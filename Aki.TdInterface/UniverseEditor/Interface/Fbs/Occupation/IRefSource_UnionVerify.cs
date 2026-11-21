using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004826 RID: 18470
	public static class IRefSource_UnionVerify
	{
		// Token: 0x0601B57A RID: 111994 RVA: 0x003DF998 File Offset: 0x003DDB98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAwakeEntityRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDestroyEntityRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IManualOccupationRefSourceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
