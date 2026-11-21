using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543E RID: 21566
	public static class IBeamLayoutConfig_UnionVerify
	{
		// Token: 0x06021D29 RID: 138537 RVA: 0x004A99BC File Offset: 0x004A7BBC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IBeamLayoutConfigWallVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBeamLayoutConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
