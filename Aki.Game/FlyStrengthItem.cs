using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F5A RID: 8026
[NullableContext(1)]
[Nullable(0)]
public class FlyStrengthItem : StrengthItemBase
{
	// Token: 0x0600F87C RID: 63612 RVA: 0x003C2819 File Offset: 0x003C0A19
	protected override string GetResourceId()
	{
		return "UiItem_EnergyFly";
	}

	// Token: 0x0600F87D RID: 63613 RVA: 0x003C2820 File Offset: 0x003C0A20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F87E RID: 63614 RVA: 0x003C2974 File Offset: 0x003C0B74
	protected override void OnStart()
	{
		for (int i = 0; i < 3; i++)
		{
			this.AddSingleStrengthItem(i == 0);
		}
		this.LowEndurancePercent = (float)ConfigCommonParamById.GetIntConfig("LowEndurancePercent").GetValueOrDefault() / 10000f;
		this.SingleStrengthValue = (float)ConfigCommonParamById.GetIntConfig("FlySingleStrengthValue").GetValueOrDefault();
		this.MaxSingleStrengthItemCount = ConfigCommonParamById.GetIntConfig("FlyMaxSingleStrengthItemCount").GetValueOrDefault(1);
		this.TailSpeed = (float)ConfigCommonParamById.GetIntConfig("FlyTailSpeed").GetValueOrDefault() * (float)TimeUtil.Instance.Millisecond;
		base.InitTweenAnim(7);
		base.InitTweenAnim(8);
		base.OnStart();
		this.RefreshStrengthPercent(true);
	}

