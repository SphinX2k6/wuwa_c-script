using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC0 RID: 19392
	public class CiacconaGalStepSubEndingItem : UiPanelBase
	{
		// Token: 0x06030692 RID: 198290 RVA: 0x00D7D668 File Offset: 0x00D7B868
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

		// Token: 0x06030693 RID: 198291 RVA: 0x00D7D6B0 File Offset: 0x00D7B8B0
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06030694 RID: 198292 RVA: 0x00D7D6C4 File Offset: 0x00D7B8C4
		public void PlayStart()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06030695 RID: 198293 RVA: 0x00D7D6F1 File Offset: 0x00D7B8F1
		[NullableContext(1)]
		public void Refresh(CiacconaGalSubEndingData subEndingData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), subEndingData.Desc, Array.Empty<object>());
		}

		// Token: 0x04019A50 RID: 105040
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A7CC RID: 42956
		private class EComponentDefine
		{
			// Token: 0x04033D4F RID: 212303
			public const int TextContent = 0;
		}
	}
}
