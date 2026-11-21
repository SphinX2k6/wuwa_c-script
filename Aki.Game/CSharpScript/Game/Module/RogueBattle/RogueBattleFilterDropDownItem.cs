using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E28 RID: 15912
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleFilterDropDownItem : DropDownItemBase<RoleBondInfo>
	{
		// Token: 0x06028951 RID: 166225 RVA: 0x00B63281 File Offset: 0x00B61481
		public RogueBattleFilterDropDownItem(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06028952 RID: 166226 RVA: 0x00B6328C File Offset: 0x00B6148C
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

		// Token: 0x06028953 RID: 166227 RVA: 0x00B63312 File Offset: 0x00B61512
		[NullableContext(2)]
		protected override UUIExtendToggle GetDropDownToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06028954 RID: 166228 RVA: 0x00B6331C File Offset: 0x00B6151C
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

		// Token: 0x06028955 RID: 166229 RVA: 0x00B633E8 File Offset: 0x00B615E8
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
