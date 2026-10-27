using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C5 RID: 5573
	public enum FloroRanchUnitActionType
	{
		// Token: 0x0400BCC9 RID: 48329
		[OriginalName("OpBuff")]
		OpBuff,
		// Token: 0x0400BCCA RID: 48330
		[OriginalName("OpUnit")]
		OpUnit,
		// Token: 0x0400BCCB RID: 48331
		[OriginalName("UnitSettle")]
		UnitSettle,
		// Token: 0x0400BCCC RID: 48332
		[OriginalName("UnitResourcesChange")]
		UnitResourcesChange,
		// Token: 0x0400BCCD RID: 48333
		[OriginalName("Eating")]
		Eating,
		// Token: 0x0400BCCE RID: 48334
		[OriginalName("EvolveUpdate")]
		EvolveUpdate,
		// Token: 0x0400BCCF RID: 48335
		[OriginalName("Mix")]
		Mix,
		// Token: 0x0400BCD0 RID: 48336
		[OriginalName("Sacrifice")]
		Sacrifice,
		// Token: 0x0400BCD1 RID: 48337
		[OriginalName("DebugActionInfo")]
		DebugActionInfo,
		// Token: 0x0400BCD2 RID: 48338
		[OriginalName("BeEat")]
		BeEat,
		// Token: 0x0400BCD3 RID: 48339
		[OriginalName("ChangePoint")]
		ChangePoint,
		// Token: 0x0400BCD4 RID: 48340
		[OriginalName("ActionStop")]
		ActionStop,
		// Token: 0x0400BCD5 RID: 48341
		[OriginalName("ToyLvUp")]
		ToyLvUp,
		// Token: 0x0400BCD6 RID: 48342
		[OriginalName("ChangeTag")]
		ChangeTag,
		// Token: 0x0400BCD7 RID: 48343
		[OriginalName("StageTributeChange")]
		StageTributeChange,
		// Token: 0x0400BCD8 RID: 48344
		[OriginalName("SelfDefineValue")]
		SelfDefineValue
	}
}
