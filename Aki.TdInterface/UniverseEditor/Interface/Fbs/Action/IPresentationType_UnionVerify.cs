using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752A RID: 29994
	public static class IPresentationType_UnionVerify
	{
		// Token: 0x06034992 RID: 215442 RVA: 0x00714058 File Offset: 0x00712258
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
