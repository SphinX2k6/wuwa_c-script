using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004582 RID: 17794
	public static class ISpecialProcess_UnionVerify
	{
		// Token: 0x06019EA2 RID: 106146 RVA: 0x003B1FE0 File Offset: 0x003B01E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILowMemorySceneSwitchVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpecialProcessVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
