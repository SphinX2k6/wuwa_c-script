using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BB6 RID: 19382
	public class CiacconaGalStepChosenItem : UiPanelBase
	{
		// Token: 0x06030642 RID: 198210 RVA: 0x00D7C5D8 File Offset: 0x00D7A7D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030643 RID: 198211 RVA: 0x00D7C641 File Offset: 0x00D7A841
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06030644 RID: 198212 RVA: 0x00D7C654 File Offset: 0x00D7A854
		protected override void OnAfterShow()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06030645 RID: 198213 RVA: 0x00D7C684 File Offset: 0x00D7A884
		[NullableContext(1)]
		public void Refresh(CiacconaGalChoiceData choiceData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), choiceData.Content, Array.Empty<object>());
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon03"), base.GetTexture(1), null, null);
		}

		// Token: 0x04019A35 RID: 105013
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A7B9 RID: 42937
		private class EComponentDefine
		{
			// Token: 0x04033D11 RID: 212241
			public const int TextContent = 0;

			// Token: 0x04033D12 RID: 212242
			public const int ImageIcon = 1;
		}
	}
}
