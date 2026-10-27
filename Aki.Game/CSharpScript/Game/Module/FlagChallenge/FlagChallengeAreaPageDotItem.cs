using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A4A RID: 23114
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeAreaPageDotItem : GridProxyAbstract<IFlagChallengeAreaPageDotItemData>
	{
		// Token: 0x0603A9D9 RID: 240089 RVA: 0x00DF3E75 File Offset: 0x00DF2075
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x0603A9DA RID: 240090 RVA: 0x00DF3E98 File Offset: 0x00DF2098
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetSelfInteractive(false);
		}

		// Token: 0x0603A9DB RID: 240091 RVA: 0x00DF3EA8 File Offset: 0x00DF20A8
		public override void Refresh(IFlagChallengeAreaPageDotItemData data, bool isSelected, int gridIndex)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			EToggleState state = data.IsHighlight ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}
	}
}
