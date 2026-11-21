using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02003762 RID: 14178
	[NullableContext(1)]
	[Nullable(0)]
	public class MediumItemListPanel : UiPanelBase
	{
		// Token: 0x06024DC5 RID: 150981 RVA: 0x00A6AFE4 File Offset: 0x00A691E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024DC6 RID: 150982 RVA: 0x00A6B06E File Offset: 0x00A6926E
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<MediumItemListItem, TItem>(base.GetGridLayout(1), new Func<MediumItemListItem>(this.CreateGridItem), null, false, true);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText("", true);
		}

		// Token: 0x06024DC7 RID: 150983 RVA: 0x00A6B0A8 File Offset: 0x00A692A8
		private MediumItemListItem CreateGridItem()
		{
			return new MediumItemListItem
			{
				GetBottomTextCallback = this.GetBottomTextCallback
			};
		}

		// Token: 0x06024DC8 RID: 150984 RVA: 0x00A6B0BC File Offset: 0x00A692BC
		public void Refresh(List<TItem> data)
		{
			GenericLayout<MediumItemListItem, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByDataAsync(data, false, null).Forget();
		}

		// Token: 0x06024DC9 RID: 150985 RVA: 0x00A6B0E9 File Offset: 0x00A692E9
		public void SetTitleNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x040146EB RID: 83691
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MediumItemListItem, TItem> RewardLayout;

		// Token: 0x040146EC RID: 83692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<int, string> GetBottomTextCallback;

		// Token: 0x020094BC RID: 38076
		[NullableContext(0)]
		public static class ERewardItemBarChildCom
		{
			// Token: 0x0402E74B RID: 190283
			public const int UiTextInstanceTitle = 0;

			// Token: 0x0402E74C RID: 190284
			public const int UiItemContainer = 1;

			// Token: 0x0402E74D RID: 190285
			public const int UiItemItem = 2;
		}
	}
}
