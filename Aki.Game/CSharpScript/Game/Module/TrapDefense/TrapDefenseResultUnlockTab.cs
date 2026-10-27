using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA7 RID: 19111
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultUnlockTab : GridProxyAbstract<ITrapDefenseResultUnlockTab>
	{
		// Token: 0x06031858 RID: 202840 RVA: 0x00B7B3AC File Offset: 0x00B795AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031859 RID: 202841 RVA: 0x00B7B478 File Offset: 0x00B79678
		protected override void OnStart()
		{
			this.OrganLayout = new GenericLayout<TrapDefenseResultOrganUnlockItem, ITrapDefenseResultUnlockInfo>(base.GetGridLayout(1), new Func<TrapDefenseResultOrganUnlockItem>(this.CreateOrganItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.BdLayout = new GenericLayout<TrapDefenseResultBdUnlockItem, ITrapDefenseResultUnlockInfo>(base.GetGridLayout(3), new Func<TrapDefenseResultBdUnlockItem>(this.CreateBdItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603185A RID: 202842 RVA: 0x00B7B4E8 File Offset: 0x00B796E8
		public override void Refresh(ITrapDefenseResultUnlockTab data, bool isSelected, int gridIndex)
		{
			ETrapDefenseResultUnlockType type = data.Type;
			string textStringId = TrapDefenseResultUnlockTab.tabTypeTxtMap[type];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
			bool flag = type == ETrapDefenseResultUnlockType.Organ || type == ETrapDefenseResultUnlockType.OrganShare;
			this.IsUnlockAnim = (type == ETrapDefenseResultUnlockType.Organ || type == ETrapDefenseResultUnlockType.Bd);
			base.GetGridLayout(1).RootUIComp.Get().SetUIActive(flag);
			base.GetGridLayout(3).RootUIComp.Get().SetUIActive(!flag);
			this.IsShared = (type == ETrapDefenseResultUnlockType.OrganShare || type == ETrapDefenseResultUnlockType.BdShare);
			if (flag)
			{
				this.OrganLayout.RefreshByData(data.DataList, null, true);
				return;
			}
			this.BdLayout.RefreshByData(data.DataList, null, true);
		}

		// Token: 0x0603185B RID: 202843 RVA: 0x00B7B5AC File Offset: 0x00B797AC
		public void PlayUnlockAnim()
		{
			if (!this.IsUnlockAnim)
			{
				return;
			}
			foreach (TrapDefenseResultOrganUnlockItem trapDefenseResultOrganUnlockItem in this.OrganLayout.GetLayoutItemList())
			{
				trapDefenseResultOrganUnlockItem.PlayUnlockAnim();
			}
			foreach (TrapDefenseResultBdUnlockItem trapDefenseResultBdUnlockItem in this.BdLayout.GetLayoutItemList())
			{
				trapDefenseResultBdUnlockItem.PlayUnlockAnim();
			}
		}

		// Token: 0x0603185C RID: 202844 RVA: 0x00B7B650 File Offset: 0x00B79850
		private TrapDefenseResultOrganUnlockItem CreateOrganItem()
		{
			return new TrapDefenseResultOrganUnlockItem();
		}

		// Token: 0x0603185D RID: 202845 RVA: 0x00B7B657 File Offset: 0x00B79857
		private TrapDefenseResultBdUnlockItem CreateBdItem()
		{
			return new TrapDefenseResultBdUnlockItem();
		}

		// Token: 0x0401A783 RID: 108419
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<ETrapDefenseResultUnlockType, string> tabTypeTxtMap = new Dictionary<ETrapDefenseResultUnlockType, string>
		{
			{
				ETrapDefenseResultUnlockType.Organ,
				"TowerDefense_Ending_GainBuilding_Text"
			},
			{
				ETrapDefenseResultUnlockType.OrganShare,
				"TowerDefense_Ending_GainBuildingShare_Text"
			},
			{
				ETrapDefenseResultUnlockType.Bd,
				"TowerDefense_Ending_GainSchool_Text"
			},
			{
				ETrapDefenseResultUnlockType.BdShare,
				"TowerDefense_Ending_GainSchoolShare_Text"
			}
		};

		// Token: 0x0401A784 RID: 108420
		protected GenericLayout<TrapDefenseResultOrganUnlockItem, ITrapDefenseResultUnlockInfo> OrganLayout;

		// Token: 0x0401A785 RID: 108421
		protected GenericLayout<TrapDefenseResultBdUnlockItem, ITrapDefenseResultUnlockInfo> BdLayout;

		// Token: 0x0401A786 RID: 108422
		public bool IsShared;

		// Token: 0x0401A787 RID: 108423
		private bool IsUnlockAnim;

		// Token: 0x0200ABFC RID: 44028
		[NullableContext(0)]
		internal class EUnlockTab
		{
			// Token: 0x04034428 RID: 214056
			public const int Title = 0;

			// Token: 0x04034429 RID: 214057
			public const int OrganLayout = 1;

			// Token: 0x0403442A RID: 214058
			public const int OrganItem = 2;

			// Token: 0x0403442B RID: 214059
			public const int BdLayout = 3;

			// Token: 0x0403442C RID: 214060
			public const int BdItem = 4;
		}
	}
}
