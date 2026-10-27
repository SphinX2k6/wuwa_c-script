using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007730 RID: 30512
	public static class TMoveSceneItemVerify
	{
		// Token: 0x06037733 RID: 227123 RVA: 0x00781D80 File Offset: 0x0077FF80
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICycleMoveToPointsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMoveToEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMoveToRelativePositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
