using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005305 RID: 21253
	public static class IGraph3dBase_UnionVerify
	{
		// Token: 0x06022B77 RID: 142199 RVA: 0x004CF9A0 File Offset: 0x004CDBA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGraph3dNormalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGraph3dBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
