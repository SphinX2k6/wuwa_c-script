using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A4E RID: 19022
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeRoleMediumGridItem : GridProxyAbstract<RoleDataBase>
	{
		// Token: 0x0602F9F9 RID: 195065 RVA: 0x00D48C0D File Offset: 0x00D46E0D
		public void SetCanSelectRole(Func<int, EToggleState, bool> callback)
		{
			this.CanSelectRole = callback;
		}

		// Token: 0x0602F9FA RID: 195066 RVA: 0x00D48C16 File Offset: 0x00D46E16
		public void SetOnSelectRole(Action<int, EToggleState> callback)
		{
			this.OnSelectRole = callback;
		}

		// Token: 0x0602F9FB RID: 195067 RVA: 0x00D48C20 File Offset: 0x00D46E20
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeRoleMediumGridItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeRoleMediumGridItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9FC RID: 195068 RVA: 0x00D48C63 File Offset: 0x00D46E63
		public override void Refresh(RoleDataBase data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshView(data);
		}

		// Token: 0x0602F9FD RID: 195069 RVA: 0x00D48C74 File Offset: 0x00D46E74
		private void RefreshView(RoleDataBase data)
		{
			int dataId = data.GetDataId();
			RoleInfo roleConfig = data.GetRoleConfig();
			int roleSkinId = data.GetRoleSkinId();
			int roleIndex = RoleSelectModel.Instance.GetRoleIndex(dataId);
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				ItemConfigId = new int?(dataId),
				SkinId = roleSkinId,
				Index = new int?((roleIndex > 0) ? roleIndex : 0),
				ElementId = new int?(roleConfig.ElementId),
				Data = data,
				IsTrialRoleVisible = new bool?(data.IsTrialRole()),
				BottomTextId = "Text_LevelShow_Text",
				BottomTextParameter = new object[]
				{
					data.GetLevelData().GetLevel()
				}
			};
			this.MediumItemGrid.Apply<CharacterMediumItemGrid>(parameters);
			bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
			this.MediumItemGrid.SetSelected(bSelected, true);
		}

		// Token: 0x0602F9FE RID: 195070 RVA: 0x00D48D5C File Offset: 0x00D46F5C
		[NullableContext(2)]
		private bool OnCanExecuteChangeEvent(object data, bool isForceSelected, EToggleState state)
		{
			Func<int, EToggleState, bool> canSelectRole = this.CanSelectRole;
			return canSelectRole == null || canSelectRole((data as RoleDataBase).GetDataId(), state);
		}

		// Token: 0x0602F9FF RID: 195071 RVA: 0x00D48D7B File Offset: 0x00D46F7B
		private void OnClickEvent(MediumItemGridExtendCallback callback)
		{
			Action<int, EToggleState> onSelectRole = this.OnSelectRole;
			if (onSelectRole == null)
			{
				return;
			}
			onSelectRole(this.Data.GetDataId(), callback.State);
		}

		// Token: 0x0401946B RID: 103531
		[Nullable(2)]
		private RoleDataBase Data;

		// Token: 0x0401946C RID: 103532
		[Nullable(2)]
		private MediumItemGrid MediumItemGrid;

		// Token: 0x0401946D RID: 103533
		[Nullable(2)]
		private Func<int, EToggleState, bool> CanSelectRole;

		// Token: 0x0401946E RID: 103534
		[Nullable(2)]
		private Action<int, EToggleState> OnSelectRole;
	}
}
