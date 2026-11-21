using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E53 RID: 15955
	public class RogueBattleRoleAffixDetailToggle : GridProxyAbstract<int>
	{
		// Token: 0x060289D5 RID: 166357 RVA: 0x00B66481 File Offset: 0x00B64681
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x060289D6 RID: 166358 RVA: 0x00B664BA File Offset: 0x00B646BA
		private void OnClickExtendToggle(EToggleState _)
		{
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(base.GridIndex);
		}

		// Token: 0x060289D7 RID: 166359 RVA: 0x00B664D4 File Offset: 0x00B646D4
		public override void Refresh(int id, bool isSelected, int gridIndex)
		{
			this.Id = id;
			RogueResCharacterBuff? rogueResCharacterBuff = RogueBattleConfig.Instance.GetRogueResCharacterBuff(id);
			if (rogueResCharacterBuff == null)
			{
				return;
			}
			this.SetSpriteByPath(rogueResCharacterBuff.Value.AffixIcon, base.GetSprite(0), false, null, null);
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
			extendToggle2.OnStateChange.Clear();
			extendToggle2.OnStateChange.Add(new Action<EToggleState>(this.OnClickExtendToggle));
		}

		// Token: 0x060289D8 RID: 166360 RVA: 0x00B6656A File Offset: 0x00B6476A
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060289D9 RID: 166361 RVA: 0x00B6657D File Offset: 0x00B6477D
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04016118 RID: 90392
		public int Id;

		// Token: 0x04016119 RID: 90393
		[Nullable(2)]
		public Action<int> OnSelectCallback;
	}
}
