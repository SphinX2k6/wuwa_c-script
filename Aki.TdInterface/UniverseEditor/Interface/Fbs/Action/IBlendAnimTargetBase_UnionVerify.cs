using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200620B RID: 25099
	public static class IBlendAnimTargetBase_UnionVerify
	{
		// Token: 0x0602B442 RID: 177218 RVA: 0x005F5C74 File Offset: 0x005F3E74
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerBlendAnimTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBlendAnimTargetBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
