using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC7 RID: 19143
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseRewardItem : GridProxyAbstract<TrapDefenseRewardItemData>
	{
		// Token: 0x06031980 RID: 203136 RVA: 0x00B802FC File Offset: 0x00B7E4FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClaimClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031981 RID: 203137 RVA: 0x00B8048A File Offset: 0x00B7E68A
		protected override void OnStart()
		{
			this.ItemListScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), () => new CommonItemSmallItemGrid(), null, false, null);
		}

		// Token: 0x06031982 RID: 203138 RVA: 0x00B804C0 File Offset: 0x00B7E6C0
		public override void Refresh(TrapDefenseRewardItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (this.Data == null)
			{
				return;
			}
			base.GetButton(0).GetRootComponent().SetUIActive(false);
			base.GetButton(7).GetRootComponent().SetUIActive(data.State == ETrapDefenseRewardState.CanClaim);
			base.GetText(1).SetUIActive(data.State != ETrapDefenseRewardState.CanClaim && data.State != ETrapDefenseRewardState.Claimed);
			if (data.State == ETrapDefenseRewardState.Lock)
			{
				base.GetText(1).SetText(data.GetUnlockRemainTimeStr(), true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.Desc, Array.Empty<object>());
			base.GetItem(6).SetUIActive(false);
			base.GetItem(3).SetUIActive(data.State == ETrapDefenseRewardState.Claimed);
			base.GetSprite(2).SetUIActive(data.State == ETrapDefenseRewardState.Claimed);
			UUIText text = base.GetText(8);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.CurProgress);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.ItemListScrollView.RefreshByData(data.ItemList, null, false);
		}

		// Token: 0x06031983 RID: 203139 RVA: 0x00B805F1 File Offset: 0x00B7E7F1
		private void OnClaimClick()
		{
			Action<TrapDefenseRewardItemData> onClaimRewardCallback = this.OnClaimRewardCallback;
			if (onClaimRewardCallback == null)
			{
				return;
			}
			onClaimRewardCallback(this.Data);
		}

		// Token: 0x0401A7FA RID: 108538
		private TrapDefenseRewardItemData Data;

		// Token: 0x0401A7FB RID: 108539
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemListScrollView;

		// Token: 0x0401A7FC RID: 108540
		public Action<TrapDefenseRewardItemData> OnClaimRewardCallback;

		// Token: 0x0200AC37 RID: 44087
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403453A RID: 214330
			public const int BtnWhite = 0;

			// Token: 0x0403453B RID: 214331
			public const int TextState = 1;

			// Token: 0x0403453C RID: 214332
			public const int SpriteFinished = 2;

			// Token: 0x0403453D RID: 214333
			public const int ItemFinished = 3;

			// Token: 0x0403453E RID: 214334
			public const int TextDesc = 4;

			// Token: 0x0403453F RID: 214335
			public const int ScrollView = 5;

			// Token: 0x04034540 RID: 214336
			public const int ItemRedDot = 6;

			// Token: 0x04034541 RID: 214337
			public const int BtnBlack = 7;

			// Token: 0x04034542 RID: 214338
			public const int TextProgress = 8;
		}
	}
}
