using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D32 RID: 19762
	public class BattleHonamiStoryLeaveButton : BattleEntranceButton
	{
		// Token: 0x060319B6 RID: 203190 RVA: 0x00DDEC10 File Offset: 0x00DDCE10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			ref ValueTuple<int, Delegate> ptr = ref span2[num];
			int item = 0;
			Action item2;
			if ((item2 = BattleHonamiStoryLeaveButton.<>O.<0>__OnLeaveClick) == null)
			{
				item2 = (BattleHonamiStoryLeaveButton.<>O.<0>__OnLeaveClick = new Action(BattleHonamiStoryLeaveButton.OnLeaveClick));
			}
			ptr = new ValueTuple<int, Delegate>(item, item2);
			this.BtnBindInfo = list2;
		}

		// Token: 0x060319B7 RID: 203191 RVA: 0x00DDECA4 File Offset: 0x00DDCEA4
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.TopButton);
			bool flag = BattleHonamiStoryLeaveButton.CanSafeLeave();
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.PlaySequencePurely(flag ? "Sucs" : "Start", false, false);
			this.AddEvents();
		}

		// Token: 0x060319B8 RID: 203192 RVA: 0x00DDECF8 File Offset: 0x00DDCEF8
		public override void Reset()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x060319B9 RID: 203193 RVA: 0x00DDED1E File Offset: 0x00DDCF1E
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiStoryLeaveButtonUpdate, new Action(this.OnSafeLeaveUpdate));
		}

		// Token: 0x060319BA RID: 203194 RVA: 0x00DDED3C File Offset: 0x00DDCF3C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryLeaveButtonUpdate, new Action(this.OnSafeLeaveUpdate));
		}

		// Token: 0x060319BB RID: 203195 RVA: 0x00DDED5A File Offset: 0x00DDCF5A
		private void OnSafeLeaveUpdate()
		{
			if (BattleHonamiStoryLeaveButton.CanSafeLeave())
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.StopPrevSequence(false, true);
				}
				UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.PlaySequencePurely("Sucs", false, false);
			}
		}

		// Token: 0x060319BC RID: 203196 RVA: 0x00DDED8D File Offset: 0x00DDCF8D
		private static void OnLeaveClick()
		{
			HonamiStoryController.Instance.TryHonamiStoryInstLeave(false);
		}

		// Token: 0x060319BD RID: 203197 RVA: 0x00DDED9A File Offset: 0x00DDCF9A
		private static bool CanSafeLeave()
		{
			return HonamiStoryModel.Instance.CanSafeLeave;
		}

		// Token: 0x0401A433 RID: 107571
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200A9FB RID: 43515
		private enum EComponentType
		{
			// Token: 0x0403489A RID: 215194
			LeaveButton
		}

		// Token: 0x0200A9FC RID: 43516
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403489B RID: 215195
			public static Action <0>__OnLeaveClick;
		}
	}
}
