using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x02006649 RID: 26185
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FeiXuePreheatTaskItem : GridProxyAbstract<FeiXuePreheatTaskData>
	{
		// Token: 0x060419E2 RID: 268770 RVA: 0x00FEA568 File Offset: 0x00FE8768
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, this.OnRewardBtnClick)
			};
		}

		// Token: 0x060419E3 RID: 268771 RVA: 0x00FEA64D File Offset: 0x00FE884D
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x060419E4 RID: 268772 RVA: 0x00FEA670 File Offset: 0x00FE8870
		public override void Refresh(FeiXuePreheatTaskData data, bool isSelected, int gridIndex)
		{
			this.TaskData = data;
			this.RewardScroll.RefreshByData(data.RewardList, delegate
			{
				this.RewardScroll.ScrollToLeft(0);
			}, false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(data.IsUnclaimed);
			base.GetItem(5).SetUIActive(data.IsUnclaimed);
			base.GetSprite(1).SetUIActive(data.IsFinished);
			base.GetText(0).SetUIActive(data.IsLock || data.IsDoing);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.QuestDesc, Array.Empty<object>());
			base.GetText(7).SetUIActive(data.Target != 0);
			UUIText text = base.GetText(7);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetItem(2).SetUIActive(data.IsFinished);
		}

		// Token: 0x060419E5 RID: 268773 RVA: 0x00FEA788 File Offset: 0x00FE8988
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem data) => this.TaskData.IsFinished)
			};
		}

		// Token: 0x04022272 RID: 139890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04022273 RID: 139891
		[Nullable(2)]
		private FeiXuePreheatTaskData TaskData;

		// Token: 0x04022274 RID: 139892
		public Action OnRewardBtnClick = delegate()
		{
		};
	}
}
