using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F67 RID: 16231
	public static class IOperation_UnionVerify
	{
		// Token: 0x06017167 RID: 94567 RVA: 0x00353CC4 File Offset: 0x00351EC4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableHLODVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAssignLoadingBackgroundVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
