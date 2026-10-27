using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C41 RID: 23617
	public static class TInhaledPerResultTypeVerify
	{
		// Token: 0x060287EC RID: 165868 RVA: 0x005922B0 File Offset: 0x005904B0
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
