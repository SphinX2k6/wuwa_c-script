using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4C RID: 28492
	public static class IGroupAiCommunicateMode_UnionVerify
	{
		// Token: 0x060314FF RID: 201983 RVA: 0x006ADE78 File Offset: 0x006AC078
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
