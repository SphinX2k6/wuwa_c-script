using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F7 RID: 25591
	public static class IGiantAnimDataType_UnionVerify
	{
		// Token: 0x0602B79B RID: 178075 RVA: 0x005EC2A8 File Offset: 0x005EA4A8
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
