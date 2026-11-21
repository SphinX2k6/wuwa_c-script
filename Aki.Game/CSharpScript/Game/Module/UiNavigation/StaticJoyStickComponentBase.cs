using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200395E RID: 14686
	[NullableContext(1)]
	[Nullable(0)]
	public class StaticJoyStickComponentBase : HotKeyComponent
	{
		// Token: 0x06025D65 RID: 154981 RVA: 0x00AA069B File Offset: 0x00A9E89B
		public StaticJoyStickComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D66 RID: 154982 RVA: 0x00AA06C1 File Offset: 0x00A9E8C1
		protected override void OnPress(HotKeyMap config)
		{
			this.SimulationPoint(config, true, this.Pivot);
		}

		// Token: 0x06025D67 RID: 154983 RVA: 0x00AA06D1 File Offset: 0x00A9E8D1
		protected override void OnRelease(HotKeyMap config)
		{
			this.SimulationPoint(config, false, this.Pivot);
		}

		// Token: 0x06025D68 RID: 154984 RVA: 0x00AA06E1 File Offset: 0x00A9E8E1
		protected void SimulationPoint(HotKeyMap config, bool isPress, Vector2D pivot)
		{
			if (isPress)
			{
				UiNavigationNewController.Instance.SimulationPointDown(config.BindButtonTag, config.Id, pivot);
				return;
			}
			UiNavigationNewController.Instance.SimulationPointUp(config.BindButtonTag, config.Id, pivot);
		}

		// Token: 0x06025D69 RID: 154985 RVA: 0x00AA071C File Offset: 0x00A9E91C
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

		// Token: 0x04014D4B RID: 85323
		protected const float ERROR_THRESHOLD = 0.01f;

		// Token: 0x04014D4C RID: 85324
		protected Vector2D Pivot = Vector2D.Create(0.5, 0.5);
	}
}
