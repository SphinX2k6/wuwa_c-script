using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001180 RID: 4480
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RoleGridProxy : GridProxyAbstract<RoleData>
{
	// Token: 0x06007677 RID: 30327 RVA: 0x0018A310 File Offset: 0x00188510
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

	// Token: 0x06007678 RID: 30328 RVA: 0x0018A340 File Offset: 0x00188540
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

	// Token: 0x06007679 RID: 30329 RVA: 0x0018A44D File Offset: 0x0018864D
	public override object GetKey(RoleData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x0400364F RID: 13903
	[Nullable(2)]
	private SmallItemGrid RoleGrid;
}
