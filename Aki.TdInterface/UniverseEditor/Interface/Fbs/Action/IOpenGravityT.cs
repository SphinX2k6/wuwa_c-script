using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007368 RID: 29544
	public class IOpenGravityT
	{
		// Token: 0x1700D8B2 RID: 55474
		// (get) Token: 0x060338FA RID: 211194 RVA: 0x006F2FF4 File Offset: 0x006F11F4
		// (set) Token: 0x060338FB RID: 211195 RVA: 0x006F2FFC File Offset: 0x006F11FC
		public ESetTeleControlType Type { get; set; }

		// Token: 0x1700D8B3 RID: 55475
		// (get) Token: 0x060338FC RID: 211196 RVA: 0x006F3005 File Offset: 0x006F1205
		// (set) Token: 0x060338FD RID: 211197 RVA: 0x006F300D File Offset: 0x006F120D
		public int EntityId { get; set; }

		// Token: 0x1700D8B4 RID: 55476
		// (get) Token: 0x060338FE RID: 211198 RVA: 0x006F3016 File Offset: 0x006F1216
		// (set) Token: 0x060338FF RID: 211199 RVA: 0x006F301E File Offset: 0x006F121E
		public int PositionEntityId { get; set; }

		// Token: 0x1700D8B5 RID: 55477
		// (get) Token: 0x06033900 RID: 211200 RVA: 0x006F3027 File Offset: 0x006F1227
		// (set) Token: 0x06033901 RID: 211201 RVA: 0x006F302F File Offset: 0x006F122F
		public byte NullMask { get; set; }

		// Token: 0x06033902 RID: 211202 RVA: 0x006F3038 File Offset: 0x006F1238
		public IOpenGravityT()
		{
			this.Type = ESetTeleControlType.OpenGravity;
			this.EntityId = 0;
			this.PositionEntityId = 0;
			this.NullMask = 0;
		}
	}
}
