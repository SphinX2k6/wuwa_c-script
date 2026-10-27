using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004897 RID: 18583
	public static class IP4SyncData_UnionVerify
	{
		// Token: 0x0601CFFB RID: 118779 RVA: 0x00418C3C File Offset: 0x00416E3C
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
