using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200119A RID: 4506
[NullableContext(2)]
[Nullable(0)]
public class DigitalHpHeadStateHeadState : UiPanelBase, IPanelTickInterface
{
	// Token: 0x0600B3C5 RID: 46021 RVA: 0x00351C4A File Offset: 0x0034FE4A
	[NullableContext(1)]
	protected virtual string GetResourceId()
	{
		return "UiItem_BattleHpMonster";
	}

	// Token: 0x0600B3C6 RID: 46022 RVA: 0x00351C54 File Offset: 0x0034FE54
	[NullableContext(1)]
	public void CreateHeadStateView(USceneComponent parentComponent, FKSC_HeadHpContext headInfo)
	{
		string resourceId = this.GetResourceId();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		double a = (double)(headInfo.Shield / 5);
		this.DividerCount = Math.Max(1, (int)Math.Ceiling(a));
		this.MaxDamageAbsorptionCount = this.DividerCount * 5;
		this.Hp = headInfo.CurHp;
		this.DamageAbsorption = headInfo.Shield;
		base.CreateThenShowByPathAsync(resourcePath, (UUIItem)parentComponent, false).Forget();
	}

	// Token: 0x0600B3C7 RID: 46023 RVA: 0x00351CCC File Offset: 0x0034FECC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIArtText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600B3C8 RID: 46024 RVA: 0x00351D68 File Offset: 0x0034FF68
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.RootItem.SetUIItemScale(new FVector(2.5f, 2.5f, 2.5f));
	}

	// Token: 0x0600B3C9 RID: 46025 RVA: 0x00351D9C File Offset: 0x0034FF9C
	protected override UniTask OnBeforeStartAsync()
	{
		DigitalHpHeadStateHeadState.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DigitalHpHeadStateHeadState.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3CA RID: 46026 RVA: 0x00351DE0 File Offset: 0x0034FFE0
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600B3CB RID: 46027 RVA: 0x00351E0C File Offset: 0x0035000C
	protected override UniTask OnBeforeHideAsync()
	{
		DigitalHpHeadStateHeadState.<OnBeforeHideAsync>d__21 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DigitalHpHeadStateHeadState.<OnBeforeHideAsync>d__21>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3CC RID: 46028 RVA: 0x00351E4F File Offset: 0x0035004F
	protected override void OnAfterHide()
	{
		UiManager.Instance.RemoveTickView(this);
	}

	// Token: 0x0600B3CD RID: 46029 RVA: 0x00351E5C File Offset: 0x0035005C
	protected void InitShieldBarDivider()
	{
		if (this.ShieldBarDivider == null || this.DividerCount <= 1)
		{
			return;
		}
		float width = this.ShieldBarDivider.GetWidth();
		float num = width * 0.5f;
		UUIItem item = base.GetItem(3);
		float num2 = (item.GetWidth() - width) / (float)this.DividerCount;
		for (int i = 1; i < this.DividerCount; i++)
		{
			num += num2;
			LguiUtil.Instance.CopyItem(this.ShieldBarDivider, item).SetAnchorOffsetX(num);
		}
	}

	// Token: 0x0600B3CE RID: 46030 RVA: 0x00351ED8 File Offset: 0x003500D8
	[NullableContext(1)]
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		this.UpdateHeadStateLocation(headInfo.Location);
		this.UpdateHpText((float)headInfo.CurHp);
		this.UpdateShieldBar((float)headInfo.Shield);
	}

	// Token: 0x0600B3CF RID: 46031 RVA: 0x00351F00 File Offset: 0x00350100
	protected void UpdateHpText(float newHp)
	{
		float num = this.DigitScroll.SetTarget(newHp);
		if (num != 0f)
		{
			UiManager.Instance.AddTickView(this);
		}
		if (num < 0f)
		{
			this.SequencePlayer.PlaySequencePurely("Hit", false, false, null, null, false);
		}
	}

	// Token: 0x0600B3D0 RID: 46032 RVA: 0x00351F50 File Offset: 0x00350150
	protected void UpdateShieldBar(float newShield)
	{
		if (this.DamageAbsorption != (int)newShield)
		{
			this.DamageAbsorption = (int)newShield;
			UUISprite shieldBar = this.ShieldBar;
			if (shieldBar != null)
			{
				shieldBar.SetFillAmount(Math.Min(newShield / (float)this.MaxDamageAbsorptionCount, 1f));
			}
			if (newShield <= 0f)
			{
				base.GetItem(5).SetUIActive(false);
			}
		}
	}

	// Token: 0x0600B3D1 RID: 46033 RVA: 0x00351FA8 File Offset: 0x003501A8
	private void UpdateHeadStateLocation(FVectorDouble location)
	{
		Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		commonTempVector.FromUeVector(location);
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIRelativeLocation(commonTempVector.ToUeVectorOld());
	}

	// Token: 0x0600B3D2 RID: 46034 RVA: 0x00351FE0 File Offset: 0x003501E0
	protected void RefreshHeadStateRotation()
	{
		Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
		Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
		commonTempRotator.Yaw = cameraRotator.Yaw + 90f;
		commonTempRotator.Roll = cameraRotator.Pitch - 90f;
		commonTempRotator.Pitch = 0f;
		UUIItem rootItem = this.RootItem;
		FRotator frotator = commonTempRotator.ToUeRotator();
		rootItem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0600B3D3 RID: 46035 RVA: 0x0035204C File Offset: 0x0035024C
	public void Tick(float delta)
	{
		if (this.DigitScroll.IsFinished())
		{
			UiManager.Instance.RemoveTickView(this);
			return;
		}
		float num = this.DigitScroll.Tick(delta);
		UUIArtText hpText = this.HpText;
		if (hpText == null)
		{
			return;
		}
		hpText.SetText(MotorcycleUtil.CompactNumberFormat((float)Math.Floor((double)num)));
	}

	// Token: 0x0600B3D4 RID: 46036 RVA: 0x0035209C File Offset: 0x0035029C
	public void AfterTick(float delta)
	{
	}

	// Token: 0x040067CB RID: 26571
	private const int DAMAGEABSORPTION_PERCELL = 5;

	// Token: 0x040067CC RID: 26572
	private const int MIN_CELL_COUNT = 1;

	// Token: 0x040067CD RID: 26573
	private const int SCROLL_DURATION = 500;

	// Token: 0x040067CE RID: 26574
	private const float DEFAULT_SCALE = 2.5f;

	// Token: 0x040067CF RID: 26575
	private int Hp = -1;

	// Token: 0x040067D0 RID: 26576
	private int DamageAbsorption = -1;

	// Token: 0x040067D1 RID: 26577
	protected UUIArtText HpText;

	// Token: 0x040067D2 RID: 26578
	protected UUIItem ShieldBarLine;

	// Token: 0x040067D3 RID: 26579
	protected UUISprite ShieldBar;

	// Token: 0x040067D4 RID: 26580
	protected UUISprite ShieldBarDivider;

	// Token: 0x040067D5 RID: 26581
	protected int DividerCount;

	// Token: 0x040067D6 RID: 26582
	protected int MaxDamageAbsorptionCount;

	// Token: 0x040067D7 RID: 26583
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x040067D8 RID: 26584
	[Nullable(1)]
	private readonly DigitScroll DigitScroll = new DigitScroll();

	// Token: 0x02007463 RID: 29795
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025E34 RID: 155188
		public const int Self = 0;

		// Token: 0x04025E35 RID: 155189
		public const int SpriteShieldBar = 1;

		// Token: 0x04025E36 RID: 155190
		public const int ArtTextHpNum = 2;

		// Token: 0x04025E37 RID: 155191
		public const int ShieldBarLine = 3;

		// Token: 0x04025E38 RID: 155192
		public const int ShieldBarDivider = 4;

		// Token: 0x04025E39 RID: 155193
		public const int ShieldRootItem = 5;
	}
}
