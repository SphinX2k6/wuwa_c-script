using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.HandBook
{
	// Token: 0x02005957 RID: 22871
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class HandBookRoleMediumItemGird : LoopScrollMediumItemGrid<RoleDataBase>
	{
		// Token: 0x0603A070 RID: 237680 RVA: 0x00DCB054 File Offset: 0x00DC9254
		protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
		{
			bool flag = false;
			if (data.GetDataId() >= 100000)
			{
				flag = true;
			}
			bool value = data.GetIsNew();
			if (flag)
			{
				value = false;
			}
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.GetRoleId()),
				SkinId = data.GetRoleConfig().SkinId,
				BottomText = data.GetName(null),
				ElementId = new int?(data.GetRoleConfig().ElementId),
				IsNewVisible = new bool?(value),
				IsDisable = new bool?(flag),
				IsShowLock = new bool?(flag)
			};
			base.SetUseFixedAsync(true);
			base.Apply<CharacterMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0603A071 RID: 237681 RVA: 0x00DCB11C File Offset: 0x00DC931C
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
			base.SetNewVisible(new bool?(false));
			RoleDataBase roleDataBase = this.Data as RoleDataBase;
			if (roleDataBase != null && roleDataBase.GetRoleId() < 100000)
			{
				roleDataBase.TryRemoveNewFlag();
			}
		}

		// Token: 0x0603A072 RID: 237682 RVA: 0x00DCB160 File Offset: 0x00DC9360
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}
	}
}
