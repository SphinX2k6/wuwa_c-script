using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C0F RID: 23567
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelDescView : UiViewBase
	{
		// Token: 0x0603B8D5 RID: 243925 RVA: 0x00E32CE4 File Offset: 0x00E30EE4
		public BossPilingLevelDescView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B8D6 RID: 243926 RVA: 0x00E32D00 File Offset: 0x00E30F00
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

		// Token: 0x0603B8D7 RID: 243927 RVA: 0x00E32E50 File Offset: 0x00E31050
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

		// Token: 0x0603B8D8 RID: 243928 RVA: 0x00E32F28 File Offset: 0x00E31128
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

		// Token: 0x0603B8D9 RID: 243929 RVA: 0x00E32FD4 File Offset: 0x00E311D4
		protected void RefreshLayout()
		{
			BossPilingLevelDescInfo bossPilingLevelDescInfo = this.IsFirst ? this.LevelInfo[0] : this.LevelInfo[1];
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(bossPilingLevelDescInfo.LevelId);
			List<ShipTowerMonsterInfoItemData> list = new List<ShipTowerMonsterInfoItemData>();
			foreach (int monsterId in config.Value.MonsterPreviewIter())
			{
				MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterId);
				ShipTowerMonsterInfoItemData item = new ShipTowerMonsterInfoItemData
				{
					Title = (monsterInfoConfig.Value.Name ?? ""),
					Level = config.Value.EntityLevel,
					MonsterIcon = monsterInfoConfig.Value.Icon,
					ElementList = (((monsterInfoConfig != null) ? monsterInfoConfig.GetValueOrDefault().ElementIdArray().ToList<int>() : null) ?? new List<int>())
				};
				list.Add(item);
			}
			this.Layout.RefreshByData(list, null, true);
		}

		// Token: 0x0603B8DA RID: 243930 RVA: 0x00E3310C File Offset: 0x00E3130C
		private void OnClickedFirst(EToggleState state)
		{
			this.IsFirst = true;
			this.RefreshPanel();
		}

		// Token: 0x0603B8DB RID: 243931 RVA: 0x00E3311B File Offset: 0x00E3131B
		private void OnClickedSecond(EToggleState state)
		{
			this.IsFirst = false;
			this.RefreshPanel();
		}

		// Token: 0x0603B8DC RID: 243932 RVA: 0x00E3312A File Offset: 0x00E3132A
		private ShipTowerMonsterInfoItem CreateItem()
		{
			return new ShipTowerMonsterInfoItem();
		}

		// Token: 0x0401F024 RID: 127012
		protected List<BossPilingLevelDescInfo> LevelInfo = new List<BossPilingLevelDescInfo>();

		// Token: 0x0401F025 RID: 127013
		protected bool IsFirst = true;

		// Token: 0x0401F026 RID: 127014
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401F027 RID: 127015
		protected GenericLayout<ShipTowerMonsterInfoItem, ShipTowerMonsterInfoItemData> Layout;

		// Token: 0x0401F028 RID: 127016
		protected LevelSequencePlayer LevelSequence;

		// Token: 0x0200BDEE RID: 48622
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403943C RID: 234556
			CaptionItem,
			// Token: 0x0403943D RID: 234557
			Toggle1,
			// Token: 0x0403943E RID: 234558
			Toggle2,
			// Token: 0x0403943F RID: 234559
			MonsterDesc,
			// Token: 0x04039440 RID: 234560
			LevelDesc,
			// Token: 0x04039441 RID: 234561
			Layout
		}
	}
}
