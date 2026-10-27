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
	// Token: 0x02005066 RID: 20582
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotViewGiantSubtitle : PlotViewHud
	{
		// Token: 0x06034B6A RID: 215914 RVA: 0x00C78A01 File Offset: 0x00C76C01
		public PlotViewGiantSubtitle(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034B6B RID: 215915 RVA: 0x00C78A0A File Offset: 0x00C76C0A
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(14, typeof(UUIText)));
		}

		// Token: 0x06034B6C RID: 215916 RVA: 0x00C78A4C File Offset: 0x00C76C4C
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

		// Token: 0x06034B6D RID: 215917 RVA: 0x00C78A99 File Offset: 0x00C76C99
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.PlayGiantStartAnim));
		}

		// Token: 0x06034B6E RID: 215918 RVA: 0x00C78ABD File Offset: 0x00C76CBD
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.PlayGiantStartAnim));
		}

		// Token: 0x06034B6F RID: 215919 RVA: 0x00C78AE4 File Offset: 0x00C76CE4
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
			UUIText text3 = base.GetText(14);
			if (text3 != null)
			{
				text3.SetUIActive(false);
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

		// Token: 0x06034B70 RID: 215920 RVA: 0x00C78B7C File Offset: 0x00C76D7C
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotViewGiantSubtitle.<OnPlayingCloseSequenceAsync>d__11 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotViewGiantSubtitle.<OnPlayingCloseSequenceAsync>d__11>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B71 RID: 215921 RVA: 0x00C78BC0 File Offset: 0x00C76DC0
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

		// Token: 0x06034B72 RID: 215922 RVA: 0x00C78C0B File Offset: 0x00C76E0B
		private bool IsRedStyle()
		{
			return this.GetGiantStyle() == EGiantSubtitleStyle.Angry;
		}

		// Token: 0x06034B73 RID: 215923 RVA: 0x00C78C18 File Offset: 0x00C76E18
		protected override void OnPlotContentUpdated(string text)
		{
			if (!this.IsRedStyle())
			{
				return;
			}
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
		}

		// Token: 0x06034B74 RID: 215924 RVA: 0x00C78C69 File Offset: 0x00C76E69
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

		// Token: 0x0401C19C RID: 115100
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

		// Token: 0x0401C19D RID: 115101
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

		// Token: 0x0401C19E RID: 115102
		[Nullable(2)]
		private LevelSequencePlayer GiantSeqPlayer;

		// Token: 0x0401C19F RID: 115103
		private EGiantSubtitleStyle LastGiantStyle;

		// Token: 0x0200B1E8 RID: 45544
		[NullableContext(0)]
		private enum EGiantCompDefine
		{
			// Token: 0x04035F4F RID: 221007
			NpcName,
			// Token: 0x04035F50 RID: 221008
			NpcTitle,
			// Token: 0x04035F51 RID: 221009
			ContentWhite,
			// Token: 0x04035F52 RID: 221010
			LineItem,
			// Token: 0x04035F53 RID: 221011
			GiantTips = 13,
			// Token: 0x04035F54 RID: 221012
			ContentRed
		}
	}
}
