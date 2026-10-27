using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CF RID: 22991
	public class IStreamingRenderConfigT
	{
		// Token: 0x1700ACBC RID: 44220
		// (get) Token: 0x06027006 RID: 159750 RVA: 0x0055E154 File Offset: 0x0055C354
		// (set) Token: 0x06027007 RID: 159751 RVA: 0x0055E15C File Offset: 0x0055C35C
		public TPortalViewDistanceConfigUnion ViewDistance { get; set; }

		// Token: 0x1700ACBD RID: 44221
		// (get) Token: 0x06027008 RID: 159752 RVA: 0x0055E165 File Offset: 0x0055C365
		// (set) Token: 0x06027009 RID: 159753 RVA: 0x0055E16D File Offset: 0x0055C36D
		public List<IActorRefT> ForceRenderActors { get; set; }

		// Token: 0x1700ACBE RID: 44222
		// (get) Token: 0x0602700A RID: 159754 RVA: 0x0055E176 File Offset: 0x0055C376
		// (set) Token: 0x0602700B RID: 159755 RVA: 0x0055E17E File Offset: 0x0055C37E
		public List<IRenderFlagT> SetRenderFlags { get; set; }

		// Token: 0x1700ACBF RID: 44223
		// (get) Token: 0x0602700C RID: 159756 RVA: 0x0055E187 File Offset: 0x0055C387
		// (set) Token: 0x0602700D RID: 159757 RVA: 0x0055E18F File Offset: 0x0055C38F
		public IStreamingRtEffectRefT RtEffectRef { get; set; }

		// Token: 0x1700ACC0 RID: 44224
		// (get) Token: 0x0602700E RID: 159758 RVA: 0x0055E198 File Offset: 0x0055C398
		// (set) Token: 0x0602700F RID: 159759 RVA: 0x0055E1A0 File Offset: 0x0055C3A0
		public IRtSizeT RtData { get; set; }

		// Token: 0x1700ACC1 RID: 44225
		// (get) Token: 0x06027010 RID: 159760 RVA: 0x0055E1A9 File Offset: 0x0055C3A9
		// (set) Token: 0x06027011 RID: 159761 RVA: 0x0055E1B1 File Offset: 0x0055C3B1
		public string FallbackCubeMapTexturePath { get; set; }

		// Token: 0x1700ACC2 RID: 44226
		// (get) Token: 0x06027012 RID: 159762 RVA: 0x0055E1BA File Offset: 0x0055C3BA
		// (set) Token: 0x06027013 RID: 159763 RVA: 0x0055E1C2 File Offset: 0x0055C3C2
		public string FallbackCubeMapKey { get; set; }

		// Token: 0x1700ACC3 RID: 44227
		// (get) Token: 0x06027014 RID: 159764 RVA: 0x0055E1CB File Offset: 0x0055C3CB
		// (set) Token: 0x06027015 RID: 159765 RVA: 0x0055E1D3 File Offset: 0x0055C3D3
		public byte NullMask { get; set; }

		// Token: 0x06027016 RID: 159766 RVA: 0x0055E1DC File Offset: 0x0055C3DC
		public IStreamingRenderConfigT()
		{
			this.ViewDistance = null;
			this.ForceRenderActors = null;
			this.SetRenderFlags = null;
			this.RtEffectRef = null;
			this.RtData = null;
			this.FallbackCubeMapTexturePath = null;
			this.FallbackCubeMapKey = null;
			this.NullMask = 0;
		}
	}
}
