using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007946 RID: 31046
	public static class ISpecialCustomLoadingOption_UnionVerify
	{
		// Token: 0x06036ADE RID: 223966 RVA: 0x007510C4 File Offset: 0x0074F2C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHonamiStoryCustomLoadingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpecialCustomLoadingOptionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
