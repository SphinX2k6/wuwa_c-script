using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02005258 RID: 21080
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDialogItem : UiPanelBase
	{
		// Token: 0x06035DFD RID: 220669 RVA: 0x00CBFDEF File Offset: 0x00CBDFEF
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035DFE RID: 220670 RVA: 0x00CBFE12 File Offset: 0x00CBE012
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06035DFF RID: 220671 RVA: 0x00CBFE3C File Offset: 0x00CBE03C
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035E00 RID: 220672 RVA: 0x00CBFE49 File Offset: 0x00CBE049
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035E01 RID: 220673 RVA: 0x00CBFE5F File Offset: 0x00CBE05F
		public UUIText GetDialog()
		{
			return base.GetText(0);
		}

		// Token: 0x06035E02 RID: 220674 RVA: 0x00CBFE68 File Offset: 0x00CBE068
		public void SetDialogActive(bool active)
		{
			if (active)
			{
				this.SetActive(true);
				this.Sequence.StopPrevSequence(false, true);
				this.Sequence.PlaySequencePurely("Start", false, false);
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x0401C8CF RID: 116943
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B416 RID: 46102
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036916 RID: 223510
			public const int DialogText = 0;
		}
	}
}
