using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E38 RID: 15928
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RougeBattleAttributeFetterItem : GridProxyAbstract<IRogueBattleMapAttrFettersInfo>
	{
		// Token: 0x06028979 RID: 166265 RVA: 0x00B643D4 File Offset: 0x00B625D4
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

		// Token: 0x0602897A RID: 166266 RVA: 0x00B64454 File Offset: 0x00B62654
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

		// Token: 0x0602897B RID: 166267 RVA: 0x00B644E0 File Offset: 0x00B626E0
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

		// Token: 0x040160B1 RID: 90289
		private int BondId;
	}
}
