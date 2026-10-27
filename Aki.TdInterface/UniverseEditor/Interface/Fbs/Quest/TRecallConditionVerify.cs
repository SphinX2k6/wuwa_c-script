using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004304 RID: 17156
	public static class TRecallConditionVerify
	{
		// Token: 0x06019728 RID: 104232 RVA: 0x003A5C88 File Offset: 0x003A3E88
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
