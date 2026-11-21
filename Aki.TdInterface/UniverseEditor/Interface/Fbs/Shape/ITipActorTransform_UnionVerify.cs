using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200406C RID: 16492
	public static class ITipActorTransform_UnionVerify
	{
		// Token: 0x06016B1C RID: 92956 RVA: 0x0033E5CC File Offset: 0x0033C7CC
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
