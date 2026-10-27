using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Mail
{
	// Token: 0x020056A2 RID: 22178
	internal class RewardItem : LoopScrollSmallItemGrid<TItem>
	{
		// Token: 0x060386E7 RID: 231143 RVA: 0x00D65E71 File Offset: 0x00D64071
		protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
		{
			this.Refresh(data, isSelected, gridIndex);
		}

		// Token: 0x060386E8 RID: 231144 RVA: 0x00D65E7C File Offset: 0x00D6407C
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
		}

		// Token: 0x060386E9 RID: 231145 RVA: 0x00D65E90 File Offset: 0x00D64090
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x060386EA RID: 231146 RVA: 0x00D65E9C File Offset: 0x00D6409C
		public override void Refresh(TItem data, bool isSelected, int gridIndex)
		{
			InventoryDefine.IGetItemData itemData = data.ItemData;
			int count = data.Count;
			this.ConfigId = itemData.ItemId;
			MailBoxView onwner = this.Onwner;
			bool flag;
			if (onwner == null)
			{
				flag = false;
			}
			else
			{
				MailData selectedMailData = onwner.SelectedMailData;
				flag = (((selectedMailData != null) ? new EMailAttachment?(selectedMailData.GetAttachmentStatus()) : null).GetValueOrDefault() == EMailAttachment.AttachmentPicked);
			}
			bool value = flag;
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ConfigId));
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
			{
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.ConfigId);
				CharacterSmallItemGrid characterSmallItemGrid = new CharacterSmallItemGrid();
				characterSmallItemGrid.Data = data;
				characterSmallItemGrid.ElementId = new int?(roleConfig.Value.ElementId);
				characterSmallItemGrid.IsReceivedVisible = new bool?(value);
				characterSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
				string bottomText;
				if (count <= 0)
				{
					bottomText = "";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(count);
					bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				characterSmallItemGrid.BottomText = bottomText;
				characterSmallItemGrid.QualityId = new int?(roleConfig.Value.QualityId);
				CharacterSmallItemGrid parameters = characterSmallItemGrid;
				base.Apply<CharacterSmallItemGrid>(parameters);
				return;
			}
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.PhantomItem)
			{
				PhantomSmallItemGrid phantomSmallItemGrid = new PhantomSmallItemGrid();
				phantomSmallItemGrid.Data = data;
				phantomSmallItemGrid.IsReceivedVisible = new bool?(value);
				phantomSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
				string bottomText2;
				if (count <= 0)
				{
					bottomText2 = "";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(count);
					bottomText2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				phantomSmallItemGrid.BottomText = bottomText2;
				PhantomSmallItemGrid parameters2 = phantomSmallItemGrid;
				base.Apply<PhantomSmallItemGrid>(parameters2);
				return;
			}
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.IsReceivedVisible = new bool?(value);
			propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText3;
			if (count <= 0)
			{
				bottomText3 = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				bottomText3 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propSmallItemGrid.BottomText = bottomText3;
			PropSmallItemGrid parameters3 = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters3);
		}

		// Token: 0x0401DA32 RID: 121394
		[Nullable(1)]
		public MailBoxView Onwner;

		// Token: 0x0401DA33 RID: 121395
		private int ConfigId;
	}
}
