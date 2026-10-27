using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x02006340 RID: 25408
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballLevelItem : UiPanelBase
	{
		// Token: 0x0603FEF9 RID: 261881 RVA: 0x00F78878 File Offset: 0x00F76A78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(delegate(EToggleState _)
			{
				this.OnTogClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FEFA RID: 261882 RVA: 0x00F78981 File Offset: 0x00F76B81
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<PinballLevelStarItem, IPinballLevelStarData>(base.GetHorizontalLayout(1), new Func<PinballLevelStarItem>(this.InitStarItem), null, false, true);
		}

		// Token: 0x0603FEFB RID: 261883 RVA: 0x00F789A4 File Offset: 0x00F76BA4
		private PinballLevelStarItem InitStarItem()
		{
			return new PinballLevelStarItem();
		}

		// Token: 0x0603FEFC RID: 261884 RVA: 0x00F789AB File Offset: 0x00F76BAB
		private bool IsLevelLock(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelLockStatus(levelId) != EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x0603FEFD RID: 261885 RVA: 0x00F789C3 File Offset: 0x00F76BC3
		private string GetLevelLockTexts(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelPreConditionLockTexts(levelId);
		}

		// Token: 0x0603FEFE RID: 261886 RVA: 0x00F789D8 File Offset: 0x00F76BD8
		public void Refresh(PinballLevelRecordData data)
		{
			this.Data = data;
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(data.LevelId);
			int starCondLength = pinballLevelConfigById.Value.StarCondLength;
			List<IPinballLevelStarData> list = new List<IPinballLevelStarData>();
			for (int i = 0; i < starCondLength; i++)
			{
				int num = pinballLevelConfigById.Value.StarCond(i);
				bool passed = Array.IndexOf<int>(data.LevelStarConditionIds, num) >= 0;
				PinballLevelStarData item = new PinballLevelStarData
				{
					ConditionId = num,
					Passed = passed
				};
				list.Add(item);
			}
			this.StarLayout.RefreshByData(list, null, false);
			bool flag = this.IsLevelLock(data.LevelId);
			base.GetItem(3).SetUIActive(flag);
			base.GetItem(4).SetUIActive(!flag);
		}

		// Token: 0x0603FEFF RID: 261887 RVA: 0x00F78AA4 File Offset: 0x00F76CA4
		public void SelectLevel()
		{
			this.OnTogClick();
		}

		// Token: 0x0603FF00 RID: 261888 RVA: 0x00F78AAC File Offset: 0x00F76CAC
		private void OnTogClick()
		{
			if (this.Data == null)
			{
				return;
			}
			bool value = this.IsLevelLock(this.Data.LevelId);
			string levelLockTexts = this.GetLevelLockTexts(this.Data.LevelId);
			PinballLevelInfoData arg = new PinballLevelInfoData
			{
				LevelId = this.Data.LevelId,
				RealLevelId = this.Data.LevelId,
				LevelStarConditionIds = this.Data.LevelStarConditionIds,
				LevelLock = new bool?(value),
				LevelLockTexts = levelLockTexts,
				ShowStar = new bool?(true),
				ShowReward = new bool?(true),
				RewardReceived = new bool?(this.Data.LevelStarConditionIds.Length != 0)
			};
			Action<PinballLevelRecordData, IPinballLevelInfoData, UUIExtendToggle> onTogLevelClick = this.OnTogLevelClick;
			if (onTogLevelClick == null)
			{
				return;
			}
			onTogLevelClick(this.Data, arg, base.GetExtendToggle(0));
		}

		// Token: 0x0402158F RID: 136591
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballLevelRecordData, IPinballLevelInfoData, UUIExtendToggle> OnTogLevelClick;

		// Token: 0x04021590 RID: 136592
		[Nullable(2)]
		private PinballLevelRecordData Data;

		// Token: 0x04021591 RID: 136593
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballLevelStarItem, IPinballLevelStarData> StarLayout;

		// Token: 0x0200C557 RID: 50519
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B8FF RID: 243967
			TogItem,
			// Token: 0x0403B900 RID: 243968
			StarLayout,
			// Token: 0x0403B901 RID: 243969
			StarItem,
			// Token: 0x0403B902 RID: 243970
			LockItem,
			// Token: 0x0403B903 RID: 243971
			NumItem
		}
	}
}
