using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007449 RID: 29769
	public class IPlayBubbleT
	{
		// Token: 0x1700DAAC RID: 55980
		// (get) Token: 0x06034188 RID: 213384 RVA: 0x00705081 File Offset: 0x00703281
		// (set) Token: 0x06034189 RID: 213385 RVA: 0x00705089 File Offset: 0x00703289
		public int EntityId { get; set; }

		// Token: 0x1700DAAD RID: 55981
		// (get) Token: 0x0603418A RID: 213386 RVA: 0x00705092 File Offset: 0x00703292
		// (set) Token: 0x0603418B RID: 213387 RVA: 0x0070509A File Offset: 0x0070329A
		public IBubbleIndexT Flow { get; set; }

		// Token: 0x1700DAAE RID: 55982
		// (get) Token: 0x0603418C RID: 213388 RVA: 0x007050A3 File Offset: 0x007032A3
		// (set) Token: 0x0603418D RID: 213389 RVA: 0x007050AB File Offset: 0x007032AB
		public bool IsRangeFollowEntity { get; set; }

		// Token: 0x1700DAAF RID: 55983
		// (get) Token: 0x0603418E RID: 213390 RVA: 0x007050B4 File Offset: 0x007032B4
		// (set) Token: 0x0603418F RID: 213391 RVA: 0x007050BC File Offset: 0x007032BC
		public bool IsAudioOccludedByScene { get; set; }

		// Token: 0x1700DAB0 RID: 55984
		// (get) Token: 0x06034190 RID: 213392 RVA: 0x007050C5 File Offset: 0x007032C5
		// (set) Token: 0x06034191 RID: 213393 RVA: 0x007050CD File Offset: 0x007032CD
		public IBubbleRangeCylinderConfigT TriggerCylinderConfig { get; set; }

		// Token: 0x1700DAB1 RID: 55985
		// (get) Token: 0x06034192 RID: 213394 RVA: 0x007050D6 File Offset: 0x007032D6
		// (set) Token: 0x06034193 RID: 213395 RVA: 0x007050DE File Offset: 0x007032DE
		public bool IsPlayMouthAnim { get; set; }

		// Token: 0x1700DAB2 RID: 55986
		// (get) Token: 0x06034194 RID: 213396 RVA: 0x007050E7 File Offset: 0x007032E7
		// (set) Token: 0x06034195 RID: 213397 RVA: 0x007050EF File Offset: 0x007032EF
		public byte NullMask { get; set; }

		// Token: 0x06034196 RID: 213398 RVA: 0x007050F8 File Offset: 0x007032F8
		public IPlayBubbleT()
		{
			this.EntityId = 0;
			this.Flow = null;
			this.IsRangeFollowEntity = false;
			this.IsAudioOccludedByScene = false;
			this.TriggerCylinderConfig = null;
			this.IsPlayMouthAnim = false;
			this.NullMask = 0;
		}
	}
}
