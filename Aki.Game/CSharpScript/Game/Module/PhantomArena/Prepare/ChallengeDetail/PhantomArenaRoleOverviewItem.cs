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
	// Token: 0x0200418F RID: 16783
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleOverviewItem : UiPanelBase
	{
		// Token: 0x0602A857 RID: 174167 RVA: 0x00BFF9D8 File Offset: 0x00BFDBD8
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

		// Token: 0x0602A858 RID: 174168 RVA: 0x00BFFA98 File Offset: 0x00BFDC98
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleOverviewItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleOverviewItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A859 RID: 174169 RVA: 0x00BFFADC File Offset: 0x00BFDCDC
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

		// Token: 0x0602A85A RID: 174170 RVA: 0x00BFFBC0 File Offset: 0x00BFDDC0
		public void PlaySelectAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("In", false, null, false);
		}

		// Token: 0x0602A85B RID: 174171 RVA: 0x00BFFBED File Offset: 0x00BFDDED
		private void OnItemButtonClick()
		{
			Action onRoleOverviewItemClick = this.OnRoleOverviewItemClick;
			if (onRoleOverviewItemClick == null)
			{
				return;
			}
			onRoleOverviewItemClick();
		}

		// Token: 0x0401714B RID: 94539
		protected IPhantomArenaRoleOverviewItemData Data;

		// Token: 0x0401714C RID: 94540
		public Action OnRoleOverviewItemClick;

		// Token: 0x0401714D RID: 94541
		private CardElementItem ElementItem;

		// Token: 0x0401714E RID: 94542
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x02009D85 RID: 40325
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030FE7 RID: 200679
			public const int ItemButton = 0;

			// Token: 0x04030FE8 RID: 200680
			public const int RoleItem = 1;

			// Token: 0x04030FE9 RID: 200681
			public const int RoleTexture = 2;

			// Token: 0x04030FEA RID: 200682
			public const int NameText = 3;

			// Token: 0x04030FEB RID: 200683
			public const int ElementItem = 4;

			// Token: 0x04030FEC RID: 200684
			public const int EmptyItem = 5;
		}
	}
}
