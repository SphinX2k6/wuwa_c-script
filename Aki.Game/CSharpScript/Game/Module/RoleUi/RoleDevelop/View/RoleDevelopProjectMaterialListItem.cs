using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CFF RID: 15615
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectMaterialListItem : LoopScrollSmallItemGrid<RoleDevelopNeedItem>
	{
		// Token: 0x06027F9B RID: 163739 RVA: 0x00B2F208 File Offset: 0x00B2D408
		protected override void OnRefresh(RoleDevelopNeedItem data, bool isSelected, int gridIndex)
		{
			if (RoleDevelopUtil.IsUnknownItem(data.ItemId))
			{
				base.SetIconByPath(RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.UnknownItemIcon ?? "");
				base.SetToggleInteractive(false);
				base.SetBottomTextVisible(false);
				base.SetQuality(null);
				return;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(data.ItemId, 0);
			string bottomText = StringUtils.Format((itemCountByConfigId >= data.Count) ? "<color=#f7eba6>{0}</color>/{1}" : "<color=#f55e66>{0}</color>/{1}", new string[]
			{
				itemCountByConfigId.ToString(),
				data.Count.ToString()
			});
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				ItemConfigId = new int?(data.ItemId),
				BottomText = bottomText,
				Data = data
			};
			base.Apply<PropSmallItemGrid>(parameters);
			base.SetToggleInteractive(true);
		}

		// Token: 0x06027F9C RID: 163740 RVA: 0x00B2F2F4 File Offset: 0x00B2D4F4
		protected override void OnExtendToggleClicked()
		{
			RoleDevelopNeedItem roleDevelopNeedItem = this.Data as RoleDevelopNeedItem;
			if (roleDevelopNeedItem == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(roleDevelopNeedItem.ItemId, true, null, false);
		}

		// Token: 0x06027F9D RID: 163741 RVA: 0x00B2F324 File Offset: 0x00B2D524
		protected override bool OnCanExecuteChange()
		{
			return false;
		}
	}
}
