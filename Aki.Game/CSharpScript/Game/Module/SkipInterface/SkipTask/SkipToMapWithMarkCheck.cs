using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BAF RID: 19375
	public class SkipToMapWithMarkCheck : SkipTask
	{
		// Token: 0x060322EC RID: 205548 RVA: 0x00BA91C4 File Offset: 0x00BA73C4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string value = (string)data[0];
			int num = int.Parse((string)data[1]);
			if (num != 0 && !MapModel.Instance.IsConfigMarkIdUnlock(num))
			{
				GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
				return;
			}
			WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
			{
				MarkId = new int?(num),
				MarkType = Enum.Parse<EMarkType>(value),
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
			base.Finish();
		}
	}
}
