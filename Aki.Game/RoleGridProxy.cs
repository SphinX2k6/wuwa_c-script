using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000634 RID: 1588
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RoleGridProxy : GridProxyAbstract<RoleData>
{
	// Token: 0x06004A0E RID: 18958 RVA: 0x00192EC0 File Offset: 0x001910C0
	protected override void OnStart()
	{
		AActor rootActor = base.GetRootActor();
		if (rootActor == null)
		{
			return;
		}
		this.RoleGrid = new SmallItemGrid();
		this.RoleGrid.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x00192EF0 File Offset: 0x001910F0
	public override void Refresh(RoleData data, bool isSelected, int gridIndex)
	{
		if (this.RoleGrid == null)
		{
			return;
		}
		if (data.RoleId > 0)
		{
			RoleConfig instance = RoleConfig.Instance;
			RoleInfo? roleInfo = (instance != null) ? instance.GetRoleConfig(data.RoleId) : null;
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = null,
				ItemConfigId = new int?(data.RoleId),
				SkinId = new int?(0),
				ElementId = new int?((roleInfo != null) ? roleInfo.GetValueOrDefault().ElementId : 0),
				BottomTextId = "Text_LevelShow_Text",
				BottomTextParameter = new object[]
				{
					data.RoleLevel
				}
			};
			this.RoleGrid.ApplyCharacterSmallItemGrid(parameters);
			UUIExtendToggle itemGridExtendToggle = this.RoleGrid.GetItemGridExtendToggle();
			if (itemGridExtendToggle != null)
			{
				itemGridExtendToggle.SetActive(false, false);
			}
			this.RoleGrid.SetExtendToggleEnable(false, false);
			return;
		}
		EmptySmallItemGrid parameters2 = new EmptySmallItemGrid();
		this.RoleGrid.ApplyEmptyWithoutAddSmallItemGrid(parameters2);
		this.RoleGrid.SetExtendToggleEnable(false, false);
	}

	// Token: 0x06004A10 RID: 18960 RVA: 0x00192FFD File Offset: 0x001911FD
	public override object GetKey(RoleData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x040036E8 RID: 14056
	[Nullable(2)]
	private SmallItemGrid RoleGrid;
}
