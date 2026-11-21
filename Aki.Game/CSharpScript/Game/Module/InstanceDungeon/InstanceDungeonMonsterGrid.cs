using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004854 RID: 18516
	public class InstanceDungeonMonsterGrid : GridProxyAbstract<int>
	{
		// Token: 0x0602E998 RID: 190872 RVA: 0x00D02734 File Offset: 0x00D00934
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

		// Token: 0x0602E999 RID: 190873 RVA: 0x00D027DF File Offset: 0x00D009DF
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(3), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
		}

		// Token: 0x0602E99A RID: 190874 RVA: 0x00D02804 File Offset: 0x00D00A04
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
			List<int> data2 = new List<int>(MonsterInfoConfig.Instance.GetMonsterInfoConfig(data).Value.ElementIdArrayIter());
			GenericLayout<TowerElementItem, int> elementLayout = this.ElementLayout;
			if (elementLayout == null)
			{
				return;
			}
			elementLayout.RefreshByData(data2, null, false);
		}

		// Token: 0x0602E99B RID: 190875 RVA: 0x00D02933 File Offset: 0x00D00B33
		[NullableContext(1)]
		private TowerElementItem CreateElementItem()
		{
			return new TowerElementItem();
		}

		// Token: 0x04018CAA RID: 101546
		public int CurrentInstanceId;

		// Token: 0x04018CAB RID: 101547
		private int CurrentMonsterId;

		// Token: 0x04018CAC RID: 101548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerElementItem, int> ElementLayout;

		// Token: 0x0200A4EF RID: 42223
		private static class EChildType
		{
			// Token: 0x04033160 RID: 209248
			public const int NameText = 0;

			// Token: 0x04033161 RID: 209249
			public const int LevelText = 1;

			// Token: 0x04033162 RID: 209250
			public const int MonsterIcon = 2;

			// Token: 0x04033163 RID: 209251
			public const int ElementLayout = 3;
		}
	}
}
