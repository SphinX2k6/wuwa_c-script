using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E9 RID: 30441
	public static class ISceneUiSubtitlePositionBase_UnionVerify
	{
		// Token: 0x06035682 RID: 218754 RVA: 0x00729A20 File Offset: 0x00727C20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneUiSubtitlePositionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISceneUiSubtitlePositionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneUiSubtitlePositionEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
