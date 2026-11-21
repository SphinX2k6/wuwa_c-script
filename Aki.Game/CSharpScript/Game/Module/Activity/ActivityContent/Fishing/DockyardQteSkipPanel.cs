using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005537 RID: 21815
	public class DockyardQteSkipPanel : UiPanelBase, IDockyardLeftTipsInterface
	{
		// Token: 0x170068EF RID: 26863
		// (get) Token: 0x060361E6 RID: 221670 RVA: 0x00F1B824 File Offset: 0x00F19A24
		// (set) Token: 0x060361E7 RID: 221671 RVA: 0x00F1B82C File Offset: 0x00F19A2C
		public bool LockState { get; set; }

		// Token: 0x060361E8 RID: 221672 RVA: 0x00F1B838 File Offset: 0x00F19A38
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

		// Token: 0x060361E9 RID: 221673 RVA: 0x00F1B922 File Offset: 0x00F19B22
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

		// Token: 0x060361EA RID: 221674 RVA: 0x00F1B950 File Offset: 0x00F19B50
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

		// Token: 0x060361EB RID: 221675 RVA: 0x00F1B9C5 File Offset: 0x00F19BC5
		public void SetQtePanelText(int currentCount, int maxCount)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_QTE_Unfish", new <>z__ReadOnlySingleElementList<object>(maxCount - currentCount));
		}

		// Token: 0x060361EC RID: 221676 RVA: 0x00F1B9EA File Offset: 0x00F19BEA
		public void SetQtePanelTextVisible(bool bVisible)
		{
			base.GetText(0).SetUIActive(bVisible);
		}

		// Token: 0x060361ED RID: 221677 RVA: 0x00F1B9FC File Offset: 0x00F19BFC
		public void SetButtonContinueVisible(bool bVisible)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x060361EE RID: 221678 RVA: 0x00F1BA24 File Offset: 0x00F19C24
		public void SetButtonExitVisible(bool bVisible)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x060361EF RID: 221679 RVA: 0x00F1BA4B File Offset: 0x00F19C4B
		private void OnContinueClick()
		{
			Action continueFunc = this.ContinueFunc;
			if (continueFunc == null)
			{
				return;
			}
			continueFunc();
		}

		// Token: 0x060361F0 RID: 221680 RVA: 0x00F1BA5D File Offset: 0x00F19C5D
		private void OnExitClick()
		{
			Action exitFunc = this.ExitFunc;
			if (exitFunc == null)
			{
				return;
			}
			exitFunc();
		}

		// Token: 0x0401C924 RID: 117028
		[Nullable(1)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401C925 RID: 117029
		[Nullable(2)]
		public Action ContinueFunc;

		// Token: 0x0401C926 RID: 117030
		[Nullable(2)]
		public Action ExitFunc;

		// Token: 0x0200B1B7 RID: 45495
		private class EComponentDefine
		{
			// Token: 0x04036F08 RID: 225032
			public const int Content = 0;

			// Token: 0x04036F09 RID: 225033
			public const int Continue = 1;

			// Token: 0x04036F0A RID: 225034
			public const int Exit = 2;
		}
	}
}
