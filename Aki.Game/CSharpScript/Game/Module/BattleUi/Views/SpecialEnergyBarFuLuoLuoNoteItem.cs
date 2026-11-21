using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DBD RID: 19901
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarFuLuoLuoNoteItem : UiPanelBase
	{
		// Token: 0x0603208E RID: 204942 RVA: 0x00E02288 File Offset: 0x00E00488
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

		// Token: 0x0603208F RID: 204943 RVA: 0x00E023B8 File Offset: 0x00E005B8
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

		// Token: 0x06032090 RID: 204944 RVA: 0x00E0242B File Offset: 0x00E0062B
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

		// Token: 0x06032091 RID: 204945 RVA: 0x00E02458 File Offset: 0x00E00658
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

		// Token: 0x06032092 RID: 204946 RVA: 0x00E024DD File Offset: 0x00E006DD
		public void SetLockState(bool state)
		{
			if (this.LockState == state)
			{
				return;
			}
			this.LockState = state;
			this.RefreshState();
		}

		// Token: 0x06032093 RID: 204947 RVA: 0x00E024F6 File Offset: 0x00E006F6
		public void SetPerformState(bool state)
		{
			if (this.PerformState == state)
			{
				return;
			}
			this.PerformState = state;
			this.RefreshState();
		}

		// Token: 0x06032094 RID: 204948 RVA: 0x00E02510 File Offset: 0x00E00710
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

		// Token: 0x06032095 RID: 204949 RVA: 0x00E025B3 File Offset: 0x00E007B3
		protected void InitTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x06032096 RID: 204950 RVA: 0x00E025C9 File Offset: 0x00E007C9
		protected void PlayTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x06032097 RID: 204951 RVA: 0x00E025D7 File Offset: 0x00E007D7
		protected void StopTweenAnim(int componentType)
		{
			this.TweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x06032098 RID: 204952 RVA: 0x00E025E5 File Offset: 0x00E007E5
		protected void ClearAllTweenAnim()
		{
			this.TweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401A7DA RID: 108506
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A7DB RID: 108507
		private readonly List<UUIItem> ItemList = new List<UUIItem>();

		// Token: 0x0401A7DC RID: 108508
		private int EnergyType = -1;

		// Token: 0x0401A7DD RID: 108509
		private bool LockState;

		// Token: 0x0401A7DE RID: 108510
		private bool PerformState;

		// Token: 0x0401A7DF RID: 108511
		private int State;

		// Token: 0x0200AB02 RID: 43778
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034DC3 RID: 216515
			Item1,
			// Token: 0x04034DC4 RID: 216516
			Item2,
			// Token: 0x04034DC5 RID: 216517
			Item3,
			// Token: 0x04034DC6 RID: 216518
			AniDefault,
			// Token: 0x04034DC7 RID: 216519
			AniLock,
			// Token: 0x04034DC8 RID: 216520
			AniPerform,
			// Token: 0x04034DC9 RID: 216521
			AniCast,
			// Token: 0x04034DCA RID: 216522
			AniExhaust
		}
	}
}
