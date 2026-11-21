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

// Token: 0x02001425 RID: 5157
[NullableContext(1)]
[Nullable(0)]
public class StrengthItem : StrengthItemBase
{
	// Token: 0x0600CD1B RID: 52507 RVA: 0x003D0C11 File Offset: 0x003CEE11
	protected virtual int ResolveChildType(int name)
	{
		return name;
	}

	// Token: 0x0600CD1C RID: 52508 RVA: 0x003D0C14 File Offset: 0x003CEE14
	[NullableContext(2)]
	protected new UUIItem GetItem(int name)
	{
		return base.GetItem(this.ResolveChildType(name));
	}

	// Token: 0x0600CD1D RID: 52509 RVA: 0x003D0C23 File Offset: 0x003CEE23
	[NullableContext(2)]
	protected new UUISprite GetSprite(int name)
	{
		return base.GetSprite(this.ResolveChildType(name));
	}

	// Token: 0x0600CD1E RID: 52510 RVA: 0x003D0C34 File Offset: 0x003CEE34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 22;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CD1F RID: 52511 RVA: 0x003D0F40 File Offset: 0x003CF140
	protected override UniTask OnBeforeStartAsync()
	{
		StrengthItem.<OnBeforeStartAsync>d__47 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<StrengthItem.<OnBeforeStartAsync>d__47>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD20 RID: 52512 RVA: 0x003D0F84 File Offset: 0x003CF184
	protected override void OnStart()
	{
		this.RootItem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		this.RootItem.SetPivot(new FVector2D(0.5f, 0.5f));
		this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
		for (int i = 0; i < 5; i++)
		{
			this.AddSingleStrengthItem(i == 0);
		}
		for (int j = 0; j < 1; j++)
		{
			this.AddTemporarySingleStrengthItem(j == 0);
		}
		this.LowEndurancePercent = (float)ConfigCommonParamById.GetIntConfig("LowEndurancePercent").GetValueOrDefault() / 10000f;
		this.SingleStrengthValue = (float)ConfigCommonParamById.GetIntConfig("SingleStrengthValue").GetValueOrDefault();
		this.MaxSingleStrengthItemCount = ConfigCommonParamById.GetIntConfig("MaxSingleStrengthItemCount").GetValueOrDefault(1);
		this.SingleTemporaryStrengthValue = (float)ConfigCommonParamById.GetIntConfig("SingleTemporaryStrengthValue").GetValueOrDefault();
		this.CurrentTemporaryStrengthPercent = 0f;
		this.TargetTemporaryStrengthPercent = 0f;
		this.StrengthVisible = false;
		this.InitUi();
		this.InitAllTweenAnim();
		this.RefreshStrengthPercent();
		this.RefreshTemporaryPercent();
		this.RefreshTemporaryVisible();
		this.RefreshSingleStrengthItemRotation();
		this.RefreshAutoMovingSetting(true);
		this.RefreshAutoMoving();
		this.RefreshVisible();
		base.OnStart();
	}

	// Token: 0x0600CD21 RID: 52513 RVA: 0x003D10BA File Offset: 0x003CF2BA
	protected virtual void InitUi()
	{
		UUIItem item = this.GetItem(1);
		if (item != null)
		{
			item.SetAlpha(0f);
		}
		UUIItem item2 = this.GetItem(11);
		if (item2 == null)
		{
			return;
		}
		item2.SetAlpha(0f);
	}

	// Token: 0x0600CD22 RID: 52514 RVA: 0x003D10EA File Offset: 0x003CF2EA
	protected override void OnBeforeDestroy()
	{
		this.IsTemporaryVisible = false;
		this.IsStarted = false;
		this.DestroyCloseAnimTimer();
		this.DestroyFullAnimTimer();
		this.DestroyTempCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CD23 RID: 52515 RVA: 0x003D1114 File Offset: 0x003CF314
	protected override void OnAddEvents()
	{
		if (EventSystem.Instance.Has<bool>(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged)))
		{
			this.OnRemoveEvents();
		}
		EventSystem.Instance.Add<bool>(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthMaxChanged), null);
	}

