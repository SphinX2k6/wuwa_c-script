using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C84 RID: 15492
	public static class TTipsActorTransformResultVerify
	{
		// Token: 0x06015734 RID: 87860 RVA: 0x003196B0 File Offset: 0x003178B0
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
