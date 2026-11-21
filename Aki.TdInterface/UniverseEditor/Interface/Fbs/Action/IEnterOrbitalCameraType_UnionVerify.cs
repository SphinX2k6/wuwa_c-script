using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D45 RID: 27973
	public static class IEnterOrbitalCameraType_UnionVerify
	{
		// Token: 0x0603040A RID: 197642 RVA: 0x0068F200 File Offset: 0x0068D400
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
