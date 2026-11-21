using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Manufacture.Forging;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004662 RID: 18018
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonManager : Singleton
	{
		// Token: 0x0602D4F4 RID: 185588 RVA: 0x00CB0490 File Offset: 0x00CAE690
		public void SetCurrentSystem(ESystemType currentSystem)
		{
			this.CurrentSystem = currentSystem;
		}

		// Token: 0x0602D4F5 RID: 185589 RVA: 0x00CB0499 File Offset: 0x00CAE699
		public ESystemType GetCurrentSystem()
		{
			return this.CurrentSystem;
		}

		// Token: 0x0602D4F6 RID: 185590 RVA: 0x00CB04A4 File Offset: 0x00CAE6A4
		public bool CheckIsBuff(int roleId, int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem != ESystemType.ComposeSystem)
			{
				return currentSystem == ESystemType.ForgingSystem && ForgingController.Instance.CheckIsBuff(roleId, itemId);
			}
			return ComposeController.Instance.CheckIsBuff(roleId, itemId);
		}

		// Token: 0x0602D4F7 RID: 185591 RVA: 0x00CB04E0 File Offset: 0x00CAE6E0
		public string GetInfoText(int roleId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetComposeInfoText(roleId);
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return string.Empty;
			}
			return ForgingController.Instance.GetForgingInfoText(roleId);
		}

		// Token: 0x0602D4F8 RID: 185592 RVA: 0x00CB051C File Offset: 0x00CAE71C
		public string GetDefaultRoleText()
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return "DefaultComposeHelperText";
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return "DefaultHelperText";
			}
			return "DefaultForgingHelperText";
		}

		// Token: 0x0602D4F9 RID: 185593 RVA: 0x00CB054C File Offset: 0x00CAE74C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonPopItemData> GetCommonItemList()
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetComposeItemList();
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return ForgingController.Instance.GetForgingItemList();
		}

		// Token: 0x0602D4FA RID: 185594 RVA: 0x00CB0581 File Offset: 0x00CAE781
		public int GetCurrentFixId()
		{
			return CookController.Instance.GetCurrentFixId();
		}

		// Token: 0x0602D4FB RID: 185595 RVA: 0x00CB058D File Offset: 0x00CAE78D
		public bool CheckCanFix()
		{
			return CookController.Instance.CheckCanFix();
		}

		// Token: 0x0602D4FC RID: 185596 RVA: 0x00CB059C File Offset: 0x00CAE79C
		public void SendFixToolRequest()
		{
			CookController.Instance.SendFixToolRequest(CookController.Instance.GetCurrentFixId(), CookController.Instance.GetCurrentEntityId().Value);
		}

		// Token: 0x0602D4FD RID: 185597 RVA: 0x00CB05D0 File Offset: 0x00CAE7D0
		public int? GetSelectedLevel()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetSelectedComposeLevel());
			}
			return null;
		}

		// Token: 0x0602D4FE RID: 185598 RVA: 0x00CB05FF File Offset: 0x00CAE7FF
		public void SetSelectedLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				ComposeController.Instance.SetSelectedComposeLevel(level);
			}
		}

		// Token: 0x0602D4FF RID: 185599 RVA: 0x00CB0618 File Offset: 0x00CAE818
		public int? GetCurrentRewardLevel()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetRewardLevelInfo().ComposeLevel);
			}
			return null;
		}

		// Token: 0x0602D500 RID: 185600 RVA: 0x00CB064C File Offset: 0x00CAE84C
		public int? GetCurrentRewardTotalProficiency()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetRewardLevelInfo().TotalProficiency);
			}
			return null;
		}

		// Token: 0x0602D501 RID: 185601 RVA: 0x00CB0680 File Offset: 0x00CAE880
		public int? GetCurrentRewardAddExp()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetRewardLevelInfo().AddExp);
			}
			return null;
		}

		// Token: 0x0602D502 RID: 185602 RVA: 0x00CB06B4 File Offset: 0x00CAE8B4
		public SynthesisLevel? GetComposeLevelByLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetComposeLevelByLevel(level);
			}
			return null;
		}

		// Token: 0x0602D503 RID: 185603 RVA: 0x00CB06E0 File Offset: 0x00CAE8E0
		[NullableContext(2)]
		public string GetLevelUpgradeTypeTexture(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendLiteral("T_ComposeTypeLevel");
				defaultInterpolatedStringHandler.AppendFormatted<int>(level);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return null;
		}

		// Token: 0x0602D504 RID: 185604 RVA: 0x00CB0720 File Offset: 0x00CAE920
		public int? GetSumExpByLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetSumExpByLevel(level));
			}
			return null;
		}

		// Token: 0x0602D505 RID: 185605 RVA: 0x00CB0750 File Offset: 0x00CAE950
		public int? GetDropIdByLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetDropIdByLevel(level));
			}
			return null;
		}

		// Token: 0x0602D506 RID: 185606 RVA: 0x00CB0780 File Offset: 0x00CAE980
		public int? GetComposeMaxLevel()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetComposeMaxLevel());
			}
			return null;
		}

		// Token: 0x0602D507 RID: 185607 RVA: 0x00CB07AF File Offset: 0x00CAE9AF
		public void SendLevelRewardRequest()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				ComposeController.Instance.SendSynthesisLevelRewardRequest();
			}
		}

		// Token: 0x0602D508 RID: 185608 RVA: 0x00CB07C4 File Offset: 0x00CAE9C4
		public bool CheckIsBuffEx(int roleId, int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem != ESystemType.ComposeSystem)
			{
				return currentSystem == ESystemType.ForgingSystem && ForgingController.Instance.CheckIsBuffEx(roleId, itemId);
			}
			return ComposeController.Instance.CheckIsBuffEx(roleId, itemId);
		}

		// Token: 0x0602D509 RID: 185609 RVA: 0x00CB0800 File Offset: 0x00CAEA00
		[NullableContext(2)]
		public string GetCommonManufactureText(int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetComposeText(itemId);
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return ForgingController.Instance.GetForgingText(itemId);
		}

		// Token: 0x0602D50A RID: 185610 RVA: 0x00CB0838 File Offset: 0x00CAEA38
		public int? GetCommonManufactureId(int id)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetComposeId(id));
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return new int?(ForgingController.Instance.GetForgingId(id));
		}

		// Token: 0x0602D50B RID: 185611 RVA: 0x00CB0884 File Offset: 0x00CAEA84
		public bool? CheckShowRoleView()
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return new bool?(ComposeController.Instance.CheckShowRoleView());
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return new bool?(ForgingController.Instance.CheckShowRoleView());
		}

		// Token: 0x0602D50C RID: 185612 RVA: 0x00CB08CB File Offset: 0x00CAEACB
		public int GetMaxCreateCount(int itemId)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetMaxCreateCount(itemId, null);
			}
			return ForgingController.Instance.GetMaxCreateCount(itemId);
		}

		// Token: 0x0602D50D RID: 185613 RVA: 0x00CB08F0 File Offset: 0x00CAEAF0
		public bool? CheckCanManufacture(int itemId)
		{
			if (this.CurrentSystem == ESystemType.ForgingSystem)
			{
				return new bool?(ForgingController.Instance.CheckCanForging(itemId));
			}
			return null;
		}

		// Token: 0x0602D50E RID: 185614 RVA: 0x00CB0920 File Offset: 0x00CAEB20
		public void SendManufacture(int itemId, int count)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				ComposeController.Instance.SendManufacture(itemId, count).Forget();
				return;
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return;
			}
			ForgingController.Instance.SendManufacture(itemId, count);
		}

		// Token: 0x0602D50F RID: 185615 RVA: 0x00CB095C File Offset: 0x00CAEB5C
		public int? GetCurrentRoleId()
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetCurrentRoleId());
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return new int?(ForgingController.Instance.GetCurrentRoleId());
		}

		// Token: 0x0602D510 RID: 185616 RVA: 0x00CB09A4 File Offset: 0x00CAEBA4
		public void SetCurrentRoleId(int roleId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				ComposeController.Instance.SetCurrentRoleId(roleId);
				return;
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return;
			}
			ForgingController.Instance.SetCurrentRoleId(roleId);
		}

		// Token: 0x0602D511 RID: 185617 RVA: 0x00CB09D8 File Offset: 0x00CAEBD8
		public int? GetManufactureRoleId(int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetComposeRoleId(itemId));
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return new int?(ForgingController.Instance.GetForgingRoleId(itemId));
		}

		// Token: 0x0602D512 RID: 185618 RVA: 0x00CB0A24 File Offset: 0x00CAEC24
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISingleItemInfo> GetManufactureMaterialList(int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetManufactureMaterialList(itemId);
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return ForgingController.Instance.GetForgingMaterialList(itemId);
		}

		// Token: 0x0602D513 RID: 185619 RVA: 0x00CB0A5C File Offset: 0x00CAEC5C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICommonRoleItemData> GetHelpRoleItemDataList(int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetHelpRoleItemDataList(itemId);
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return ForgingController.Instance.GetHelpRoleItemDataList(itemId);
		}

		// Token: 0x0602D514 RID: 185620 RVA: 0x00CB0A94 File Offset: 0x00CAEC94
		public bool? CheckCanShowExpItem()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new bool?(ComposeController.Instance.CheckCanShowExpItem());
			}
			return null;
		}

		// Token: 0x0602D515 RID: 185621 RVA: 0x00CB0AC4 File Offset: 0x00CAECC4
		public bool? CheckShowAmountItem()
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem == ESystemType.ComposeSystem)
			{
				return new bool?(true);
			}
			if (currentSystem != ESystemType.ForgingSystem)
			{
				return null;
			}
			return new bool?(false);
		}

		// Token: 0x17005B44 RID: 23364
		// (get) Token: 0x0602D516 RID: 185622 RVA: 0x00CB0AF9 File Offset: 0x00CAECF9
		public static CommonManager Instance
		{
			get
			{
				if (CommonManager._instance == null)
				{
					CommonManager._instance = new CommonManager();
					CommonManager._instance.OnInit();
				}
				return CommonManager._instance;
			}
		}

		// Token: 0x0602D517 RID: 185623 RVA: 0x00CB0B1C File Offset: 0x00CAED1C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D518 RID: 185624 RVA: 0x00CB0B1E File Offset: 0x00CAED1E
		public static void ResetStaticDefaultValue()
		{
			CommonManager instance = CommonManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CommonManager._instance = null;
		}

		// Token: 0x0602D519 RID: 185625 RVA: 0x00CB0B37 File Offset: 0x00CAED37
		static CommonManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonManager.CreateStaticDefaultValue), new Action(CommonManager.ResetStaticDefaultValue));
		}

		// Token: 0x04018489 RID: 99465
		private ESystemType CurrentSystem;

		// Token: 0x0401848A RID: 99466
		[Nullable(2)]
		private static CommonManager _instance;
	}
}
