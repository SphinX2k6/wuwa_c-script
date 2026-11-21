using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02005F9D RID: 24477
	[NullableContext(2)]
	[Nullable(0)]
	public class GravityFlipViewOpenParam : IGravityFlipViewOpenParam
	{
		// Token: 0x17006EFF RID: 28415
		// (get) Token: 0x0603ACFF RID: 240895 RVA: 0x010A08E6 File Offset: 0x0109EAE6
		// (set) Token: 0x0603AD00 RID: 240896 RVA: 0x010A08EE File Offset: 0x0109EAEE
		public Action<int> SelectCallback { get; set; }
	}
}
