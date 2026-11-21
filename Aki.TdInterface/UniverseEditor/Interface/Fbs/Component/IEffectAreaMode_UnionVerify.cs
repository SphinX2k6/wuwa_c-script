using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005678 RID: 22136
	public static class IEffectAreaMode_UnionVerify
	{
		// Token: 0x06023667 RID: 144999 RVA: 0x004DE870 File Offset: 0x004DCA70
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
