using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005254 RID: 21076
	public static class IFillType_UnionVerify
	{
		// Token: 0x06022488 RID: 140424 RVA: 0x004C0FE8 File Offset: 0x004BF1E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFillTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFixedFillVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDirectionFillVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
