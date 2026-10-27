using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200523A RID: 21050
	[NullableContext(1)]
	public interface IPhantomArenaSkillData
	{
		// Token: 0x1700823D RID: 33341
		// (get) Token: 0x06035C65 RID: 220261
		// (set) Token: 0x06035C66 RID: 220262
		bool IsOwn { get; set; }

		// Token: 0x1700823E RID: 33342
		// (get) Token: 0x06035C67 RID: 220263
		// (set) Token: 0x06035C68 RID: 220264
		int SkillId { get; set; }

		// Token: 0x1700823F RID: 33343
		// (get) Token: 0x06035C69 RID: 220265
		// (set) Token: 0x06035C6A RID: 220266
		bool IsPassive { get; set; }

		// Token: 0x17008240 RID: 33344
		// (get) Token: 0x06035C6B RID: 220267
		// (set) Token: 0x06035C6C RID: 220268
		string Icon { get; set; }

		// Token: 0x17008241 RID: 33345
		// (get) Token: 0x06035C6D RID: 220269
		// (set) Token: 0x06035C6E RID: 220270
		string SkillName { get; set; }

		// Token: 0x17008242 RID: 33346
		// (get) Token: 0x06035C6F RID: 220271
		// (set) Token: 0x06035C70 RID: 220272
		string SkillDesc { get; set; }

		// Token: 0x17008243 RID: 33347
		// (get) Token: 0x06035C71 RID: 220273
		// (set) Token: 0x06035C72 RID: 220274
		List<string> SkillDescParams { get; set; }

		// Token: 0x17008244 RID: 33348
		// (get) Token: 0x06035C73 RID: 220275
		// (set) Token: 0x06035C74 RID: 220276
		int CostConsume { get; set; }
	}
}
