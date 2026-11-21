using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200643C RID: 25660
	public static class IGravityDirectionType_UnionVerify
	{
		// Token: 0x0602B98F RID: 178575 RVA: 0x005EF688 File Offset: 0x005ED888
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGravityDirectionTypeVerify.Verify(verifier, tablePos);
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
			case 5:
				result = IGravityDirectionByEntityGravityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
