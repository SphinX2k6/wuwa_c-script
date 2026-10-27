using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004639 RID: 17977
	public class UiTickViewBase : UiViewBase, IPanelTickInterface
	{
		// Token: 0x0602E5BB RID: 189883 RVA: 0x00AB684F File Offset: 0x00AB4A4F
		[NullableContext(1)]
		public UiTickViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E5BC RID: 189884 RVA: 0x00AB6858 File Offset: 0x00AB4A58
		protected override void OnBeforeShowImplementImplement()
		{
			UiManager.Instance.AddTickView(this);
		}

		// Token: 0x0602E5BD RID: 189885 RVA: 0x00AB6865 File Offset: 0x00AB4A65
		protected override void OnAfterHideImplementImplement()
		{
			UiManager.Instance.RemoveTickView(this);
		}

		// Token: 0x0602E5BE RID: 189886 RVA: 0x00AB6872 File Offset: 0x00AB4A72
		public void Tick(float delta)
		{
			this.OnTick(delta);
		}

		// Token: 0x0602E5BF RID: 189887 RVA: 0x00AB687B File Offset: 0x00AB4A7B
		public void AfterTick(float delta)
		{
			this.OnAfterTick(delta);
		}

		// Token: 0x0602E5C0 RID: 189888 RVA: 0x00AB6884 File Offset: 0x00AB4A84
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0602E5C1 RID: 189889 RVA: 0x00AB6886 File Offset: 0x00AB4A86
		protected virtual void OnAfterTick(float delta)
		{
		}
	}
}
