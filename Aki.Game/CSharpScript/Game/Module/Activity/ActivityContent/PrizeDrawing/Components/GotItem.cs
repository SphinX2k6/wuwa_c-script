using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components
{
	// Token: 0x02005225 RID: 21029
	[NullableContext(2)]
	[Nullable(0)]
	internal class GotItem : UiPanelBase
	{
		// Token: 0x06034552 RID: 214354 RVA: 0x00EA44D8 File Offset: 0x00EA26D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034553 RID: 214355 RVA: 0x00EA4541 File Offset: 0x00EA2741
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TxtItem = base.GetText(0);
			this.PnlGotItem = base.GetItem(1);
			UUIItem pnlGotItem = this.PnlGotItem;
			if (pnlGotItem == null)
			{
				return;
			}
			pnlGotItem.SetUIActive(false);
		}

		// Token: 0x06034554 RID: 214356 RVA: 0x00EA457F File Offset: 0x00EA277F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x06034555 RID: 214357 RVA: 0x00EA4591 File Offset: 0x00EA2791
		public void SetIndexText(int index)
		{
			UUIText txtItem = this.TxtItem;
			if (txtItem == null)
			{
				return;
			}
			txtItem.SetText((index < 10) ? ("0" + index.ToString()) : index.ToString(), true);
		}

		// Token: 0x06034556 RID: 214358 RVA: 0x00EA45C4 File Offset: 0x00EA27C4
		public void RefreshGotState(bool isGot, bool animBanned = false)
		{
			UUIItem pnlGotItem = this.PnlGotItem;
			if ((pnlGotItem == null || !pnlGotItem.IsUIActiveSelf()) && isGot && !animBanned)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
				}
			}
			UUIItem pnlGotItem2 = this.PnlGotItem;
			if (pnlGotItem2 == null)
			{
				return;
			}
			pnlGotItem2.SetUIActive(isGot);
		}

		// Token: 0x0401BC9B RID: 113819
		private UUIItem PnlGotItem;

		// Token: 0x0401BC9C RID: 113820
		private UUIText TxtItem;

		// Token: 0x0401BC9D RID: 113821
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
