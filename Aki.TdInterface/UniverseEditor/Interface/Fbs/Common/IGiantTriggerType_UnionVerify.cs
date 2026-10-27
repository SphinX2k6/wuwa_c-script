using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF3 RID: 24051
	public static class IGiantTriggerType_UnionVerify
	{
		// Token: 0x060292B9 RID: 168633 RVA: 0x005A62AC File Offset: 0x005A44AC
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
