using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D5 RID: 22741
	public static class ISceneItemSeqEventCbType_UnionVerify
	{
		// Token: 0x06026629 RID: 157225 RVA: 0x0054A2CC File Offset: 0x005484CC
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
