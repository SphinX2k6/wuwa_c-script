using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005601 RID: 22017
	public static class INoiseRemovalBoarderBase_UnionVerify
	{
		// Token: 0x0602487E RID: 149630 RVA: 0x0050A8A0 File Offset: 0x00508AA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INoiseRemovalBoarderBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INoiseRemovalBoxBoarderVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INoiseRemovalSphereBoarderVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
