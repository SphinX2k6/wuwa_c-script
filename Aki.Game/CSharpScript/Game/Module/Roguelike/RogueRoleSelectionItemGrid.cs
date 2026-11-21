using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE5 RID: 15845
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueRoleSelectionItemGrid : LoopScrollMediumItemGrid<RoleDataBase>
	{
		// Token: 0x060287A7 RID: 165799 RVA: 0x00B58BE0 File Offset: 0x00B56DE0
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

		// Token: 0x060287A8 RID: 165800 RVA: 0x00B58CC0 File Offset: 0x00B56EC0
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

		// Token: 0x060287A9 RID: 165801 RVA: 0x00B58CF8 File Offset: 0x00B56EF8
		public void SetAddLevelComponent(int addLevel, int maxLevel, bool isShow)
		{
			int num = Math.Max((this.Data as RoleDataBase).GetLevelData().GetLevel(), addLevel);
			ItemGridComponent component = base.RefreshComponent(typeof(RogueAddLevelComponent), new bool?(true), num);
			base.SetComponentVisible(component, isShow);
		}

		// Token: 0x060287AA RID: 165802 RVA: 0x00B58D46 File Offset: 0x00B56F46
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}
	}
}
