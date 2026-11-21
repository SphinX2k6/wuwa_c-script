using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F7A RID: 32634
	public static class TPhoneSystemInteractVerify
	{
		// Token: 0x0603AD1A RID: 240922 RVA: 0x007E7D68 File Offset: 0x007E5F68
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
