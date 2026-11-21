using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002A9D RID: 10909
[NullableContext(1)]
[Nullable(0)]
public class PreloadModelNew : ModelBase
{
	// Token: 0x17002CF4 RID: 11508
	// (get) Token: 0x0601BB7E RID: 113534 RVA: 0x008892DE File Offset: 0x008874DE
	[Nullable(2)]
	public UHoldPreloadObject HoldPreloadObject
	{
		[NullableContext(2)]
		get
		{
			return this.HoldPreloadObjectInternal;
		}
	}

	// Token: 0x0601BB7F RID: 113535 RVA: 0x008892E8 File Offset: 0x008874E8
	protected override bool OnInit()
	{
		this.ProjectPath = UKismetSystemLibrary.ConvertToAbsolutePath(UBlueprintPathsLibrary.ProjectDir());
		this.JsonExportRootPath = UKismetSystemLibrary.ConvertToAbsolutePath(this.ProjectPath + "../Config/Client/Preload/");
		this.ModelConfigJsonExportPath = this.JsonExportRootPath + "ModelConfig/";
		this.SkillJsonExportPath = this.JsonExportRootPath + "SkillInfo/";
		this.CommonSkillJsonExportPath = this.JsonExportRootPath + "CommonSkillInfo/";
		this.BulletJsonExportPath = this.JsonExportRootPath + "BulletInfo/";
		this.StateMachineJsonExportPath = this.JsonExportRootPath + "EntityFsm/";
		this.HoldPreloadObjectInternal = new UHoldPreloadObject(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
		this.PreCreateEffect.RegisterTick();
		this.PreCreateEffect.Init();
		if (Info.Instance.IsPs5Platform() || CloudGameManager.Instance.IsCloudGame)
		{
			PreloadSetting.LoadAllPreloadData = true;
		}
		this.InitPbDataPreload();
		this.InitCommonSkillDataPreload();
		if (PreloadSetting.LoadAllPreloadData)
		{
			this.InitBulletDataPreload();
			this.InitModelConfigDataPreload();
			this.InitStateMachineDataPreload();
			this.InitTemplateDataPreload();
			this.InitSkillDataPreload();
		}
		this.PlotAssetManager.Init();
		this.PlotUiAssetManager.Init();
		return true;
	}

	// Token: 0x0601BB80 RID: 113536 RVA: 0x0088941C File Offset: 0x0088761C
	private void InitPbDataPreload()
	{
		IReadOnlyList<PbDataPreload> configList = ConfigPbDataPreloadAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (PbDataPreload value in configList)
			{
				if (!this.PbDataPreloadDataMap.ContainsKey(value.MapId))
				{
					this.PbDataPreloadDataMap[value.MapId] = new Dictionary<int, PbDataPreload>();
				}
				this.PbDataPreloadDataMap[value.MapId][value.PbDataId] = value;
			}
		}
	}

	// Token: 0x0601BB81 RID: 113537 RVA: 0x008894B4 File Offset: 0x008876B4
	private void InitBulletDataPreload()
	{
		foreach (BulletPreload src in ConfigBulletPreloadByAll.GetConfigList(true))
		{
			if (!this.BulletPreloadDataMap.ContainsKey(src.ActorBlueprint))
			{
				this.BulletPreloadDataMap[src.ActorBlueprint] = new Dictionary<long, PreloadSaveData>();
			}
			this.BulletPreloadDataMap[src.ActorBlueprint][src.BulletId] = this.BuildPreloadSaveData(src);
		}
	}

	// Token: 0x0601BB82 RID: 113538 RVA: 0x0088954C File Offset: 0x0088774C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public OneOf<PreloadSaveData, BulletPreload>? GetBulletPreloadData(string bpPath, long bulletId)
	{
		if (PreloadSetting.LoadAllPreloadData)
		{
			Dictionary<long, PreloadSaveData> dictionary;
			PreloadSaveData value;
			if (this.BulletPreloadDataMap.TryGetValue(bpPath, out dictionary) && dictionary.TryGetValue(bulletId, out value))
			{
				return new OneOf<PreloadSaveData, BulletPreload>?(value);
			}
			return null;
		}
		else
		{
			BulletPreload? config = ConfigBulletPreloadByActorBlueprintAndBulletId.GetConfig(bpPath, bulletId, true);
			if (config != null)
			{
				return new OneOf<PreloadSaveData, BulletPreload>?(config.Value);
			}
			return null;
		}
	}

