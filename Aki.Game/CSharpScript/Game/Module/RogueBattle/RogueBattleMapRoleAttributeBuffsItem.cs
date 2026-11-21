using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E36 RID: 15926
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapRoleAttributeBuffsItem : UiPanelBase
	{
		// Token: 0x06028972 RID: 166258 RVA: 0x00B64214 File Offset: 0x00B62414
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

		// Token: 0x06028973 RID: 166259 RVA: 0x00B64284 File Offset: 0x00B62484
		protected override void OnStart()
		{
			this.BuffsLayout = new GenericLayout<RougeBattleAttributeBuffItem, int>(base.GetGridLayout(1), new Func<RougeBattleAttributeBuffItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x06028974 RID: 166260 RVA: 0x00B642A7 File Offset: 0x00B624A7
		private RougeBattleAttributeBuffItem CreateElement()
		{
			return new RougeBattleAttributeBuffItem
			{
				OnClickCall = new Action<int>(this.OnClickBuff)
			};
		}

		// Token: 0x06028975 RID: 166261 RVA: 0x00B642C0 File Offset: 0x00B624C0
		protected override void OnBeforeDestroy()
		{
			this.BuffsLayout = null;
		}

		// Token: 0x06028976 RID: 166262 RVA: 0x00B642CC File Offset: 0x00B624CC
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
				buffsLayout.RefreshByData(roleAffixs, null, false);
			}
			this.BuffList = new List<int>(roleAffixs);
		}

		// Token: 0x06028977 RID: 166263 RVA: 0x00B64370 File Offset: 0x00B62570
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

		// Token: 0x040160AA RID: 90282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RougeBattleAttributeBuffItem, int> BuffsLayout;

		// Token: 0x040160AB RID: 90283
		private List<int> BuffList = new List<int>();

		// Token: 0x040160AC RID: 90284
		private int RoleId;
	}
}
