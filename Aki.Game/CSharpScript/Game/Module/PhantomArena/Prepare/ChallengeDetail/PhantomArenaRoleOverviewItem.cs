using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.ChallengeDetail
{
	// Token: 0x020051BF RID: 20927
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleOverviewItem : UiPanelBase
	{
		// Token: 0x0603595C RID: 219484 RVA: 0x00CB239C File Offset: 0x00CB059C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnItemButtonClick))
			};
		}

		// Token: 0x0603595D RID: 219485 RVA: 0x00CB245C File Offset: 0x00CB065C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleOverviewItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleOverviewItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603595E RID: 219486 RVA: 0x00CB24A0 File Offset: 0x00CB06A0
		public void Refresh(IPhantomArenaRoleOverviewItemData data)
		{
			this.Data = data;
			if (data.CardRoleId <= 0)
			{
				base.GetItem(5).SetUIActive(true);
				base.GetItem(1).SetUIActive(false);
				return;
			}
			base.GetItem(5).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(data.CardRoleId);
			int roleConfigId = phantomBattleCardRole.RoleConfigId;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
			if (roleConfig != null)
			{
				base.SetTextureByPath(phantomBattleCardRole.RolePreviewTexture, base.GetTexture(2), null, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), roleConfig.Value.Name, Array.Empty<object>());
				CardElementItem elementItem = this.ElementItem;
				if (elementItem == null)
				{
					return;
				}
				elementItem.RefreshElement((ECardElement)roleConfig.Value.ElementId);
			}
		}

		// Token: 0x0603595F RID: 219487 RVA: 0x00CB2584 File Offset: 0x00CB0784
		public void PlaySelectAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("In", false, null, false);
		}

		// Token: 0x06035960 RID: 219488 RVA: 0x00CB25B1 File Offset: 0x00CB07B1
		private void OnItemButtonClick()
		{
			Action onRoleOverviewItemClick = this.OnRoleOverviewItemClick;
			if (onRoleOverviewItemClick == null)
			{
				return;
			}
			onRoleOverviewItemClick();
		}

		// Token: 0x0401C716 RID: 116502
		protected IPhantomArenaRoleOverviewItemData Data;

		// Token: 0x0401C717 RID: 116503
		public Action OnRoleOverviewItemClick;

		// Token: 0x0401C718 RID: 116504
		private CardElementItem ElementItem;

		// Token: 0x0401C719 RID: 116505
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B34D RID: 45901
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036594 RID: 222612
			public const int ItemButton = 0;

			// Token: 0x04036595 RID: 222613
			public const int RoleItem = 1;

			// Token: 0x04036596 RID: 222614
			public const int RoleTexture = 2;

			// Token: 0x04036597 RID: 222615
			public const int NameText = 3;

			// Token: 0x04036598 RID: 222616
			public const int ElementItem = 4;

			// Token: 0x04036599 RID: 222617
			public const int EmptyItem = 5;
		}
	}
}
