using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006272 RID: 25202
	public static class TInteractStyleVerify
	{
		// Token: 0x0602AE32 RID: 175666 RVA: 0x005DA9CC File Offset: 0x005D8BCC
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
