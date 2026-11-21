using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E51 RID: 15953
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleRandomEventItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x060289CF RID: 166351 RVA: 0x00B66384 File Offset: 0x00B64584
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

		// Token: 0x060289D0 RID: 166352 RVA: 0x00B66401 File Offset: 0x00B64601
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

		// Token: 0x060289D1 RID: 166353 RVA: 0x00B6642F File Offset: 0x00B6462F
		public override void Refresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
		}

		// Token: 0x060289D2 RID: 166354 RVA: 0x00B66438 File Offset: 0x00B64638
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			RogueBattleModel.Instance.SelectGainData = this.Data;
		}

		// Token: 0x060289D3 RID: 166355 RVA: 0x00B6645B File Offset: 0x00B6465B
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			RogueBattleModel.Instance.SelectGainData = null;
		}

		// Token: 0x04016114 RID: 90388
		[Nullable(2)]
		public RogueResGainData Data;
	}
}
