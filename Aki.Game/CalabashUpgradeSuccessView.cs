using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200177C RID: 6012
public class CalabashUpgradeSuccessView : UiViewBase
{
	// Token: 0x0600AEC4 RID: 44740 RVA: 0x00277AC0 File Offset: 0x00275CC0
	[NullableContext(1)]
	public CalabashUpgradeSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AEC5 RID: 44741 RVA: 0x00277B04 File Offset: 0x00275D04
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

	// Token: 0x0600AEC6 RID: 44742 RVA: 0x00277BCC File Offset: 0x00275DCC
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

	// Token: 0x17000E7F RID: 3711
	// (get) Token: 0x0600AEC7 RID: 44743 RVA: 0x00277D8E File Offset: 0x00275F8E
	private bool IsOverLoop
	{
		get
		{
			return this.IsLevelUp && this.ShowingExp >= this.PreMaxExp;
		}
	}

	// Token: 0x0600AEC8 RID: 44744 RVA: 0x00277DAC File Offset: 0x00275FAC
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

	// Token: 0x0600AEC9 RID: 44745 RVA: 0x00277E72 File Offset: 0x00276072
	private void RemoveTimer()
	{
		if (this.AnimTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AnimTimer);
			this.AnimTimer = null;
		}
	}

	// Token: 0x0600AECA RID: 44746 RVA: 0x00277E94 File Offset: 0x00276094
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

	// Token: 0x0600AECB RID: 44747 RVA: 0x00277F00 File Offset: 0x00276100
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

	// Token: 0x04004F52 RID: 20306
	private bool IsLevelUp;

	// Token: 0x04004F53 RID: 20307
	private bool IsExpUp;

	// Token: 0x04004F54 RID: 20308
	private bool IsOverLevel;

	// Token: 0x04004F55 RID: 20309
	private float ShowingExp;

	// Token: 0x04004F56 RID: 20310
	private float PreMaxExp;

	// Token: 0x04004F57 RID: 20311
	private float TargetExp;

	// Token: 0x04004F58 RID: 20312
	private float CurMaxExp;

	// Token: 0x04004F59 RID: 20313
	private float AddExp;

	// Token: 0x04004F5A RID: 20314
	[Nullable(2)]
	private TimerHandle AnimTimer;

	// Token: 0x04004F5B RID: 20315
	private readonly int AnimeTime = ConfigCommonParamById.GetIntConfig("ExpDisplayTime").Value;

	// Token: 0x04004F5C RID: 20316
	private readonly int CloseTime = ConfigCommonParamById.GetIntConfig("ExpDisplayCloseTime").Value;

	// Token: 0x02007D85 RID: 32133
	private enum ECalabashUpgradeSuccessDefine
	{
		// Token: 0x040291A6 RID: 168358
		PreLevelTxt,
		// Token: 0x040291A7 RID: 168359
		TxtExp,
		// Token: 0x040291A8 RID: 168360
		BarExp,
		// Token: 0x040291A9 RID: 168361
		CurLevelTxt,
		// Token: 0x040291AA RID: 168362
		LevelDesc,
		// Token: 0x040291AB RID: 168363
		PanelExp,
		// Token: 0x040291AC RID: 168364
		PanelLevel,
		// Token: 0x040291AD RID: 168365
		LevelUpItem
	}
}
