using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E6B RID: 20075
	public class RougeBattleAttributeBuffItem : GridProxyAbstract<int>
	{
		// Token: 0x06033B03 RID: 211715 RVA: 0x00C1AAF0 File Offset: 0x00C18CF0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.OnClick))
			};
		}

		// Token: 0x06033B04 RID: 211716 RVA: 0x00C1AC50 File Offset: 0x00C18E50
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.BuffId = data;
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.SetSpriteByPath(RogueBattleConfig.Instance.GetRogueResCharacterBuff(this.BuffId).Value.AffixIcon, base.GetSprite(9), false, null, null);
		}

		// Token: 0x06033B05 RID: 211717 RVA: 0x00C1ACB1 File Offset: 0x00C18EB1
		private void OnClick(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(11);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			Action<int> onClickCall = this.OnClickCall;
			if (onClickCall == null)
			{
				return;
			}
			onClickCall(this.BuffId);
		}

		// Token: 0x0401B6D0 RID: 112336
		private int BuffId;

		// Token: 0x0401B6D1 RID: 112337
		[Nullable(2)]
		public Action<int> OnClickCall;
	}
}
