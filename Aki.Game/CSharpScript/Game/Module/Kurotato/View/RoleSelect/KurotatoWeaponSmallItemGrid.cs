using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.RoleSelect
{
	// Token: 0x0200470D RID: 18189
	public class KurotatoWeaponSmallItemGrid : LoopScrollSmallItemGrid<int>
	{
		// Token: 0x0602DB33 RID: 187187 RVA: 0x00CC7BB0 File Offset: 0x00CC5DB0
		protected override void OnRefresh(int id, bool isSelected, int gridIndex)
		{
			if (id == 0)
			{
				PropSmallItemGrid parameters = new PropSmallItemGrid
				{
					Data = id,
					IsQualityHidden = new bool?(true)
				};
				base.SetUseFixedAsync(true);
				base.Apply<PropSmallItemGrid>(parameters);
				return;
			}
			this.ItemId = id;
			KurotatoWeapon? weaponConfigByWeaponId = KurotatoConfig.Instance.GetWeaponConfigByWeaponId(this.ItemId);
			if (weaponConfigByWeaponId == null)
			{
				return;
			}
			if (KurotatoConfig.Instance.GetQualityByQuality(weaponConfigByWeaponId.Value.Quality) == null)
			{
				return;
			}
			KurotatoSmallItemGrid parameters2 = new KurotatoSmallItemGrid
			{
				Id = this.ItemId,
				Data = id,
				QualityId = new int?(weaponConfigByWeaponId.Value.Quality),
				CardType = EKurotatoCardType.Weapon
			};
			base.SetUseFixedAsync(true);
			base.Apply<KurotatoSmallItemGrid>(parameters2);
		}

		// Token: 0x0602DB34 RID: 187188 RVA: 0x00CC7C82 File Offset: 0x00CC5E82
		[NullableContext(1)]
		public void SetToggleClickCallback(Action<int> callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x0602DB35 RID: 187189 RVA: 0x00CC7C8B File Offset: 0x00CC5E8B
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			this.SetSelected(false, false);
			if (this.ItemId != 0 && state == EToggleState.ETT_Checked)
			{
				Action<int> toggleClickCallback = this.ToggleClickCallback;
				if (toggleClickCallback == null)
				{
					return;
				}
				toggleClickCallback(this.ItemId);
			}
		}

		// Token: 0x04018706 RID: 100102
		private int ItemId;

		// Token: 0x04018707 RID: 100103
		[Nullable(2)]
		private Action<int> ToggleClickCallback;
	}
}
