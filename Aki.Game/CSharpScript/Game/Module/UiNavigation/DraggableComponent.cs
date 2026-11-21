using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038CF RID: 14543
	public class DraggableComponent : HotKeyComponent
	{
		// Token: 0x06025B2E RID: 154414 RVA: 0x00A9BCEB File Offset: 0x00A99EEB
		public DraggableComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B2F RID: 154415 RVA: 0x00A9BD06 File Offset: 0x00A99F06
		protected override void OnPress(HotKeyMap config)
		{
			this.RemoveTickHandle();
			this.AddTickHandle();
		}

		// Token: 0x06025B30 RID: 154416 RVA: 0x00A9BD14 File Offset: 0x00A99F14
		protected override void OnRelease(HotKeyMap config)
		{
			this.RemoveTickHandle();
		}

		// Token: 0x06025B31 RID: 154417 RVA: 0x00A9BD1C File Offset: 0x00A99F1C
		private void AddTickHandle()
		{
			this.TickTime = 20f;
			this.TickHandle = TickSystem.Instance.Add(new Action<float>(this.OnTick), "NavigationDraggableComponent", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06025B32 RID: 154418 RVA: 0x00A9BD53 File Offset: 0x00A99F53
		private void RemoveTickHandle()
		{
			if (this.TickHandle != -1)
			{
				TickSystem.Instance.Remove(this.TickHandle);
				this.TickHandle = -1;
			}
		}

		// Token: 0x06025B33 RID: 154419 RVA: 0x00A9BD78 File Offset: 0x00A99F78
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

		// Token: 0x06025B34 RID: 154420 RVA: 0x00A9BDB1 File Offset: 0x00A99FB1
		private void OnTick(float deltaTime)
		{
			this.TickTime += deltaTime;
			if (this.TickTime > 20f)
			{
				this.TickTime -= 20f;
				this.TriggerEvent();
			}
		}

		// Token: 0x06025B35 RID: 154421 RVA: 0x00A9BDE6 File Offset: 0x00A99FE6
		protected virtual void TriggerEvent()
		{
		}

		// Token: 0x06025B36 RID: 154422 RVA: 0x00A9BDE8 File Offset: 0x00A99FE8
		protected override void OnUnRegisterMe()
		{
			this.RemoveTickHandle();
		}

		// Token: 0x04014CF6 RID: 85238
		private const float TRIGGER_TIME = 20f;

		// Token: 0x04014CF7 RID: 85239
		private int TickHandle = -1;

		// Token: 0x04014CF8 RID: 85240
		private float TickTime = 20f;
	}
}
