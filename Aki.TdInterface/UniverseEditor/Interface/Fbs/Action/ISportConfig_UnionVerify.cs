using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007976 RID: 31094
	public static class ISportConfig_UnionVerify
	{
		// Token: 0x06036C2B RID: 224299 RVA: 0x0075336C File Offset: 0x0075156C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISportConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISlideConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPetalGrabConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPetalFlyConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
