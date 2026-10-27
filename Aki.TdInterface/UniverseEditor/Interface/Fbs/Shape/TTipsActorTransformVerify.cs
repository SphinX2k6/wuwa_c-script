using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C81 RID: 15489
	public static class TTipsActorTransformVerify
	{
		// Token: 0x06015728 RID: 87848 RVA: 0x003195B4 File Offset: 0x003177B4
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
