using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE2 RID: 24290
	public static class ISceneItemSeqEventCbType_UnionVerify
	{
		// Token: 0x06028B8B RID: 166795 RVA: 0x00590E18 File Offset: 0x0058F018
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneItemSeqEventCbTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAnsEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAnEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
