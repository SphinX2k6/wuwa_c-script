using System;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200533A RID: 21306
	public class RogueResTrialRoleItem : LoopScrollMediumItemGrid<int>
	{
		// Token: 0x06036738 RID: 223032 RVA: 0x00CE4748 File Offset: 0x00CE2948
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
