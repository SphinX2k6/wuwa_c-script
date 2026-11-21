using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043CF RID: 17359
	public static class IPhotographSubTarget_UnionVerify
	{
		// Token: 0x06018A5A RID: 100954 RVA: 0x00383E18 File Offset: 0x00382018
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotographSubTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotographSubTargetSpecificRoleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotographSubTargetAnyRoleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
