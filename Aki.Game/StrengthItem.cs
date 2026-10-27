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

// Token: 0x02001F63 RID: 8035
[NullableContext(1)]
[Nullable(0)]
public class StrengthItem : StrengthItemBase
{
	// Token: 0x0600F8FC RID: 63740 RVA: 0x003C5125 File Offset: 0x003C3325
	protected virtual int ResolveChildType(int name)
	{
		return name;
	}

	// Token: 0x0600F8FD RID: 63741 RVA: 0x003C5128 File Offset: 0x003C3328
	[NullableContext(2)]
	protected new UUIItem GetItem(int name)
	{
		return base.GetItem(this.ResolveChildType(name));
	}

	// Token: 0x0600F8FE RID: 63742 RVA: 0x003C5137 File Offset: 0x003C3337
	[NullableContext(2)]
	protected new UUISprite GetSprite(int name)
	{
		return base.GetSprite(this.ResolveChildType(name));
	}

	// Token: 0x0600F8FF RID: 63743 RVA: 0x003C5148 File Offset: 0x003C3348
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

	// Token: 0x0600F900 RID: 63744 RVA: 0x003C5454 File Offset: 0x003C3654
	protected override UniTask OnBeforeStartAsync()
	{
		StrengthItem.<OnBeforeStartAsync>d__47 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<StrengthItem.<OnBeforeStartAsync>d__47>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F901 RID: 63745 RVA: 0x003C5498 File Offset: 0x003C3698
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

	// Token: 0x0600F902 RID: 63746 RVA: 0x003C55CE File Offset: 0x003C37CE
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

	// Token: 0x0600F903 RID: 63747 RVA: 0x003C55FE File Offset: 0x003C37FE
	protected override void OnBeforeDestroy()
	{
		this.IsTemporaryVisible = false;
		this.IsStarted = false;
		this.DestroyCloseAnimTimer();
		this.DestroyFullAnimTimer();
		this.DestroyTempCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F904 RID: 63748 RVA: 0x003C5628 File Offset: 0x003C3828
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

	// Token: 0x0600F905 RID: 63749 RVA: 0x003C56A4 File Offset: 0x003C38A4
	protected override void OnRemoveEvents()
	{
		if (EventSystem.Instance.Has<bool>(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged)))
		{
			EventSystem.Instance.Remove<bool>(EEventName.AutoMovingSettingChanged, new Action<bool>(this.AutoMovingSettingChanged));
		}
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthMaxChanged));
	}

	// Token: 0x0600F906 RID: 63750 RVA: 0x003C5718 File Offset: 0x003C3918
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

	// Token: 0x0600F907 RID: 63751 RVA: 0x003C5800 File Offset: 0x003C3A00
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

	// Token: 0x0600F908 RID: 63752 RVA: 0x003C5854 File Offset: 0x003C3A54
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600F909 RID: 63753 RVA: 0x003C585C File Offset: 0x003C3A5C
	public override void Tick(float delta)
	{
		this.LerpTemporaryPercent(delta);
		this.RefreshAutoMoving();
	}

	// Token: 0x0600F90A RID: 63754 RVA: 0x003C586B File Offset: 0x003C3A6B
	private void AutoMovingSettingChanged(bool enable)
	{
		this.RefreshAutoMovingSetting(false);
		this.RefreshAutoMoving();
	}

	// Token: 0x0600F90B RID: 63755 RVA: 0x003C587C File Offset: 0x003C3A7C
	private void RefreshStrengthPercent()
	{
		this.StrengthCurrentValue = FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength);
		this.MaxStrengthBaseValue = FormationAttributeController.Instance.GetBaseMax(EFormationAttributeId.Strength);
		this.MaxStrengthCurrentValue = FormationAttributeController.Instance.GetMax(EFormationAttributeId.Strength);
		this.SetStrengthPercent(this.StrengthCurrentValue, this.MaxStrengthBaseValue);
	}

	// Token: 0x0600F90C RID: 63756 RVA: 0x003C58D0 File Offset: 0x003C3AD0
	private void RefreshSingleStrengthItemRotation()
	{
		float maxStrength = this.MaxStrengthCurrentValue - this.MaxStrengthBaseValue;
		this.RefreshSingleStrengthItemRotationInner(this.MaxStrengthBaseValue);
		this.RefreshSingleTemporaryStrengthItemRotation(maxStrength);
		this.RefreshSingleTemporaryStrengthItemVisible(maxStrength);
	}

	// Token: 0x0600F90D RID: 63757 RVA: 0x003C5908 File Offset: 0x003C3B08
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

	// Token: 0x0600F90E RID: 63758 RVA: 0x003C5A05 File Offset: 0x003C3C05
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent();
		this.RefreshTemporaryPercent();
		this.RefreshStrengthState();
	}

	// Token: 0x0600F90F RID: 63759 RVA: 0x003C5A19 File Offset: 0x003C3C19
	private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent();
		this.RefreshSingleStrengthItemRotation();
	}

	// Token: 0x0600F910 RID: 63760 RVA: 0x003C5A27 File Offset: 0x003C3C27
	private void OnStrengthBuff(int tagId, bool tagExists)
	{
		this.SetBuff(tagExists ? StrengthItem.EStrengthBuffType.Buff : StrengthItem.EStrengthBuffType.None);
	}

	// Token: 0x0600F911 RID: 63761 RVA: 0x003C5A36 File Offset: 0x003C3C36
	private void OnStrengthDeBuff(int tagId, bool tagExists)
	{
		this.SetBuff(tagExists ? StrengthItem.EStrengthBuffType.DeBuff : StrengthItem.EStrengthBuffType.None);
	}

	// Token: 0x0600F912 RID: 63762 RVA: 0x003C5A45 File Offset: 0x003C3C45
	private void OnStrengthDisable(int tagId, bool tagExists)
	{
		this.SetEnable(!tagExists);
	}

	// Token: 0x0600F913 RID: 63763 RVA: 0x003C5A51 File Offset: 0x003C3C51
	private void OnStrengthRecover(int tagId, bool tagExists)
	{
		this.PlayPickUpAnim();
	}

	// Token: 0x0600F914 RID: 63764 RVA: 0x003C5A59 File Offset: 0x003C3C59
	private void OnEnterAutoMoving(int tagId, bool tagExists)
	{
		this.HasAutoMovingTag = tagExists;
	}

	// Token: 0x0600F915 RID: 63765 RVA: 0x003C5A64 File Offset: 0x003C3C64
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

	// Token: 0x0600F916 RID: 63766 RVA: 0x003C5AB8 File Offset: 0x003C3CB8
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

	// Token: 0x0600F917 RID: 63767 RVA: 0x003C5B58 File Offset: 0x003C3D58
	protected void SetEnable(bool bEnable)
	{
		UUIItem item = this.GetItem(6);
		if (item.IsUIActiveSelf() != bEnable)
		{
			return;
		}
		item.SetUIActive(!bEnable);
	}

	// Token: 0x0600F918 RID: 63768 RVA: 0x003C5B84 File Offset: 0x003C3D84
	protected void SetNone(bool bNone)
	{
		UUIItem item = this.GetItem(2);
		if (item.IsUIActiveSelf() == bNone)
		{
			return;
		}
		item.SetUIActive(bNone);
	}

	// Token: 0x0600F919 RID: 63769 RVA: 0x003C5BAC File Offset: 0x003C3DAC
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

	// Token: 0x0600F91A RID: 63770 RVA: 0x003C5C00 File Offset: 0x003C3E00
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

	// Token: 0x0600F91B RID: 63771 RVA: 0x003C5C88 File Offset: 0x003C3E88
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

	// Token: 0x0600F91C RID: 63772 RVA: 0x003C5CF0 File Offset: 0x003C3EF0
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

	// Token: 0x0600F91D RID: 63773 RVA: 0x003C5D4C File Offset: 0x003C3F4C
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

	// Token: 0x0600F91E RID: 63774 RVA: 0x003C5DF8 File Offset: 0x003C3FF8
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

	// Token: 0x0600F91F RID: 63775 RVA: 0x003C5E5C File Offset: 0x003C405C
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

	// Token: 0x0600F920 RID: 63776 RVA: 0x003C5E96 File Offset: 0x003C4096
	private void RefreshTemporaryVisible()
	{
		this.PlayTemporaryAnim(this.CanRefreshTemporaryStrength());
	}

	// Token: 0x0600F921 RID: 63777 RVA: 0x003C5EA4 File Offset: 0x003C40A4
	private bool CanRefreshTemporaryStrength()
	{
		return this.GetTemporaryStrength() > 0f || this.MaxStrengthCurrentValue > this.MaxStrengthBaseValue;
	}

	// Token: 0x0600F922 RID: 63778 RVA: 0x003C5EC3 File Offset: 0x003C40C3
	private float GetTemporaryStrength()
	{
		return this.StrengthCurrentValue - this.MaxStrengthBaseValue;
	}

	// Token: 0x0600F923 RID: 63779 RVA: 0x003C5ED4 File Offset: 0x003C40D4
	private void SetTemporaryVisible(bool bVisible)
	{
		UUIItem item = this.GetItem(3);
		if (item.IsUIActiveSelf() != bVisible)
		{
			item.SetUIActive(bVisible);
		}
	}

	// Token: 0x0600F924 RID: 63780 RVA: 0x003C5EF9 File Offset: 0x003C40F9
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

	// Token: 0x0600F925 RID: 63781 RVA: 0x003C5F28 File Offset: 0x003C4128
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

	// Token: 0x0600F926 RID: 63782 RVA: 0x003C5F5C File Offset: 0x003C415C
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

	// Token: 0x0600F927 RID: 63783 RVA: 0x003C5FE4 File Offset: 0x003C41E4
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

	// Token: 0x0600F928 RID: 63784 RVA: 0x003C604C File Offset: 0x003C424C
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

	// Token: 0x0600F929 RID: 63785 RVA: 0x003C60A8 File Offset: 0x003C42A8
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

	// Token: 0x0600F92A RID: 63786 RVA: 0x003C612E File Offset: 0x003C432E
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

	// Token: 0x0600F92B RID: 63787 RVA: 0x003C6168 File Offset: 0x003C4368
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

	// Token: 0x0600F92C RID: 63788 RVA: 0x003C61BE File Offset: 0x003C43BE
	private void StopFullAnim()
	{
		this.DestroyFullAnimTimer();
		base.StopTweenAnim(16);
	}

	// Token: 0x0600F92D RID: 63789 RVA: 0x003C61CE File Offset: 0x003C43CE
	private void DestroyFullAnimTimer()
	{
		if (this.FullAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.FullAnimTimer);
			this.FullAnimTimer = null;
		}
	}

	// Token: 0x0600F92E RID: 63790 RVA: 0x003C61F0 File Offset: 0x003C43F0
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

	// Token: 0x0600F92F RID: 63791 RVA: 0x003C6216 File Offset: 0x003C4416
	private void PlayNoneAnim()
	{
		base.PlayTweenAnim(17);
	}

	// Token: 0x0600F930 RID: 63792 RVA: 0x003C6220 File Offset: 0x003C4420
	private void StopNoneAnim()
	{
		base.StopTweenAnim(17);
	}

	// Token: 0x0600F931 RID: 63793 RVA: 0x003C622C File Offset: 0x003C442C
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

	// Token: 0x0600F932 RID: 63794 RVA: 0x003C627B File Offset: 0x003C447B
	private void StopCloseAnim()
	{
		this.DestroyCloseAnimTimer();
		base.StopTweenAnim(15);
	}

	// Token: 0x0600F933 RID: 63795 RVA: 0x003C628B File Offset: 0x003C448B
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600F934 RID: 63796 RVA: 0x003C62AD File Offset: 0x003C44AD
	private void PlayTemporaryStartAnim()
	{
		base.PlayTweenAnim(19);
	}

	// Token: 0x0600F935 RID: 63797 RVA: 0x003C62B7 File Offset: 0x003C44B7
	private void StopTemporaryStartAnim()
	{
		base.StopTweenAnim(19);
	}

	// Token: 0x0600F936 RID: 63798 RVA: 0x003C62C1 File Offset: 0x003C44C1
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

	// Token: 0x0600F937 RID: 63799 RVA: 0x003C62FE File Offset: 0x003C44FE
	private void StopTemporaryCloseAnim()
	{
		this.DestroyTempCloseAnimTimer();
		base.StopTweenAnim(20);
	}

	// Token: 0x0600F938 RID: 63800 RVA: 0x003C630E File Offset: 0x003C450E
	private void DestroyTempCloseAnimTimer()
	{
		if (this.TempCloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.TempCloseAnimTimer);
			this.TempCloseAnimTimer = null;
		}
	}

	// Token: 0x0600F939 RID: 63801 RVA: 0x003C6330 File Offset: 0x003C4530
	private void PlayPickUpAnim()
	{
		base.PlayTweenAnim(18);
	}

	// Token: 0x0600F93A RID: 63802 RVA: 0x003C633A File Offset: 0x003C453A
	private void RefreshVisible()
	{
		this.SetActive((this.StrengthVisible || this.AutoMovingVisible) && this.EnableByHighPriority);
	}

	// Token: 0x0600F93B RID: 63803 RVA: 0x003C635C File Offset: 0x003C455C
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

	// Token: 0x0600F93C RID: 63804 RVA: 0x003C63D8 File Offset: 0x003C45D8
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

	// Token: 0x0600F93D RID: 63805 RVA: 0x003C6480 File Offset: 0x003C4680
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

	// Token: 0x04007401 RID: 29697
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 5;

	// Token: 0x04007402 RID: 29698
	private const int PRELOAD_SINGLE_TEMPORARY_STRENGTH_ITEM_COUNT = 1;

	// Token: 0x04007403 RID: 29699
	private const float TEMPORARY_STRENGTH_LERP_TIME = 300f;

	// Token: 0x04007404 RID: 29700
	private const float CLOSE_ANIM_TIME = 250f;

	// Token: 0x04007405 RID: 29701
	private const float FULL_ANIM_TIME = 300f;

	// Token: 0x04007406 RID: 29702
	private const float TEMP_CLOSE_ANIM_TIME = 330f;

	// Token: 0x04007407 RID: 29703
	protected bool IsNormalState = true;

	// Token: 0x04007408 RID: 29704
	private StrengthItem.EState StrengthState;

	// Token: 0x04007409 RID: 29705
	private StrengthItem.EStrengthBuffType BuffType;

	// Token: 0x0400740A RID: 29706
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x0400740B RID: 29707
	private readonly List<UUIItem> TemporaryStrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x0400740C RID: 29708
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);

	// Token: 0x0400740D RID: 29709
	private float Strength;

	// Token: 0x0400740E RID: 29710
	private float TemporaryStrength;

	// Token: 0x0400740F RID: 29711
	private float SingleStrengthValue;

	// Token: 0x04007410 RID: 29712
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x04007411 RID: 29713
	private float SingleTemporaryStrengthValue;

	// Token: 0x04007412 RID: 29714
	private float LerpTime;

	// Token: 0x04007413 RID: 29715
	private float CurrentTemporaryStrengthPercent;

	// Token: 0x04007414 RID: 29716
	private float TargetTemporaryStrengthPercent;

	// Token: 0x04007415 RID: 29717
	private bool IsTemporaryVisible;

	// Token: 0x04007416 RID: 29718
	private bool IsStarted;

	// Token: 0x04007417 RID: 29719
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x04007418 RID: 29720
	[Nullable(2)]
	private TimerHandle FullAnimTimer;

	// Token: 0x04007419 RID: 29721
	[Nullable(2)]
	private TimerHandle TempCloseAnimTimer;

	// Token: 0x0400741A RID: 29722
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("StrengthCloseAnim", "", "");

	// Token: 0x0400741B RID: 29723
	[StaticVariableRuleIgnore]
	private static readonly Stat FullAnimTimerStat = Stat.Create("StrengthFullAnim", "", "");

	// Token: 0x0400741C RID: 29724
	[StaticVariableRuleIgnore]
	private static readonly Stat TempCloseAnimTimerStat = Stat.Create("StrengthTempCloseAnim", "", "");

	// Token: 0x0400741D RID: 29725
	private float StrengthCurrentValue;

	// Token: 0x0400741E RID: 29726
	private float MaxStrengthBaseValue;

	// Token: 0x0400741F RID: 29727
	private float MaxStrengthCurrentValue;

	// Token: 0x04007420 RID: 29728
	private float LowEndurancePercent;

	// Token: 0x04007421 RID: 29729
	private bool AutoMovingSettingEnable;

	// Token: 0x04007422 RID: 29730
	private int AutoMovingProgressAnimTime = 1000;

	// Token: 0x04007423 RID: 29731
	[Nullable(2)]
	private AutoMovingItem AutoMovingItem;

	// Token: 0x04007424 RID: 29732
	private StrengthItem.EAutoMovingState AutoMovingState;

	// Token: 0x04007425 RID: 29733
	private bool HasAutoMovingTag;

	// Token: 0x04007426 RID: 29734
	private bool StrengthVisible;

	// Token: 0x04007427 RID: 29735
	private bool AutoMovingVisible;

	// Token: 0x0200855B RID: 34139
	[NullableContext(0)]
	public enum EChildType
	{
		// Token: 0x0402B6A1 RID: 177825
		LowItem,
		// Token: 0x0402B6A2 RID: 177826
		NormalItem,
		// Token: 0x0402B6A3 RID: 177827
		NoneItem,
		// Token: 0x0402B6A4 RID: 177828
		TemporaryItem,
		// Token: 0x0402B6A5 RID: 177829
		BuffItem,
		// Token: 0x0402B6A6 RID: 177830
		DeBuffItem,
		// Token: 0x0402B6A7 RID: 177831
		DisableItem,
		// Token: 0x0402B6A8 RID: 177832
		LowBarSprite,
		// Token: 0x0402B6A9 RID: 177833
		NormalBarSprite,
		// Token: 0x0402B6AA RID: 177834
		TemporaryBarSprite,
		// Token: 0x0402B6AB RID: 177835
		StrengthSingleLineItem,
		// Token: 0x0402B6AC RID: 177836
		StrengthLineItem,
		// Token: 0x0402B6AD RID: 177837
		TemporarySingleLineItem,
		// Token: 0x0402B6AE RID: 177838
		TemporaryLineItem,
		// Token: 0x0402B6AF RID: 177839
		AnimStart,
		// Token: 0x0402B6B0 RID: 177840
		AnimClose,
		// Token: 0x0402B6B1 RID: 177841
		AnimFull,
		// Token: 0x0402B6B2 RID: 177842
		AnimNone,
		// Token: 0x0402B6B3 RID: 177843
		AnimPickUp,
		// Token: 0x0402B6B4 RID: 177844
		AnimTempStart,
		// Token: 0x0402B6B5 RID: 177845
		AnimTempClose,
		// Token: 0x0402B6B6 RID: 177846
		AutoMovingItem
	}

	// Token: 0x0200855C RID: 34140
	[NullableContext(0)]
	private enum EState
	{
		// Token: 0x0402B6B8 RID: 177848
		Full,
		// Token: 0x0402B6B9 RID: 177849
		Normal,
		// Token: 0x0402B6BA RID: 177850
		Low,
		// Token: 0x0402B6BB RID: 177851
		None
	}

	// Token: 0x0200855D RID: 34141
	[NullableContext(0)]
	private enum EAutoMovingState
	{
		// Token: 0x0402B6BD RID: 177853
		None,
		// Token: 0x0402B6BE RID: 177854
		Moving,
		// Token: 0x0402B6BF RID: 177855
		AutoMoving
	}

	// Token: 0x0200855E RID: 34142
	[NullableContext(0)]
	private enum EStrengthBuffType
	{
		// Token: 0x0402B6C1 RID: 177857
		None,
		// Token: 0x0402B6C2 RID: 177858
		Buff,
		// Token: 0x0402B6C3 RID: 177859
		DeBuff
	}
}
