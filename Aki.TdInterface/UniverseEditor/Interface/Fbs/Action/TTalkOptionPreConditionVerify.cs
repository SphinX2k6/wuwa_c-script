using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CD RID: 30669
	public static class TTalkOptionPreConditionVerify
	{
		// Token: 0x06037A2B RID: 227883 RVA: 0x007863A4 File Offset: 0x007845A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkOptionConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkOptionFirstSelectVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkOptionPreOptionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkOptionSystemConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
