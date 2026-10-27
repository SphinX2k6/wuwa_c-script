using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E1C RID: 19996
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueRoleSelectionItemGrid : LoopScrollMediumItemGrid<RoleDataBase>
	{
		// Token: 0x0603393C RID: 211260 RVA: 0x00C0F6A8 File Offset: 0x00C0D8A8
		protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
		{
			int dataId = data.GetDataId();
			bool value = SceneTeamModel.Instance.GetTeamItem((long)dataId, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.ConfigId
			}) != null;
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.GetRoleId()),
				SkinId = data.GetRoleSkinId(),
				BottomTextId = "Text_LevelShow_Text",
				BottomTextParameter = new object[]
				{
					data.GetLevelData().GetLevel()
				},
				IsInTeam = new bool?(value),
				ElementId = new int?(data.GetRoleConfig().ElementId),
				IsTrialRoleVisible = new bool?(data.IsTrialRole()),
				IsNewVisible = new bool?(data.GetIsNew())
			};
			base.Apply<CharacterMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0603393D RID: 211261 RVA: 0x00C0F788 File Offset: 0x00C0D988
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
			base.SetNewVisible(new bool?(false));
			RoleDataBase roleDataBase = this.Data as RoleDataBase;
			if (roleDataBase != null)
			{
				roleDataBase.TryRemoveNewFlag();
			}
		}

		// Token: 0x0603393E RID: 211262 RVA: 0x00C0F7C0 File Offset: 0x00C0D9C0
		public void SetAddLevelComponent(int addLevel, int maxLevel, bool isShow)
		{
			int num = Math.Max((this.Data as RoleDataBase).GetLevelData().GetLevel(), addLevel);
			ItemGridComponent component = base.RefreshComponent(typeof(RogueAddLevelComponent), new bool?(true), num);
			base.SetComponentVisible(component, isShow);
		}

		// Token: 0x0603393F RID: 211263 RVA: 0x00C0F80E File Offset: 0x00C0DA0E
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}
	}
}
