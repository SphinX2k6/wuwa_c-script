using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BAA RID: 19370
	public class SkipTaskEnterEntrance : SkipTask
	{
		// Token: 0x060322D3 RID: 205523 RVA: 0x00BA8ABC File Offset: 0x00BA6CBC
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string markType = (string)data[1];
			string markId = (string)data[2];
			int entranceId = int.Parse(s);
			InstanceDungeonEntranceController.Instance.InstEntranceDetailRequest(entranceId).ContinueWith(delegate(bool isSuccess)
			{
				if (!isSuccess)
				{
					this.Finish();
				}
				if (InstanceDungeonEntranceModel.Instance.EntranceInstanceIdList.Count <= 0)
				{
					GenericPromptController.Instance.ShowPromptByCode("InstanceTime", Array.Empty<object>());
					this.Finish();
					return;
				}
				EMarkType emarkType = (EMarkType)int.Parse(markType);
				int num = int.Parse(markId);
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
							goto IL_D0;
						}
					}
					WorldMapController.Instance.FocalMarkItem(emarkType, num);
					IL_D0:
					this.Finish();
					return;
				}
				WorldMapController.Instance.FocalMarkItem(emarkType, num);
				this.Finish();
			});
		}
	}
}
