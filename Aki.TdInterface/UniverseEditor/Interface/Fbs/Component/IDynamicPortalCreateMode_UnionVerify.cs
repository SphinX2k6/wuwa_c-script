using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565A RID: 22106
	public static class IDynamicPortalCreateMode_UnionVerify
	{
		// Token: 0x06023552 RID: 144722 RVA: 0x004DC6A8 File Offset: 0x004DA8A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDynamicPortalByBulletVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDynamicPortalCreateModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
