using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C5D RID: 15453
	public static class ITipActorTransform_UnionVerify
	{
		// Token: 0x06015608 RID: 87560 RVA: 0x0031772C File Offset: 0x0031592C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITipActorTransformVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAbsoluteTipActorTransformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRelativeTipActorTransformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
