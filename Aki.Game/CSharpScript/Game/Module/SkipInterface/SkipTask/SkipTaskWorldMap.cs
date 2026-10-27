using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BBD RID: 19389
	public class SkipTaskWorldMap : SkipTask
	{
		// Token: 0x06032309 RID: 205577 RVA: 0x00BA99C4 File Offset: 0x00BA7BC4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string value = (string)data[0];
			string s = (string)data[1];
			EMarkType emarkType;
			Enum.TryParse<EMarkType>(value, out emarkType);
			int num;
			int.TryParse(s, out num);
			if (UiManager.Instance.IsViewShow(EUiViewName.WorldMapView))
			{
				WorldMapModel instance = WorldMapModel.Instance;
				EMarkType? currentFocalMarkType = instance.CurrentFocalMarkType;
				EMarkType emarkType2 = emarkType;
				if (currentFocalMarkType.GetValueOrDefault() == emarkType2 & currentFocalMarkType != null)
				{
					int? currentFocalMarkId = instance.CurrentFocalMarkId;
					int num2 = num;
					if (currentFocalMarkId.GetValueOrDefault() == num2 & currentFocalMarkId != null)
					{
						GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
						goto IL_9B;
					}
				}
				WorldMapController.Instance.FocalMarkItem(emarkType, num);
				IL_9B:
				base.Finish();
				return;
			}
			WorldMapController.Instance.FocalMarkItem(emarkType, num);
			base.Finish();
		}
	}
}
