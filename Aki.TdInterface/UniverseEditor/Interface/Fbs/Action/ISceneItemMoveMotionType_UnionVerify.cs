using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C5 RID: 30405
	public static class ISceneItemMoveMotionType_UnionVerify
	{
		// Token: 0x06035556 RID: 218454 RVA: 0x00727708 File Offset: 0x00725908
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
