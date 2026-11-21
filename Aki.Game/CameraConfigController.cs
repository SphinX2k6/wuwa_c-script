using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020001FB RID: 507
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraConfigController : CameraControllerBase
{
	// Token: 0x0600203E RID: 8254 RVA: 0x000A7D1C File Offset: 0x000A5F1C
	private static Dictionary<int, float> ToIntConfig(Dictionary<EFightCameraDefault, float> source)
	{
		Dictionary<int, float> dictionary = new Dictionary<int, float>(source.Count);
		foreach (KeyValuePair<EFightCameraDefault, float> keyValuePair in source)
		{
			EFightCameraDefault efightCameraDefault;
			float num;
			keyValuePair.Deconstruct(out efightCameraDefault, out num);
			EFightCameraDefault efightCameraDefault2 = efightCameraDefault;
			float value = num;
			dictionary[Convert.ToInt32(efightCameraDefault2)] = value;
		}
		return dictionary;
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000A7D94 File Offset: 0x000A5F94
	public CameraConfig GetDefaultConfig()
	{
		return this.DefaultConfig;
	}

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06002040 RID: 8256 RVA: 0x000A7D9C File Offset: 0x000A5F9C
	// (set) Token: 0x06002041 RID: 8257 RVA: 0x000A7DA4 File Offset: 0x000A5FA4
	[Nullable(2)]
	protected EntityHandle SelfCharacterEntity
	{
		[NullableContext(2)]
		get
		{
			return this.SelfCharacterEntityInternal;
		}
		[NullableContext(2)]
		set
		{
			if (this.SelfCharacterEntityInternal == value)
			{
				return;
			}
			EntityHandle selfCharacterEntityInternal = this.SelfCharacterEntityInternal;
			if (selfCharacterEntityInternal != null && selfCharacterEntityInternal.Valid)
			{
				BaseTagComponent component = this.SelfCharacterEntityInternal.Entity.GetComponent<BaseTagComponent>();
				if (component != null && component.Valid)
				{
					foreach (CameraConfig cameraConfig in this.SubConfigs.Values)
					{
						component.RemoveTagAddOrRemoveListener(cameraConfig.Tag.Value.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChanged));
					}
				}
			}
			if (value != null && value.Valid)
			{
				BaseTagComponent component2 = value.Entity.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.Valid)
				{
					foreach (CameraConfig cameraConfig2 in this.SubConfigs.Values)
					{
						component2.AddTagAddOrRemoveListener(cameraConfig2.Tag.Value.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChanged), null);
					}
				}
			}
			this.SelfCharacterEntityInternal = value;
			this.UpdateTargetConfig();
		}
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06002042 RID: 8258 RVA: 0x000A7EE8 File Offset: 0x000A60E8
	// (set) Token: 0x06002043 RID: 8259 RVA: 0x000A7EF0 File Offset: 0x000A60F0
	[Nullable(2)]
	protected EntityHandle FloatCharacterEntity
	{
		[NullableContext(2)]
		get
		{
			return this.FloatCharacterEntityInternal;
		}
		[NullableContext(2)]
		set
		{
			if (this.FloatCharacterEntityInternal == value)
			{
				return;
			}
			EntityHandle floatCharacterEntityInternal = this.FloatCharacterEntityInternal;
			if (floatCharacterEntityInternal != null && floatCharacterEntityInternal.Valid)
			{
				BaseTagComponent component = this.FloatCharacterEntityInternal.Entity.GetComponent<BaseTagComponent>();
				if (component != null && component.Valid)
				{
					foreach (CameraConfig cameraConfig in this.AccompanyConfigs.Values)
					{
						component.RemoveTagAddOrRemoveListener(cameraConfig.Tag.Value.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnAccompanyTagChanged));
					}
				}
			}
			if (value != null && value.Valid)
			{
				BaseTagComponent component2 = value.Entity.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.Valid)
				{
					foreach (CameraConfig cameraConfig2 in this.AccompanyConfigs.Values)
					{
						component2.AddTagAddOrRemoveListener(cameraConfig2.Tag.Value.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnAccompanyTagChanged), null);
					}
				}
			}
			this.FloatCharacterEntityInternal = value;
			this.UpdateAccompanyTargetConfig();
		}
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000A8034 File Offset: 0x000A6234
	private void OnSubTagChanged(int gameplayTagId, bool tagExist)
	{
		if (tagExist)
		{
			if (this.CurrentSubTagSet.Contains(gameplayTagId))
			{
				return;
			}
			CameraConfig cameraConfig;
			if (!this.SubConfigs.TryGetValue(gameplayTagId, out cameraConfig))
			{
				return;
			}
			this.CurrentConfigList.Insert(cameraConfig);
			this.CurrentSubTagSet.Add(gameplayTagId);
			this.UpdateFadeInConfig(cameraConfig);
			return;
		}
		else
		{
			CameraConfig cameraConfig2;
			if (!this.SubConfigs.TryGetValue(gameplayTagId, out cameraConfig2))
			{
				return;
			}
			if (!this.CurrentSubTagSet.Contains(gameplayTagId))
			{
				return;
			}
			if (this.Camera.ContainsTag(gameplayTagId, false))
			{
				return;
			}
			this.CurrentConfigList.Remove(cameraConfig2);
			this.CurrentSubTagSet.Remove(gameplayTagId);
			this.UpdateFadeOutConfig(cameraConfig2);
			return;
		}
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000A80D8 File Offset: 0x000A62D8
	private void OnAccompanyTagChanged(int gameplayTagId, bool tagExist)
	{
		if (tagExist)
		{
			if (this.CurrentAccompanyTagSet.Contains(gameplayTagId))
			{
				return;
			}
			CameraConfig cameraConfig;
			if (!this.AccompanyConfigs.TryGetValue(gameplayTagId, out cameraConfig))
			{
				return;
			}
			this.CurrentConfigList.Insert(cameraConfig);
			this.CurrentAccompanyTagSet.Add(gameplayTagId);
			this.UpdateFadeInConfig(cameraConfig);
			return;
		}
		else
		{
			CameraConfig cameraConfig2;
			if (!this.AccompanyConfigs.TryGetValue(gameplayTagId, out cameraConfig2))
			{
				return;
			}
			if (!this.CurrentAccompanyTagSet.Contains(gameplayTagId))
			{
				return;
			}
			if (this.Camera.AccompanyContainsTag(gameplayTagId))
			{
				return;
			}
			this.CurrentConfigList.Remove(cameraConfig2);
			this.CurrentAccompanyTagSet.Remove(gameplayTagId);
			this.UpdateFadeOutConfig(cameraConfig2);
			return;
		}
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000A8178 File Offset: 0x000A6378
	protected void UpdateFocusTargetAndSocket([Nullable(2)] Entity newTarget, string newSocket)
	{
		bool flag = false;
		if (this.FocusTarget == newTarget)
		{
			if (this.FocusTargetSocketName != newSocket)
			{
				flag = true;
			}
		}
		else
		{
			Entity focusTarget = this.FocusTarget;
			if (focusTarget != null && focusTarget.Valid)
			{
				BaseTagComponent component = this.FocusTarget.GetComponent<BaseTagComponent>();
				if (component != null && component.Valid)
				{
					foreach (CameraConfig cameraConfig in this.FocusConfigs.Values)
					{
						component.RemoveTagAddOrRemoveListener(cameraConfig.Tag.Value.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnFocusTagChanged));
					}
				}
			}
			if (newTarget != null && newTarget.Valid)
			{
				BaseTagComponent component2 = newTarget.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.Valid)
				{
					foreach (CameraConfig cameraConfig2 in this.FocusConfigs.Values)
					{
						component2.AddTagAddOrRemoveListener(cameraConfig2.Tag.Value.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnFocusTagChanged), null);
					}
				}
			}
			flag = true;
		}
		this.FocusTarget = newTarget;
		this.FocusTargetSocketName = newSocket;
		if (flag)
		{
			this.UpdateFocusTargetConfig();
		}
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000A82D8 File Offset: 0x000A64D8
	private void OnFocusTagChanged(int gameplayTagId, bool tagExist)
	{
		if (tagExist)
		{
			if (this.CurrentFocusTagSet.Contains(gameplayTagId))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "Got config before Tag";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", GameplayTagUtils.GetNameByTagId(gameplayTagId));
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CameraConfig cameraConfig;
			if (!this.FocusConfigs.TryGetValue(gameplayTagId, out cameraConfig) || cameraConfig.LockOnParts.Length != 0)
			{
				return;
			}
			this.CurrentConfigList.Insert(cameraConfig);
			this.CurrentFocusTagSet.Add(gameplayTagId);
			this.UpdateFadeInConfig(cameraConfig);
			return;
		}
		else
		{
			if (!this.CurrentFocusTagSet.Contains(gameplayTagId))
			{
				return;
			}
			CameraConfig cameraConfig2;
			if (!this.FocusConfigs.TryGetValue(gameplayTagId, out cameraConfig2))
			{
				return;
			}
			this.CurrentConfigList.Remove(cameraConfig2);
			this.UpdateFadeOutConfig(cameraConfig2);
			this.CurrentFocusTagSet.Remove(gameplayTagId);
			return;
		}
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000A83A0 File Offset: 0x000A65A0
	protected override void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (this.AdjustCameraTagMap.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<EAdjustPlayerCamera, int?> keyValuePair in this.AdjustCameraTagMap)
		{
			EAdjustPlayerCamera eadjustPlayerCamera;
			int? num;
			keyValuePair.Deconstruct(out eadjustPlayerCamera, out num);
			EAdjustPlayerCamera adjustPlayerCamera = eadjustPlayerCamera;
			int? extraTagId = num;
			this.EnableHookConfig(adjustPlayerCamera, extraTagId);
		}
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000A8414 File Offset: 0x000A6614
	private void OnCameraCharacterChanged([Nullable(2)] EntityHandle newEntity, string cameraName)
	{
		CameraModelInstance cameraModel = base.CameraModel;
		if (cameraName != ((cameraModel != null) ? cameraModel.CameraName : null))
		{
			return;
		}
		this.SelfCharacterEntity = newEntity;
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x000A8438 File Offset: 0x000A6638
	private void OnFollowShooterPossessed(EntityHandle follower)
	{
		this.FloatCharacterEntity = follower;
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x000A8441 File Offset: 0x000A6641
	private void OnFollowShooterUnPossessed()
	{
		this.FloatCharacterEntity = null;
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x000A844C File Offset: 0x000A664C
	public CameraConfigController(FightCameraLogicComponent camera) : base(camera)
	{
		this.CurrentConfigList = new RbTree<CameraConfig>(this.CameraConfigCompare);
		this.LoadConfig();
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x000A8551 File Offset: 0x000A6751
	public override string Name()
	{
		return "ConfigController";
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x000A8558 File Offset: 0x000A6758
	public override void OnStart()
	{
		base.OnStart();
		EventSystem.Instance.Add<EntityHandle, string>(EEventName.CameraCharacterChanged, new Action<EntityHandle, string>(this.OnCameraCharacterChanged));
		EventSystem.Instance.Add<EntityHandle>(EEventName.OnPlayerFollowerPossessed, new Action<EntityHandle>(this.OnFollowShooterPossessed));
		EventSystem.Instance.Add(EEventName.OnPlayerFollowerUnPossessed, new Action(this.OnFollowShooterUnPossessed));
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x000A85BF File Offset: 0x000A67BF
	protected override void UpdateInternal(float deltaTime)
	{
		this.UpdateConfig();
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000A85C8 File Offset: 0x000A67C8
	public void EnableHookConfig(EAdjustPlayerCamera adjustPlayerCamera, int? extraTagId = null)
	{
		int tagIdByName = GameplayTagUtils.GetTagIdByName(adjustPlayerCamera.ToEnumString());
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
		{
			if (entityHandle.Valid)
			{
				BaseTagComponent component = entityHandle.Entity.GetComponent<BaseTagComponent>();
				if (component != null)
				{
					if (extraTagId != null && !component.HasTag(extraTagId.Value))
					{
						component.AddTag(new int?(extraTagId.Value));
					}
					if (component.HasTag(tagIdByName))
					{
						component.RemoveTag(new int?(tagIdByName));
					}
					component.AddTag(new int?(tagIdByName));
					this.AdjustCameraEntityHandleSet.Add(entityHandle);
				}
			}
		}
		this.AdjustCameraTagMap[adjustPlayerCamera] = extraTagId;
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000A86A8 File Offset: 0x000A68A8
	public void DisableHookConfig(float? fadeOutTime = null)
	{
		if (fadeOutTime != null)
		{
			foreach (EAdjustPlayerCamera adjustPlayerCamera in EAdjustPlayerCameraExtensions.GetValues())
			{
				this.SetHookConfigFadeOutTime(adjustPlayerCamera, fadeOutTime.Value);
			}
		}
		foreach (EntityHandle entityHandle in this.AdjustCameraEntityHandleSet)
		{
			WorldEntity entity = entityHandle.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				foreach (EAdjustPlayerCamera value in EAdjustPlayerCameraExtensions.GetValues())
				{
					baseTagComponent.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(value.ToEnumString())));
				}
				baseTagComponent.RemoveTag(new int?(CameraConfigController.NoAimGameplayTag));
			}
		}
		this.AdjustCameraEntityHandleSet.Clear();
		this.AdjustCameraTagMap.Clear();
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x000A8794 File Offset: 0x000A6994
	public void DisableHookConfigByType(EAdjustPlayerCamera adjustPlayerCamera)
	{
		foreach (EntityHandle entityHandle in this.AdjustCameraEntityHandleSet)
		{
			WorldEntity entity = entityHandle.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				baseTagComponent.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(adjustPlayerCamera.ToEnumString())));
				baseTagComponent.RemoveTag(new int?(CameraConfigController.NoAimGameplayTag));
			}
		}
		this.AdjustCameraTagMap.Remove(adjustPlayerCamera);
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x000A882C File Offset: 0x000A6A2C
	[NullableContext(2)]
	public CameraConfig GetCameraConfigByTag(int hookTagId)
	{
		return this.SubConfigs.GetValueOrDefault(hookTagId);
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x000A883C File Offset: 0x000A6A3C
	public void LoadConfig()
	{
		this.ConfigsCache = CameraController.Instance.GetCameraConfigList(null);
		this.SubConfigs.Clear();
		this.FocusConfigs.Clear();
		this.AccompanyConfigs.Clear();
		this.CurrentSubTagSet.Clear();
		this.CurrentAccompanyTagSet.Clear();
		foreach (DtCameraConfig dtCameraConfig in this.CharacterCameraConfigs.Values)
		{
			dtCameraConfig.SubValidKeys.Clear();
			dtCameraConfig.FocusValidKeys.Clear();
			dtCameraConfig.AccompanyValidKeys.Clear();
		}
		int num = this.ConfigsCache.Num();
		for (int i = 0; i < num; i++)
		{
			CameraConfig cameraConfig = new CameraConfig(this.ConfigsCache.Get(i));
			if (Info.Instance.IsMobilePlatform() ? cameraConfig.MobileValid : cameraConfig.PcValid)
			{
				if (cameraConfig.Type == EFightCameraType.基础镜头)
				{
					this.DefaultConfig = cameraConfig;
				}
				else if (cameraConfig.Type == EFightCameraType.战斗镜头)
				{
					this.FightConfig = cameraConfig;
				}
				else if (cameraConfig.Type == EFightCameraType.子镜头)
				{
					if (cameraConfig.Tag == null || cameraConfig.Tag.Value.TagName == FName.NAME_None)
					{
						global::Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "初始化镜头配置[DT_CameraConfigs]失败，子镜头没有正确配置Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						this.SubConfigs[cameraConfig.Tag.Value.TagId()] = cameraConfig;
					}
				}
				else if (cameraConfig.Type == EFightCameraType.锁定目标镜头)
				{
					if (cameraConfig.Tag.Value.TagName == FName.NAME_None)
					{
						global::Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "初始化镜头配置[DT_CameraConfigs]失败，锁定目标镜头没有正确配置Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						this.FocusConfigs[cameraConfig.Tag.Value.TagId()] = cameraConfig;
					}
				}
				else if (cameraConfig.Type == EFightCameraType.伴随目标镜头)
				{
					if (cameraConfig.Tag.Value.TagName == FName.NAME_None)
					{
						global::Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "初始化镜头配置[DT_CameraConfigs]失败，伴随目标镜头没有正确配置Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						this.AccompanyConfigs[cameraConfig.Tag.Value.TagId()] = cameraConfig;
					}
				}
			}
		}
		if (this.DefaultConfig == null || this.FightConfig == null)
		{
			global::Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "初始化镜头配置[DT_CameraConfigs]失败，基础镜头/战斗镜头未配置", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		foreach (DtCameraConfig dtCameraConfig2 in this.CharacterCameraConfigs.Values)
		{
			dtCameraConfig2.SetToConfigs(this.SubConfigs, this.FocusConfigs, this.AccompanyConfigs);
		}
		this.IsFighting = false;
		this.CurrentConfigList.Clear();
		this.CurrentConfigList.Insert(this.DefaultConfig);
		this.HasChangedConfig = true;
		this.UpdateFadeInConfig(this.DefaultConfig);
		this.UpdateConfig();
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x000A8B64 File Offset: 0x000A6D64
	[NullableContext(2)]
	public void LoadCharacterConfig(UDataTable dataTable)
	{
		if (dataTable == null)
		{
			return;
		}
		DtCameraConfig dtCameraConfig;
		if (!this.CharacterCameraConfigs.TryGetValue(dataTable, out dtCameraConfig))
		{
			dtCameraConfig = new DtCameraConfig(dataTable);
			dtCameraConfig.SetToConfigs(this.SubConfigs, this.FocusConfigs, this.AccompanyConfigs);
			this.CharacterCameraConfigs[dataTable] = dtCameraConfig;
			EntityHandle selfCharacterEntityInternal = this.SelfCharacterEntityInternal;
			if (selfCharacterEntityInternal != null && selfCharacterEntityInternal.Valid)
			{
				BaseTagComponent component = this.SelfCharacterEntityInternal.Entity.GetComponent<BaseTagComponent>();
				if (component != null && component.Valid)
				{
					foreach (int tagId in dtCameraConfig.SubValidKeys)
					{
						component.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChanged), null);
					}
				}
			}
			Entity focusTarget = this.FocusTarget;
			if (focusTarget != null && focusTarget.Valid)
			{
				BaseTagComponent component2 = this.FocusTarget.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.Valid)
				{
					foreach (int tagId2 in dtCameraConfig.FocusValidKeys)
					{
						component2.AddTagAddOrRemoveListener(tagId2, new BaseTagComponent.TTagSwitchedCallback(this.OnFocusTagChanged), null);
					}
				}
			}
			EntityHandle floatCharacterEntity = this.FloatCharacterEntity;
			if (floatCharacterEntity != null && floatCharacterEntity.Valid)
			{
				BaseTagComponent component3 = this.FloatCharacterEntityInternal.Entity.GetComponent<BaseTagComponent>();
				if (component3 != null && component3.Valid)
				{
					foreach (int tagId3 in dtCameraConfig.AccompanyValidKeys)
					{
						component3.AddTagAddOrRemoveListener(tagId3, new BaseTagComponent.TTagSwitchedCallback(this.OnAccompanyTagChanged), null);
					}
				}
			}
			if (this.SelfCharacterEntity != null)
			{
				foreach (int num in dtCameraConfig.SubValidKeys)
				{
					if (this.Camera.ContainsTag(num, false))
					{
						CameraConfig cameraConfig = this.SubConfigs[num];
						this.CurrentConfigList.Insert(cameraConfig);
						this.CurrentSubTagSet.Add(num);
						this.UpdateFadeInConfig(cameraConfig);
					}
				}
			}
			if (this.FocusTarget != null)
			{
				foreach (int num2 in dtCameraConfig.FocusValidKeys)
				{
					if (this.Camera.TargetContainsTag(num2))
					{
						CameraConfig cameraConfig2 = this.FocusConfigs[num2];
						this.CurrentConfigList.Insert(cameraConfig2);
						this.CurrentFocusTagSet.Add(num2);
						this.UpdateFadeInConfig(cameraConfig2);
					}
				}
			}
			if (this.FloatCharacterEntity != null)
			{
				foreach (int num3 in dtCameraConfig.AccompanyValidKeys)
				{
					if (this.Camera.AccompanyContainsTag(num3))
					{
						CameraConfig cameraConfig3 = this.AccompanyConfigs[num3];
						this.CurrentConfigList.Insert(cameraConfig3);
						this.CurrentAccompanyTagSet.Add(num3);
						this.UpdateFadeInConfig(cameraConfig3);
					}
				}
			}
		}
		dtCameraConfig.ReferenceCount++;
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x000A8EDC File Offset: 0x000A70DC
	[NullableContext(2)]
	public void UnloadCharacterConfig(UDataTable dataTable)
	{
		if (dataTable == null)
		{
			return;
		}
		DtCameraConfig dtCameraConfig;
		if (!this.CharacterCameraConfigs.TryGetValue(dataTable, out dtCameraConfig))
		{
			return;
		}
		dtCameraConfig.ReferenceCount--;
		if (dtCameraConfig.ReferenceCount == 0)
		{
			EntityHandle selfCharacterEntityInternal = this.SelfCharacterEntityInternal;
			if (selfCharacterEntityInternal != null && selfCharacterEntityInternal.Valid)
			{
				BaseTagComponent component = this.SelfCharacterEntityInternal.Entity.GetComponent<BaseTagComponent>();
				if (component != null && component.Valid)
				{
					foreach (int tagId in dtCameraConfig.SubValidKeys)
					{
						component.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSubTagChanged));
					}
				}
			}
			Entity focusTarget = this.FocusTarget;
			if (focusTarget != null && focusTarget.Valid)
			{
				BaseTagComponent component2 = this.FocusTarget.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.Valid)
				{
					foreach (int tagId2 in dtCameraConfig.FocusValidKeys)
					{
						component2.RemoveTagAddOrRemoveListener(tagId2, new BaseTagComponent.TTagSwitchedCallback(this.OnFocusTagChanged));
					}
				}
			}
			EntityHandle floatCharacterEntityInternal = this.FloatCharacterEntityInternal;
			if (floatCharacterEntityInternal != null && floatCharacterEntityInternal.Valid)
			{
				BaseTagComponent component3 = this.FloatCharacterEntityInternal.Entity.GetComponent<BaseTagComponent>();
				if (component3 != null && component3.Valid)
				{
					foreach (int tagId3 in dtCameraConfig.AccompanyValidKeys)
					{
						component3.RemoveTagAddOrRemoveListener(tagId3, new BaseTagComponent.TTagSwitchedCallback(this.OnAccompanyTagChanged));
					}
				}
			}
			if (this.SelfCharacterEntity != null)
			{
				foreach (int num in dtCameraConfig.SubValidKeys)
				{
					if (this.CurrentSubTagSet.Remove(num))
					{
						CameraConfig cameraConfig = this.SubConfigs[num];
						this.CurrentConfigList.Remove(cameraConfig);
						this.UpdateFadeOutConfig(cameraConfig);
					}
				}
			}
			if (this.FocusTarget != null)
			{
				foreach (int num2 in dtCameraConfig.FocusValidKeys)
				{
					if (this.CurrentFocusTagSet.Remove(num2))
					{
						CameraConfig cameraConfig2 = this.FocusConfigs[num2];
						this.CurrentConfigList.Remove(cameraConfig2);
						this.UpdateFadeOutConfig(cameraConfig2);
					}
				}
			}
			if (this.FloatCharacterEntity != null)
			{
				foreach (int num3 in dtCameraConfig.AccompanyValidKeys)
				{
					if (this.CurrentAccompanyTagSet.Remove(num3))
					{
						CameraConfig cameraConfig3 = this.AccompanyConfigs[num3];
						this.CurrentConfigList.Remove(cameraConfig3);
						this.UpdateFadeOutConfig(cameraConfig3);
					}
				}
			}
			dtCameraConfig.RemoveFromConfigs(this.SubConfigs, this.FocusConfigs, this.AccompanyConfigs);
			this.CharacterCameraConfigs.Remove(dataTable);
		}
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000A9228 File Offset: 0x000A7428
	public void UpdateConfig()
	{
		if (this.Camera.Character == null)
		{
			return;
		}
		bool flag = this.UpdateMainFightConfig();
		this.SelfCharacterEntity = this.Camera.CharacterEntityHandle;
		string text;
		if (this.Camera.TargetEntity == null)
		{
			text = "";
		}
		else
		{
			FightCameraLogicComponent camera = this.Camera;
			text = (((camera.TargetSocketName != null) ? camera.TargetSocketName.GetValueOrDefault().ToString() : null) ?? "");
		}
		string newSocket = text;
		EntityHandle targetEntity = this.Camera.TargetEntity;
		this.UpdateFocusTargetAndSocket((targetEntity != null) ? targetEntity.Entity : null, newSocket);
		if (flag | this.HasChangedConfig)
		{
			this.ApplyAllConfigs();
		}
		this.HasChangedConfig = false;
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x000A92D8 File Offset: 0x000A74D8
	private bool UpdateMainFightConfig()
	{
		bool flag = this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], false);
		if (flag == this.IsFighting)
		{
			return false;
		}
		CameraConfig cameraConfig = this.IsFighting ? this.FightConfig : this.DefaultConfig;
		CameraConfig cameraConfig2 = flag ? this.FightConfig : this.DefaultConfig;
		this.CurrentConfigList.Remove(cameraConfig);
		this.CurrentConfigList.Insert(cameraConfig2);
		this.UpdateFadeOutConfig(cameraConfig);
		this.UpdateFadeInConfig(cameraConfig2);
		this.IsFighting = flag;
		return true;
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x000A9364 File Offset: 0x000A7564
	private void UpdateFocusTargetConfig()
	{
		int[] array = new int[this.CurrentFocusTagSet.Count];
		this.CurrentFocusTagSet.CopyTo(array);
		foreach (int num in array)
		{
			CameraConfig cameraConfig = this.FocusConfigs[num];
			if (!this.Camera.TargetContainsTag(num) || Array.IndexOf<string>(cameraConfig.LockOnParts, this.FocusTargetSocketName) < 0)
			{
				this.CurrentConfigList.Remove(cameraConfig);
				this.CurrentFocusTagSet.Remove(num);
				this.UpdateFadeOutConfig(cameraConfig);
			}
		}
		foreach (KeyValuePair<int, CameraConfig> keyValuePair in this.FocusConfigs)
		{
			int i;
			CameraConfig cameraConfig2;
			keyValuePair.Deconstruct(out i, out cameraConfig2);
			int num2 = i;
			CameraConfig cameraConfig3 = cameraConfig2;
			if (this.Camera.TargetContainsTag(num2) && (cameraConfig3.LockOnParts.Length == 0 || Array.IndexOf<string>(cameraConfig3.LockOnParts, this.FocusTargetSocketName) >= 0) && !this.CurrentFocusTagSet.Contains(num2))
			{
				this.CurrentConfigList.Insert(cameraConfig3);
				this.CurrentFocusTagSet.Add(num2);
				this.UpdateFadeInConfig(cameraConfig3);
			}
		}
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x000A94AC File Offset: 0x000A76AC
	private void UpdateTargetConfig()
	{
		int[] array = new int[this.CurrentSubTagSet.Count];
		this.CurrentSubTagSet.CopyTo(array);
		foreach (int num in array)
		{
			CameraConfig cameraConfig = this.SubConfigs[num];
			if (!this.Camera.ContainsTag(num, false))
			{
				this.CurrentConfigList.Remove(cameraConfig);
				this.CurrentSubTagSet.Remove(num);
				this.UpdateFadeOutConfig(cameraConfig);
			}
		}
		foreach (KeyValuePair<int, CameraConfig> keyValuePair in this.SubConfigs)
		{
			int i;
			CameraConfig cameraConfig2;
			keyValuePair.Deconstruct(out i, out cameraConfig2);
			int num2 = i;
			CameraConfig cameraConfig3 = cameraConfig2;
			if (!this.CurrentSubTagSet.Contains(num2) && this.Camera.ContainsTag(num2, false))
			{
				this.CurrentConfigList.Insert(cameraConfig3);
				this.CurrentSubTagSet.Add(num2);
				this.UpdateFadeInConfig(cameraConfig3);
			}
		}
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000A95C0 File Offset: 0x000A77C0
	private void UpdateAccompanyTargetConfig()
	{
		int[] array = new int[this.CurrentAccompanyTagSet.Count];
		this.CurrentAccompanyTagSet.CopyTo(array);
		foreach (int num in array)
		{
			CameraConfig cameraConfig = this.AccompanyConfigs[num];
			if (!this.Camera.AccompanyContainsTag(num))
			{
				this.CurrentConfigList.Remove(cameraConfig);
				this.CurrentAccompanyTagSet.Remove(num);
				this.UpdateFadeOutConfig(cameraConfig);
			}
		}
		foreach (KeyValuePair<int, CameraConfig> keyValuePair in this.AccompanyConfigs)
		{
			int i;
			CameraConfig cameraConfig2;
			keyValuePair.Deconstruct(out i, out cameraConfig2);
			int num2 = i;
			CameraConfig cameraConfig3 = cameraConfig2;
			if (!this.CurrentAccompanyTagSet.Contains(num2) && this.Camera.AccompanyContainsTag(num2))
			{
				this.CurrentConfigList.Insert(cameraConfig3);
				this.CurrentAccompanyTagSet.Add(num2);
				this.UpdateFadeInConfig(cameraConfig3);
			}
		}
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000A96D0 File Offset: 0x000A78D0
	private void UpdateFadeInConfig(CameraConfig cameraConfig)
	{
		float num = Math.Min(cameraConfig.FadeInTime, 10f);
		if (num > this.ConfigFadeInDuration)
		{
			return;
		}
		if (!this.IsUniqueFade)
		{
			FightCameraLogicComponent camera = this.Camera;
			if (camera == null || !camera.Fading || !camera.IsUniqueFade)
			{
				goto IL_46;
			}
		}
		if (!cameraConfig.IsUniqueFade)
		{
			return;
		}
		IL_46:
		this.FadeInTriggered = true;
		this.HasChangedConfig = true;
		this.IsUniqueFade = cameraConfig.IsUniqueFade;
		this.ConfigFadeInDuration = num;
		this.ConfigFadeInCurve = cameraConfig.FadeInCurve;
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000A9750 File Offset: 0x000A7950
	private void UpdateFadeOutConfig(CameraConfig cameraConfig)
	{
		float num = Math.Min(cameraConfig.FadeOutTime, 10f);
		if (num > this.ConfigFadeOutDuration)
		{
			return;
		}
		if (!this.IsUniqueFade)
		{
			FightCameraLogicComponent camera = this.Camera;
			if (camera == null || !camera.Fading || !camera.IsUniqueFade)
			{
				goto IL_46;
			}
		}
		if (!cameraConfig.IsUniqueFade)
		{
			return;
		}
		IL_46:
		this.FadeOutTriggered = true;
		this.HasChangedConfig = true;
		this.IsUniqueFade = cameraConfig.IsUniqueFade;
		this.ConfigFadeOutDuration = num;
		this.ConfigFadeOutCurve = cameraConfig.FadeOutCurve;
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x000A97D0 File Offset: 0x000A79D0
	private bool IsFadeIn()
	{
		if (this.FadeInTriggered && this.FadeOutTriggered)
		{
			return this.ConfigFadeInDuration <= this.ConfigFadeOutDuration;
		}
		return this.FadeInTriggered;
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000A97FA File Offset: 0x000A79FA
	[Conditional("DEBUG")]
	private void UpdateSubCameraModification()
	{
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000A97FC File Offset: 0x000A79FC
	private void ApplyAllConfigs()
	{
		this.ResetLockController();
		this.ResetAllControllersDefaultConfig();
		CameraConfig resetDefaultConfig = this.CurrentConfigList.ExtremelyLeft;
		bool hasResetDefaultConfig = false;
		CameraConfig resetDefaultLockConfig = this.CurrentConfigList.ExtremelyLeft;
		bool hasResetDefaultLockConfig = false;
		bool isLockConfigLeft = false;
		this.CurrentConfigList.ForEachReverse(delegate(CameraConfig config)
		{
			if (config.IsResetDefaultConfig && !hasResetDefaultConfig)
			{
				resetDefaultConfig = config;
				hasResetDefaultConfig = true;
			}
			if (config.IsResetCameraLock && !hasResetDefaultLockConfig)
			{
				resetDefaultLockConfig = config;
				hasResetDefaultLockConfig = true;
			}
			if (!hasResetDefaultLockConfig & hasResetDefaultConfig)
			{
				isLockConfigLeft = true;
			}
			return !(hasResetDefaultLockConfig & hasResetDefaultConfig);
		});
		CameraConfig from = isLockConfigLeft ? resetDefaultLockConfig : resetDefaultConfig;
		bool appliedDefaultConfig = false;
		bool appliedLockConfig = false;
		this.CurrentConfigList.ForEachFrom(from, delegate(CameraConfig config)
		{
			if (config == resetDefaultConfig && !appliedDefaultConfig)
			{
				appliedDefaultConfig = true;
			}
			if (config == resetDefaultLockConfig && !appliedLockConfig)
			{
				appliedLockConfig = true;
			}
			if (appliedDefaultConfig)
			{
				this.UpdateControllersConfig(config);
			}
			if (appliedLockConfig)
			{
				this.UpdateControllersLockStateByConfig(config);
			}
			return true;
		});
		this.Camera.ApplyConfig();
		if (this.Camera.Initialized)
		{
			bool flag = this.IsFadeIn();
			this.Camera.StartFade(flag ? this.ConfigFadeInDuration : this.ConfigFadeOutDuration, flag ? this.ConfigFadeInCurve : this.ConfigFadeOutCurve, true, true, true, true, this.IsUniqueFade);
		}
		this.IsUniqueFade = false;
		this.FadeInTriggered = false;
		this.FadeOutTriggered = false;
		this.ConfigFadeInDuration = 10f;
		this.ConfigFadeOutDuration = 10f;
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x000A9930 File Offset: 0x000A7B30
	private void SetHookConfigFadeOutTime(EAdjustPlayerCamera adjustPlayerCamera, float fadeOutTime)
	{
		CameraConfig cameraConfigByTag = this.GetCameraConfigByTag(GameplayTagUtils.GetTagIdByName(adjustPlayerCamera.ToEnumString()));
		if (cameraConfigByTag == null)
		{
			return;
		}
		cameraConfigByTag.FadeOutTime = fadeOutTime;
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x000A995C File Offset: 0x000A7B5C
	public string GetCameraConfigTagsContent()
	{
		string content = "";
		this.CurrentConfigList.ForEach(delegate(CameraConfig config)
		{
			string content = content;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<FName>((config.Tag != null) ? config.Tag.GetValueOrDefault().TagName : "None");
			content += defaultInterpolatedStringHandler.ToStringAndClear();
			return true;
		});
		return content;
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000A9998 File Offset: 0x000A7B98
	private void ResetLockController()
	{
		if (!this.AutoCamera)
		{
			this.Camera.CameraAutoController.Unlock(this);
		}
		if (!this.ModifyCamera)
		{
			this.Camera.CameraModifyController.Unlock(this);
		}
		if (!this.AdjustCamera)
		{
			this.Camera.CameraAdjustController.Unlock(this);
		}
		if (!this.FocusCamera)
		{
			this.Camera.CameraFocusController.Unlock(this);
		}
		if (!this.SidestepCamera)
		{
			this.Camera.CameraSidestepController.Unlock(this);
		}
		if (!this.ClimbCamera)
		{
			this.Camera.CameraClimbController.Unlock(this);
		}
		this.AutoCamera = true;
		this.ModifyCamera = true;
		this.AdjustCamera = true;
		this.FocusCamera = true;
		this.SidestepCamera = true;
		this.ClimbCamera = true;
		this.Camera.CameraCollision.IsOpenBlend = true;
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000A9A78 File Offset: 0x000A7C78
	private void UpdateControllersConfig(CameraConfig config)
	{
		this.Camera.SetConfigs(config.DefaultConfig, config.DefaultCurveConfig, config.VehicleConfig, config.VehicleCurveConfig, (config.Tag != null) ? config.Tag.GetValueOrDefault().TagName : FName.NAME_None, config.CameraArmLocationSocketName, config.CameraArmLocationSocketOverrideType, false);
		this.Camera.CameraFocusController.SetConfigsCore(config.FocusConfig, config.CurveFocusConfig);
		this.Camera.CameraInputController.SetConfigsCore(config.InputConfig, config.CurveInputConfig);
		this.Camera.CameraModifyController.SetConfigsCore(config.ModifyConfig, config.CurveModifyConfig);
		this.Camera.CameraAdjustController.SetConfigsCore(config.AdjustConfig, config.CurveAdjustConfig);
		this.Camera.CameraSidestepController.SetConfigsCore(config.SidestepConfig, config.CurveSidestepConfig);
		this.Camera.CameraAutoController.SetConfigsCore(config.AutoConfig, config.CurveAutoConfig);
		this.Camera.CameraGuideController.SetConfigsCore(config.GuideConfig, config.CurveGuideConfig);
		this.Camera.CameraRunningController.SetConfigsCore(config.ExploreConfig, config.CurveExploreConfig);
		this.Camera.CameraDialogueController.SetConfigsCore(config.DialogueConfig, config.CurveDialogueConfig);
		this.Camera.CameraClimbController.SetConfigsCore(config.ClimbConfig, config.CurveClimbConfig);
		this.Camera.CameraGravityController.SetConfigsCore(config.GravityConfig, config.GravityCurveConfig);
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x000A9C0C File Offset: 0x000A7E0C
	private void UpdateControllersLockStateByConfig(CameraConfig config)
	{
		if (!config.EnableAutoCamera)
		{
			this.Camera.CameraAutoController.Lock(this);
			this.AutoCamera = false;
		}
		if (!config.EnableModifyCamera)
		{
			this.Camera.CameraModifyController.Lock(this);
			this.ModifyCamera = false;
		}
		if (!config.EnableAdjustCamera)
		{
			this.Camera.CameraAdjustController.Lock(this);
			this.AdjustCamera = false;
		}
		if (!config.EnableFocusCamera)
		{
			this.Camera.CameraFocusController.Lock(this);
			this.FocusCamera = false;
		}
		if (!config.EnableSidestepCamera)
		{
			this.Camera.CameraSidestepController.Lock(this);
			this.SidestepCamera = false;
		}
		if (!config.EnableClimbCamera)
		{
			this.Camera.CameraClimbController.Lock(this);
			this.ClimbCamera = false;
		}
		this.Camera.CameraCollision.IsOpenBlend = config.IsOpenMainLoop;
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x000A9CF0 File Offset: 0x000A7EF0
	private void ResetAllControllersDefaultConfig()
	{
		this.Camera.ResetDefaultConfig();
		this.Camera.CameraFocusController.ResetDefaultConfig();
		this.Camera.CameraInputController.ResetDefaultConfig();
		this.Camera.CameraModifyController.ResetDefaultConfig();
		this.Camera.CameraAdjustController.ResetDefaultConfig();
		this.Camera.CameraSidestepController.ResetDefaultConfig();
		this.Camera.CameraAutoController.ResetDefaultConfig();
		this.Camera.CameraGuideController.ResetDefaultConfig();
		this.Camera.CameraRunningController.ResetDefaultConfig();
		this.Camera.CameraDialogueController.ResetDefaultConfig();
		this.Camera.CameraClimbController.ResetDefaultConfig();
		this.Camera.CameraGravityController.ResetDefaultConfig();
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x000A9DB8 File Offset: 0x000A7FB8
	public bool CheckIfInAdjustCamera()
	{
		return this.AdjustCameraTagMap.Count > 0 && this.AdjustCameraTagMap.ContainsKey(EAdjustPlayerCamera.Fixed);
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x000A9DD8 File Offset: 0x000A7FD8
	public override void OnEnd()
	{
		base.OnEnd();
		EventSystem.Instance.Remove<EntityHandle, string>(EEventName.CameraCharacterChanged, new Action<EntityHandle, string>(this.OnCameraCharacterChanged));
		EventSystem.Instance.Remove<EntityHandle>(EEventName.OnPlayerFollowerPossessed, new Action<EntityHandle>(this.OnFollowShooterPossessed));
		EventSystem.Instance.Remove(EEventName.OnPlayerFollowerUnPossessed, new Action(this.OnFollowShooterUnPossessed));
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x000A9E40 File Offset: 0x000A8040
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 10:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'I')
					{
						if (c == 'S')
						{
							if (key == "SubConfigs")
							{
								value = this.SubConfigs;
								return true;
							}
						}
					}
					else if (key == "IsFighting")
					{
						value = this.IsFighting;
						return true;
					}
				}
				else if (key == "AutoCamera")
				{
					value = this.AutoCamera;
					return true;
				}
				break;
			}
			case 11:
			{
				char c = key[1];
				if (c != 'i')
				{
					if (c != 'l')
					{
						if (c == 'o')
						{
							if (key == "FocusTarget")
							{
								value = this.FocusTarget;
								return true;
							}
							if (key == "FocusCamera")
							{
								value = this.FocusCamera;
								return true;
							}
						}
					}
					else if (key == "ClimbCamera")
					{
						value = this.ClimbCamera;
						return true;
					}
				}
				else if (key == "FightConfig")
				{
					value = this.FightConfig;
					return true;
				}
				break;
			}
			case 12:
			{
				char c = key[0];
				if (c <= 'C')
				{
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (key == "ConfigsCache")
							{
								value = this.ConfigsCache;
								return true;
							}
						}
					}
					else if (key == "AdjustCamera")
					{
						value = this.AdjustCamera;
						return true;
					}
				}
				else if (c != 'F')
				{
					if (c != 'I')
					{
						if (c == 'M')
						{
							if (key == "ModifyCamera")
							{
								value = this.ModifyCamera;
								return true;
							}
						}
					}
					else if (key == "IsUniqueFade")
					{
						value = this.IsUniqueFade;
						return true;
					}
				}
				else if (key == "FocusConfigs")
				{
					value = this.FocusConfigs;
					return true;
				}
				break;
			}
			case 13:
				if (key == "DefaultConfig")
				{
					value = this.DefaultConfig;
					return true;
				}
				break;
			case 14:
				if (key == "SidestepCamera")
				{
					value = this.SidestepCamera;
					return true;
				}
				break;
			case 15:
				if (key == "FadeInTriggered")
				{
					value = this.FadeInTriggered;
					return true;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c <= 'C')
				{
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (key == "CurrentSubTagSet")
							{
								value = this.CurrentSubTagSet;
								return true;
							}
						}
					}
					else if (key == "AccompanyConfigs")
					{
						value = this.AccompanyConfigs;
						return true;
					}
				}
				else if (c != 'F')
				{
					if (c == 'H')
					{
						if (key == "HasChangedConfig")
						{
							value = this.HasChangedConfig;
							return true;
						}
					}
				}
				else if (key == "FadeOutTriggered")
				{
					value = this.FadeOutTriggered;
					return true;
				}
				break;
			}
			case 17:
			{
				char c = key[1];
				if (c != 'o')
				{
					if (c == 'u')
					{
						if (key == "CurrentConfigList")
						{
							value = this.CurrentConfigList;
							return true;
						}
					}
				}
				else if (key == "ConfigFadeInCurve")
				{
					value = this.ConfigFadeInCurve;
					return true;
				}
				break;
			}
			case 18:
			{
				char c = key[1];
				if (c != 'd')
				{
					if (c != 'o')
					{
						if (c == 'u')
						{
							if (key == "CurrentFocusTagSet")
							{
								value = this.CurrentFocusTagSet;
								return true;
							}
						}
					}
					else if (key == "ConfigFadeOutCurve")
					{
						value = this.ConfigFadeOutCurve;
						return true;
					}
				}
				else if (key == "AdjustCameraTagMap")
				{
					value = this.AdjustCameraTagMap;
					return true;
				}
				break;
			}
			case 19:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'S')
					{
						if (key == "SelfCharacterEntity")
						{
							value = this.SelfCharacterEntity;
							return true;
						}
					}
				}
				else if (key == "CameraConfigCompare")
				{
					value = this.CameraConfigCompare;
					return true;
				}
				break;
			}
			case 20:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'F')
					{
						if (key == "FloatCharacterEntity")
						{
							value = this.FloatCharacterEntity;
							return true;
						}
					}
				}
				else if (key == "ConfigFadeInDuration")
				{
					value = this.ConfigFadeInDuration;
					return true;
				}
				break;
			}
			case 21:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'F')
					{
						if (key == "FocusTargetSocketName")
						{
							value = this.FocusTargetSocketName;
							return true;
						}
					}
				}
				else if (key == "ConfigFadeOutDuration")
				{
					value = this.ConfigFadeOutDuration;
					return true;
				}
				break;
			}
			case 22:
			{
				char c = key[1];
				if (c != 'h')
				{
					if (c == 'u')
					{
						if (key == "CurrentAccompanyTagSet")
						{
							value = this.CurrentAccompanyTagSet;
							return true;
						}
					}
				}
				else if (key == "CharacterCameraConfigs")
				{
					value = this.CharacterCameraConfigs;
					return true;
				}
				break;
			}
			case 27:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'D')
					{
						if (c == 'S')
						{
							if (key == "SelfCharacterEntityInternal")
							{
								value = this.SelfCharacterEntityInternal;
								return true;
							}
						}
					}
					else if (key == "DebugSubCameraModifications")
					{
						value = this.DebugSubCameraModifications;
						return true;
					}
				}
				else if (key == "AdjustCameraEntityHandleSet")
				{
					value = this.AdjustCameraEntityHandleSet;
					return true;
				}
				break;
			}
			case 28:
				if (key == "FloatCharacterEntityInternal")
				{
					value = this.FloatCharacterEntityInternal;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000AA4F0 File Offset: 0x000A86F0
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 10:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'I')
					{
						if (key == "IsFighting")
						{
							this.IsFighting = (bool)value;
							return;
						}
					}
				}
				else if (key == "AutoCamera")
				{
					this.AutoCamera = (bool)value;
					return;
				}
				break;
			}
			case 11:
			{
				char c = key[1];
				if (c != 'i')
				{
					if (c != 'l')
					{
						if (c == 'o')
						{
							if (key == "FocusTarget")
							{
								this.FocusTarget = (Entity)value;
								return;
							}
							if (key == "FocusCamera")
							{
								this.FocusCamera = (bool)value;
								return;
							}
						}
					}
					else if (key == "ClimbCamera")
					{
						this.ClimbCamera = (bool)value;
						return;
					}
				}
				else if (key == "FightConfig")
				{
					this.FightConfig = (CameraConfig)value;
					return;
				}
				break;
			}
			case 12:
			{
				char c = key[0];
				if (c <= 'C')
				{
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (key == "ConfigsCache")
							{
								this.ConfigsCache = (TArray<SCameraConfig>)value;
								return;
							}
						}
					}
					else if (key == "AdjustCamera")
					{
						this.AdjustCamera = (bool)value;
						return;
					}
				}
				else if (c != 'I')
				{
					if (c == 'M')
					{
						if (key == "ModifyCamera")
						{
							this.ModifyCamera = (bool)value;
							return;
						}
					}
				}
				else if (key == "IsUniqueFade")
				{
					this.IsUniqueFade = (bool)value;
					return;
				}
				break;
			}
			case 13:
				if (key == "DefaultConfig")
				{
					this.DefaultConfig = (CameraConfig)value;
					return;
				}
				break;
			case 14:
				if (key == "SidestepCamera")
				{
					this.SidestepCamera = (bool)value;
					return;
				}
				break;
			case 15:
				if (key == "FadeInTriggered")
				{
					this.FadeInTriggered = (bool)value;
					return;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'H')
					{
						if (key == "HasChangedConfig")
						{
							this.HasChangedConfig = (bool)value;
							return;
						}
					}
				}
				else if (key == "FadeOutTriggered")
				{
					this.FadeOutTriggered = (bool)value;
					return;
				}
				break;
			}
			case 17:
				if (key == "ConfigFadeInCurve")
				{
					this.ConfigFadeInCurve = (CurveBase)value;
					return;
				}
				break;
			case 18:
				if (key == "ConfigFadeOutCurve")
				{
					this.ConfigFadeOutCurve = (CurveBase)value;
					return;
				}
				break;
			case 19:
				if (key == "SelfCharacterEntity")
				{
					this.SelfCharacterEntity = (EntityHandle)value;
					return;
				}
				break;
			case 20:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'F')
					{
						if (key == "FloatCharacterEntity")
						{
							this.FloatCharacterEntity = (EntityHandle)value;
							return;
						}
					}
				}
				else if (key == "ConfigFadeInDuration")
				{
					float num2;
					if (value is double)
					{
						double num = (double)value;
						num2 = (float)num;
					}
					else if (value is float)
					{
						float num3 = (float)value;
						num2 = num3;
					}
					else if (value is int)
					{
						int num4 = (int)value;
						num2 = (float)num4;
					}
					else if (value is long)
					{
						long num5 = (long)value;
						num2 = (float)num5;
					}
					else
					{
						num2 = (float)value;
					}
					this.ConfigFadeInDuration = num2;
					return;
				}
				break;
			}
			case 21:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'F')
					{
						if (key == "FocusTargetSocketName")
						{
							this.FocusTargetSocketName = (string)value;
							return;
						}
					}
				}
				else if (key == "ConfigFadeOutDuration")
				{
					float num2;
					if (value is double)
					{
						double num6 = (double)value;
						num2 = (float)num6;
					}
					else if (value is float)
					{
						float num7 = (float)value;
						num2 = num7;
					}
					else if (value is int)
					{
						int num8 = (int)value;
						num2 = (float)num8;
					}
					else if (value is long)
					{
						long num9 = (long)value;
						num2 = (float)num9;
					}
					else
					{
						num2 = (float)value;
					}
					this.ConfigFadeOutDuration = num2;
					return;
				}
				break;
			}
			case 27:
			{
				char c = key[0];
				if (c != 'D')
				{
					if (c == 'S')
					{
						if (key == "SelfCharacterEntityInternal")
						{
							this.SelfCharacterEntityInternal = (EntityHandle)value;
							return;
						}
					}
				}
				else if (key == "DebugSubCameraModifications")
				{
					this.DebugSubCameraModifications = (Dictionary<CameraConfig, Dictionary<string, ValueTuple<float, bool>>>)value;
					return;
				}
				break;
			}
			case 28:
				if (key == "FloatCharacterEntityInternal")
				{
					this.FloatCharacterEntityInternal = (EntityHandle)value;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000AAA72 File Offset: 0x000A8C72
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraConfigController.<MemberIter>d__83 <MemberIter>d__ = new CameraConfigController.<MemberIter>d__83(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040013C7 RID: 5063
	private const int DEFAULT_MAX_FADE_TIME = 10;

	// Token: 0x040013C8 RID: 5064
	private static readonly int NoAimGameplayTag = GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.禁止瞄准模式"];

	// Token: 0x040013C9 RID: 5065
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraConfig> ConfigsCache;

	// Token: 0x040013CA RID: 5066
	[Nullable(2)]
	private CameraConfig DefaultConfig;

	// Token: 0x040013CB RID: 5067
	[Nullable(2)]
	private CameraConfig FightConfig;

	// Token: 0x040013CC RID: 5068
	private readonly Dictionary<int, CameraConfig> SubConfigs = new Dictionary<int, CameraConfig>();

	// Token: 0x040013CD RID: 5069
	private readonly Dictionary<int, CameraConfig> FocusConfigs = new Dictionary<int, CameraConfig>();

	// Token: 0x040013CE RID: 5070
	private readonly Dictionary<int, CameraConfig> AccompanyConfigs = new Dictionary<int, CameraConfig>();

	// Token: 0x040013CF RID: 5071
	private readonly HashSet<int> CurrentSubTagSet = new HashSet<int>();

	// Token: 0x040013D0 RID: 5072
	private readonly HashSet<int> CurrentFocusTagSet = new HashSet<int>();

	// Token: 0x040013D1 RID: 5073
	private readonly HashSet<int> CurrentAccompanyTagSet = new HashSet<int>();

	// Token: 0x040013D2 RID: 5074
	private readonly Comparison<CameraConfig> CameraConfigCompare = (CameraConfig a, CameraConfig b) => a.Priority - b.Priority;

	// Token: 0x040013D3 RID: 5075
	private readonly RbTree<CameraConfig> CurrentConfigList;

	// Token: 0x040013D4 RID: 5076
	private readonly Dictionary<UDataTable, DtCameraConfig> CharacterCameraConfigs = new Dictionary<UDataTable, DtCameraConfig>();

	// Token: 0x040013D5 RID: 5077
	public readonly Dictionary<EAdjustPlayerCamera, int?> AdjustCameraTagMap = new Dictionary<EAdjustPlayerCamera, int?>();

	// Token: 0x040013D6 RID: 5078
	public readonly HashSet<EntityHandle> AdjustCameraEntityHandleSet = new HashSet<EntityHandle>();

	// Token: 0x040013D7 RID: 5079
	private bool IsFighting;

	// Token: 0x040013D8 RID: 5080
	[Nullable(2)]
	private EntityHandle SelfCharacterEntityInternal;

	// Token: 0x040013D9 RID: 5081
	[Nullable(2)]
	private EntityHandle FloatCharacterEntityInternal;

	// Token: 0x040013DA RID: 5082
	[Nullable(2)]
	private Entity FocusTarget;

	// Token: 0x040013DB RID: 5083
	private string FocusTargetSocketName = "";

	// Token: 0x040013DC RID: 5084
	private bool IsUniqueFade;

	// Token: 0x040013DD RID: 5085
	private bool FadeInTriggered;

	// Token: 0x040013DE RID: 5086
	private float ConfigFadeInDuration = 10f;

	// Token: 0x040013DF RID: 5087
	[Nullable(2)]
	private CurveBase ConfigFadeInCurve;

	// Token: 0x040013E0 RID: 5088
	private bool FadeOutTriggered;

	// Token: 0x040013E1 RID: 5089
	private float ConfigFadeOutDuration = 10f;

	// Token: 0x040013E2 RID: 5090
	[Nullable(2)]
	private CurveBase ConfigFadeOutCurve;

	// Token: 0x040013E3 RID: 5091
	public bool AutoCamera = true;

	// Token: 0x040013E4 RID: 5092
	public bool AdjustCamera = true;

	// Token: 0x040013E5 RID: 5093
	public bool ModifyCamera = true;

	// Token: 0x040013E6 RID: 5094
	public bool FocusCamera = true;

	// Token: 0x040013E7 RID: 5095
	public bool SidestepCamera = true;

	// Token: 0x040013E8 RID: 5096
	public bool ClimbCamera = true;

	// Token: 0x040013E9 RID: 5097
	private bool HasChangedConfig = true;

	// Token: 0x040013EA RID: 5098
	[TupleElementNames(new string[]
	{
		"Value",
		"IsEffect"
	})]
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		0
	})]
	public Dictionary<CameraConfig, Dictionary<string, ValueTuple<float, bool>>> DebugSubCameraModifications;
}
