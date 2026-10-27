using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C4 RID: 29380
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CameraNearClipController : ControllerBase
	{
		// Token: 0x0604812B RID: 295211 RVA: 0x0127AED8 File Offset: 0x012790D8
		public CameraNearClipController()
		{
			this.CameraNearClipConfigList = new PriorityQueue<CameraNearClipConfig>(new Comparison<CameraNearClipConfig>(this.CompareCameraNearClipConfigPriority));
		}

		// Token: 0x0604812C RID: 295212 RVA: 0x0127AF0D File Offset: 0x0127910D
		private int CompareCameraNearClipConfigPriority(CameraNearClipConfig a, CameraNearClipConfig b)
		{
			if (a.Priority == b.Priority)
			{
				return -1;
			}
			return b.Priority - a.Priority;
		}

		// Token: 0x0604812D RID: 295213 RVA: 0x0127AF2C File Offset: 0x0127912C
		public int EnableRelativeNearClip(int priority, float distance)
		{
			CameraNearClipConfig cameraNearClipConfig = new CameraNearClipConfig(priority);
			cameraNearClipConfig.SetRelativeNearClip(ECameraRelativeNearClipTargetType.CameraTarget, distance);
			this.CameraNearClipConfigList.Push(cameraNearClipConfig);
			this.CameraNearClipConfigMap[cameraNearClipConfig.Id] = cameraNearClipConfig;
			this.UpdateCameraNearClip();
			return cameraNearClipConfig.Id;
		}

		// Token: 0x0604812E RID: 295214 RVA: 0x0127AF74 File Offset: 0x01279174
		public int EnableAbsoluteNearClip(int priority, float distance)
		{
			CameraNearClipConfig cameraNearClipConfig = new CameraNearClipConfig(priority);
			cameraNearClipConfig.SetAbsoluteNearClip(distance);
			this.CameraNearClipConfigList.Push(cameraNearClipConfig);
			this.CameraNearClipConfigMap[cameraNearClipConfig.Id] = cameraNearClipConfig;
			this.UpdateCameraNearClip();
			return cameraNearClipConfig.Id;
		}

		// Token: 0x0604812F RID: 295215 RVA: 0x0127AFBC File Offset: 0x012791BC
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

		// Token: 0x06048130 RID: 295216 RVA: 0x0127B02C File Offset: 0x0127922C
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

		// Token: 0x06048131 RID: 295217 RVA: 0x0127B08C File Offset: 0x0127928C
		public void ClearLevelEventAdjustPlayerCameraNearClip()
		{
			if (this.LevelEventAdjustPlayerCameraNearClipId <= 0)
			{
				return;
			}
			this.DisableCameraNearClip(this.LevelEventAdjustPlayerCameraNearClipId);
			this.LevelEventAdjustPlayerCameraNearClipId = 0;
		}

		// Token: 0x06048132 RID: 295218 RVA: 0x0127B0AC File Offset: 0x012792AC
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

		// Token: 0x06048133 RID: 295219 RVA: 0x0127B12D File Offset: 0x0127932D
		public void ClearSequenceCameraPlayerComponentNearClip()
		{
			if (this.SequenceCameraPlayerComponentNearClipId <= 0)
			{
				return;
			}
			this.DisableCameraNearClip(this.SequenceCameraPlayerComponentNearClipId);
			this.SequenceCameraPlayerComponentNearClipId = 0;
		}

		// Token: 0x06048134 RID: 295220 RVA: 0x0127B14C File Offset: 0x0127934C
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

		// Token: 0x06048135 RID: 295221 RVA: 0x0127B1A6 File Offset: 0x012793A6
		public void ClearTsAnimNotifyStateNearClip()
		{
			if (this.TsAnimNotifyStateNearClipId <= 0)
			{
				return;
			}
			this.DisableCameraNearClip(this.TsAnimNotifyStateNearClipId);
			this.TsAnimNotifyStateNearClipId = 0;
		}

		// Token: 0x06048136 RID: 295222 RVA: 0x0127B1C8 File Offset: 0x012793C8
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

		// Token: 0x06048137 RID: 295223 RVA: 0x0127B224 File Offset: 0x01279424
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

		// Token: 0x06048138 RID: 295224 RVA: 0x0127B362 File Offset: 0x01279562
		protected override bool OnClear()
		{
			this.ClearAll("CameraNearClipController触发OnClear");
			return true;
		}

		// Token: 0x06048139 RID: 295225 RVA: 0x0127B370 File Offset: 0x01279570
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

		// Token: 0x0604813A RID: 295226 RVA: 0x0127B3BC File Offset: 0x012795BC
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

		// Token: 0x17009F2F RID: 40751
		// (get) Token: 0x0604813B RID: 295227 RVA: 0x0127B43C File Offset: 0x0127963C
		public static CameraNearClipController Instance
		{
			get
			{
				return CameraNearClipController._Instance;
			}
		}

		// Token: 0x0604813C RID: 295228 RVA: 0x0127B443 File Offset: 0x01279643
		public static CameraNearClipController GetOrCreateInstance()
		{
			if (CameraNearClipController._Instance == null)
			{
				CameraNearClipController.CreateInstance();
			}
			return CameraNearClipController._Instance;
		}

		// Token: 0x0604813D RID: 295229 RVA: 0x0127B457 File Offset: 0x01279657
		public static bool CreateInstance()
		{
			if (CameraNearClipController._Instance != null)
			{
				return true;
			}
			CameraNearClipController._Instance = new CameraNearClipController();
			return true;
		}

		// Token: 0x0604813E RID: 295230 RVA: 0x0127B46D File Offset: 0x0127966D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604813F RID: 295231 RVA: 0x0127B46F File Offset: 0x0127966F
		public static void ResetStaticDefaultValue()
		{
			CameraNearClipController._Instance = null;
		}

		// Token: 0x06048140 RID: 295232 RVA: 0x0127B477 File Offset: 0x01279677
		static CameraNearClipController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraNearClipController.CreateStaticDefaultValue), new Action(CameraNearClipController.ResetStaticDefaultValue));
		}

		// Token: 0x0402606A RID: 155754
		private int CurrentNearClipId;

		// Token: 0x0402606B RID: 155755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ICameraNearClipAction<CameraBaseNearClipConfig> CurrentNearClipAction;

		// Token: 0x0402606C RID: 155756
		private readonly Dictionary<CameraNearClipConfig, ICameraNearClipAction<CameraBaseNearClipConfig>> CurrentNearClipActionMap = new Dictionary<CameraNearClipConfig, ICameraNearClipAction<CameraBaseNearClipConfig>>();

		// Token: 0x0402606D RID: 155757
		private readonly Dictionary<int, CameraNearClipConfig> CameraNearClipConfigMap = new Dictionary<int, CameraNearClipConfig>();

		// Token: 0x0402606E RID: 155758
		private readonly PriorityQueue<CameraNearClipConfig> CameraNearClipConfigList;

		// Token: 0x0402606F RID: 155759
		public int LevelEventAdjustPlayerCameraNearClipId;

		// Token: 0x04026070 RID: 155760
		public int SequenceCameraPlayerComponentNearClipId;

		// Token: 0x04026071 RID: 155761
		public int TsAnimNotifyStateNearClipId;

		// Token: 0x04026072 RID: 155762
		[Nullable(2)]
		private static CameraNearClipController _Instance;
	}
}
