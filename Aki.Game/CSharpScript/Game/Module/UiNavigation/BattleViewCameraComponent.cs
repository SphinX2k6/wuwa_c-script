using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200494C RID: 18764
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleViewCameraComponent : HotKeyComponent
	{
		// Token: 0x06030FD1 RID: 200657 RVA: 0x00B6073E File Offset: 0x00B5E93E
		public BattleViewCameraComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x06030FD2 RID: 200658 RVA: 0x00B60762 File Offset: 0x00B5E962
		protected override void OnClear()
		{
			InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x06030FD3 RID: 200659 RVA: 0x00B6077F File Offset: 0x00B5E97F
		private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
		{
			this.IsMainKeyPress = (actionType == InputDistributeDefine.EActionType.Press);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsMainKeyPress, false);
		}

		// Token: 0x06030FD4 RID: 200660 RVA: 0x00B60799 File Offset: 0x00B5E999
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsMainKeyPress, false);
		}

		// Token: 0x06030FD5 RID: 200661 RVA: 0x00B607A9 File Offset: 0x00B5E9A9
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}

		// Token: 0x0401A480 RID: 107648
		private bool IsMainKeyPress;
	}
}
