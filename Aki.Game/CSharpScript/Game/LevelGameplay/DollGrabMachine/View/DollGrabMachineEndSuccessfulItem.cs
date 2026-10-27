using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006F04 RID: 28420
	public class DollGrabMachineEndSuccessfulItem : UiPanelBase
	{
		// Token: 0x060452EB RID: 283371 RVA: 0x0111D1BC File Offset: 0x0111B3BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060452EC RID: 283372 RVA: 0x0111D228 File Offset: 0x0111B428
		protected override void OnBeforeShow()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x040240D9 RID: 147673
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
