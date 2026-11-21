using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E34 RID: 15924
	public class RougeBattleAttributeBuffItem : GridProxyAbstract<int>
	{
		// Token: 0x0602896E RID: 166254 RVA: 0x00B64018 File Offset: 0x00B62218
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

		// Token: 0x0602896F RID: 166255 RVA: 0x00B64178 File Offset: 0x00B62378
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

		// Token: 0x06028970 RID: 166256 RVA: 0x00B641D9 File Offset: 0x00B623D9
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

		// Token: 0x040160A3 RID: 90275
		private int BuffId;

		// Token: 0x040160A4 RID: 90276
		[Nullable(2)]
		public Action<int> OnClickCall;
	}
}
