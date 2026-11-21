using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F7 RID: 25079
	public static class TAddBuffModeVerify
	{
		// Token: 0x0602AAC8 RID: 174792 RVA: 0x005D1A90 File Offset: 0x005CFC90
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
