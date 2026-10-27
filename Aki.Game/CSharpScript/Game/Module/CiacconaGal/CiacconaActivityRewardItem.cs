using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BF5 RID: 23541
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaActivityRewardItem : GridProxyAbstract<CiacconaGalRewardData>
	{
		// Token: 0x0603B7E7 RID: 243687 RVA: 0x00E30464 File Offset: 0x00E2E664
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

		// Token: 0x0603B7E8 RID: 243688 RVA: 0x00E30574 File Offset: 0x00E2E774
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaActivityRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivityRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7E9 RID: 243689 RVA: 0x00E305B7 File Offset: 0x00E2E7B7
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreateItem), null, false, null);
		}

		// Token: 0x0603B7EA RID: 243690 RVA: 0x00E305DC File Offset: 0x00E2E7DC
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
			this.ScrollView.RefreshByData(data.RewardItemDataList.ToList<TItem>(), null, false);
		}

		// Token: 0x0603B7EB RID: 243691 RVA: 0x00E306B1 File Offset: 0x00E2E8B1
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603B7EC RID: 243692 RVA: 0x00E306B8 File Offset: 0x00E2E8B8
		private void OnReceive(int _)
		{
			int id = CiacconaGalModel.Instance.ActivityData.Id;
			CiacconaGalController.Instance.RequestGetActivityProgressReward(id, this.Data.Id);
		}

		// Token: 0x0401EFE4 RID: 126948
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ScrollView;

		// Token: 0x0401EFE5 RID: 126949
		private ButtonItem BtnE;

		// Token: 0x0401EFE6 RID: 126950
		private ButtonItem BtnB;

		// Token: 0x0401EFE7 RID: 126951
		private CiacconaGalRewardData Data;

		// Token: 0x0200BDDE RID: 48606
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393FD RID: 234493
			public const int BtnE = 0;

			// Token: 0x040393FE RID: 234494
			public const int BtnB = 1;

			// Token: 0x040393FF RID: 234495
			public const int TextUnfinished = 2;

			// Token: 0x04039400 RID: 234496
			public const int ItemFinished = 3;

			// Token: 0x04039401 RID: 234497
			public const int TextTitle = 4;

			// Token: 0x04039402 RID: 234498
			public const int TextDesc = 5;

			// Token: 0x04039403 RID: 234499
			public const int ScrollView = 6;
		}
	}
}
