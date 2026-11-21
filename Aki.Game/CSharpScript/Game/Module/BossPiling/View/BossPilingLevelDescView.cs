using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BEF RID: 19439
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelDescView : UiViewBase
	{
		// Token: 0x06030820 RID: 198688 RVA: 0x00D83024 File Offset: 0x00D81224
		public BossPilingLevelDescView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06030821 RID: 198689 RVA: 0x00D83040 File Offset: 0x00D81240
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIGridLayout));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickedFirst));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickedSecond));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030822 RID: 198690 RVA: 0x00D83190 File Offset: 0x00D81390
		protected override void OnStart()
		{
			this.LevelSequence = new LevelSequencePlayer(base.GetRootItem());
			BossPilingLevelDetailInfo bossPilingLevelDetailInfo = this.OpenParam as BossPilingLevelDetailInfo;
			this.IsFirst = bossPilingLevelDetailInfo.IsFirst;
			this.LevelInfo = bossPilingLevelDetailInfo.LevelList;
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.CaptionItem.SetHelpBtnActive(false);
			this.Layout = new GenericLayout<ShipTowerMonsterInfoItem, ShipTowerMonsterInfoItemData>(base.GetGridLayout(5), new Func<ShipTowerMonsterInfoItem>(this.CreateItem), null, false, true);
			if (this.IsFirst)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(1);
				if (extendToggle != null)
				{
					extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				}
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
				if (extendToggle2 != null)
				{
					extendToggle2.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				}
			}
			this.RefreshPanel();
		}

		// Token: 0x06030823 RID: 198691 RVA: 0x00D83268 File Offset: 0x00D81468
		protected void RefreshPanel()
		{
			this.LevelSequence.PlayOrReplaySequenceByName("Switch", false, null);
			BossPilingLevelDescInfo bossPilingLevelDescInfo = this.IsFirst ? this.LevelInfo[0] : this.LevelInfo[1];
			string key = StringUtils.IsBlank(bossPilingLevelDescInfo.MonsterDesc) ? "BossPilingActivity_DungeonDetail17" : bossPilingLevelDescInfo.MonsterDesc;
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.ShowTextNew(key);
			}
			string key2 = StringUtils.IsBlank(bossPilingLevelDescInfo.LevelDesc) ? "BossPilingActivity_DungeonDetail17" : bossPilingLevelDescInfo.LevelDesc;
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.ShowTextNew(key2);
			}
			this.RefreshLayout();
		}

		// Token: 0x06030824 RID: 198692 RVA: 0x00D83314 File Offset: 0x00D81514
		protected void RefreshLayout()
		{
			BossPilingLevelDescInfo bossPilingLevelDescInfo = this.IsFirst ? this.LevelInfo[0] : this.LevelInfo[1];
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(bossPilingLevelDescInfo.LevelId);
			List<ShipTowerMonsterInfoItemData> list = new List<ShipTowerMonsterInfoItemData>();
			foreach (int monsterId in config.Value.MonsterPreviewIter())
			{
				MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterId);
				ShipTowerMonsterInfoItemData shipTowerMonsterInfoItemData = new ShipTowerMonsterInfoItemData();
				shipTowerMonsterInfoItemData.Title = (monsterInfoConfig.Value.Name ?? "");
				shipTowerMonsterInfoItemData.Level = config.Value.EntityLevel;
				shipTowerMonsterInfoItemData.MonsterIcon = monsterInfoConfig.Value.Icon;
				int[] array = (monsterInfoConfig != null) ? monsterInfoConfig.GetValueOrDefault().ElementIdArray() : null;
				shipTowerMonsterInfoItemData.ElementList = ((array != null) ? new List<int>(array) : new List<int>());
				ShipTowerMonsterInfoItemData item = shipTowerMonsterInfoItemData;
				list.Add(item);
			}
			this.Layout.RefreshByData(list, null, true);
		}

		// Token: 0x06030825 RID: 198693 RVA: 0x00D83454 File Offset: 0x00D81654
		private void OnClickedFirst(EToggleState state)
		{
			this.IsFirst = true;
			this.RefreshPanel();
		}

		// Token: 0x06030826 RID: 198694 RVA: 0x00D83463 File Offset: 0x00D81663
		private void OnClickedSecond(EToggleState state)
		{
			this.IsFirst = false;
			this.RefreshPanel();
		}

		// Token: 0x06030827 RID: 198695 RVA: 0x00D83472 File Offset: 0x00D81672
		private ShipTowerMonsterInfoItem CreateItem()
		{
			return new ShipTowerMonsterInfoItem();
		}

		// Token: 0x04019AD5 RID: 105173
		protected List<BossPilingLevelDescInfo> LevelInfo = new List<BossPilingLevelDescInfo>();

		// Token: 0x04019AD6 RID: 105174
		protected bool IsFirst = true;

		// Token: 0x04019AD7 RID: 105175
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04019AD8 RID: 105176
		protected GenericLayout<ShipTowerMonsterInfoItem, ShipTowerMonsterInfoItemData> Layout;

		// Token: 0x04019AD9 RID: 105177
		protected LevelSequencePlayer LevelSequence;

		// Token: 0x0200A7F6 RID: 42998
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04033DFF RID: 212479
			CaptionItem,
			// Token: 0x04033E00 RID: 212480
			Toggle1,
			// Token: 0x04033E01 RID: 212481
			Toggle2,
			// Token: 0x04033E02 RID: 212482
			MonsterDesc,
			// Token: 0x04033E03 RID: 212483
			LevelDesc,
			// Token: 0x04033E04 RID: 212484
			Layout
		}
	}
}
