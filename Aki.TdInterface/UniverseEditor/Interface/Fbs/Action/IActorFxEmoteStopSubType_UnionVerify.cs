using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006723 RID: 26403
	public static class IActorFxEmoteStopSubType_UnionVerify
	{
		// Token: 0x0602CB88 RID: 183176 RVA: 0x0061E360 File Offset: 0x0061C560
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorFxEmoteStopSubTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorFxEmoteStopAllVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorFxEmoteStopSocketsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
