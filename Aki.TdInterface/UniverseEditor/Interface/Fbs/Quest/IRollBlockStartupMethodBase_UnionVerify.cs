using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F6 RID: 16630
	public static class IRollBlockStartupMethodBase_UnionVerify
	{
		// Token: 0x060183CA RID: 99274 RVA: 0x0037D29C File Offset: 0x0037B49C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockStartupMethodBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockLaunchMethodInteractVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockLaunchMethodRangeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
