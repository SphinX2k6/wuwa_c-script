using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007429 RID: 29737
	public static class IPhoneSystemInteractBase_UnionVerify
	{
		// Token: 0x06034075 RID: 213109 RVA: 0x00702FC8 File Offset: 0x007011C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhoneSystemInteractBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISendPhoneMessageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDeletePhoneMessageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IOpenPhoneMessageBoardVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFlowOpenPhoneMessageVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
