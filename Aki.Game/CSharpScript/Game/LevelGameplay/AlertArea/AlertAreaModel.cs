using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.AlertArea
{
	// Token: 0x02006F63 RID: 28515
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AlertAreaModel : ModelBase
	{
		// Token: 0x060455D9 RID: 284121 RVA: 0x0112BB31 File Offset: 0x01129D31
		public bool GetAreaAlertEnabled(int areaId)
		{
			return this.EnabledAreaAlertData.ContainsKey(areaId);
		}

		// Token: 0x060455DA RID: 284122 RVA: 0x0112BB40 File Offset: 0x01129D40
		public bool GetAreaAlertUiEnabled(int areaId)
		{
			AlertAreaData alertAreaData;
			return this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData) && alertAreaData != null && alertAreaData.AlertUiEnabled;
		}

		// Token: 0x060455DB RID: 284123 RVA: 0x0112BB6C File Offset: 0x01129D6C
		public bool GetAreaAlertUiVisible(int areaId)
		{
			AlertAreaData alertAreaData;
			return this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData) && (alertAreaData != null && alertAreaData.AlertUiEnabled) && alertAreaData.AlertUiVisible;
		}

		// Token: 0x060455DC RID: 284124 RVA: 0x0112BBA0 File Offset: 0x01129DA0
		public int? GetAlertUiVisibleAreaId()
		{
			foreach (KeyValuePair<int, AlertAreaData> keyValuePair in this.EnabledAreaAlertData)
			{
				int key = keyValuePair.Key;
				AlertAreaData value = keyValuePair.Value;
				if (value != null && value.AlertUiEnabled && value.AlertUiVisible)
				{
					return new int?(key);
				}
			}
			return null;
		}

		// Token: 0x060455DD RID: 284125 RVA: 0x0112BC28 File Offset: 0x01129E28
		public float GetAreaAlertValue(int areaId)
		{
			AlertAreaData alertAreaData;
			if (!this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData))
			{
				return 0f;
			}
			if (alertAreaData == null)
			{
				return 0f;
			}
			return alertAreaData.AlertValue;
		}

		// Token: 0x060455DE RID: 284126 RVA: 0x0112BC5C File Offset: 0x01129E5C
		public void UpdateAreaAlertValue(int areaId, float newValue)
		{
			AlertAreaData alertAreaData;
			if (!this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData))
			{
				return;
			}
			float num = MathUtils.Instance.Clamp(newValue, alertAreaData.MinAlertValue, alertAreaData.MaxAlertValue);
			if (alertAreaData.AlertValue == num)
			{
				return;
			}
			alertAreaData.AlertValue = num;
			EventSystem.Instance.Emit<int, float>(EEventName.OnUpdateAreaAlertValue, areaId, newValue);
		}

		// Token: 0x060455DF RID: 284127 RVA: 0x0112BCB8 File Offset: 0x01129EB8
		public void UpdateAreaAlertUiEnabled(int areaId, bool newEnabled)
		{
			AlertAreaData alertAreaData;
			if (!this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData) || alertAreaData.AlertUiEnabled == newEnabled)
			{
				return;
			}
			if (!newEnabled)
			{
				this.UpdateAreaAlertUiVisible(areaId, false);
			}
			alertAreaData.AlertUiEnabled = newEnabled;
			EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertUiEnable, areaId, newEnabled);
		}

		// Token: 0x060455E0 RID: 284128 RVA: 0x0112BD04 File Offset: 0x01129F04
		public void UpdateAreaAlertUiVisible(int areaId, bool newVisible)
		{
			AlertAreaData alertAreaData;
			if (!this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData) || !alertAreaData.AlertUiEnabled || alertAreaData.AlertUiVisible == newVisible)
			{
				return;
			}
			alertAreaData.AlertUiVisible = newVisible;
			EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertUiVisible, areaId, newVisible);
		}

		// Token: 0x060455E1 RID: 284129 RVA: 0x0112BD4C File Offset: 0x01129F4C
		public void EnableAlertArea(int areaId, float initValue, bool initUiEnable, bool initUiVisible)
		{
			if (this.EnabledAreaAlertData.ContainsKey(areaId))
			{
				return;
			}
			AlertAreaConfig? config = ConfigAlertAreaConfigById.GetConfig(areaId, true);
			if (config == null)
			{
				return;
			}
			AlertAreaData alertAreaData = new AlertAreaData(config.Value.MinValue, config.Value.MaxValue);
			alertAreaData.AlertValue = MathUtils.Instance.Clamp(initValue, alertAreaData.MinAlertValue, alertAreaData.MaxAlertValue);
			alertAreaData.AlertUiEnabled = initUiEnable;
			alertAreaData.AlertUiVisible = initUiVisible;
			this.EnabledAreaAlertData[areaId] = alertAreaData;
			EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertEnable, areaId, true);
			if (alertAreaData.AlertUiEnabled)
			{
				EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertUiEnable, areaId, true);
			}
			if (alertAreaData.AlertUiVisible)
			{
				EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertUiVisible, areaId, true);
			}
		}

		// Token: 0x060455E2 RID: 284130 RVA: 0x0112BE20 File Offset: 0x0112A020
		public void DisableAlertArea(int areaId)
		{
			AlertAreaData alertAreaData;
			if (!this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData))
			{
				return;
			}
			if (alertAreaData.AlertUiEnabled && alertAreaData.AlertUiVisible)
			{
				alertAreaData.AlertUiVisible = false;
				EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertUiVisible, areaId, false);
			}
			if (alertAreaData.AlertUiEnabled)
			{
				alertAreaData.AlertUiEnabled = false;
				EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertUiEnable, areaId, false);
			}
			this.EnabledAreaAlertData.Remove(areaId);
			EventSystem.Instance.Emit<int, bool>(EEventName.OnUpdateAreaAlertEnable, areaId, false);
		}

		// Token: 0x17009B60 RID: 39776
		// (get) Token: 0x060455E3 RID: 284131 RVA: 0x0112BEA7 File Offset: 0x0112A0A7
		public static AlertAreaModel Instance
		{
			get
			{
				return AlertAreaModel._Instance;
			}
		}

		// Token: 0x060455E4 RID: 284132 RVA: 0x0112BEAE File Offset: 0x0112A0AE
		public static AlertAreaModel GetOrCreateInstance()
		{
			if (AlertAreaModel._Instance == null)
			{
				AlertAreaModel.CreateInstance();
			}
			return AlertAreaModel._Instance;
		}

		// Token: 0x060455E5 RID: 284133 RVA: 0x0112BEC2 File Offset: 0x0112A0C2
		public static bool CreateInstance()
		{
			if (AlertAreaModel._Instance != null)
			{
				return true;
			}
			AlertAreaModel._Instance = new AlertAreaModel();
			return true;
		}

		// Token: 0x060455E6 RID: 284134 RVA: 0x0112BED8 File Offset: 0x0112A0D8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060455E7 RID: 284135 RVA: 0x0112BEDA File Offset: 0x0112A0DA
		public static void ResetStaticDefaultValue()
		{
			AlertAreaModel._Instance = null;
		}

		// Token: 0x060455E8 RID: 284136 RVA: 0x0112BEE2 File Offset: 0x0112A0E2
		static AlertAreaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AlertAreaModel.CreateStaticDefaultValue), new Action(AlertAreaModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024304 RID: 148228
		private readonly Dictionary<int, AlertAreaData> EnabledAreaAlertData = new Dictionary<int, AlertAreaData>();

		// Token: 0x04024305 RID: 148229
		[Nullable(2)]
		private static AlertAreaModel _Instance;
	}
}
