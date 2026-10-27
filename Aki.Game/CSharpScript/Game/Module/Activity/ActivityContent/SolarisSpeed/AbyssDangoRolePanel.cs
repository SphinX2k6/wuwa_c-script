using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060C6 RID: 24774
	[NullableContext(1)]
	[Nullable(0)]
	public class AbyssDangoRolePanel : SolarSpeedRolePanelBase
	{
		// Token: 0x0603EA33 RID: 256563 RVA: 0x00F207CC File Offset: 0x00F1E9CC
		private UniTask InitDescContent()
		{
			AbyssDangoRolePanel.<InitDescContent>d__4 <InitDescContent>d__;
			<InitDescContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescContent>d__.<>4__this = this;
			<InitDescContent>d__.<>1__state = -1;
			<InitDescContent>d__.<>t__builder.Start<AbyssDangoRolePanel.<InitDescContent>d__4>(ref <InitDescContent>d__);
			return <InitDescContent>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA34 RID: 256564 RVA: 0x00F2080F File Offset: 0x00F1EA0F
		private void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnAbyssLikeChange, new Action<int>(this.OnAbyssLikeChange));
		}

		// Token: 0x0603EA35 RID: 256565 RVA: 0x00F2082D File Offset: 0x00F1EA2D
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAbyssLikeChange, new Action<int>(this.OnAbyssLikeChange));
		}

		// Token: 0x0603EA36 RID: 256566 RVA: 0x00F2084C File Offset: 0x00F1EA4C
		private void OnAbyssLikeChange(int playerId)
		{
			int? currentPlayerId = this.CurrentPlayerId;
			if (currentPlayerId.GetValueOrDefault() == playerId & currentPlayerId != null)
			{
				int playerLikeCount = DangoAbyssModel.Instance.GetPlayerLikeCount(playerId);
				int? id = PlayerInfoModel.Instance.GetId();
				bool playerIfLikePlayer = DangoAbyssModel.Instance.GetPlayerIfLikePlayer(id.Value, playerId);
				this.LikeItem.Refresh(playerLikeCount, playerId, playerIfLikePlayer);
			}
		}

		// Token: 0x0603EA37 RID: 256567 RVA: 0x00F208B0 File Offset: 0x00F1EAB0
		protected override UniTask OnBeforeStartAsync()
		{
			AbyssDangoRolePanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AbyssDangoRolePanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA38 RID: 256568 RVA: 0x00F208F3 File Offset: 0x00F1EAF3
		protected override void OnStart()
		{
			this.AddEventListener();
		}

		// Token: 0x0603EA39 RID: 256569 RVA: 0x00F208FB File Offset: 0x00F1EAFB
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0603EA3A RID: 256570 RVA: 0x00F20904 File Offset: 0x00F1EB04
		private void RefreshAvatarTexture(IAbyssRolePanelData data)
		{
			string path = UiResourceConfig.Instance.GetResourceConfig(data.AvatarTexturePath).Value.Path;
			base.SetTextureByPath(path, base.GetTexture(14), null, null);
		}

		// Token: 0x0603EA3B RID: 256571 RVA: 0x00F2094C File Offset: 0x00F1EB4C
		private void RefreshLineTexture(IAbyssRolePanelData data)
		{
			string path = UiResourceConfig.Instance.GetResourceConfig(data.LineTexturePath).Value.Path;
			base.SetTextureByPath(path, base.GetTexture(15), null, null);
		}

		// Token: 0x0603EA3C RID: 256572 RVA: 0x00F20994 File Offset: 0x00F1EB94
		private void RefreshPlayerTitle(IAbyssRolePanelData data)
		{
			if (data.PlayerTitle != null)
			{
				int? playerTitle = data.PlayerTitle;
				int num = 0;
				if (playerTitle.GetValueOrDefault() > num & playerTitle != null)
				{
					base.GetItem(16).SetUIActive(true);
				}
			}
			this.PlayerTitleItem.Refresh(data.PlayerTitle, data.PlayerTitleStarLevel, new int?(data.Sex));
		}

		// Token: 0x0603EA3D RID: 256573 RVA: 0x00F20A00 File Offset: 0x00F1EC00
		private void RefreshBgTexture(IAbyssRolePanelData data)
		{
			string path = UiResourceConfig.Instance.GetResourceConfig(data.BgTexturePath).Value.Path;
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
		}

		// Token: 0x0603EA3E RID: 256574 RVA: 0x00F20A48 File Offset: 0x00F1EC48
		protected override void OnRefresh(ISolarSpeedRolePanelData baseData)
		{
			IAbyssRolePanelData abyssRolePanelData = (IAbyssRolePanelData)baseData;
			this.CurrentPlayerId = new int?(abyssRolePanelData.PlayerId);
			this.DescContent.Refresh(abyssRolePanelData);
			int? id = PlayerInfoModel.Instance.GetId();
			bool playerIfLikePlayer = DangoAbyssModel.Instance.GetPlayerIfLikePlayer(id.Value, abyssRolePanelData.PlayerId);
			this.LikeItem.Refresh(abyssRolePanelData.LikeCount, abyssRolePanelData.PlayerId, playerIfLikePlayer);
			this.LikeItem.RefreshLineState(!abyssRolePanelData.IsSelf);
			this.LikeItem.SetActive(true);
			this.RefreshPlayerTitle(abyssRolePanelData);
			this.RefreshAvatarTexture(abyssRolePanelData);
			this.RefreshLineTexture(abyssRolePanelData);
			this.RefreshBgTexture(abyssRolePanelData);
			base.SetFriendItemState(!abyssRolePanelData.IsSelf);
		}

		// Token: 0x04020BFE RID: 134142
		private AbyssDangoDescContent DescContent;

		// Token: 0x04020BFF RID: 134143
		private AbyssDangoLikeItem LikeItem;

		// Token: 0x04020C00 RID: 134144
		private int? CurrentPlayerId;

		// Token: 0x04020C01 RID: 134145
		[Nullable(2)]
		private PlayerTitleItem PlayerTitleItem;
	}
}
