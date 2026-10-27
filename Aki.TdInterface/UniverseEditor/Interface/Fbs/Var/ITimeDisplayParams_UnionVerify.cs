using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AFB RID: 15099
	public static class ITimeDisplayParams_UnionVerify
	{
		// Token: 0x06014940 RID: 84288 RVA: 0x002FEE6C File Offset: 0x002FD06C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITimeDisplayParamsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITimeDisplayParamsConstantVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITimeDisplayParamsVarVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
