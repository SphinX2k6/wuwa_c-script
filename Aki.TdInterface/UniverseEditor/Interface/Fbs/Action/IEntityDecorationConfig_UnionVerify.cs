using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5A RID: 27994
	public static class IEntityDecorationConfig_UnionVerify
	{
		// Token: 0x0603049D RID: 197789 RVA: 0x0068FFD0 File Offset: 0x0068E1D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityDecorationConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAddEntityDecorationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRemoveEntityDecorationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
