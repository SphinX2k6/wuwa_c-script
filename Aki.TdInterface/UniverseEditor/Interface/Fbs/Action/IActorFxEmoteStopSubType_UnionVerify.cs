using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C1 RID: 24769
	public static class IActorFxEmoteStopSubType_UnionVerify
	{
		// Token: 0x0602A4A7 RID: 173223 RVA: 0x005D43B8 File Offset: 0x005D25B8
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
