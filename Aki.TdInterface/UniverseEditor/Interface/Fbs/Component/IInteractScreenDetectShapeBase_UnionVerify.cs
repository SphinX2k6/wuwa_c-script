using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546F RID: 21615
	public static class IInteractScreenDetectShapeBase_UnionVerify
	{
		// Token: 0x060238E8 RID: 145640 RVA: 0x004EAE8C File Offset: 0x004E908C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInteractScreenDetectShapeCircleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractScreenDetectShapeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
