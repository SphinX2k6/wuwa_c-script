using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006266 RID: 25190
	public static class TInhaledPerResultTypeVerify
	{
		// Token: 0x0602ADFA RID: 175610 RVA: 0x005DA4C8 File Offset: 0x005D86C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInhaledDestroySelfVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInhaledChangeSelfStateVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
