using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A9 RID: 22697
	public class InstanceDungeonScoreListItem : UiPanelBase
	{
		// Token: 0x06039BC2 RID: 236482 RVA: 0x00DB8894 File Offset: 0x00DB6A94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039BC3 RID: 236483 RVA: 0x00DB89E8 File Offset: 0x00DB6BE8
		[NullableContext(2)]
		public void RefreshItem(InstanceDungeonScoreListItemData data)
		{
			bool flag = data == null || string.IsNullOrEmpty(data.MedalPathId);
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			if (!flag)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.TitleTextId1, Array.Empty<object>());
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), data.TitleTextId2, Array.Empty<object>());
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), data.TitleTextId3, Array.Empty<object>());
				UUIText text2 = base.GetText(2);
				if (text2 != null)
				{
					text2.SetText(data.ScoreText1, true);
				}
				UUIText text3 = base.GetText(4);
				if (text3 != null)
				{
					text3.SetText(data.ScoreText2, true);
				}
				UUIText text4 = base.GetText(6);
				if (text4 != null)
				{
					text4.SetText(data.ScoreText3, true);
				}
				base.TrySetTextureByPath(data.MedalPathId, base.GetTexture(8), null, null);
			}
		}

		// Token: 0x0200BB11 RID: 47889
		private enum EComponent
		{
			// Token: 0x0403882A RID: 231466
			FullRootItem,
			// Token: 0x0403882B RID: 231467
			TitleText1,
			// Token: 0x0403882C RID: 231468
			ScoreText1,
			// Token: 0x0403882D RID: 231469
			TitleText2,
			// Token: 0x0403882E RID: 231470
			ScoreText2,
			// Token: 0x0403882F RID: 231471
			TitleText3,
			// Token: 0x04038830 RID: 231472
			ScoreText3,
			// Token: 0x04038831 RID: 231473
			EmptyRootItem,
			// Token: 0x04038832 RID: 231474
			MedalTexture
		}
	}
}
