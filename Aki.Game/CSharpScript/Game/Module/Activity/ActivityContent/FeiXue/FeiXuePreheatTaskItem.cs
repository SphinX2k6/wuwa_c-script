using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055C7 RID: 21959
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FeiXuePreheatTaskItem : GridProxyAbstract<FeiXuePreheatTaskData>
	{
		// Token: 0x060366A7 RID: 222887 RVA: 0x00F31620 File Offset: 0x00F2F820
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

		// Token: 0x060366A8 RID: 222888 RVA: 0x00F31705 File Offset: 0x00F2F905
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x060366A9 RID: 222889 RVA: 0x00F31728 File Offset: 0x00F2F928
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

		// Token: 0x060366AA RID: 222890 RVA: 0x00F31840 File Offset: 0x00F2FA40
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem data) => this.TaskData.IsFinished)
			};
		}

		// Token: 0x0401CBA3 RID: 117667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401CBA4 RID: 117668
		[Nullable(2)]
		private FeiXuePreheatTaskData TaskData;

		// Token: 0x0401CBA5 RID: 117669
		public Action OnRewardBtnClick = delegate()
		{
		};
	}
}
