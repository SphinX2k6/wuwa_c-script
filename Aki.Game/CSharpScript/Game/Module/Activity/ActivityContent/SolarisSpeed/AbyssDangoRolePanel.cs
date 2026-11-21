using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005044 RID: 20548
	[NullableContext(1)]
	[Nullable(0)]
	public class AbyssDangoRolePanel : SolarSpeedRolePanelBase
	{
		// Token: 0x060336F7 RID: 210679 RVA: 0x00E67590 File Offset: 0x00E65790
		private UniTask InitDescContent()
		{
			AbyssDangoRolePanel.<InitDescContent>d__4 <InitDescContent>d__;
			<InitDescContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescContent>d__.<>4__this = this;
			<InitDescContent>d__.<>1__state = -1;
			<InitDescContent>d__.<>t__builder.Start<AbyssDangoRolePanel.<InitDescContent>d__4>(ref <InitDescContent>d__);
			return <InitDescContent>d__.<>t__builder.Task;
		}

		// Token: 0x060336F8 RID: 210680 RVA: 0x00E675D3 File Offset: 0x00E657D3
		private void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnAbyssLikeChange, new Action<int>(this.OnAbyssLikeChange));
		}

		// Token: 0x060336F9 RID: 210681 RVA: 0x00E675F1 File Offset: 0x00E657F1
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAbyssLikeChange, new Action<int>(this.OnAbyssLikeChange));
		}

		// Token: 0x060336FA RID: 210682 RVA: 0x00E67610 File Offset: 0x00E65810
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

		// Token: 0x060336FB RID: 210683 RVA: 0x00E67674 File Offset: 0x00E65874
		protected override UniTask OnBeforeStartAsync()
		{
			AbyssDangoRolePanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AbyssDangoRolePanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060336FC RID: 210684 RVA: 0x00E676B7 File Offset: 0x00E658B7
		protected override void OnStart()
		{
			this.AddEventListener();
		}

		// Token: 0x060336FD RID: 210685 RVA: 0x00E676BF File Offset: 0x00E658BF
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060336FE RID: 210686 RVA: 0x00E676C8 File Offset: 0x00E658C8
		private void RefreshAvatarTexture(IAbyssRolePanelData data)
		{
			string path = UiResourceConfig.Instance.GetResourceConfig(data.AvatarTexturePath).Value.Path;
			base.SetTextureByPath(path, base.GetTexture(14), null, null);
		}

		// Token: 0x060336FF RID: 210687 RVA: 0x00E67710 File Offset: 0x00E65910
		private void RefreshLineTexture(IAbyssRolePanelData data)
		{
			string path = UiResourceConfig.Instance.GetResourceConfig(data.LineTexturePath).Value.Path;
			base.SetTextureByPath(path, base.GetTexture(15), null, null);
		}

		// Token: 0x06033700 RID: 210688 RVA: 0x00E67758 File Offset: 0x00E65958
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

		// Token: 0x06033701 RID: 210689 RVA: 0x00E677C4 File Offset: 0x00E659C4
		private void RefreshBgTexture(IAbyssRolePanelData data)
		{
			string path = UiResourceConfig.Instance.GetResourceConfig(data.BgTexturePath).Value.Path;
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
		}

		// Token: 0x06033702 RID: 210690 RVA: 0x00E6780C File Offset: 0x00E65A0C
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

		// Token: 0x0401B52B RID: 111915
		private AbyssDangoDescContent DescContent;

		// Token: 0x0401B52C RID: 111916
		private AbyssDangoLikeItem LikeItem;

		// Token: 0x0401B52D RID: 111917
		private int? CurrentPlayerId;

		// Token: 0x0401B52E RID: 111918
		[Nullable(2)]
		private PlayerTitleItem PlayerTitleItem;
	}
}
