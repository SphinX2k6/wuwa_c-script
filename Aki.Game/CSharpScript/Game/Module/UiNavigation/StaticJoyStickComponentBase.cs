using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E4 RID: 18916
	[NullableContext(1)]
	[Nullable(0)]
	public class StaticJoyStickComponentBase : HotKeyComponent
	{
		// Token: 0x0603122F RID: 201263 RVA: 0x00B6574B File Offset: 0x00B6394B
		public StaticJoyStickComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031230 RID: 201264 RVA: 0x00B65771 File Offset: 0x00B63971
		protected override void OnPress(HotKeyMap config)
		{
			this.SimulationPoint(config, true, this.Pivot);
		}

		// Token: 0x06031231 RID: 201265 RVA: 0x00B65781 File Offset: 0x00B63981
		protected override void OnRelease(HotKeyMap config)
		{
			this.SimulationPoint(config, false, this.Pivot);
		}

		// Token: 0x06031232 RID: 201266 RVA: 0x00B65791 File Offset: 0x00B63991
		protected void SimulationPoint(HotKeyMap config, bool isPress, Vector2D pivot)
		{
			if (isPress)
			{
				UiNavigationNewController.Instance.SimulationPointDown(config.BindButtonTag, config.Id, pivot);
				return;
			}
			UiNavigationNewController.Instance.SimulationPointUp(config.BindButtonTag, config.Id, pivot);
		}

		// Token: 0x06031233 RID: 201267 RVA: 0x00B657CC File Offset: 0x00B639CC
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag != null && activeListenerByTag.IsListenerActive(), false);
		}

		// Token: 0x0401A4D9 RID: 107737
		protected const float ERROR_THRESHOLD = 0.01f;

		// Token: 0x0401A4DA RID: 107738
		protected Vector2D Pivot = Vector2D.Create(0.5, 0.5);
	}
}
