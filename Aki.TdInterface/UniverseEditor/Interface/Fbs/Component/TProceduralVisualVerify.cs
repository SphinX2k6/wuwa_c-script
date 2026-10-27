using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8F RID: 23695
	public static class TProceduralVisualVerify
	{
		// Token: 0x06028962 RID: 166242 RVA: 0x005944C0 File Offset: 0x005926C0
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
