using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E9A RID: 20122
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleSettleInfoRoleGrid : LoopScrollMediumItemGrid<RogueResGainData>
	{
		// Token: 0x06033B94 RID: 211860 RVA: 0x00C1DE64 File Offset: 0x00C1C064
		protected override void OnRefresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(data.RogueResRole.RoleIdOrTrialRoleId, true);
			if (roleDataById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.LPH;
				string message = "刷新角色信息失败，角色配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId:", data.RogueResRole.RoleIdOrTrialRoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				ItemConfigId = new int?(data.RogueResRole.RoleIdOrTrialRoleId),
				SkinId = roleDataById.GetRoleSkinId(),
				ElementId = new int?(roleDataById.GetElementInfo().Value.Id),
				Data = data,
				IsTrialRoleVisible = new bool?(roleDataById.IsTrialRole())
			};
			base.Apply<CharacterMediumItemGrid>(parameters);
			ItemGridComponent component = base.RefreshComponent(typeof(<RogueBattleSettleInfoRoleGrid>F4C055BC0C396696E7E5BAE8054587EF69924311750C95E1C4B8449D42628F438__RogueBattleSettleInfoRoleGridLevelComponent), new bool?(true), data);
			base.SetComponentVisible(component, true);
		}
	}
}
