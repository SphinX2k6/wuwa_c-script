using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FB RID: 16891
	public static class IDarkTideModule_UnionVerify
	{
		// Token: 0x06017711 RID: 96017 RVA: 0x0035944C File Offset: 0x0035764C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDarkTideBossEventModuleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDarkTideModuleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
