using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BC6 RID: 23494
	[NullableContext(1)]
	[Nullable(0)]
	internal class SolidBox : IBoxSnapshot
	{
		// Token: 0x17006E07 RID: 28167
		// (get) Token: 0x06039C00 RID: 236544 RVA: 0x01038C5D File Offset: 0x01036E5D
		public Quat Rotation { get; } = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x17006E08 RID: 28168
		// (get) Token: 0x06039C01 RID: 236545 RVA: 0x01038C65 File Offset: 0x01036E65
		public Vector HalfExtent { get; } = Vector.Create();

		// Token: 0x17006E09 RID: 28169
		// (get) Token: 0x06039C02 RID: 236546 RVA: 0x01038C6D File Offset: 0x01036E6D
		public Vector WorldPosition { get; } = Vector.Create();

		// Token: 0x0401E81C RID: 124956
		public int RefCount;

		// Token: 0x0401E81D RID: 124957
		public readonly Vector Position = Vector.Create();

		// Token: 0x0401E81F RID: 124959
		public readonly Vector LocationOffset = Vector.Create();

		// Token: 0x0401E822 RID: 124962
		public readonly Vector WorldAabbMin = Vector.Create();

		// Token: 0x0401E823 RID: 124963
		public readonly Vector WorldAabbMax = Vector.Create();
	}
}
