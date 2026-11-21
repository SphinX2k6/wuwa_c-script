using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038FF RID: 14591
	public class LongTimeToTriggerInScrollComponent : LongTimeToTriggerComponent
	{
		// Token: 0x06025C32 RID: 154674 RVA: 0x00A9E146 File Offset: 0x00A9C346
		public LongTimeToTriggerInScrollComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C33 RID: 154675 RVA: 0x00A9E150 File Offset: 0x00A9C350
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			if (activeListenerByTag == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!activeListenerByTag.IsInNormalScrollDisplayByGridActor())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag.IsListenerActive(), false);
		}
	}
}
