using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006743 RID: 26435
	public static class IExploreConfig_UnionVerify
	{
		// Token: 0x0602DFAC RID: 188332 RVA: 0x00648BE0 File Offset: 0x00646DE0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITeleControlConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IExploreConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
