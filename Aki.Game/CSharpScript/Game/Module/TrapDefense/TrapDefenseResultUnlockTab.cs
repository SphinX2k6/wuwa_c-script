using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A4F RID: 14927
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultUnlockTab : GridProxyAbstract<ITrapDefenseResultUnlockTab>
	{
		// Token: 0x060265E8 RID: 157160 RVA: 0x00ABF360 File Offset: 0x00ABD560
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

		// Token: 0x060265E9 RID: 157161 RVA: 0x00ABF42C File Offset: 0x00ABD62C
		protected override void OnStart()
		{
			this.OrganLayout = new GenericLayout<TrapDefenseResultOrganUnlockItem, ITrapDefenseResultUnlockInfo>(base.GetGridLayout(1), new Func<TrapDefenseResultOrganUnlockItem>(this.CreateOrganItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.BdLayout = new GenericLayout<TrapDefenseResultBdUnlockItem, ITrapDefenseResultUnlockInfo>(base.GetGridLayout(3), new Func<TrapDefenseResultBdUnlockItem>(this.CreateBdItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x060265EA RID: 157162 RVA: 0x00ABF49C File Offset: 0x00ABD69C
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

		// Token: 0x060265EB RID: 157163 RVA: 0x00ABF560 File Offset: 0x00ABD760
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

		// Token: 0x060265EC RID: 157164 RVA: 0x00ABF604 File Offset: 0x00ABD804
		private TrapDefenseResultOrganUnlockItem CreateOrganItem()
		{
			return new TrapDefenseResultOrganUnlockItem();
		}

		// Token: 0x060265ED RID: 157165 RVA: 0x00ABF60B File Offset: 0x00ABD80B
		private TrapDefenseResultBdUnlockItem CreateBdItem()
		{
			return new TrapDefenseResultBdUnlockItem();
		}

		// Token: 0x040150D5 RID: 86229
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

		// Token: 0x040150D6 RID: 86230
		protected GenericLayout<TrapDefenseResultOrganUnlockItem, ITrapDefenseResultUnlockInfo> OrganLayout;

		// Token: 0x040150D7 RID: 86231
		protected GenericLayout<TrapDefenseResultBdUnlockItem, ITrapDefenseResultUnlockInfo> BdLayout;

		// Token: 0x040150D8 RID: 86232
		public bool IsShared;

		// Token: 0x040150D9 RID: 86233
		private bool IsUnlockAnim;

		// Token: 0x0200961C RID: 38428
		[NullableContext(0)]
		internal class EUnlockTab
		{
			// Token: 0x0402EDD9 RID: 191961
			public const int Title = 0;

			// Token: 0x0402EDDA RID: 191962
			public const int OrganLayout = 1;

			// Token: 0x0402EDDB RID: 191963
			public const int OrganItem = 2;

			// Token: 0x0402EDDC RID: 191964
			public const int BdLayout = 3;

			// Token: 0x0402EDDD RID: 191965
			public const int BdItem = 4;
		}
	}
}
