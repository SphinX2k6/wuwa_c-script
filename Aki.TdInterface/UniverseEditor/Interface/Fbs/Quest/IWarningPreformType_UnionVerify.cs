using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F6 RID: 18166
	public static class IWarningPreformType_UnionVerify
	{
		// Token: 0x0601ABA0 RID: 109472 RVA: 0x003CC4AC File Offset: 0x003CA6AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWarningPreformTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWarningPreformFadeInScreenVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWarningPreformActivateStateRecordEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
