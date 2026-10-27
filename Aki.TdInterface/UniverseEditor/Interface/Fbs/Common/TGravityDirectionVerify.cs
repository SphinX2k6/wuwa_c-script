using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E8F RID: 24207
	public static class TGravityDirectionVerify
	{
		// Token: 0x0602974D RID: 169805 RVA: 0x005AE2FC File Offset: 0x005AC4FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGravityDirectionByEntityGravityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGravityDirectionSelfRotationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGravityDirectionVectorInfoVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGravityDirectionWorldAxisVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
