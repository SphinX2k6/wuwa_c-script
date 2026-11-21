using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573E RID: 22334
	public static class IExhibitItemType_UnionVerify
	{
		// Token: 0x06023EFB RID: 147195 RVA: 0x004F095C File Offset: 0x004EEB5C
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