	// Token: 0x0601BB83 RID: 113539 RVA: 0x008895C0 File Offset: 0x008877C0
	private void InitCommonSkillDataPreload()
	{
		IReadOnlyList<CommonSkillPreload> configList = ConfigCommonSkillPreloadAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (CommonSkillPreload item in configList)
			{
				this.CommonSkillPreloadDataMap = new List<CommonSkillPreload>(this.CommonSkillPreloadDataMap)
				{
					item
				}.ToArray();
			}
		}
	}

	// Token: 0x0601BB84 RID: 113540 RVA: 0x0088962C File Offset: 0x0088782C
	[NullableContext(2)]
	public CommonSkillPreload[] GetCommonSkillPreloadData()
	{
		return this.CommonSkillPreloadDataMap;
	}

	// Token: 0x0601BB85 RID: 113541 RVA: 0x00889634 File Offset: 0x00887834
	private void InitModelConfigDataPreload()
	{
		foreach (ModelConfigPreload src in ConfigModelConfigPreloadByAll.GetConfigList(true))
		{
			if (!this.ModelConfigPreloadDataMap.ContainsKey(src.Id))
			{
				PreloadModelConfigSaveData preloadModelConfigSaveData = this.BuildPreloadSaveData(src) as PreloadModelConfigSaveData;
				preloadModelConfigSaveData.ActorClassPath = src.ActorClassPath;
				this.ModelConfigPreloadDataMap[src.Id] = preloadModelConfigSaveData;
			}
		}
	}

	// Token: 0x0601BB86 RID: 113542 RVA: 0x008896BC File Offset: 0x008878BC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public OneOf<PreloadModelConfigSaveData, ModelConfigPreload>? GetModelConfigPreloadData(int modelConfigId)
	{
		if (PreloadSetting.LoadAllPreloadData)
		{
			PreloadModelConfigSaveData value;
			if (this.ModelConfigPreloadDataMap.TryGetValue(modelConfigId, out value))
			{
				return new OneOf<PreloadModelConfigSaveData, ModelConfigPreload>?(value);
			}
			return null;
		}
		else
		{
			ModelConfigPreload? config = ConfigModelConfigPreloadById.GetConfig(modelConfigId, true);
			if (config != null)
			{
				return new OneOf<PreloadModelConfigSaveData, ModelConfigPreload>?(config.Value);
			}
			return null;
		}
	}

	// Token: 0x0601BB87 RID: 113543 RVA: 0x00889724 File Offset: 0x00887924
	private void InitStateMachineDataPreload()
	{
		foreach (StateMachinePreload src in ConfigStateMachinePreloadByAll.GetConfigList(true))
		{
			if (!this.StateMachinePreloadDataMap.ContainsKey(src.FsmKey))
			{
				this.StateMachinePreloadDataMap[src.FsmKey] = this.BuildPreloadSaveData(src);
			}
		}
	}

	// Token: 0x0601BB88 RID: 113544 RVA: 0x00889798 File Offset: 0x00887998
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public OneOf<PreloadSaveData, StateMachinePreload>? GetStateMachinePreloadData(string fsmKey)
	{
		if (PreloadSetting.LoadAllPreloadData)
		{
			PreloadSaveData value;
			if (this.StateMachinePreloadDataMap.TryGetValue(fsmKey, out value))
			{
				return new OneOf<PreloadSaveData, StateMachinePreload>?(value);
			}
			return null;
		}
		else
		{
			StateMachinePreload? config = ConfigStateMachinePreloadByFsmKey.GetConfig(fsmKey, true);
			if (config != null)
			{
				return new OneOf<PreloadSaveData, StateMachinePreload>?(config.Value);
			}
			return null;
		}
	}

	// Token: 0x0601BB89 RID: 113545 RVA: 0x00889800 File Offset: 0x00887A00
	private void InitTemplateDataPreload()
	{
		foreach (TemplateDataPreload src in ConfigTemplateDataPreloadByAll.GetConfigList(true))
		{
			if (!this.TemplatePreloadDataMap.ContainsKey(src.Id))
			{
				this.TemplatePreloadDataMap[src.Id] = this.BuildPreloadSaveData(src);
			}
		}
	}

	// Token: 0x0601BB8A RID: 113546 RVA: 0x00889874 File Offset: 0x00887A74
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public OneOf<PreloadSaveData, TemplateDataPreload>? GetTemplatePreloadData(int templateId)
	{
		if (PreloadSetting.LoadAllPreloadData)
		{
			PreloadSaveData value;
			if (this.TemplatePreloadDataMap.TryGetValue(templateId, out value))
			{
				return new OneOf<PreloadSaveData, TemplateDataPreload>?(value);
			}
			return null;
		}
		else
		{
			TemplateDataPreload? config = ConfigTemplateDataPreloadById.GetConfig(templateId, true);
			if (config != null)
			{
				return new OneOf<PreloadSaveData, TemplateDataPreload>?(config.Value);
			}
			return null;
		}
	}

	// Token: 0x0601BB8B RID: 113547 RVA: 0x008898DC File Offset: 0x00887ADC
	private void InitSkillDataPreload()
	{
		foreach (EntitySkillPreload src in ConfigEntitySkillPreloadByAll.GetConfigList(true))
		{
			PreloadSkillSaveData preloadSkillSaveData = this.BuildPreloadSaveData(src) as PreloadSkillSaveData;
			preloadSkillSaveData.SkillId = src.SkillId;
			preloadSkillSaveData.ActorBlueprint = src.ActorBlueprint;
			preloadSkillSaveData.LoadType = src.LoadType;
			preloadSkillSaveData.IsCommon = src.IsCommon;
			preloadSkillSaveData.HasMontagePath = src.HasMontagePath;
			List<PreloadSkillSaveData> list;
			if (this.SkillPreloadDataMap.TryGetValue(src.ActorBlueprint, out list))
			{
				list.Add(preloadSkillSaveData);
			}
			else
			{
				list = new List<PreloadSkillSaveData>();
				list.Add(preloadSkillSaveData);
				this.SkillPreloadDataMap[src.ActorBlueprint] = list;
			}
		}
	}

	// Token: 0x0601BB8C RID: 113548 RVA: 0x008899B8 File Offset: 0x00887BB8
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>? GetSkillPreloadData(string bpPath)
	{
		if (PreloadSetting.LoadAllPreloadData)
		{
			List<PreloadSkillSaveData> value;
			if (this.SkillPreloadDataMap.TryGetValue(bpPath, out value))
			{
				return new OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>?(value);
			}
			return null;
		}
		else
		{
			IReadOnlyList<EntitySkillPreload> configList = ConfigEntitySkillPreloadByActorBlueprint.GetConfigList(bpPath, true);
			if (configList != null)
			{
				return new OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>?(new OneOf<List<PreloadSkillSaveData>, IReadOnlyList<EntitySkillPreload>>(configList));
			}
			return null;
		}
	}

	// Token: 0x0601BB8D RID: 113549 RVA: 0x00889A14 File Offset: 0x00887C14
	private PreloadSaveData BuildPreloadSaveData(BulletPreload src)
	{
		PreloadSaveData preloadSaveData = new PreloadSaveData();
		if (src.ActorClassLength > 0)
		{
			for (int i = 0; i < src.ActorClassLength; i++)
			{
				preloadSaveData.Others.Add(src.ActorClass(i));
			}
		}
		if (src.AnimationsLength > 0)
		{
			if (preloadSaveData.Animations == null)
			{
				preloadSaveData.Animations = new List<string>();
			}
			preloadSaveData.Animations.Clear();
			for (int j = 0; j < src.AnimationsLength; j++)
			{
				preloadSaveData.Animations.Add(src.Animations(j));
			}
		}
		if (src.EffectsLength > 0)
		{
			for (int k = 0; k < src.EffectsLength; k++)
			{
				preloadSaveData.Others.Add(src.Effects(k));
			}
		}
		if (src.AudiosLength > 0)
		{
			for (int l = 0; l < src.AudiosLength; l++)
			{
				preloadSaveData.Others.Add(src.Audios(l));
			}
		}
		if (src.MaterialsLength > 0)
		{
			for (int m = 0; m < src.MaterialsLength; m++)
			{
				preloadSaveData.Others.Add(src.Materials(m));
			}
		}
		if (src.MeshesLength > 0)
		{
			for (int n = 0; n < src.MeshesLength; n++)
			{
				preloadSaveData.Others.Add(src.Meshes(n));
			}
		}
		if (src.AnimationBlueprintsLength > 0)
		{
			for (int num = 0; num < src.AnimationBlueprintsLength; num++)
			{
				preloadSaveData.Others.Add(src.AnimationBlueprints(num));
			}
		}
		if (src.OthersLength > 0)
		{
			for (int num2 = 0; num2 < src.OthersLength; num2++)
			{
				preloadSaveData.Others.Add(src.Others(num2));
			}
		}
		return preloadSaveData;
	}

	// Token: 0x0601BB8E RID: 113550 RVA: 0x00889BD8 File Offset: 0x00887DD8
	private PreloadSaveData BuildPreloadSaveData(EntitySkillPreload src)
	{
		PreloadSkillSaveData preloadSkillSaveData = new PreloadSkillSaveData();
		if (src.ActorClassLength > 0)
		{
			for (int i = 0; i < src.ActorClassLength; i++)
			{
				preloadSkillSaveData.Others.Add(src.ActorClass(i));
			}
		}
		if (src.AnimationsLength > 0)
		{
			if (preloadSkillSaveData.Animations == null)
			{
				preloadSkillSaveData.Animations = new List<string>();
			}
			preloadSkillSaveData.Animations.Clear();
			for (int j = 0; j < src.AnimationsLength; j++)
			{
				preloadSkillSaveData.Animations.Add(src.Animations(j));
			}
		}
		if (src.EffectsLength > 0)
		{
			for (int k = 0; k < src.EffectsLength; k++)
			{
				preloadSkillSaveData.Others.Add(src.Effects(k));
			}
		}
		if (src.AudiosLength > 0)
		{
			for (int l = 0; l < src.AudiosLength; l++)
			{
				preloadSkillSaveData.Others.Add(src.Audios(l));
			}
		}
		if (src.MaterialsLength > 0)
		{
			for (int m = 0; m < src.MaterialsLength; m++)
			{
				preloadSkillSaveData.Others.Add(src.Materials(m));
			}
		}
		if (src.MeshesLength > 0)
		{
			for (int n = 0; n < src.MeshesLength; n++)
			{
				preloadSkillSaveData.Others.Add(src.Meshes(n));
			}
		}
		if (src.AnimationBlueprintsLength > 0)
		{
			for (int num = 0; num < src.AnimationBlueprintsLength; num++)
			{
				preloadSkillSaveData.Others.Add(src.AnimationBlueprints(num));
			}
		}
		if (src.OthersLength > 0)
		{
			for (int num2 = 0; num2 < src.OthersLength; num2++)
			{
				preloadSkillSaveData.Others.Add(src.Others(num2));
			}
		}
		return preloadSkillSaveData;
	}

	// Token: 0x0601BB8F RID: 113551 RVA: 0x00889D9C File Offset: 0x00887F9C
	private PreloadSaveData BuildPreloadSaveData(TemplateDataPreload src)
	{
		PreloadSaveData preloadSaveData = new PreloadSaveData();
		if (src.ActorClassLength > 0)
		{
			for (int i = 0; i < src.ActorClassLength; i++)
			{
				preloadSaveData.Others.Add(src.ActorClass(i));
			}
		}
		if (src.AnimationsLength > 0)
		{
			if (preloadSaveData.Animations == null)
			{
				preloadSaveData.Animations = new List<string>();
			}
			preloadSaveData.Animations.Clear();
			for (int j = 0; j < src.AnimationsLength; j++)
			{
				preloadSaveData.Animations.Add(src.Animations(j));
			}
		}
		if (src.EffectsLength > 0)
		{
			for (int k = 0; k < src.EffectsLength; k++)
			{
				preloadSaveData.Others.Add(src.Effects(k));
			}
		}
		if (src.AudiosLength > 0)
		{
			for (int l = 0; l < src.AudiosLength; l++)
			{
				preloadSaveData.Others.Add(src.Audios(l));
			}
		}
		if (src.MaterialsLength > 0)
		{
			for (int m = 0; m < src.MaterialsLength; m++)
			{
				preloadSaveData.Others.Add(src.Materials(m));
			}
		}
		if (src.MeshesLength > 0)
		{
			for (int n = 0; n < src.MeshesLength; n++)
			{
				preloadSaveData.Others.Add(src.Meshes(n));
			}
		}
		if (src.AnimationBlueprintsLength > 0)
		{
			for (int num = 0; num < src.AnimationBlueprintsLength; num++)
			{
				preloadSaveData.Others.Add(src.AnimationBlueprints(num));
			}
		}
		if (src.OthersLength > 0)
		{
			for (int num2 = 0; num2 < src.OthersLength; num2++)
			{
				preloadSaveData.Others.Add(src.Others(num2));
			}
		}
		return preloadSaveData;
	}

	// Token: 0x0601BB90 RID: 113552 RVA: 0x00889F60 File Offset: 0x00888160
	private PreloadSaveData BuildPreloadSaveData(StateMachinePreload src)
	{
		PreloadSaveData preloadSaveData = new PreloadSaveData();
		if (src.ActorClassLength > 0)
		{
			for (int i = 0; i < src.ActorClassLength; i++)
			{
				preloadSaveData.Others.Add(src.ActorClass(i));
			}
		}
		if (src.AnimationsLength > 0)
		{
			if (preloadSaveData.Animations == null)
			{
				preloadSaveData.Animations = new List<string>();
			}
			preloadSaveData.Animations.Clear();
			for (int j = 0; j < src.AnimationsLength; j++)
			{
				preloadSaveData.Animations.Add(src.Animations(j));
			}
		}
		if (src.EffectsLength > 0)
		{
			for (int k = 0; k < src.EffectsLength; k++)
			{
				preloadSaveData.Others.Add(src.Effects(k));
			}
		}
		if (src.AudiosLength > 0)
		{
			for (int l = 0; l < src.AudiosLength; l++)
			{
				preloadSaveData.Others.Add(src.Audios(l));
			}
		}
		if (src.MaterialsLength > 0)
		{
			for (int m = 0; m < src.MaterialsLength; m++)
			{
				preloadSaveData.Others.Add(src.Materials(m));
			}
		}
		if (src.MeshesLength > 0)
		{
			for (int n = 0; n < src.MeshesLength; n++)
			{
				preloadSaveData.Others.Add(src.Meshes(n));
			}
		}
		if (src.AnimationBlueprintsLength > 0)
		{
			for (int num = 0; num < src.AnimationBlueprintsLength; num++)
			{
				preloadSaveData.Others.Add(src.AnimationBlueprints(num));
			}
		}
		if (src.OthersLength > 0)
		{
			for (int num2 = 0; num2 < src.OthersLength; num2++)
			{
				preloadSaveData.Others.Add(src.Others(num2));
			}
		}
		return preloadSaveData;
	}

	// Token: 0x0601BB91 RID: 113553 RVA: 0x0088A124 File Offset: 0x00888324
	private PreloadSaveData BuildPreloadSaveData(ModelConfigPreload src)
	{
		PreloadModelConfigSaveData preloadModelConfigSaveData = new PreloadModelConfigSaveData();
		if (src.ActorClassLength > 0)
		{
			for (int i = 0; i < src.ActorClassLength; i++)
			{
				preloadModelConfigSaveData.Others.Add(src.ActorClass(i));
			}
		}
		if (src.AnimationsLength > 0)
		{
			if (preloadModelConfigSaveData.Animations == null)
			{
				preloadModelConfigSaveData.Animations = new List<string>();
			}
			preloadModelConfigSaveData.Animations.Clear();
			for (int j = 0; j < src.AnimationsLength; j++)
			{
				preloadModelConfigSaveData.Animations.Add(src.Animations(j));
			}
		}
		if (src.EffectsLength > 0)
		{
			for (int k = 0; k < src.EffectsLength; k++)
			{
				preloadModelConfigSaveData.Others.Add(src.Effects(k));
			}
		}
		if (src.AudiosLength > 0)
		{
			for (int l = 0; l < src.AudiosLength; l++)
			{
				preloadModelConfigSaveData.Others.Add(src.Audios(l));
			}
		}
		if (src.MaterialsLength > 0)
		{
			for (int m = 0; m < src.MaterialsLength; m++)
			{
				preloadModelConfigSaveData.Others.Add(src.Materials(m));
			}
		}
		if (src.MeshesLength > 0)
		{
			for (int n = 0; n < src.MeshesLength; n++)
			{
				preloadModelConfigSaveData.Others.Add(src.Meshes(n));
			}
		}
		if (src.AnimationBlueprintsLength > 0)
		{
			for (int num = 0; num < src.AnimationBlueprintsLength; num++)
			{
				preloadModelConfigSaveData.Others.Add(src.AnimationBlueprints(num));
			}
		}
		if (src.OthersLength > 0)
		{
			for (int num2 = 0; num2 < src.OthersLength; num2++)
			{
				preloadModelConfigSaveData.Others.Add(src.Others(num2));
			}
		}
		return preloadModelConfigSaveData;
	}

	// Token: 0x0601BB92 RID: 113554 RVA: 0x0088A2E8 File Offset: 0x008884E8
	private PreloadSaveData BuildPreloadSaveData(IDbAssetElement src)
	{
		PreloadSaveData preloadSaveData = new PreloadSaveData();
		if (src.ActorClass.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.ActorClass);
		}
		if (src.Animations.Count > 0)
		{
			preloadSaveData.Animations = new List<string>(src.Animations);
		}
		if (src.Effects.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.Effects);
		}
		if (src.Audios.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.Audios);
		}
		if (src.Materials.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.Materials);
		}
		if (src.Meshes.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.Meshes);
		}
		if (src.AnimationBlueprints.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.AnimationBlueprints);
		}
		if (src.Others.Count > 0)
		{
			preloadSaveData.Others.AddRange(src.Others);
		}
		return preloadSaveData;
	}

	// Token: 0x0601BB93 RID: 113555 RVA: 0x0088A3F4 File Offset: 0x008885F4
	protected override bool OnClear()
	{
		UHoldPreloadObject holdPreloadObjectInternal = this.HoldPreloadObjectInternal;
		if (holdPreloadObjectInternal != null)
		{
			holdPreloadObjectInternal.Clear();
		}
		UHoldPreloadObject holdPreloadObjectInternal2 = this.HoldPreloadObjectInternal;
		if (holdPreloadObjectInternal2 != null && holdPreloadObjectInternal2.IsValid())
		{
			this.HoldPreloadObjectInternal.Clear();
		}
		this.HoldPreloadObjectInternal = null;
		this.PreCreateEffect.UnregisterTick();
		this.PreCreateEffect.Clear();
		this.CommonSkillMap.Clear();
		this.PlotAssetManager.Clear();
		this.PlotUiAssetManager.Clear();
		return true;
	}

	// Token: 0x0601BB94 RID: 113556 RVA: 0x0088A470 File Offset: 0x00888670
	public void AddPreloadResource(string path)
	{
		if (this.PreloadAssetMap.ContainsKey(path))
		{
			int num = this.PreloadAssetMap[path];
			this.PreloadAssetMap[path] = num + 1;
			return;
		}
		this.PreloadAssetMap[path] = 1;
	}

	// Token: 0x0601BB95 RID: 113557 RVA: 0x0088A4B8 File Offset: 0x008886B8
	public bool RemovePreloadResource(string path)
	{
		if (!this.PreloadAssetMap.ContainsKey(path))
		{
			return false;
		}
		int num = this.PreloadAssetMap[path];
		if (num > 0)
		{
			num--;
			this.PreloadAssetMap[path] = num;
		}
		if (num == 0)
		{
			this.PreloadAssetMap.Remove(path);
		}
		return true;
	}

	// Token: 0x0601BB96 RID: 113558 RVA: 0x0088A508 File Offset: 0x00888708
	public void ClearPreloadResource()
	{
		this.PreloadAssetMap.Clear();
		this.HoldPreloadObjectInternal.Clear();
		this.LoadingNeedWaitEntitySet.Clear();
	}

	// Token: 0x0601BB97 RID: 113559 RVA: 0x0088A52B File Offset: 0x0088872B
	public bool AddEntityAsset(long creatureDataId, EntityAssetElement entityAsset)
	{
		if (this.AllEntityAssetMap.ContainsKey(creatureDataId))
		{
			return false;
		}
		this.AllEntityAssetMap[creatureDataId] = entityAsset;
		return true;
	}

	// Token: 0x0601BB98 RID: 113560 RVA: 0x0088A54B File Offset: 0x0088874B
	public bool HasEntityAsset(long creatureDataId)
	{
		return this.AllEntityAssetMap.ContainsKey(creatureDataId);
	}

	// Token: 0x0601BB99 RID: 113561 RVA: 0x0088A559 File Offset: 0x00888759
	[NullableContext(2)]
	public EntityAssetElement GetEntityAssetElement(long creatureDataId)
	{
		return this.AllEntityAssetMap.GetValueOrDefault(creatureDataId);
	}

	// Token: 0x0601BB9A RID: 113562 RVA: 0x0088A567 File Offset: 0x00888767
	public bool RemoveEntityAsset(long creatureDataId)
	{
		return this.AllEntityAssetMap.Remove(creatureDataId);
	}

	// Token: 0x0601BB9B RID: 113563 RVA: 0x0088A575 File Offset: 0x00888775
	public void ClearEntityAsset()
	{
		this.AllEntityAssetMap.Clear();
	}

	// Token: 0x0601BB9C RID: 113564 RVA: 0x0088A582 File Offset: 0x00888782
	public bool AddPbEntityAsset(int pbDataId, PbEntityAssetElement entityAsset)
	{
		if (this.AllPbEntityAssetMap.ContainsKey(pbDataId))
		{
			return false;
		}
		this.AllPbEntityAssetMap[pbDataId] = entityAsset;
		return true;
	}

	// Token: 0x0601BB9D RID: 113565 RVA: 0x0088A5A2 File Offset: 0x008887A2
	public bool HasPbEntityAsset(int pbDataId)
	{
		return this.AllPbEntityAssetMap.ContainsKey(pbDataId);
	}

	// Token: 0x0601BB9E RID: 113566 RVA: 0x0088A5B0 File Offset: 0x008887B0
	[NullableContext(2)]
	public PbEntityAssetElement GetPbEntityAssetElement(int pbDataId)
	{
		return this.AllPbEntityAssetMap.GetValueOrDefault(pbDataId);
	}

	// Token: 0x0601BB9F RID: 113567 RVA: 0x0088A5BE File Offset: 0x008887BE
	public bool RemovePbEntityAsset(int pbDataId)
	{
		return this.AllPbEntityAssetMap.Remove(pbDataId);
	}

	// Token: 0x0601BBA0 RID: 113568 RVA: 0x0088A5CC File Offset: 0x008887CC
	public void ClearPbEntityAsset()
	{
		foreach (KeyValuePair<int, PbEntityAssetElement> keyValuePair in this.AllPbEntityAssetMap)
		{
			keyValuePair.Value.Clear();
		}
		this.AllPbEntityAssetMap.Clear();
	}

	// Token: 0x0601BBA1 RID: 113569 RVA: 0x0088A630 File Offset: 0x00888830
	public void CleanPlotAsset()
	{
		this.PlotAssetManager.RemoveAllPreload();
	}

	// Token: 0x0601BBA2 RID: 113570 RVA: 0x0088A63D File Offset: 0x0088883D
	public void AddNeedWaitEntity(int entityId)
	{
		this.LoadingNeedWaitEntitySet.Add(entityId);
	}

	// Token: 0x0601BBA3 RID: 113571 RVA: 0x0088A64C File Offset: 0x0088884C
	public void RemoveNeedWaitEntity(int entityId)
	{
		this.LoadingNeedWaitEntitySet.Remove(entityId);
	}

	// Token: 0x0601BBA4 RID: 113572 RVA: 0x0088A65C File Offset: 0x0088885C
	public bool AddCommonSkill(int skillId, bool hasMontage, AssetElement assetElement)
	{
		if (this.CommonSkillMap.ContainsKey((long)skillId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "[预加载] 重复添加技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.CommonSkillMap[(long)skillId] = new ValueTuple<bool, AssetElement>(hasMontage, assetElement);
		return true;
	}

	// Token: 0x0601BBA5 RID: 113573 RVA: 0x0088A6BA File Offset: 0x008888BA
	public bool IsCommonSkill(int skillId)
	{
		return this.CommonSkillMap.ContainsKey((long)skillId);
	}

	// Token: 0x0601BBA6 RID: 113574 RVA: 0x0088A6CC File Offset: 0x008888CC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, AssetElement>? GetCommonSkill(int skillId)
	{
		ValueTuple<bool, AssetElement> value;
		if (this.CommonSkillMap.TryGetValue((long)skillId, out value))
		{
			return new ValueTuple<bool, AssetElement>?(value);
		}
		return null;
	}

	// Token: 0x0601BBA7 RID: 113575 RVA: 0x0088A6FA File Offset: 0x008888FA
	public void AddResourcesLoadTime([Nullable(new byte[]
	{
		0,
		1
	})] ValueTuple<string, int> loadTime)
	{
		this.ResourcesLoadTime.Add(loadTime);
	}

	// Token: 0x0601BBA8 RID: 113576 RVA: 0x0088A708 File Offset: 0x00888908
	public void ClearResourcesLoadTime()
	{
		this.ResourcesLoadTime.Clear();
	}

	// Token: 0x17002CF5 RID: 11509
	// (get) Token: 0x0601BBA9 RID: 113577 RVA: 0x0088A715 File Offset: 0x00888915
	public static PreloadModelNew Instance
	{
		get
		{
			return PreloadModelNew._Instance;
		}
	}

	// Token: 0x0601BBAA RID: 113578 RVA: 0x0088A71C File Offset: 0x0088891C
	public static PreloadModelNew GetOrCreateInstance()
	{
		if (PreloadModelNew._Instance == null)
		{
			PreloadModelNew.CreateInstance();
		}
		return PreloadModelNew._Instance;
	}

	// Token: 0x0601BBAB RID: 113579 RVA: 0x0088A730 File Offset: 0x00888930
	public static bool CreateInstance()
	{
		if (PreloadModelNew._Instance != null)
		{
			return true;
		}
		PreloadModelNew._Instance = new PreloadModelNew();
		return true;
	}

	// Token: 0x0601BBAC RID: 113580 RVA: 0x0088A746 File Offset: 0x00888946
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BBAD RID: 113581 RVA: 0x0088A748 File Offset: 0x00888948
	public static void ResetStaticDefaultValue()
	{
		PreloadModelNew._Instance = null;
	}

	// Token: 0x0601BBAE RID: 113582 RVA: 0x0088A750 File Offset: 0x00888950
	static PreloadModelNew()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreloadModelNew.CreateStaticDefaultValue), new Action(PreloadModelNew.ResetStaticDefaultValue));
	}

	// Token: 0x0400EF7B RID: 61307
	public bool EnablePreloadLog;

	// Token: 0x0400EF7C RID: 61308
	[Nullable(2)]
	public string ProjectPath;

	// Token: 0x0400EF7D RID: 61309
	[Nullable(2)]
	public string JsonExportRootPath;

	// Token: 0x0400EF7E RID: 61310
	[Nullable(2)]
	public string ModelConfigJsonExportPath;

	// Token: 0x0400EF7F RID: 61311
	[Nullable(2)]
	public string SkillJsonExportPath;

	// Token: 0x0400EF80 RID: 61312
	[Nullable(2)]
	public string CommonSkillJsonExportPath;

	// Token: 0x0400EF81 RID: 61313
	[Nullable(2)]
	public string BulletJsonExportPath;

	// Token: 0x0400EF82 RID: 61314
	[Nullable(2)]
	public string StateMachineJsonExportPath;

	// Token: 0x0400EF83 RID: 61315
	public readonly PreCreateEffect PreCreateEffect = new PreCreateEffect();

	// Token: 0x0400EF84 RID: 61316
	public readonly CommonAssetElement CommonAssetElement = new CommonAssetElement(null);

	// Token: 0x0400EF85 RID: 61317
	public readonly Dictionary<string, int> PreloadAssetMap = new Dictionary<string, int>();

	// Token: 0x0400EF86 RID: 61318
	public readonly Dictionary<int, Dictionary<int, PbDataPreload>> PbDataPreloadDataMap = new Dictionary<int, Dictionary<int, PbDataPreload>>();

	// Token: 0x0400EF87 RID: 61319
	public readonly Dictionary<long, EntityAssetElement> AllEntityAssetMap = new Dictionary<long, EntityAssetElement>();

	// Token: 0x0400EF88 RID: 61320
	public readonly Dictionary<int, PbEntityAssetElement> AllPbEntityAssetMap = new Dictionary<int, PbEntityAssetElement>();

	// Token: 0x0400EF89 RID: 61321
	public readonly PlotAssetManager PlotAssetManager = new PlotAssetManager();

	// Token: 0x0400EF8A RID: 61322
	public readonly PlotUiAssetManager PlotUiAssetManager = new PlotUiAssetManager();

	// Token: 0x0400EF8B RID: 61323
	[TupleElementNames(new string[]
	{
		"hasMontage",
		"assetElement"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly Dictionary<long, ValueTuple<bool, AssetElement>> CommonSkillMap = new Dictionary<long, ValueTuple<bool, AssetElement>>();

	// Token: 0x0400EF8C RID: 61324
	[Nullable(2)]
	private UHoldPreloadObject HoldPreloadObjectInternal;

	// Token: 0x0400EF8D RID: 61325
	public readonly Dictionary<string, Dictionary<long, PreloadSaveData>> BulletPreloadDataMap = new Dictionary<string, Dictionary<long, PreloadSaveData>>();

	// Token: 0x0400EF8E RID: 61326
	public CommonSkillPreload[] CommonSkillPreloadDataMap = Array.Empty<CommonSkillPreload>();

	// Token: 0x0400EF8F RID: 61327
	public readonly Dictionary<int, PreloadModelConfigSaveData> ModelConfigPreloadDataMap = new Dictionary<int, PreloadModelConfigSaveData>();

	// Token: 0x0400EF90 RID: 61328
	public readonly Dictionary<string, PreloadSaveData> StateMachinePreloadDataMap = new Dictionary<string, PreloadSaveData>();

	// Token: 0x0400EF91 RID: 61329
	public readonly Dictionary<int, PreloadSaveData> TemplatePreloadDataMap = new Dictionary<int, PreloadSaveData>();

	// Token: 0x0400EF92 RID: 61330
	public readonly Dictionary<string, List<PreloadSkillSaveData>> SkillPreloadDataMap = new Dictionary<string, List<PreloadSkillSaveData>>();

	// Token: 0x0400EF93 RID: 61331
	public readonly HashSet<int> LoadingNeedWaitEntitySet = new HashSet<int>();

	// Token: 0x0400EF94 RID: 61332
	public bool UseEntityProfilerInternal = true;

	// Token: 0x0400EF95 RID: 61333
	public bool LoadAssetOneByOneState;

	// Token: 0x0400EF96 RID: 61334
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<string, int>> ResourcesLoadTime = new List<ValueTuple<string, int>>();

	// Token: 0x0400EF97 RID: 61335
	[Nullable(2)]
	private static PreloadModelNew _Instance;
}
