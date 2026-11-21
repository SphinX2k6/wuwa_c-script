using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x0200537A RID: 21370
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourSettleView : UiViewBase
	{
		// Token: 0x060352BC RID: 217788 RVA: 0x00ED9578 File Offset: 0x00ED7778
		public MotorParkourSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060352BD RID: 217789 RVA: 0x00ED9584 File Offset: 0x00ED7784
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

		// Token: 0x060352BE RID: 217790 RVA: 0x00ED9868 File Offset: 0x00ED7A68
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

		// Token: 0x060352BF RID: 217791 RVA: 0x00ED9A66 File Offset: 0x00ED7C66
		private void OnReChallengeBtnClick()
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false);
		}

		// Token: 0x060352C0 RID: 217792 RVA: 0x00ED9A74 File Offset: 0x00ED7C74
		private void OnExitBtnClick()
		{
			MotorParkourController.Instance.IsNeedShowMotorParkourMainView = true;
			MotorParkourController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0200B006 RID: 45062
		public interface IMotorParkourSettleViewData
		{
			// Token: 0x17007A23 RID: 31267
			// (get) Token: 0x0604718E RID: 291214
			// (set) Token: 0x0604718F RID: 291215
			MotorParkourLevelData LevelData { get; set; }

			// Token: 0x17007A24 RID: 31268
			// (get) Token: 0x06047190 RID: 291216
			// (set) Token: 0x06047191 RID: 291217
			bool IsNewRecord { get; set; }

			// Token: 0x17007A25 RID: 31269
			// (get) Token: 0x06047192 RID: 291218
			// (set) Token: 0x06047193 RID: 291219
			int MyScoreTime { get; set; }
		}

		// Token: 0x0200B007 RID: 45063
		[Nullable(0)]
		public class MotorParkourSettleViewData : MotorParkourSettleView.IMotorParkourSettleViewData
		{
			// Token: 0x17007A26 RID: 31270
			// (get) Token: 0x06047194 RID: 291220 RVA: 0x01583D0A File Offset: 0x01581F0A
			// (set) Token: 0x06047195 RID: 291221 RVA: 0x01583D12 File Offset: 0x01581F12
			public MotorParkourLevelData LevelData { get; set; }

			// Token: 0x17007A27 RID: 31271
			// (get) Token: 0x06047196 RID: 291222 RVA: 0x01583D1B File Offset: 0x01581F1B
			// (set) Token: 0x06047197 RID: 291223 RVA: 0x01583D23 File Offset: 0x01581F23
			public bool IsNewRecord { get; set; }

			// Token: 0x17007A28 RID: 31272
			// (get) Token: 0x06047198 RID: 291224 RVA: 0x01583D2C File Offset: 0x01581F2C
			// (set) Token: 0x06047199 RID: 291225 RVA: 0x01583D34 File Offset: 0x01581F34
			public int MyScoreTime { get; set; }
		}

		// Token: 0x0200B008 RID: 45064
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403666A RID: 222826
			public const int ItemFirstBg = 0;

			// Token: 0x0403666B RID: 222827
			public const int ItemSecondBg = 1;

			// Token: 0x0403666C RID: 222828
			public const int ItemThirdBg = 2;

			// Token: 0x0403666D RID: 222829
			public const int ItemNormalBg = 3;

			// Token: 0x0403666E RID: 222830
			public const int BtnReChallenge = 4;

			// Token: 0x0403666F RID: 222831
			public const int BtnExit = 5;

			// Token: 0x04036670 RID: 222832
			public const int ItemFirstNum = 6;

			// Token: 0x04036671 RID: 222833
			public const int ItemSecondNum = 7;

			// Token: 0x04036672 RID: 222834
			public const int ItemThirdNum = 8;

			// Token: 0x04036673 RID: 222835
			public const int TextMyScoreTime = 9;

			// Token: 0x04036674 RID: 222836
			public const int ItemNewRecord = 10;

			// Token: 0x04036675 RID: 222837
			public const int TextBestRecordTime = 11;

			// Token: 0x04036676 RID: 222838
			public const int TextFirstName = 12;

			// Token: 0x04036677 RID: 222839
			public const int TextFirstTime = 13;

			// Token: 0x04036678 RID: 222840
			public const int TextSecondName = 14;

			// Token: 0x04036679 RID: 222841
			public const int TextSecondTime = 15;

			// Token: 0x0403667A RID: 222842
			public const int TextThirdName = 16;

			// Token: 0x0403667B RID: 222843
			public const int TextThirdTime = 17;
		}
	}
}
