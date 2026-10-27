using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004177 RID: 16759
	public static class ISystemPromptType_UnionVerify
	{
		// Token: 0x060189E4 RID: 100836 RVA: 0x0038BAD0 File Offset: 0x00389CD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAreaNameSystemPromptVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISystemPromptTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
