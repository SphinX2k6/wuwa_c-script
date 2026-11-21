using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F41 RID: 24385
	public static class ISlidePerformType_UnionVerify
	{
		// Token: 0x06028F8B RID: 167819 RVA: 0x00598F34 File Offset: 0x00597134
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISlopeSlidePerformVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISlidePerformTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
