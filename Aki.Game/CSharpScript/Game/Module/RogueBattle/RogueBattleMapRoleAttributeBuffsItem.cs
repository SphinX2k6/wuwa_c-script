using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E6D RID: 20077
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapRoleAttributeBuffsItem : UiPanelBase
	{
		// Token: 0x06033B07 RID: 211719 RVA: 0x00C1ACEC File Offset: 0x00C18EEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06033B08 RID: 211720 RVA: 0x00C1AD5C File Offset: 0x00C18F5C
		protected override void OnStart()
		{
			this.BuffsLayout = new GenericLayout<RougeBattleAttributeBuffItem, int>(base.GetGridLayout(1), new Func<RougeBattleAttributeBuffItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x06033B09 RID: 211721 RVA: 0x00C1AD7F File Offset: 0x00C18F7F
		private RougeBattleAttributeBuffItem CreateElement()
		{
			return new RougeBattleAttributeBuffItem
			{
				OnClickCall = new Action<int>(this.OnClickBuff)
			};
		}

		// Token: 0x06033B0A RID: 211722 RVA: 0x00C1AD98 File Offset: 0x00C18F98
		protected override void OnBeforeDestroy()
		{
			this.BuffsLayout = null;
		}

		// Token: 0x06033B0B RID: 211723 RVA: 0x00C1ADA4 File Offset: 0x00C18FA4
		public void Refresh(int roleId)
		{
			this.RoleId = roleId;
			int incIdByRoleId = RogueBattleModel.Instance.GetIncIdByRoleId(roleId);
			RepeatedField<int> roleAffixs = RogueBattleModel.Instance.GetRoleInfoById(incIdByRoleId).RoleAffixs;
			if (roleAffixs.Count == 0)
			{
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.BuffsLayout.GetRootUiItem().SetUIActive(false);
				return;
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.BuffsLayout.GetRootUiItem().SetUIActive(true);
			GenericLayout<RougeBattleAttributeBuffItem, int> buffsLayout = this.BuffsLayout;
			if (buffsLayout != null)
			{
				buffsLayout.RefreshByData(roleAffixs.ToList<int>(), null, false);
			}
			this.BuffList = new List<int>(roleAffixs);
		}

		// Token: 0x06033B0C RID: 211724 RVA: 0x00C1AE4C File Offset: 0x00C1904C
		private void OnClickBuff(int buffId)
		{
			RogueBattleRoleAffixDetailOpenParam param = new RogueBattleRoleAffixDetailOpenParam
			{
				Index = this.BuffList.IndexOf(buffId),
				AffixIds = this.BuffList,
				RoleId = this.RoleId
			};
			UiManager.Instance.OpenView(EUiViewName.RogueBattleRoleAffixDetailView, param, null);
		}

		// Token: 0x0401B6D7 RID: 112343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RougeBattleAttributeBuffItem, int> BuffsLayout;

		// Token: 0x0401B6D8 RID: 112344
		private List<int> BuffList = new List<int>();

		// Token: 0x0401B6D9 RID: 112345
		private int RoleId;
	}
}
