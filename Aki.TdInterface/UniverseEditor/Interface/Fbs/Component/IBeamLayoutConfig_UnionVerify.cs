using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F0C RID: 20236
	public static class IBeamLayoutConfig_UnionVerify
	{
		// Token: 0x0601FFB9 RID: 131001 RVA: 0x00473628 File Offset: 0x00471828
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
