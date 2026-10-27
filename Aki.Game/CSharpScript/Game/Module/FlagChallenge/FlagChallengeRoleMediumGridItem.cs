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
	// Token: 0x02005A72 RID: 23154
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeRoleMediumGridItem : GridProxyAbstract<RoleDataBase>
	{
		// Token: 0x0603AAB0 RID: 240304 RVA: 0x00DF8689 File Offset: 0x00DF6889
		public void SetCanSelectRole(Func<int, EToggleState, bool> callback)
		{
			this.CanSelectRole = callback;
		}

		// Token: 0x0603AAB1 RID: 240305 RVA: 0x00DF8692 File Offset: 0x00DF6892
		public void SetOnSelectRole(Action<int, EToggleState> callback)
		{
			this.OnSelectRole = callback;
		}

		// Token: 0x0603AAB2 RID: 240306 RVA: 0x00DF869C File Offset: 0x00DF689C
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeRoleMediumGridItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeRoleMediumGridItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AAB3 RID: 240307 RVA: 0x00DF86DF File Offset: 0x00DF68DF
		public override void Refresh(RoleDataBase data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshView(data);
		}

		// Token: 0x0603AAB4 RID: 240308 RVA: 0x00DF86F0 File Offset: 0x00DF68F0
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

		// Token: 0x0603AAB5 RID: 240309 RVA: 0x00DF87D8 File Offset: 0x00DF69D8
		[NullableContext(2)]
		private bool OnCanExecuteChangeEvent(object data, bool isForceSelected, EToggleState state)
		{
			Func<int, EToggleState, bool> canSelectRole = this.CanSelectRole;
			return canSelectRole == null || canSelectRole((data as RoleDataBase).GetDataId(), state);
		}

		// Token: 0x0603AAB6 RID: 240310 RVA: 0x00DF87F7 File Offset: 0x00DF69F7
		private void OnClickEvent(MediumItemGridExtendCallback callback)
		{
			Action<int, EToggleState> onSelectRole = this.OnSelectRole;
			if (onSelectRole == null)
			{
				return;
			}
			onSelectRole(this.Data.GetDataId(), callback.State);
		}

		// Token: 0x0401E9C4 RID: 125380
		[Nullable(2)]
		private RoleDataBase Data;

		// Token: 0x0401E9C5 RID: 125381
		[Nullable(2)]
		private MediumItemGrid MediumItemGrid;

		// Token: 0x0401E9C6 RID: 125382
		[Nullable(2)]
		private Func<int, EToggleState, bool> CanSelectRole;

		// Token: 0x0401E9C7 RID: 125383
		[Nullable(2)]
		private Action<int, EToggleState> OnSelectRole;
	}
}
