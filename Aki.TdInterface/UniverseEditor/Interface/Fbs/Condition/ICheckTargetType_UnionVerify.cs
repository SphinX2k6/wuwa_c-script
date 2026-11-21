using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200503F RID: 20543
	public static class ICheckTargetType_UnionVerify
	{
		// Token: 0x06020194 RID: 131476 RVA: 0x00473F1C File Offset: 0x0047211C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAllPlayerTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckTargetTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
