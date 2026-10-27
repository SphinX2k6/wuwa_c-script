using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E5F RID: 20063
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFilterDropDownItem : DropDownItemBase<RoleBondInfo>
	{
		// Token: 0x06033AE6 RID: 211686 RVA: 0x00C19D59 File Offset: 0x00C17F59
		public RogueBattleFilterDropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06033AE7 RID: 211687 RVA: 0x00C19D64 File Offset: 0x00C17F64
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06033AE8 RID: 211688 RVA: 0x00C19DEA File Offset: 0x00C17FEA
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06033AE9 RID: 211689 RVA: 0x00C19DF4 File Offset: 0x00C17FF4
		protected override void OnShowDropDownItemBase(RoleBondInfo fetterInfo)
		{
			if (fetterInfo.ConfigId == 0)
			{
				this.SetFetterAllSelect();
				return;
			}
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(fetterInfo.ConfigId);
			if (rogueResBond == null)
			{
				return;
			}
			bool uiactive = RogueBattleModel.Instance.IsBondLinkCanActivate(fetterInfo.ConfigId);
			UUITexture texture = base.GetTexture(2);
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueResBond.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "RogueResSynergyLV", new <>z__ReadOnlySingleElementList<object>(fetterInfo.Level));
			base.GetText(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(uiactive);
		}

		// Token: 0x06033AEA RID: 211690 RVA: 0x00C19EC0 File Offset: 0x00C180C0
		private void SetFetterAllSelect()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RogueSelectAll");
			base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(2), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueRes_BondSelect_Desc", Array.Empty<object>());
			base.GetText(3).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}
	}
}
