using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004093 RID: 16531
	public static class TTipsActorTransformVerify
	{
		// Token: 0x06016C60 RID: 93280 RVA: 0x0034082C File Offset: 0x0033EA2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRelativeTipActorTransformVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAbsoluteTipActorTransformVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
