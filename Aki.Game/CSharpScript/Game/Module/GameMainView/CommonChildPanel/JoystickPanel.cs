using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.CommonChildPanel
{
	// Token: 0x02005A16 RID: 23062
	[NullableContext(2)]
	[Nullable(0)]
	public class JoystickPanel : BattleChildViewPanel
	{
		// Token: 0x0603A7AE RID: 239534 RVA: 0x00DEAC12 File Offset: 0x00DE8E12
		public override void InitializeTemp()
		{
			this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x0603A7AF RID: 239535 RVA: 0x00DEAC24 File Offset: 0x00DE8E24
		public override UniTask InitializeAsync()
		{
			JoystickPanel.<InitializeAsync>d__5 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<JoystickPanel.<InitializeAsync>d__5>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7B0 RID: 239536 RVA: 0x00DEAC67 File Offset: 0x00DE8E67
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			Joystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.ShowBattleVisibleChildView();
		}

		// Token: 0x0603A7B1 RID: 239537 RVA: 0x00DEAC79 File Offset: 0x00DE8E79
		protected override void OnHideBattleChildViewPanel()
		{
			Joystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.HideBattleVisibleChildView();
		}

		// Token: 0x0603A7B2 RID: 239538 RVA: 0x00DEAC8B File Offset: 0x00DE8E8B
		public override void OnTickBattleChildViewPanel(float delta)
		{
			Joystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.Tick(delta);
		}

		// Token: 0x0603A7B3 RID: 239539 RVA: 0x00DEAC9E File Offset: 0x00DE8E9E
		public override void Reset()
		{
			this.Joystick = null;
		}

		// Token: 0x0603A7B4 RID: 239540 RVA: 0x00DEACA7 File Offset: 0x00DE8EA7
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRoleCompleted));
		}

		// Token: 0x0603A7B5 RID: 239541 RVA: 0x00DEACC5 File Offset: 0x00DE8EC5
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRoleCompleted));
		}

		// Token: 0x0603A7B6 RID: 239542 RVA: 0x00DEACE4 File Offset: 0x00DE8EE4
		private UniTask NewJoystickItem()
		{
			JoystickPanel.<NewJoystickItem>d__12 <NewJoystickItem>d__;
			<NewJoystickItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewJoystickItem>d__.<>4__this = this;
			<NewJoystickItem>d__.<>1__state = -1;
			<NewJoystickItem>d__.<>t__builder.Start<JoystickPanel.<NewJoystickItem>d__12>(ref <NewJoystickItem>d__);
			return <NewJoystickItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7B7 RID: 239543 RVA: 0x00DEAD28 File Offset: 0x00DE8F28
		private void RefreshJoystick()
		{
			if (this.Joystick != null && this.CurrentEntity != null)
			{
				base.ClearAllTagSignificantChangedCallback();
				base.ListenForTagSignificantChanged(this.CurrentEntity, JoystickPanel.ForbidMoveTagId, delegate(int _, bool tagExists)
				{
					this.Joystick.SetForbidMove(tagExists);
				});
				this.Joystick.SetForbidMove(base.ContainsTag(this.CurrentEntity, JoystickPanel.ForbidMoveTagId));
			}
		}

		// Token: 0x0603A7B8 RID: 239544 RVA: 0x00DEAD84 File Offset: 0x00DE8F84
		private void OnChangeRoleCompleted(int newEntityId, int oldEntityId)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.CurrentEntity = curRoleData.EntityHandle;
			this.RefreshJoystick();
		}

		// Token: 0x0401E791 RID: 124817
		[StaticVariableRuleIgnore]
		private static readonly int ForbidMoveTagId = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"];

		// Token: 0x0401E792 RID: 124818
		private Joystick Joystick;

		// Token: 0x0401E793 RID: 124819
		private EntityHandle CurrentEntity;

		// Token: 0x0401E794 RID: 124820
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat JoystickPanelTickStats = Stat.Create("JoystickPanelTickStats", "", "");
	}
}
