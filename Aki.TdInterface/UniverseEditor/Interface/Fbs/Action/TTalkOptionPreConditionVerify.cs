using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008005 RID: 32773
	public static class TTalkOptionPreConditionVerify
	{
		// Token: 0x0603AFB0 RID: 241584 RVA: 0x007EBA08 File Offset: 0x007E9C08
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
