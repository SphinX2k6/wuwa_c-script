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

// Token: 0x02001424 RID: 5156
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleStrengthItem : StrengthItemBase
{
	// Token: 0x0600CCF3 RID: 52467 RVA: 0x003CFDFB File Offset: 0x003CDFFB
	protected override string GetResourceId()
	{
		return "UiItem_EnergyRide";
	}

	// Token: 0x0600CCF4 RID: 52468 RVA: 0x003CFE04 File Offset: 0x003CE004
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

	// Token: 0x0600CCF5 RID: 52469 RVA: 0x003CFF9C File Offset: 0x003CE19C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleStrengthItem.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleStrengthItem.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CCF6 RID: 52470 RVA: 0x003CFFE0 File Offset: 0x003CE1E0
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

	// Token: 0x0600CCF7 RID: 52471 RVA: 0x003D00A0 File Offset: 0x003CE2A0
	protected override UniTask OnBeforeHideAsync()
	{
		MotorcycleStrengthItem.<OnBeforeHideAsync>d__24 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleStrengthItem.<OnBeforeHideAsync>d__24>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CCF8 RID: 52472 RVA: 0x003D00E3 File Offset: 0x003CE2E3
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		this.DestroyAutoMoving();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CCF9 RID: 52473 RVA: 0x003D00F8 File Offset: 0x003CE2F8
	protected override void OnAddEvents()
	{
		FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthMaxChanged), null);
		EventSystem.Instance.Add<bool>(EEventName.MotorcycleAutoAcceleratorSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Add<bool>(EEventName.MotorcycleAutoNitrogenSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
	}

	// Token: 0x0600CCFA RID: 52474 RVA: 0x003D018C File Offset: 0x003CE38C
	protected override void OnRemoveEvents()
	{
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthMaxChanged));
		EventSystem.Instance.Remove<bool>(EEventName.MotorcycleAutoAcceleratorSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Remove<bool>(EEventName.MotorcycleAutoNitrogenSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
	}

	// Token: 0x0600CCFB RID: 52475 RVA: 0x003D0220 File Offset: 0x003CE420
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

	// Token: 0x0600CCFC RID: 52476 RVA: 0x003D02BC File Offset: 0x003CE4BC
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

	// Token: 0x0600CCFD RID: 52477 RVA: 0x003D0362 File Offset: 0x003CE562
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600CCFE RID: 52478 RVA: 0x003D036B File Offset: 0x003CE56B
	private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600CCFF RID: 52479 RVA: 0x003D0374 File Offset: 0x003CE574
	private void OnMotorcycleTagChanged(int tagId, bool tagExists)
	{
		if (this.IsDriving != tagExists)
		{
			this.IsDriving = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CD00 RID: 52480 RVA: 0x003D038C File Offset: 0x003CE58C
	private void OnLockTagChanged(int tagId, bool tagExists)
	{
		if (this.IsLock != tagExists)
		{
			this.IsLock = tagExists;
			this.RefreshLockState();
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CD01 RID: 52481 RVA: 0x003D03AA File Offset: 0x003CE5AA
	private void OnHideTagChanged(int tagId, bool tagExists)
	{
		if (this.IsHideTag != tagExists)
		{
			this.IsHideTag = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CD02 RID: 52482 RVA: 0x003D03C4 File Offset: 0x003CE5C4
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

	// Token: 0x0600CD03 RID: 52483 RVA: 0x003D041C File Offset: 0x003CE61C
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

	// Token: 0x0600CD04 RID: 52484 RVA: 0x003D048C File Offset: 0x003CE68C
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

	// Token: 0x0600CD05 RID: 52485 RVA: 0x003D04F8 File Offset: 0x003CE6F8
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

	// Token: 0x0600CD06 RID: 52486 RVA: 0x003D0590 File Offset: 0x003CE790
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

	// Token: 0x0600CD07 RID: 52487 RVA: 0x003D05E4 File Offset: 0x003CE7E4
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

	// Token: 0x0600CD08 RID: 52488 RVA: 0x003D0645 File Offset: 0x003CE845
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600CD09 RID: 52489 RVA: 0x003D0650 File Offset: 0x003CE850
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

	// Token: 0x0600CD0A RID: 52490 RVA: 0x003D06F5 File Offset: 0x003CE8F5
	private void RefreshLockState()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLock);
	}

	// Token: 0x0600CD0B RID: 52491 RVA: 0x003D070E File Offset: 0x003CE90E
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

	// Token: 0x0600CD0C RID: 52492 RVA: 0x003D074A File Offset: 0x003CE94A
	public override void Tick(float delta)
	{
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600CD0D RID: 52493 RVA: 0x003D0753 File Offset: 0x003CE953
	private void AutoMovingSettingChanged(bool enable)
	{
		this.RefreshAutoMovingSetting(false);
		this.RefreshAutoMovingTag();
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600CD0E RID: 52494 RVA: 0x003D0769 File Offset: 0x003CE969
	private void OnMotorcycleStateChanged(bool bEnable)
	{
		this.RefreshAutoMovingTag();
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600CD0F RID: 52495 RVA: 0x003D0778 File Offset: 0x003CE978
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

	// Token: 0x0600CD10 RID: 52496 RVA: 0x003D07E4 File Offset: 0x003CE9E4
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

	// Token: 0x0600CD11 RID: 52497 RVA: 0x003D08D4 File Offset: 0x003CEAD4
	protected void ListenForMotorcycleTagAddOrRemove(BaseTagComponent tagComponent, int? tagId, Action<int, bool> callback)
	{
		ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(tagId, new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), null);
		if (tagTask != null)
		{
			this.MotorcycleTagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600CD12 RID: 52498 RVA: 0x003D0908 File Offset: 0x003CEB08
	protected void ClearMotorcycleTagTask()
	{
		foreach (ITagTask tagTask in this.MotorcycleTagTaskList)
		{
			tagTask.EndTask();
		}
		this.MotorcycleTagTaskList.Clear();
	}

	// Token: 0x0600CD13 RID: 52499 RVA: 0x003D0964 File Offset: 0x003CEB64
	private void OnAutoAcceleratorTagChange(int tagId, bool tagExists)
	{
		this.HasAutoAcceleratorTag = tagExists;
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600CD14 RID: 52500 RVA: 0x003D0974 File Offset: 0x003CEB74
	private void OnAutoNitrogenTagChange(int tagId, bool tagExists)
	{
		this.HasAutoNitrogenTag = tagExists;
		this.RefreshAutoMoving(false);
	}

	// Token: 0x0600CD15 RID: 52501 RVA: 0x003D0984 File Offset: 0x003CEB84
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

	// Token: 0x0600CD16 RID: 52502 RVA: 0x003D0A7C File Offset: 0x003CEC7C
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

	// Token: 0x0600CD17 RID: 52503 RVA: 0x003D0B31 File Offset: 0x003CED31
	private void DestroyAutoMoving()
	{
		this.ClearMotorcycleTagTask();
		this.MotorcycleEntityHandle = null;
		this.MotorcycleTagComponent = null;
	}

	// Token: 0x040074C5 RID: 29893
	private const int CLOSE_ANIM_TIME = 250;

	// Token: 0x040074C6 RID: 29894
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 3;

	// Token: 0x040074C7 RID: 29895
	private static readonly int autoAcceleratorTagId = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.油门维持"];

	// Token: 0x040074C8 RID: 29896
	private static readonly int autoNitrogenTagId = GameplayTagDefine.EGameplayTagId["载具.摩托.移动.氮气维持"];

	// Token: 0x040074C9 RID: 29897
	private bool IsNormalState = true;

	// Token: 0x040074CA RID: 29898
	private bool IsFullState = true;

	// Token: 0x040074CB RID: 29899
	private bool IsDriving;

	// Token: 0x040074CC RID: 29900
	private bool IsLock;

	// Token: 0x040074CD RID: 29901
	private bool IsHideTag;

	// Token: 0x040074CE RID: 29902
	private float LowEndurancePercent;

	// Token: 0x040074CF RID: 29903
	private float SingleStrengthValue;

	// Token: 0x040074D0 RID: 29904
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x040074D1 RID: 29905
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x040074D2 RID: 29906
	private float StrengthCurrentValue;

	// Token: 0x040074D3 RID: 29907
	private float MaxStrengthCurrentValue;

	// Token: 0x040074D4 RID: 29908
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);

	// Token: 0x040074D5 RID: 29909
	private bool CurBarVisible;

	// Token: 0x040074D6 RID: 29910
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x040074D7 RID: 29911
	[Nullable(2)]
	private CustomPromise CloseAnimPromise;

	// Token: 0x040074D8 RID: 29912
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("MotorcycleStrengthCloseAnim", "", "");

	// Token: 0x040074D9 RID: 29913
	private bool AutoAcceleratorSettingEnable;

	// Token: 0x040074DA RID: 29914
	private bool AutoNitrogenSettingEnable;

	// Token: 0x040074DB RID: 29915
	[Nullable(2)]
	private MotorcycleAutoMovingItem AutoMovingItem;

	// Token: 0x040074DC RID: 29916
	private EMotorcycleAutoMovingState AutoMovingState;

	// Token: 0x040074DD RID: 29917
	[Nullable(2)]
	private EntityHandle MotorcycleEntityHandle;

	// Token: 0x040074DE RID: 29918
	[Nullable(2)]
	private BaseTagComponent MotorcycleTagComponent;

	// Token: 0x040074DF RID: 29919
	private bool HasAutoAcceleratorTag;

	// Token: 0x040074E0 RID: 29920
	private bool HasAutoNitrogenTag;

	// Token: 0x040074E1 RID: 29921
	protected readonly List<ITagTask> MotorcycleTagTaskList = new List<ITagTask>();
}
