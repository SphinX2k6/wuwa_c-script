using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA1 RID: 23713
	public static class TSceneItemSeqEventCbTypeVerify
	{
		// Token: 0x060289B6 RID: 166326 RVA: 0x00594C58 File Offset: 0x00592E58
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
