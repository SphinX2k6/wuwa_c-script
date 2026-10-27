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
	// Token: 0x02005C16 RID: 23574
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingSettlePanel : UiPanelBase
	{
		// Token: 0x0603B91E RID: 243998 RVA: 0x00E34DF4 File Offset: 0x00E32FF4
		public BossPilingSettlePanel(BossPilingSettleNotify levelInfo)
		{
			this.LevelInfo = levelInfo;
		}

		// Token: 0x0603B91F RID: 243999 RVA: 0x00E34E04 File Offset: 0x00E33004
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

		// Token: 0x0603B920 RID: 244000 RVA: 0x00E34ED0 File Offset: 0x00E330D0
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<BossPilingSettleScoreTabItem, BossPilingScoreTabInfo>(base.GetVerticalLayout(3), new Func<BossPilingSettleScoreTabItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x0603B921 RID: 244001 RVA: 0x00E34EF4 File Offset: 0x00E330F4
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

		// Token: 0x0603B922 RID: 244002 RVA: 0x00E34FFC File Offset: 0x00E331FC
		private BossPilingSettleScoreTabItem CreateItem()
		{
			return new BossPilingSettleScoreTabItem();
		}

		// Token: 0x0401F04B RID: 127051
		protected GenericLayout<BossPilingSettleScoreTabItem, BossPilingScoreTabInfo> Layout;

		// Token: 0x0401F04C RID: 127052
		protected BossPilingSettleNotify LevelInfo;

		// Token: 0x0200BE01 RID: 48641
		[NullableContext(0)]
		private enum EPanel
		{
			// Token: 0x040394A9 RID: 234665
			TxtTitle,
			// Token: 0x040394AA RID: 234666
			TxtNum,
			// Token: 0x040394AB RID: 234667
			PanelNew,
			// Token: 0x040394AC RID: 234668
			PanelTarget,
			// Token: 0x040394AD RID: 234669
			TargetItem
		}
	}
}
