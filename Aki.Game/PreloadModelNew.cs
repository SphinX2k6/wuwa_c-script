using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02003528 RID: 13608
[NullableContext(1)]
[Nullable(0)]
public class PreloadModelNew : ModelBase
{
	// Token: 0x1700295B RID: 10587
	// (get) Token: 0x0601DE56 RID: 122454 RVA: 0x008616A6 File Offset: 0x0085F8A6
	[Nullable(2)]
	public UHoldPreloadObject HoldPreloadObject
	{
		[NullableContext(2)]
		get
		{
			return this.HoldPreloadObjectInternal;
		}
	}

	// Token: 0x0601DE57 RID: 122455 RVA: 0x008616B0 File Offset: 0x0085F8B0
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

	// Token: 0x0601DE58 RID: 122456 RVA: 0x008617E4 File Offset: 0x0085F9E4
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

	// Token: 0x0601DE59 RID: 122457 RVA: 0x0086187C File Offset: 0x0085FA7C
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

	// Token: 0x0601DE5A RID: 122458 RVA: 0x00861914 File Offset: 0x0085FB14
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

	// Token: 0x0601DE5B RID: 122459 RVA: 0x00861988 File Offset: 0x0085FB88
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

	// Token: 0x0601DE5C RID: 122460 RVA: 0x008619F4 File Offset: 0x0085FBF4
	[NullableContext(2)]
	public CommonSkillPreload[] GetCommonSkillPreloadData()
	{
		return this.CommonSkillPreloadDataMap;
	}

	// Token: 0x0601DE5D RID: 122461 RVA: 0x008619FC File Offset: 0x0085FBFC
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

	// Token: 0x0601DE5E RID: 122462 RVA: 0x00861A84 File Offset: 0x0085FC84
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

	// Token: 0x0601DE5F RID: 122463 RVA: 0x00861AEC File Offset: 0x0085FCEC
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

	// Token: 0x0601DE60 RID: 122464 RVA: 0x00861B60 File Offset: 0x0085FD60
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

	// Token: 0x0601DE61 RID: 122465 RVA: 0x00861BC8 File Offset: 0x0085FDC8
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

	// Token: 0x0601DE62 RID: 122466 RVA: 0x00861C3C File Offset: 0x0085FE3C
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

	// Token: 0x0601DE63 RID: 122467 RVA: 0x00861CA4 File Offset: 0x0085FEA4
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

	// Token: 0x0601DE64 RID: 122468 RVA: 0x00861D80 File Offset: 0x0085FF80
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

	// Token: 0x0601DE65 RID: 122469 RVA: 0x00861DDC File Offset: 0x0085FFDC
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

	// Token: 0x0601DE66 RID: 122470 RVA: 0x00861FA0 File Offset: 0x008601A0
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

	// Token: 0x0601DE67 RID: 122471 RVA: 0x00862164 File Offset: 0x00860364
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

	// Token: 0x0601DE68 RID: 122472 RVA: 0x00862328 File Offset: 0x00860528
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

	// Token: 0x0601DE69 RID: 122473 RVA: 0x008624EC File Offset: 0x008606EC
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

	// Token: 0x0601DE6A RID: 122474 RVA: 0x008626B0 File Offset: 0x008608B0
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

	// Token: 0x0601DE6B RID: 122475 RVA: 0x008627BC File Offset: 0x008609BC
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

	// Token: 0x0601DE6C RID: 122476 RVA: 0x00862838 File Offset: 0x00860A38
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

	// Token: 0x0601DE6D RID: 122477 RVA: 0x00862880 File Offset: 0x00860A80
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

	// Token: 0x0601DE6E RID: 122478 RVA: 0x008628D0 File Offset: 0x00860AD0
	public void ClearPreloadResource()
	{
		this.PreloadAssetMap.Clear();
		this.HoldPreloadObjectInternal.Clear();
		this.LoadingNeedWaitEntitySet.Clear();
	}

	// Token: 0x0601DE6F RID: 122479 RVA: 0x008628F3 File Offset: 0x00860AF3
	public bool AddEntityAsset(long creatureDataId, EntityAssetElement entityAsset)
	{
		if (this.AllEntityAssetMap.ContainsKey(creatureDataId))
		{
			return false;
		}
		this.AllEntityAssetMap[creatureDataId] = entityAsset;
		return true;
	}

	// Token: 0x0601DE70 RID: 122480 RVA: 0x00862913 File Offset: 0x00860B13
	public bool HasEntityAsset(long creatureDataId)
	{
		return this.AllEntityAssetMap.ContainsKey(creatureDataId);
	}

	// Token: 0x0601DE71 RID: 122481 RVA: 0x00862921 File Offset: 0x00860B21
	[NullableContext(2)]
	public EntityAssetElement GetEntityAssetElement(long creatureDataId)
	{
		return this.AllEntityAssetMap.GetValueOrDefault(creatureDataId);
	}

