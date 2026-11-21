using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064D2 RID: 25810
	public static class TGravityDirectionVerify
	{
		// Token: 0x0602BDF5 RID: 179701 RVA: 0x005F72A0 File Offset: 0x005F54A0
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
