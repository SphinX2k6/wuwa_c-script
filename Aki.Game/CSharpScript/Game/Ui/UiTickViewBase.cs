using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200356A RID: 13674
	public class UiTickViewBase : UiViewBase, IPanelTickInterface
	{
		// Token: 0x06022D05 RID: 142597 RVA: 0x009E3E8F File Offset: 0x009E208F
		[NullableContext(1)]
		public UiTickViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06022D06 RID: 142598 RVA: 0x009E3E98 File Offset: 0x009E2098
		protected override void OnBeforeShowImplementImplement()
		{
			UiManager.Instance.AddTickView(this);
		}

		// Token: 0x06022D07 RID: 142599 RVA: 0x009E3EA5 File Offset: 0x009E20A5
		protected override void OnAfterHideImplementImplement()
		{
			UiManager.Instance.RemoveTickView(this);
		}

		// Token: 0x06022D08 RID: 142600 RVA: 0x009E3EB2 File Offset: 0x009E20B2
		public void Tick(float delta)
		{
			this.OnTick(delta);
		}

		// Token: 0x06022D09 RID: 142601 RVA: 0x009E3EBB File Offset: 0x009E20BB
		public void AfterTick(float delta)
		{
			this.OnAfterTick(delta);
		}

		// Token: 0x06022D0A RID: 142602 RVA: 0x009E3EC4 File Offset: 0x009E20C4
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06022D0B RID: 142603 RVA: 0x009E3EC6 File Offset: 0x009E20C6
		protected virtual void OnAfterTick(float delta)
		{
		}
	}
}
