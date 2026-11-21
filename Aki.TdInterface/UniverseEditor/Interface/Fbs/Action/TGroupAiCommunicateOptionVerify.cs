using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF0 RID: 32496
	public static class TGroupAiCommunicateOptionVerify
	{
		// Token: 0x0603AA14 RID: 240148 RVA: 0x007E31FC File Offset: 0x007E13FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGroupAiCommunicateRemoveTagVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGroupAiCommunicateAddTagVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
