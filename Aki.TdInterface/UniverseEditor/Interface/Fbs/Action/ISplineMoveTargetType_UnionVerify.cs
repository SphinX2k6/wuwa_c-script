using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007195 RID: 29077
	public static class ISplineMoveTargetType_UnionVerify
	{
		// Token: 0x060338D7 RID: 211159 RVA: 0x006F17CC File Offset: 0x006EF9CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMoveTargetTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntitySplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPlayerSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
