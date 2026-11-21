using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F59 RID: 32601
	public static class TMoveSceneItemVerify
	{
		// Token: 0x0603AC6E RID: 240750 RVA: 0x007E6D10 File Offset: 0x007E4F10
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
