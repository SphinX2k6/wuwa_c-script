using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D53 RID: 23891
	public class BattleHonamiStoryPlayerLevelView : UiPanelBase
	{
		// Token: 0x0603CA80 RID: 248448 RVA: 0x00E8EF88 File Offset: 0x00E8D188
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CA81 RID: 248449 RVA: 0x00E8EFD0 File Offset: 0x00E8D1D0
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0603CA82 RID: 248450 RVA: 0x00E8EFE3 File Offset: 0x00E8D1E3
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603CA83 RID: 248451 RVA: 0x00E8F000 File Offset: 0x00E8D200
		public void RefreshLevel(int oldValue, int newValue, bool isInit = false)
		{
			base.GetText(0).SetText(newValue.ToString(), true);
			if (isInit || oldValue == newValue || this.SequencePlayer == null)
			{
				return;
			}
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely((oldValue > newValue) ? "Down" : "Upd", false, false);
		}

		// Token: 0x0401F987 RID: 129415
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C001 RID: 49153
		private enum EComponentType
		{
			// Token: 0x04039F01 RID: 237313
			LevelText
		}
	}
}
