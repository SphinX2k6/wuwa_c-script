using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581F RID: 22559
	public static class IRefreshConditionBase_UnionVerify
	{
		// Token: 0x06025EED RID: 155373 RVA: 0x0053AF5C File Offset: 0x0053915C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRefreshConditionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRefreshOnDeathVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRefreshOnHostInteractVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
