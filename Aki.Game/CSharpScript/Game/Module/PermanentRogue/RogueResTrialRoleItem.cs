using System;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200430A RID: 17162
	public class RogueResTrialRoleItem : LoopScrollMediumItemGrid<int>
	{
		// Token: 0x0602B634 RID: 177716 RVA: 0x00C32118 File Offset: 0x00C30318
		protected override void OnRefresh(int roleId, bool isSelected, int gridIndex)
		{
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				ItemConfigId = new int?(roleId),
				SkinId = value.SkinId,
				BottomTextId = value.Name,
				ElementId = new int?(value.ElementId),
				Data = value
			};
			base.Apply<CharacterMediumItemGrid>(parameters);
		}
	}
}
