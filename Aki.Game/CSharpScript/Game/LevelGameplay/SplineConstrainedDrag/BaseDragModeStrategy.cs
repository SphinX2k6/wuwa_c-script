using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag
{
	// Token: 0x02005B8C RID: 23436
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BaseDragModeStrategy : IDragModeStrategy
	{
		// Token: 0x17006DCA RID: 28106
		// (get) Token: 0x06039A0F RID: 236047
		public abstract EKuroSplineConstrainedDragMode Mode { get; }

		// Token: 0x06039A10 RID: 236048 RVA: 0x01030009 File Offset: 0x0102E209
		public virtual void OnActivate(IKuroSplineConstrainedDrag host)
		{
			this.Host = host;
		}

		// Token: 0x06039A11 RID: 236049 RVA: 0x01030012 File Offset: 0x0102E212
		public virtual void OnDeactivate()
		{
		}

		// Token: 0x06039A12 RID: 236050 RVA: 0x01030014 File Offset: 0x0102E214
		public virtual void BeginDrag()
		{
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return;
			}
			host.RunCommonBeginDrag();
		}

		// Token: 0x06039A13 RID: 236051 RVA: 0x01030026 File Offset: 0x0102E226
		public virtual void EndDrag()
		{
		}

		// Token: 0x06039A14 RID: 236052
		public abstract void SetCurrentScreenPosition(Vector screenPosition);

		// Token: 0x06039A15 RID: 236053
		public abstract void ApplyScreenDelta(Vector screenDelta);

		// Token: 0x0401E6B7 RID: 124599
		[Nullable(2)]
		protected IKuroSplineConstrainedDrag Host;
	}
}
