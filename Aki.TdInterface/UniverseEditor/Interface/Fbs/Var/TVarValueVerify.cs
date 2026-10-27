using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B67 RID: 15207
	public static class TVarValueVerify
	{
		// Token: 0x06014CE4 RID: 85220 RVA: 0x00305978 File Offset: 0x00303B78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = BooleanValueVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IntValueVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = FloatValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = StringValueVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = QuestStateValueVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = EntityValueVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = QuestValueVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = PrefabValueVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = TransformValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
