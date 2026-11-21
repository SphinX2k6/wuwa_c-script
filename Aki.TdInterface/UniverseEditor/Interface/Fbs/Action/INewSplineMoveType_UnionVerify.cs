using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EB RID: 29419
	public static class INewSplineMoveType_UnionVerify
	{
		// Token: 0x060334BC RID: 210108 RVA: 0x006EB470 File Offset: 0x006E9670
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFrontAxleTrackingSplineMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INewSplineMoveTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
