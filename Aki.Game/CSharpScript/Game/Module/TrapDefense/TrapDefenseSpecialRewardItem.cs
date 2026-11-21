using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A73 RID: 14963
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseSpecialRewardItem : UiPanelBase
	{
		// Token: 0x06026732 RID: 157490 RVA: 0x00AC4CE4 File Offset: 0x00AC2EE4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClaimClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026733 RID: 157491 RVA: 0x00AC4E98 File Offset: 0x00AC3098
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseSpecialRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseSpecialRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026734 RID: 157492 RVA: 0x00AC4EDC File Offset: 0x00AC30DC
		public void Refresh(TrapDefenseSpecialRewardData data)
		{
			this.Data = data;
			if (this.Data == null)
			{
				return;
			}
			base.GetButton(6).GetRootComponent().SetUIActive(false);
			base.GetButton(9).GetRootComponent().SetUIActive(data.State == ETrapDefenseRewardState.CanClaim);
			base.GetText(1).SetUIActive(data.State != ETrapDefenseRewardState.CanClaim && data.State != ETrapDefenseRewardState.Claimed);
			base.GetItem(8).SetUIActive(data.State == ETrapDefenseRewardState.Claimed);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Desc, Array.Empty<object>());
			TItem titem = data.ItemList[0];
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(titem.ItemData.ItemId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ((itemConfigData != null) ? itemConfigData.Name : null) ?? "", Array.Empty<object>());
			this.ItemGrid.Refresh(data.ItemList[0]);
			UUIText text = base.GetText(4);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.CurrentProgress);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.TotalProgress);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetSprite(5).SetFillAmount((float)(data.CurrentProgress / ((data.TotalProgress > 0) ? data.TotalProgress : 1)));
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x06026735 RID: 157493 RVA: 0x00AC5056 File Offset: 0x00AC3256
		private void OnClaimClick()
		{
			TrapDefenseController.Instance.RequestTrapDefenseSpecialRewardClaim(this.Data.Id);
		}

		// Token: 0x04015156 RID: 86358
		private TrapDefenseSpecialRewardData Data;

		// Token: 0x04015157 RID: 86359
		private CommonItemSmallItemGrid ItemGrid;

		// Token: 0x0200965D RID: 38493
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF09 RID: 192265
			public const int ItemGrid = 0;

			// Token: 0x0402EF0A RID: 192266
			public const int TextState = 1;

			// Token: 0x0402EF0B RID: 192267
			public const int TextName = 2;

			// Token: 0x0402EF0C RID: 192268
			public const int TextDesc = 3;

			// Token: 0x0402EF0D RID: 192269
			public const int TextProgress = 4;

			// Token: 0x0402EF0E RID: 192270
			public const int SpriteProgress = 5;

			// Token: 0x0402EF0F RID: 192271
			public const int BtnWhite = 6;

			// Token: 0x0402EF10 RID: 192272
			public const int ItemRedDot = 7;

			// Token: 0x0402EF11 RID: 192273
			public const int ItemFinished = 8;

			// Token: 0x0402EF12 RID: 192274
			public const int BtnBlack = 9;
		}
	}
}
