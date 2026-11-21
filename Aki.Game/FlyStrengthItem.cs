using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200141C RID: 5148
[NullableContext(1)]
[Nullable(0)]
public class FlyStrengthItem : StrengthItemBase
{
	// Token: 0x0600CC9B RID: 52379 RVA: 0x003CE305 File Offset: 0x003CC505
	protected override string GetResourceId()
	{
		return "UiItem_EnergyFly";
	}

	// Token: 0x0600CC9C RID: 52380 RVA: 0x003CE30C File Offset: 0x003CC50C
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

	// Token: 0x0600CC9D RID: 52381 RVA: 0x003CE460 File Offset: 0x003CC660
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

	// Token: 0x0600CC9E RID: 52382 RVA: 0x003CE515 File Offset: 0x003CC715
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		base.StopTweenAnim(8);
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600CC9F RID: 52383 RVA: 0x003CE52C File Offset: 0x003CC72C
	protected override UniTask OnBeforeHideAsync()
	{
		FlyStrengthItem.<OnBeforeHideAsync>d__28 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<FlyStrengthItem.<OnBeforeHideAsync>d__28>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CCA0 RID: 52384 RVA: 0x003CE56F File Offset: 0x003CC76F
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CCA1 RID: 52385 RVA: 0x003CE57D File Offset: 0x003CC77D
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

	// Token: 0x0600CCA2 RID: 52386 RVA: 0x003CE5B2 File Offset: 0x003CC7B2
	protected override void OnAddEvents()
	{
		FormationAttributeController.Instance.AddValueListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthMaxChanged), null);
	}

	// Token: 0x0600CCA3 RID: 52387 RVA: 0x003CE5EE File Offset: 0x003CC7EE
	protected override void OnRemoveEvents()
	{
		FormationAttributeController.Instance.RemoveValueListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(this.StrengthAttributeId, new TValueListener(this.OnStrengthMaxChanged));
	}

	// Token: 0x0600CCA4 RID: 52388 RVA: 0x003CE628 File Offset: 0x003CC828
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

	// Token: 0x0600CCA5 RID: 52389 RVA: 0x003CE738 File Offset: 0x003CC938
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

	// Token: 0x0600CCA6 RID: 52390 RVA: 0x003CE896 File Offset: 0x003CCA96
	protected override void OnEnableByHighPriority(bool b)
	{
		this.RefreshVisible();
	}

	// Token: 0x0600CCA7 RID: 52391 RVA: 0x003CE89E File Offset: 0x003CCA9E
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600CCA8 RID: 52392 RVA: 0x003CE8A7 File Offset: 0x003CCAA7
	private void OnStrengthMaxChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.RefreshStrengthPercent(false);
	}

	// Token: 0x0600CCA9 RID: 52393 RVA: 0x003CE8B0 File Offset: 0x003CCAB0
	protected void OnFlyTagChanged(int tagId, bool tagExists)
	{
		this.IsFlyTag = tagExists;
		if (this.IsFlying != (this.IsFlyTag || this.IsFlyStrengthTag))
		{
			this.IsFlying = !this.IsFlying;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CCAA RID: 52394 RVA: 0x003CE8E7 File Offset: 0x003CCAE7
	protected void OnFlyStrengthTagChanged(int tagId, bool tagExists)
	{
		this.IsFlyStrengthTag = tagExists;
		if (this.IsFlying != (this.IsFlyTag || this.IsFlyStrengthTag))
		{
			this.IsFlying = !this.IsFlying;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CCAB RID: 52395 RVA: 0x003CE91E File Offset: 0x003CCB1E
	protected void OnSpeedUpTagChanged(int tagId, bool tagExists)
	{
		this.IsSpeedUpTag = tagExists;
		if (this.IsSpeedUp != (this.IsSpeedUpTag || this.IsBaseSpeedUpTag))
		{
			this.IsSpeedUp = !this.IsSpeedUp;
			this.RefreshSpeedUp();
		}
	}

	// Token: 0x0600CCAC RID: 52396 RVA: 0x003CE955 File Offset: 0x003CCB55
	protected void OnBaseSpeedUpTagChanged(int tagId, bool tagExists)
	{
		this.IsBaseSpeedUpTag = tagExists;
		if (this.IsSpeedUp != (this.IsFlyTag || this.IsBaseSpeedUpTag))
		{
			this.IsSpeedUp = !this.IsSpeedUp;
			this.RefreshSpeedUp();
		}
	}

	// Token: 0x0600CCAD RID: 52397 RVA: 0x003CE98C File Offset: 0x003CCB8C
	protected void OnLockTagChanged(int tagId, bool tagExists)
	{
		if (this.IsLock != tagExists)
		{
			this.IsLock = tagExists;
			this.RefreshLockState();
		}
	}

	// Token: 0x0600CCAE RID: 52398 RVA: 0x003CE9A4 File Offset: 0x003CCBA4
	protected void OnHideTagChanged(int tagId, bool tagExists)
	{
		if (this.IsHideTag != tagExists)
		{
			this.IsHideTag = tagExists;
			this.RefreshVisible();
		}
	}

	// Token: 0x0600CCAF RID: 52399 RVA: 0x003CE9BC File Offset: 0x003CCBBC
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

	// Token: 0x0600CCB0 RID: 52400 RVA: 0x003CEA14 File Offset: 0x003CCC14
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

	// Token: 0x0600CCB1 RID: 52401 RVA: 0x003CEAB0 File Offset: 0x003CCCB0
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

	// Token: 0x0600CCB2 RID: 52402 RVA: 0x003CEB1C File Offset: 0x003CCD1C
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

	// Token: 0x0600CCB3 RID: 52403 RVA: 0x003CEBB4 File Offset: 0x003CCDB4
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

	// Token: 0x0600CCB4 RID: 52404 RVA: 0x003CEC08 File Offset: 0x003CCE08
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

	// Token: 0x0600CCB5 RID: 52405 RVA: 0x003CEC6C File Offset: 0x003CCE6C
	protected virtual void RefreshVisible()
	{
		bool active = !this.IsHideTag && (this.IsFlying || !this.IsFullState) && this.EnableByHighPriority;
		this.SetActive(active);
	}

	// Token: 0x0600CCB6 RID: 52406 RVA: 0x003CECA4 File Offset: 0x003CCEA4
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

	// Token: 0x0600CCB7 RID: 52407 RVA: 0x003CED10 File Offset: 0x003CCF10
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

	// Token: 0x0600CCB8 RID: 52408 RVA: 0x003CED6B File Offset: 0x003CCF6B
	protected void RefreshLockState()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsLock);
	}

	// Token: 0x0600CCB9 RID: 52409 RVA: 0x003CED84 File Offset: 0x003CCF84
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

	// Token: 0x04007468 RID: 29800
	private const int CLOSE_ANIM_TIME = 250;

	// Token: 0x04007469 RID: 29801
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 3;

	// Token: 0x0400746A RID: 29802
	protected EFormationAttributeId StrengthAttributeId = EFormationAttributeId.SoarStrength;

	// Token: 0x0400746B RID: 29803
	private bool IsNormalState = true;

	// Token: 0x0400746C RID: 29804
	protected bool IsFullState = true;

	// Token: 0x0400746D RID: 29805
	protected bool IsFlying;

	// Token: 0x0400746E RID: 29806
	protected bool IsSpeedUp;

	// Token: 0x0400746F RID: 29807
	protected bool IsLock;

	// Token: 0x04007470 RID: 29808
	protected bool IsHideTag;

	// Token: 0x04007471 RID: 29809
	private bool IsFlyTag;

	// Token: 0x04007472 RID: 29810
	private bool IsFlyStrengthTag;

	// Token: 0x04007473 RID: 29811
	private bool IsSpeedUpTag;

	// Token: 0x04007474 RID: 29812
	private bool IsBaseSpeedUpTag;

	// Token: 0x04007475 RID: 29813
	private float LowEndurancePercent;

	// Token: 0x04007476 RID: 29814
	private float SingleStrengthValue;

	// Token: 0x04007477 RID: 29815
	private int MaxSingleStrengthItemCount = 1;

	// Token: 0x04007478 RID: 29816
	private float TailSpeed = 0.1f;

	// Token: 0x04007479 RID: 29817
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x0400747A RID: 29818
	private float StrengthCurrentValue;

	// Token: 0x0400747B RID: 29819
	private float MaxStrengthCurrentValue;

	// Token: 0x0400747C RID: 29820
	private float TailStrengthCurrentValue;

	// Token: 0x0400747D RID: 29821
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x0400747E RID: 29822
	[Nullable(2)]
	private CustomPromise CloseAnimPromise;

	// Token: 0x0400747F RID: 29823
	[StaticVariableRuleIgnore]
	private static readonly Stat CloseAnimTimerStat = Stat.Create("StrengthCloseAnim", "", "");
}
