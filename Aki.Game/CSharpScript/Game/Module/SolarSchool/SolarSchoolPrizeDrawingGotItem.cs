using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200591C RID: 22812
	[NullableContext(2)]
	[Nullable(0)]
	internal class SolarSchoolPrizeDrawingGotItem : UiPanelBase
	{
		// Token: 0x060383BE RID: 230334 RVA: 0x00FB8E30 File Offset: 0x00FB7030
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

		// Token: 0x060383BF RID: 230335 RVA: 0x00FB8E99 File Offset: 0x00FB7099
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

		// Token: 0x060383C0 RID: 230336 RVA: 0x00FB8ED7 File Offset: 0x00FB70D7
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x060383C1 RID: 230337 RVA: 0x00FB8EE9 File Offset: 0x00FB70E9
		public void SetIndexText(int index)
		{
			UUIText txtItem = this.TxtItem;
			if (txtItem == null)
			{
				return;
			}
			txtItem.SetText((index < 10) ? ("0" + index.ToString()) : index.ToString(), true);
		}

		// Token: 0x060383C2 RID: 230338 RVA: 0x00FB8F1C File Offset: 0x00FB711C
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

		// Token: 0x0401D9A7 RID: 121255
		private UUIItem PnlGotItem;

		// Token: 0x0401D9A8 RID: 121256
		private UUIText TxtItem;

		// Token: 0x0401D9A9 RID: 121257
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
