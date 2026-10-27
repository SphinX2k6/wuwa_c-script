using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AEC RID: 15084
	public static class ITargetType_UnionVerify
	{
		// Token: 0x060148D3 RID: 84179 RVA: 0x002FE1A0 File Offset: 0x002FC3A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITargetPlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITargetLevelEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
