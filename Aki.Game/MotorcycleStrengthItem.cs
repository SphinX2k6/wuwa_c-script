using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F62 RID: 8034
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleStrengthItem : StrengthItemBase
{
	// Token: 0x0600F8D4 RID: 63700 RVA: 0x003C430F File Offset: 0x003C250F
	protected override string GetResourceId()
	{
		return "UiItem_EnergyRide";
	}

	// Token: 0x0600F8D5 RID: 63701 RVA: 0x003C4318 File Offset: 0x003C2518
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F8D6 RID: 63702 RVA: 0x003C44B0 File Offset: 0x003C26B0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleStrengthItem.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleStrengthItem.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8D7 RID: 63703 RVA: 0x003C44F4 File Offset: 0x003C26F4
	protected override void OnStart()
	{
		for (int i = 0; i < 3; i++)
		{
			this.AddSingleStrengthItem(i == 0);
		}
		this.LowEndurancePercent = (float)ConfigCommonParamById.GetIntConfig("LowEndurancePercent").GetValueOrDefault() / 10000f;
		this.SingleStrengthValue = (float)ConfigCommonParamById.GetIntConfig("MotorcycleSingleStrengthValue").GetValueOrDefault();
		this.MaxSingleStrengthItemCount = ConfigCommonParamById.GetIntConfig("MotorcycleMaxSingleStrengthItemCount").GetValueOrDefault(1);
		base.InitTweenAnim(7);
		base.InitTweenAnim(8);
		base.OnStart();
		this.CurBarVisible = false;
		base.GetItem(9).SetAlpha(0f);
		this.RefreshAutoMovingSetting(true);
		this.RefreshAutoMovingTag();
		this.RefreshAutoMoving(true);
		this.RefreshStrengthPercent(true);
	}

	// Token: 0x0600F8D8 RID: 63704 RVA: 0x003C45B4 File Offset: 0x003C27B4
	protected override UniTask OnBeforeHideAsync()
	{
		MotorcycleStrengthItem.<OnBeforeHideAsync>d__24 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleStrengthItem.<OnBeforeHideAsync>d__24>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8D9 RID: 63705 RVA: 0x003C45F7 File Offset: 0x003C27F7
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		this.DestroyAutoMoving();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F8DA RID: 63706 RVA: 0x003C460C File Offset: 0x003C280C
	protected override void OnAddEvents()
	{
		FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthMaxChanged), null);
		EventSystem.Instance.Add<bool>(EEventName.MotorcycleAutoAcceleratorSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Add<bool>(EEventName.MotorcycleAutoNitrogenSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
	}

	// Token: 0x0600F8DB RID: 63707 RVA: 0x003C46A0 File Offset: 0x003C28A0
	protected override void OnRemoveEvents()
	{
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthMaxChanged));
		EventSystem.Instance.Remove<bool>(EEventName.MotorcycleAutoAcceleratorSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Remove<bool>(EEventName.MotorcycleAutoNitrogenSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
	}

	// Token: 0x0600F8DC RID: 63708 RVA: 0x003C4734 File Offset: 0x003C2934
	protected override void OnAddEntityEvents()
	{
		if (this.RoleData == null)
		{
			return;
		}
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		if (gameplayTagComponent == null)
		{
			return;
		}
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]), new Action<int, bool>(this.OnMotorcycleTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.氮气.无限氮气"]), new Action<int, bool>(this.OnLockTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.隐藏氮气条"]), new Action<int, bool>(this.OnHideTagChanged));
	}

	// Token: 0x0600F8DD RID: 63709 RVA: 0x003C47D0 File Offset: 0x003C29D0
	protected override void OnRefreshRoleData()
	{
		if (this.RoleData == null)
		{
			return;
		}
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		this.IsDriving = (gameplayTagComponent != null && gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]));
		BaseTagComponent gameplayTagComponent2 = this.RoleData.GameplayTagComponent;
		this.IsLock = (gameplayTagComponent2 != null && gameplayTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.氮气.无限氮气"]));
		BaseTagComponent gameplayTagComponent3 = this.RoleData.GameplayTagComponent;
		this.IsHideTag = (gameplayTagComponent3 != null && gameplayTagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.隐藏氮气条"]));
		this.RefreshLockState();
		this.RefreshVisible();
	}

	// Token: 0x0600F8DE RID: 63710 RVA: 0x003C4876 File Offset: 0x003C2A76
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F8DF RID: 63711 RVA: 0x003C487F File Offset: 0x003C2A7F
	private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F8E0 RID: 63712 RVA: 0x003C4888 File Offset: 0x003C2A88
	private void OnMotorcycleTagChanged(int tagId, bool tagExists)
	{
		if (this.IsDriving != tagExists)
		{
			this.IsDriving = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F8E1 RID: 63713 RVA: 0x003C48A0 File Offset: 0x003C2AA0
	private void OnLockTagChanged(int tagId, bool tagExists)
	{
		if (this.IsLock != tagExists)
		{
			this.IsLock = tagExists;
			this.RefreshLockState();
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F8E2 RID: 63714 RVA: 0x003C48BE File Offset: 0x003C2ABE
	private void OnHideTagChanged(int tagId, bool tagExists)
	{
		if (this.IsHideTag != tagExists)
		{
			this.IsHideTag = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F8E3 RID: 63715 RVA: 0x003C48D8 File Offset: 0x003C2AD8
	private UUIItem AddSingleStrengthItem(bool isFirst = false)
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		UUIItem uuiitem;
		if (isFirst)
		{
			uuiitem = item2;
		}
		else
		{
			uuiitem = (LguiUtil.Instance.DuplicateActor(item2.GetOwner(), item).GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		}
		this.StrengthSingleLineActorList.Add(uuiitem);
		return uuiitem;
	}

	// Token: 0x0600F8E4 RID: 63716 RVA: 0x003C4930 File Offset: 0x003C2B30
	private void RefreshStrengthPercent(bool bForce = false)
	{
		float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.MotorcycleStrength);
		float max = FormationAttributeController.Instance.GetMax(EFormationAttributeId.MotorcycleStrength);
		bool flag = value != this.StrengthCurrentValue;
		if (flag)
		{
			this.StrengthCurrentValue = value;
		}
		if (max != this.MaxStrengthCurrentValue)
		{
			flag = true;
			this.MaxStrengthCurrentValue = max;
			this.RefreshSingleStrengthItemVisible(max);
		}
		if (flag)
		{
			base.GetSprite(1).SetFillAmount(value / max);
		}
		this.RefreshStrengthState(bForce);
	}

	// Token: 0x0600F8E5 RID: 63717 RVA: 0x003C49A0 File Offset: 0x003C2BA0
	private void RefreshSingleStrengthItemVisible(float maxStrength)
	{
		int num = (int)Math.Floor((double)(maxStrength / this.SingleStrengthValue));
		if (num > this.MaxSingleStrengthItemCount)
		{
			num = this.MaxSingleStrengthItemCount;
		}
		for (int i = 0; i < this.StrengthSingleLineActorList.Count; i++)
		{
			UUIItem uuiitem = this.StrengthSingleLineActorList[i];
			bool flag = i < num;
			if (uuiitem.IsUIActiveSelf() != flag)
			{
				uuiitem.SetUIActive(flag);
			}
		}
		this.RefreshSingleStrengthItemRotation();
	}

	// Token: 0x0600F8E6 RID: 63718 RVA: 0x003C4A0C File Offset: 0x003C2C0C
	private void RefreshSingleStrengthItemRotation()
	{
		int num = (int)Math.Floor((double)(this.MaxStrengthCurrentValue / this.SingleStrengthValue));
		if (num > this.MaxSingleStrengthItemCount)
		{
			num = this.MaxSingleStrengthItemCount;
		}
		float num2 = 360f / (float)num;
		float num3 = 0f;
		for (int i = 0; i < num; i++)
		{
			UUIItem uuiitem = (this.StrengthSingleLineActorList.Count > i) ? this.StrengthSingleLineActorList[i] : null;
			if (uuiitem == null)
			{
				uuiitem = this.AddSingleStrengthItem(false);
			}
			this.RotationCache.Yaw = num3;
			uuiitem.SetUIRelativeRotation(this.RotationCache);
			num3 += num2;
		}
	}

	// Token: 0x0600F8E7 RID: 63719 RVA: 0x003C4AA4 File Offset: 0x003C2CA4
	private void RefreshStrengthState(bool bForce = false)
	{
		float strengthCurrentValue = this.StrengthCurrentValue;
		float maxStrengthCurrentValue = this.MaxStrengthCurrentValue;
		bool bNormal = strengthCurrentValue / maxStrengthCurrentValue > this.LowEndurancePercent;
		this.SetNormal(bNormal, bForce);
		bool flag = strengthCurrentValue >= maxStrengthCurrentValue;
		if (this.IsFullState != flag || bForce)
		{
			this.IsFullState = flag;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F8E8 RID: 63720 RVA: 0x003C4AF8 File Offset: 0x003C2CF8
	private void SetNormal(bool bNormal, bool bForce = false)
	{
		if (this.IsNormalState == bNormal && !bForce)
		{
			return;
		}
		this.IsNormalState = bNormal;
		UUISprite sprite = base.GetSprite(1);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = !bNormal;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUISprite sprite2 = base.GetSprite(2);
		UUIItem uuiitem2 = sprite2;
		bool bUseChangeColor2 = !bNormal;
		fcolor = new FColor?(sprite2.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
	}

	// Token: 0x0600F8E9 RID: 63721 RVA: 0x003C4B59 File Offset: 0x003C2D59
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600F8EA RID: 63722 RVA: 0x003C4B64 File Offset: 0x003C2D64
	private void RefreshVisible()
	{
		bool flag = !this.IsHideTag && (this.IsLock || (this.IsDriving && !this.IsFullState)) && this.EnableByHighPriority;
		bool flag2 = !this.IsHideTag && this.AutoMovingItem.GetTargetVisible();
		bool flag3 = flag || flag2;
		if (this.TargetActive != flag3)
		{
			this.SetActive(flag3);
		}
		if (this.CurBarVisible && !flag)
		{
			this.CurBarVisible = false;
			base.StopTweenAnim(7);
			base.PlayTweenAnim(8);
			return;
		}
		if (!this.CurBarVisible && flag)
		{
			this.CurBarVisible = true;
			base.StopTweenAnim(8);
			base.PlayTweenAnim(7);
		}
	}

	// Token: 0x0600F8EB RID: 63723 RVA: 0x003C4C09 File Offset: 0x003C2E09
	private void RefreshLockState()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLock);
	}

	// Token: 0x0600F8EC RID: 63724 RVA: 0x003C4C22 File Offset: 0x003C2E22
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
		if (this.CloseAnimPromise != null)
		{
			this.CloseAnimPromise.SetResult();
			this.CloseAnimPromise = null;
		}
	}

	// Token: 0x0600F8ED RID: 63725 RVA: 0x003C4C5E File Offset: 0x003C2E5E
	public override void Tick(float delta)
	{
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600F8EE RID: 63726 RVA: 0x003C4C67 File Offset: 0x003C2E67
	private void AutoMovingSettingChanged(bool enable)
	{
		this.RefreshAutoMovingSetting(false);
		this.RefreshAutoMovingTag();
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600F8EF RID: 63727 RVA: 0x003C4C7D File Offset: 0x003C2E7D
	private void OnMotorcycleStateChanged(bool bEnable)
	{
		this.RefreshAutoMovingTag();
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600F8F0 RID: 63728 RVA: 0x003C4C8C File Offset: 0x003C2E8C
	private void RefreshAutoMovingSetting(bool isStart = false)
	{
		BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
		if (this.AutoAcceleratorSettingEnable == motorcycleData.AutoAcceleratorSettingEnable && this.AutoNitrogenSettingEnable == motorcycleData.AutoNitrogenSettingEnable)
		{
			return;
		}
		this.AutoAcceleratorSettingEnable = motorcycleData.AutoAcceleratorSettingEnable;
		this.AutoNitrogenSettingEnable = motorcycleData.AutoNitrogenSettingEnable;
		if (!this.AutoAcceleratorSettingEnable && !this.AutoNitrogenSettingEnable)
		{
			this.SetAutoMovingState(EMotorcycleAutoMovingState.None, 0f, isStart);
		}
	}

	// Token: 0x0600F8F1 RID: 63729 RVA: 0x003C4CF8 File Offset: 0x003C2EF8
	private void RefreshAutoMovingTag()
	{
		this.MotorcycleEntityHandle = null;
		this.ClearMotorcycleTagTask();
		if (!this.AutoAcceleratorSettingEnable && !this.AutoNitrogenSettingEnable)
		{
			return;
		}
		BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
		if (!motorcycleData.IsDriving)
		{
			return;
		}
		this.MotorcycleEntityHandle = motorcycleData.MotorcycleEntityHandle;
		EntityHandle motorcycleEntityHandle = this.MotorcycleEntityHandle;
		if (motorcycleEntityHandle == null || !motorcycleEntityHandle.Valid)
		{
			this.MotorcycleTagComponent = null;
			return;
		}
		this.MotorcycleTagComponent = this.MotorcycleEntityHandle.Entity.GetComponent<BaseTagComponent>();
		this.HasAutoAcceleratorTag = this.MotorcycleTagComponent.HasTag(MotorcycleStrengthItem.autoAcceleratorTagId);
		this.HasAutoNitrogenTag = this.MotorcycleTagComponent.HasTag(MotorcycleStrengthItem.autoNitrogenTagId);
		this.ListenForMotorcycleTagAddOrRemove(this.MotorcycleTagComponent, new int?(MotorcycleStrengthItem.autoAcceleratorTagId), new Action<int, bool>(this.OnAutoAcceleratorTagChange));
		this.ListenForMotorcycleTagAddOrRemove(this.MotorcycleTagComponent, new int?(MotorcycleStrengthItem.autoNitrogenTagId), new Action<int, bool>(this.OnAutoNitrogenTagChange));
	}

	// Token: 0x0600F8F2 RID: 63730 RVA: 0x003C4DE8 File Offset: 0x003C2FE8
	protected void ListenForMotorcycleTagAddOrRemove(BaseTagComponent tagComponent, int? tagId, Action<int, bool> callback)
	{
		ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(tagId, new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), null);
		if (tagTask != null)
		{
			this.MotorcycleTagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600F8F3 RID: 63731 RVA: 0x003C4E1C File Offset: 0x003C301C
	protected void ClearMotorcycleTagTask()
	{
		foreach (ITagTask tagTask in this.MotorcycleTagTaskList)
		{
			tagTask.EndTask();
		}
		this.MotorcycleTagTaskList.Clear();
	}

	// Token: 0x0600F8F4 RID: 63732 RVA: 0x003C4E78 File Offset: 0x003C3078
	private void OnAutoAcceleratorTagChange(int tagId, bool tagExists)
	{
		this.HasAutoAcceleratorTag = tagExists;
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600F8F5 RID: 63733 RVA: 0x003C4E88 File Offset: 0x003C3088
	private void OnAutoNitrogenTagChange(int tagId, bool tagExists)
	{
		this.HasAutoNitrogenTag = tagExists;
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600F8F6 RID: 63734 RVA: 0x003C4E98 File Offset: 0x003C3098
	private void RefreshAutoMoving(bool isStart = false)
	{
		if (!this.AutoAcceleratorSettingEnable && !this.AutoNitrogenSettingEnable)
		{
			return;
		}
		EntityHandle motorcycleEntityHandle = this.MotorcycleEntityHandle;
		MotorcycleInputComponent motorcycleInputComponent;
		if (motorcycleEntityHandle == null)
		{
			motorcycleInputComponent = null;
		}
		else
		{
			WorldEntity entity = motorcycleEntityHandle.Entity;
			motorcycleInputComponent = ((entity != null) ? entity.GetComponent<MotorcycleInputComponent>() : null);
		}
		MotorcycleInputComponent motorcycleInputComponent2 = motorcycleInputComponent;
		if (motorcycleInputComponent2 == null)
		{
			return;
		}
		if (this.AutoNitrogenSettingEnable)
		{
			if (this.HasAutoNitrogenTag)
			{
				this.SetAutoMovingState(EMotorcycleAutoMovingState.AutoNitrogen, 1f, isStart);
				return;
			}
			MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo = motorcycleInputComponent2.GetNitroBoostInfo();
			if (nitroBoostInfo != null)
			{
				double duration = nitroBoostInfo.GetDuration();
				double currentTime = nitroBoostInfo.GetCurrentTime();
				if (currentTime > 0.0)
				{
					this.SetAutoMovingState(EMotorcycleAutoMovingState.Nitrogen, (float)(currentTime / duration), isStart);
					return;
				}
			}
		}
		if (this.AutoAcceleratorSettingEnable)
		{
			if (this.HasAutoAcceleratorTag)
			{
				this.SetAutoMovingState(EMotorcycleAutoMovingState.AutoAccelerator, 1f, isStart);
				return;
			}
			MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo = motorcycleInputComponent2.GetHoldThrottleInfo();
			if (holdThrottleInfo != null)
			{
				double duration2 = holdThrottleInfo.GetDuration();
				double currentTime2 = holdThrottleInfo.GetCurrentTime();
				if (currentTime2 > 0.0)
				{
					this.SetAutoMovingState(EMotorcycleAutoMovingState.Accelerator, (float)currentTime2 / (float)duration2, isStart);
					return;
				}
			}
		}
		this.SetAutoMovingState(EMotorcycleAutoMovingState.None, 0f, isStart);
	}

	// Token: 0x0600F8F7 RID: 63735 RVA: 0x003C4F90 File Offset: 0x003C3190
	private void SetAutoMovingState(EMotorcycleAutoMovingState state, float percent = 0f, bool isStart = false)
	{
		if (this.AutoMovingItem == null)
		{
			return;
		}
		if (this.AutoMovingState == state)
		{
			if (this.AutoMovingState == EMotorcycleAutoMovingState.Nitrogen)
			{
				this.AutoMovingItem.SetPercentNitrogen(percent);
				return;
			}
			if (this.AutoMovingState == EMotorcycleAutoMovingState.Accelerator)
			{
				this.AutoMovingItem.SetPercentAccelerator(percent);
			}
			return;
		}
		else
		{
			this.AutoMovingState = state;
			if (state == EMotorcycleAutoMovingState.None)
			{
				this.AutoMovingItem.SetVisible(false);
				if (!isStart)
				{
					this.RefreshVisible();
				}
				return;
			}
			this.AutoMovingItem.SetVisible(true);
			bool flag = state == EMotorcycleAutoMovingState.AutoNitrogen || state == EMotorcycleAutoMovingState.Nitrogen;
			this.AutoMovingItem.SetNitrogen(flag);
			if (flag)
			{
				this.AutoMovingItem.SetPercentNitrogen(percent);
			}
			else
			{
				this.AutoMovingItem.SetPercentAccelerator(percent);
			}
			if (!isStart)
			{
				this.RefreshVisible();
			}
			return;
		}
	}

	// Token: 0x0600F8F8 RID: 63736 RVA: 0x003C5045 File Offset: 0x003C3245
	private void DestroyAutoMoving()
	{
		this.ClearMotorcycleTagTask();
		this.MotorcycleEntityHandle = null;
		this.MotorcycleTagComponent = null;
	}

	// Token: 0x040073E4 RID: 29668
	private const int CLOSE_ANIM_TIME = 250;

	// Token: 0x040073E5 RID: 29669
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 3;

	// Token: 0x040073E6 RID: 29670
	private static readonly int autoAcceleratorTagId = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.油门维持"];

	// Token: 0x040073E7 RID: 29671
	private static readonly int autoNitrogenTagId = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.氮气维持"];

	// Token: 0x040073E8 RID: 29672
	private bool IsNormalState = true;

	// Token: 0x040073E9 RID: 29673
	private bool IsFullState = true;

	// Token: 0x040073EA RID: 29674
	private bool IsDriving;

	// Token: 0x040073EB RID: 29675
	private bool IsLock;

	// Token: 0x040073EC RID: 29676
	private bool IsHideTag;

	// Token: 0x040073ED RID: 29677
	private float LowEndurancePercent;

	// Token: 0x040073EE RID: 29678
	private float SingleStrengthValue;

	// Token: 0x040073EF RID: 29679
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x040073F0 RID: 29680
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x040073F1 RID: 29681
	private float StrengthCurrentValue;

	// Token: 0x040073F2 RID: 29682
	private float MaxStrengthCurrentValue;

	// Token: 0x040073F3 RID: 29683
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);

	// Token: 0x040073F4 RID: 29684
	private bool CurBarVisible;

	// Token: 0x040073F5 RID: 29685
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x040073F6 RID: 29686
	[Nullable(2)]
	private CustomPromise CloseAnimPromise;

	// Token: 0x040073F7 RID: 29687
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("MotorcycleStrengthCloseAnim", "", "");

	// Token: 0x040073F8 RID: 29688
	private bool AutoAcceleratorSettingEnable;

	// Token: 0x040073F9 RID: 29689
	private bool AutoNitrogenSettingEnable;

	// Token: 0x040073FA RID: 29690
	[Nullable(2)]
	private MotorcycleAutoMovingItem AutoMovingItem;

	// Token: 0x040073FB RID: 29691
	private EMotorcycleAutoMovingState AutoMovingState;

	// Token: 0x040073FC RID: 29692
	[Nullable(2)]
	private EntityHandle MotorcycleEntityHandle;

	// Token: 0x040073FD RID: 29693
	[Nullable(2)]
	private BaseTagComponent MotorcycleTagComponent;

	// Token: 0x040073FE RID: 29694
	private bool HasAutoAcceleratorTag;

	// Token: 0x040073FF RID: 29695
	private bool HasAutoNitrogenTag;

	// Token: 0x04007400 RID: 29696
	protected readonly List<ITagTask> MotorcycleTagTaskList = new List<ITagTask>();
}
