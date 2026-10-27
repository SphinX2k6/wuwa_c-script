using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.AlertArea
{
	// Token: 0x02006F61 RID: 28513
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AlertAreaController : ControllerBase
	{
		// Token: 0x060455CD RID: 284109 RVA: 0x0112B7EC File Offset: 0x011299EC
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

		// Token: 0x060455CE RID: 284110 RVA: 0x0112B898 File Offset: 0x01129A98
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

		// Token: 0x060455CF RID: 284111 RVA: 0x0112BA00 File Offset: 0x01129C00
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

		// Token: 0x060455D0 RID: 284112 RVA: 0x0112BA68 File Offset: 0x01129C68
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

		// Token: 0x17009B5F RID: 39775
		// (get) Token: 0x060455D1 RID: 284113 RVA: 0x0112BAAE File Offset: 0x01129CAE
		public static AlertAreaController Instance
		{
			get
			{
				return AlertAreaController._Instance;
			}
		}

		// Token: 0x060455D2 RID: 284114 RVA: 0x0112BAB5 File Offset: 0x01129CB5
		public static AlertAreaController GetOrCreateInstance()
		{
			if (AlertAreaController._Instance == null)
			{
				AlertAreaController.CreateInstance();
			}
			return AlertAreaController._Instance;
		}

		// Token: 0x060455D3 RID: 284115 RVA: 0x0112BAC9 File Offset: 0x01129CC9
		public static bool CreateInstance()
		{
			if (AlertAreaController._Instance != null)
			{
				return true;
			}
			AlertAreaController._Instance = new AlertAreaController();
			return true;
		}

		// Token: 0x060455D4 RID: 284116 RVA: 0x0112BADF File Offset: 0x01129CDF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060455D5 RID: 284117 RVA: 0x0112BAE1 File Offset: 0x01129CE1
		public static void ResetStaticDefaultValue()
		{
			AlertAreaController._Instance = null;
		}

		// Token: 0x060455D6 RID: 284118 RVA: 0x0112BAE9 File Offset: 0x01129CE9
		static AlertAreaController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AlertAreaController.CreateStaticDefaultValue), new Action(AlertAreaController.ResetStaticDefaultValue));
		}

		// Token: 0x040242FC RID: 148220
		private const int ALERT_VAL_PROGRESS_INTERVAL = 1000;

		// Token: 0x040242FD RID: 148221
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Dictionary<int, TimerHandle> AlertValueProgressTimerHandle = new Dictionary<int, TimerHandle>();

		// Token: 0x040242FE RID: 148222
		[Nullable(2)]
		private static AlertAreaController _Instance;
	}
}
