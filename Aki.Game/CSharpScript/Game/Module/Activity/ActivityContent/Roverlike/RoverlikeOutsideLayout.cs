using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B0 RID: 20656
	public static class RoverlikeOutsideLayout
	{
		// Token: 0x06033B22 RID: 211746 RVA: 0x00E78588 File Offset: 0x00E76788
		[return: TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private static IReadOnlyList<ValueTuple<EOutsideSlot, Type>> BuildWithRole()
		{
			List<ValueTuple<EOutsideSlot, Type>> list = new List<ValueTuple<EOutsideSlot, Type>>(RoverlikeOutsideLayout.RoleColumn.Count + RoverlikeOutsideLayout.MainBody.Count);
			for (int i = 0; i < RoverlikeOutsideLayout.RoleColumn.Count; i++)
			{
				list.Add(RoverlikeOutsideLayout.RoleColumn[i]);
			}
			for (int j = 0; j < RoverlikeOutsideLayout.MainBody.Count; j++)
			{
				list.Add(RoverlikeOutsideLayout.MainBody[j]);
			}
			return list;
		}

		// Token: 0x0401B6A5 RID: 112293
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<ValueTuple<EOutsideSlot, Type>> RoleColumn = new ValueTuple<EOutsideSlot, Type>[]
		{
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlRole, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.SvRole, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.TogRole, typeof(UUIExtendToggle)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlRoleEmpty, typeof(UUIItem))
		};

		// Token: 0x0401B6A6 RID: 112294
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<ValueTuple<EOutsideSlot, Type>> MainBody = new ValueTuple<EOutsideSlot, Type>[]
		{
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlItem, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.SvMulti, typeof(UUIMultiTemplateScrollViewComponent)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlTitle, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.ItemBaseGrid, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlProgress, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.TxtProgress, typeof(UUIText)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.ItemBlessDetail, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.ItemPropDetail, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.ItemReinforceDetail, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlRoleLock, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlRight, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.PnlToggle, typeof(UUIItem)),
			new ValueTuple<EOutsideSlot, Type>(EOutsideSlot.ToggleTick, typeof(UUIExtendToggle))
		};

		// Token: 0x0401B6A7 RID: 112295
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<ValueTuple<EOutsideSlot, Type>> WithRole = RoverlikeOutsideLayout.BuildWithRole();

		// Token: 0x0401B6A8 RID: 112296
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<ValueTuple<EOutsideSlot, Type>> Compact = RoverlikeOutsideLayout.MainBody;
	}
}
