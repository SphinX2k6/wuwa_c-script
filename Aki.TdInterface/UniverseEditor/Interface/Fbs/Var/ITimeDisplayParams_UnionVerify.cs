using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EFD RID: 16125
	public static class ITimeDisplayParams_UnionVerify
	{
		// Token: 0x06015DEA RID: 89578 RVA: 0x003250FC File Offset: 0x003232FC
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
