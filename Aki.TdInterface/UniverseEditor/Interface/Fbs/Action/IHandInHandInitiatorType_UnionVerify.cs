using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F76 RID: 28534
	public static class IHandInHandInitiatorType_UnionVerify
	{
		// Token: 0x06031637 RID: 202295 RVA: 0x006B2980 File Offset: 0x006B0B80
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHandInHandInitiatorTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerHandInHandInitiatorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityHandInHandInitiatorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
