using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C35 RID: 3125
public class CalabashUpgradeSuccessView : UiViewBase
{
	// Token: 0x060082AB RID: 33451 RVA: 0x00281F84 File Offset: 0x00280184
	[NullableContext(1)]
	public CalabashUpgradeSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060082AC RID: 33452 RVA: 0x00281FC8 File Offset: 0x002801C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x060082AD RID: 33453 RVA: 0x00282090 File Offset: 0x00280290
	protected override void OnStart()
	{
		ICalabashUpgradeSuccessViedData calabashUpgradeSuccessViedData = this.OpenParam as ICalabashUpgradeSuccessViedData;
		this.IsLevelUp = (calabashUpgradeSuccessViedData.CurLevel > calabashUpgradeSuccessViedData.PreLevel);
		this.IsExpUp = calabashUpgradeSuccessViedData.AddExp;
		this.IsOverLevel = false;
		base.GetItem(6).SetUIActive(!this.IsExpUp);
		base.GetItem(5).SetUIActive(this.IsExpUp);
		if (this.IsLevelUp)
		{
			base.GetText(3).SetText(calabashUpgradeSuccessViedData.CurLevel.ToString(), true);
			CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(calabashUpgradeSuccessViedData.CurLevel);
			if (calabashConfigByLevel != null && !StringUtils.IsEmpty(calabashConfigByLevel.Value.LevelUpDescription))
			{
				base.GetItem(7).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), calabashConfigByLevel.Value.LevelUpDescription, Array.Empty<object>());
			}
			else
			{
				base.GetItem(7).SetUIActive(false);
			}
		}
		if (this.IsExpUp)
		{
			base.GetText(0).SetText(calabashUpgradeSuccessViedData.PreLevel.ToString(), true);
			this.ShowingExp = (float)calabashUpgradeSuccessViedData.PreExp;
			this.PreMaxExp = (float)CalabashModel.Instance.GetMaxExpByLevel(calabashUpgradeSuccessViedData.PreLevel);
			this.CurMaxExp = (float)CalabashModel.Instance.GetMaxExpByLevel(calabashUpgradeSuccessViedData.CurLevel);
			this.TargetExp = (this.IsLevelUp ? ((float)calabashUpgradeSuccessViedData.CurExp + this.PreMaxExp) : ((float)calabashUpgradeSuccessViedData.CurExp));
			this.AddExp = (this.TargetExp - this.ShowingExp) / (float)this.AnimeTime;
			this.RefreshExp();
		}
		this.UiViewSequence.AddSequenceFinishEvent("LevelUp", delegate(string _)
		{
			this.RemoveTimer();
			base.CloseMe(null);
		}, false);
	}

	// Token: 0x17000EA2 RID: 3746
	// (get) Token: 0x060082AE RID: 33454 RVA: 0x00282252 File Offset: 0x00280452
	private bool IsOverLoop
	{
		get
		{
			return this.IsLevelUp && this.ShowingExp >= this.PreMaxExp;
		}
	}

	// Token: 0x060082AF RID: 33455 RVA: 0x00282270 File Offset: 0x00280470
	private void RefreshExp()
	{
		float num = this.IsOverLoop ? (this.ShowingExp - this.PreMaxExp) : this.ShowingExp;
		float num2 = this.IsOverLoop ? this.CurMaxExp : this.PreMaxExp;
		UUIText text = base.GetText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Round((double)num));
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<float>(num2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetSprite(2).SetFillAmount(num / num2);
		if (this.AnimTimer != null && num > num2 && !this.IsOverLevel)
		{
			this.IsOverLevel = true;
			this.UiViewSequence.PlaySequence("Stuck", false, null);
		}
	}

	// Token: 0x060082B0 RID: 33456 RVA: 0x00282336 File Offset: 0x00280536
	private void RemoveTimer()
	{
		if (this.AnimTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AnimTimer);
			this.AnimTimer = null;
		}
	}

	// Token: 0x060082B1 RID: 33457 RVA: 0x00282358 File Offset: 0x00280558
	protected override void OnAfterPlayStartSequence()
	{
		if (this.IsExpUp)
		{
			this.AnimTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.BarExpAnime), 20f, 1f, null, null, true);
			return;
		}
		this.AnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RemoveTimer();
			base.CloseMe(null);
		}, (float)this.CloseTime, null, null, true, 1f);
	}

	// Token: 0x060082B2 RID: 33458 RVA: 0x002823C4 File Offset: 0x002805C4
	private void BarExpAnime(float delta)
	{
		this.ShowingExp += this.AddExp * delta;
		if (this.ShowingExp >= this.TargetExp)
		{
			this.ShowingExp = this.TargetExp;
			this.RemoveTimer();
			if (this.IsLevelUp)
			{
				base.GetItem(6).SetUIActive(true);
				base.GetItem(5).SetUIActive(false);
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence("LevelUp", false, null);
				}
			}
			else
			{
				base.CloseMe(null);
			}
		}
		this.RefreshExp();
	}

	// Token: 0x04004FFC RID: 20476
	private bool IsLevelUp;

	// Token: 0x04004FFD RID: 20477
	private bool IsExpUp;

	// Token: 0x04004FFE RID: 20478
	private bool IsOverLevel;

	// Token: 0x04004FFF RID: 20479
	private float ShowingExp;

	// Token: 0x04005000 RID: 20480
	private float PreMaxExp;

	// Token: 0x04005001 RID: 20481
	private float TargetExp;

	// Token: 0x04005002 RID: 20482
	private float CurMaxExp;

	// Token: 0x04005003 RID: 20483
	private float AddExp;

	// Token: 0x04005004 RID: 20484
	[Nullable(2)]
	private TimerHandle AnimTimer;

	// Token: 0x04005005 RID: 20485
	private readonly int AnimeTime = ConfigCommonParamById.GetIntConfig("ExpDisplayTime").Value;

	// Token: 0x04005006 RID: 20486
	private readonly int CloseTime = ConfigCommonParamById.GetIntConfig("ExpDisplayCloseTime").Value;

	// Token: 0x02006F0B RID: 28427
	private enum ECalabashUpgradeSuccessDefine
	{
		// Token: 0x040244D1 RID: 148689
		PreLevelTxt,
		// Token: 0x040244D2 RID: 148690
		TxtExp,
		// Token: 0x040244D3 RID: 148691
		BarExp,
		// Token: 0x040244D4 RID: 148692
		CurLevelTxt,
		// Token: 0x040244D5 RID: 148693
		LevelDesc,
		// Token: 0x040244D6 RID: 148694
		PanelExp,
		// Token: 0x040244D7 RID: 148695
		PanelLevel,
		// Token: 0x040244D8 RID: 148696
		LevelUpItem
	}
}
