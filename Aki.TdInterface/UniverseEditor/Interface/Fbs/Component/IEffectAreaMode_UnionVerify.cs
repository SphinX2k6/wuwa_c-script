using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005113 RID: 20755
	public static class IEffectAreaMode_UnionVerify
	{
		// Token: 0x06021713 RID: 136979 RVA: 0x004A48E4 File Offset: 0x004A2AE4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IBuffAreaVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEffectAreaModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