	// Token: 0x0600CD24 RID: 52516 RVA: 0x003D1190 File Offset: 0x003CF390
	protected override void OnRemoveEvents()
	{
		if (EventSystem.Instance.Has<bool>(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged)))
		{
			EventSystem.Instance.Remove<bool>(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		}
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthMaxChanged));
	}

	// Token: 0x0600CD25 RID: 52517 RVA: 0x003D1204 File Offset: 0x003CF404
	protected override void OnAddEntityEvents()
	{
		BattleUiRoleData roleData = this.RoleData;
		BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
		if (baseTagComponent == null)
		{
			return;
		}
		base.ListenForTagAddOrRemove(baseTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.人物属性.体力增益"]), new Action<int, bool>(this.OnStrengthBuff));
		base.ListenForTagAddOrRemove(baseTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.人物属性.体力减益"]), new Action<int, bool>(this.OnStrengthDeBuff));
		base.ListenForTagAddOrRemove(baseTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.人物属性.体力禁用"]), new Action<int, bool>(this.OnStrengthDisable));
		base.ListenForTagAddOrRemove(baseTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFFID.体力恢复"]), new Action<int, bool>(this.OnStrengthRecover));
		base.ListenForTagAddOrRemove(baseTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]), new Action<int, bool>(this.OnEnterAutoMoving));
	}

	// Token: 0x0600CD26 RID: 52518 RVA: 0x003D12EC File Offset: 0x003CF4EC
	protected override void OnRefreshRoleData()
	{
		if (this.RoleData == null)
		{
			return;
		}
		this.RefreshBuffState();
		this.RefreshEnableState();
		this.RefreshTemporaryVisible();
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		this.HasAutoMovingTag = (gameplayTagComponent != null && gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]));
	}

	// Token: 0x0600CD27 RID: 52519 RVA: 0x003D1340 File Offset: 0x003CF540
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600CD28 RID: 52520 RVA: 0x003D1348 File Offset: 0x003CF548
	public override void Tick(float delta)
	{
		this.LerpTemporaryPercent(delta);
		this.RefreshAutoMoving();
	}

	// Token: 0x0600CD29 RID: 52521 RVA: 0x003D1357 File Offset: 0x003CF557
	private void AutoMovingSettingChanged(bool enable)
	{
		this.RefreshAutoMovingSetting(false);
		this.RefreshAutoMoving();
	}

	// Token: 0x0600CD2A RID: 52522 RVA: 0x003D1368 File Offset: 0x003CF568
	private void RefreshStrengthPercent()
	{
		this.StrengthCurrentValue = FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength);
		this.MaxStrengthBaseValue = FormationAttributeController.Instance.GetBaseMax(EFormationAttributeId.Strength);
		this.MaxStrengthCurrentValue = FormationAttributeController.Instance.GetMax(EFormationAttributeId.Strength);
		this.SetStrengthPercent(this.StrengthCurrentValue, this.MaxStrengthBaseValue);
	}

	// Token: 0x0600CD2B RID: 52523 RVA: 0x003D13BC File Offset: 0x003CF5BC
	private void RefreshSingleStrengthItemRotation()
	{
		float maxStrength = this.MaxStrengthCurrentValue - this.MaxStrengthBaseValue;
		this.RefreshSingleStrengthItemRotationInner(this.MaxStrengthBaseValue);
		this.RefreshSingleTemporaryStrengthItemRotation(maxStrength);
		this.RefreshSingleTemporaryStrengthItemVisible(maxStrength);
	}

	// Token: 0x0600CD2C RID: 52524 RVA: 0x003D13F4 File Offset: 0x003CF5F4
	private void RefreshStrengthState()
	{
		if (this.CanRefreshTemporaryStrength())
		{
			if (this.GetTemporaryStrength() > 0f)
			{
				this.SetTemporaryVisible(true);
				this.PlayTemporaryAnim(true);
			}
			else
			{
				this.PlayTemporaryAnim(false);
			}
		}
		else
		{
			this.SetTemporaryVisible(false);
		}
		if (this.StrengthCurrentValue >= this.MaxStrengthCurrentValue)
		{
			if (this.StrengthState == StrengthItem.EState.Full)
			{
				return;
			}
			this.StrengthState = StrengthItem.EState.Full;
			this.SetNone(false);
			this.StopNoneAnim();
			this.SetNormal(true);
			this.PlayFullAnim();
			return;
		}
		else if (this.StrengthCurrentValue <= 0f)
		{
			if (this.StrengthState == StrengthItem.EState.None)
			{
				return;
			}
			this.StrengthState = StrengthItem.EState.None;
			this.SetNone(true);
			this.PlayNoneAnim();
			return;
		}
		else
		{
			bool flag = this.StrengthCurrentValue / this.MaxStrengthCurrentValue > this.LowEndurancePercent;
			StrengthItem.EState estate = flag ? StrengthItem.EState.Normal : StrengthItem.EState.Low;
			if (this.StrengthState == estate)
			{
				return;
			}
			this.StrengthState = estate;
			this.SetNone(false);
			this.StopNoneAnim();
			this.SetNormal(flag);
			this.StrengthVisible = true;
			this.RefreshVisible();
			this.PlayStartAnim();
			return;
		}
	}

	// Token: 0x0600CD2D RID: 52525 RVA: 0x003D14F1 File Offset: 0x003CF6F1
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent();
		this.RefreshTemporaryPercent();
		this.RefreshStrengthState();
	}

	// Token: 0x0600CD2E RID: 52526 RVA: 0x003D1505 File Offset: 0x003CF705
	private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent();
		this.RefreshSingleStrengthItemRotation();
	}

	// Token: 0x0600CD2F RID: 52527 RVA: 0x003D1513 File Offset: 0x003CF713
	private void OnStrengthBuff(int tagId, bool tagExists)
	{
		this.SetBuff(tagExists ? StrengthItem.EStrengthBuffType.Buff : StrengthItem.EStrengthBuffType.None);
	}

	// Token: 0x0600CD30 RID: 52528 RVA: 0x003D1522 File Offset: 0x003CF722
	private void OnStrengthDeBuff(int tagId, bool tagExists)
	{
		this.SetBuff(tagExists ? StrengthItem.EStrengthBuffType.DeBuff : StrengthItem.EStrengthBuffType.None);
	}

	// Token: 0x0600CD31 RID: 52529 RVA: 0x003D1531 File Offset: 0x003CF731
	private void OnStrengthDisable(int tagId, bool tagExists)
	{
		this.SetEnable(!tagExists);
	}

	// Token: 0x0600CD32 RID: 52530 RVA: 0x003D153D File Offset: 0x003CF73D
	private void OnStrengthRecover(int tagId, bool tagExists)
	{
		this.PlayPickUpAnim();
	}

	// Token: 0x0600CD33 RID: 52531 RVA: 0x003D1545 File Offset: 0x003CF745
	private void OnEnterAutoMoving(int tagId, bool tagExists)
	{
		this.HasAutoMovingTag = tagExists;
	}

	// Token: 0x0600CD34 RID: 52532 RVA: 0x003D1550 File Offset: 0x003CF750
	protected virtual void SetNormal(bool bNormal)
	{
		if (this.IsNormalState == bNormal)
		{
			return;
		}
		this.IsNormalState = bNormal;
		UUIItem item = this.GetItem(0);
		UUIItem item2 = this.GetItem(1);
		if (item.IsUIActiveSelf() == bNormal)
		{
			item.SetUIActive(!bNormal);
		}
		if (item.IsUIActiveSelf() != bNormal)
		{
			item2.SetUIActive(bNormal);
		}
	}

	// Token: 0x0600CD35 RID: 52533 RVA: 0x003D15A4 File Offset: 0x003CF7A4
	private void SetBuff(StrengthItem.EStrengthBuffType buffType)
	{
		if (this.BuffType == buffType)
		{
			return;
		}
		this.BuffType = buffType;
		UUIItem item = this.GetItem(4);
		UUIItem item2 = this.GetItem(5);
		switch (buffType)
		{
		case StrengthItem.EStrengthBuffType.None:
			if (item.IsUIActiveSelf())
			{
				item.SetUIActive(false);
			}
			if (item2.IsUIActiveSelf())
			{
				item2.SetUIActive(false);
				return;
			}
			break;
		case StrengthItem.EStrengthBuffType.Buff:
			if (!item.IsUIActiveSelf())
			{
				item.SetUIActive(true);
			}
			if (item2.IsUIActiveSelf())
			{
				item2.SetUIActive(false);
				return;
			}
			break;
		case StrengthItem.EStrengthBuffType.DeBuff:
			if (item.IsUIActiveSelf())
			{
				item.SetUIActive(false);
			}
			if (!item2.IsUIActiveSelf())
			{
				item2.SetUIActive(true);
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600CD36 RID: 52534 RVA: 0x003D1644 File Offset: 0x003CF844
	protected void SetEnable(bool bEnable)
	{
		UUIItem item = this.GetItem(6);
		if (item.IsUIActiveSelf() != bEnable)
		{
			return;
		}
		item.SetUIActive(!bEnable);
	}

	// Token: 0x0600CD37 RID: 52535 RVA: 0x003D1670 File Offset: 0x003CF870
	protected void SetNone(bool bNone)
	{
		UUIItem item = this.GetItem(2);
		if (item.IsUIActiveSelf() == bNone)
		{
			return;
		}
		item.SetUIActive(bNone);
	}

	// Token: 0x0600CD38 RID: 52536 RVA: 0x003D1698 File Offset: 0x003CF898
	protected bool SetStrengthPercent(float strength, float maxStrength)
	{
		if (this.Strength == strength)
		{
			return false;
		}
		this.Strength = strength;
		float fillAmount = (maxStrength <= 0f) ? 0f : (strength / maxStrength);
		this.GetSprite(8).SetFillAmount(fillAmount);
		this.GetSprite(7).SetFillAmount(fillAmount);
		this.RefreshSingleStrengthItemVisible(maxStrength);
		return true;
	}

	// Token: 0x0600CD39 RID: 52537 RVA: 0x003D16EC File Offset: 0x003CF8EC
	private void RefreshSingleStrengthItemRotationInner(float maxStrength)
	{
		int num = (int)Math.Floor((double)(maxStrength / this.SingleStrengthValue));
		if (num > this.MaxSingleStrengthItemCount)
		{
			num = this.MaxSingleStrengthItemCount;
		}
		float num2 = 360f / (float)num;
		float num3 = 0f;
		for (int i = 0; i < num; i++)
		{
			UUIItem uuiitem = (i < this.StrengthSingleLineActorList.Count) ? this.StrengthSingleLineActorList[i] : this.AddSingleStrengthItem(false);
			this.RotationCache.Yaw = num3;
			uuiitem.SetUIRelativeRotation(this.RotationCache);
			num3 += num2;
		}
	}

	// Token: 0x0600CD3A RID: 52538 RVA: 0x003D1774 File Offset: 0x003CF974
	private void RefreshSingleStrengthItemVisible(float maxStrength)
	{
		int num = (int)Math.Floor((double)(maxStrength / this.SingleStrengthValue));
		if (num > this.MaxSingleStrengthItemCount)
		{
			num = this.MaxSingleStrengthItemCount;
		}
		for (int i = 0; i < this.StrengthSingleLineActorList.Count; i++)
		{
			bool flag = i < num;
			UUIItem uuiitem = this.StrengthSingleLineActorList[i];
			if (uuiitem.IsUIActiveSelf() != flag)
			{
				uuiitem.SetUIActive(flag);
			}
		}
	}

	// Token: 0x0600CD3B RID: 52539 RVA: 0x003D17DC File Offset: 0x003CF9DC
	private UUIItem AddSingleStrengthItem(bool isFirst = false)
	{
		UUIItem item = this.GetItem(11);
		UUIItem item2 = this.GetItem(10);
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

	// Token: 0x0600CD3C RID: 52540 RVA: 0x003D1838 File Offset: 0x003CFA38
	private void RefreshBuffState()
	{
		BattleUiRoleData roleData = this.RoleData;
		bool flag;
		if (roleData == null)
		{
			flag = false;
		}
		else
		{
			BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
			flag = ((gameplayTagComponent != null) ? new bool?(gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.人物属性.体力增益"])) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.SetBuff(StrengthItem.EStrengthBuffType.Buff);
			return;
		}
		BattleUiRoleData roleData2 = this.RoleData;
		bool flag2;
		if (roleData2 == null)
		{
			flag2 = false;
		}
		else
		{
			BaseTagComponent gameplayTagComponent2 = roleData2.GameplayTagComponent;
			flag2 = ((gameplayTagComponent2 != null) ? new bool?(gameplayTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["功能.人物属性.体力减益"])) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			this.SetBuff(StrengthItem.EStrengthBuffType.DeBuff);
			return;
		}
		this.SetBuff(StrengthItem.EStrengthBuffType.None);
	}

	// Token: 0x0600CD3D RID: 52541 RVA: 0x003D18E4 File Offset: 0x003CFAE4
	private void RefreshEnableState()
	{
		BattleUiRoleData roleData = this.RoleData;
		bool? flag;
		if (roleData == null)
		{
			flag = null;
		}
		else
		{
			BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
			flag = ((gameplayTagComponent != null) ? new bool?(gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.人物属性.体力禁用"])) : null);
		}
		bool? flag2 = flag;
		bool valueOrDefault = flag2.GetValueOrDefault();
		this.SetEnable(!valueOrDefault);
	}

	// Token: 0x0600CD3E RID: 52542 RVA: 0x003D1948 File Offset: 0x003CFB48
	private void RefreshTemporaryPercent()
	{
		if (!this.CanRefreshTemporaryStrength())
		{
			return;
		}
		float strength = this.StrengthCurrentValue - this.MaxStrengthBaseValue;
		float maxStrength = this.MaxStrengthCurrentValue - this.MaxStrengthBaseValue;
		this.SetTemporaryStrengthPercent(strength, maxStrength);
	}

	// Token: 0x0600CD3F RID: 52543 RVA: 0x003D1982 File Offset: 0x003CFB82
	private void RefreshTemporaryVisible()
	{
		this.PlayTemporaryAnim(this.CanRefreshTemporaryStrength());
	}

	// Token: 0x0600CD40 RID: 52544 RVA: 0x003D1990 File Offset: 0x003CFB90
	private bool CanRefreshTemporaryStrength()
	{
		return this.GetTemporaryStrength() > 0f || this.MaxStrengthCurrentValue > this.MaxStrengthBaseValue;
	}

	// Token: 0x0600CD41 RID: 52545 RVA: 0x003D19AF File Offset: 0x003CFBAF
	private float GetTemporaryStrength()
	{
		return this.StrengthCurrentValue - this.MaxStrengthBaseValue;
	}

	// Token: 0x0600CD42 RID: 52546 RVA: 0x003D19C0 File Offset: 0x003CFBC0
	private void SetTemporaryVisible(bool bVisible)
	{
		UUIItem item = this.GetItem(3);
		if (item.IsUIActiveSelf() != bVisible)
		{
			item.SetUIActive(bVisible);
		}
	}

	// Token: 0x0600CD43 RID: 52547 RVA: 0x003D19E5 File Offset: 0x003CFBE5
	private void PlayTemporaryAnim(bool bVisible)
	{
		if (this.IsTemporaryVisible == bVisible)
		{
			return;
		}
		this.IsTemporaryVisible = bVisible;
		if (bVisible)
		{
			this.StopTemporaryCloseAnim();
			this.PlayTemporaryStartAnim();
			return;
		}
		this.StopTemporaryStartAnim();
		this.PlayTemporaryCloseAnim();
	}

	// Token: 0x0600CD44 RID: 52548 RVA: 0x003D1A14 File Offset: 0x003CFC14
	private void SetTemporaryStrengthPercent(float strength, float maxStrength)
	{
		if (this.TemporaryStrength == strength)
		{
			return;
		}
		this.TargetTemporaryStrengthPercent = ((maxStrength <= 0f) ? 0f : (strength / maxStrength));
		this.TemporaryStrength = strength;
		this.RefreshSingleTemporaryStrengthItemVisible(maxStrength);
	}

	// Token: 0x0600CD45 RID: 52549 RVA: 0x003D1A48 File Offset: 0x003CFC48
	private void RefreshSingleTemporaryStrengthItemRotation(float maxStrength)
	{
		int num = (int)Math.Floor((double)(maxStrength / this.SingleTemporaryStrengthValue));
		if (num > this.MaxSingleStrengthItemCount)
		{
			num = this.MaxSingleStrengthItemCount;
		}
		float num2 = 360f / (float)num;
		float num3 = 0f;
		for (int i = 0; i < num; i++)
		{
			UUIItem uuiitem = (i < this.TemporaryStrengthSingleLineActorList.Count) ? this.TemporaryStrengthSingleLineActorList[i] : this.AddTemporarySingleStrengthItem(false);
			this.RotationCache.Yaw = num3;
			uuiitem.SetUIRelativeRotation(this.RotationCache);
			num3 += num2;
		}
	}

	// Token: 0x0600CD46 RID: 52550 RVA: 0x003D1AD0 File Offset: 0x003CFCD0
	private void RefreshSingleTemporaryStrengthItemVisible(float maxStrength)
	{
		int num = (int)Math.Floor((double)(maxStrength / this.SingleTemporaryStrengthValue));
		if (num > this.MaxSingleStrengthItemCount)
		{
			num = this.MaxSingleStrengthItemCount;
		}
		for (int i = 0; i < this.TemporaryStrengthSingleLineActorList.Count; i++)
		{
			bool flag = i < num;
			UUIItem uuiitem = this.TemporaryStrengthSingleLineActorList[i];
			if (uuiitem.IsUIActiveSelf() != flag)
			{
				uuiitem.SetUIActive(flag);
			}
		}
	}

	// Token: 0x0600CD47 RID: 52551 RVA: 0x003D1B38 File Offset: 0x003CFD38
	private UUIItem AddTemporarySingleStrengthItem(bool isFirst = false)
	{
		UUIItem item = this.GetItem(13);
		UUIItem item2 = this.GetItem(12);
		UUIItem uuiitem;
		if (isFirst)
		{
			uuiitem = item2;
		}
		else
		{
			uuiitem = (LguiUtil.Instance.DuplicateActor(item2.GetOwner(), item).GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		}
		this.TemporaryStrengthSingleLineActorList.Add(uuiitem);
		return uuiitem;
	}

	// Token: 0x0600CD48 RID: 52552 RVA: 0x003D1B94 File Offset: 0x003CFD94
	private void LerpTemporaryPercent(float delta)
	{
		if (!base.GetActive() || this.CurrentTemporaryStrengthPercent == this.TargetTemporaryStrengthPercent)
		{
			return;
		}
		this.LerpTime += delta;
		this.CurrentTemporaryStrengthPercent = MathUtils.Instance.Lerp(this.CurrentTemporaryStrengthPercent, this.TargetTemporaryStrengthPercent, this.LerpTime / 300f);
		this.GetSprite(9).SetFillAmount(this.CurrentTemporaryStrengthPercent);
		if (this.LerpTime >= 300f)
		{
			this.LerpTime = 0f;
		}
	}

	// Token: 0x0600CD49 RID: 52553 RVA: 0x003D1C1A File Offset: 0x003CFE1A
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(14);
		base.InitTweenAnim(15);
		base.InitTweenAnim(16);
		base.InitTweenAnim(17);
		base.InitTweenAnim(18);
		base.InitTweenAnim(19);
		base.InitTweenAnim(20);
	}

	// Token: 0x0600CD4A RID: 52554 RVA: 0x003D1C54 File Offset: 0x003CFE54
	private void PlayFullAnim()
	{
		base.PlayTweenAnim(16);
		this.DestroyFullAnimTimer();
		this.FullAnimTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.FullAnimTimer = null;
			this.PlayCloseAnim();
			if (this.GetItem(3).IsUIActiveSelf())
			{
				this.PlayTemporaryCloseAnim();
			}
		}, 300f, StrengthItem.FullAnimTimerStat, null, true, 1f);
		this.IsTemporaryVisible = false;
		this.IsStarted = false;
	}

	// Token: 0x0600CD4B RID: 52555 RVA: 0x003D1CAA File Offset: 0x003CFEAA
	private void StopFullAnim()
	{
		this.DestroyFullAnimTimer();
		base.StopTweenAnim(16);
	}

	// Token: 0x0600CD4C RID: 52556 RVA: 0x003D1CBA File Offset: 0x003CFEBA
	private void DestroyFullAnimTimer()
	{
		if (this.FullAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.FullAnimTimer);
			this.FullAnimTimer = null;
		}
	}

	// Token: 0x0600CD4D RID: 52557 RVA: 0x003D1CDC File Offset: 0x003CFEDC
	private void PlayStartAnim()
	{
		if (this.IsStarted)
		{
			return;
		}
		this.StopFullAnim();
		this.StopCloseAnim();
		base.PlayTweenAnim(14);
		this.IsStarted = true;
	}

	// Token: 0x0600CD4E RID: 52558 RVA: 0x003D1D02 File Offset: 0x003CFF02
	private void PlayNoneAnim()
	{
		base.PlayTweenAnim(17);
	}

	// Token: 0x0600CD4F RID: 52559 RVA: 0x003D1D0C File Offset: 0x003CFF0C
	private void StopNoneAnim()
	{
		base.StopTweenAnim(17);
	}

	// Token: 0x0600CD50 RID: 52560 RVA: 0x003D1D18 File Offset: 0x003CFF18
	private void PlayCloseAnim()
	{
		base.PlayTweenAnim(15);
		this.DestroyCloseAnimTimer();
		this.CloseAnimTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CloseAnimTimer = null;
			this.StrengthVisible = false;
			this.RefreshVisible();
		}, 250f, StrengthItem.CloseAnimTimerStat, null, true, 1f);
		this.IsStarted = false;
	}

	// Token: 0x0600CD51 RID: 52561 RVA: 0x003D1D67 File Offset: 0x003CFF67
	private void StopCloseAnim()
	{
		this.DestroyCloseAnimTimer();
		base.StopTweenAnim(15);
	}

	// Token: 0x0600CD52 RID: 52562 RVA: 0x003D1D77 File Offset: 0x003CFF77
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600CD53 RID: 52563 RVA: 0x003D1D99 File Offset: 0x003CFF99
	private void PlayTemporaryStartAnim()
	{
		base.PlayTweenAnim(19);
	}

	// Token: 0x0600CD54 RID: 52564 RVA: 0x003D1DA3 File Offset: 0x003CFFA3
	private void StopTemporaryStartAnim()
	{
		base.StopTweenAnim(19);
	}

	// Token: 0x0600CD55 RID: 52565 RVA: 0x003D1DAD File Offset: 0x003CFFAD
	private void PlayTemporaryCloseAnim()
	{
		base.PlayTweenAnim(20);
		this.DestroyTempCloseAnimTimer();
		this.TempCloseAnimTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.TempCloseAnimTimer = null;
			this.SetTemporaryVisible(false);
			this.IsTemporaryVisible = false;
		}, 330f, StrengthItem.TempCloseAnimTimerStat, null, true, 1f);
	}

	// Token: 0x0600CD56 RID: 52566 RVA: 0x003D1DEA File Offset: 0x003CFFEA
	private void StopTemporaryCloseAnim()
	{
		this.DestroyTempCloseAnimTimer();
		base.StopTweenAnim(20);
	}

	// Token: 0x0600CD57 RID: 52567 RVA: 0x003D1DFA File Offset: 0x003CFFFA
	private void DestroyTempCloseAnimTimer()
	{
		if (this.TempCloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.TempCloseAnimTimer);
			this.TempCloseAnimTimer = null;
		}
	}

	// Token: 0x0600CD58 RID: 52568 RVA: 0x003D1E1C File Offset: 0x003D001C
	private void PlayPickUpAnim()
	{
		base.PlayTweenAnim(18);
	}

	// Token: 0x0600CD59 RID: 52569 RVA: 0x003D1E26 File Offset: 0x003D0026
	private void RefreshVisible()
	{
		this.SetActive((this.StrengthVisible || this.AutoMovingVisible) && this.EnableByHighPriority);
	}

	// Token: 0x0600CD5A RID: 52570 RVA: 0x003D1E48 File Offset: 0x003D0048
	private void RefreshAutoMovingSetting(bool isStart = false)
	{
		BattleUiFormationData formationData = BattleUiModel.Instance.FormationData;
		bool flag = formationData != null && formationData.AutoMovingSettingEnable;
		if (this.AutoMovingSettingEnable == flag)
		{
			return;
		}
		if (flag)
		{
			this.AutoMovingProgressAnimTime = ConfigCommonParamById.GetIntConfig("ConstantSprintProgressAnimTime").GetValueOrDefault(1000);
		}
		else
		{
			AutoMovingItem autoMovingItem = this.AutoMovingItem;
			if (autoMovingItem != null)
			{
				autoMovingItem.SetVisible(false);
			}
		}
		this.AutoMovingSettingEnable = flag;
		this.AutoMovingVisible = flag;
		if (!isStart)
		{
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CD5B RID: 52571 RVA: 0x003D1EC4 File Offset: 0x003D00C4
	private void RefreshAutoMoving()
	{
		if (!this.AutoMovingSettingEnable)
		{
			return;
		}
		BattleUiRoleData roleData = this.RoleData;
		CharacterInputComponent characterInputComponent;
		if (roleData == null)
		{
			characterInputComponent = null;
		}
		else
		{
			EntityHandle entityHandle = roleData.EntityHandle;
			if (entityHandle == null)
			{
				characterInputComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				characterInputComponent = ((entity != null) ? entity.GetComponent<CharacterInputComponent>() : null);
			}
		}
		CharacterInputComponent characterInputComponent2 = characterInputComponent;
		if (characterInputComponent2 == null)
		{
			return;
		}
		if (this.HasAutoMovingTag)
		{
			this.SetAutoMovingState(StrengthItem.EAutoMovingState.AutoMoving, 1f);
			return;
		}
		InputContinuously autoMovingConfig = characterInputComponent2.GetAutoMovingConfig();
		float num = Math.Max(0f, autoMovingConfig.GetDuration() - autoMovingConfig.GetCurrentTime());
		if (num > (float)this.AutoMovingProgressAnimTime)
		{
			this.SetAutoMovingState(StrengthItem.EAutoMovingState.None, 0f);
			return;
		}
		float percent = 1f - num / (float)this.AutoMovingProgressAnimTime;
		this.SetAutoMovingState(StrengthItem.EAutoMovingState.Moving, percent);
	}

	// Token: 0x0600CD5C RID: 52572 RVA: 0x003D1F6C File Offset: 0x003D016C
	private void SetAutoMovingState(StrengthItem.EAutoMovingState state, float percent = 0f)
	{
		if (this.AutoMovingItem == null)
		{
			return;
		}
		if (this.AutoMovingState == state)
		{
			if (this.AutoMovingState == StrengthItem.EAutoMovingState.Moving)
			{
				this.AutoMovingItem.SetPercent(percent);
			}
			return;
		}
		this.AutoMovingState = state;
		this.AutoMovingItem.SetVisible(state > StrengthItem.EAutoMovingState.None);
		this.AutoMovingItem.SetPercent(percent);
		this.AutoMovingItem.SetChangeColor(state == StrengthItem.EAutoMovingState.AutoMoving);
	}

	// Token: 0x040074E2 RID: 29922
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 5;

	// Token: 0x040074E3 RID: 29923
	private const int PRELOAD_SINGLE_TEMPORARY_STRENGTH_ITEM_COUNT = 1;

	// Token: 0x040074E4 RID: 29924
	private const float TEMPORARY_STRENGTH_LERP_TIME = 300f;

	// Token: 0x040074E5 RID: 29925
	private const float CLOSE_ANIM_TIME = 250f;

	// Token: 0x040074E6 RID: 29926
	private const float FULL_ANIM_TIME = 300f;

	// Token: 0x040074E7 RID: 29927
	private const float TEMP_CLOSE_ANIM_TIME = 330f;

	// Token: 0x040074E8 RID: 29928
	protected bool IsNormalState = true;

	// Token: 0x040074E9 RID: 29929
	private StrengthItem.EState StrengthState;

	// Token: 0x040074EA RID: 29930
	private StrengthItem.EStrengthBuffType BuffType;

	// Token: 0x040074EB RID: 29931
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x040074EC RID: 29932
	private readonly List<UUIItem> TemporaryStrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x040074ED RID: 29933
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);

	// Token: 0x040074EE RID: 29934
	private float Strength;

	// Token: 0x040074EF RID: 29935
	private float TemporaryStrength;

	// Token: 0x040074F0 RID: 29936
	private float SingleStrengthValue;

	// Token: 0x040074F1 RID: 29937
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x040074F2 RID: 29938
	private float SingleTemporaryStrengthValue;

	// Token: 0x040074F3 RID: 29939
	private float LerpTime;

	// Token: 0x040074F4 RID: 29940
	private float CurrentTemporaryStrengthPercent;

	// Token: 0x040074F5 RID: 29941
	private float TargetTemporaryStrengthPercent;

	// Token: 0x040074F6 RID: 29942
	private bool IsTemporaryVisible;

	// Token: 0x040074F7 RID: 29943
	private bool IsStarted;

	// Token: 0x040074F8 RID: 29944
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x040074F9 RID: 29945
	[Nullable(2)]
	private TimerHandle FullAnimTimer;

	// Token: 0x040074FA RID: 29946
	[Nullable(2)]
	private TimerHandle TempCloseAnimTimer;

	// Token: 0x040074FB RID: 29947
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("StrengthCloseAnim", "", "");

	// Token: 0x040074FC RID: 29948
	[StaticVariableRuleIgnore]
	private static readonly Stat FullAnimTimerStat = Stat.Create("StrengthFullAnim", "", "");

	// Token: 0x040074FD RID: 29949
	[StaticVariableRuleIgnore]
	private static readonly Stat TempCloseAnimTimerStat = Stat.Create("StrengthTempCloseAnim", "", "");

	// Token: 0x040074FE RID: 29950
	private float StrengthCurrentValue;

	// Token: 0x040074FF RID: 29951
	private float MaxStrengthBaseValue;

	// Token: 0x04007500 RID: 29952
	private float MaxStrengthCurrentValue;

	// Token: 0x04007501 RID: 29953
	private float LowEndurancePercent;

	// Token: 0x04007502 RID: 29954
	private bool AutoMovingSettingEnable;

	// Token: 0x04007503 RID: 29955
	private int AutoMovingProgressAnimTime = 1000;

	// Token: 0x04007504 RID: 29956
	[Nullable(2)]
	private AutoMovingItem AutoMovingItem;

	// Token: 0x04007505 RID: 29957
	private StrengthItem.EAutoMovingState AutoMovingState;

	// Token: 0x04007506 RID: 29958
	private bool HasAutoMovingTag;

	// Token: 0x04007507 RID: 29959
	private bool StrengthVisible;

	// Token: 0x04007508 RID: 29960
	private bool AutoMovingVisible;

	// Token: 0x020076E0 RID: 30432
	[NullableContext(0)]
	public enum EChildType
	{
		// Token: 0x040269C5 RID: 158149
		LowItem,
		// Token: 0x040269C6 RID: 158150
		NormalItem,
		// Token: 0x040269C7 RID: 158151
		NoneItem,
		// Token: 0x040269C8 RID: 158152
		TemporaryItem,
		// Token: 0x040269C9 RID: 158153
		BuffItem,
		// Token: 0x040269CA RID: 158154
		DeBuffItem,
		// Token: 0x040269CB RID: 158155
		DisableItem,
		// Token: 0x040269CC RID: 158156
		LowBarSprite,
		// Token: 0x040269CD RID: 158157
		NormalBarSprite,
		// Token: 0x040269CE RID: 158158
		TemporaryBarSprite,
		// Token: 0x040269CF RID: 158159
		StrengthSingleLineItem,
		// Token: 0x040269D0 RID: 158160
		StrengthLineItem,
		// Token: 0x040269D1 RID: 158161
		TemporarySingleLineItem,
		// Token: 0x040269D2 RID: 158162
		TemporaryLineItem,
		// Token: 0x040269D3 RID: 158163
		AnimStart,
		// Token: 0x040269D4 RID: 158164
		AnimClose,
		// Token: 0x040269D5 RID: 158165
		AnimFull,
		// Token: 0x040269D6 RID: 158166
		AnimNone,
		// Token: 0x040269D7 RID: 158167
		AnimPickUp,
		// Token: 0x040269D8 RID: 158168
		AnimTempStart,
		// Token: 0x040269D9 RID: 158169
		AnimTempClose,
		// Token: 0x040269DA RID: 158170
		AutoMovingItem
	}

	// Token: 0x020076E1 RID: 30433
	[NullableContext(0)]
	private enum EState
	{
		// Token: 0x040269DC RID: 158172
		Full,
		// Token: 0x040269DD RID: 158173
		Normal,
		// Token: 0x040269DE RID: 158174
		Low,
		// Token: 0x040269DF RID: 158175
		None
	}

	// Token: 0x020076E2 RID: 30434
	[NullableContext(0)]
	private enum EAutoMovingState
	{
		// Token: 0x040269E1 RID: 158177
		None,
		// Token: 0x040269E2 RID: 158178
		Moving,
		// Token: 0x040269E3 RID: 158179
		AutoMoving
	}

	// Token: 0x020076E3 RID: 30435
	[NullableContext(0)]
	private enum EStrengthBuffType
	{
		// Token: 0x040269E5 RID: 158181
		None,
		// Token: 0x040269E6 RID: 158182
		Buff,
		// Token: 0x040269E7 RID: 158183
		DeBuff
	}
}
