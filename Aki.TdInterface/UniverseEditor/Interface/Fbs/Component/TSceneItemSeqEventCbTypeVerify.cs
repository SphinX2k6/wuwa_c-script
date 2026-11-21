using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062D2 RID: 25298
	public static class TSceneItemSeqEventCbTypeVerify
	{
		// Token: 0x0602AFFE RID: 176126 RVA: 0x005DD3CC File Offset: 0x005DB5CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAnsEventVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAnEventVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
