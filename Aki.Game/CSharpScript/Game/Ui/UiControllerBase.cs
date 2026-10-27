using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004631 RID: 17969
	public abstract class UiControllerBase : ControllerBase
	{
		// Token: 0x0602E482 RID: 189570 RVA: 0x00AB302D File Offset: 0x00AB122D
		public override bool Init()
		{
			bool result = base.Init();
			this.OnRegisterNetEvent();
			this.OnAddEvents();
			this.OnAddOpenViewCheckFunction();
			return result;
		}

		// Token: 0x0602E483 RID: 189571 RVA: 0x00AB3047 File Offset: 0x00AB1247
		public override bool Clear()
		{
			this.OnUnRegisterNetEvent();
			this.OnRemoveEvents();
			this.OnRemoveOpenViewCheckFunction();
			return base.Clear();
		}

		// Token: 0x0602E484 RID: 189572 RVA: 0x00AB3061 File Offset: 0x00AB1261
		protected virtual void OnRegisterNetEvent()
		{
		}

		// Token: 0x0602E485 RID: 189573 RVA: 0x00AB3063 File Offset: 0x00AB1263
		protected virtual void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x0602E486 RID: 189574 RVA: 0x00AB3065 File Offset: 0x00AB1265
		protected virtual void OnAddEvents()
		{
		}

		// Token: 0x0602E487 RID: 189575 RVA: 0x00AB3067 File Offset: 0x00AB1267
		protected virtual void OnRemoveEvents()
		{
		}

		// Token: 0x0602E488 RID: 189576 RVA: 0x00AB3069 File Offset: 0x00AB1269
		protected virtual void OnAddOpenViewCheckFunction()
		{
		}

		// Token: 0x0602E489 RID: 189577 RVA: 0x00AB306B File Offset: 0x00AB126B
		protected virtual void OnRemoveOpenViewCheckFunction()
		{
		}
	}
}
