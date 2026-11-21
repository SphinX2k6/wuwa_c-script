using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005591 RID: 21905
	public static class IConveyorBeltField_UnionVerify
	{
		// Token: 0x06022D6C RID: 142700 RVA: 0x004CC924 File Offset: 0x004CAB24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConveyorBeltFieldVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDirectionalFieldVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPointFieldVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
