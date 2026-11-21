using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006236 RID: 25142
	public static class TExhibitConfigVerify
	{
		// Token: 0x0602ACE0 RID: 175328 RVA: 0x005D8908 File Offset: 0x005D6B08
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
