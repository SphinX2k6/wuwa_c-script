using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004772 RID: 18290
	public static class TSaveConfigVerify
	{
		// Token: 0x0601AEEE RID: 110318 RVA: 0x003D1BD4 File Offset: 0x003CFDD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISavePointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISaveNewVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
