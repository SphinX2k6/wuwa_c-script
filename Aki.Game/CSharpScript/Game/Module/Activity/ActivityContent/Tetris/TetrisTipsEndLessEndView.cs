using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006027 RID: 24615
	public class TetrisTipsEndLessEndView : TetrisTipsBaseView
	{
		// Token: 0x0603E4E4 RID: 255204 RVA: 0x00F0C47B File Offset: 0x00F0A67B
		[NullableContext(1)]
		public TetrisTipsEndLessEndView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E4E5 RID: 255205 RVA: 0x00F0C484 File Offset: 0x00F0A684
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603E4E6 RID: 255206 RVA: 0x00F0C4E0 File Offset: 0x00F0A6E0
		protected override void OnStart()
		{
			base.OnStart();
			object openParam = this.OpenParam;
			if (openParam is int)
			{
				int value = (int)openParam;
				this.Param = new int?(value);
				return;
			}
			this.Param = new int?((this.OpenParam as IEndLessEndOpenParam).Score);
			this.IsQuit = (this.OpenParam as IEndLessEndOpenParam).IsQuit;
		}

		// Token: 0x0603E4E7 RID: 255207 RVA: 0x00F0C547 File Offset: 0x00F0A747
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603E4E8 RID: 255208 RVA: 0x00F0C550 File Offset: 0x00F0A750
		protected override void OnClose()
		{
			if (this.IsQuit)
			{
				base.CloseMe(delegate(bool _)
				{
					UiManager.Instance.CloseView(EUiViewName.TetrisPlayView, null);
				});
				return;
			}
			base.OnClose();
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView != null)
			{
				tetrisPlayView.OpenLoseConfirm();
			}
		}

		// Token: 0x0603E4E9 RID: 255209 RVA: 0x00F0C5B0 File Offset: 0x00F0A7B0
		private void Refresh()
		{
			if (this.IsQuit)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_ChallengeFinish_Text", Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Tetristext_13", new <>z__ReadOnlySingleElementList<object>(this.Param.Value.ToString()));
			base.GetItem(2).SetUIActive((long)this.Param.Value > TetrisController.Instance.GetHighestScore());
		}

		// Token: 0x04020907 RID: 133383
		private int? Param;

		// Token: 0x04020908 RID: 133384
		private bool IsQuit;
	}
}
