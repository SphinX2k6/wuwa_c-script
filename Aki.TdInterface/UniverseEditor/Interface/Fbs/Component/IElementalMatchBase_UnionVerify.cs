using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005137 RID: 20791
	public static class IElementalMatchBase_UnionVerify
	{
		// Token: 0x0602188F RID: 137359 RVA: 0x004A7EE0 File Offset: 0x004A60E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IElementalMatchBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFireElementalMatchVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWaterElementalMatchVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IWoodElementalMatchVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
