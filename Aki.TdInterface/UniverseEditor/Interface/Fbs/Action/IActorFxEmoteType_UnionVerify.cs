using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C7 RID: 24775
	public static class IActorFxEmoteType_UnionVerify
	{
		// Token: 0x0602A4C7 RID: 173255 RVA: 0x005D4678 File Offset: 0x005D2878
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorFxEmoteTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorFxEmotePlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorFxEmoteStopVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
