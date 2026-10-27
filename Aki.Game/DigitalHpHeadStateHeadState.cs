using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CD8 RID: 7384
[NullableContext(2)]
[Nullable(0)]
public class DigitalHpHeadStateHeadState : UiPanelBase, IPanelTickInterface
{
	// Token: 0x0600DFA8 RID: 57256 RVA: 0x00346222 File Offset: 0x00344422
	[NullableContext(1)]
	protected virtual string GetResourceId()
	{
		return "UiItem_BattleHpMonster";
	}

	// Token: 0x0600DFA9 RID: 57257 RVA: 0x0034622C File Offset: 0x0034442C
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

	// Token: 0x0600DFAA RID: 57258 RVA: 0x003462A4 File Offset: 0x003444A4
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

	// Token: 0x0600DFAB RID: 57259 RVA: 0x00346340 File Offset: 0x00344540
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.RootItem.SetUIItemScale(new FVector(2.5f, 2.5f, 2.5f));
	}

	// Token: 0x0600DFAC RID: 57260 RVA: 0x00346374 File Offset: 0x00344574
	protected override UniTask OnBeforeStartAsync()
	{
		DigitalHpHeadStateHeadState.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DigitalHpHeadStateHeadState.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFAD RID: 57261 RVA: 0x003463B8 File Offset: 0x003445B8
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600DFAE RID: 57262 RVA: 0x003463E4 File Offset: 0x003445E4
	protected override UniTask OnBeforeHideAsync()
	{
		DigitalHpHeadStateHeadState.<OnBeforeHideAsync>d__21 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DigitalHpHeadStateHeadState.<OnBeforeHideAsync>d__21>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFAF RID: 57263 RVA: 0x00346427 File Offset: 0x00344627
	protected override void OnAfterHide()
	{
		UiManager.Instance.RemoveTickView(this);
	}

	// Token: 0x0600DFB0 RID: 57264 RVA: 0x00346434 File Offset: 0x00344634
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

	// Token: 0x0600DFB1 RID: 57265 RVA: 0x003464B0 File Offset: 0x003446B0
	[NullableContext(1)]
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		this.UpdateHeadStateLocation(headInfo.Location);
		this.UpdateHpText((float)headInfo.CurHp);
		this.UpdateShieldBar((float)headInfo.Shield);
	}

	// Token: 0x0600DFB2 RID: 57266 RVA: 0x003464D8 File Offset: 0x003446D8
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

	// Token: 0x0600DFB3 RID: 57267 RVA: 0x00346528 File Offset: 0x00344728
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

	// Token: 0x0600DFB4 RID: 57268 RVA: 0x00346580 File Offset: 0x00344780
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

	// Token: 0x0600DFB5 RID: 57269 RVA: 0x003465B8 File Offset: 0x003447B8
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

	// Token: 0x0600DFB6 RID: 57270 RVA: 0x00346624 File Offset: 0x00344824
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

	// Token: 0x0600DFB7 RID: 57271 RVA: 0x00346674 File Offset: 0x00344874
	public void AfterTick(float delta)
	{
	}

	// Token: 0x040066EC RID: 26348
	private const int DAMAGEABSORPTION_PERCELL = 5;

	// Token: 0x040066ED RID: 26349
	private const int MIN_CELL_COUNT = 1;

	// Token: 0x040066EE RID: 26350
	private const int SCROLL_DURATION = 500;

	// Token: 0x040066EF RID: 26351
	private const float DEFAULT_SCALE = 2.5f;

	// Token: 0x040066F0 RID: 26352
	private int Hp = -1;

	// Token: 0x040066F1 RID: 26353
	private int DamageAbsorption = -1;

	// Token: 0x040066F2 RID: 26354
	protected UUIArtText HpText;

	// Token: 0x040066F3 RID: 26355
	protected UUIItem ShieldBarLine;

	// Token: 0x040066F4 RID: 26356
	protected UUISprite ShieldBar;

	// Token: 0x040066F5 RID: 26357
	protected UUISprite ShieldBarDivider;

	// Token: 0x040066F6 RID: 26358
	protected int DividerCount;

	// Token: 0x040066F7 RID: 26359
	protected int MaxDamageAbsorptionCount;

	// Token: 0x040066F8 RID: 26360
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x040066F9 RID: 26361
	[Nullable(1)]
	private readonly DigitScroll DigitScroll = new DigitScroll();

	// Token: 0x020082DA RID: 33498
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AB0C RID: 174860
		public const int Self = 0;

		// Token: 0x0402AB0D RID: 174861
		public const int SpriteShieldBar = 1;

		// Token: 0x0402AB0E RID: 174862
		public const int ArtTextHpNum = 2;

		// Token: 0x0402AB0F RID: 174863
		public const int ShieldBarLine = 3;

		// Token: 0x0402AB10 RID: 174864
		public const int ShieldBarDivider = 4;

		// Token: 0x0402AB11 RID: 174865
		public const int ShieldRootItem = 5;
	}
}
