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
	// Token: 0x0200568C RID: 22156
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonManager : Singleton
	{
		// Token: 0x060385F7 RID: 230903 RVA: 0x00D62340 File Offset: 0x00D60540
		public void SetCurrentSystem(ESystemType currentSystem)
		{
			this.CurrentSystem = currentSystem;
		}

		// Token: 0x060385F8 RID: 230904 RVA: 0x00D62349 File Offset: 0x00D60549
		public ESystemType GetCurrentSystem()
		{
			return this.CurrentSystem;
		}

		// Token: 0x060385F9 RID: 230905 RVA: 0x00D62354 File Offset: 0x00D60554
		public bool CheckIsBuff(int roleId, int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem != ESystemType.ComposeSystem)
			{
				return currentSystem == ESystemType.ForgingSystem && ForgingController.Instance.CheckIsBuff(roleId, itemId);
			}
			return ComposeController.Instance.CheckIsBuff(roleId, itemId);
		}

		// Token: 0x060385FA RID: 230906 RVA: 0x00D62390 File Offset: 0x00D60590
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

		// Token: 0x060385FB RID: 230907 RVA: 0x00D623CC File Offset: 0x00D605CC
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

		// Token: 0x060385FC RID: 230908 RVA: 0x00D623FC File Offset: 0x00D605FC
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

		// Token: 0x060385FD RID: 230909 RVA: 0x00D62431 File Offset: 0x00D60631
		public int GetCurrentFixId()
		{
			return CookController.Instance.GetCurrentFixId();
		}

		// Token: 0x060385FE RID: 230910 RVA: 0x00D6243D File Offset: 0x00D6063D
		public bool CheckCanFix()
		{
			return CookController.Instance.CheckCanFix();
		}

		// Token: 0x060385FF RID: 230911 RVA: 0x00D6244C File Offset: 0x00D6064C
		public void SendFixToolRequest()
		{
			CookController.Instance.SendFixToolRequest(CookController.Instance.GetCurrentFixId(), CookController.Instance.GetCurrentEntityId().Value);
		}

		// Token: 0x06038600 RID: 230912 RVA: 0x00D62480 File Offset: 0x00D60680
		public int? GetSelectedLevel()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetSelectedComposeLevel());
			}
			return null;
		}

		// Token: 0x06038601 RID: 230913 RVA: 0x00D624AF File Offset: 0x00D606AF
		public void SetSelectedLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				ComposeController.Instance.SetSelectedComposeLevel(level);
			}
		}

		// Token: 0x06038602 RID: 230914 RVA: 0x00D624C8 File Offset: 0x00D606C8
		public int? GetCurrentRewardLevel()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetRewardLevelInfo().ComposeLevel);
			}
			return null;
		}

		// Token: 0x06038603 RID: 230915 RVA: 0x00D624FC File Offset: 0x00D606FC
		public int? GetCurrentRewardTotalProficiency()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetRewardLevelInfo().TotalProficiency);
			}
			return null;
		}

		// Token: 0x06038604 RID: 230916 RVA: 0x00D62530 File Offset: 0x00D60730
		public int? GetCurrentRewardAddExp()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetRewardLevelInfo().AddExp);
			}
			return null;
		}

		// Token: 0x06038605 RID: 230917 RVA: 0x00D62564 File Offset: 0x00D60764
		public SynthesisLevel? GetComposeLevelByLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetComposeLevelByLevel(level);
			}
			return null;
		}

		// Token: 0x06038606 RID: 230918 RVA: 0x00D62590 File Offset: 0x00D60790
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

		// Token: 0x06038607 RID: 230919 RVA: 0x00D625D0 File Offset: 0x00D607D0
		public int? GetSumExpByLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetSumExpByLevel(level));
			}
			return null;
		}

		// Token: 0x06038608 RID: 230920 RVA: 0x00D62600 File Offset: 0x00D60800
		public int? GetDropIdByLevel(int level)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetDropIdByLevel(level));
			}
			return null;
		}

		// Token: 0x06038609 RID: 230921 RVA: 0x00D62630 File Offset: 0x00D60830
		public int? GetComposeMaxLevel()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new int?(ComposeController.Instance.GetComposeMaxLevel());
			}
			return null;
		}

		// Token: 0x0603860A RID: 230922 RVA: 0x00D6265F File Offset: 0x00D6085F
		public void SendLevelRewardRequest()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				ComposeController.Instance.SendSynthesisLevelRewardRequest();
			}
		}

		// Token: 0x0603860B RID: 230923 RVA: 0x00D62674 File Offset: 0x00D60874
		public bool CheckIsBuffEx(int roleId, int itemId)
		{
			ESystemType currentSystem = this.CurrentSystem;
			if (currentSystem != ESystemType.ComposeSystem)
			{
				return currentSystem == ESystemType.ForgingSystem && ForgingController.Instance.CheckIsBuffEx(roleId, itemId);
			}
			return ComposeController.Instance.CheckIsBuffEx(roleId, itemId);
		}

		// Token: 0x0603860C RID: 230924 RVA: 0x00D626B0 File Offset: 0x00D608B0
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

		// Token: 0x0603860D RID: 230925 RVA: 0x00D626E8 File Offset: 0x00D608E8
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

		// Token: 0x0603860E RID: 230926 RVA: 0x00D62734 File Offset: 0x00D60934
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

		// Token: 0x0603860F RID: 230927 RVA: 0x00D6277B File Offset: 0x00D6097B
		public int GetMaxCreateCount(int itemId)
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return ComposeController.Instance.GetMaxCreateCount(itemId, null);
			}
			return ForgingController.Instance.GetMaxCreateCount(itemId);
		}

		// Token: 0x06038610 RID: 230928 RVA: 0x00D627A0 File Offset: 0x00D609A0
		public bool? CheckCanManufacture(int itemId)
		{
			if (this.CurrentSystem == ESystemType.ForgingSystem)
			{
				return new bool?(ForgingController.Instance.CheckCanForging(itemId));
			}
			return null;
		}

		// Token: 0x06038611 RID: 230929 RVA: 0x00D627D0 File Offset: 0x00D609D0
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

		// Token: 0x06038612 RID: 230930 RVA: 0x00D6280C File Offset: 0x00D60A0C
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

		// Token: 0x06038613 RID: 230931 RVA: 0x00D62854 File Offset: 0x00D60A54
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

		// Token: 0x06038614 RID: 230932 RVA: 0x00D62888 File Offset: 0x00D60A88
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

		// Token: 0x06038615 RID: 230933 RVA: 0x00D628D4 File Offset: 0x00D60AD4
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

		// Token: 0x06038616 RID: 230934 RVA: 0x00D6290C File Offset: 0x00D60B0C
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

		// Token: 0x06038617 RID: 230935 RVA: 0x00D62944 File Offset: 0x00D60B44
		public bool? CheckCanShowExpItem()
		{
			if (this.CurrentSystem == ESystemType.ComposeSystem)
			{
				return new bool?(ComposeController.Instance.CheckCanShowExpItem());
			}
			return null;
		}

		// Token: 0x06038618 RID: 230936 RVA: 0x00D62974 File Offset: 0x00D60B74
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

		// Token: 0x1700877D RID: 34685
		// (get) Token: 0x06038619 RID: 230937 RVA: 0x00D629A9 File Offset: 0x00D60BA9
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

		// Token: 0x0603861A RID: 230938 RVA: 0x00D629CC File Offset: 0x00D60BCC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603861B RID: 230939 RVA: 0x00D629CE File Offset: 0x00D60BCE
		public static void ResetStaticDefaultValue()
		{
			CommonManager instance = CommonManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CommonManager._instance = null;
		}

		// Token: 0x0603861C RID: 230940 RVA: 0x00D629E7 File Offset: 0x00D60BE7
		static CommonManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonManager.CreateStaticDefaultValue), new Action(CommonManager.ResetStaticDefaultValue));
		}

		// Token: 0x0401D9FE RID: 121342
		private ESystemType CurrentSystem;

		// Token: 0x0401D9FF RID: 121343
		[Nullable(2)]
		private static CommonManager _instance;
	}
}
