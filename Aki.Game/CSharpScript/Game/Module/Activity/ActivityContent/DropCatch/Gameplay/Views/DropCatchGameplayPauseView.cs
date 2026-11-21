using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x0200564F RID: 22095
	public class DropCatchGameplayPauseView : UiViewBase
	{
		// Token: 0x0603693D RID: 223549 RVA: 0x00F3AB60 File Offset: 0x00F38D60
		[NullableContext(1)]
		public DropCatchGameplayPauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603693E RID: 223550 RVA: 0x00F3AB6C File Offset: 0x00F38D6C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickExit)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickContinue)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickRestart))
			};
		}

		// Token: 0x0603693F RID: 223551 RVA: 0x00F3AC5B File Offset: 0x00F38E5B
		protected override void OnStart()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			this.Proxy.PauseGameplay("PauseView");
			this.InitScoreLevelLayout();
			this.RefreshCurScore();
			this.RefreshRestartButtonVisible();
		}

		// Token: 0x06036940 RID: 223552 RVA: 0x00F3AC90 File Offset: 0x00F38E90
		private void InitScoreLevelLayout()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			List<float> list;
			if (proxy == null)
			{
				list = null;
			}
			else
			{
				DropCatchGameplayViewModel gameplayViewModel = proxy.GetGameplayViewModel();
				list = ((gameplayViewModel != null) ? gameplayViewModel.GetScoreLevels() : null);
			}
			List<float> list2 = list;
			if (list2 == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "获取关卡配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ScoreLevelLayout = new GenericLayout<DropCatchPauseScoreItem, IScoreLevelItemData>(base.GetVerticalLayout(1), () => new DropCatchPauseScoreItem(), null, false, true);
			List<IScoreLevelItemData> list3 = new List<IScoreLevelItemData>();
			foreach (float num in list2)
			{
				list3.Add(new IScoreLevelItemData
				{
					Score = num,
					IsFinish = (this.Proxy.GetCurScore() >= num)
				});
			}
			this.ScoreLevelLayout.RefreshByData(list3, null, false);
		}

		// Token: 0x06036941 RID: 223553 RVA: 0x00F3AD90 File Offset: 0x00F38F90
		private void RefreshCurScore()
		{
			UUIArtText artText = base.GetArtText(0);
			if (artText == null)
			{
				return;
			}
			artText.SetText(this.Proxy.GetCurScore().ToString());
		}

		// Token: 0x06036942 RID: 223554 RVA: 0x00F3ADC4 File Offset: 0x00F38FC4
		private void OnClickExit()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			DropCatchGameplay? dropCatchGameplay = (proxy != null) ? proxy.GetGameplayConfig() : null;
			if (dropCatchGameplay != null && dropCatchGameplay.GetValueOrDefault().IsNeedSettle)
			{
				DropCatchGameplayProxy proxy2 = this.Proxy;
				if (proxy2 != null)
				{
					proxy2.SettleGameplay(EDropCatchGameplaySettleReason.Exit);
				}
			}
			else
			{
				DropCatchGameplayProxy proxy3 = this.Proxy;
				if (proxy3 != null)
				{
					proxy3.EndGameplay();
				}
			}
			base.CloseMe(null);
		}

		// Token: 0x06036943 RID: 223555 RVA: 0x00F3AE35 File Offset: 0x00F39035
		private void OnClickContinue()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036944 RID: 223556 RVA: 0x00F3AE3E File Offset: 0x00F3903E
		private void OnClickRestart()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			if (proxy != null)
			{
				proxy.StartGameplay(this.Proxy.GetCurGameplayId());
			}
			base.CloseMe(null);
		}

		// Token: 0x06036945 RID: 223557 RVA: 0x00F3AE64 File Offset: 0x00F39064
		private void RefreshRestartButtonVisible()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			DropCatchGameplay? dropCatchGameplay = (proxy != null) ? proxy.GetGameplayConfig() : null;
			if (dropCatchGameplay == null)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(5);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(!dropCatchGameplay.Value.IsSpecial);
		}

		// Token: 0x06036946 RID: 223558 RVA: 0x00F3AEC6 File Offset: 0x00F390C6
		protected override void OnBeforeDestroy()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			if (proxy == null)
			{
				return;
			}
			proxy.ResumeGameplay("PauseView");
		}

		// Token: 0x0401CD61 RID: 118113
		[Nullable(2)]
		private DropCatchGameplayProxy Proxy;

		// Token: 0x0401CD62 RID: 118114
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DropCatchPauseScoreItem, IScoreLevelItemData> ScoreLevelLayout;
	}
}
