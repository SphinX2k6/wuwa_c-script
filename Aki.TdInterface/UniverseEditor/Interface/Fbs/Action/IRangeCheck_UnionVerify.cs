using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0F RID: 28175
	public static class IRangeCheck_UnionVerify
	{
		// Token: 0x06031C85 RID: 203909 RVA: 0x006BD7DC File Offset: 0x006BB9DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IConeRangeCheckVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRangeCheckVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
