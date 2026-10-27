using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E8E RID: 20110
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleRoleSelectFetterItem : GridProxyAbstract<RoleBondInfo>
	{
		// Token: 0x06033B7C RID: 211836 RVA: 0x00C1D398 File Offset: 0x00C1B598
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelect))
			};
		}

		// Token: 0x06033B7D RID: 211837 RVA: 0x00C1D444 File Offset: 0x00C1B644
		public override void Refresh(RoleBondInfo bondInfo, bool isSelected, int gridIndex)
		{
			int configId = bondInfo.ConfigId;
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(configId);
			this.BondInfo = bondInfo;
			int level = bondInfo.Level;
			RogueResBondLv? bondLvConfigByLv = RogueBattleConfig.Instance.GetBondLvConfigByLv(level);
			if (rogueResBond == null || bondLvConfigByLv == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(2);
			UUIText text = base.GetText(3);
			UUIText text2 = base.GetText(4);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = level == 0 && !isSelected;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, texture, null);
			UUISprite sprite = base.GetSprite(1);
			FColor color = FColor.FromHex(bondLvConfigByLv.Value.LvColor);
			sprite.SetColor(color);
			sprite.SetUIActive(level > 0 && !isSelected);
			text.SetColor(color);
			text2.SetColor(color);
			LguiUtil.Instance.SetLocalTextNew(text, "RogueResSynergyLV", new <>z__ReadOnlySingleElementList<object>(level));
			LguiUtil.Instance.SetLocalTextNew(text2, rogueResBond.Value.Name, Array.Empty<object>());
		}

		// Token: 0x06033B7E RID: 211838 RVA: 0x00C1D56B File Offset: 0x00C1B76B
		private void OnToggleSelect(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			Action<RoleBondInfo> onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this.BondInfo);
		}

		// Token: 0x06033B7F RID: 211839 RVA: 0x00C1D588 File Offset: 0x00C1B788
		public override void OnSelected(bool fireEvent)
		{
			UUIItem sprite = base.GetSprite(1);
			UUITexture texture = base.GetTexture(2);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = false;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			sprite.SetUIActive(false);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06033B80 RID: 211840 RVA: 0x00C1D5D0 File Offset: 0x00C1B7D0
		public override void OnDeselected(bool fireEvent)
		{
			int level = this.BondInfo.Level;
			UUIItem sprite = base.GetSprite(1);
			UUITexture texture = base.GetTexture(2);
			sprite.SetUIActive(level > 0);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = level == 0;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06033B81 RID: 211841 RVA: 0x00C1D62A File Offset: 0x00C1B82A
		public override object GetKey(RoleBondInfo data, int displayIndex)
		{
			return data.ConfigId;
		}

		// Token: 0x0401B757 RID: 112471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoleBondInfo> OnToggleClick;

		// Token: 0x0401B758 RID: 112472
		private RoleBondInfo BondInfo;
	}
}
