using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag
{
	// Token: 0x02006A2F RID: 27183
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BaseDragModeStrategy : IDragModeStrategy
	{
		// Token: 0x170098E5 RID: 39141
		// (get) Token: 0x060439C1 RID: 276929
		public abstract EKuroSplineConstrainedDragMode Mode { get; }

		// Token: 0x060439C2 RID: 276930 RVA: 0x0108B7D9 File Offset: 0x010899D9
		public virtual void OnActivate(IKuroSplineConstrainedDrag host)
		{
			this.Host = host;
		}

		// Token: 0x060439C3 RID: 276931 RVA: 0x0108B7E2 File Offset: 0x010899E2
		public virtual void OnDeactivate()
		{
		}

		// Token: 0x060439C4 RID: 276932 RVA: 0x0108B7E4 File Offset: 0x010899E4
		public virtual void BeginDrag()
		{
			IKuroSplineConstrainedDrag host = this.Host;
			if (host == null)
			{
				return;
			}
			host.RunCommonBeginDrag();
		}

		// Token: 0x060439C5 RID: 276933 RVA: 0x0108B7F6 File Offset: 0x010899F6
		public virtual void EndDrag()
		{
		}

		// Token: 0x060439C6 RID: 276934
		public abstract void SetCurrentScreenPosition(Vector screenPosition);

		// Token: 0x060439C7 RID: 276935
		public abstract void ApplyScreenDelta(Vector screenDelta);

		// Token: 0x040234C5 RID: 144581
		[Nullable(2)]
		protected IKuroSplineConstrainedDrag Host;
	}
}
