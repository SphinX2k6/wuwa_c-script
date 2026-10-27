using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006240 RID: 25152
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipRatingView : UiViewBase
	{
		// Token: 0x0603F626 RID: 259622 RVA: 0x00F52969 File Offset: 0x00F50B69
		public RhythmShipRatingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F627 RID: 259623 RVA: 0x00F52988 File Offset: 0x00F50B88
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickLeftBtn)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickRightBtn))
			};
		}

		// Token: 0x0603F628 RID: 259624 RVA: 0x00F52AD0 File Offset: 0x00F50CD0
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipRatingView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipRatingView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F629 RID: 259625 RVA: 0x00F52B14 File Offset: 0x00F50D14
		protected override void OnStart()
		{
			IRhythmShipRatingViewData rhythmShipRatingViewData = this.OpenParam as IRhythmShipRatingViewData;
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(rhythmShipRatingViewData.LevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			foreach (RhythmSubLevel rhythmSubLevel in (RhythmShipConfig.Instance.GetRhythmShipSubLevelByLevelId(rhythmShipRatingViewData.LevelId) ?? new List<RhythmSubLevel>()))
			{
				this.SubLevelIdList.Add(rhythmSubLevel.Id);
			}
			this.CurrentShowSubLevelId = this.SubLevelIdList.IndexOf(rhythmShipRatingViewData.SubLevelId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rhythmShipLevelById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rhythmShipLevelById.Value.DesName, Array.Empty<object>());
			this.RefreshView();
		}

		// Token: 0x0603F62A RID: 259626 RVA: 0x00F52C10 File Offset: 0x00F50E10
		private void OnClickLeftBtn()
		{
			if (this.CurrentShowSubLevelId <= 0)
			{
				return;
			}
			this.CurrentShowSubLevelId--;
			this.RefreshView();
		}

		// Token: 0x0603F62B RID: 259627 RVA: 0x00F52C30 File Offset: 0x00F50E30
		private void OnClickRightBtn()
		{
			if (this.CurrentShowSubLevelId >= this.SubLevelIdList.Count - 1)
			{
				return;
			}
			this.CurrentShowSubLevelId++;
			this.RefreshView();
		}

		// Token: 0x0603F62C RID: 259628 RVA: 0x00F52C5C File Offset: 0x00F50E5C
		private void RefreshView()
		{
			int num = this.SubLevelIdList[this.CurrentShowSubLevelId];
			List<IRhythmShipSubLevelRatingData> subLevelRatingInfo;
			if (!this.LevelRatingInfoMap.TryGetValue(num, out subLevelRatingInfo))
			{
				subLevelRatingInfo = RhythmShipModel.Instance.GetSubLevelRatingInfo(num);
				this.LevelRatingInfoMap[num] = subLevelRatingInfo;
			}
			if (subLevelRatingInfo.Count > 0)
			{
				LoopScrollView<RhythmShipRatingItem, IRhythmShipSubLevelRatingData> playerScroll = this.PlayerScroll;
				if (playerScroll != null)
				{
					playerScroll.RefreshByData(subLevelRatingInfo, false, null, false);
				}
				base.GetLoopScrollViewComponent(3).RootUIComp.Get().SetUIActive(true);
				base.GetItem(10).SetUIActive(false);
			}
			else
			{
				base.GetLoopScrollViewComponent(3).RootUIComp.Get().SetUIActive(false);
				base.GetItem(10).SetUIActive(true);
			}
			IRhythmShipSubLevelRatingData subLevelSelfRatingInfo = RhythmShipModel.Instance.GetSubLevelSelfRatingInfo(num);
			if (subLevelSelfRatingInfo == null)
			{
				RhythmShipRatingItem selfItem = this.SelfItem;
				if (selfItem != null)
				{
					selfItem.RefreshItemNone();
				}
			}
			else
			{
				int? id = PlayerInfoModel.Instance.GetId();
				if (subLevelRatingInfo != null && subLevelRatingInfo.Count > 0)
				{
					foreach (IRhythmShipSubLevelRatingData rhythmShipSubLevelRatingData in subLevelRatingInfo)
					{
						int playerId = rhythmShipSubLevelRatingData.PlayerId;
						int? num2 = id;
						if (playerId == num2.GetValueOrDefault() & num2 != null)
						{
							subLevelSelfRatingInfo.RankingNumber = rhythmShipSubLevelRatingData.RankingNumber;
							break;
						}
					}
				}
				RhythmShipRatingItem selfItem2 = this.SelfItem;
				if (selfItem2 != null)
				{
					selfItem2.RefreshItemByData(subLevelSelfRatingInfo);
				}
			}
			RhythmSubLevel? rhythmShipSubLevelById = RhythmShipConfig.Instance.GetRhythmShipSubLevelById(num);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), RhythmShipDefine.rhythmShipDifficultyText[(rhythmShipSubLevelById != null) ? rhythmShipSubLevelById.GetValueOrDefault().Difficulty : 1], Array.Empty<object>());
			this.RefreshBtnActivity();
		}

		// Token: 0x0603F62D RID: 259629 RVA: 0x00F52E20 File Offset: 0x00F51020
		private void RefreshBtnActivity()
		{
			base.GetButton(9).RootUIComp.Get().SetUIActive(false);
			base.GetButton(8).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x040211A1 RID: 135585
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040211A2 RID: 135586
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RhythmShipRatingItem, IRhythmShipSubLevelRatingData> PlayerScroll;

		// Token: 0x040211A3 RID: 135587
		[Nullable(2)]
		private RhythmShipRatingItem SelfItem;

		// Token: 0x040211A4 RID: 135588
		private readonly List<int> SubLevelIdList = new List<int>();

		// Token: 0x040211A5 RID: 135589
		private int CurrentShowSubLevelId;

		// Token: 0x040211A6 RID: 135590
		private readonly Dictionary<int, List<IRhythmShipSubLevelRatingData>> LevelRatingInfoMap = new Dictionary<int, List<IRhythmShipSubLevelRatingData>>();
	}
}
