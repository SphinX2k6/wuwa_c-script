using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006446 RID: 25670
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CameraNearClipController : ControllerBase
	{
		// Token: 0x0603E51F RID: 255263 RVA: 0x0121D270 File Offset: 0x0121B470
		public CameraNearClipController()
		{
			this.CameraNearClipConfigList = new PriorityQueue<CameraNearClipConfig>(new Comparison<CameraNearClipConfig>(this.CompareCameraNearClipConfigPriority));
		}

		// Token: 0x0603E520 RID: 255264 RVA: 0x0121D2A5 File Offset: 0x0121B4A5
		private int CompareCameraNearClipConfigPriority(CameraNearClipConfig a, CameraNearClipConfig b)
		{
			if (a.Priority == b.Priority)
			{
				return -1;
			}
			return b.Priority - a.Priority;
		}

		// Token: 0x0603E521 RID: 255265 RVA: 0x0121D2C4 File Offset: 0x0121B4C4
		public int EnableRelativeNearClip(int priority, float distance)
		{
			CameraNearClipConfig cameraNearClipConfig = new CameraNearClipConfig(priority);
			cameraNearClipConfig.SetRelativeNearClip(ECameraRelativeNearClipTargetType.CameraTarget, distance);
			this.CameraNearClipConfigList.Push(cameraNearClipConfig);
			this.CameraNearClipConfigMap[cameraNearClipConfig.Id] = cameraNearClipConfig;
			this.UpdateCameraNearClip();
			return cameraNearClipConfig.Id;
		}

		// Token: 0x0603E522 RID: 255266 RVA: 0x0121D30C File Offset: 0x0121B50C
		public int EnableAbsoluteNearClip(int priority, float distance)
		{
			CameraNearClipConfig cameraNearClipConfig = new CameraNearClipConfig(priority);
			cameraNearClipConfig.SetAbsoluteNearClip(distance);
			this.CameraNearClipConfigList.Push(cameraNearClipConfig);
			this.CameraNearClipConfigMap[cameraNearClipConfig.Id] = cameraNearClipConfig;
			this.UpdateCameraNearClip();
			return cameraNearClipConfig.Id;
		}

		// Token: 0x0603E523 RID: 255267 RVA: 0x0121D354 File Offset: 0x0121B554
		public void DisableCameraNearClip(int id)
		{
			CameraNearClipConfig cameraNearClipConfig;
			if (this.CameraNearClipConfigMap.TryGetValue(id, out cameraNearClipConfig))
			{
				cameraNearClipConfig.MarkDelete = true;
				ICameraNearClipAction<CameraBaseNearClipConfig> cameraNearClipAction;
				if (this.CurrentNearClipActionMap.TryGetValue(cameraNearClipConfig, out cameraNearClipAction))
				{
					cameraNearClipAction.End();
					this.CurrentNearClipActionMap.Remove(cameraNearClipConfig);
				}
			}
			if (id == this.CurrentNearClipId)
			{
				this.ClearCurrent("因为禁用销毁，id: " + id.ToString());
			}
			this.UpdateCameraNearClip();
		}

		// Token: 0x0603E524 RID: 255268 RVA: 0x0121D3C4 File Offset: 0x0121B5C4
		[NullableContext(2)]
		public CameraNearClipConfig GetCameraNearClipConfig()
		{
			while (!this.CameraNearClipConfigList.Empty)
			{
				CameraNearClipConfig top = this.CameraNearClipConfigList.Top;
				if (top == null)
				{
					return null;
				}
				if (!top.MarkDelete && top.IsValid())
				{
					return top;
				}
				this.CameraNearClipConfigList.Pop();
				this.CameraNearClipConfigMap.Remove(top.Id);
			}
			return null;
		}

		// Token: 0x0603E525 RID: 255269 RVA: 0x0121D424 File Offset: 0x0121B624
		public void ClearLevelEventAdjustPlayerCameraNearClip()
		{
			if (this.LevelEventAdjustPlayerCameraNearClipId <= 0)
			{
				return;
			}
			this.DisableCameraNearClip(this.LevelEventAdjustPlayerCameraNearClipId);
			this.LevelEventAdjustPlayerCameraNearClipId = 0;
		}

		// Token: 0x0603E526 RID: 255270 RVA: 0x0121D444 File Offset: 0x0121B644
		public void EnableLevelEventAdjustPlayerCameraNearClip(float? nearClipDistanceToTarget)
		{
			this.ClearLevelEventAdjustPlayerCameraNearClip();
			if (nearClipDistanceToTarget == null)
			{
				return;
			}
			float? num = nearClipDistanceToTarget;
			float num2 = 0f;
			if (num.GetValueOrDefault() <= num2 & num != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[CameraNearClip][Invalid Near Clip Distance";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("distance", nearClipDistanceToTarget);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.LevelEventAdjustPlayerCameraNearClipId = this.EnableRelativeNearClip(1000, nearClipDistanceToTarget.Value);
		}

		// Token: 0x0603E527 RID: 255271 RVA: 0x0121D4C5 File Offset: 0x0121B6C5
		public void ClearSequenceCameraPlayerComponentNearClip()
		{
			if (this.SequenceCameraPlayerComponentNearClipId <= 0)
			{
				return;
			}
			this.DisableCameraNearClip(this.SequenceCameraPlayerComponentNearClipId);
			this.SequenceCameraPlayerComponentNearClipId = 0;
		}

		// Token: 0x0603E528 RID: 255272 RVA: 0x0121D4E4 File Offset: 0x0121B6E4
		public void EnableSequenceCameraPlayerComponentNearClip(float clipDistance)
		{
			this.ClearSequenceCameraPlayerComponentNearClip();
			if (clipDistance <= 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[CameraNearClip][Invalid Sequence Near Clip Distance";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("distance", clipDistance);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.SequenceCameraPlayerComponentNearClipId = this.EnableAbsoluteNearClip(2000, clipDistance);
		}

		// Token: 0x0603E529 RID: 255273 RVA: 0x0121D53E File Offset: 0x0121B73E
		public void ClearTsAnimNotifyStateNearClip()
		{
			if (this.TsAnimNotifyStateNearClipId <= 0)
			{
				return;
			}
			this.DisableCameraNearClip(this.TsAnimNotifyStateNearClipId);
			this.TsAnimNotifyStateNearClipId = 0;
		}

		// Token: 0x0603E52A RID: 255274 RVA: 0x0121D560 File Offset: 0x0121B760
		public void EnableTsAnimNotifyStateNearClip(float clipDistance)
		{
			this.ClearTsAnimNotifyStateNearClip();
			if (clipDistance <= 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[CameraNearClip][Invalid ANS Near Clip Distance";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("distance", clipDistance);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.TsAnimNotifyStateNearClipId = this.EnableAbsoluteNearClip(500, clipDistance);
		}

		// Token: 0x0603E52B RID: 255275 RVA: 0x0121D5BC File Offset: 0x0121B7BC
		private void UpdateCameraNearClip()
		{
			CameraNearClipConfig cameraNearClipConfig = this.GetCameraNearClipConfig();
			if (cameraNearClipConfig == null)
			{
				this.ClearCurrent("没有有效配置");
				return;
			}
			if (this.CurrentNearClipId == cameraNearClipConfig.Id)
			{
				return;
			}
			if (this.CurrentNearClipAction != null)
			{
				this.CurrentNearClipAction.Pause();
			}
			this.ClearCurrent("将要更新新裁剪面，还原默认裁剪面");
			ICameraNearClipAction<CameraBaseNearClipConfig> cameraNearClipAction = null;
			ICameraNearClipAction<CameraBaseNearClipConfig> cameraNearClipAction2;
			if (this.CurrentNearClipActionMap.TryGetValue(cameraNearClipConfig, out cameraNearClipAction2))
			{
				if (cameraNearClipAction2 == null)
				{
					Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "[CameraNearClip][不应该出现此情况][错误的缓存对象]", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				cameraNearClipAction2.Resume();
			}
			else
			{
				if (cameraNearClipConfig.Type == ECameraNearClipType.Relative)
				{
					CameraRelativeNearClipConfig config = (CameraRelativeNearClipConfig)cameraNearClipConfig.CameraBaseNearClip;
					cameraNearClipAction = CameraNearClipConstructorFactory.Create(cameraNearClipConfig.Type, cameraNearClipConfig.Id, config);
				}
				else if (cameraNearClipConfig.Type == ECameraNearClipType.Absolute)
				{
					CameraAbsoluteNearClipConfig config2 = (CameraAbsoluteNearClipConfig)cameraNearClipConfig.CameraBaseNearClip;
					cameraNearClipAction = CameraNearClipConstructorFactory.Create(cameraNearClipConfig.Type, cameraNearClipConfig.Id, config2);
				}
				if (cameraNearClipAction == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Camera;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "[CameraNearClip][请补充对应类型实现]";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", cameraNearClipConfig.Type);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.CurrentNearClipActionMap[cameraNearClipConfig] = cameraNearClipAction;
				cameraNearClipAction.Start();
			}
			this.CurrentNearClipId = cameraNearClipConfig.Id;
			this.CurrentNearClipAction = cameraNearClipAction;
		}

		// Token: 0x0603E52C RID: 255276 RVA: 0x0121D6FA File Offset: 0x0121B8FA
		protected override bool OnClear()
		{
			this.ClearAll("CameraNearClipController触发OnClear");
			return true;
		}

		// Token: 0x0603E52D RID: 255277 RVA: 0x0121D708 File Offset: 0x0121B908
		private void ClearCurrent(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][还原近裁剪面]";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CurrentNearClipId = 0;
			this.CurrentNearClipAction = null;
			UKuroCameraFunctionLibrary.DelaySetNearClipPlane(10f);
		}

		// Token: 0x0603E52E RID: 255278 RVA: 0x0121D754 File Offset: 0x0121B954
		public void ClearAll(string reason)
		{
			this.ClearCurrent(reason);
			foreach (KeyValuePair<CameraNearClipConfig, ICameraNearClipAction<CameraBaseNearClipConfig>> keyValuePair in this.CurrentNearClipActionMap)
			{
				keyValuePair.Value.End();
			}
			this.CurrentNearClipActionMap.Clear();
			this.CameraNearClipConfigMap.Clear();
			this.CameraNearClipConfigList.Clear();
		}

		// Token: 0x17007696 RID: 30358
		// (get) Token: 0x0603E52F RID: 255279 RVA: 0x0121D7D4 File Offset: 0x0121B9D4
		public static CameraNearClipController Instance
		{
			get
			{
				return CameraNearClipController._Instance;
			}
		}

		// Token: 0x0603E530 RID: 255280 RVA: 0x0121D7DB File Offset: 0x0121B9DB
		public static CameraNearClipController GetOrCreateInstance()
		{
			if (CameraNearClipController._Instance == null)
			{
				CameraNearClipController.CreateInstance();
			}
			return CameraNearClipController._Instance;
		}

		// Token: 0x0603E531 RID: 255281 RVA: 0x0121D7EF File Offset: 0x0121B9EF
		public static bool CreateInstance()
		{
			if (CameraNearClipController._Instance != null)
			{
				return true;
			}
			CameraNearClipController._Instance = new CameraNearClipController();
			return true;
		}

		// Token: 0x0603E532 RID: 255282 RVA: 0x0121D805 File Offset: 0x0121BA05
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E533 RID: 255283 RVA: 0x0121D807 File Offset: 0x0121BA07
		public static void ResetStaticDefaultValue()
		{
			CameraNearClipController._Instance = null;
		}

		// Token: 0x0603E534 RID: 255284 RVA: 0x0121D80F File Offset: 0x0121BA0F
		static CameraNearClipController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraNearClipController.CreateStaticDefaultValue), new Action(CameraNearClipController.ResetStaticDefaultValue));
		}

		// Token: 0x0402134A RID: 136010
		private int CurrentNearClipId;

		// Token: 0x0402134B RID: 136011
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ICameraNearClipAction<CameraBaseNearClipConfig> CurrentNearClipAction;

		// Token: 0x0402134C RID: 136012
		private readonly Dictionary<CameraNearClipConfig, ICameraNearClipAction<CameraBaseNearClipConfig>> CurrentNearClipActionMap = new Dictionary<CameraNearClipConfig, ICameraNearClipAction<CameraBaseNearClipConfig>>();

		// Token: 0x0402134D RID: 136013
		private readonly Dictionary<int, CameraNearClipConfig> CameraNearClipConfigMap = new Dictionary<int, CameraNearClipConfig>();

		// Token: 0x0402134E RID: 136014
		private readonly PriorityQueue<CameraNearClipConfig> CameraNearClipConfigList;

		// Token: 0x0402134F RID: 136015
		public int LevelEventAdjustPlayerCameraNearClipId;

		// Token: 0x04021350 RID: 136016
		public int SequenceCameraPlayerComponentNearClipId;

		// Token: 0x04021351 RID: 136017
		public int TsAnimNotifyStateNearClipId;

		// Token: 0x04021352 RID: 136018
		[Nullable(2)]
		private static CameraNearClipController _Instance;
	}
}