	// Token: 0x0600F87F RID: 63615 RVA: 0x003C2A29 File Offset: 0x003C0C29
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		base.StopTweenAnim(8);
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600F880 RID: 63616 RVA: 0x003C2A40 File Offset: 0x003C0C40
	protected override UniTask OnBeforeHideAsync()
	{
		FlyStrengthItem.<OnBeforeHideAsync>d__28 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<FlyStrengthItem.<OnBeforeHideAsync>d__28>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F881 RID: 63617 RVA: 0x003C2A83 File Offset: 0x003C0C83
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F882 RID: 63618 RVA: 0x003C2A91 File Offset: 0x003C0C91
	public override void Tick(float delta)
	{
		if (!base.GetUiVisible())
		{
			return;
		}
		if (this.TailStrengthCurrentValue <= this.StrengthCurrentValue)
		{
			return;
		}
		this.TailStrengthCurrentValue -= delta * this.TailSpeed;
		this.UpdateTailProgress();
	}

	// Token: 0x0600F883 RID: 63619 RVA: 0x003C2AC6 File Offset: 0x003C0CC6
	protected override void OnAddEvents()
	{
		FormationAttributeController.Instance.AddValueListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthMaxChanged), null);
	}

	// Token: 0x0600F884 RID: 63620 RVA: 0x003C2B02 File Offset: 0x003C0D02
	protected override void OnRemoveEvents()
	{
		FormationAttributeController.Instance.RemoveValueListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthMaxChanged));
	}

	// Token: 0x0600F885 RID: 63621 RVA: 0x003C2B3C File Offset: 0x003C0D3C
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
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]), new Action<int, bool>(this.OnFlyTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力显示"]), new Action<int, bool>(this.OnFlyStrengthTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.冲刺"]), new Action<int, bool>(this.OnSpeedUpTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力冲刺"]), new Action<int, bool>(this.OnBaseSpeedUpTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力锁定"]), new Action<int, bool>(this.OnLockTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力隐藏"]), new Action<int, bool>(this.OnHideTagChanged));
	}

	// Token: 0x0600F886 RID: 63622 RVA: 0x003C2C4C File Offset: 0x003C0E4C
	protected override void OnRefreshRoleData()
	{
		if (this.RoleData == null)
		{
			return;
		}
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		this.IsFlyTag = (gameplayTagComponent != null && gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]));
		BaseTagComponent gameplayTagComponent2 = this.RoleData.GameplayTagComponent;
		this.IsFlyStrengthTag = (gameplayTagComponent2 != null && gameplayTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力显示"]));
		BaseTagComponent gameplayTagComponent3 = this.RoleData.GameplayTagComponent;
		this.IsSpeedUpTag = (gameplayTagComponent3 != null && gameplayTagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.冲刺"]));
		BaseTagComponent gameplayTagComponent4 = this.RoleData.GameplayTagComponent;
		this.IsBaseSpeedUpTag = (gameplayTagComponent4 != null && gameplayTagComponent4.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力冲刺"]));
		BaseTagComponent gameplayTagComponent5 = this.RoleData.GameplayTagComponent;
		this.IsLock = (gameplayTagComponent5 != null && gameplayTagComponent5.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力锁定"]));
		BaseTagComponent gameplayTagComponent6 = this.RoleData.GameplayTagComponent;
		this.IsHideTag = (gameplayTagComponent6 != null && gameplayTagComponent6.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力隐藏"]));
		this.IsFlying = (this.IsFlyTag || this.IsFlyStrengthTag);
		this.IsSpeedUp = (this.IsSpeedUpTag || this.IsBaseSpeedUpTag);
		this.RefreshSpeedUp();
		this.RefreshLockState();
		this.RefreshVisible();
	}

	// Token: 0x0600F887 RID: 63623 RVA: 0x003C2DAA File Offset: 0x003C0FAA
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600F888 RID: 63624 RVA: 0x003C2DB2 File Offset: 0x003C0FB2
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F889 RID: 63625 RVA: 0x003C2DBB File Offset: 0x003C0FBB
	private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F88A RID: 63626 RVA: 0x003C2DC4 File Offset: 0x003C0FC4
	protected void OnFlyTagChanged(int tagId, bool tagExists)
	{
		this.IsFlyTag = tagExists;
		if (this.IsFlying != (this.IsFlyTag || this.IsFlyStrengthTag))
		{
			this.IsFlying = !this.IsFlying;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F88B RID: 63627 RVA: 0x003C2DFB File Offset: 0x003C0FFB
	protected void OnFlyStrengthTagChanged(int tagId, bool tagExists)
	{
		this.IsFlyStrengthTag = tagExists;
		if (this.IsFlying != (this.IsFlyTag || this.IsFlyStrengthTag))
		{
			this.IsFlying = !this.IsFlying;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F88C RID: 63628 RVA: 0x003C2E32 File Offset: 0x003C1032
	protected void OnSpeedUpTagChanged(int tagId, bool tagExists)
	{
		this.IsSpeedUpTag = tagExists;
		if (this.IsSpeedUp != (this.IsSpeedUpTag || this.IsBaseSpeedUpTag))
		{
			this.IsSpeedUp = !this.IsSpeedUp;
			this.RefreshSpeedUp();
		}
	}

	// Token: 0x0600F88D RID: 63629 RVA: 0x003C2E69 File Offset: 0x003C1069
	protected void OnBaseSpeedUpTagChanged(int tagId, bool tagExists)
	{
		this.IsBaseSpeedUpTag = tagExists;
		if (this.IsSpeedUp != (this.IsFlyTag || this.IsBaseSpeedUpTag))
		{
			this.IsSpeedUp = !this.IsSpeedUp;
			this.RefreshSpeedUp();
		}
	}

	// Token: 0x0600F88E RID: 63630 RVA: 0x003C2EA0 File Offset: 0x003C10A0
	protected void OnLockTagChanged(int tagId, bool tagExists)
	{
		if (this.IsLock != tagExists)
		{
			this.IsLock = tagExists;
			this.RefreshLockState();
		}
	}

	// Token: 0x0600F88F RID: 63631 RVA: 0x003C2EB8 File Offset: 0x003C10B8
	protected void OnHideTagChanged(int tagId, bool tagExists)
	{
		if (this.IsHideTag != tagExists)
		{
			this.IsHideTag = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F890 RID: 63632 RVA: 0x003C2ED0 File Offset: 0x003C10D0
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

	// Token: 0x0600F891 RID: 63633 RVA: 0x003C2F28 File Offset: 0x003C1128
	private void RefreshStrengthPercent(bool bForce = false)
	{
		float value = FormationAttributeController.Instance.GetValue(this.StrengthAttributeId);
		float max = FormationAttributeController.Instance.GetMax(this.StrengthAttributeId);
		bool flag = value != this.StrengthCurrentValue;
		if (flag)
		{
			this.StrengthCurrentValue = value;
			if (this.IsSpeedUp && this.TailStrengthCurrentValue < this.StrengthCurrentValue)
			{
				this.TailStrengthCurrentValue = this.StrengthCurrentValue;
			}
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

	// Token: 0x0600F892 RID: 63634 RVA: 0x003C2FC4 File Offset: 0x003C11C4
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

	// Token: 0x0600F893 RID: 63635 RVA: 0x003C3030 File Offset: 0x003C1230
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
			UUIItem uuiitem2 = uuiitem;
			FRotator frotator = new FRotator(0f, num3, 0f);
			uuiitem2.SetUIRelativeRotation(frotator);
			num3 += num2;
		}
	}

	// Token: 0x0600F894 RID: 63636 RVA: 0x003C30C8 File Offset: 0x003C12C8
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

	// Token: 0x0600F895 RID: 63637 RVA: 0x003C311C File Offset: 0x003C131C
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

	// Token: 0x0600F896 RID: 63638 RVA: 0x003C3180 File Offset: 0x003C1380
	protected virtual void RefreshVisible()
	{
		bool active = !this.IsHideTag && (this.IsFlying || !this.IsFullState) && this.EnableByHighPriority;
		this.SetActive(active);
	}

	// Token: 0x0600F897 RID: 63639 RVA: 0x003C31B8 File Offset: 0x003C13B8
	protected void RefreshSpeedUp()
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem item = base.GetItem(5);
		if (!this.IsSpeedUp)
		{
			this.TailStrengthCurrentValue = 0f;
			sprite.SetUIActive(false);
			item.SetUIActive(false);
			return;
		}
		if (this.TailStrengthCurrentValue == 0f)
		{
			this.TailStrengthCurrentValue = this.StrengthCurrentValue;
		}
		this.UpdateTailProgress();
		sprite.SetUIActive(true);
		item.SetUIActive(true);
	}

	// Token: 0x0600F898 RID: 63640 RVA: 0x003C3224 File Offset: 0x003C1424
	private void UpdateTailProgress()
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem item = base.GetItem(5);
		sprite.SetFillAmount(this.TailStrengthCurrentValue / this.MaxStrengthCurrentValue);
		float inYaw = 360f * (this.StrengthCurrentValue / this.MaxStrengthCurrentValue);
		UUIItem uuiitem = item;
		FRotator frotator = new FRotator(0f, inYaw, 0f);
		uuiitem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0600F899 RID: 63641 RVA: 0x003C327F File Offset: 0x003C147F
	protected void RefreshLockState()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLock);
	}

	// Token: 0x0600F89A RID: 63642 RVA: 0x003C3298 File Offset: 0x003C1498
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

	// Token: 0x04007387 RID: 29575
	private const int CLOSE_ANIM_TIME = 250;

	// Token: 0x04007388 RID: 29576
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 3;

	// Token: 0x04007389 RID: 29577
	protected EFormationAttributeId StrengthAttributeId = EFormationAttributeId.SoarStrength;

	// Token: 0x0400738A RID: 29578
	private bool IsNormalState = true;

	// Token: 0x0400738B RID: 29579
	protected bool IsFullState = true;

	// Token: 0x0400738C RID: 29580
	protected bool IsFlying;

	// Token: 0x0400738D RID: 29581
	protected bool IsSpeedUp;

	// Token: 0x0400738E RID: 29582
	protected bool IsLock;

	// Token: 0x0400738F RID: 29583
	protected bool IsHideTag;

	// Token: 0x04007390 RID: 29584
	private bool IsFlyTag;

	// Token: 0x04007391 RID: 29585
	private bool IsFlyStrengthTag;

	// Token: 0x04007392 RID: 29586
	private bool IsSpeedUpTag;

	// Token: 0x04007393 RID: 29587
	private bool IsBaseSpeedUpTag;

	// Token: 0x04007394 RID: 29588
	private float LowEndurancePercent;

	// Token: 0x04007395 RID: 29589
	private float SingleStrengthValue;

	// Token: 0x04007396 RID: 29590
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x04007397 RID: 29591
	private float TailSpeed = 0.1f;

	// Token: 0x04007398 RID: 29592
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x04007399 RID: 29593
	private float StrengthCurrentValue;

	// Token: 0x0400739A RID: 29594
	private float MaxStrengthCurrentValue;

	// Token: 0x0400739B RID: 29595
	private float TailStrengthCurrentValue;

	// Token: 0x0400739C RID: 29596
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x0400739D RID: 29597
	[Nullable(2)]
	private CustomPromise CloseAnimPromise;

	// Token: 0x0400739E RID: 29598
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("StrengthCloseAnim", "", "");
}
