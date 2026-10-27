using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200408A RID: 16522
	public static class IRecallData_UnionVerify
	{
		// Token: 0x06018090 RID: 98448 RVA: 0x003777B0 File Offset: 0x003759B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRecallDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestRecallDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILevelPlayRecallDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