	// Token: 0x0601DE72 RID: 122482 RVA: 0x0086292F File Offset: 0x00860B2F
	public bool RemoveEntityAsset(long creatureDataId)
	{
		return this.AllEntityAssetMap.Remove(creatureDataId);
	}

	// Token: 0x0601DE73 RID: 122483 RVA: 0x0086293D File Offset: 0x00860B3D
	public void ClearEntityAsset()
	{
		this.AllEntityAssetMap.Clear();
	}

	// Token: 0x0601DE74 RID: 122484 RVA: 0x0086294A File Offset: 0x00860B4A
	public bool AddPbEntityAsset(int pbDataId, PbEntityAssetElement entityAsset)
	{
		if (this.AllPbEntityAssetMap.ContainsKey(pbDataId))
		{
			return false;
		}
		this.AllPbEntityAssetMap[pbDataId] = entityAsset;
		return true;
	}

	// Token: 0x0601DE75 RID: 122485 RVA: 0x0086296A File Offset: 0x00860B6A
	public bool HasPbEntityAsset(int pbDataId)
	{
		return this.AllPbEntityAssetMap.ContainsKey(pbDataId);
	}

	// Token: 0x0601DE76 RID: 122486 RVA: 0x00862978 File Offset: 0x00860B78
	[NullableContext(2)]
	public PbEntityAssetElement GetPbEntityAssetElement(int pbDataId)
	{
		return this.AllPbEntityAssetMap.GetValueOrDefault(pbDataId);
	}

	// Token: 0x0601DE77 RID: 122487 RVA: 0x00862986 File Offset: 0x00860B86
	public bool RemovePbEntityAsset(int pbDataId)
	{
		return this.AllPbEntityAssetMap.Remove(pbDataId);
	}

	// Token: 0x0601DE78 RID: 122488 RVA: 0x00862994 File Offset: 0x00860B94
	public void ClearPbEntityAsset()
	{
		foreach (KeyValuePair<int, PbEntityAssetElement> keyValuePair in this.AllPbEntityAssetMap)
		{
			keyValuePair.Value.Clear();
		}
		this.AllPbEntityAssetMap.Clear();
	}

	// Token: 0x0601DE79 RID: 122489 RVA: 0x008629F8 File Offset: 0x00860BF8
	public void CleanPlotAsset()
	{
		this.PlotAssetManager.RemoveAllPreload();
	}

	// Token: 0x0601DE7A RID: 122490 RVA: 0x00862A05 File Offset: 0x00860C05
	public void AddNeedWaitEntity(int entityId)
	{
		this.LoadingNeedWaitEntitySet.Add(entityId);
	}

	// Token: 0x0601DE7B RID: 122491 RVA: 0x00862A14 File Offset: 0x00860C14
	public void RemoveNeedWaitEntity(int entityId)
	{
		this.LoadingNeedWaitEntitySet.Remove(entityId);
	}

	// Token: 0x0601DE7C RID: 122492 RVA: 0x00862A24 File Offset: 0x00860C24
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

	// Token: 0x0601DE7D RID: 122493 RVA: 0x00862A82 File Offset: 0x00860C82
	public bool IsCommonSkill(int skillId)
	{
		return this.CommonSkillMap.ContainsKey((long)skillId);
	}

	// Token: 0x0601DE7E RID: 122494 RVA: 0x00862A94 File Offset: 0x00860C94
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

	// Token: 0x0601DE7F RID: 122495 RVA: 0x00862AC2 File Offset: 0x00860CC2
	public void AddResourcesLoadTime([Nullable(new byte[]
	{
		0,
		1
	})] ValueTuple<string, int> loadTime)
	{
		this.ResourcesLoadTime.Add(loadTime);
	}

	// Token: 0x0601DE80 RID: 122496 RVA: 0x00862AD0 File Offset: 0x00860CD0
	public void ClearResourcesLoadTime()
	{
		this.ResourcesLoadTime.Clear();
	}

	// Token: 0x1700295C RID: 10588
	// (get) Token: 0x0601DE81 RID: 122497 RVA: 0x00862ADD File Offset: 0x00860CDD
	public static PreloadModelNew Instance
	{
		get
		{
			return PreloadModelNew._Instance;
		}
	}

	// Token: 0x0601DE82 RID: 122498 RVA: 0x00862AE4 File Offset: 0x00860CE4
	public static PreloadModelNew GetOrCreateInstance()
	{
		if (PreloadModelNew._Instance == null)
		{
			PreloadModelNew.CreateInstance();
		}
		return PreloadModelNew._Instance;
	}

	// Token: 0x0601DE83 RID: 122499 RVA: 0x00862AF8 File Offset: 0x00860CF8
	public static bool CreateInstance()
	{
		if (PreloadModelNew._Instance != null)
		{
			return true;
		}
		PreloadModelNew._Instance = new PreloadModelNew();
		return true;
	}

