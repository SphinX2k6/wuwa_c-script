using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048E2 RID: 18658
	public static class TAreaConflictCheckTriggerShapeVerify
	{
		// Token: 0x0601D2F1 RID: 119537 RVA: 0x0041E624 File Offset: 0x0041C824
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBoxTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICylinderTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISphereTriggerShapeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
