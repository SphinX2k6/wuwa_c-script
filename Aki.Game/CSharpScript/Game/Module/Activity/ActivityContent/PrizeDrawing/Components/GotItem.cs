using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components
{
	// Token: 0x020062A7 RID: 25255
	[NullableContext(2)]
	[Nullable(0)]
	internal class GotItem : UiPanelBase
	{
		// Token: 0x0603F891 RID: 260241 RVA: 0x00F5D57C File Offset: 0x00F5B77C
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

		// Token: 0x0603F892 RID: 260242 RVA: 0x00F5D5E5 File Offset: 0x00F5B7E5
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

		// Token: 0x0603F893 RID: 260243 RVA: 0x00F5D623 File Offset: 0x00F5B823
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603F894 RID: 260244 RVA: 0x00F5D635 File Offset: 0x00F5B835
		public void SetIndexText(int index)
		{
			UUIText txtItem = this.TxtItem;
			if (txtItem == null)
			{
				return;
			}
			txtItem.SetText((index < 10) ? ("0" + index.ToString()) : index.ToString(), true);
		}

		// Token: 0x0603F895 RID: 260245 RVA: 0x00F5D668 File Offset: 0x00F5B868
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

		// Token: 0x0402136C RID: 136044
		private UUIItem PnlGotItem;

		// Token: 0x0402136D RID: 136045
		private UUIText TxtItem;

		// Token: 0x0402136E RID: 136046
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
