using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F5D RID: 8029
[NullableContext(1)]
[Nullable(0)]
public class FlyStrengthItemForQingXiao : StrengthItemBase
{
	// Token: 0x0600F8A5 RID: 63653 RVA: 0x003C3582 File Offset: 0x003C1782
	protected override string GetResourceId()
	{
		return "UiItem_EnergyFly";
	}

	// Token: 0x0600F8A6 RID: 63654 RVA: 0x003C358C File Offset: 0x003C178C
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

	// Token: 0x0600F8A7 RID: 63655 RVA: 0x003C36E0 File Offset: 0x003C18E0
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

	// Token: 0x0600F8A8 RID: 63656 RVA: 0x003C3795 File Offset: 0x003C1995
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		base.StopTweenAnim(8);
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600F8A9 RID: 63657 RVA: 0x003C37AC File Offset: 0x003C19AC
	protected override UniTask OnBeforeHideAsync()
	{
		FlyStrengthItemForQingXiao.<OnBeforeHideAsync>d__24 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<FlyStrengthItemForQingXiao.<OnBeforeHideAsync>d__24>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8AA RID: 63658 RVA: 0x003C37EF File Offset: 0x003C19EF
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F8AB RID: 63659 RVA: 0x003C37FD File Offset: 0x003C19FD
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

	// Token: 0x0600F8AC RID: 63660 RVA: 0x003C3834 File Offset: 0x003C1A34
	protected override void OnAddEntityEvents()
	{
		if (this.RoleData == null)
		{
			return;
		}
		BattleUiRoleData roleData = this.RoleData;
		if (roleData.RoleConfig == null || roleData.RoleConfig.GetValueOrDefault().Id != 1413)
		{
			return;
		}
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		if (gameplayTagComponent == null)
		{
			return;
		}
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.显示"]), new Action<int, bool>(this.OnFlyStrengthTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.冲刺"]), new Action<int, bool>(this.OnBaseSpeedUpTagChanged));
		base.ListenForTagAddOrRemove(gameplayTagComponent, new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.锁定"]), new Action<int, bool>(this.OnLockTagChanged));
		base.ListenForAttributeChanged(this.StrengthAttributeId, new Action<EAttributeType, float, float>(this.OnStrengthChanged));
		base.ListenForAttributeChanged(this.MaxStrengthAttributeId, new Action<EAttributeType, float, float>(this.OnStrengthMaxChanged));
	}

	// Token: 0x0600F8AD RID: 63661 RVA: 0x003C3930 File Offset: 0x003C1B30
	protected override void OnRefreshRoleData()
	{
		if (this.RoleData == null)
		{
			return;
		}
		BattleUiRoleData roleData = this.RoleData;
		if (roleData.RoleConfig == null || roleData.RoleConfig.GetValueOrDefault().Id != 1413)
		{
			this.IsFlying = false;
			this.IsFullState = true;
			this.RefreshVisible();
			return;
		}
		BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
		this.IsFlying = (gameplayTagComponent != null && gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.显示"]));
		BaseTagComponent gameplayTagComponent2 = this.RoleData.GameplayTagComponent;
		this.IsSpeedUp = (gameplayTagComponent2 != null && gameplayTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.冲刺"]));
		BaseTagComponent gameplayTagComponent3 = this.RoleData.GameplayTagComponent;
		this.IsLock = (gameplayTagComponent3 != null && gameplayTagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.锁定"]));
		this.RefreshSpeedUp();
		this.RefreshLockState();
		this.RefreshVisible();
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F8AE RID: 63662 RVA: 0x003C3A28 File Offset: 0x003C1C28
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600F8AF RID: 63663 RVA: 0x003C3A30 File Offset: 0x003C1C30
	private void OnStrengthChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F8B0 RID: 63664 RVA: 0x003C3A39 File Offset: 0x003C1C39
	private void OnStrengthMaxChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600F8B1 RID: 63665 RVA: 0x003C3A42 File Offset: 0x003C1C42
	protected void OnFlyStrengthTagChanged(int tagId, bool tagExists)
	{
		if (this.IsFlying != tagExists)
		{
			this.IsFlying = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600F8B2 RID: 63666 RVA: 0x003C3A5A File Offset: 0x003C1C5A
	protected void OnBaseSpeedUpTagChanged(int tagId, bool tagExists)
	{
		if (this.IsSpeedUp != tagExists)
		{
			this.IsSpeedUp = tagExists;
			this.RefreshSpeedUp();
		}
	}

	// Token: 0x0600F8B3 RID: 63667 RVA: 0x003C3A72 File Offset: 0x003C1C72
	protected void OnLockTagChanged(int tagId, bool tagExists)
	{
		if (this.IsLock != tagExists)
		{
			this.IsLock = tagExists;
			this.RefreshLockState();
		}
	}

	// Token: 0x0600F8B4 RID: 63668 RVA: 0x003C3A8C File Offset: 0x003C1C8C
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

	// Token: 0x0600F8B5 RID: 63669 RVA: 0x003C3AE4 File Offset: 0x003C1CE4
	private void RefreshStrengthPercent(bool bForce = false)
	{
		BattleUiRoleData roleData = this.RoleData;
		BaseAttributeComponent baseAttributeComponent = (roleData != null) ? roleData.AttributeComponent : null;
		if (baseAttributeComponent == null)
		{
			return;
		}
		float currentValue = baseAttributeComponent.GetCurrentValue(this.StrengthAttributeId);
		float currentValue2 = baseAttributeComponent.GetCurrentValue(this.MaxStrengthAttributeId);
		bool flag = currentValue != this.StrengthCurrentValue;
		if (flag)
		{
			this.StrengthCurrentValue = currentValue;
			if (this.IsSpeedUp && this.TailStrengthCurrentValue < this.StrengthCurrentValue)
			{
				this.TailStrengthCurrentValue = this.StrengthCurrentValue;
			}
		}
		if (currentValue2 != this.MaxStrengthCurrentValue)
		{
			flag = true;
			this.MaxStrengthCurrentValue = currentValue2;
			this.RefreshSingleStrengthItemVisible(currentValue2);
		}
		if (flag)
		{
			base.GetSprite(1).SetFillAmount(currentValue / currentValue2);
		}
		this.RefreshStrengthState(bForce);
	}

	// Token: 0x0600F8B6 RID: 63670 RVA: 0x003C3B90 File Offset: 0x003C1D90
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

	// Token: 0x0600F8B7 RID: 63671 RVA: 0x003C3BFC File Offset: 0x003C1DFC
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

	// Token: 0x0600F8B8 RID: 63672 RVA: 0x003C3C94 File Offset: 0x003C1E94
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

	// Token: 0x0600F8B9 RID: 63673 RVA: 0x003C3CE8 File Offset: 0x003C1EE8
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

	// Token: 0x0600F8BA RID: 63674 RVA: 0x003C3D4C File Offset: 0x003C1F4C
	protected void RefreshVisible()
	{
		bool flag = (this.IsFlying || !this.IsFullState) && this.EnableByHighPriority;
		if (this.TargetActive != flag)
		{
			this.SetActive(flag);
		}
	}

	// Token: 0x0600F8BB RID: 63675 RVA: 0x003C3D84 File Offset: 0x003C1F84
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

	// Token: 0x0600F8BC RID: 63676 RVA: 0x003C3DF0 File Offset: 0x003C1FF0
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

	// Token: 0x0600F8BD RID: 63677 RVA: 0x003C3E4B File Offset: 0x003C204B
	protected void RefreshLockState()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLock);
	}

	// Token: 0x0600F8BE RID: 63678 RVA: 0x003C3E64 File Offset: 0x003C2064
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

	// Token: 0x040073AA RID: 29610
	private const int CLOSE_ANIM_TIME = 250;

	// Token: 0x040073AB RID: 29611
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 3;

	// Token: 0x040073AC RID: 29612
	protected EAttributeType StrengthAttributeId = EAttributeType.SpecialEnergy3;

	// Token: 0x040073AD RID: 29613
	protected EAttributeType MaxStrengthAttributeId = EAttributeType.SpecialEnergy3Max;

	// Token: 0x040073AE RID: 29614
	private bool IsNormalState = true;

	// Token: 0x040073AF RID: 29615
	private bool IsFullState = true;

	// Token: 0x040073B0 RID: 29616
	protected bool IsFlying;

	// Token: 0x040073B1 RID: 29617
	protected bool IsSpeedUp;

	// Token: 0x040073B2 RID: 29618
	protected bool IsLock;

	// Token: 0x040073B3 RID: 29619
	private float LowEndurancePercent;

	// Token: 0x040073B4 RID: 29620
	private float SingleStrengthValue;

	// Token: 0x040073B5 RID: 29621
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x040073B6 RID: 29622
	private float TailSpeed = 0.1f;

	// Token: 0x040073B7 RID: 29623
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x040073B8 RID: 29624
	private float StrengthCurrentValue;

	// Token: 0x040073B9 RID: 29625
	private float MaxStrengthCurrentValue;

	// Token: 0x040073BA RID: 29626
	private float TailStrengthCurrentValue;

	// Token: 0x040073BB RID: 29627
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x040073BC RID: 29628
	[Nullable(2)]
	private CustomPromise CloseAnimPromise;

	// Token: 0x040073BD RID: 29629
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("StrengthCloseAnim", "", "");
}
