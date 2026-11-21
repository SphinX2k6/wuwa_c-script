using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C3 RID: 14531
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleViewCameraComponent : HotKeyComponent
	{
		// Token: 0x06025AFD RID: 154365 RVA: 0x00A9B582 File Offset: 0x00A99782
		public BattleViewCameraComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x06025AFE RID: 154366 RVA: 0x00A9B5A6 File Offset: 0x00A997A6
		protected override void OnClear()
		{
			InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
		}

		// Token: 0x06025AFF RID: 154367 RVA: 0x00A9B5C3 File Offset: 0x00A997C3
		private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
		{
			this.IsMainKeyPress = (actionType == InputDistributeDefine.EActionType.Press);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsMainKeyPress, false);
		}

		// Token: 0x06025B00 RID: 154368 RVA: 0x00A9B5DD File Offset: 0x00A997DD
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsMainKeyPress, false);
		}

		// Token: 0x06025B01 RID: 154369 RVA: 0x00A9B5ED File Offset: 0x00A997ED
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}

		// Token: 0x04014CF3 RID: 85235
		private bool IsMainKeyPress;
	}
}
