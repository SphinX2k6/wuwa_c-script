using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5C RID: 27484
	public static class IMoveSceneItemType_UnionVerify
	{
		// Token: 0x060303E4 RID: 197604 RVA: 0x0068E104 File Offset: 0x0068C304
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMoveSceneItemTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICycleMoveToPointsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMoveToRelativePositionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMoveToEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
