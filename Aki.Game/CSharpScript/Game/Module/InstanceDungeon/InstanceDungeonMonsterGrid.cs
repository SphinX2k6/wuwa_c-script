using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200587C RID: 22652
	public class InstanceDungeonMonsterGrid : GridProxyAbstract<int>
	{
		// Token: 0x06039A75 RID: 236149 RVA: 0x00DB3820 File Offset: 0x00DB1A20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039A76 RID: 236150 RVA: 0x00DB38CB File Offset: 0x00DB1ACB
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(3), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
		}

		// Token: 0x06039A77 RID: 236151 RVA: 0x00DB38F0 File Offset: 0x00DB1AF0
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.CurrentMonsterId = data;
			string monsterName = MonsterInfoConfig.Instance.GetMonsterName(this.CurrentMonsterId);
			base.GetText(0).SetText(monsterName, true);
			int num = InstanceDungeonConfig.Instance.GetConfig(this.CurrentInstanceId).Value.EntityLevel;
			if (num == 0)
			{
				int currentInstanceId = this.CurrentInstanceId;
				int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
				ValueTuple<bool, int> valueTuple = ActivityModel.Instance.CheckActivityLevelBelongToType(currentInstanceId);
				bool item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				if (item)
				{
					num = ActivityModel.Instance.GetActivityLevelRecommendLevel(currentInstanceId, curWorldLevel, item2);
				}
				else
				{
					num = InstanceDungeonConfig.Instance.GetRecommendLevel(currentInstanceId, curWorldLevel);
				}
			}
			LguiUtil.Instance.SetLocalText(base.GetText(1), "LevelText", new <>z__ReadOnlySingleElementList<object>(num));
			string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(this.CurrentMonsterId);
			base.SetTextureByPath(monsterIcon, base.GetTexture(2), null, null);
			List<int> data2 = MonsterInfoConfig.Instance.GetMonsterInfoConfig(data).Value.ElementIdArrayIter().ToList<int>();
			GenericLayout<TowerElementItem, int> elementLayout = this.ElementLayout;
			if (elementLayout == null)
			{
				return;
			}
			elementLayout.RefreshByData(data2, null, false);
		}

		// Token: 0x06039A78 RID: 236152 RVA: 0x00DB3A1F File Offset: 0x00DB1C1F
		[NullableContext(1)]
		private TowerElementItem CreateElementItem()
		{
			return new TowerElementItem();
		}

		// Token: 0x0401E20D RID: 123405
		public int CurrentInstanceId;

		// Token: 0x0401E20E RID: 123406
		private int CurrentMonsterId;

		// Token: 0x0401E20F RID: 123407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerElementItem, int> ElementLayout;

		// Token: 0x0200BAD6 RID: 47830
		private static class EChildType
		{
			// Token: 0x0403875F RID: 231263
			public const int NameText = 0;

			// Token: 0x04038760 RID: 231264
			public const int LevelText = 1;

			// Token: 0x04038761 RID: 231265
			public const int MonsterIcon = 2;

			// Token: 0x04038762 RID: 231266
			public const int ElementLayout = 3;
		}
	}
}
