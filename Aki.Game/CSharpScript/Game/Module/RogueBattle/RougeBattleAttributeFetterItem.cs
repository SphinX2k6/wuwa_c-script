using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E6F RID: 20079
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RougeBattleAttributeFetterItem : GridProxyAbstract<IRogueBattleMapAttrFettersInfo>
	{
		// Token: 0x06033B0E RID: 211726 RVA: 0x00C1AEB0 File Offset: 0x00C190B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x06033B0F RID: 211727 RVA: 0x00C1AF30 File Offset: 0x00C19130
		public override void Refresh(IRogueBattleMapAttrFettersInfo data, bool isSelected, int gridIndex)
		{
			this.BondId = data.ConfigId;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.SetTextureByPath(RogueBattleConfig.Instance.GetRogueResBond(data.ConfigId).Value.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x06033B10 RID: 211728 RVA: 0x00C1AFBC File Offset: 0x00C191BC
		private void OnClickToggle(EToggleState state)
		{
			RogueBattleModel.Instance.CurrentMapSummaryBond = this.BondId;
			RogueBattleModel.Instance.IsMapSummaryBondJumping = true;
			EventSystem.Instance.Emit(EEventName.RogueResMapSummaryTeamToBondUpdate);
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401B6DE RID: 112350
		private int BondId;
	}
}
