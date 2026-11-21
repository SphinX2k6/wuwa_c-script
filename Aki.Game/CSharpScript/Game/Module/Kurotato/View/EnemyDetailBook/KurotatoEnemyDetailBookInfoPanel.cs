using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x02004740 RID: 18240
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyDetailBookInfoPanel : UiPanelBase
	{
		// Token: 0x0602DCA1 RID: 187553 RVA: 0x00CD00D8 File Offset: 0x00CCE2D8
		public KurotatoEnemyDetailBookInfoPanel(KurotatoEnemyDetailBookMainView parentView)
		{
			this.ParentView = parentView;
		}

		// Token: 0x0602DCA2 RID: 187554 RVA: 0x00CD00E8 File Offset: 0x00CCE2E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DCA3 RID: 187555 RVA: 0x00CD025C File Offset: 0x00CCE45C
		protected override void OnStart()
		{
			this.Grid = new SmallItemGrid();
			this.Grid.Initialize(base.GetItem(0).GetOwner());
			this.BasePropertyLayout = new GenericLayout<KurotatoEnemyBasePropertyItem, KurotatoEnemyBasePropertyData>(base.GetVerticalLayout(4), new Func<KurotatoEnemyBasePropertyItem>(this.CreateBasePropertyItem), null, false, true);
			this.CharacteristicLayout = new GenericLayout<KurotatoEnemyCharacteristicItem, KurotatoEnemyCharacteristicData>(base.GetVerticalLayout(6), new Func<KurotatoEnemyCharacteristicItem>(this.CreateCharacteristicItem), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602DCA4 RID: 187556 RVA: 0x00CD02E0 File Offset: 0x00CCE4E0
		[NullableContext(2)]
		public void RefreshMonsterInfoShow(KurotatoEnemyData monsterData)
		{
			if (monsterData == null)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopSequenceByKey("Select", false, true);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Select", false, null, false);
			}
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = null,
				IconPath = monsterData.IconPath,
				QualityIcon = monsterData.GetQualityPathGrid()
			};
			this.Grid.ApplyPropSmallItemGrid(parameters);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), monsterData.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), monsterData.GetRiskTypeText(), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), monsterData.GetBodyTypeText(), Array.Empty<object>());
			bool flag = !string.IsNullOrEmpty(monsterData.Desc);
			base.GetText(8).SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), monsterData.Desc, Array.Empty<object>());
			}
			this.BasePropertyLayout.RefreshByData(monsterData.BasePropertyDataList, null, false);
			this.CharacteristicLayout.RefreshByData(monsterData.CharacteristicDataList, null, false);
			base.GetItem(9).SetUIActive(monsterData.CharacteristicDataList.Count > 0);
		}

		// Token: 0x0602DCA5 RID: 187557 RVA: 0x00CD042B File Offset: 0x00CCE62B
		private KurotatoEnemyBasePropertyItem CreateBasePropertyItem()
		{
			return new KurotatoEnemyBasePropertyItem();
		}

		// Token: 0x0602DCA6 RID: 187558 RVA: 0x00CD0432 File Offset: 0x00CCE632
		private KurotatoEnemyCharacteristicItem CreateCharacteristicItem()
		{
			return new KurotatoEnemyCharacteristicItem();
		}

		// Token: 0x040187A6 RID: 100262
		protected KurotatoEnemyDetailBookMainView ParentView;

		// Token: 0x040187A7 RID: 100263
		[Nullable(2)]
		private SmallItemGrid Grid;

		// Token: 0x040187A8 RID: 100264
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoEnemyBasePropertyItem, KurotatoEnemyBasePropertyData> BasePropertyLayout;

		// Token: 0x040187A9 RID: 100265
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoEnemyCharacteristicItem, KurotatoEnemyCharacteristicData> CharacteristicLayout;

		// Token: 0x040187AA RID: 100266
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A38C RID: 41868
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04032B2E RID: 207662
			public const int ItemIconBox = 0;

			// Token: 0x04032B2F RID: 207663
			public const int TextName = 1;

			// Token: 0x04032B30 RID: 207664
			public const int TextType = 2;

			// Token: 0x04032B31 RID: 207665
			public const int TextSize = 3;

			// Token: 0x04032B32 RID: 207666
			public const int PanelBasePropertyLayout = 4;

			// Token: 0x04032B33 RID: 207667
			public const int ItemBaseProperty = 5;

			// Token: 0x04032B34 RID: 207668
			public const int PanelCharacteristicLayout = 6;

			// Token: 0x04032B35 RID: 207669
			public const int ItemCharacteristic = 7;

			// Token: 0x04032B36 RID: 207670
			public const int TextDesc = 8;

			// Token: 0x04032B37 RID: 207671
			public const int Line = 9;
		}
	}
}
