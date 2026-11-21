using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006729 RID: 26409
	public static class IActorFxEmoteType_UnionVerify
	{
		// Token: 0x0602CBA8 RID: 183208 RVA: 0x0061E620 File Offset: 0x0061C820
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
