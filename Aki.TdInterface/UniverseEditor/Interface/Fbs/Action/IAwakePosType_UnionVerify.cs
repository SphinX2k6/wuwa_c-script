using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006843 RID: 26691
	public static class IAwakePosType_UnionVerify
	{
		// Token: 0x0602D9EA RID: 186858 RVA: 0x0063DC8C File Offset: 0x0063BE8C
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
