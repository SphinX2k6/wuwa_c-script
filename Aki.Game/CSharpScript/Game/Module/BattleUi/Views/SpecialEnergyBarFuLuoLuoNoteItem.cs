using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD9 RID: 24025
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarFuLuoLuoNoteItem : UiPanelBase
	{
		// Token: 0x0603D117 RID: 250135 RVA: 0x00EB1394 File Offset: 0x00EAF594
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D118 RID: 250136 RVA: 0x00EB14C4 File Offset: 0x00EAF6C4
		protected override void OnStart()
		{
			base.OnStart();
			this.ItemList.Add(base.GetItem(0));
			this.ItemList.Add(base.GetItem(1));
			this.ItemList.Add(base.GetItem(2));
			this.InitTweenAnim(3);
			this.InitTweenAnim(4);
			this.InitTweenAnim(5);
			this.InitTweenAnim(6);
			this.InitTweenAnim(7);
			this.PlayTweenAnim(3);
		}

		// Token: 0x0603D119 RID: 250137 RVA: 0x00EB1537 File Offset: 0x00EAF737
		public void SetParent(UUIItem parentUiItem)
		{
			if (this.ParentUiItem == parentUiItem)
			{
				return;
			}
			this.ParentUiItem = parentUiItem;
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIParent(this.ParentUiItem, false);
		}

		// Token: 0x0603D11A RID: 250138 RVA: 0x00EB1564 File Offset: 0x00EAF764
		public void SetEnergyType(int energyType)
		{
			if (energyType == this.EnergyType)
			{
				return;
			}
			int energyType2 = this.EnergyType;
			this.EnergyType = energyType;
			for (int i = 0; i < this.ItemList.Count; i++)
			{
				this.ItemList[i].SetUIActive(energyType == i + 1);
			}
			this.RefreshState();
			if (energyType2 == 0 && this.EnergyType != 0)
			{
				this.PlayTweenAnim(6);
				return;
			}
			if (energyType2 != 0 && this.EnergyType == 0 && !this.PerformState)
			{
				this.PlayTweenAnim(7);
			}
		}

		// Token: 0x0603D11B RID: 250139 RVA: 0x00EB15E9 File Offset: 0x00EAF7E9
		public void SetLockState(bool state)
		{
			if (this.LockState == state)
			{
				return;
			}
			this.LockState = state;
			this.RefreshState();
		}

		// Token: 0x0603D11C RID: 250140 RVA: 0x00EB1602 File Offset: 0x00EAF802
		public void SetPerformState(bool state)
		{
			if (this.PerformState == state)
			{
				return;
			}
			this.PerformState = state;
			this.RefreshState();
		}

		// Token: 0x0603D11D RID: 250141 RVA: 0x00EB161C File Offset: 0x00EAF81C
		private void RefreshState()
		{
			int num = 0;
			if (this.PerformState)
			{
				num = 1;
			}
			else if (this.LockState && this.EnergyType > 0)
			{
				num = 2;
			}
			if (this.State == num)
			{
				return;
			}
			if (this.State == 0)
			{
				this.StopTweenAnim(3);
			}
			else if (this.State == 1)
			{
				this.StopTweenAnim(5);
			}
			else if (this.State == 2)
			{
				this.StopTweenAnim(4);
			}
			this.State = num;
			if (this.State == 0)
			{
				this.PlayTweenAnim(3);
				return;
			}
			if (this.State == 1)
			{
				this.PlayTweenAnim(5);
				return;
			}
			if (this.State == 2)
			{
				this.PlayTweenAnim(4);
			}
		}

		// Token: 0x0603D11E RID: 250142 RVA: 0x00EB16BF File Offset: 0x00EAF8BF
		protected void InitTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603D11F RID: 250143 RVA: 0x00EB16D5 File Offset: 0x00EAF8D5
		protected void PlayTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603D120 RID: 250144 RVA: 0x00EB16E3 File Offset: 0x00EAF8E3
		protected void StopTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603D121 RID: 250145 RVA: 0x00EB16F1 File Offset: 0x00EAF8F1
		protected void ClearAllTweenAnim()
		{
			this.TweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401FD1D RID: 130333
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401FD1E RID: 130334
		private readonly List<UUIItem> ItemList = new List<UUIItem>();

		// Token: 0x0401FD1F RID: 130335
		private int EnergyType = -1;

		// Token: 0x0401FD20 RID: 130336
		private bool LockState;

		// Token: 0x0401FD21 RID: 130337
		private bool PerformState;

		// Token: 0x0401FD22 RID: 130338
		private int State;

		// Token: 0x0200C0F9 RID: 49401
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A3F1 RID: 238577
			Item1,
			// Token: 0x0403A3F2 RID: 238578
			Item2,
			// Token: 0x0403A3F3 RID: 238579
			Item3,
			// Token: 0x0403A3F4 RID: 238580
			AniDefault,
			// Token: 0x0403A3F5 RID: 238581
			AniLock,
			// Token: 0x0403A3F6 RID: 238582
			AniPerform,
			// Token: 0x0403A3F7 RID: 238583
			AniCast,
			// Token: 0x0403A3F8 RID: 238584
			AniExhaust
		}
	}
}
