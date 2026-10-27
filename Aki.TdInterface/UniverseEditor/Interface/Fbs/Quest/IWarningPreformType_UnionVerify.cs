using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429A RID: 17050
	public static class IWarningPreformType_UnionVerify
	{
		// Token: 0x06019434 RID: 103476 RVA: 0x003A0DD4 File Offset: 0x0039EFD4
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
