using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B3 RID: 20915
	public static class IRoleLevelType_UnionVerify
	{
		// Token: 0x06020ECA RID: 134858 RVA: 0x0048DDCC File Offset: 0x0048BFCC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpecifyRoleLevelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRoleLevelTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
