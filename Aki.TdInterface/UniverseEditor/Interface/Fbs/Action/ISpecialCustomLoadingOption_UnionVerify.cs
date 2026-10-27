using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007177 RID: 29047
	public static class ISpecialCustomLoadingOption_UnionVerify
	{
		// Token: 0x06033804 RID: 210948 RVA: 0x006F0134 File Offset: 0x006EE334
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
