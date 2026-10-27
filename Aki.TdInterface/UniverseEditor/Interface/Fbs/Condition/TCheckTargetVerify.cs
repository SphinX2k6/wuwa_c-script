using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D3E RID: 19774
	public static class TCheckTargetVerify
	{
		// Token: 0x0601F637 RID: 128567 RVA: 0x0045FE3C File Offset: 0x0045E03C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckTargetEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckOnlinePlayerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
