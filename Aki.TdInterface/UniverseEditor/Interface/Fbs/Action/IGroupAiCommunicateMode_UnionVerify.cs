using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AB RID: 26795
	public static class IGroupAiCommunicateMode_UnionVerify
	{
		// Token: 0x0602EBC5 RID: 191429 RVA: 0x0065EDF8 File Offset: 0x0065CFF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGroupAiCommunicateModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGroupAiCommunicateAddTagVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGroupAiCommunicateRemoveTagVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
