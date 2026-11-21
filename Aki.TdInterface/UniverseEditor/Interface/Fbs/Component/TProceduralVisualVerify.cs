using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C0 RID: 25280
	public static class TProceduralVisualVerify
	{
		// Token: 0x0602AFA8 RID: 176040 RVA: 0x005DCBF8 File Offset: 0x005DADF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISearchlightRotateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IProceduralVisualLookAtVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
