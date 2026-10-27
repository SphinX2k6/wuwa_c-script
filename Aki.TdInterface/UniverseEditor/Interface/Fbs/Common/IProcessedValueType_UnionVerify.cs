using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E4A RID: 24138
	public static class IProcessedValueType_UnionVerify
	{
		// Token: 0x06029520 RID: 169248 RVA: 0x005AA3E0 File Offset: 0x005A85E0
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
