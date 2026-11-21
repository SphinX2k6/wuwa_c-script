using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B77 RID: 27511
	public static class ICustomScreenLoadingTypeBase_UnionVerify
	{
		// Token: 0x0602F576 RID: 193910 RVA: 0x00675DE8 File Offset: 0x00673FE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICustomScreenLoadingCyberpunkVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICustomScreenLoadingTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
