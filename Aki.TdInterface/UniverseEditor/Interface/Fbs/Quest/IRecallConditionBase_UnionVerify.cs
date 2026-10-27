using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004078 RID: 16504
	public static class IRecallConditionBase_UnionVerify
	{
		// Token: 0x06017FE0 RID: 98272 RVA: 0x00376418 File Offset: 0x00374618
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRecallConditionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRecallConditionByEntityTypeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRecallConditionByTemplateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRecallConditionByGroupVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
