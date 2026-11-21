using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004881 RID: 18561
	public class InstanceDungeonScoreListItem : UiPanelBase
	{
		// Token: 0x0602EAE5 RID: 191205 RVA: 0x00D077AC File Offset: 0x00D059AC
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

		// Token: 0x0602EAE6 RID: 191206 RVA: 0x00D07900 File Offset: 0x00D05B00
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

		// Token: 0x0200A52A RID: 42282
		private enum EComponent
		{
			// Token: 0x0403322B RID: 209451
			FullRootItem,
			// Token: 0x0403322C RID: 209452
			TitleText1,
			// Token: 0x0403322D RID: 209453
			ScoreText1,
			// Token: 0x0403322E RID: 209454
			TitleText2,
			// Token: 0x0403322F RID: 209455
			ScoreText2,
			// Token: 0x04033230 RID: 209456
			TitleText3,
			// Token: 0x04033231 RID: 209457
			ScoreText3,
			// Token: 0x04033232 RID: 209458
			EmptyRootItem,
			// Token: 0x04033233 RID: 209459
			MedalTexture
		}
	}
}
