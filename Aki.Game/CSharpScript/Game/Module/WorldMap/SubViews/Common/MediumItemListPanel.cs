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
	// Token: 0x02004831 RID: 18481
	[NullableContext(1)]
	[Nullable(0)]
	public class MediumItemListPanel : UiPanelBase
	{
		// Token: 0x060305F5 RID: 198133 RVA: 0x00B3AF18 File Offset: 0x00B39118
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

		// Token: 0x060305F6 RID: 198134 RVA: 0x00B3AFA2 File Offset: 0x00B391A2
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

		// Token: 0x060305F7 RID: 198135 RVA: 0x00B3AFDC File Offset: 0x00B391DC
		private MediumItemListItem CreateGridItem()
		{
			return new MediumItemListItem
			{
				GetBottomTextCallback = this.GetBottomTextCallback
			};
		}

		// Token: 0x060305F8 RID: 198136 RVA: 0x00B3AFF0 File Offset: 0x00B391F0
		public void Refresh(List<TItem> data)
		{
			GenericLayout<MediumItemListItem, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByDataAsync(data, false, null).Forget();
		}

		// Token: 0x060305F9 RID: 198137 RVA: 0x00B3B01D File Offset: 0x00B3921D
		public void SetTitleNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x0401A037 RID: 106551
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MediumItemListItem, TItem> RewardLayout;

		// Token: 0x0401A038 RID: 106552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<int, string> GetBottomTextCallback;

		// Token: 0x0200AB0D RID: 43789
		[NullableContext(0)]
		public static class ERewardItemBarChildCom
		{
			// Token: 0x04033FCB RID: 212939
			public const int UiTextInstanceTitle = 0;

			// Token: 0x04033FCC RID: 212940
			public const int UiItemContainer = 1;

			// Token: 0x04033FCD RID: 212941
			public const int UiItemItem = 2;
		}
	}
}
