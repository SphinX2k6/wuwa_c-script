using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A6F RID: 14959
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseRewardItem : GridProxyAbstract<TrapDefenseRewardItemData>
	{
		// Token: 0x06026710 RID: 157456 RVA: 0x00AC42B0 File Offset: 0x00AC24B0
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

		// Token: 0x06026711 RID: 157457 RVA: 0x00AC443E File Offset: 0x00AC263E
		protected override void OnStart()
		{
			this.ItemListScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), () => new CommonItemSmallItemGrid(), null, false, null);
		}

		// Token: 0x06026712 RID: 157458 RVA: 0x00AC4474 File Offset: 0x00AC2674
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

		// Token: 0x06026713 RID: 157459 RVA: 0x00AC45A5 File Offset: 0x00AC27A5
		private void OnClaimClick()
		{
			Action<TrapDefenseRewardItemData> onClaimRewardCallback = this.OnClaimRewardCallback;
			if (onClaimRewardCallback == null)
			{
				return;
			}
			onClaimRewardCallback(this.Data);
		}

		// Token: 0x0401514C RID: 86348
		private TrapDefenseRewardItemData Data;

		// Token: 0x0401514D RID: 86349
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemListScrollView;

		// Token: 0x0401514E RID: 86350
		public Action<TrapDefenseRewardItemData> OnClaimRewardCallback;

		// Token: 0x02009657 RID: 38487
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EEEB RID: 192235
			public const int BtnWhite = 0;

			// Token: 0x0402EEEC RID: 192236
			public const int TextState = 1;

			// Token: 0x0402EEED RID: 192237
			public const int SpriteFinished = 2;

			// Token: 0x0402EEEE RID: 192238
			public const int ItemFinished = 3;

			// Token: 0x0402EEEF RID: 192239
			public const int TextDesc = 4;

			// Token: 0x0402EEF0 RID: 192240
			public const int ScrollView = 5;

			// Token: 0x0402EEF1 RID: 192241
			public const int ItemRedDot = 6;

			// Token: 0x0402EEF2 RID: 192242
			public const int BtnBlack = 7;

			// Token: 0x0402EEF3 RID: 192243
			public const int TextProgress = 8;
		}
	}
}
