using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D47 RID: 19783
	public static class TAreaConflictCheckTriggerShapeVerify
	{
		// Token: 0x0601EADE RID: 125662 RVA: 0x0044ADC0 File Offset: 0x00448FC0
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
