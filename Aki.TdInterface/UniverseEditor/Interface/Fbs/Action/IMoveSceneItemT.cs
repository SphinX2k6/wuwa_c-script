using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729B RID: 29339
	public class IMoveSceneItemT
	{
		// Token: 0x1700D70C RID: 55052
		// (get) Token: 0x0603320C RID: 209420 RVA: 0x006E62CD File Offset: 0x006E44CD
		// (set) Token: 0x0603320D RID: 209421 RVA: 0x006E62D5 File Offset: 0x006E44D5
		public int EntityId { get; set; }

		// Token: 0x1700D70D RID: 55053
		// (get) Token: 0x0603320E RID: 209422 RVA: 0x006E62DE File Offset: 0x006E44DE
		// (set) Token: 0x0603320F RID: 209423 RVA: 0x006E62E6 File Offset: 0x006E44E6
		public bool StopBeforeMove { get; set; }

		// Token: 0x1700D70E RID: 55054
		// (get) Token: 0x06033210 RID: 209424 RVA: 0x006E62EF File Offset: 0x006E44EF
		// (set) Token: 0x06033211 RID: 209425 RVA: 0x006E62F7 File Offset: 0x006E44F7
		public TMoveSceneItemUnion MoveConfig { get; set; }

		// Token: 0x1700D70F RID: 55055
		// (get) Token: 0x06033212 RID: 209426 RVA: 0x006E6300 File Offset: 0x006E4500
		// (set) Token: 0x06033213 RID: 209427 RVA: 0x006E6308 File Offset: 0x006E4508
		public bool BypassClientResponse { get; set; }

		// Token: 0x1700D710 RID: 55056
		// (get) Token: 0x06033214 RID: 209428 RVA: 0x006E6311 File Offset: 0x006E4511
		// (set) Token: 0x06033215 RID: 209429 RVA: 0x006E6319 File Offset: 0x006E4519
		public byte NullMask { get; set; }

		// Token: 0x06033216 RID: 209430 RVA: 0x006E6322 File Offset: 0x006E4522
		public IMoveSceneItemT()
		{
			this.EntityId = 0;
			this.StopBeforeMove = false;
			this.MoveConfig = null;
			this.BypassClientResponse = false;
			this.NullMask = 0;
		}
	}
}
