using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D38 RID: 23864
	internal class HeadIconEnergyBarFuLuoLuoNoteItem : UiPanelBase
	{
		// Token: 0x0603C86D RID: 247917 RVA: 0x00E85654 File Offset: 0x00E83854
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

		// Token: 0x0603C86E RID: 247918 RVA: 0x00E85720 File Offset: 0x00E83920
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

		// Token: 0x0603C86F RID: 247919 RVA: 0x00E857BC File Offset: 0x00E839BC
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

		// Token: 0x0603C870 RID: 247920 RVA: 0x00E8586E File Offset: 0x00E83A6E
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603C871 RID: 247921 RVA: 0x00E85897 File Offset: 0x00E83A97
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603C872 RID: 247922 RVA: 0x00E858AA File Offset: 0x00E83AAA
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603C873 RID: 247923 RVA: 0x00E858BD File Offset: 0x00E83ABD
		protected void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0401F889 RID: 129161
		[Nullable(1)]
		private readonly List<UUIItem> ItemList = new List<UUIItem>(3);

		// Token: 0x0401F88A RID: 129162
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401F88B RID: 129163
		private int EnergyType = -1;

		// Token: 0x0401F88C RID: 129164
		private bool IsExhausted;

		// Token: 0x0200BFD4 RID: 49108
		private enum ENoteChildType
		{
			// Token: 0x04039DF7 RID: 237047
			Item1,
			// Token: 0x04039DF8 RID: 237048
			Item2,
			// Token: 0x04039DF9 RID: 237049
			Item3,
			// Token: 0x04039DFA RID: 237050
			AniDefault,
			// Token: 0x04039DFB RID: 237051
			AniExhaust
		}
	}
}
