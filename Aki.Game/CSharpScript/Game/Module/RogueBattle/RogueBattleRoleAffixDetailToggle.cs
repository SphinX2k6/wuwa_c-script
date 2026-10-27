using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E8A RID: 20106
	public class RogueBattleRoleAffixDetailToggle : GridProxyAbstract<int>
	{
		// Token: 0x06033B6A RID: 211818 RVA: 0x00C1CF65 File Offset: 0x00C1B165
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x06033B6B RID: 211819 RVA: 0x00C1CF9E File Offset: 0x00C1B19E
		private void OnClickExtendToggle(EToggleState _)
		{
			Action<int> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(base.GridIndex);
		}

		// Token: 0x06033B6C RID: 211820 RVA: 0x00C1CFB8 File Offset: 0x00C1B1B8
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

		// Token: 0x06033B6D RID: 211821 RVA: 0x00C1D04E File Offset: 0x00C1B24E
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033B6E RID: 211822 RVA: 0x00C1D061 File Offset: 0x00C1B261
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401B745 RID: 112453
		public int Id;

		// Token: 0x0401B746 RID: 112454
		[Nullable(2)]
		public Action<int> OnSelectCallback;
	}
}
