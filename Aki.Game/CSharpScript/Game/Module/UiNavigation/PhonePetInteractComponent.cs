using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049AE RID: 18862
	[NullableContext(1)]
	[Nullable(0)]
	public class PhonePetInteractComponent : HotKeyComponent
	{
		// Token: 0x06031189 RID: 201097 RVA: 0x00B646BA File Offset: 0x00B628BA
		public PhonePetInteractComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603118A RID: 201098 RVA: 0x00B646C4 File Offset: 0x00B628C4
		public override void SetDataCallback(Func<object> callback)
		{
			this.InteractAction = delegate()
			{
				callback();
			};
		}

		// Token: 0x0603118B RID: 201099 RVA: 0x00B646F0 File Offset: 0x00B628F0
		protected override void OnPress(HotKeyMap config)
		{
			Action interactAction = this.InteractAction;
			if (interactAction == null)
			{
				return;
			}
			interactAction();
		}

		// Token: 0x0603118C RID: 201100 RVA: 0x00B64702 File Offset: 0x00B62902
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.InteractAction != null, false);
		}

		// Token: 0x0603118D RID: 201101 RVA: 0x00B64715 File Offset: 0x00B62915
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}

		// Token: 0x0603118E RID: 201102 RVA: 0x00B64718 File Offset: 0x00B62918
		protected override void OnClear()
		{
			base.OnClear();
			this.InteractAction = null;
		}

		// Token: 0x0401A4B7 RID: 107703
		[Nullable(2)]
		private Action InteractAction;
	}
}
