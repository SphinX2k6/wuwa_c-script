using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x02006373 RID: 25459
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleLevelInfoTargetData : IPinballBattleLevelInfoTargetData
	{
		// Token: 0x17009349 RID: 37705
		// (get) Token: 0x0604009E RID: 262302 RVA: 0x00F7E228 File Offset: 0x00F7C428
		// (set) Token: 0x0604009F RID: 262303 RVA: 0x00F7E230 File Offset: 0x00F7C430
		public bool IsSpecial { get; set; }

		// Token: 0x1700934A RID: 37706
		// (get) Token: 0x060400A0 RID: 262304 RVA: 0x00F7E239 File Offset: 0x00F7C439
		// (set) Token: 0x060400A1 RID: 262305 RVA: 0x00F7E241 File Offset: 0x00F7C441
		public bool IsFinish { get; set; }

		// Token: 0x1700934B RID: 37707
		// (get) Token: 0x060400A2 RID: 262306 RVA: 0x00F7E24A File Offset: 0x00F7C44A
		// (set) Token: 0x060400A3 RID: 262307 RVA: 0x00F7E252 File Offset: 0x00F7C452
		public string Desc { get; set; }

		// Token: 0x1700934C RID: 37708
		// (get) Token: 0x060400A4 RID: 262308 RVA: 0x00F7E25B File Offset: 0x00F7C45B
		// (set) Token: 0x060400A5 RID: 262309 RVA: 0x00F7E263 File Offset: 0x00F7C463
		public int Value { get; set; }
	}
}
