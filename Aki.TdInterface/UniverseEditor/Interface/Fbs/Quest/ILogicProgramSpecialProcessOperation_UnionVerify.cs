using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200435A RID: 17242
	public static class ILogicProgramSpecialProcessOperation_UnionVerify
	{
		// Token: 0x0601854F RID: 99663 RVA: 0x003786B4 File Offset: 0x003768B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDisableUroVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILogicProgramSpecialProcessOperationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
