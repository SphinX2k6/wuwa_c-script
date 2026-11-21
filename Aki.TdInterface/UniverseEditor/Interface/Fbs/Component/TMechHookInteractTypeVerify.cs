using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006284 RID: 25220
	public static class TMechHookInteractTypeVerify
	{
		// Token: 0x0602AE84 RID: 175748 RVA: 0x005DB10C File Offset: 0x005D930C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechBurrowHookInteractVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechFixedPointHookInteractVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechPullHookInteractVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
