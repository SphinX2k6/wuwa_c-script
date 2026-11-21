using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D3 RID: 17875
	public static class ITakePhoto2ModeBase_UnionVerify
	{
		// Token: 0x0601A1AE RID: 106926 RVA: 0x003B850C File Offset: 0x003B670C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITakePhoto2BeforeYourEyesModeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITakePhoto2ModeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
