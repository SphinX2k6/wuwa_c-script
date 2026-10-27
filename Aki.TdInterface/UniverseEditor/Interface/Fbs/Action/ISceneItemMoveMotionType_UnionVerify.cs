using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3E RID: 28478
	public static class ISceneItemMoveMotionType_UnionVerify
	{
		// Token: 0x060324FE RID: 206078 RVA: 0x006CB7A0 File Offset: 0x006C99A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneItemMoveMotionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUniformMotionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVariableMotionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
