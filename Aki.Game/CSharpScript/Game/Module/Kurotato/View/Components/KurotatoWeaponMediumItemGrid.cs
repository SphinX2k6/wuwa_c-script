using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Components
{
	// Token: 0x02004748 RID: 18248
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoWeaponMediumItemGrid : LoopScrollMediumItemGrid<IKurotatoMediumItemGridData>
	{
		// Token: 0x0602DCE0 RID: 187616 RVA: 0x00CD1579 File Offset: 0x00CCF779
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		}

		// Token: 0x0602DCE1 RID: 187617 RVA: 0x00CD1587 File Offset: 0x00CCF787
		protected override void OnRefresh(IKurotatoMediumItemGridData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.Refresh(data, new bool?(isSelected));
		}

		// Token: 0x0602DCE2 RID: 187618 RVA: 0x00CD15A0 File Offset: 0x00CCF7A0
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

		// Token: 0x0602DCE3 RID: 187619 RVA: 0x00CD15FC File Offset: 0x00CCF7FC
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

		// Token: 0x0602DCE4 RID: 187620 RVA: 0x00CD16EC File Offset: 0x00CCF8EC
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

		// Token: 0x0602DCE5 RID: 187621 RVA: 0x00CD1816 File Offset: 0x00CCFA16
		public void BindCallback(Action<EToggleState> onSelectedCallback)
		{
			this.OnSelectedCallback = onSelectedCallback;
		}

		// Token: 0x0602DCE6 RID: 187622 RVA: 0x00CD181F File Offset: 0x00CCFA1F
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnSelectedCallback != null)
			{
				this.OnSelectedCallback(state);
			}
		}

		// Token: 0x0602DCE7 RID: 187623 RVA: 0x00CD1838 File Offset: 0x00CCFA38
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

		// Token: 0x0602DCE8 RID: 187624 RVA: 0x00CD18A1 File Offset: 0x00CCFAA1
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x0602DCE9 RID: 187625 RVA: 0x00CD18AB File Offset: 0x00CCFAAB
		public override object GetKey(IKurotatoMediumItemGridData data, int gridIndex)
		{
			return data.Id;
		}

		// Token: 0x040187C4 RID: 100292
		[Nullable(2)]
		public new IKurotatoMediumItemGridData Data;

		// Token: 0x040187C5 RID: 100293
		public new int GridIndex;

		// Token: 0x040187C6 RID: 100294
		public bool IsShowItemCount = true;

		// Token: 0x040187C7 RID: 100295
		public bool IsShowLock;

		// Token: 0x040187C8 RID: 100296
		public bool IsShowNew;

		// Token: 0x040187C9 RID: 100297
		[Nullable(2)]
		private Action<EToggleState> OnSelectedCallback;
	}
}
