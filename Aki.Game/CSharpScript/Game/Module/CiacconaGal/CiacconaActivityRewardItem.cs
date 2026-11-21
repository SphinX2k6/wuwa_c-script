using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BD5 RID: 19413
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaActivityRewardItem : GridProxyAbstract<CiacconaGalRewardData>
	{
		// Token: 0x06030732 RID: 198450 RVA: 0x00D80774 File Offset: 0x00D7E974
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030733 RID: 198451 RVA: 0x00D80884 File Offset: 0x00D7EA84
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaActivityRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivityRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030734 RID: 198452 RVA: 0x00D808C7 File Offset: 0x00D7EAC7
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreateItem), null, false, null);
		}

		// Token: 0x06030735 RID: 198453 RVA: 0x00D808EC File Offset: 0x00D7EAEC
		[NullableContext(1)]
		public override void Refresh(CiacconaGalRewardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.Desc, Array.Empty<object>());
			this.BtnB.SetActive(data.CanReceive && !data.IsReceived);
			this.BtnB.SetRedDotVisible(data.CanReceive && !data.IsReceived);
			this.BtnE.SetActive(false);
			base.GetText(2).SetUIActive(!data.CanReceive);
			base.GetItem(3).SetUIActive(data.IsReceived);
			this.ScrollView.RefreshByData(data.RewardItemDataList, null, false);
		}

		// Token: 0x06030736 RID: 198454 RVA: 0x00D809BC File Offset: 0x00D7EBBC
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06030737 RID: 198455 RVA: 0x00D809C4 File Offset: 0x00D7EBC4
		private void OnReceive(int _)
		{
			int id = CiacconaGalModel.Instance.ActivityData.Id;
			CiacconaGalController.Instance.RequestGetActivityProgressReward(id, this.Data.Id);
		}

		// Token: 0x04019A95 RID: 105109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ScrollView;

		// Token: 0x04019A96 RID: 105110
		private ButtonItem BtnE;

		// Token: 0x04019A97 RID: 105111
		private ButtonItem BtnB;

		// Token: 0x04019A98 RID: 105112
		private CiacconaGalRewardData Data;

		// Token: 0x0200A7E6 RID: 42982
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033DC0 RID: 212416
			public const int BtnE = 0;

			// Token: 0x04033DC1 RID: 212417
			public const int BtnB = 1;

			// Token: 0x04033DC2 RID: 212418
			public const int TextUnfinished = 2;

			// Token: 0x04033DC3 RID: 212419
			public const int ItemFinished = 3;

			// Token: 0x04033DC4 RID: 212420
			public const int TextTitle = 4;

			// Token: 0x04033DC5 RID: 212421
			public const int TextDesc = 5;

			// Token: 0x04033DC6 RID: 212422
			public const int ScrollView = 6;
		}
	}
}
