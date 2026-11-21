using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F5 RID: 23029
	public static class IInteractScreenDetectShapeBase_UnionVerify
	{
		// Token: 0x060259A0 RID: 154016 RVA: 0x00527F00 File Offset: 0x00526100
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
