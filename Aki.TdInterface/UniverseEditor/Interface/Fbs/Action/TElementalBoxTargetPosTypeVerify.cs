using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EBD RID: 32445
	public static class TElementalBoxTargetPosTypeVerify
	{
		// Token: 0x0603A90E RID: 239886 RVA: 0x007E195C File Offset: 0x007DFB5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IElementalBoxTargetRelativePosVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IElementalBoxTargetPrefabPosVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
