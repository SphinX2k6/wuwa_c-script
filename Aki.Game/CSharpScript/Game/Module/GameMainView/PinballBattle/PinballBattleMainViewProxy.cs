using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.PinballBattle
{
	// Token: 0x02005A04 RID: 23044
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleMainViewProxy : GameMainViewProxy
	{
		// Token: 0x17008BB3 RID: 35763
		// (get) Token: 0x0603A641 RID: 239169 RVA: 0x00DE4B50 File Offset: 0x00DE2D50
		protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0603A642 RID: 239170 RVA: 0x00DE4B66 File Offset: 0x00DE2D66
		protected override bool ShouldCreateJoystickPanel()
		{
			return false;
		}

		// Token: 0x0603A643 RID: 239171 RVA: 0x00DE4B69 File Offset: 0x00DE2D69
		protected override void OnAfterShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Default, PinballBattleMainViewProxy.pinballChildren, true, true, 0);
		}

		// Token: 0x0603A644 RID: 239172 RVA: 0x00DE4B83 File Offset: 0x00DE2D83
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Default, PinballBattleMainViewProxy.pinballChildren, false, true, 0);
		}

		// Token: 0x0603A645 RID: 239173 RVA: 0x00DE4BA0 File Offset: 0x00DE2DA0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballBattleMainViewProxy.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleMainViewProxy.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A646 RID: 239174 RVA: 0x00DE4BE3 File Offset: 0x00DE2DE3
		protected override void OnStart()
		{
			UUIItem originalItem = this.BattlePanel.GetOriginalItem();
			if (originalItem == null)
			{
				return;
			}
			originalItem.SetAsFirstHierarchy();
		}

		// Token: 0x0603A647 RID: 239175 RVA: 0x00DE4BFC File Offset: 0x00DE2DFC
		private UniTask CreateBattlePanel()
		{
			PinballBattleMainViewProxy.<CreateBattlePanel>d__9 <CreateBattlePanel>d__;
			<CreateBattlePanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBattlePanel>d__.<>4__this = this;
			<CreateBattlePanel>d__.<>1__state = -1;
			<CreateBattlePanel>d__.<>t__builder.Start<PinballBattleMainViewProxy.<CreateBattlePanel>d__9>(ref <CreateBattlePanel>d__);
			return <CreateBattlePanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603A648 RID: 239176 RVA: 0x00DE4C40 File Offset: 0x00DE2E40
		protected override UniTask OnPlayingHideSequenceAsync()
		{
			PinballBattleMainViewProxy.<OnPlayingHideSequenceAsync>d__10 <OnPlayingHideSequenceAsync>d__;
			<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingHideSequenceAsync>d__.<>4__this = this;
			<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
			<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<PinballBattleMainViewProxy.<OnPlayingHideSequenceAsync>d__10>(ref <OnPlayingHideSequenceAsync>d__);
			return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401E6FF RID: 124671
		[StaticVariableRuleIgnore]
		private static readonly EBattleUiChild[] pinballChildren = new EBattleUiChild[]
		{
			EBattleUiChild.Common,
			EBattleUiChild.DamageView,
			EBattleUiChild.PositionOfficial
		};

		// Token: 0x0401E700 RID: 124672
		public PinballBattleMainBattlePanel BattlePanel;
	}
}
