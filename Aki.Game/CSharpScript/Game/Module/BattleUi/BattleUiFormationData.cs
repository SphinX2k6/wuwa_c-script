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
	// Token: 0x02005C8D RID: 23693
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiFormationData
	{
		// Token: 0x0603BD7D RID: 245117 RVA: 0x00E4AEB8 File Offset: 0x00E490B8
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

		// Token: 0x0603BD7E RID: 245118 RVA: 0x00E4AEF6 File Offset: 0x00E490F6
		public void OnLeaveLevel()
		{
		}

		// Token: 0x0603BD7F RID: 245119 RVA: 0x00E4AEF8 File Offset: 0x00E490F8
		public void Clear()
		{
			this.IsInit = false;
			this.EnvironmentPropertyDataTable = null;
			this.EnvironmentPropertyList.Clear();
			this.UiEnvironmentPropertyMap.Clear();
			this.ClearFollowerEntity();
			this.AutoMovingSettingEnable = false;
		}

		// Token: 0x0603BD80 RID: 245120 RVA: 0x00E4AF2B File Offset: 0x00E4912B
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

		// Token: 0x0603BD81 RID: 245121 RVA: 0x00E4AF60 File Offset: 0x00E49160
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

		// Token: 0x0603BD82 RID: 245122 RVA: 0x00E4B062 File Offset: 0x00E49262
		public void RefreshFollowerConfig(EntityHandle entityHandle)
		{
			this.ClearFollowerEntity();
			this.AddFollower(entityHandle);
		}

		// Token: 0x0603BD83 RID: 245123 RVA: 0x00E4B071 File Offset: 0x00E49271
		public void RemoveFollower()
		{
			this.ClearFollowerEntity();
		}

		// Token: 0x0603BD84 RID: 245124 RVA: 0x00E4B079 File Offset: 0x00E49279
		public void ChangePlayerFollowerEnable(bool isEnable)
		{
			if (this.FollowerEntityHandle == null)
			{
				return;
			}
			this.SetFollowerEnable(isEnable);
		}

		// Token: 0x0603BD85 RID: 245125 RVA: 0x00E4B08C File Offset: 0x00E4928C
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

		// Token: 0x0603BD86 RID: 245126 RVA: 0x00E4B102 File Offset: 0x00E49302
		public EFollowType GetFollowType()
		{
			return this.FollowType;
		}

		// Token: 0x0603BD87 RID: 245127 RVA: 0x00E4B10A File Offset: 0x00E4930A
		public string GetSightResId()
		{
			return this.SightResId;
		}

		// Token: 0x0603BD88 RID: 245128 RVA: 0x00E4B112 File Offset: 0x00E49312
		public bool GetFollowerAiming()
		{
			return this.FollowerEnable && this.FollowType != EFollowType.FollowNoAim;
		}

		// Token: 0x0603BD89 RID: 245129 RVA: 0x00E4B12A File Offset: 0x00E4932A
		public bool GetFollowerEnable()
		{
			return this.FollowerEnable;
		}

		// Token: 0x0603BD8A RID: 245130 RVA: 0x00E4B132 File Offset: 0x00E49332
		[NullableContext(2)]
		public EntityHandle GetFollowerEntityHandle()
		{
			return this.FollowerEntityHandle;
		}

		// Token: 0x0603BD8B RID: 245131 RVA: 0x00E4B13C File Offset: 0x00E4933C
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

		// Token: 0x17008DE3 RID: 36323
		// (get) Token: 0x0603BD8C RID: 245132 RVA: 0x00E4B18A File Offset: 0x00E4938A
		// (set) Token: 0x0603BD8D RID: 245133 RVA: 0x00E4B192 File Offset: 0x00E49392
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

		// Token: 0x17008DE4 RID: 36324
		// (get) Token: 0x0603BD8E RID: 245134 RVA: 0x00E4B1B6 File Offset: 0x00E493B6
		// (set) Token: 0x0603BD8F RID: 245135 RVA: 0x00E4B1BE File Offset: 0x00E493BE
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

		// Token: 0x0603BD91 RID: 245137 RVA: 0x00E4B20C File Offset: 0x00E4940C
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

		// Token: 0x0401F332 RID: 127794
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, EFollowType> FollowerMap;

		// Token: 0x0401F333 RID: 127795
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyDictionary<EFollowType, FollowHudInfo> FollowTypeToHudInfo;

		// Token: 0x0401F334 RID: 127796
		[Nullable(2)]
		private UDataTable EnvironmentPropertyDataTable;

		// Token: 0x0401F335 RID: 127797
		public List<int> EnvironmentPropertyList = new List<int>();

		// Token: 0x0401F336 RID: 127798
		public Dictionary<int, SUiEnvironmentProperty> UiEnvironmentPropertyMap = new Dictionary<int, SUiEnvironmentProperty>();

		// Token: 0x0401F337 RID: 127799
		private bool IsInit;

		// Token: 0x0401F338 RID: 127800
		[Nullable(2)]
		private EntityHandle FollowerEntityHandle;

		// Token: 0x0401F339 RID: 127801
		private EFollowType FollowType;

		// Token: 0x0401F33A RID: 127802
		private string SightResId = string.Empty;

		// Token: 0x0401F33B RID: 127803
		private bool FollowerEnable;

		// Token: 0x0401F33C RID: 127804
		private bool AutoMovingSettingInternal;

		// Token: 0x0401F33D RID: 127805
		private bool AutoSprintSettingInternal;
	}
}
