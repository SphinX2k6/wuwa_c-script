using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F5 RID: 20725
	public static class IDynamicPortalCreateMode_UnionVerify
	{
		// Token: 0x060215FE RID: 136702 RVA: 0x004A271C File Offset: 0x004A091C
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
