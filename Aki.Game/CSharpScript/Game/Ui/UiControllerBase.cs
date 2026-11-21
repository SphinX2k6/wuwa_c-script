using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200355B RID: 13659
	public abstract class UiControllerBase : ControllerBase
	{
		// Token: 0x06022B95 RID: 142229 RVA: 0x009DFDBD File Offset: 0x009DDFBD
		public override bool Init()
		{
			bool result = base.Init();
			this.OnRegisterNetEvent();
			this.OnAddEvents();
			this.OnAddOpenViewCheckFunction();
			return result;
		}

		// Token: 0x06022B96 RID: 142230 RVA: 0x009DFDD7 File Offset: 0x009DDFD7
		public override bool Clear()
		{
			this.OnUnRegisterNetEvent();
			this.OnRemoveEvents();
			this.OnRemoveOpenViewCheckFunction();
			return base.Clear();
		}

		// Token: 0x06022B97 RID: 142231 RVA: 0x009DFDF1 File Offset: 0x009DDFF1
		protected virtual void OnRegisterNetEvent()
		{
		}

		// Token: 0x06022B98 RID: 142232 RVA: 0x009DFDF3 File Offset: 0x009DDFF3
		protected virtual void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x06022B99 RID: 142233 RVA: 0x009DFDF5 File Offset: 0x009DDFF5
		protected virtual void OnAddEvents()
		{
		}

		// Token: 0x06022B9A RID: 142234 RVA: 0x009DFDF7 File Offset: 0x009DDFF7
		protected virtual void OnRemoveEvents()
		{
		}

		// Token: 0x06022B9B RID: 142235 RVA: 0x009DFDF9 File Offset: 0x009DDFF9
		protected virtual void OnAddOpenViewCheckFunction()
		{
		}

		// Token: 0x06022B9C RID: 142236 RVA: 0x009DFDFB File Offset: 0x009DDFFB
		protected virtual void OnRemoveOpenViewCheckFunction()
		{
		}
	}
}
