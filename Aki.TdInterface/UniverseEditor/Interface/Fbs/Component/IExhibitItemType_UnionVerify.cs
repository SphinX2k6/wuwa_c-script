using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D9 RID: 20953
	public static class IExhibitItemType_UnionVerify
	{
		// Token: 0x06021FA3 RID: 139171 RVA: 0x004B68F4 File Offset: 0x004B4AF4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExhibitItemTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhantomExhibitConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWeaponExhibitConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
