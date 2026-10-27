using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A69 RID: 27241
	[NullableContext(1)]
	[Nullable(0)]
	internal class SolidBox : IBoxSnapshot
	{
		// Token: 0x17009922 RID: 39202
		// (get) Token: 0x06043BB2 RID: 277426 RVA: 0x01094429 File Offset: 0x01092629
		public Quat Rotation { get; } = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x17009923 RID: 39203
		// (get) Token: 0x06043BB3 RID: 277427 RVA: 0x01094431 File Offset: 0x01092631
		public Vector HalfExtent { get; } = Vector.Create();

		// Token: 0x17009924 RID: 39204
		// (get) Token: 0x06043BB4 RID: 277428 RVA: 0x01094439 File Offset: 0x01092639
		public Vector WorldPosition { get; } = Vector.Create();

		// Token: 0x0402362A RID: 144938
		public int RefCount;

		// Token: 0x0402362B RID: 144939
		public readonly Vector Position = Vector.Create();

		// Token: 0x0402362D RID: 144941
		public readonly Vector LocationOffset = Vector.Create();

		// Token: 0x04023630 RID: 144944
		public readonly Vector WorldAabbMin = Vector.Create();

		// Token: 0x04023631 RID: 144945
		public readonly Vector WorldAabbMax = Vector.Create();
	}
}
