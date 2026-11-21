using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200396D RID: 14701
	public class SingleHotKeyItem : HotKeyItem
	{
		// Token: 0x06025DA4 RID: 155044 RVA: 0x00AA1CD4 File Offset: 0x00A9FED4
		protected override UniTask OnBeforeStartAsync()
		{
			SingleHotKeyItem.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SingleHotKeyItem.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025DA5 RID: 155045 RVA: 0x00AA1D18 File Offset: 0x00A9FF18
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

		// Token: 0x06025DA6 RID: 155046 RVA: 0x00AA1D90 File Offset: 0x00A9FF90
		protected override void OnClear()
		{
			this.HotKeyTypeComponent.Clear();
		}

		// Token: 0x06025DA7 RID: 155047 RVA: 0x00AA1D9D File Offset: 0x00A9FF9D
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

		// Token: 0x04014D57 RID: 85335
		[Nullable(2)]
		private HotKeyTypeBase HotKeyTypeComponent;
	}
}
