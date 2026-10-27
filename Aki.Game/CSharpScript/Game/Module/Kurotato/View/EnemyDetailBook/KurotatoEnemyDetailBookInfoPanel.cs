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
	// Token: 0x02005769 RID: 22377
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyDetailBookInfoPanel : UiPanelBase
	{
		// Token: 0x06038D91 RID: 232849 RVA: 0x00D815DC File Offset: 0x00D7F7DC
		public KurotatoEnemyDetailBookInfoPanel(KurotatoEnemyDetailBookMainView parentView)
		{
			this.ParentView = parentView;
		}

		// Token: 0x06038D92 RID: 232850 RVA: 0x00D815EC File Offset: 0x00D7F7EC
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

		// Token: 0x06038D93 RID: 232851 RVA: 0x00D81760 File Offset: 0x00D7F960
		protected override void OnStart()
		{
			this.Grid = new SmallItemGrid();
			this.Grid.Initialize(base.GetItem(0).GetOwner());
			this.BasePropertyLayout = new GenericLayout<KurotatoEnemyBasePropertyItem, KurotatoEnemyBasePropertyData>(base.GetVerticalLayout(4), new Func<KurotatoEnemyBasePropertyItem>(this.CreateBasePropertyItem), null, false, true);
			this.CharacteristicLayout = new GenericLayout<KurotatoEnemyCharacteristicItem, KurotatoEnemyCharacteristicData>(base.GetVerticalLayout(6), new Func<KurotatoEnemyCharacteristicItem>(this.CreateCharacteristicItem), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038D94 RID: 232852 RVA: 0x00D817E4 File Offset: 0x00D7F9E4
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

		// Token: 0x06038D95 RID: 232853 RVA: 0x00D8192F File Offset: 0x00D7FB2F
		private KurotatoEnemyBasePropertyItem CreateBasePropertyItem()
		{
			return new KurotatoEnemyBasePropertyItem();
		}

		// Token: 0x06038D96 RID: 232854 RVA: 0x00D81936 File Offset: 0x00D7FB36
		private KurotatoEnemyCharacteristicItem CreateCharacteristicItem()
		{
			return new KurotatoEnemyCharacteristicItem();
		}

		// Token: 0x0401DD10 RID: 122128
		protected KurotatoEnemyDetailBookMainView ParentView;

		// Token: 0x0401DD11 RID: 122129
		[Nullable(2)]
		private SmallItemGrid Grid;

		// Token: 0x0401DD12 RID: 122130
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoEnemyBasePropertyItem, KurotatoEnemyBasePropertyData> BasePropertyLayout;

		// Token: 0x0401DD13 RID: 122131
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoEnemyCharacteristicItem, KurotatoEnemyCharacteristicData> CharacteristicLayout;

		// Token: 0x0401DD14 RID: 122132
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B972 RID: 47474
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038134 RID: 229684
			public const int ItemIconBox = 0;

			// Token: 0x04038135 RID: 229685
			public const int TextName = 1;

			// Token: 0x04038136 RID: 229686
			public const int TextType = 2;

			// Token: 0x04038137 RID: 229687
			public const int TextSize = 3;

			// Token: 0x04038138 RID: 229688
			public const int PanelBasePropertyLayout = 4;

			// Token: 0x04038139 RID: 229689
			public const int ItemBaseProperty = 5;

			// Token: 0x0403813A RID: 229690
			public const int PanelCharacteristicLayout = 6;

			// Token: 0x0403813B RID: 229691
			public const int ItemCharacteristic = 7;

			// Token: 0x0403813C RID: 229692
			public const int TextDesc = 8;

			// Token: 0x0403813D RID: 229693
			public const int Line = 9;
		}
	}
}
