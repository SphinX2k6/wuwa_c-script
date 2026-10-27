using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x020066FF RID: 26367
	public class DropCatchGameplayPauseView : UiViewBase
	{
		// Token: 0x06041DF1 RID: 269809 RVA: 0x00FF976C File Offset: 0x00FF796C
		[NullableContext(1)]
		public DropCatchGameplayPauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041DF2 RID: 269810 RVA: 0x00FF9778 File Offset: 0x00FF7978
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

		// Token: 0x06041DF3 RID: 269811 RVA: 0x00FF9867 File Offset: 0x00FF7A67
		protected override void OnStart()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			this.Proxy.PauseGameplay("PauseView");
			this.InitScoreLevelLayout();
			this.RefreshCurScore();
			this.RefreshRestartButtonVisible();
		}

		// Token: 0x06041DF4 RID: 269812 RVA: 0x00FF989C File Offset: 0x00FF7A9C
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

		// Token: 0x06041DF5 RID: 269813 RVA: 0x00FF999C File Offset: 0x00FF7B9C
		private void RefreshCurScore()
		{
			UUIArtText artText = base.GetArtText(0);
			if (artText == null)
			{
				return;
			}
			artText.SetText(this.Proxy.GetCurScore().ToString());
		}

		// Token: 0x06041DF6 RID: 269814 RVA: 0x00FF99D0 File Offset: 0x00FF7BD0
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

		// Token: 0x06041DF7 RID: 269815 RVA: 0x00FF9A41 File Offset: 0x00FF7C41
		private void OnClickContinue()
		{
			base.CloseMe(null);
		}

		// Token: 0x06041DF8 RID: 269816 RVA: 0x00FF9A4A File Offset: 0x00FF7C4A
		private void OnClickRestart()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			if (proxy != null)
			{
				proxy.StartGameplay(this.Proxy.GetCurGameplayId());
			}
			base.CloseMe(null);
		}

		// Token: 0x06041DF9 RID: 269817 RVA: 0x00FF9A70 File Offset: 0x00FF7C70
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

		// Token: 0x06041DFA RID: 269818 RVA: 0x00FF9AD2 File Offset: 0x00FF7CD2
		protected override void OnBeforeDestroy()
		{
			DropCatchGameplayProxy proxy = this.Proxy;
			if (proxy == null)
			{
				return;
			}
			proxy.ResumeGameplay("PauseView");
		}

		// Token: 0x04022508 RID: 140552
		[Nullable(2)]
		private DropCatchGameplayProxy Proxy;

		// Token: 0x04022509 RID: 140553
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DropCatchPauseScoreItem, IScoreLevelItemData> ScoreLevelLayout;
	}
}
