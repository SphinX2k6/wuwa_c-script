using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02005472 RID: 21618
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceStandardLogic : DropDownLogicBase
	{
		// Token: 0x060372C8 RID: 225992 RVA: 0x00D15DA8 File Offset: 0x00D13FA8
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

		// Token: 0x060372C9 RID: 225993 RVA: 0x00D15E0E File Offset: 0x00D1400E
		public override TableTextArgNew GetDataTextId(object data, MenuData menuData)
		{
			return new TableTextArgNew(((ResourceStandardDropDownData)data).TextId, Array.Empty<object>());
		}

		// Token: 0x060372CA RID: 225994 RVA: 0x00D15E25 File Offset: 0x00D14025
		public override void TriggerSelectChange(object data, MenuData menuData)
		{
		}

		// Token: 0x060372CB RID: 225995 RVA: 0x00D15E28 File Offset: 0x00D14028
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

		// Token: 0x060372CC RID: 225996 RVA: 0x00D15EA0 File Offset: 0x00D140A0
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
