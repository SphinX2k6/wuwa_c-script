using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007123 RID: 28963
	public static class ILiveScOperation_UnionVerify
	{
		// Token: 0x060324FE RID: 206078 RVA: 0x006CD6A4 File Offset: 0x006CB8A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveScOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveSendScConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveClearScConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
