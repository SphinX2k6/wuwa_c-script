using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007183 RID: 29059
	public static class ISplineMoveConfig_UnionVerify
	{
		// Token: 0x06033853 RID: 211027 RVA: 0x006F0A54 File Offset: 0x006EEC54
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMoveConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenSplineMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseSplineMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
