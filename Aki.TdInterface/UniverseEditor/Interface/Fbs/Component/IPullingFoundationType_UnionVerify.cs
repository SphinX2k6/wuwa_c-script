using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DBD RID: 23997
	public static class IPullingFoundationType_UnionVerify
	{
		// Token: 0x06028013 RID: 163859 RVA: 0x00578B74 File Offset: 0x00576D74
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
