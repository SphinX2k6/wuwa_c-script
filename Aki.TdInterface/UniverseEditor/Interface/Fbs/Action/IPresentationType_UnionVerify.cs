using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAF RID: 28079
	public static class IPresentationType_UnionVerify
	{
		// Token: 0x06031996 RID: 203158 RVA: 0x006B8970 File Offset: 0x006B6B70
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResetPresentationFailureVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPresentationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
