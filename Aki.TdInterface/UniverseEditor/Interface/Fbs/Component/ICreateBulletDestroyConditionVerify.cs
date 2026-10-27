using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005044 RID: 20548
	public static class ICreateBulletDestroyConditionVerify
	{
		// Token: 0x06020ECA RID: 134858 RVA: 0x00493BEA File Offset: 0x00491DEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
