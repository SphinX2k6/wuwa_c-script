using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.HandBook
{
	// Token: 0x02004930 RID: 18736
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class HandBookRoleMediumItemGird : LoopScrollMediumItemGrid<RoleDataBase>
	{
		// Token: 0x0602EF93 RID: 192403 RVA: 0x00D1A308 File Offset: 0x00D18508
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

		// Token: 0x0602EF94 RID: 192404 RVA: 0x00D1A3D0 File Offset: 0x00D185D0
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

		// Token: 0x0602EF95 RID: 192405 RVA: 0x00D1A414 File Offset: 0x00D18614
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}
	}
}
