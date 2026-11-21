using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006035 RID: 24629
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DollViewCameraInfo
	{
		// Token: 0x17006FD0 RID: 28624
		// (get) Token: 0x0603B227 RID: 242215 RVA: 0x010B8D5B File Offset: 0x010B6F5B
		// (set) Token: 0x0603B228 RID: 242216 RVA: 0x010B8D63 File Offset: 0x010B6F63
		[RequiredMember]
		public Vector Location { get; set; }

		// Token: 0x17006FD1 RID: 28625
		// (get) Token: 0x0603B229 RID: 242217 RVA: 0x010B8D6C File Offset: 0x010B6F6C
		// (set) Token: 0x0603B22A RID: 242218 RVA: 0x010B8D74 File Offset: 0x010B6F74
		[RequiredMember]
		public Rotator Rotation { get; set; }

		// Token: 0x17006FD2 RID: 28626
		// (get) Token: 0x0603B22B RID: 242219 RVA: 0x010B8D7D File Offset: 0x010B6F7D
		// (set) Token: 0x0603B22C RID: 242220 RVA: 0x010B8D85 File Offset: 0x010B6F85
		[RequiredMember]
		public float Fov { get; set; }

		// Token: 0x0603B22D RID: 242221 RVA: 0x010B8D8E File Offset: 0x010B6F8E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollViewCameraInfo()
		{
		}
	}
}
