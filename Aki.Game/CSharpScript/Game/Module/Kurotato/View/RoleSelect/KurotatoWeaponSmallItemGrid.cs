using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.RoleSelect
{
	// Token: 0x02005736 RID: 22326
	public class KurotatoWeaponSmallItemGrid : LoopScrollSmallItemGrid<int>
	{
		// Token: 0x06038C23 RID: 232483 RVA: 0x00D79500 File Offset: 0x00D77700
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

		// Token: 0x06038C24 RID: 232484 RVA: 0x00D795D2 File Offset: 0x00D777D2
		[NullableContext(1)]
		public void SetToggleClickCallback(Action<int> callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x06038C25 RID: 232485 RVA: 0x00D795DB File Offset: 0x00D777DB
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

		// Token: 0x0401DC70 RID: 121968
		private int ItemId;

		// Token: 0x0401DC71 RID: 121969
		[Nullable(2)]
		private Action<int> ToggleClickCallback;
	}
}
