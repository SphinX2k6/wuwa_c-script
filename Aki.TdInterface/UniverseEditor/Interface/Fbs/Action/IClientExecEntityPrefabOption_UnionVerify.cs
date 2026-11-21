using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A37 RID: 27191
	public static class IClientExecEntityPrefabOption_UnionVerify
	{
		// Token: 0x0602EA40 RID: 191040 RVA: 0x0065BD38 File Offset: 0x00659F38
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientModifyEntityPrefabParamsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientExecEntityPrefabOptionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
