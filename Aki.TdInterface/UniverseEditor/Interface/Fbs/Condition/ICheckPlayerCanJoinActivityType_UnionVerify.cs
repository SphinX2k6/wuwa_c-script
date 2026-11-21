using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB5 RID: 20405
	public static class ICheckPlayerCanJoinActivityType_UnionVerify
	{
		// Token: 0x0601FCD4 RID: 130260 RVA: 0x0046AFE0 File Offset: 0x004691E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPlayerCanJoinRogueVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckPlayerCanJoinActivityTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
