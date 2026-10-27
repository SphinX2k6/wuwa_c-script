using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D40 RID: 19776
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectMaterialListItem : LoopScrollSmallItemGrid<RoleDevelopNeedItem>
	{
		// Token: 0x06033186 RID: 209286 RVA: 0x00BE805C File Offset: 0x00BE625C
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

		// Token: 0x06033187 RID: 209287 RVA: 0x00BE8148 File Offset: 0x00BE6348
		protected override void OnExtendToggleClicked()
		{
			RoleDevelopNeedItem roleDevelopNeedItem = this.Data as RoleDevelopNeedItem;
			if (roleDevelopNeedItem == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(roleDevelopNeedItem.ItemId, true, null);
		}

		// Token: 0x06033188 RID: 209288 RVA: 0x00BE8177 File Offset: 0x00BE6377
		protected override bool OnCanExecuteChange()
		{
			return false;
		}
	}
}
