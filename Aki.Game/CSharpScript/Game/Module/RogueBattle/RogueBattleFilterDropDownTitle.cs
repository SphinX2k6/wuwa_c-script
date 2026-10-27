using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E61 RID: 20065
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFilterDropDownTitle : TitleItemBase<RoleBondInfo>
	{
		// Token: 0x06033AEB RID: 211691 RVA: 0x00C19F21 File Offset: 0x00C18121
		public RogueBattleFilterDropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06033AEC RID: 211692 RVA: 0x00C19F2C File Offset: 0x00C1812C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06033AED RID: 211693 RVA: 0x00C19F88 File Offset: 0x00C18188
		public override void ShowTemp(RoleBondInfo fetterInfo, DropDownItemBase<RoleBondInfo> selectedItemObj)
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
			UUITexture texture = base.GetTexture(1);
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueResBond.Value.Name, Array.Empty<object>());
			base.GetItem(2).SetUIActive(uiactive);
		}

		// Token: 0x06033AEE RID: 211694 RVA: 0x00C1A024 File Offset: 0x00C18224
		private void SetFetterAllSelect()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RogueSelectAll");
			base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(1), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueRes_BondSelect_Desc", Array.Empty<object>());
			base.GetItem(2).SetUIActive(false);
		}
	}
}
