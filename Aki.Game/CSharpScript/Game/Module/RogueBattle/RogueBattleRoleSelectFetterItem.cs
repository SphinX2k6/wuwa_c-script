using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E57 RID: 15959
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleRoleSelectFetterItem : GridProxyAbstract<RoleBondInfo>
	{
		// Token: 0x060289E7 RID: 166375 RVA: 0x00B668B4 File Offset: 0x00B64AB4
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

		// Token: 0x060289E8 RID: 166376 RVA: 0x00B66960 File Offset: 0x00B64B60
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

		// Token: 0x060289E9 RID: 166377 RVA: 0x00B66A87 File Offset: 0x00B64C87
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

		// Token: 0x060289EA RID: 166378 RVA: 0x00B66AA4 File Offset: 0x00B64CA4
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

		// Token: 0x060289EB RID: 166379 RVA: 0x00B66AEC File Offset: 0x00B64CEC
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

		// Token: 0x060289EC RID: 166380 RVA: 0x00B66B46 File Offset: 0x00B64D46
		public override object GetKey(RoleBondInfo data, int displayIndex)
		{
			return data.ConfigId;
		}

		// Token: 0x0401612A RID: 90410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoleBondInfo> OnToggleClick;

		// Token: 0x0401612B RID: 90411
		private RoleBondInfo BondInfo;
	}
}
