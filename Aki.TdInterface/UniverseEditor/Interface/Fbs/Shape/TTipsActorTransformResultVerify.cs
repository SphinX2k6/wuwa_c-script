using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004096 RID: 16534
	public static class TTipsActorTransformResultVerify
	{
		// Token: 0x06016C6C RID: 93292 RVA: 0x00340928 File Offset: 0x0033EB28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRelativeTipsActorTransformResultVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAbsoluteTipsActorTransformResultVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
