using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02004125 RID: 16677
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaRoleSkillItem : GridProxyAbstract<PhantomArenaRoleSkillItemData>
	{
		// Token: 0x0602A2A2 RID: 172706 RVA: 0x00BE7A57 File Offset: 0x00BE5C57
		public PhantomArenaRoleSkillItem()
		{
			base.GridIndex = -1;
		}

		// Token: 0x0602A2A3 RID: 172707 RVA: 0x00BE7A68 File Offset: 0x00BE5C68
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectInternal))
			};
		}

		// Token: 0x0602A2A4 RID: 172708 RVA: 0x00BE7AD0 File Offset: 0x00BE5CD0
		[NullableContext(1)]
		public override void Refresh(PhantomArenaRoleSkillItemData data, bool isSelected, int gridIndex)
		{
			base.GridIndex = gridIndex;
			this.Data = data;
			base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
			this.SetSelected(isSelected);
		}

		// Token: 0x0602A2A5 RID: 172709 RVA: 0x00BE7B0F File Offset: 0x00BE5D0F
		private void OnToggleSelectInternal(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> onToggleSelect = this.OnToggleSelect;
				if (onToggleSelect == null)
				{
					return;
				}
				onToggleSelect(base.GridIndex);
			}
		}

		// Token: 0x0602A2A6 RID: 172710 RVA: 0x00BE7B2B File Offset: 0x00BE5D2B
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602A2A7 RID: 172711 RVA: 0x00BE7B43 File Offset: 0x00BE5D43
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602A2A8 RID: 172712 RVA: 0x00BE7B5B File Offset: 0x00BE5D5B
		public void SetSelected(bool isSelected)
		{
			if (this.IsSelected == isSelected)
			{
				return;
			}
			this.IsSelected = isSelected;
			if (this.IsSelected)
			{
				this.OnSelected(false);
				return;
			}
			this.OnDeselected(false);
		}

		// Token: 0x04016F69 RID: 94057
		protected bool IsSelected;

		// Token: 0x04016F6A RID: 94058
		protected PhantomArenaRoleSkillItemData Data;

		// Token: 0x04016F6B RID: 94059
		public Action<int> OnToggleSelect;

		// Token: 0x02009CF3 RID: 40179
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030C9C RID: 199836
			public const int ItemToggle = 0;

			// Token: 0x04030C9D RID: 199837
			public const int SkillTexture = 1;
		}
	}
}
