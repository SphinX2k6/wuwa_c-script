using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004537 RID: 17719
	public static class IRollBlockStartupMethodBase_UnionVerify
	{
		// Token: 0x06019A6B RID: 105067 RVA: 0x003A71EC File Offset: 0x003A53EC
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
