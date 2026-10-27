using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4D RID: 23629
	public static class TInteractStyleVerify
	{
		// Token: 0x06028824 RID: 165924 RVA: 0x005927B4 File Offset: 0x005909B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInteractStylePanoramaVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractStyleEntityPartVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
