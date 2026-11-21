using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Fight.FollowShooter;
using AkiClient.Game.Aki.Data.Fight.UI;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C6E RID: 19566
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiFormationData
	{
		// Token: 0x06030CCB RID: 199883 RVA: 0x00D9B434 File Offset: 0x00D99634
		public void Init()
		{
			this.IsInit = true;
			string stringConfig = ConfigCommonParamById.GetStringConfig("EnvironmentPropertyInfoPath");
			ResourceSystem.Instance.LoadAsync<UDataTable>(stringConfig, delegate([Nullable(2)] UDataTable table, string _)
			{
				if (!this.IsInit)
				{
					return;
				}
				this.EnvironmentPropertyDataTable = table;
				if (table == null)
				{
					return;
				}
				List<string> list = new List<string>();
				DataTableUtil.GetDataTableAllRowNamesFromTable(table, list);
				foreach (string text in list)
				{
					int num;
					if (int.TryParse(text, out num) && num != 0)
					{
						SUiEnvironmentProperty dataTableRow = DataTableUtil.GetDataTableRow<SUiEnvironmentProperty>(table, text);
						this.UiEnvironmentPropertyMap[num] = dataTableRow;
						this.EnvironmentPropertyList.Add(num);
					}
				}
			}, 100, "js_undefined");
		}

		// Token: 0x06030CCC RID: 199884 RVA: 0x00D9B472 File Offset: 0x00D99672
		public void OnLeaveLevel()
		{
		}

		// Token: 0x06030CCD RID: 199885 RVA: 0x00D9B474 File Offset: 0x00D99674
		public void Clear()
		{
			this.IsInit = false;
			this.EnvironmentPropertyDataTable = null;
			this.EnvironmentPropertyList.Clear();
			this.UiEnvironmentPropertyMap.Clear();
			this.ClearFollowerEntity();
			this.AutoMovingSettingEnable = false;
		}

		// Token: 0x06030CCE RID: 199886 RVA: 0x00D9B4A7 File Offset: 0x00D996A7
		[NullableContext(2)]
		public SUiEnvironmentProperty GetUiEnvironmentProperty(int formationPropertyId)
		{
			if (!this.IsInit)
			{
				return null;
			}
			if (GlobalData.IsPlayInEditor)
			{
				return DataTableUtil.GetDataTableRow<SUiEnvironmentProperty>(this.EnvironmentPropertyDataTable, formationPropertyId.ToString());
			}
			return this.UiEnvironmentPropertyMap.GetValueOrDefault(formationPropertyId);
		}

		// Token: 0x06030CCF RID: 199887 RVA: 0x00D9B4DC File Offset: 0x00D996DC
		public void AddFollower(EntityHandle handle)
		{
			if (handle == this.FollowerEntityHandle)
			{
				return;
			}
			this.ClearFollowerEntity();
			this.FollowerEntityHandle = handle;
			FollowShooterComponent component = handle.Entity.GetComponent<FollowShooterComponent>();
			int? num;
			if (component == null)
			{
				num = null;
			}
			else
			{
				BP_FollowShooterConfig_C followShooterConfig = component.FollowShooterConfig;
				num = ((followShooterConfig != null) ? new int?(followShooterConfig.AimType) : null);
			}
			int? num2 = num;
			EFollowType? efollowType = (num2 != null) ? new EFollowType?((EFollowType)num2.GetValueOrDefault()) : null;
			if (efollowType != null)
			{
				EFollowType? efollowType2 = efollowType;
				EFollowType efollowType3 = EFollowType.Default;
				if (!(efollowType2.GetValueOrDefault() == efollowType3 & efollowType2 != null))
				{
					goto IL_AF;
				}
			}
			efollowType = new EFollowType?(BattleUiFormationData.FollowerMap.GetValueOrDefault(handle.PbDataId, EFollowType.Default));
			IL_AF:
			this.FollowType = efollowType.Value;
			string text;
			if (component == null)
			{
				text = null;
			}
			else
			{
				BP_FollowShooterConfig_C followShooterConfig2 = component.FollowShooterConfig;
				text = ((followShooterConfig2 != null) ? followShooterConfig2.SightResId : null);
			}
			this.SightResId = (text ?? "");
			this.SetFollowerEnable(component != null && component.GetEnable());
		}

		// Token: 0x06030CD0 RID: 199888 RVA: 0x00D9B5DE File Offset: 0x00D997DE
		public void RefreshFollowerConfig(EntityHandle entityHandle)
		{
			this.ClearFollowerEntity();
			this.AddFollower(entityHandle);
		}

		// Token: 0x06030CD1 RID: 199889 RVA: 0x00D9B5ED File Offset: 0x00D997ED
		public void RemoveFollower()
		{
			this.ClearFollowerEntity();
		}

		// Token: 0x06030CD2 RID: 199890 RVA: 0x00D9B5F5 File Offset: 0x00D997F5
		public void ChangePlayerFollowerEnable(bool isEnable)
		{
			if (this.FollowerEntityHandle == null)
			{
				return;
			}
			this.SetFollowerEnable(isEnable);
		}

		// Token: 0x06030CD3 RID: 199891 RVA: 0x00D9B608 File Offset: 0x00D99808
		private void SetFollowerEnable(bool value)
		{
			if (this.FollowerEnable == value)
			{
				return;
			}
			this.FollowerEnable = value;
			EventSystem.Instance.Emit<bool, bool>(EEventName.BattleUiFollowerAimStateChanged, value, this.FollowType == EFollowType.Default);
			FollowHudInfo followHudInfo;
			if (BattleUiFormationData.FollowTypeToHudInfo.TryGetValue(this.FollowType, out followHudInfo))
			{
				if (this.FollowerEnable)
				{
					HudUnitController.Instance.TryCreateHud(followHudInfo.HudUnitType);
				}
				EventSystem.Instance.Emit<bool>(followHudInfo.EventName, value);
			}
		}

		// Token: 0x06030CD4 RID: 199892 RVA: 0x00D9B67E File Offset: 0x00D9987E
		public EFollowType GetFollowType()
		{
			return this.FollowType;
		}

		// Token: 0x06030CD5 RID: 199893 RVA: 0x00D9B686 File Offset: 0x00D99886
		public string GetSightResId()
		{
			return this.SightResId;
		}

		// Token: 0x06030CD6 RID: 199894 RVA: 0x00D9B68E File Offset: 0x00D9988E
		public bool GetFollowerAiming()
		{
			return this.FollowerEnable && this.FollowType != EFollowType.FollowNoAim;
		}

		// Token: 0x06030CD7 RID: 199895 RVA: 0x00D9B6A6 File Offset: 0x00D998A6
		public bool GetFollowerEnable()
		{
			return this.FollowerEnable;
		}

		// Token: 0x06030CD8 RID: 199896 RVA: 0x00D9B6AE File Offset: 0x00D998AE
		[NullableContext(2)]
		public EntityHandle GetFollowerEntityHandle()
		{
			return this.FollowerEntityHandle;
		}

		// Token: 0x06030CD9 RID: 199897 RVA: 0x00D9B6B8 File Offset: 0x00D998B8
		private void ClearFollowerEntity()
		{
			if (this.FollowerEnable)
			{
				this.SetFollowerEnable(false);
			}
			this.FollowerEntityHandle = null;
			FollowHudInfo followHudInfo;
			if (BattleUiFormationData.FollowTypeToHudInfo.TryGetValue(this.FollowType, out followHudInfo))
			{
				HudUnitController.Instance.TryDestroyHud(followHudInfo.HudUnitType);
			}
			this.FollowType = EFollowType.Default;
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x06030CDA RID: 199898 RVA: 0x00D9B706 File Offset: 0x00D99906
		// (set) Token: 0x06030CDB RID: 199899 RVA: 0x00D9B70E File Offset: 0x00D9990E
		public bool AutoMovingSettingEnable
		{
			get
			{
				return this.AutoMovingSettingInternal;
			}
			set
			{
				if (this.AutoMovingSettingInternal == value)
				{
					return;
				}
				this.AutoMovingSettingInternal = value;
				EventSystem.Instance.Emit<bool>(EEventName.AutoMovingSettingChanged, value);
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x06030CDC RID: 199900 RVA: 0x00D9B732 File Offset: 0x00D99932
		// (set) Token: 0x06030CDD RID: 199901 RVA: 0x00D9B73A File Offset: 0x00D9993A
		public bool AutoSprintSettingEnable
		{
			get
			{
				return this.AutoSprintSettingInternal;
			}
			set
			{
				if (this.AutoSprintSettingInternal == value)
				{
					return;
				}
				this.AutoSprintSettingInternal = value;
				EventSystem.Instance.Emit<bool>(EEventName.AutoSprintSettingChanged, value);
			}
		}

		// Token: 0x06030CDF RID: 199903 RVA: 0x00D9B788 File Offset: 0x00D99988
		// Note: this type is marked as 'beforefieldinit'.
		static BattleUiFormationData()
		{
			Dictionary<int, EFollowType> dictionary = new Dictionary<int, EFollowType>();
			dictionary[658750002] = EFollowType.FollowShoot;
			dictionary[658750003] = EFollowType.FollowShoot;
			dictionary[658750000] = EFollowType.FollowNoAim;
			BattleUiFormationData.FollowerMap = dictionary;
			Dictionary<EFollowType, FollowHudInfo> dictionary2 = new Dictionary<EFollowType, FollowHudInfo>();
			dictionary2[EFollowType.FollowShoot] = new FollowHudInfo(EHudUnitType.FollowShootAim, EEventName.SetFollowShootAimVisible);
			dictionary2[EFollowType.FollowAutoAim] = new FollowHudInfo(EHudUnitType.FollowShootAutoAim, EEventName.SetFollowShootAutoAimVisible);
			dictionary2[EFollowType.FollowVisionCar] = new FollowHudInfo(EHudUnitType.FollowShootVisionCar, EEventName.SetFollowShootAutoAimVisible);
			dictionary2[EFollowType.TDFollowShootAim] = new FollowHudInfo(EHudUnitType.TDFollowShootAim, EEventName.SetTDFollowShootAimVisible);
			dictionary2[EFollowType.FollowOnlyAutoAim] = new FollowHudInfo(EHudUnitType.FollowShootOnlyAutoAim, EEventName.SetFollowShootAutoAimVisible);
			dictionary2[EFollowType.FollowAutoAimNoRing] = new FollowHudInfo(EHudUnitType.FollowShootAutoAimNoRing, EEventName.SetFollowShootAutoAimVisible);
			BattleUiFormationData.FollowTypeToHudInfo = dictionary2;
		}

		// Token: 0x04019DE8 RID: 105960
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, EFollowType> FollowerMap;

		// Token: 0x04019DE9 RID: 105961
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyDictionary<EFollowType, FollowHudInfo> FollowTypeToHudInfo;

		// Token: 0x04019DEA RID: 105962
		[Nullable(2)]
		private UDataTable EnvironmentPropertyDataTable;

		// Token: 0x04019DEB RID: 105963
		public List<int> EnvironmentPropertyList = new List<int>();

		// Token: 0x04019DEC RID: 105964
		public Dictionary<int, SUiEnvironmentProperty> UiEnvironmentPropertyMap = new Dictionary<int, SUiEnvironmentProperty>();

		// Token: 0x04019DED RID: 105965
		private bool IsInit;

		// Token: 0x04019DEE RID: 105966
		[Nullable(2)]
		private EntityHandle FollowerEntityHandle;

		// Token: 0x04019DEF RID: 105967
		private EFollowType FollowType;

		// Token: 0x04019DF0 RID: 105968
		private string SightResId = string.Empty;

		// Token: 0x04019DF1 RID: 105969
		private bool FollowerEnable;

		// Token: 0x04019DF2 RID: 105970
		private bool AutoMovingSettingInternal;

		// Token: 0x04019DF3 RID: 105971
		private bool AutoSprintSettingInternal;
	}
}
