using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E71 RID: 20081
	public class RogueBattleMapRoleAttributeFettersItem : UiPanelBase
	{
		// Token: 0x06033B12 RID: 211730 RVA: 0x00C1B014 File Offset: 0x00C19214
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06033B13 RID: 211731 RVA: 0x00C1B06E File Offset: 0x00C1926E
		protected override void OnStart()
		{
			this.FettersLayout = new GenericLayout<RougeBattleAttributeFetterItem, IRogueBattleMapAttrFettersInfo>(base.GetHorizontalLayout(1), new Func<RougeBattleAttributeFetterItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x06033B14 RID: 211732 RVA: 0x00C1B091 File Offset: 0x00C19291
		[NullableContext(1)]
		private RougeBattleAttributeFetterItem CreateElement()
		{
			return new RougeBattleAttributeFetterItem();
		}

		// Token: 0x06033B15 RID: 211733 RVA: 0x00C1B098 File Offset: 0x00C19298
		protected override void OnBeforeDestroy()
		{
			this.FettersLayout = null;
		}

		// Token: 0x06033B16 RID: 211734 RVA: 0x00C1B0A4 File Offset: 0x00C192A4
		public void Refresh(int roleId)
		{
			bool flag = RogueBattleModel.Instance.IsRoleGot(roleId);
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(roleId);
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(baseRoleId);
			List<IRogueBattleMapAttrFettersInfo> list = new List<IRogueBattleMapAttrFettersInfo>();
			foreach (int num in rogueResBondRole.Value.BondIdsIter())
			{
				RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(num);
				RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(num);
				int num2 = (roleBondDataById != null) ? roleBondDataById.Level : 0;
				RogueBattleMapAttrFettersInfo item = new RogueBattleMapAttrFettersInfo
				{
					ConfigId = num,
					Level = num2,
					IsUnlock = (flag && roleBondDataById != null),
					IsMaxLevel = new bool?(roleBondDataById != null && num2 == rogueResBond.Value.StarMapLength)
				};
				list.Add(item);
			}
			GenericLayout<RougeBattleAttributeFetterItem, IRogueBattleMapAttrFettersInfo> fettersLayout = this.FettersLayout;
			if (fettersLayout == null)
			{
				return;
			}
			fettersLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0401B6E3 RID: 112355
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RougeBattleAttributeFetterItem, IRogueBattleMapAttrFettersInfo> FettersLayout;
	}
}
