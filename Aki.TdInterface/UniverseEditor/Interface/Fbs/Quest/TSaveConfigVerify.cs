using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004313 RID: 17171
	public static class TSaveConfigVerify
	{
		// Token: 0x0601976C RID: 104300 RVA: 0x003A62A4 File Offset: 0x003A44A4
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
