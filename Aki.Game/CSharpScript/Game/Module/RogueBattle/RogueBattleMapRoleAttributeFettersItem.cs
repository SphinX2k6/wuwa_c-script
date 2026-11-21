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
	// Token: 0x02003E3A RID: 15930
	public class RogueBattleMapRoleAttributeFettersItem : UiPanelBase
	{
		// Token: 0x0602897D RID: 166269 RVA: 0x00B64538 File Offset: 0x00B62738
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602897E RID: 166270 RVA: 0x00B64592 File Offset: 0x00B62792
		protected override void OnStart()
		{
			this.FettersLayout = new GenericLayout<RougeBattleAttributeFetterItem, IRogueBattleMapAttrFettersInfo>(base.GetHorizontalLayout(1), new Func<RougeBattleAttributeFetterItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x0602897F RID: 166271 RVA: 0x00B645B5 File Offset: 0x00B627B5
		[NullableContext(1)]
		private RougeBattleAttributeFetterItem CreateElement()
		{
			return new RougeBattleAttributeFetterItem();
		}

		// Token: 0x06028980 RID: 166272 RVA: 0x00B645BC File Offset: 0x00B627BC
		protected override void OnBeforeDestroy()
		{
			this.FettersLayout = null;
		}

		// Token: 0x06028981 RID: 166273 RVA: 0x00B645C8 File Offset: 0x00B627C8
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

		// Token: 0x040160B6 RID: 90294
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RougeBattleAttributeFetterItem, IRogueBattleMapAttrFettersInfo> FettersLayout;
	}
}
