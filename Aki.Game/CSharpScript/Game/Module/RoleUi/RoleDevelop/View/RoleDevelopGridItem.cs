using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D36 RID: 19766
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopGridItem : LoopScrollMediumItemGrid<RoleDevelopData>
	{
		// Token: 0x0603312B RID: 209195 RVA: 0x00BE663F File Offset: 0x00BE483F
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x0603312C RID: 209196 RVA: 0x00BE6649 File Offset: 0x00BE4849
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x0603312D RID: 209197 RVA: 0x00BE6654 File Offset: 0x00BE4854
		protected override void OnRefresh(RoleDevelopData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			int id = data.GetId();
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
			string text = data.GetDevelopRoleData().GetName();
			bool flag = RoleModel.Instance.IsRoleOwned(id);
			bool flag2 = RoleDevelopModel.Instance.DevTargetRoleId == id;
			bool value = SceneTeamModel.Instance.GetTeamItem((long)id, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.ConfigId,
				OnlyMyRole = new bool?(true)
			}) != null;
			if (flag)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
				text = ConfigMultiTextLang.GetLocalTextNew("Text_LevelShow_Text", null);
				text = StringUtils.Format(text, new string[]
				{
					roleDataById.GetLevelData().GetLevel().ToString()
				});
			}
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(id);
			int skinId = (roleSkinDataByRoleId != null) ? roleSkinDataByRoleId.GetItemId() : roleConfig.Value.SkinId;
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(id),
				SkinId = skinId,
				BottomText = text,
				ElementId = new int?(roleConfig.Value.ElementId),
				IsShowLock = new bool?(!flag && !flag2),
				IsDisable = new bool?(!flag),
				IsRoleDevelopTagMark = new bool?(flag2),
				IsInTeam = new bool?(value)
			};
			base.SetUseFixedAsync(true);
			base.Apply<CharacterMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0603312E RID: 209198 RVA: 0x00BE67D3 File Offset: 0x00BE49D3
		public override object GetKey(RoleDevelopData data, int gridIndex)
		{
			return data.GetId();
		}
	}
}
