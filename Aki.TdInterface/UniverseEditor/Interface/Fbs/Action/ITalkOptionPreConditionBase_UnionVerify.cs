using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B17 RID: 31511
	public static class ITalkOptionPreConditionBase_UnionVerify
	{
		// Token: 0x06038BD8 RID: 232408 RVA: 0x007ACAAC File Offset: 0x007AACAC
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
