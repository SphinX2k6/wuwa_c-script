using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E5E RID: 20062
	public static class IAddBuffMode_UnionVerify
	{
		// Token: 0x0601F7EF RID: 129007 RVA: 0x004630EC File Offset: 0x004612EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAddBuffModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IImmediateAddBuffVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAdsorbAddBuffVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFireBulletAddBuffVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
