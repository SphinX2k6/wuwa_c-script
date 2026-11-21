using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.AlertArea
{
	// Token: 0x020060E4 RID: 24804
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AlertAreaModel : ModelBase
	{
		// Token: 0x0603B787 RID: 243591 RVA: 0x010D5911 File Offset: 0x010D3B11
		public bool GetAreaAlertEnabled(int areaId)
		{
			return this.EnabledAreaAlertData.ContainsKey(areaId);
		}

		// Token: 0x0603B788 RID: 243592 RVA: 0x010D5920 File Offset: 0x010D3B20
		public bool GetAreaAlertUiEnabled(int areaId)
		{
			AlertAreaData alertAreaData;
			return this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData) && alertAreaData != null && alertAreaData.AlertUiEnabled;
		}

		// Token: 0x0603B789 RID: 243593 RVA: 0x010D594C File Offset: 0x010D3B4C
		public bool GetAreaAlertUiVisible(int areaId)
		{
			AlertAreaData alertAreaData;
			return this.EnabledAreaAlertData.TryGetValue(areaId, out alertAreaData) && (alertAreaData != null && alertAreaData.AlertUiEnabled) && alertAreaData.AlertUiVisible;
		}

		// Token: 0x0603B78A RID: 243594 RVA: 0x010D5980 File Offset: 0x010D3B80
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

		// Token: 0x0603B78B RID: 243595 RVA: 0x010D5A08 File Offset: 0x010D3C08
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

		// Token: 0x0603B78C RID: 243596 RVA: 0x010D5A3C File Offset: 0x010D3C3C
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

		// Token: 0x0603B78D RID: 243597 RVA: 0x010D5A98 File Offset: 0x010D3C98
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

		// Token: 0x0603B78E RID: 243598 RVA: 0x010D5AE4 File Offset: 0x010D3CE4
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

		// Token: 0x0603B78F RID: 243599 RVA: 0x010D5B2C File Offset: 0x010D3D2C
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

		// Token: 0x0603B790 RID: 243600 RVA: 0x010D5C00 File Offset: 0x010D3E00
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

		// Token: 0x1700709F RID: 28831
		// (get) Token: 0x0603B791 RID: 243601 RVA: 0x010D5C87 File Offset: 0x010D3E87
		public static AlertAreaModel Instance
		{
			get
			{
				return AlertAreaModel._Instance;
			}
		}

		// Token: 0x0603B792 RID: 243602 RVA: 0x010D5C8E File Offset: 0x010D3E8E
		public static AlertAreaModel GetOrCreateInstance()
		{
			if (AlertAreaModel._Instance == null)
			{
				AlertAreaModel.CreateInstance();
			}
			return AlertAreaModel._Instance;
		}

		// Token: 0x0603B793 RID: 243603 RVA: 0x010D5CA2 File Offset: 0x010D3EA2
		public static bool CreateInstance()
		{
			if (AlertAreaModel._Instance != null)
			{
				return true;
			}
			AlertAreaModel._Instance = new AlertAreaModel();
			return true;
		}

		// Token: 0x0603B794 RID: 243604 RVA: 0x010D5CB8 File Offset: 0x010D3EB8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B795 RID: 243605 RVA: 0x010D5CBA File Offset: 0x010D3EBA
		public static void ResetStaticDefaultValue()
		{
			AlertAreaModel._Instance = null;
		}

		// Token: 0x0603B796 RID: 243606 RVA: 0x010D5CC2 File Offset: 0x010D3EC2
		static AlertAreaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AlertAreaModel.CreateStaticDefaultValue), new Action(AlertAreaModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F5B9 RID: 128441
		private readonly Dictionary<int, AlertAreaData> EnabledAreaAlertData = new Dictionary<int, AlertAreaData>();

		// Token: 0x0401F5BA RID: 128442
		[Nullable(2)]
		private static AlertAreaModel _Instance;
	}
}
