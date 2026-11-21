using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200514D RID: 20813
	public static class IMechCondition_UnionVerify
	{
		// Token: 0x06020BE0 RID: 134112 RVA: 0x00489200 File Offset: 0x00487400
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPlayerInMechVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMechConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
