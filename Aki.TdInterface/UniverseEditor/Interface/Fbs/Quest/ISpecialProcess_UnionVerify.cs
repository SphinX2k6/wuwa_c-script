using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004141 RID: 16705
	public static class ISpecialProcess_UnionVerify
	{
		// Token: 0x060187FF RID: 100351 RVA: 0x00387FD8 File Offset: 0x003861D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILowMemorySceneSwitchVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpecialProcessVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
