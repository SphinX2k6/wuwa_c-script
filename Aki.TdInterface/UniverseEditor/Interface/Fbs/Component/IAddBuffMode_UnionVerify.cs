using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536F RID: 21359
	public static class IAddBuffMode_UnionVerify
	{
		// Token: 0x0602143A RID: 136250 RVA: 0x00497104 File Offset: 0x00495304
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
