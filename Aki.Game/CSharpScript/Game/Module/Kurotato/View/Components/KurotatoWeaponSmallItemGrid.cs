using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Components
{
	// Token: 0x02005772 RID: 22386
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoWeaponSmallItemGrid : LoopScrollSmallItemGrid<IKurotatoSmallItemGridData>
	{
		// Token: 0x06038DDB RID: 232923 RVA: 0x00D82DCB File Offset: 0x00D80FCB
		public KurotatoWeaponSmallItemGrid(bool needComposeFx = false)
		{
			this.NeedComposeFx = needComposeFx;
		}

		// Token: 0x06038DDC RID: 232924 RVA: 0x00D82DDC File Offset: 0x00D80FDC
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

		// Token: 0x06038DDD RID: 232925 RVA: 0x00D82E61 File Offset: 0x00D81061
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		}

		// Token: 0x06038DDE RID: 232926 RVA: 0x00D82E6F File Offset: 0x00D8106F
		protected override void OnRefresh(IKurotatoSmallItemGridData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GridIndex = gridIndex;
			this.Refresh(data);
		}

		// Token: 0x06038DDF RID: 232927 RVA: 0x00D82E88 File Offset: 0x00D81088
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

		// Token: 0x06038DE0 RID: 232928 RVA: 0x00D82F08 File Offset: 0x00D81108
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

		// Token: 0x06038DE1 RID: 232929 RVA: 0x00D82FD4 File Offset: 0x00D811D4
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

		// Token: 0x06038DE2 RID: 232930 RVA: 0x00D830BC File Offset: 0x00D812BC
		public void BindCallback(Action<IKurotatoSmallItemGridData, EToggleState, int> onSelectedCallback)
		{
			this.OnSelectedCallback = onSelectedCallback;
		}

		// Token: 0x06038DE3 RID: 232931 RVA: 0x00D830C5 File Offset: 0x00D812C5
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnSelectedCallback != null)
			{
				this.OnSelectedCallback(this.Data, state, base.GridIndex);
			}
		}

		// Token: 0x06038DE4 RID: 232932 RVA: 0x00D830E8 File Offset: 0x00D812E8
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

		// Token: 0x0401DD34 RID: 122164
		[Nullable(2)]
		protected new IKurotatoSmallItemGridData Data;

		// Token: 0x0401DD35 RID: 122165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IKurotatoSmallItemGridData, EToggleState, int> OnSelectedCallback;

		// Token: 0x0401DD36 RID: 122166
		private readonly bool NeedComposeFx;

		// Token: 0x0200B97B RID: 47483
		[NullableContext(0)]
		private enum EKurotatoGridChildComp
		{
			// Token: 0x04038165 RID: 229733
			ComposeNiagara = 11
		}
	}
}
