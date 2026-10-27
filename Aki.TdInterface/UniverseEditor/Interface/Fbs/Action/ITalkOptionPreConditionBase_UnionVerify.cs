using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733F RID: 29503
	public static class ITalkOptionPreConditionBase_UnionVerify
	{
		// Token: 0x060358A5 RID: 219301 RVA: 0x0074AF24 File Offset: 0x00749124
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkOptionPreConditionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkOptionPreOptionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkOptionConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkOptionFirstSelectVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
