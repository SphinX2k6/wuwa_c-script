using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EB RID: 16875
	public class ITrackCaptureVisionsT
	{
		// Token: 0x170077B9 RID: 30649
		// (get) Token: 0x06018E32 RID: 101938 RVA: 0x00394A96 File Offset: 0x00392C96
		// (set) Token: 0x06018E33 RID: 101939 RVA: 0x00394A9E File Offset: 0x00392C9E
		public ETrackType Type { get; set; }

		// Token: 0x170077BA RID: 30650
		// (get) Token: 0x06018E34 RID: 101940 RVA: 0x00394AA7 File Offset: 0x00392CA7
		// (set) Token: 0x06018E35 RID: 101941 RVA: 0x00394AAF File Offset: 0x00392CAF
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x170077BB RID: 30651
		// (get) Token: 0x06018E36 RID: 101942 RVA: 0x00394AB8 File Offset: 0x00392CB8
		// (set) Token: 0x06018E37 RID: 101943 RVA: 0x00394AC0 File Offset: 0x00392CC0
		public List<int> VisionDropEntities { get; set; }

		// Token: 0x06018E38 RID: 101944 RVA: 0x00394AC9 File Offset: 0x00392CC9
		public ITrackCaptureVisionsT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.VisionDropEntities = null;
		}
	}
}
