using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045BB RID: 17851
	public static class ISystemPromptType_UnionVerify
	{
		// Token: 0x0601A0AC RID: 106668 RVA: 0x003B608C File Offset: 0x003B428C
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
