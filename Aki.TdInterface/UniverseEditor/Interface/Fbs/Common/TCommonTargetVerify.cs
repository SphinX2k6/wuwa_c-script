using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B1 RID: 25777
	public static class TCommonTargetVerify
	{
		// Token: 0x0602BD36 RID: 179510 RVA: 0x005F5D74 File Offset: 0x005F3F74
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAssistCharacterTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
