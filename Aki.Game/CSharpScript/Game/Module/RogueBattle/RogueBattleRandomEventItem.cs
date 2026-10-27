using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E88 RID: 20104
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleRandomEventItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x06033B64 RID: 211812 RVA: 0x00C1CE68 File Offset: 0x00C1B068
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnBtnExtendToggle))
			};
		}

		// Token: 0x06033B65 RID: 211813 RVA: 0x00C1CEE5 File Offset: 0x00C1B0E5
		private void OnBtnExtendToggle(EToggleState state)
		{
			if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked)
			{
				IScrollViewDelegate<IGridProxy<RogueResGainData>, RogueResGainData> scrollViewDelegate = base.ScrollViewDelegate;
				if (scrollViewDelegate == null)
				{
					return;
				}
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, true);
			}
		}

		// Token: 0x06033B66 RID: 211814 RVA: 0x00C1CF13 File Offset: 0x00C1B113
		public override void Refresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
		}

		// Token: 0x06033B67 RID: 211815 RVA: 0x00C1CF1C File Offset: 0x00C1B11C
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			RogueBattleModel.Instance.SelectGainData = this.Data;
		}

		// Token: 0x06033B68 RID: 211816 RVA: 0x00C1CF3F File Offset: 0x00C1B13F
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			RogueBattleModel.Instance.SelectGainData = null;
		}

		// Token: 0x0401B741 RID: 112449
		[Nullable(2)]
		public RogueResGainData Data;
	}
}
