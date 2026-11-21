using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B9 RID: 17593
	public static class IRecallConditionBase_UnionVerify
	{
		// Token: 0x06019679 RID: 104057 RVA: 0x003A0250 File Offset: 0x0039E450
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
