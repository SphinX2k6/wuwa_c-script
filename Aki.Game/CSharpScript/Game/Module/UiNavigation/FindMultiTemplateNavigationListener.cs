using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F2 RID: 18674
	public class FindMultiTemplateNavigationListener : FindActionBase
	{
		// Token: 0x06030D5E RID: 200030 RVA: 0x00B576E8 File Offset: 0x00B558E8
		[NullableContext(1)]
		public override void FindNavigation(FindNavigationResult result)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.Params[0] as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null || tsUiNavigationBehaviorListener.ScrollProxy == null || tsUiNavigationBehaviorListener.ScrollProxy.ScrollView == null)
			{
				result.Listener = null;
				result.Result = EFindNavigationResult.CantFocus;
				return;
			}
			UUIMultiTemplateScrollViewComponent uuimultiTemplateScrollViewComponent = tsUiNavigationBehaviorListener.ScrollProxy.ScrollView as UUIMultiTemplateScrollViewComponent;
			int gridIndex = (int)this.Params[1];
			UUISelectableComponent navigationComponentByGridIndex = uuimultiTemplateScrollViewComponent.GetNavigationComponentByGridIndex(gridIndex);
			if (navigationComponentByGridIndex != null)
			{
				AActor owner = navigationComponentByGridIndex.GetOwner();
				result.Listener = (((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener);
				result.Result = EFindNavigationResult.CanFocus;
				return;
			}
			if (uuimultiTemplateScrollViewComponent.IsInDisplayRange(gridIndex, true))
			{
				result.Listener = tsUiNavigationBehaviorListener;
				result.Result = EFindNavigationResult.CanFocus;
				return;
			}
			result.Listener = null;
			result.Result = EFindNavigationResult.MultiTemplateScrollViewNotReady;
		}
	}
}
