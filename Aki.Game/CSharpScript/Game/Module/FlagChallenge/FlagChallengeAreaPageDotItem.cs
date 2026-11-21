using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A26 RID: 18982
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeAreaPageDotItem : GridProxyAbstract<IFlagChallengeAreaPageDotItemData>
	{
		// Token: 0x0602F922 RID: 194850 RVA: 0x00D443F9 File Offset: 0x00D425F9
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x0602F923 RID: 194851 RVA: 0x00D4441C File Offset: 0x00D4261C
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetSelfInteractive(false);
		}

		// Token: 0x0602F924 RID: 194852 RVA: 0x00D4442C File Offset: 0x00D4262C
		public override void Refresh(IFlagChallengeAreaPageDotItemData data, bool isSelected, int gridIndex)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			EToggleState state = data.IsHighlight ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}
	}
}
