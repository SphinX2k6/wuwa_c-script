using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F91 RID: 16273
	public static class ISyncBlockRefVerify
	{
		// Token: 0x060162EB RID: 90859 RVA: 0x0032E3F2 File Offset: 0x0032C5F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
