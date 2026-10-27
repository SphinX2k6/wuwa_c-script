using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5C RID: 27740
	public static class IOverrideLookAtType_UnionVerify
	{
		// Token: 0x06030E04 RID: 200196 RVA: 0x006A37C8 File Offset: 0x006A19C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckFlowLookAtVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOverrideLookAtTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
