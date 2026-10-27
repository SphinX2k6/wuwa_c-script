using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049F3 RID: 18931
	public class SingleHotKeyItem : HotKeyItem
	{
		// Token: 0x0603126E RID: 201326 RVA: 0x00B66D18 File Offset: 0x00B64F18
		protected override UniTask OnBeforeStartAsync()
		{
			SingleHotKeyItem.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SingleHotKeyItem.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603126F RID: 201327 RVA: 0x00B66D5C File Offset: 0x00B64F5C
		private void RegisterLinkComponent()
		{
			TsUiHotKeyLinkListener tsUiHotKeyLinkListener = this.RootActor.GetComponentByClass(TsUiHotKeyLinkListener.StaticClass()) as TsUiHotKeyLinkListener;
			if (tsUiHotKeyLinkListener == null)
			{
				return;
			}
			foreach (HotKeyComponent hotKeyComponent in this.GetHotKeyComponentArray())
			{
				if (hotKeyComponent != null)
				{
					hotKeyComponent.SetLinkComponent(tsUiHotKeyLinkListener);
				}
			}
		}

		// Token: 0x06031270 RID: 201328 RVA: 0x00B66DD4 File Offset: 0x00B64FD4
		protected override void OnClear()
		{
			this.HotKeyTypeComponent.Clear();
		}

		// Token: 0x06031271 RID: 201329 RVA: 0x00B66DE1 File Offset: 0x00B64FE1
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override List<HotKeyComponent> GetHotKeyComponentArray()
		{
			if (this.HotKeyTypeComponent != null)
			{
				return this.HotKeyTypeComponent.GetHotKeyComponents();
			}
			return new List<HotKeyComponent>();
		}

		// Token: 0x0401A4E5 RID: 107749
		[Nullable(2)]
		private HotKeyTypeBase HotKeyTypeComponent;
	}
}
