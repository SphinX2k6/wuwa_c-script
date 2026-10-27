using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737B RID: 29563
	public static class ITeleportConfig_UnionVerify
	{
		// Token: 0x06035A6D RID: 219757 RVA: 0x0074E05C File Offset: 0x0074C25C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITeleportConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFixedPosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INearestEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGravityFlipFixedPosVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISafePosVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
