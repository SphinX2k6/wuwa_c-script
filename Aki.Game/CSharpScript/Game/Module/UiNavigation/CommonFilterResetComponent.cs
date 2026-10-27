using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004955 RID: 18773
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonFilterResetComponent : LongTimeToTriggerComponent
	{
		// Token: 0x06030FF7 RID: 200695 RVA: 0x00B60D35 File Offset: 0x00B5EF35
		public CommonFilterResetComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FF8 RID: 200696 RVA: 0x00B60D3E File Offset: 0x00B5EF3E
		protected override void ClickButton(string tag)
		{
			UiNavigationNewController.Instance.ClickButton(tag);
			this.ResetToFindListener();
		}

		// Token: 0x06030FF9 RID: 200697 RVA: 0x00B60D54 File Offset: 0x00B5EF54
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
			if (!CommonFilterResetComponent.ListenerGroupNameArray.Contains(currentNavigationFocusListener.GroupName))
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

		// Token: 0x0401A482 RID: 107650
		[StaticVariableRuleIgnore]
		private static readonly string[] ListenerGroupNameArray = new string[]
		{
			"Group1",
			"Group2"
		};
	}
}
