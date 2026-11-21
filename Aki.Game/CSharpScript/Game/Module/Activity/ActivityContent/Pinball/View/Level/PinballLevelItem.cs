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
	// Token: 0x020052BE RID: 21182
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballLevelItem : UiPanelBase
	{
		// Token: 0x06034BBA RID: 215994 RVA: 0x00EBF7D8 File Offset: 0x00EBD9D8
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

		// Token: 0x06034BBB RID: 215995 RVA: 0x00EBF8E1 File Offset: 0x00EBDAE1
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<PinballLevelStarItem, IPinballLevelStarData>(base.GetHorizontalLayout(1), new Func<PinballLevelStarItem>(this.InitStarItem), null, false, true);
		}

		// Token: 0x06034BBC RID: 215996 RVA: 0x00EBF904 File Offset: 0x00EBDB04
		private PinballLevelStarItem InitStarItem()
		{
			return new PinballLevelStarItem();
		}

		// Token: 0x06034BBD RID: 215997 RVA: 0x00EBF90B File Offset: 0x00EBDB0B
		private bool IsLevelLock(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelLockStatus(levelId) != EPinballChapterLevelLockStatus.Activated;
		}

		// Token: 0x06034BBE RID: 215998 RVA: 0x00EBF923 File Offset: 0x00EBDB23
		private string GetLevelLockTexts(int levelId)
		{
			return PinballModel.Instance.ActivityData.GetLevelPreConditionLockTexts(levelId);
		}

		// Token: 0x06034BBF RID: 215999 RVA: 0x00EBF938 File Offset: 0x00EBDB38
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

		// Token: 0x06034BC0 RID: 216000 RVA: 0x00EBFA04 File Offset: 0x00EBDC04
		public void SelectLevel()
		{
			this.OnTogClick();
		}

		// Token: 0x06034BC1 RID: 216001 RVA: 0x00EBFA0C File Offset: 0x00EBDC0C
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

		// Token: 0x0401BEBE RID: 114366
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballLevelRecordData, IPinballLevelInfoData, UUIExtendToggle> OnTogLevelClick;

		// Token: 0x0401BEBF RID: 114367
		[Nullable(2)]
		private PinballLevelRecordData Data;

		// Token: 0x0401BEC0 RID: 114368
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballLevelStarItem, IPinballLevelStarData> StarLayout;

		// Token: 0x0200AF3E RID: 44862
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036261 RID: 221793
			TogItem,
			// Token: 0x04036262 RID: 221794
			StarLayout,
			// Token: 0x04036263 RID: 221795
			StarItem,
			// Token: 0x04036264 RID: 221796
			LockItem,
			// Token: 0x04036265 RID: 221797
			NumItem
		}
	}
}
