using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D1 RID: 29905
	public static class IUnlockCookSystemType_UnionVerify
	{
		// Token: 0x060365DE RID: 222686 RVA: 0x00763274 File Offset: 0x00761474
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IUnlockCookSystemCookBookVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IUnlockCookSystemTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
