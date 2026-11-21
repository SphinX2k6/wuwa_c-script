using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588B RID: 22667
	public static class IGraph3dBase_UnionVerify
	{
		// Token: 0x06024C2B RID: 150571 RVA: 0x0050C874 File Offset: 0x0050AA74
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
