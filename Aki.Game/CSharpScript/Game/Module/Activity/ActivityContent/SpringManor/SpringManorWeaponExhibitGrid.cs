using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FCF RID: 20431
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorWeaponExhibitGrid : LoopScrollMediumItemGrid<SpringManorWeaponExhibitItem>
	{
		// Token: 0x06033311 RID: 209681 RVA: 0x00E58C2D File Offset: 0x00E56E2D
		public void BindOnWeaponSelected(Action<int, int> callback)
		{
			this.OnWeaponSelectedCallback = callback;
		}

		// Token: 0x06033312 RID: 209682 RVA: 0x00E58C36 File Offset: 0x00E56E36
		public override void OnSelected(bool _)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06033313 RID: 209683 RVA: 0x00E58C40 File Offset: 0x00E56E40
		public override void OnDeselected(bool _)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06033314 RID: 209684 RVA: 0x00E58C4C File Offset: 0x00E56E4C
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

		// Token: 0x06033315 RID: 209685 RVA: 0x00E58CDB File Offset: 0x00E56EDB
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnWeaponSelectedCallback != null && this.CurrentData != null)
			{
				this.OnWeaponSelectedCallback(this.CurrentData.ConfigId, base.GridIndex);
			}
		}

		// Token: 0x0401B2C2 RID: 111298
		[Nullable(2)]
		private Action<int, int> OnWeaponSelectedCallback;

		// Token: 0x0401B2C3 RID: 111299
		[Nullable(2)]
		private SpringManorWeaponExhibitItem CurrentData;
	}
}
