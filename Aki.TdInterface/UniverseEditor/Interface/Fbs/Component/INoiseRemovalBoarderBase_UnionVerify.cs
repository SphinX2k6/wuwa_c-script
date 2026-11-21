using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9F RID: 23455
	public static class INoiseRemovalBoarderBase_UnionVerify
	{
		// Token: 0x06026A8E RID: 158350 RVA: 0x0054AEB8 File Offset: 0x005490B8
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
