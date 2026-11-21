using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CFC RID: 19708
	public static class IP4SyncData_UnionVerify
	{
		// Token: 0x0601E7E8 RID: 124904 RVA: 0x004453D8 File Offset: 0x004435D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IP4SyncDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEditorSaviorSyncDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUgsSyncDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
