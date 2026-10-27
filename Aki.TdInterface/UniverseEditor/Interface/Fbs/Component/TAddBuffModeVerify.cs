using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE1 RID: 23521
	public static class TAddBuffModeVerify
	{
		// Token: 0x06028504 RID: 165124 RVA: 0x0058A000 File Offset: 0x00588200
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAdsorbAddBuffVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFireBulletAddBuffVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IImmediateAddBuffVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
