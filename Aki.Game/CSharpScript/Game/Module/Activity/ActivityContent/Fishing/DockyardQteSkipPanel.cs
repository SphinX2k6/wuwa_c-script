using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B9 RID: 26041
	public class DockyardQteSkipPanel : UiPanelBase, IDockyardLeftTipsInterface
	{
		// Token: 0x1700958D RID: 38285
		// (get) Token: 0x06041521 RID: 267553 RVA: 0x00FD47E8 File Offset: 0x00FD29E8
		// (set) Token: 0x06041522 RID: 267554 RVA: 0x00FD47F0 File Offset: 0x00FD29F0
		public bool LockState { get; set; }

		// Token: 0x06041523 RID: 267555 RVA: 0x00FD47FC File Offset: 0x00FD29FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnContinueClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnExitClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041524 RID: 267556 RVA: 0x00FD48E6 File Offset: 0x00FD2AE6
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string eventName)
			{
				if (eventName == "Hide")
				{
					this.SetActive(false);
				}
			}, false);
		}

		// Token: 0x06041525 RID: 267557 RVA: 0x00FD4914 File Offset: 0x00FD2B14
		public void SetPanelVisible(bool bVisible)
		{
			if (this.LockState)
			{
				return;
			}
			if (bVisible)
			{
				this.LevelSequencePlayer.StopCurrentSequence(true, true);
				this.LevelSequencePlayer.PlaySequencePurely("Show", false, false, null, null, false);
				this.SetActive(true);
				return;
			}
			this.LevelSequencePlayer.StopCurrentSequence(true, true);
			this.LevelSequencePlayer.PlaySequencePurely("Hide", false, false, null, null, false);
		}

		// Token: 0x06041526 RID: 267558 RVA: 0x00FD4989 File Offset: 0x00FD2B89
		public void SetQtePanelText(int currentCount, int maxCount)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Unfish", new <>z__ReadOnlySingleElementList<object>(maxCount - currentCount));
		}

		// Token: 0x06041527 RID: 267559 RVA: 0x00FD49AE File Offset: 0x00FD2BAE
		public void SetQtePanelTextVisible(bool bVisible)
		{
			base.GetText(0).SetUIActive(bVisible);
		}

		// Token: 0x06041528 RID: 267560 RVA: 0x00FD49C0 File Offset: 0x00FD2BC0
		public void SetButtonContinueVisible(bool bVisible)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06041529 RID: 267561 RVA: 0x00FD49E8 File Offset: 0x00FD2BE8
		public void SetButtonExitVisible(bool bVisible)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x0604152A RID: 267562 RVA: 0x00FD4A0F File Offset: 0x00FD2C0F
		private void OnContinueClick()
		{
			Action continueFunc = this.ContinueFunc;
			if (continueFunc == null)
			{
				return;
			}
			continueFunc();
		}

		// Token: 0x0604152B RID: 267563 RVA: 0x00FD4A21 File Offset: 0x00FD2C21
		private void OnExitClick()
		{
			Action exitFunc = this.ExitFunc;
			if (exitFunc == null)
			{
				return;
			}
			exitFunc();
		}

		// Token: 0x04021FF3 RID: 139251
		[Nullable(1)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04021FF4 RID: 139252
		[Nullable(2)]
		public Action ContinueFunc;

		// Token: 0x04021FF5 RID: 139253
		[Nullable(2)]
		public Action ExitFunc;

		// Token: 0x0200C7D4 RID: 51156
		private class EComponentDefine
		{
			// Token: 0x0403C5BA RID: 247226
			public const int Content = 0;

			// Token: 0x0403C5BB RID: 247227
			public const int Continue = 1;

			// Token: 0x0403C5BC RID: 247228
			public const int Exit = 2;
		}
	}
}