	// Token: 0x0601DE84 RID: 122500 RVA: 0x00862B0E File Offset: 0x00860D0E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DE85 RID: 122501 RVA: 0x00862B10 File Offset: 0x00860D10
	public static void ResetStaticDefaultValue()
	{
		PreloadModelNew._Instance = null;
	}

	// Token: 0x0601DE86 RID: 122502 RVA: 0x00862B18 File Offset: 0x00860D18
	static PreloadModelNew()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreloadModelNew.CreateStaticDefaultValue), new Action(PreloadModelNew.ResetStaticDefaultValue));
	}

	// Token: 0x0400EABE RID: 60094
	public bool EnablePreloadLog;

	// Token: 0x0400EABF RID: 60095
	[Nullable(2)]
	public string ProjectPath;

	// Token: 0x0400EAC0 RID: 60096
	[Nullable(2)]
	public string JsonExportRootPath;

	// Token: 0x0400EAC1 RID: 60097
	[Nullable(2)]
	public string ModelConfigJsonExportPath;

	// Token: 0x0400EAC2 RID: 60098
	[Nullable(2)]
	public string SkillJsonExportPath;

	// Token: 0x0400EAC3 RID: 60099
	[Nullable(2)]
	public string CommonSkillJsonExportPath;

	// Token: 0x0400EAC4 RID: 60100
	[Nullable(2)]
	public string BulletJsonExportPath;

	// Token: 0x0400EAC5 RID: 60101
	[Nullable(2)]
	public string StateMachineJsonExportPath;

	// Token: 0x0400EAC6 RID: 60102
	public readonly PreCreateEffect PreCreateEffect = new PreCreateEffect();

	// Token: 0x0400EAC7 RID: 60103
	public readonly CommonAssetElement CommonAssetElement = new CommonAssetElement(null);

	// Token: 0x0400EAC8 RID: 60104
	public readonly Dictionary<string, int> PreloadAssetMap = new Dictionary<string, int>();

	// Token: 0x0400EAC9 RID: 60105
	public readonly Dictionary<int, Dictionary<int, PbDataPreload>> PbDataPreloadDataMap = new Dictionary<int, Dictionary<int, PbDataPreload>>();

	// Token: 0x0400EACA RID: 60106
	public readonly Dictionary<long, EntityAssetElement> AllEntityAssetMap = new Dictionary<long, EntityAssetElement>();

	// Token: 0x0400EACB RID: 60107
	public readonly Dictionary<int, PbEntityAssetElement> AllPbEntityAssetMap = new Dictionary<int, PbEntityAssetElement>();

	// Token: 0x0400EACC RID: 60108
	public readonly PlotAssetManager PlotAssetManager = new PlotAssetManager();

	// Token: 0x0400EACD RID: 60109
	public readonly PlotUiAssetManager PlotUiAssetManager = new PlotUiAssetManager();

	// Token: 0x0400EACE RID: 60110
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

	// Token: 0x0400EACF RID: 60111
	[Nullable(2)]
	private UHoldPreloadObject HoldPreloadObjectInternal;

	// Token: 0x0400EAD0 RID: 60112
	public readonly Dictionary<string, Dictionary<long, PreloadSaveData>> BulletPreloadDataMap = new Dictionary<string, Dictionary<long, PreloadSaveData>>();

	// Token: 0x0400EAD1 RID: 60113
	public CommonSkillPreload[] CommonSkillPreloadDataMap = Array.Empty<CommonSkillPreload>();

	// Token: 0x0400EAD2 RID: 60114
	public readonly Dictionary<int, PreloadModelConfigSaveData> ModelConfigPreloadDataMap = new Dictionary<int, PreloadModelConfigSaveData>();

	// Token: 0x0400EAD3 RID: 60115
	public readonly Dictionary<string, PreloadSaveData> StateMachinePreloadDataMap = new Dictionary<string, PreloadSaveData>();

	// Token: 0x0400EAD4 RID: 60116
	public readonly Dictionary<int, PreloadSaveData> TemplatePreloadDataMap = new Dictionary<int, PreloadSaveData>();

	// Token: 0x0400EAD5 RID: 60117
	public readonly Dictionary<string, List<PreloadSkillSaveData>> SkillPreloadDataMap = new Dictionary<string, List<PreloadSkillSaveData>>();

	// Token: 0x0400EAD6 RID: 60118
	public readonly HashSet<int> LoadingNeedWaitEntitySet = new HashSet<int>();

	// Token: 0x0400EAD7 RID: 60119
	public bool UseEntityProfilerInternal = true;

	// Token: 0x0400EAD8 RID: 60120
	public bool LoadAssetOneByOneState;

	// Token: 0x0400EAD9 RID: 60121
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<string, int>> ResourcesLoadTime = new List<ValueTuple<string, int>>();

	// Token: 0x0400EADA RID: 60122
	[Nullable(2)]
	private static PreloadModelNew _Instance;
}
