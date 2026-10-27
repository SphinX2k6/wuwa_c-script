using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005038 RID: 20536
	public static class IConveyorBeltMove_UnionVerify
	{
		// Token: 0x06020E6A RID: 134762 RVA: 0x0049315C File Offset: 0x0049135C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFixSpeedVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IConveyorBeltMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
