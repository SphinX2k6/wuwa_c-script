using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DBA RID: 23994
	public static class IGiantAnimDataType_UnionVerify
	{
		// Token: 0x06029111 RID: 168209 RVA: 0x005A3578 File Offset: 0x005A1778
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGiantAnimDataTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGiantIdleAnimDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGiantSpecialAnimDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
