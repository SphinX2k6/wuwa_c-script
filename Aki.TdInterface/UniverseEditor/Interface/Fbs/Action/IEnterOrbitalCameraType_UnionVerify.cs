using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CB RID: 26315
	public static class IEnterOrbitalCameraType_UnionVerify
	{
		// Token: 0x0602DBED RID: 187373 RVA: 0x00641F4C File Offset: 0x0064014C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnterOrbitalCameraControlByMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEnterOrbitalCameraTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
