using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200648A RID: 25738
	public static class IProcessedValueType_UnionVerify
	{
		// Token: 0x0602BBBC RID: 179132 RVA: 0x005F3288 File Offset: 0x005F1488
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IProcessedValueTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IProcessedValueConstantVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IProcessedValueConstraintVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
