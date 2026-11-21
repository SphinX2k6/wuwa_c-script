using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8B RID: 27787
	public static class IDungeonEventType_UnionVerify
	{
		// Token: 0x0602FE15 RID: 196117 RVA: 0x00684F68 File Offset: 0x00683168
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRecordTimeStampTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDungeonEventTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
