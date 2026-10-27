using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A3 RID: 30627
	public static class TSplineMoveTargetVerify
	{
		// Token: 0x06037961 RID: 227681 RVA: 0x00785134 File Offset: 0x00783334
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerSplineMoveTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEntitySplineMoveTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
