using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005032 RID: 20530
	public static class IConveyorBeltField_UnionVerify
	{
		// Token: 0x06020E4C RID: 134732 RVA: 0x00492ED4 File Offset: 0x004910D4
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
