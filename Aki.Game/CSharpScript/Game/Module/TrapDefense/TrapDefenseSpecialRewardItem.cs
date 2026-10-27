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
	// Token: 0x02004ACB RID: 19147
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseSpecialRewardItem : UiPanelBase
	{
		// Token: 0x060319A2 RID: 203170 RVA: 0x00B80D30 File Offset: 0x00B7EF30
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

		// Token: 0x060319A3 RID: 203171 RVA: 0x00B80EE4 File Offset: 0x00B7F0E4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseSpecialRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseSpecialRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319A4 RID: 203172 RVA: 0x00B80F28 File Offset: 0x00B7F128
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

		// Token: 0x060319A5 RID: 203173 RVA: 0x00B810A2 File Offset: 0x00B7F2A2
		private void OnClaimClick()
		{
			TrapDefenseController.Instance.RequestTrapDefenseSpecialRewardClaim(this.Data.Id);
		}

		// Token: 0x0401A804 RID: 108548
		private TrapDefenseSpecialRewardData Data;

		// Token: 0x0401A805 RID: 108549
		private CommonItemSmallItemGrid ItemGrid;

		// Token: 0x0200AC3D RID: 44093
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034558 RID: 214360
			public const int ItemGrid = 0;

			// Token: 0x04034559 RID: 214361
			public const int TextState = 1;

			// Token: 0x0403455A RID: 214362
			public const int TextName = 2;

			// Token: 0x0403455B RID: 214363
			public const int TextDesc = 3;

			// Token: 0x0403455C RID: 214364
			public const int TextProgress = 4;

			// Token: 0x0403455D RID: 214365
			public const int SpriteProgress = 5;

			// Token: 0x0403455E RID: 214366
			public const int BtnWhite = 6;

			// Token: 0x0403455F RID: 214367
			public const int ItemRedDot = 7;

			// Token: 0x04034560 RID: 214368
			public const int ItemFinished = 8;

			// Token: 0x04034561 RID: 214369
			public const int BtnBlack = 9;
		}
	}
}
