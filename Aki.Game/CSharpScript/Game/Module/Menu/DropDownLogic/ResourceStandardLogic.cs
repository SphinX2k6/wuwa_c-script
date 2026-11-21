using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004455 RID: 17493
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceStandardLogic : DropDownLogicBase
	{
		// Token: 0x0602C211 RID: 180753 RVA: 0x00C65200 File Offset: 0x00C63400
		public override IReadOnlyList<object> GetDropDownDataList()
		{
			List<ResourceStandardDropDownData> list = new List<ResourceStandardDropDownData>();
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId(20070);
			if (menuConfigByFunctionId == null)
			{
				return list;
			}
			string[] array = menuConfigByFunctionId.Value.OptionsName();
			for (int i = 0; i < array.Length; i++)
			{
				string textId = array[i];
				list.Add(new ResourceStandardDropDownData(i, textId));
			}
			return list;
		}

		// Token: 0x0602C212 RID: 180754 RVA: 0x00C65266 File Offset: 0x00C63466
		public override TableTextArgNew GetDataTextId(object data, MenuData menuData)
		{
			return new TableTextArgNew(((ResourceStandardDropDownData)data).TextId, Array.Empty<object>());
		}

		// Token: 0x0602C213 RID: 180755 RVA: 0x00C6527D File Offset: 0x00C6347D
		public override void TriggerSelectChange(object data, MenuData menuData)
		{
		}

		// Token: 0x0602C214 RID: 180756 RVA: 0x00C65280 File Offset: 0x00C63480
		public override bool CanSelectChange(int curIndex, int newIndex, MenuData menuData)
		{
			if (curIndex == newIndex)
			{
				return false;
			}
			if (curIndex == -1)
			{
				return true;
			}
			IReadOnlyList<ETier> supportedResourceQualityTiers = HotFixManager.GetSupportedResourceQualityTiers();
			if (newIndex < 0 || newIndex >= supportedResourceQualityTiers.Count)
			{
				return false;
			}
			ETier targetTier = supportedResourceQualityTiers[newIndex];
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ResourceStandardChangeConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				ETier localResourceQualityTier = HotFixManager.GetLocalResourceQualityTier();
				HotFixManager.SetTargetResourceQualityTier(targetTier);
				Action<ETier, ETier> mobilePreDownloadApplyTierChangeHandler = HotFixManager.MobilePreDownloadApplyTierChangeHandler;
				if (mobilePreDownloadApplyTierChangeHandler != null)
				{
					mobilePreDownloadApplyTierChangeHandler(localResourceQualityTier, targetTier);
				}
				ReConnectController.Instance.Logout(ELogoutReason.ChangePackTier);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return false;
		}

		// Token: 0x0602C215 RID: 180757 RVA: 0x00C652F8 File Offset: 0x00C634F8
		public override int GetDefaultIndex(MenuData menuData)
		{
			ETier targetConfig = (ETier)MenuController.Instance.GetTargetConfig(menuData.FunctionId);
			int num = HotFixManager.GetSupportedResourceQualityTiers().IndexOf(targetConfig);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}
	}
}
