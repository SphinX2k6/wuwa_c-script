using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A2 RID: 29346
	public static class IMoveSceneItemType_UnionVerify
	{
		// Token: 0x0603323B RID: 209467 RVA: 0x006E66C0 File Offset: 0x006E48C0
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
