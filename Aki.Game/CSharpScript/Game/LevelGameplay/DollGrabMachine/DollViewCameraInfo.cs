using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EB5 RID: 28341
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DollViewCameraInfo
	{
		// Token: 0x17009A99 RID: 39577
		// (get) Token: 0x06045086 RID: 282758 RVA: 0x0110EC7F File Offset: 0x0110CE7F
		// (set) Token: 0x06045087 RID: 282759 RVA: 0x0110EC87 File Offset: 0x0110CE87
		[RequiredMember]
		public Vector Location { get; set; }

		// Token: 0x17009A9A RID: 39578
		// (get) Token: 0x06045088 RID: 282760 RVA: 0x0110EC90 File Offset: 0x0110CE90
		// (set) Token: 0x06045089 RID: 282761 RVA: 0x0110EC98 File Offset: 0x0110CE98
		[RequiredMember]
		public Rotator Rotation { get; set; }

		// Token: 0x17009A9B RID: 39579
		// (get) Token: 0x0604508A RID: 282762 RVA: 0x0110ECA1 File Offset: 0x0110CEA1
		// (set) Token: 0x0604508B RID: 282763 RVA: 0x0110ECA9 File Offset: 0x0110CEA9
		[RequiredMember]
		public float Fov { get; set; }

		// Token: 0x0604508C RID: 282764 RVA: 0x0110ECB2 File Offset: 0x0110CEB2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollViewCameraInfo()
		{
		}
	}
}
