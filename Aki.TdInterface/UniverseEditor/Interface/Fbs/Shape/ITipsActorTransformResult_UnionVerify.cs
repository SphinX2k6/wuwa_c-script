using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C63 RID: 15459
	public static class ITipsActorTransformResult_UnionVerify
	{
		// Token: 0x0601563A RID: 87610 RVA: 0x00317D58 File Offset: 0x00315F58
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITipsActorTransformResultVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAbsoluteTipsActorTransformResultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRelativeTipsActorTransformResultVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
