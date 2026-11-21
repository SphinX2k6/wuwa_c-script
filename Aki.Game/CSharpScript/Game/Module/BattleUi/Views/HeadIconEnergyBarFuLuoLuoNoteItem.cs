using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D1A RID: 19738
	internal class HeadIconEnergyBarFuLuoLuoNoteItem : UiPanelBase
	{
		// Token: 0x060317C6 RID: 202694 RVA: 0x00DD5DF4 File Offset: 0x00DD3FF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060317C7 RID: 202695 RVA: 0x00DD5EC0 File Offset: 0x00DD40C0
		protected override void OnStart()
		{
			base.OnStart();
			this.ItemList.Add(base.GetItem(0));
			this.ItemList.Add(base.GetItem(1));
			this.ItemList.Add(base.GetItem(2));
			foreach (UUIItem uuiitem in this.ItemList)
			{
				uuiitem.SetUIActive(false);
			}
			this.InitTweenAnim(3);
			this.InitTweenAnim(4);
		}

		// Token: 0x060317C8 RID: 202696 RVA: 0x00DD5F5C File Offset: 0x00DD415C
		public void SetEnergyType(int energyType)
		{
			if (energyType == this.EnergyType)
			{
				return;
			}
			int energyType2 = this.EnergyType;
			this.EnergyType = energyType;
			bool flag = (energyType2 == -1 || energyType2 == 0) && energyType != 0;
			bool flag2 = energyType2 != -1 && energyType2 != 0 && energyType == 0;
			for (int i = 0; i < this.ItemList.Count; i++)
			{
				UUIItem uuiitem = this.ItemList[i];
				if (flag2 && energyType2 == i + 1)
				{
					uuiitem.SetUIActive(true);
				}
				else
				{
					uuiitem.SetUIActive(energyType == i + 1);
				}
			}
			if (flag)
			{
				if (this.IsExhausted)
				{
					this.PlayTweenAnim(3);
				}
				this.IsExhausted = false;
				return;
			}
			if (flag2)
			{
				this.PlayTweenAnim(4);
				this.IsExhausted = true;
			}
		}

		// Token: 0x060317C9 RID: 202697 RVA: 0x00DD600E File Offset: 0x00DD420E
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x060317CA RID: 202698 RVA: 0x00DD6037 File Offset: 0x00DD4237
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x060317CB RID: 202699 RVA: 0x00DD604A File Offset: 0x00DD424A
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x060317CC RID: 202700 RVA: 0x00DD605D File Offset: 0x00DD425D
		protected void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401A342 RID: 107330
		[Nullable(1)]
		private readonly List<UUIItem> ItemList = new List<UUIItem>(3);

		// Token: 0x0401A343 RID: 107331
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401A344 RID: 107332
		private int EnergyType = -1;

		// Token: 0x0401A345 RID: 107333
		private bool IsExhausted;

		// Token: 0x0200A9DA RID: 43482
		private enum ENoteChildType
		{
			// Token: 0x040347B9 RID: 214969
			Item1,
			// Token: 0x040347BA RID: 214970
			Item2,
			// Token: 0x040347BB RID: 214971
			Item3,
			// Token: 0x040347BC RID: 214972
			AniDefault,
			// Token: 0x040347BD RID: 214973
			AniExhaust
		}
	}
}
