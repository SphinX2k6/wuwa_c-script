using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB3 RID: 27827
	public static class IPhoneSystemInteractBase_UnionVerify
	{
		// Token: 0x0603109E RID: 200862 RVA: 0x006A7D94 File Offset: 0x006A5F94
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
