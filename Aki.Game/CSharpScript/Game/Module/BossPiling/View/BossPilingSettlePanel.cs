using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BF6 RID: 19446
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingSettlePanel : UiPanelBase
	{
		// Token: 0x06030869 RID: 198761 RVA: 0x00D85150 File Offset: 0x00D83350
		public BossPilingSettlePanel(BossPilingSettleNotify levelInfo)
		{
			this.LevelInfo = levelInfo;
		}

		// Token: 0x0603086A RID: 198762 RVA: 0x00D85160 File Offset: 0x00D83360
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603086B RID: 198763 RVA: 0x00D8522C File Offset: 0x00D8342C
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<BossPilingSettleScoreTabItem, BossPilingScoreTabInfo>(base.GetVerticalLayout(3), new Func<BossPilingSettleScoreTabItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x0603086C RID: 198764 RVA: 0x00D85250 File Offset: 0x00D83450
		protected override void OnBeforeShow()
		{
			int challengeLevelId = this.LevelInfo.ChallengeLevelId;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(this.LevelInfo.IsUpdateBossHpNum);
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew("BossPilingActivity_Dungeon14");
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.LevelInfo.BossHpNum);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			List<BossPilingScoreTabInfo> list = new List<BossPilingScoreTabInfo>();
			BossPilingLevels value = BossPilingConfig.Instance.GetLevelInfo(challengeLevelId).Value;
			for (int i = 0; i < value.Achievement().Length; i++)
			{
				int num = value.Achievement()[i];
				BossPilingScoreTabInfo item2 = new BossPilingScoreTabInfo
				{
					BossHp = num,
					Quality = i + 1,
					IsAchieve = (this.LevelInfo.BossHpNum >= num)
				};
				list.Add(item2);
			}
			this.Layout.RefreshByData(list, null, true);
		}

		// Token: 0x0603086D RID: 198765 RVA: 0x00D85358 File Offset: 0x00D83558
		private BossPilingSettleScoreTabItem CreateItem()
		{
			return new BossPilingSettleScoreTabItem();
		}

		// Token: 0x04019AFC RID: 105212
		protected GenericLayout<BossPilingSettleScoreTabItem, BossPilingScoreTabInfo> Layout;

		// Token: 0x04019AFD RID: 105213
		protected BossPilingSettleNotify LevelInfo;

		// Token: 0x0200A809 RID: 43017
		[NullableContext(0)]
		private enum EPanel
		{
			// Token: 0x04033E6C RID: 212588
			TxtTitle,
			// Token: 0x04033E6D RID: 212589
			TxtNum,
			// Token: 0x04033E6E RID: 212590
			PanelNew,
			// Token: 0x04033E6F RID: 212591
			PanelTarget,
			// Token: 0x04033E70 RID: 212592
			TargetItem
		}
	}
}
