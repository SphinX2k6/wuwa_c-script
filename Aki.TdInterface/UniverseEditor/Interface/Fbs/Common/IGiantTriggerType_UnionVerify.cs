using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006430 RID: 25648
	public static class IGiantTriggerType_UnionVerify
	{
		// Token: 0x0602B943 RID: 178499 RVA: 0x005EEFDC File Offset: 0x005ED1DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGiantTriggerTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGiantTriggerRoleStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGiantTriggerStableValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGiantTriggerEnterAreaVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
