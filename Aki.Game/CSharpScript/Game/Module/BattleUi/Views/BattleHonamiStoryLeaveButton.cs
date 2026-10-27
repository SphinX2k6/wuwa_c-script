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
	// Token: 0x02005D50 RID: 23888
	public class BattleHonamiStoryLeaveButton : BattleEntranceButton
	{
		// Token: 0x0603CA5D RID: 248413 RVA: 0x00E8E45C File Offset: 0x00E8C65C
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

		// Token: 0x0603CA5E RID: 248414 RVA: 0x00E8E4F0 File Offset: 0x00E8C6F0
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

		// Token: 0x0603CA5F RID: 248415 RVA: 0x00E8E544 File Offset: 0x00E8C744
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

		// Token: 0x0603CA60 RID: 248416 RVA: 0x00E8E56A File Offset: 0x00E8C76A
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnHonamiStoryLeaveButtonUpdate, new Action(this.OnSafeLeaveUpdate));
		}

		// Token: 0x0603CA61 RID: 248417 RVA: 0x00E8E588 File Offset: 0x00E8C788
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryLeaveButtonUpdate, new Action(this.OnSafeLeaveUpdate));
		}

		// Token: 0x0603CA62 RID: 248418 RVA: 0x00E8E5A6 File Offset: 0x00E8C7A6
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

		// Token: 0x0603CA63 RID: 248419 RVA: 0x00E8E5D9 File Offset: 0x00E8C7D9
		private static void OnLeaveClick()
		{
			HonamiStoryController.Instance.TryHonamiStoryInstLeave(false);
		}

		// Token: 0x0603CA64 RID: 248420 RVA: 0x00E8E5E6 File Offset: 0x00E8C7E6
		private static bool CanSafeLeave()
		{
			return HonamiStoryModel.Instance.CanSafeLeave;
		}

		// Token: 0x0401F97A RID: 129402
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200BFF5 RID: 49141
		private enum EComponentType
		{
			// Token: 0x04039ED8 RID: 237272
			LeaveButton
		}

		// Token: 0x0200BFF6 RID: 49142
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039ED9 RID: 237273
			public static Action <0>__OnLeaveClick;
		}
	}
}
