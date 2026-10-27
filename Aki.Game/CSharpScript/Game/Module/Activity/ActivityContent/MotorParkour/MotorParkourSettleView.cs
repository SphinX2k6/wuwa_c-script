using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063FC RID: 25596
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourSettleView : UiViewBase
	{
		// Token: 0x060405FB RID: 263675 RVA: 0x00F92598 File Offset: 0x00F90798
		public MotorParkourSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060405FC RID: 263676 RVA: 0x00F925A4 File Offset: 0x00F907A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnReChallengeBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnExitBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060405FD RID: 263677 RVA: 0x00F92888 File Offset: 0x00F90A88
		protected override void OnBeforeShow()
		{
			MotorParkourSettleView.IMotorParkourSettleViewData motorParkourSettleViewData = this.OpenParam as MotorParkourSettleView.IMotorParkourSettleViewData;
			MotorParkourLevelData levelData = motorParkourSettleViewData.LevelData;
			bool isNewRecord = motorParkourSettleViewData.IsNewRecord;
			List<MotorParkourRankData> newRankList = levelData.GetNewRankList(motorParkourSettleViewData.MyScoreTime);
			int num = newRankList.FindIndex((MotorParkourRankData rankData) => rankData.IsOwn) + 1;
			base.GetItem(0).SetUIActive(num == 1);
			base.GetItem(1).SetUIActive(num == 2);
			base.GetItem(2).SetUIActive(num == 3);
			base.GetItem(3).SetUIActive(num > 3);
			base.GetItem(6).SetUIActive(num == 1);
			base.GetItem(7).SetUIActive(num == 2);
			base.GetItem(8).SetUIActive(num == 3);
			for (int i = 0; i < 3; i++)
			{
				MotorParkourRankData motorParkourRankData = newRankList[i];
				if (motorParkourRankData.IsOwn)
				{
					string playerName = FunctionModel.Instance.GetPlayerName();
					UUIText text = base.GetText(12 + i * 2);
					if (text != null)
					{
						text.SetText(playerName, true);
					}
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(12 + i * 2), motorParkourRankData.Name, Array.Empty<object>());
				}
				string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5((double)motorParkourRankData.Time * TimeUtil.Instance.Millisecond);
				UUIText text2 = base.GetText(13 + i * 2);
				if (text2 != null)
				{
					text2.SetText(remainTimeDataFormat, true);
				}
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(isNewRecord);
			}
			string remainTimeDataFormat2 = TimeUtil.Instance.GetRemainTimeDataFormat5((double)motorParkourSettleViewData.MyScoreTime * TimeUtil.Instance.Millisecond);
			UUIText text3 = base.GetText(9);
			if (text3 != null)
			{
				text3.SetText(remainTimeDataFormat2, true);
			}
			string remainTimeDataFormat3 = TimeUtil.Instance.GetRemainTimeDataFormat5((double)levelData.BestRecordTime * TimeUtil.Instance.Millisecond);
			UUIText text4 = base.GetText(11);
			if (text4 == null)
			{
				return;
			}
			text4.SetText(remainTimeDataFormat3, true);
		}

		// Token: 0x060405FE RID: 263678 RVA: 0x00F92A86 File Offset: 0x00F90C86
		private void OnReChallengeBtnClick()
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon();
		}

		// Token: 0x060405FF RID: 263679 RVA: 0x00F92A93 File Offset: 0x00F90C93
		private void OnExitBtnClick()
		{
			MotorParkourController.Instance.IsNeedShowMotorParkourMainView = true;
			MotorParkourController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0200C61F RID: 50719
		public interface IMotorParkourSettleViewData
		{
			// Token: 0x1700A286 RID: 41606
			// (get) Token: 0x06050CA9 RID: 330921
			// (set) Token: 0x06050CAA RID: 330922
			MotorParkourLevelData LevelData { get; set; }

			// Token: 0x1700A287 RID: 41607
			// (get) Token: 0x06050CAB RID: 330923
			// (set) Token: 0x06050CAC RID: 330924
			bool IsNewRecord { get; set; }

			// Token: 0x1700A288 RID: 41608
			// (get) Token: 0x06050CAD RID: 330925
			// (set) Token: 0x06050CAE RID: 330926
			int MyScoreTime { get; set; }
		}

		// Token: 0x0200C620 RID: 50720
		[Nullable(0)]
		public class MotorParkourSettleViewData : MotorParkourSettleView.IMotorParkourSettleViewData
		{
			// Token: 0x1700A289 RID: 41609
			// (get) Token: 0x06050CAF RID: 330927 RVA: 0x015CBFCE File Offset: 0x015CA1CE
			// (set) Token: 0x06050CB0 RID: 330928 RVA: 0x015CBFD6 File Offset: 0x015CA1D6
			public MotorParkourLevelData LevelData { get; set; }

			// Token: 0x1700A28A RID: 41610
			// (get) Token: 0x06050CB1 RID: 330929 RVA: 0x015CBFDF File Offset: 0x015CA1DF
			// (set) Token: 0x06050CB2 RID: 330930 RVA: 0x015CBFE7 File Offset: 0x015CA1E7
			public bool IsNewRecord { get; set; }

			// Token: 0x1700A28B RID: 41611
			// (get) Token: 0x06050CB3 RID: 330931 RVA: 0x015CBFF0 File Offset: 0x015CA1F0
			// (set) Token: 0x06050CB4 RID: 330932 RVA: 0x015CBFF8 File Offset: 0x015CA1F8
			public int MyScoreTime { get; set; }
		}

		// Token: 0x0200C621 RID: 50721
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BD0B RID: 245003
			public const int ItemFirstBg = 0;

			// Token: 0x0403BD0C RID: 245004
			public const int ItemSecondBg = 1;

			// Token: 0x0403BD0D RID: 245005
			public const int ItemThirdBg = 2;

			// Token: 0x0403BD0E RID: 245006
			public const int ItemNormalBg = 3;

			// Token: 0x0403BD0F RID: 245007
			public const int BtnReChallenge = 4;

			// Token: 0x0403BD10 RID: 245008
			public const int BtnExit = 5;

			// Token: 0x0403BD11 RID: 245009
			public const int ItemFirstNum = 6;

			// Token: 0x0403BD12 RID: 245010
			public const int ItemSecondNum = 7;

			// Token: 0x0403BD13 RID: 245011
			public const int ItemThirdNum = 8;

			// Token: 0x0403BD14 RID: 245012
			public const int TextMyScoreTime = 9;

			// Token: 0x0403BD15 RID: 245013
			public const int ItemNewRecord = 10;

			// Token: 0x0403BD16 RID: 245014
			public const int TextBestRecordTime = 11;

			// Token: 0x0403BD17 RID: 245015
			public const int TextFirstName = 12;

			// Token: 0x0403BD18 RID: 245016
			public const int TextFirstTime = 13;

			// Token: 0x0403BD19 RID: 245017
			public const int TextSecondName = 14;

			// Token: 0x0403BD1A RID: 245018
			public const int TextSecondTime = 15;

			// Token: 0x0403BD1B RID: 245019
			public const int TextThirdName = 16;

			// Token: 0x0403BD1C RID: 245020
			public const int TextThirdTime = 17;
		}
	}
}
