using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007437 RID: 29751
	public class IPhotographConfigT
	{
		// Token: 0x1700DA81 RID: 55937
		// (get) Token: 0x060340E4 RID: 213220 RVA: 0x00703DB5 File Offset: 0x00701FB5
		// (set) Token: 0x060340E5 RID: 213221 RVA: 0x00703DBD File Offset: 0x00701FBD
		public List<int> PhotoTargets { get; set; }

		// Token: 0x1700DA82 RID: 55938
		// (get) Token: 0x060340E6 RID: 213222 RVA: 0x00703DC6 File Offset: 0x00701FC6
		// (set) Token: 0x060340E7 RID: 213223 RVA: 0x00703DCE File Offset: 0x00701FCE
		public IPhotographPlayerPerformT PlayerPerform { get; set; }

		// Token: 0x1700DA83 RID: 55939
		// (get) Token: 0x060340E8 RID: 213224 RVA: 0x00703DD7 File Offset: 0x00701FD7
		// (set) Token: 0x060340E9 RID: 213225 RVA: 0x00703DDF File Offset: 0x00701FDF
		public IPhotographCameraParamsT CameraParams { get; set; }

		// Token: 0x1700DA84 RID: 55940
		// (get) Token: 0x060340EA RID: 213226 RVA: 0x00703DE8 File Offset: 0x00701FE8
		// (set) Token: 0x060340EB RID: 213227 RVA: 0x00703DF0 File Offset: 0x00701FF0
		public byte NullMask { get; set; }

		// Token: 0x060340EC RID: 213228 RVA: 0x00703DF9 File Offset: 0x00701FF9
		public IPhotographConfigT()
		{
			this.PhotoTargets = null;
			this.PlayerPerform = null;
			this.CameraParams = null;
			this.NullMask = 0;
		}
	}
}
