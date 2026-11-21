using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E26 RID: 24102
	public static class IRefreshConditionBase_UnionVerify
	{
		// Token: 0x0602840D RID: 164877 RVA: 0x005810E8 File Offset: 0x0057F2E8
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
