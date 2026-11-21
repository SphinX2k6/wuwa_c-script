using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004072 RID: 16498
	public static class ITipsActorTransformResult_UnionVerify
	{
		// Token: 0x06016B4E RID: 93006 RVA: 0x0033EBF8 File Offset: 0x0033CDF8
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
