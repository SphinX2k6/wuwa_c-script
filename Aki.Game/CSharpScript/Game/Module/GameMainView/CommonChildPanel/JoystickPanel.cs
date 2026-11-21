using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.CommonChildPanel
{
	// Token: 0x020049F2 RID: 18930
	[NullableContext(2)]
	[Nullable(0)]
	public class JoystickPanel : BattleChildViewPanel
	{
		// Token: 0x0602F6F7 RID: 194295 RVA: 0x00D3B1AA File Offset: 0x00D393AA
		public override void InitializeTemp()
		{
			this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x0602F6F8 RID: 194296 RVA: 0x00D3B1BC File Offset: 0x00D393BC
		public override UniTask InitializeAsync()
		{
			JoystickPanel.<InitializeAsync>d__5 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<JoystickPanel.<InitializeAsync>d__5>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F6F9 RID: 194297 RVA: 0x00D3B1FF File Offset: 0x00D393FF
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			Joystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.ShowBattleVisibleChildView();
		}

		// Token: 0x0602F6FA RID: 194298 RVA: 0x00D3B211 File Offset: 0x00D39411
		protected override void OnHideBattleChildViewPanel()
		{
			Joystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.HideBattleVisibleChildView();
		}

		// Token: 0x0602F6FB RID: 194299 RVA: 0x00D3B223 File Offset: 0x00D39423
		public override void OnTickBattleChildViewPanel(float delta)
		{
			Joystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.Tick(delta);
		}

		// Token: 0x0602F6FC RID: 194300 RVA: 0x00D3B236 File Offset: 0x00D39436
		public override void Reset()
		{
			this.Joystick = null;
		}

		// Token: 0x0602F6FD RID: 194301 RVA: 0x00D3B23F File Offset: 0x00D3943F
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRoleCompleted));
		}

		// Token: 0x0602F6FE RID: 194302 RVA: 0x00D3B25D File Offset: 0x00D3945D
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRoleCompleted));
		}

		// Token: 0x0602F6FF RID: 194303 RVA: 0x00D3B27C File Offset: 0x00D3947C
		private UniTask NewJoystickItem()
		{
			JoystickPanel.<NewJoystickItem>d__12 <NewJoystickItem>d__;
			<NewJoystickItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewJoystickItem>d__.<>4__this = this;
			<NewJoystickItem>d__.<>1__state = -1;
			<NewJoystickItem>d__.<>t__builder.Start<JoystickPanel.<NewJoystickItem>d__12>(ref <NewJoystickItem>d__);
			return <NewJoystickItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602F700 RID: 194304 RVA: 0x00D3B2C0 File Offset: 0x00D394C0
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

		// Token: 0x0602F701 RID: 194305 RVA: 0x00D3B31C File Offset: 0x00D3951C
		private void OnChangeRoleCompleted(int newEntityId, int oldEntityId)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.CurrentEntity = curRoleData.EntityHandle;
			this.RefreshJoystick();
		}

		// Token: 0x04019238 RID: 102968
		[StaticVariableRuleIgnore]
		private static readonly int ForbidMoveTagId = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"];

		// Token: 0x04019239 RID: 102969
		private Joystick Joystick;

		// Token: 0x0401923A RID: 102970
		private EntityHandle CurrentEntity;

		// Token: 0x0401923B RID: 102971
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat JoystickPanelTickStats = Stat.Create("JoystickPanelTickStats", "", "");
	}
}
