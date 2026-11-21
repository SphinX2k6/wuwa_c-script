using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004036 RID: 16438
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotViewGiantSubtitle : PlotViewHud
	{
		// Token: 0x06029A5D RID: 170589 RVA: 0x00BC5CD1 File Offset: 0x00BC3ED1
		public PlotViewGiantSubtitle(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029A5E RID: 170590 RVA: 0x00BC5CDA File Offset: 0x00BC3EDA
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(14, typeof(UUIText)));
		}

		// Token: 0x06029A5F RID: 170591 RVA: 0x00BC5D1C File Offset: 0x00BC3F1C
		protected override void OnStart()
		{
			base.OnStart();
			this.GiantSeqPlayer = new LevelSequencePlayer(base.GetItem(13));
			UUIText text = base.GetText(14);
			if (text != null)
			{
				text.SetGameRichText(true);
			}
			UUIText text2 = base.GetText(14);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x06029A60 RID: 170592 RVA: 0x00BC5D69 File Offset: 0x00BC3F69
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.PlayGiantStartAnim));
		}

		// Token: 0x06029A61 RID: 170593 RVA: 0x00BC5D8D File Offset: 0x00BC3F8D
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.PlayGiantStartAnim));
		}

		// Token: 0x06029A62 RID: 170594 RVA: 0x00BC5DB4 File Offset: 0x00BC3FB4
		private void PlayGiantStartAnim(ITalkItem inPlotSubtitleInfo)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			LevelSequencePlayer giantSeqPlayer = this.GiantSeqPlayer;
			if (giantSeqPlayer != null)
			{
				giantSeqPlayer.StopPlayingSequence(false, true);
			}
			LevelSequencePlayer giantSeqPlayer2 = this.GiantSeqPlayer;
			if (giantSeqPlayer2 == null)
			{
				return;
			}
			giantSeqPlayer2.PlayLevelSequenceByName(PlotViewGiantSubtitle.startSeqByStyle[this.GetGiantStyle()], false, null, false);
		}

		// Token: 0x06029A63 RID: 170595 RVA: 0x00BC5E38 File Offset: 0x00BC4038
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotViewGiantSubtitle.<OnPlayingCloseSequenceAsync>d__11 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotViewGiantSubtitle.<OnPlayingCloseSequenceAsync>d__11>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029A64 RID: 170596 RVA: 0x00BC5E7C File Offset: 0x00BC407C
		private EGiantSubtitleStyle GetGiantStyle()
		{
			IPlotModeUiStyleLevelD plotModeUiStyle = PlotModel.Instance.PlotConfig.PlotModeUiStyle;
			IUiStyleGiantSubtitleOfLevelD uiStyleGiantSubtitleOfLevelD = ((plotModeUiStyle != null) ? plotModeUiStyle.UiStyle : null) as IUiStyleGiantSubtitleOfLevelD;
			if (uiStyleGiantSubtitleOfLevelD != null && uiStyleGiantSubtitleOfLevelD.Type == EUiStyleTypeOfLevelD.GiantSubtitle)
			{
				this.LastGiantStyle = uiStyleGiantSubtitleOfLevelD.Style;
			}
			return this.LastGiantStyle;
		}

		// Token: 0x06029A65 RID: 170597 RVA: 0x00BC5EC7 File Offset: 0x00BC40C7
		private bool IsRedStyle()
		{
			return this.GetGiantStyle() == EGiantSubtitleStyle.Angry;
		}

		// Token: 0x06029A66 RID: 170598 RVA: 0x00BC5ED4 File Offset: 0x00BC40D4
		protected override void OnPlotContentUpdated(string text)
		{
			if (this.IsRedStyle())
			{
				UUIText text2 = base.GetText(2);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				UUIText text3 = base.GetText(14);
				if (text3 != null)
				{
					text3.SetText(text, true);
				}
				UUIText text4 = base.GetText(14);
				if (text4 == null)
				{
					return;
				}
				text4.SetUIActive(true);
				return;
			}
			else
			{
				UUIText text5 = base.GetText(14);
				if (text5 != null)
				{
					text5.SetUIActive(false);
				}
				UUIText text6 = base.GetText(2);
				if (text6 == null)
				{
					return;
				}
				text6.SetUIActive(true);
				return;
			}
		}

		// Token: 0x06029A67 RID: 170599 RVA: 0x00BC5F4B File Offset: 0x00BC414B
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer giantSeqPlayer = this.GiantSeqPlayer;
			if (giantSeqPlayer != null)
			{
				giantSeqPlayer.Clear();
			}
			this.GiantSeqPlayer = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x04016BC7 RID: 93127
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EGiantSubtitleStyle, string> startSeqByStyle = new Dictionary<EGiantSubtitleStyle, string>
		{
			{
				EGiantSubtitleStyle.Angry,
				"Start01"
			},
			{
				EGiantSubtitleStyle.Happy,
				"Start02"
			},
			{
				EGiantSubtitleStyle.Sad,
				"Start03"
			},
			{
				EGiantSubtitleStyle.Curious,
				"Start04"
			},
			{
				EGiantSubtitleStyle.Neutral,
				"Start05"
			}
		};

		// Token: 0x04016BC8 RID: 93128
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EGiantSubtitleStyle, string> closeSeqByStyle = new Dictionary<EGiantSubtitleStyle, string>
		{
			{
				EGiantSubtitleStyle.Angry,
				"Close01"
			},
			{
				EGiantSubtitleStyle.Happy,
				"Close02"
			},
			{
				EGiantSubtitleStyle.Sad,
				"Close03"
			},
			{
				EGiantSubtitleStyle.Curious,
				"Close04"
			},
			{
				EGiantSubtitleStyle.Neutral,
				"Close05"
			}
		};

		// Token: 0x04016BC9 RID: 93129
		[Nullable(2)]
		private LevelSequencePlayer GiantSeqPlayer;

		// Token: 0x04016BCA RID: 93130
		private EGiantSubtitleStyle LastGiantStyle;

		// Token: 0x02009C22 RID: 39970
		[NullableContext(0)]
		private enum EGiantCompDefine
		{
			// Token: 0x040309A4 RID: 199076
			NpcName,
			// Token: 0x040309A5 RID: 199077
			NpcTitle,
			// Token: 0x040309A6 RID: 199078
			ContentWhite,
			// Token: 0x040309A7 RID: 199079
			LineItem,
			// Token: 0x040309A8 RID: 199080
			GiantTips = 13,
			// Token: 0x040309A9 RID: 199081
			ContentRed
		}
	}
}
