using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E2A RID: 15914
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFilterDropDownTitle : TitleItemBase<RoleBondInfo>
	{
		// Token: 0x06028956 RID: 166230 RVA: 0x00B63449 File Offset: 0x00B61649
		public RogueBattleFilterDropDownTitle(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06028957 RID: 166231 RVA: 0x00B63454 File Offset: 0x00B61654
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06028958 RID: 166232 RVA: 0x00B634B0 File Offset: 0x00B616B0
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

		// Token: 0x06028959 RID: 166233 RVA: 0x00B6354C File Offset: 0x00B6174C
		private void SetFetterAllSelect()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RogueSelectAll");
			base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(1), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueRes_BondSelect_Desc", Array.Empty<object>());
			base.GetItem(2).SetUIActive(false);
		}
	}
}
