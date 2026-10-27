using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02005155 RID: 20821
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaRoleSkillItem : GridProxyAbstract<PhantomArenaRoleSkillItemData>
	{
		// Token: 0x060353A6 RID: 218022 RVA: 0x00C9A557 File Offset: 0x00C98757
		public PhantomArenaRoleSkillItem()
		{
			base.GridIndex = -1;
		}

		// Token: 0x060353A7 RID: 218023 RVA: 0x00C9A568 File Offset: 0x00C98768
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

		// Token: 0x060353A8 RID: 218024 RVA: 0x00C9A5D0 File Offset: 0x00C987D0
		[NullableContext(1)]
		public override void Refresh(PhantomArenaRoleSkillItemData data, bool isSelected, int gridIndex)
		{
			base.GridIndex = gridIndex;
			this.Data = data;
			base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
			this.SetSelected(isSelected);
		}

		// Token: 0x060353A9 RID: 218025 RVA: 0x00C9A60F File Offset: 0x00C9880F
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

		// Token: 0x060353AA RID: 218026 RVA: 0x00C9A62B File Offset: 0x00C9882B
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060353AB RID: 218027 RVA: 0x00C9A643 File Offset: 0x00C98843
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060353AC RID: 218028 RVA: 0x00C9A65B File Offset: 0x00C9885B
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

		// Token: 0x0401C534 RID: 116020
		protected bool IsSelected;

		// Token: 0x0401C535 RID: 116021
		protected PhantomArenaRoleSkillItemData Data;

		// Token: 0x0401C536 RID: 116022
		public Action<int> OnToggleSelect;

		// Token: 0x0200B2BA RID: 45754
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036247 RID: 221767
			public const int ItemToggle = 0;

			// Token: 0x04036248 RID: 221768
			public const int SkillTexture = 1;
		}
	}
}
