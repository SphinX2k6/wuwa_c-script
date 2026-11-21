using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.PinballBattle
{
	// Token: 0x020049E0 RID: 18912
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleMainViewProxy : GameMainViewProxy
	{
		// Token: 0x17005F81 RID: 24449
		// (get) Token: 0x0602F58A RID: 193930 RVA: 0x00D350A0 File Offset: 0x00D332A0
		protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0602F58B RID: 193931 RVA: 0x00D350B6 File Offset: 0x00D332B6
		protected override bool ShouldCreateJoystickPanel()
		{
			return false;
		}

		// Token: 0x0602F58C RID: 193932 RVA: 0x00D350B9 File Offset: 0x00D332B9
		protected override void OnAfterShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Default, PinballBattleMainViewProxy.pinballChildren, true, true, 0);
		}

		// Token: 0x0602F58D RID: 193933 RVA: 0x00D350D3 File Offset: 0x00D332D3
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Default, PinballBattleMainViewProxy.pinballChildren, false, true, 0);
		}

		// Token: 0x0602F58E RID: 193934 RVA: 0x00D350F0 File Offset: 0x00D332F0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballBattleMainViewProxy.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleMainViewProxy.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F58F RID: 193935 RVA: 0x00D35133 File Offset: 0x00D33333
		protected override void OnStart()
		{
			UUIItem originalItem = this.BattlePanel.GetOriginalItem();
			if (originalItem == null)
			{
				return;
			}
			originalItem.SetAsFirstHierarchy();
		}

		// Token: 0x0602F590 RID: 193936 RVA: 0x00D3514C File Offset: 0x00D3334C
		private UniTask CreateBattlePanel()
		{
			PinballBattleMainViewProxy.<CreateBattlePanel>d__9 <CreateBattlePanel>d__;
			<CreateBattlePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBattlePanel>d__.<>4__this = this;
			<CreateBattlePanel>d__.<>1__state = -1;
			<CreateBattlePanel>d__.<>t__builder.Start<PinballBattleMainViewProxy.<CreateBattlePanel>d__9>(ref <CreateBattlePanel>d__);
			return <CreateBattlePanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602F591 RID: 193937 RVA: 0x00D35190 File Offset: 0x00D33390
		protected override UniTask OnPlayingHideSequenceAsync()
		{
			PinballBattleMainViewProxy.<OnPlayingHideSequenceAsync>d__10 <OnPlayingHideSequenceAsync>d__;
			<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingHideSequenceAsync>d__.<>4__this = this;
			<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
			<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<PinballBattleMainViewProxy.<OnPlayingHideSequenceAsync>d__10>(ref <OnPlayingHideSequenceAsync>d__);
			return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040191A6 RID: 102822
		[StaticVariableRuleIgnore]
		private static readonly EBattleUiChild[] pinballChildren = new EBattleUiChild[]
		{
			EBattleUiChild.Common,
			EBattleUiChild.DamageView,
			EBattleUiChild.PositionOfficial
		};

		// Token: 0x040191A7 RID: 102823
		public PinballBattleMainBattlePanel BattlePanel;
	}
}
