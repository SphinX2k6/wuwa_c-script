using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02005B97 RID: 23447
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class KeyPointState : IKeyPointState
	{
		// Token: 0x17006DEE RID: 28142
		// (get) Token: 0x06039ACA RID: 236234 RVA: 0x01031B22 File Offset: 0x0102FD22
		// (set) Token: 0x06039ACB RID: 236235 RVA: 0x01031B2A File Offset: 0x0102FD2A
		[RequiredMember]
		public IDragActorPlayKeyPointConfig Config { get; set; }

		// Token: 0x17006DEF RID: 28143
		// (get) Token: 0x06039ACC RID: 236236 RVA: 0x01031B33 File Offset: 0x0102FD33
		// (set) Token: 0x06039ACD RID: 236237 RVA: 0x01031B3B File Offset: 0x0102FD3B
		[RequiredMember]
		public Vector Position { get; set; }

		// Token: 0x17006DF0 RID: 28144
		// (get) Token: 0x06039ACE RID: 236238 RVA: 0x01031B44 File Offset: 0x0102FD44
		// (set) Token: 0x06039ACF RID: 236239 RVA: 0x01031B4C File Offset: 0x0102FD4C
		public bool IsInside { get; set; }

		// Token: 0x06039AD0 RID: 236240 RVA: 0x01031B55 File Offset: 0x0102FD55
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public KeyPointState()
		{
		}
	}
}
