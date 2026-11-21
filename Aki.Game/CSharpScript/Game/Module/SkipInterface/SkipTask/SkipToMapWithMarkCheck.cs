using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B59 RID: 15193
	public class SkipToMapWithMarkCheck : SkipTask
	{
		// Token: 0x0602707D RID: 159869 RVA: 0x00AED470 File Offset: 0x00AEB670
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
