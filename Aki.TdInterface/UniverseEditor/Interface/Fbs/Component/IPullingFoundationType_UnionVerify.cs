using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B6 RID: 22454
	public static class IPullingFoundationType_UnionVerify
	{
		// Token: 0x06025AF3 RID: 154355 RVA: 0x005329E8 File Offset: 0x00530BE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPullingCategoryMatchingFoundationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPullingFoundationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
