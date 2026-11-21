using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D35 RID: 19765
	public class BattleHonamiStoryPlayerLevelView : UiPanelBase
	{
		// Token: 0x060319D9 RID: 203225 RVA: 0x00DDF73C File Offset: 0x00DDD93C
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

		// Token: 0x060319DA RID: 203226 RVA: 0x00DDF784 File Offset: 0x00DDD984
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x060319DB RID: 203227 RVA: 0x00DDF797 File Offset: 0x00DDD997
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060319DC RID: 203228 RVA: 0x00DDF7B4 File Offset: 0x00DDD9B4
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

		// Token: 0x0401A440 RID: 107584
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200AA07 RID: 43527
		private enum EComponentType
		{
			// Token: 0x040348C3 RID: 215235
			LevelText
		}
	}
}
