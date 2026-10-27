using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Components
{
	// Token: 0x02005771 RID: 22385
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoWeaponMediumItemGrid : LoopScrollMediumItemGrid<IKurotatoMediumItemGridData>
	{
		// Token: 0x06038DD0 RID: 232912 RVA: 0x00D82A7D File Offset: 0x00D80C7D
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		}

		// Token: 0x06038DD1 RID: 232913 RVA: 0x00D82A8B File Offset: 0x00D80C8B
		protected override void OnRefresh(IKurotatoMediumItemGridData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.Refresh(data, new bool?(isSelected));
		}

		// Token: 0x06038DD2 RID: 232914 RVA: 0x00D82AA4 File Offset: 0x00D80CA4
		public void Refresh(IKurotatoMediumItemGridData data, bool? isSelected = null)
		{
			this.Data = data;
			if (data.Type == EKurotatoCardType.Weapon)
			{
				this.RefreshWeapon(data);
			}
			else if (data.Type == EKurotatoCardType.Item)
			{
				this.RefreshItem(data);
			}
			else
			{
				base.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid());
			}
			if (isSelected != null)
			{
				this.SetSelected(isSelected.Value, true);
			}
		}

		// Token: 0x06038DD3 RID: 232915 RVA: 0x00D82B00 File Offset: 0x00D80D00
		private void RefreshWeapon(IKurotatoMediumItemGridData data)
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
			KurotatoWeaponData kurotatoWeaponData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoWeaponData(id);
			KurotatoMediumItemGrid parameters = new KurotatoMediumItemGrid
			{
				Id = id,
				Data = data,
				QualityId = new int?(weaponConfigByWeaponId.Value.Quality),
				BottomTextId = weaponConfigByWeaponId.Value.Name,
				CardType = EKurotatoCardType.Weapon,
				IsNewVisible = new bool?(this.IsShowNew && kurotatoWeaponData.HasRedDot),
				IsDisable = new bool?(this.IsShowLock && !kurotatoWeaponData.IsUnLock)
			};
			base.Apply<KurotatoMediumItemGrid>(parameters);
		}

		// Token: 0x06038DD4 RID: 232916 RVA: 0x00D82BF0 File Offset: 0x00D80DF0
		private void RefreshItem(IKurotatoMediumItemGridData data)
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
			KurotatoItemData kurotatoItemData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoItemData(id);
			KurotatoMediumItemGrid kurotatoMediumItemGrid = new KurotatoMediumItemGrid();
			kurotatoMediumItemGrid.Id = id;
			kurotatoMediumItemGrid.Data = data;
			kurotatoMediumItemGrid.QualityId = new int?(itemConfigByItemId.Value.Quality);
			kurotatoMediumItemGrid.BottomTextId = itemConfigByItemId.Value.Name;
			kurotatoMediumItemGrid.CardType = EKurotatoCardType.Item;
			kurotatoMediumItemGrid.IsNewVisible = new bool?(this.IsShowNew && kurotatoItemData.HasRedDot);
			kurotatoMediumItemGrid.IsDisable = new bool?(this.IsShowLock && !kurotatoItemData.IsUnLock);
			string rightTopValue;
			if (!this.IsShowItemCount)
			{
				rightTopValue = null;
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				rightTopValue = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			kurotatoMediumItemGrid.RightTopValue = rightTopValue;
			KurotatoMediumItemGrid parameters = kurotatoMediumItemGrid;
			base.Apply<KurotatoMediumItemGrid>(parameters);
		}

		// Token: 0x06038DD5 RID: 232917 RVA: 0x00D82D1A File Offset: 0x00D80F1A
		public void BindCallback(Action<EToggleState> onSelectedCallback)
		{
			this.OnSelectedCallback = onSelectedCallback;
		}

		// Token: 0x06038DD6 RID: 232918 RVA: 0x00D82D23 File Offset: 0x00D80F23
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnSelectedCallback != null)
			{
				this.OnSelectedCallback(state);
			}
		}

		// Token: 0x06038DD7 RID: 232919 RVA: 0x00D82D3C File Offset: 0x00D80F3C
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			if (this.Data.Type == EKurotatoCardType.Weapon)
			{
				activityData.GetKurotatoWeaponData(this.Data.Id).ReadRedDot(true);
			}
			else
			{
				activityData.GetKurotatoItemData(this.Data.Id).ReadRedDot(true);
			}
			base.SetNewVisible(new bool?(false));
		}

		// Token: 0x06038DD8 RID: 232920 RVA: 0x00D82DA5 File Offset: 0x00D80FA5
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x06038DD9 RID: 232921 RVA: 0x00D82DAF File Offset: 0x00D80FAF
		public override object GetKey(IKurotatoMediumItemGridData data, int gridIndex)
		{
			return data.Id;
		}

		// Token: 0x0401DD2E RID: 122158
		[Nullable(2)]
		public new IKurotatoMediumItemGridData Data;

		// Token: 0x0401DD2F RID: 122159
		public new int GridIndex;

		// Token: 0x0401DD30 RID: 122160
		public bool IsShowItemCount = true;

		// Token: 0x0401DD31 RID: 122161
		public bool IsShowLock;

		// Token: 0x0401DD32 RID: 122162
		public bool IsShowNew;

		// Token: 0x0401DD33 RID: 122163
		[Nullable(2)]
		private Action<EToggleState> OnSelectedCallback;
	}
}
