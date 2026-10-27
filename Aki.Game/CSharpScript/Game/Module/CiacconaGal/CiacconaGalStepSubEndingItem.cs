using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE0 RID: 23520
	public class CiacconaGalStepSubEndingItem : UiPanelBase
	{
		// Token: 0x0603B747 RID: 243527 RVA: 0x00E2D360 File Offset: 0x00E2B560
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

		// Token: 0x0603B748 RID: 243528 RVA: 0x00E2D3A8 File Offset: 0x00E2B5A8
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B749 RID: 243529 RVA: 0x00E2D3BC File Offset: 0x00E2B5BC
		public void PlayStart()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B74A RID: 243530 RVA: 0x00E2D3E9 File Offset: 0x00E2B5E9
		[NullableContext(1)]
		public void Refresh(CiacconaGalSubEndingData subEndingData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), subEndingData.Desc, Array.Empty<object>());
		}

		// Token: 0x0401EF9F RID: 126879
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDC3 RID: 48579
		private class EComponentDefine
		{
			// Token: 0x0403938A RID: 234378
			public const int TextContent = 0;
		}
	}
}
