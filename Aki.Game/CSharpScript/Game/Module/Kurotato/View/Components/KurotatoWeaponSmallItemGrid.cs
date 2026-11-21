using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Components
{
	// Token: 0x02004749 RID: 18249
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoWeaponSmallItemGrid : LoopScrollSmallItemGrid<IKurotatoSmallItemGridData>
	{
		// Token: 0x0602DCEB RID: 187627 RVA: 0x00CD18C7 File Offset: 0x00CCFAC7
		public KurotatoWeaponSmallItemGrid(bool needComposeFx = false)
		{
			this.NeedComposeFx = needComposeFx;
		}

		// Token: 0x0602DCEC RID: 187628 RVA: 0x00CD18D8 File Offset: 0x00CCFAD8
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			if (!this.NeedComposeFx)
			{
				return;
			}
			int num = this.ComponentRegisterInfos.FindIndex(([Nullable(new byte[]
			{
				0,
				1
			})] ValueTuple<int, Type> info) => info.Item1 == 11);
			if (num >= 0)
			{
				this.ComponentRegisterInfos[num] = new ValueTuple<int, Type>(11, typeof(UUINiagara));
				return;
			}
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUINiagara)));
		}

		// Token: 0x0602DCED RID: 187629 RVA: 0x00CD195D File Offset: 0x00CCFB5D
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		}

		// Token: 0x0602DCEE RID: 187630 RVA: 0x00CD196B File Offset: 0x00CCFB6B
		protected override void OnRefresh(IKurotatoSmallItemGridData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GridIndex = gridIndex;
			this.Refresh(data);
		}

		// Token: 0x0602DCEF RID: 187631 RVA: 0x00CD1984 File Offset: 0x00CCFB84
		public void Refresh(IKurotatoSmallItemGridData data)
		{
			this.Data = data;
			UUINiagara uiNiagara = base.GetUiNiagara(11);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			if (data.Id == 0)
			{
				PropSmallItemGrid parameters = new PropSmallItemGrid
				{
					Data = data,
					IsQualityHidden = new bool?(true)
				};
				base.Apply<PropSmallItemGrid>(parameters);
				return;
			}
			if (data.Type == EKurotatoCardType.Weapon)
			{
				this.RefreshWeapon(data);
			}
			else
			{
				this.RefreshItem(data);
			}
			if (data.PlayComposeFx.GetValueOrDefault())
			{
				this.PlayComposeFx();
			}
		}

		// Token: 0x0602DCF0 RID: 187632 RVA: 0x00CD1A04 File Offset: 0x00CCFC04
		private void RefreshWeapon(IKurotatoSmallItemGridData data)
		{
			int id = data.Id;
			KurotatoWeapon? weaponConfigByWeaponId = KurotatoConfig.Instance.GetWeaponConfigByWeaponId(id);
			if (weaponConfigByWeaponId == null)
			{
				return;
			}
			if (KurotatoConfig.Instance.GetQualityByQuality(weaponConfigByWeaponId.Value.Quality) == null)
			{
				return;
			}
			KurotatoSmallItemGrid parameters = new KurotatoSmallItemGrid
			{
				Id = id,
				Data = data,
				QualityId = new int?(weaponConfigByWeaponId.Value.Quality),
				BottomTextId = weaponConfigByWeaponId.Value.Name,
				CardType = EKurotatoCardType.Weapon,
				IsReceivedVisible = data.IsReceived
			};
			base.Apply<KurotatoSmallItemGrid>(parameters);
			base.SetBottomTextVisible(false);
			base.SetArrowVisible(data.ShowArrow.GetValueOrDefault());
		}

		// Token: 0x0602DCF1 RID: 187633 RVA: 0x00CD1AD0 File Offset: 0x00CCFCD0
		private void RefreshItem(IKurotatoSmallItemGridData data)
		{
			int id = data.Id;
			KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(id);
			if (itemConfigByItemId == null)
			{
				return;
			}
			if (KurotatoConfig.Instance.GetQualityByQuality(itemConfigByItemId.Value.Quality) == null)
			{
				return;
			}
			KurotatoSmallItemGrid parameters = new KurotatoSmallItemGrid
			{
				Id = id,
				Data = data,
				QualityId = new int?(itemConfigByItemId.Value.Quality),
				BottomTextId = itemConfigByItemId.Value.Name,
				CardType = EKurotatoCardType.Item,
				IsReceivedVisible = data.IsReceived,
				RightTopValue = (data.IsShowCount.GetValueOrDefault() ? ("x" + data.Count.ToString()) : null)
			};
			base.Apply<KurotatoSmallItemGrid>(parameters);
			base.SetBottomTextVisible(false);
		}

		// Token: 0x0602DCF2 RID: 187634 RVA: 0x00CD1BB8 File Offset: 0x00CCFDB8
		public void BindCallback(Action<IKurotatoSmallItemGridData, EToggleState, int> onSelectedCallback)
		{
			this.OnSelectedCallback = onSelectedCallback;
		}

		// Token: 0x0602DCF3 RID: 187635 RVA: 0x00CD1BC1 File Offset: 0x00CCFDC1
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnSelectedCallback != null)
			{
				this.OnSelectedCallback(this.Data, state, base.GridIndex);
			}
		}

		// Token: 0x0602DCF4 RID: 187636 RVA: 0x00CD1BE4 File Offset: 0x00CCFDE4
		private void PlayComposeFx()
		{
			if (this.Data == null || this.Data.Type != EKurotatoCardType.Weapon)
			{
				return;
			}
			KurotatoWeapon? weaponConfigByWeaponId = KurotatoConfig.Instance.GetWeaponConfigByWeaponId(this.Data.Id);
			if (weaponConfigByWeaponId == null)
			{
				return;
			}
			KurotatoQuality? qualityByQuality = KurotatoConfig.Instance.GetQualityByQuality(weaponConfigByWeaponId.Value.Quality);
			if (qualityByQuality == null)
			{
				return;
			}
			UUINiagara uiNiagara = base.GetUiNiagara(11);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
			FColor color = FColor.FromHex(qualityByQuality.Value.ItemGridNiagaraColor);
			uiNiagara.SetColor(color);
			uiNiagara.SetUIActive(true);
		}

		// Token: 0x040187CA RID: 100298
		[Nullable(2)]
		protected new IKurotatoSmallItemGridData Data;

		// Token: 0x040187CB RID: 100299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IKurotatoSmallItemGridData, EToggleState, int> OnSelectedCallback;

		// Token: 0x040187CC RID: 100300
		private readonly bool NeedComposeFx;

		// Token: 0x0200A395 RID: 41877
		[NullableContext(0)]
		private enum EKurotatoGridChildComp
		{
			// Token: 0x04032B5F RID: 207711
			ComposeNiagara = 11
		}
	}
}
