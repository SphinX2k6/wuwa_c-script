using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004957 RID: 18775
	public class DraggableComponent : HotKeyComponent
	{
		// Token: 0x06030FFE RID: 200702 RVA: 0x00B60E0A File Offset: 0x00B5F00A
		public DraggableComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FFF RID: 200703 RVA: 0x00B60E25 File Offset: 0x00B5F025
		protected override void OnPress(HotKeyMap config)
		{
			this.RemoveTickHandle();
			this.AddTickHandle();
		}

		// Token: 0x06031000 RID: 200704 RVA: 0x00B60E33 File Offset: 0x00B5F033
		protected override void OnRelease(HotKeyMap config)
		{
			this.RemoveTickHandle();
		}

		// Token: 0x06031001 RID: 200705 RVA: 0x00B60E3B File Offset: 0x00B5F03B
		private void AddTickHandle()
		{
			this.TickTime = 20f;
			this.TickHandle = TickSystem.Instance.Add(new Action<float>(this.OnTick), "NavigationDraggableComponent", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06031002 RID: 200706 RVA: 0x00B60E72 File Offset: 0x00B5F072
		private void RemoveTickHandle()
		{
			if (this.TickHandle != -1)
			{
				TickSystem.Instance.Remove(this.TickHandle);
				this.TickHandle = -1;
			}
		}

		// Token: 0x06031003 RID: 200707 RVA: 0x00B60E98 File Offset: 0x00B5F098
		[NullableContext(1)]
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

		// Token: 0x06031004 RID: 200708 RVA: 0x00B60ED1 File Offset: 0x00B5F0D1
		private void OnTick(float deltaTime)
		{
			this.TickTime += deltaTime;
			if (this.TickTime > 20f)
			{
				this.TickTime -= 20f;
				this.TriggerEvent();
			}
		}

		// Token: 0x06031005 RID: 200709 RVA: 0x00B60F06 File Offset: 0x00B5F106
		protected virtual void TriggerEvent()
		{
		}

		// Token: 0x06031006 RID: 200710 RVA: 0x00B60F08 File Offset: 0x00B5F108
		protected override void OnUnRegisterMe()
		{
			this.RemoveTickHandle();
		}

		// Token: 0x0401A483 RID: 107651
		private const float TRIGGER_TIME = 20f;

		// Token: 0x0401A484 RID: 107652
		private int TickHandle = -1;

		// Token: 0x0401A485 RID: 107653
		private float TickTime = 20f;
	}
}
