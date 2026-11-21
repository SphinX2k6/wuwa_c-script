using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005992 RID: 22930
	public class SolarSchoolContinueButtonItem : UiPanelBase
	{
		// Token: 0x060388A4 RID: 231588 RVA: 0x00FD19D0 File Offset: 0x00FCFBD0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060388A5 RID: 231589 RVA: 0x00FD1A5A File Offset: 0x00FCFC5A
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x060388A6 RID: 231590 RVA: 0x00FD1A85 File Offset: 0x00FCFC85
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName != "Close")
			{
				return;
			}
			base.SetUiActive(false);
		}

		// Token: 0x060388A7 RID: 231591 RVA: 0x00FD1A9C File Offset: 0x00FCFC9C
		public void SetDone(bool isDone)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!isDone);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(isDone);
			}
			this.SetTextById(isDone ? "SolarSchoolLetter_Over" : "SolarSchoolLetter_Next");
		}

		// Token: 0x060388A8 RID: 231592 RVA: 0x00FD1ADC File Offset: 0x00FCFCDC
		[NullableContext(1)]
		public void SetTextById(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
		}

		// Token: 0x060388A9 RID: 231593 RVA: 0x00FD1AF8 File Offset: 0x00FCFCF8
		public void PlayShow(bool blockClick = false)
		{
			base.SetUiActive(true);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", blockClick, null);
		}

		// Token: 0x060388AA RID: 231594 RVA: 0x00FD1B2C File Offset: 0x00FCFD2C
		public void PlayHide(bool blockClick = false)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Close", blockClick, null);
		}

		// Token: 0x0401DC81 RID: 121985
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B538 RID: 46392
		private class EComponents
		{
			// Token: 0x0403807F RID: 229503
			public const int PnlNor = 0;

			// Token: 0x04038080 RID: 229504
			public const int PnlDone = 1;

			// Token: 0x04038081 RID: 229505
			public const int TxtContent = 2;
		}
	}
}
