using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038CD RID: 14541
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonFilterResetComponent : LongTimeToTriggerComponent
	{
		// Token: 0x06025B27 RID: 154407 RVA: 0x00A9BC15 File Offset: 0x00A99E15
		public CommonFilterResetComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B28 RID: 154408 RVA: 0x00A9BC1E File Offset: 0x00A99E1E
		protected override void ClickButton(string tag)
		{
			UiNavigationNewController.Instance.ClickButton(tag);
			this.ResetToFindListener();
		}

		// Token: 0x06025B29 RID: 154409 RVA: 0x00A9BC34 File Offset: 0x00A99E34
		protected void ResetToFindListener()
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener == null)
			{
				return;
			}
			if (!currentNavigationFocusListener.IsScrollOrLayoutActor())
			{
				return;
			}
			if (Array.IndexOf<string>(CommonFilterResetComponent.ListenerGroupNameArray, currentNavigationFocusListener.GroupName) < 0)
			{
				return;
			}
			if (currentNavigationFocusListener.PanelConfig == null)
			{
				return;
			}
			FindNavigationByListener findNavigationByListener = new FindNavigationByListener();
			findNavigationByListener.PanelConfig = currentNavigationFocusListener.PanelConfig;
			findNavigationByListener.AddParam(new object[]
			{
				currentNavigationFocusListener
			});
			currentNavigationFocusListener.PanelConfig.SetFindNavigationAction(findNavigationByListener);
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}

		// Token: 0x04014CF5 RID: 85237
		[StaticVariableRuleIgnore]
		private static readonly string[] ListenerGroupNameArray = new string[]
		{
			"Group1",
			"Group2"
		};
	}
}
