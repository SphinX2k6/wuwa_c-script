using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007751 RID: 30545
	public static class TPhoneSystemInteractVerify
	{
		// Token: 0x060377DD RID: 227293 RVA: 0x00782D94 File Offset: 0x00780F94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDeletePhoneMessageVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFlowOpenPhoneMessageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOpenPhoneMessageBoardVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISendPhoneMessageVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
