using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC1 RID: 27841
	public class IPhotographConfigT
	{
		// Token: 0x1700CF44 RID: 53060
		// (get) Token: 0x0603110D RID: 200973 RVA: 0x006A8B81 File Offset: 0x006A6D81
		// (set) Token: 0x0603110E RID: 200974 RVA: 0x006A8B89 File Offset: 0x006A6D89
		public List<int> PhotoTargets { get; set; }

		// Token: 0x1700CF45 RID: 53061
		// (get) Token: 0x0603110F RID: 200975 RVA: 0x006A8B92 File Offset: 0x006A6D92
		// (set) Token: 0x06031110 RID: 200976 RVA: 0x006A8B9A File Offset: 0x006A6D9A
		public IPhotographPlayerPerformT PlayerPerform { get; set; }

		// Token: 0x1700CF46 RID: 53062
		// (get) Token: 0x06031111 RID: 200977 RVA: 0x006A8BA3 File Offset: 0x006A6DA3
		// (set) Token: 0x06031112 RID: 200978 RVA: 0x006A8BAB File Offset: 0x006A6DAB
		public IPhotographCameraParamsT CameraParams { get; set; }

		// Token: 0x1700CF47 RID: 53063
		// (get) Token: 0x06031113 RID: 200979 RVA: 0x006A8BB4 File Offset: 0x006A6DB4
		// (set) Token: 0x06031114 RID: 200980 RVA: 0x006A8BBC File Offset: 0x006A6DBC
		public byte NullMask { get; set; }

		// Token: 0x06031115 RID: 200981 RVA: 0x006A8BC5 File Offset: 0x006A6DC5
		public IPhotographConfigT()
		{
			this.PhotoTargets = null;
			this.PlayerPerform = null;
			this.CameraParams = null;
			this.NullMask = 0;
		}
	}
}
