using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200661A RID: 26138
	public static class IDungeonEventType_UnionVerify
	{
		// Token: 0x0602D644 RID: 185924 RVA: 0x00638400 File Offset: 0x00636600
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
