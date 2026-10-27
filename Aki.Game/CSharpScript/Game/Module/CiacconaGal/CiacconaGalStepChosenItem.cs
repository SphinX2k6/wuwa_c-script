using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD6 RID: 23510
	public class CiacconaGalStepChosenItem : UiPanelBase
	{
		// Token: 0x0603B6F7 RID: 243447 RVA: 0x00E2C2D0 File Offset: 0x00E2A4D0
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

		// Token: 0x0603B6F8 RID: 243448 RVA: 0x00E2C339 File Offset: 0x00E2A539
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B6F9 RID: 243449 RVA: 0x00E2C34C File Offset: 0x00E2A54C
		protected override void OnAfterShow()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B6FA RID: 243450 RVA: 0x00E2C37C File Offset: 0x00E2A57C
		[NullableContext(1)]
		public void Refresh(CiacconaGalChoiceData choiceData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), choiceData.Content, Array.Empty<object>());
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon03"), base.GetTexture(1), null, null);
		}

		// Token: 0x0401EF84 RID: 126852
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDB0 RID: 48560
		private class EComponentDefine
		{
			// Token: 0x0403934C RID: 234316
			public const int TextContent = 0;

			// Token: 0x0403934D RID: 234317
			public const int ImageIcon = 1;
		}
	}
}
