using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.AlertArea
{
	// Token: 0x020060E2 RID: 24802
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AlertAreaController : ControllerBase
	{
		// Token: 0x0603B77B RID: 243579 RVA: 0x010D55CC File Offset: 0x010D37CC
		protected override bool OnClear()
		{
			List<int> list = new List<int>();
			foreach (int item in this.AlertValueProgressTimerHandle.Keys)
			{
				list.Add(item);
			}
			foreach (int areaId in list)
			{
				this.DisableAlertValueProgressTimer(areaId);
			}
			this.AlertValueProgressTimerHandle.Clear();
			return true;
		}

		// Token: 0x0603B77C RID: 243580 RVA: 0x010D5678 File Offset: 0x010D3878
		public void UpdateAlertDataByServerNotify(AlertAreaNotify notify)
		{
			AlertAreaModel instance = AlertAreaModel.Instance;
			foreach (int areaId in notify.RemoveAreaIds)
			{
				this.DisableAlertValueProgressTimer(areaId);
				instance.DisableAlertArea(areaId);
			}
			foreach (AlertArea alertArea in notify.AlertAreas)
			{
				if (!instance.GetAreaAlertEnabled(alertArea.AreaId))
				{
					instance.EnableAlertArea(alertArea.AreaId, alertArea.AlertValue, alertArea.EnableUi, alertArea.VisibleUi);
					if (alertArea.ChangeSpeed != 0f)
					{
						this.EnableAlertValueProgressTimer(alertArea.AreaId, alertArea.ChangeSpeed, 1000);
					}
				}
				else
				{
					instance.UpdateAreaAlertValue(alertArea.AreaId, alertArea.AlertValue);
					instance.UpdateAreaAlertUiEnabled(alertArea.AreaId, alertArea.EnableUi);
					instance.UpdateAreaAlertUiVisible(alertArea.AreaId, alertArea.VisibleUi);
					if (alertArea.ChangeSpeed != 0f)
					{
						this.EnableAlertValueProgressTimer(alertArea.AreaId, alertArea.ChangeSpeed, 1000);
					}
					else
					{
						this.DisableAlertValueProgressTimer(alertArea.AreaId);
					}
				}
			}
		}

		// Token: 0x0603B77D RID: 243581 RVA: 0x010D57E0 File Offset: 0x010D39E0
		public void EnableAlertValueProgressTimer(int areaId, float deltaVal, int interval)
		{
			this.DisableAlertValueProgressTimer(areaId);
			TimerHandle value = TimerSystem.Instance.Forever(delegate(float _)
			{
				if (!AlertAreaModel.Instance.GetAreaAlertEnabled(areaId))
				{
					this.DisableAlertValueProgressTimer(areaId);
					return;
				}
				float areaAlertValue = AlertAreaModel.Instance.GetAreaAlertValue(areaId);
				AlertAreaModel.Instance.UpdateAreaAlertValue(areaId, areaAlertValue + deltaVal);
			}, (float)interval, 1f, null, null, true);
			this.AlertValueProgressTimerHandle[areaId] = value;
		}

		// Token: 0x0603B77E RID: 243582 RVA: 0x010D5848 File Offset: 0x010D3A48
		public void DisableAlertValueProgressTimer(int areaId)
		{
			TimerHandle timerHandle;
			if (this.AlertValueProgressTimerHandle.TryGetValue(areaId, out timerHandle) && timerHandle != null)
			{
				if (TimerSystem.Instance.Has(timerHandle))
				{
					TimerSystem.Instance.Remove(timerHandle);
				}
				this.AlertValueProgressTimerHandle.Remove(areaId);
			}
		}

		// Token: 0x1700709E RID: 28830
		// (get) Token: 0x0603B77F RID: 243583 RVA: 0x010D588E File Offset: 0x010D3A8E
		public static AlertAreaController Instance
		{
			get
			{
				return AlertAreaController._Instance;
			}
		}

		// Token: 0x0603B780 RID: 243584 RVA: 0x010D5895 File Offset: 0x010D3A95
		public static AlertAreaController GetOrCreateInstance()
		{
			if (AlertAreaController._Instance == null)
			{
				AlertAreaController.CreateInstance();
			}
			return AlertAreaController._Instance;
		}

		// Token: 0x0603B781 RID: 243585 RVA: 0x010D58A9 File Offset: 0x010D3AA9
		public static bool CreateInstance()
		{
			if (AlertAreaController._Instance != null)
			{
				return true;
			}
			AlertAreaController._Instance = new AlertAreaController();
			return true;
		}

		// Token: 0x0603B782 RID: 243586 RVA: 0x010D58BF File Offset: 0x010D3ABF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B783 RID: 243587 RVA: 0x010D58C1 File Offset: 0x010D3AC1
		public static void ResetStaticDefaultValue()
		{
			AlertAreaController._Instance = null;
		}

		// Token: 0x0603B784 RID: 243588 RVA: 0x010D58C9 File Offset: 0x010D3AC9
		static AlertAreaController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AlertAreaController.CreateStaticDefaultValue), new Action(AlertAreaController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F5B1 RID: 128433
		private const int ALERT_VAL_PROGRESS_INTERVAL = 1000;

		// Token: 0x0401F5B2 RID: 128434
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Dictionary<int, TimerHandle> AlertValueProgressTimerHandle = new Dictionary<int, TimerHandle>();

		// Token: 0x0401F5B3 RID: 128435
		[Nullable(2)]
		private static AlertAreaController _Instance;
	}
}
