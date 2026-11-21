using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD6 RID: 23254
	public static class IMechHookInteractType_UnionVerify
	{
		// Token: 0x060262A5 RID: 156325 RVA: 0x0053AC6C File Offset: 0x00538E6C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechHookInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechBurrowHookInteractVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechFixedPointHookInteractVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
