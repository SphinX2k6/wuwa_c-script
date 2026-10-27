using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006051 RID: 24657
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorWeaponExhibitGrid : LoopScrollMediumItemGrid<SpringManorWeaponExhibitItem>
	{
		// Token: 0x0603E64D RID: 255565 RVA: 0x00F11E69 File Offset: 0x00F10069
		public void BindOnWeaponSelected(Action<int, int> callback)
		{
			this.OnWeaponSelectedCallback = callback;
		}

		// Token: 0x0603E64E RID: 255566 RVA: 0x00F11E72 File Offset: 0x00F10072
		public override void OnSelected(bool _)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0603E64F RID: 255567 RVA: 0x00F11E7C File Offset: 0x00F1007C
		public override void OnDeselected(bool _)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0603E650 RID: 255568 RVA: 0x00F11E88 File Offset: 0x00F10088
		protected override void OnRefresh(SpringManorWeaponExhibitItem data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			WeaponConfig instance = WeaponConfig.Instance;
			WeaponConf? weaponConf;
			string bottomTextId = ((instance != null) ? ((instance.GetWeaponConfigByItemId(data.ConfigId) != null) ? weaponConf.GetValueOrDefault().WeaponName : null) : null) ?? "";
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				ItemConfigId = new int?(data.ConfigId),
				IsCheckTick = new bool?(data.IsSelected),
				BottomTextId = bottomTextId
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0603E651 RID: 255569 RVA: 0x00F11F17 File Offset: 0x00F10117
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnWeaponSelectedCallback != null && this.CurrentData != null)
			{
				this.OnWeaponSelectedCallback(this.CurrentData.ConfigId, base.GridIndex);
			}
		}

		// Token: 0x04020995 RID: 133525
		[Nullable(2)]
		private Action<int, int> OnWeaponSelectedCallback;

		// Token: 0x04020996 RID: 133526
		[Nullable(2)]
		private SpringManorWeaponExhibitItem CurrentData;
	}
}
