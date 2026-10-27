using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D5 RID: 25045
	public static class IAwakePosType_UnionVerify
	{
		// Token: 0x0602B2A3 RID: 176803 RVA: 0x005F3218 File Offset: 0x005F1418
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAwakeWithTransformVarVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAwakePosTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
