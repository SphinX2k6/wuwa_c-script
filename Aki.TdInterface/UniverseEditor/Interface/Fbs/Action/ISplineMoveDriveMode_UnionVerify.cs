using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007958 RID: 31064
	public static class ISplineMoveDriveMode_UnionVerify
	{
		// Token: 0x06036B4D RID: 224077 RVA: 0x00751CA4 File Offset: 0x0074FEA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMoveDriveModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInputDrivenMoveDriveModeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPositionDrivenMoveDriveModeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
