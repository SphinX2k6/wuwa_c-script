using System;

namespace System
{
	// Token: 0x0200015B RID: 347
	internal enum LazyState
	{
		// Token: 0x040004CA RID: 1226
		NoneViaConstructor,
		// Token: 0x040004CB RID: 1227
		NoneViaFactory,
		// Token: 0x040004CC RID: 1228
		NoneException,
		// Token: 0x040004CD RID: 1229
		PublicationOnlyViaConstructor,
		// Token: 0x040004CE RID: 1230
		PublicationOnlyViaFactory,
		// Token: 0x040004CF RID: 1231
		PublicationOnlyWait,
		// Token: 0x040004D0 RID: 1232
		PublicationOnlyException,
		// Token: 0x040004D1 RID: 1233
		ExecutionAndPublicationViaConstructor,
		// Token: 0x040004D2 RID: 1234
		ExecutionAndPublicationViaFactory,
		// Token: 0x040004D3 RID: 1235
		ExecutionAndPublicationException
	}
}
