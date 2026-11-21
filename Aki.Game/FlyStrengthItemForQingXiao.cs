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

// Token: 0x0200141F RID: 5151
[NullableContext(1)]
[Nullable(0)]
public class FlyStrengthItemForQingXiao : StrengthItemBase
{
	// Token: 0x0600CCC4 RID: 52420 RVA: 0x003CF06E File Offset: 0x003CD26E
	protected override string GetResourceId()
	{
		return "UiItem_EnergyFly";
	}

	// Token: 0x0600CCC5 RID: 52421 RVA: 0x003CF078 File Offset: 0x003CD278
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

	// Token: 0x0600CCC6 RID: 52422 RVA: 0x003CF1CC File Offset: 0x003CD3CC
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

	// Token: 0x0600CCC7 RID: 52423 RVA: 0x003CF281 File Offset: 0x003CD481
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		base.StopTweenAnim(8);
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600CCC8 RID: 52424 RVA: 0x003CF298 File Offset: 0x003CD498
	protected override UniTask OnBeforeHideAsync()
	{
		FlyStrengthItemForQingXiao.<OnBeforeHideAsync>d__24 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<FlyStrengthItemForQingXiao.<OnBeforeHideAsync>d__24>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CCC9 RID: 52425 RVA: 0x003CF2DB File Offset: 0x003CD4DB
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CCCA RID: 52426 RVA: 0x003CF2E9 File Offset: 0x003CD4E9
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

	// Token: 0x0600CCCB RID: 52427 RVA: 0x003CF320 File Offset: 0x003CD520
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

	// Token: 0x0600CCCC RID: 52428 RVA: 0x003CF41C File Offset: 0x003CD61C
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

	// Token: 0x0600CCCD RID: 52429 RVA: 0x003CF514 File Offset: 0x003CD714
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600CCCE RID: 52430 RVA: 0x003CF51C File Offset: 0x003CD71C
	private void OnStrengthChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600CCCF RID: 52431 RVA: 0x003CF525 File Offset: 0x003CD725
	private void OnStrengthMaxChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600CCD0 RID: 52432 RVA: 0x003CF52E File Offset: 0x003CD72E
	protected void OnFlyStrengthTagChanged(int tagId, bool tagExists)
	{
		if (this.IsFlying != tagExists)
		{
			this.IsFlying = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CCD1 RID: 52433 RVA: 0x003CF546 File Offset: 0x003CD746
	protected void OnBaseSpeedUpTagChanged(int tagId, bool tagExists)
	{
		if (this.IsSpeedUp != tagExists)
		{
			this.IsSpeedUp = tagExists;
			this.RefreshSpeedUp();
		}
	}

	// Token: 0x0600CCD2 RID: 52434 RVA: 0x003CF55E File Offset: 0x003CD75E
	protected void OnLockTagChanged(int tagId, bool tagExists)
	{
		if (this.IsLock != tagExists)
		{
			this.IsLock = tagExists;
			this.RefreshLockState();
		}
	}

	// Token: 0x0600CCD3 RID: 52435 RVA: 0x003CF578 File Offset: 0x003CD778
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

	// Token: 0x0600CCD4 RID: 52436 RVA: 0x003CF5D0 File Offset: 0x003CD7D0
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

	// Token: 0x0600CCD5 RID: 52437 RVA: 0x003CF67C File Offset: 0x003CD87C
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

	// Token: 0x0600CCD6 RID: 52438 RVA: 0x003CF6E8 File Offset: 0x003CD8E8
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

	// Token: 0x0600CCD7 RID: 52439 RVA: 0x003CF780 File Offset: 0x003CD980
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

	// Token: 0x0600CCD8 RID: 52440 RVA: 0x003CF7D4 File Offset: 0x003CD9D4
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

	// Token: 0x0600CCD9 RID: 52441 RVA: 0x003CF838 File Offset: 0x003CDA38
	protected void RefreshVisible()
	{
		bool flag = (this.IsFlying || !this.IsFullState) && this.EnableByHighPriority;
		if (this.TargetActive != flag)
		{
			this.SetActive(flag);
		}
	}

	// Token: 0x0600CCDA RID: 52442 RVA: 0x003CF870 File Offset: 0x003CDA70
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

	// Token: 0x0600CCDB RID: 52443 RVA: 0x003CF8DC File Offset: 0x003CDADC
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

	// Token: 0x0600CCDC RID: 52444 RVA: 0x003CF937 File Offset: 0x003CDB37
	protected void RefreshLockState()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLock);
	}

	// Token: 0x0600CCDD RID: 52445 RVA: 0x003CF950 File Offset: 0x003CDB50
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

	// Token: 0x0400748B RID: 29835
	private const int CLOSE_ANIM_TIME = 250;

	// Token: 0x0400748C RID: 29836
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 3;

	// Token: 0x0400748D RID: 29837
	protected EAttributeType StrengthAttributeId = EAttributeType.SpecialEnergy3;

	// Token: 0x0400748E RID: 29838
	protected EAttributeType MaxStrengthAttributeId = EAttributeType.SpecialEnergy3Max;

	// Token: 0x0400748F RID: 29839
	private bool IsNormalState = true;

	// Token: 0x04007490 RID: 29840
	private bool IsFullState = true;

	// Token: 0x04007491 RID: 29841
	protected bool IsFlying;

	// Token: 0x04007492 RID: 29842
	protected bool IsSpeedUp;

	// Token: 0x04007493 RID: 29843
	protected bool IsLock;

	// Token: 0x04007494 RID: 29844
	private float LowEndurancePercent;

	// Token: 0x04007495 RID: 29845
	private float SingleStrengthValue;

	// Token: 0x04007496 RID: 29846
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x04007497 RID: 29847
	private float TailSpeed = 0.1f;

	// Token: 0x04007498 RID: 29848
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x04007499 RID: 29849
	private float StrengthCurrentValue;

	// Token: 0x0400749A RID: 29850
	private float MaxStrengthCurrentValue;

	// Token: 0x0400749B RID: 29851
	private float TailStrengthCurrentValue;

	// Token: 0x0400749C RID: 29852
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x0400749D RID: 29853
	[Nullable(2)]
	private CustomPromise CloseAnimPromise;

	// Token: 0x0400749E RID: 29854
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("StrengthCloseAnim", "", "");
}
