using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004399 RID: 17305
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleScoreProgressActivityPanel : UiPanelBase
	{
		// Token: 0x0602BB65 RID: 179045 RVA: 0x00C44CD4 File Offset: 0x00C42ED4
		public UniTask Init(UUIItem item)
		{
			MoraleScoreProgressActivityPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleScoreProgressActivityPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB66 RID: 179046 RVA: 0x00C44D20 File Offset: 0x00C42F20
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x0602BB67 RID: 179047 RVA: 0x00C44DBC File Offset: 0x00C42FBC
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleScoreProgressActivityPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleScoreProgressActivityPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB68 RID: 179048 RVA: 0x00C44E00 File Offset: 0x00C43000
		public void UpdateData()
		{
			MoraleModel instance = MoraleModel.Instance;
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout = this.PercentLayout;
			if (percentLayout != null)
			{
				percentLayout.RefreshByData(instance.ProgressRewardList, new Action(this.UpdatePercentHandle), false);
			}
			List<MoraleAreaProgressData> list = new List<MoraleAreaProgressData>(instance.ProgressRewardList.Count);
			foreach (MoraleProgressRewardData moraleProgressRewardData in instance.ProgressRewardList)
			{
				MoraleAreaProgressData item = new MoraleAreaProgressData
				{
					TargetScore = moraleProgressRewardData.TargetScore,
					LastTargetScore = moraleProgressRewardData.LastTargetScore,
					StartScore = moraleProgressRewardData.StartScore
				};
				list.Add(item);
			}
			GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> pointLayout = this.PointLayout;
			if (pointLayout != null)
			{
				pointLayout.RefreshByData(list, null, false);
			}
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout2 = this.PercentLayout;
			if (percentLayout2 != null)
			{
				percentLayout2.BindLateUpdate(delegate(float _)
				{
					TimerSystem.Instance.Next(new TTimerAction(this.TimerUpdatePercentHandle), null, null);
					GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout3 = this.PercentLayout;
					if (percentLayout3 == null)
					{
						return;
					}
					percentLayout3.UnBindLateUpdate();
				});
			}
			int currentProgressScore = instance.GetCurrentProgressScore();
			int progressTotalScore = instance.GetProgressTotalScore();
			UUIText text = base.GetText(0);
			string textStringId = "Morale_title_17";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				currentProgressScore,
				progressTotalScore
			}));
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("Morale_title_1");
		}

		// Token: 0x0602BB69 RID: 179049 RVA: 0x00C44F50 File Offset: 0x00C43150
		protected void TimerUpdatePercentHandle(float _)
		{
			this.UpdatePercentHandle();
		}

		// Token: 0x0602BB6A RID: 179050 RVA: 0x00C44F58 File Offset: 0x00C43158
		protected void UpdatePercentHandle()
		{
			GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> percentLayout = this.PercentLayout;
			List<MoraleScoreProgressPercentItem> list = (percentLayout != null) ? percentLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].UpdatePercentHandle();
			}
		}

		// Token: 0x0602BB6B RID: 179051 RVA: 0x00C44F99 File Offset: 0x00C43199
		private MoraleScoreProgressPercentItem CreatePercentItem()
		{
			return new MoraleScoreProgressPercentItem();
		}

		// Token: 0x0602BB6C RID: 179052 RVA: 0x00C44FA0 File Offset: 0x00C431A0
		private MoraleAreaProgressPointItem CreatePointItem()
		{
			return new MoraleAreaProgressPointItem();
		}

		// Token: 0x0401790A RID: 96522
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleScoreProgressPercentItem, MoraleProgressRewardData> PercentLayout;

		// Token: 0x0401790B RID: 96523
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<MoraleAreaProgressPointItem, MoraleAreaProgressData> PointLayout;

		// Token: 0x0200A08A RID: 41098
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031E17 RID: 204311
			public const int TxtSumScoreProgress = 0;

			// Token: 0x04031E18 RID: 204312
			public const int TxtSumProgressTitle = 1;

			// Token: 0x04031E19 RID: 204313
			public const int LayoutPercent = 2;

			// Token: 0x04031E1A RID: 204314
			public const int ItemPercent = 3;

			// Token: 0x04031E1B RID: 204315
			public const int LayoutProgressPoint = 4;

			// Token: 0x04031E1C RID: 204316
			public const int ItemProgressPointTemplate = 5;
		}
	}
}
