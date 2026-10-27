using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C17 RID: 23575
	public static class TExhibitConfigVerify
	{
		// Token: 0x060286F0 RID: 165616 RVA: 0x005909C0 File Offset: 0x0058EBC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWeaponExhibitConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPhantomExhibitConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
