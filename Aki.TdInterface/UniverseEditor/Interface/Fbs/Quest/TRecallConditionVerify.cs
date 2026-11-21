using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004763 RID: 18275
	public static class TRecallConditionVerify
	{
		// Token: 0x0601AEAA RID: 110250 RVA: 0x003D15B8 File Offset: 0x003CF7B8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRecallConditionByEntityTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRecallConditionByGroupVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRecallConditionByTemplateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
