using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005597 RID: 21911
	public static class IConveyorBeltMove_UnionVerify
	{
		// Token: 0x06022D8A RID: 142730 RVA: 0x004CCBAC File Offset: 0x004CADAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFixSpeedVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IConveyorBeltMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
