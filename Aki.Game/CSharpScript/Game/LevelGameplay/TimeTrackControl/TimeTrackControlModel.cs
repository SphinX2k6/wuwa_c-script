using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.TimeTrackControl
{
	// Token: 0x020069E7 RID: 27111
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class TimeTrackControlModel : ModelBase
	{
		// Token: 0x1700987C RID: 39036
		// (get) Token: 0x06043700 RID: 276224 RVA: 0x0107B11A File Offset: 0x0107931A
		public long CreatureDataId
		{
			get
			{
				return this.CurCreatureDataId;
			}
		}

		// Token: 0x1700987D RID: 39037
		// (get) Token: 0x06043701 RID: 276225 RVA: 0x0107B122 File Offset: 0x01079322
		public int ControlPoint
		{
			get
			{
				return this.CurControlPoint;
			}
		}

		// Token: 0x1700987E RID: 39038
		// (get) Token: 0x06043702 RID: 276226 RVA: 0x0107B12A File Offset: 0x0107932A
		// (set) Token: 0x06043703 RID: 276227 RVA: 0x0107B132 File Offset: 0x01079332
		public bool CanUpdated
		{
			get
			{
				return this.CanUpdate;
			}
			set
			{
				this.CanUpdate = value;
			}
		}

		// Token: 0x1700987F RID: 39039
		// (get) Token: 0x06043704 RID: 276228 RVA: 0x0107B13B File Offset: 0x0107933B
		// (set) Token: 0x06043705 RID: 276229 RVA: 0x0107B143 File Offset: 0x01079343
		public long RefEntityId
		{
			get
			{
				return this.CurStaticSceneRefEntityId;
			}
			set
			{
				this.CurStaticSceneRefEntityId = value;
			}
		}

		// Token: 0x17009880 RID: 39040
		// (get) Token: 0x06043706 RID: 276230 RVA: 0x0107B14C File Offset: 0x0107934C
		// (set) Token: 0x06043707 RID: 276231 RVA: 0x0107B154 File Offset: 0x01079354
		public long RefTrueEntityId
		{
			get
			{
				return this.CurStaticSceneRefTrueEntityId;
			}
			set
			{
				this.CurStaticSceneRefTrueEntityId = value;
			}
		}

		// Token: 0x17009881 RID: 39041
		// (get) Token: 0x06043708 RID: 276232 RVA: 0x0107B15D File Offset: 0x0107935D
		public EntityHandle ControllerEntity
		{
			get
			{
				return this.CurTimeTrackControlEntity;
			}
		}

		// Token: 0x06043709 RID: 276233 RVA: 0x0107B168 File Offset: 0x01079368
		public void SetCurrentTimeTrackControl(long inEntityId, int index)
		{
			this.CurTimeTrackControlEntity = CreatureModel.Instance.GetEntity(inEntityId);
			this.CurConfigIndex = new int?(index);
			EntityHandle curTimeTrackControlEntity = this.CurTimeTrackControlEntity;
			CreatureDataComponent creatureDataComponent = (curTimeTrackControlEntity != null) ? curTimeTrackControlEntity.Entity.GetComponent<CreatureDataComponent>() : null;
			this.CurCreatureDataId = ((creatureDataComponent != null) ? creatureDataComponent.GetCreatureDataId() : 0L);
			this.UpdateCurConfig();
			this.CanUpdate = true;
		}

		// Token: 0x0604370A RID: 276234 RVA: 0x0107B1CC File Offset: 0x010793CC
		private void UpdateCurConfig()
		{
			if (this.CurTimeTrackControlEntity == null || this.CurConfigIndex == null)
			{
				return;
			}
			SceneItemTimeTrackControlComponent component = this.CurTimeTrackControlEntity.Entity.GetComponent<SceneItemTimeTrackControlComponent>();
			if (component == null)
			{
				return;
			}
			this.CurConfig = component.GetTimeTrackControlConfig(this.CurConfigIndex.Value);
		}

		// Token: 0x0604370B RID: 276235 RVA: 0x0107B21C File Offset: 0x0107941C
		public int GetConfigStatesCounts()
		{
			if (this.CurConfig == null)
			{
				return 0;
			}
			using (List<ITimelineTrackControlData>.Enumerator enumerator = this.CurConfig.ControlConfigs.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					IReadOnlyList<object> controlPoints = enumerator.Current.GetControlPoints();
					return (controlPoints != null) ? controlPoints.Count : 0;
				}
			}
			return 0;
		}

		// Token: 0x0604370C RID: 276236 RVA: 0x0107B290 File Offset: 0x01079490
		public float GetConfigSegmentTime()
		{
			if (this.CurConfig == null)
			{
				return 0.5f;
			}
			return this.CurConfig.SegmentTime.GetValueOrDefault(0.5f);
		}

		// Token: 0x0604370D RID: 276237 RVA: 0x0107B2C3 File Offset: 0x010794C3
		[NullableContext(1)]
		public void InitControlInfo(TimelineTraceStartResponse inInfo)
		{
			this.CurControlPoint = inInfo.ControlPoint;
			this.ControlPointsStates = inInfo.PointDatas;
			this.UpdatePointsUsable();
		}

		// Token: 0x0604370E RID: 276238 RVA: 0x0107B2E3 File Offset: 0x010794E3
		public void UpdateControlInfo(int inIndex)
		{
			this.CurControlPoint = inIndex;
			this.UpdatePointsUsable();
		}

		// Token: 0x0604370F RID: 276239 RVA: 0x0107B2F4 File Offset: 0x010794F4
		public void UpdatePointsUsable()
		{
			int configStatesCounts = this.GetConfigStatesCounts();
			if (configStatesCounts == 0)
			{
				return;
			}
			if (this.ControlPointsUsable == null || this.ControlPointsUsable.Length != configStatesCounts)
			{
				this.ControlPointsUsable = new bool[configStatesCounts];
			}
			Array.Fill<bool>(this.ControlPointsUsable, false);
			ControlPointData controlPointData = this.ControlPointsStates[this.CurControlPoint];
			this.ControlPointsUsable[this.CurControlPoint] = (controlPointData.LeftEnable || controlPointData.RightEnable);
			for (int i = this.CurControlPoint - 1; i >= 0; i--)
			{
				if (!controlPointData.LeftEnable || !this.ControlPointsUsable[i + 1])
				{
					this.ControlPointsUsable[i] = false;
				}
				else
				{
					this.ControlPointsUsable[i] = this.ControlPointsStates[i + 1].LeftEnable;
				}
			}
			for (int j = this.CurControlPoint + 1; j < configStatesCounts; j++)
			{
				if (!controlPointData.RightEnable || !this.ControlPointsUsable[j - 1])
				{
					this.ControlPointsUsable[j] = false;
				}
				else
				{
					this.ControlPointsUsable[j] = this.ControlPointsStates[j - 1].RightEnable;
				}
			}
		}

		// Token: 0x06043710 RID: 276240 RVA: 0x0107B401 File Offset: 0x01079601
		public bool IsControlPointUsable(int index)
		{
			return this.ControlPointsUsable != null && this.ControlPointsUsable.Length != 0 && index <= this.ControlPointsUsable.Length - 1 && this.ControlPointsUsable[index];
		}

		// Token: 0x17009882 RID: 39042
		// (get) Token: 0x06043711 RID: 276241 RVA: 0x0107B42D File Offset: 0x0107962D
		[Nullable(1)]
		public static TimeTrackControlModel Instance
		{
			[NullableContext(1)]
			get
			{
				return TimeTrackControlModel._Instance;
			}
		}

		// Token: 0x06043712 RID: 276242 RVA: 0x0107B434 File Offset: 0x01079634
		[NullableContext(1)]
		public static TimeTrackControlModel GetOrCreateInstance()
		{
			if (TimeTrackControlModel._Instance == null)
			{
				TimeTrackControlModel.CreateInstance();
			}
			return TimeTrackControlModel._Instance;
		}

		// Token: 0x06043713 RID: 276243 RVA: 0x0107B448 File Offset: 0x01079648
		public static bool CreateInstance()
		{
			if (TimeTrackControlModel._Instance != null)
			{
				return true;
			}
			TimeTrackControlModel._Instance = new TimeTrackControlModel();
			return true;
		}

		// Token: 0x06043714 RID: 276244 RVA: 0x0107B45E File Offset: 0x0107965E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043715 RID: 276245 RVA: 0x0107B460 File Offset: 0x01079660
		public static void ResetStaticDefaultValue()
		{
			TimeTrackControlModel._Instance = null;
		}

		// Token: 0x06043716 RID: 276246 RVA: 0x0107B468 File Offset: 0x01079668
		static TimeTrackControlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TimeTrackControlModel.CreateStaticDefaultValue), new Action(TimeTrackControlModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402330B RID: 144139
		private EntityHandle CurTimeTrackControlEntity;

		// Token: 0x0402330C RID: 144140
		private int? CurConfigIndex;

		// Token: 0x0402330D RID: 144141
		private ITimelineControlGroup CurConfig;

		// Token: 0x0402330E RID: 144142
		private long CurCreatureDataId;

		// Token: 0x0402330F RID: 144143
		private int CurControlPoint;

		// Token: 0x04023310 RID: 144144
		private bool CanUpdate;

		// Token: 0x04023311 RID: 144145
		private long CurStaticSceneRefEntityId;

		// Token: 0x04023312 RID: 144146
		private long CurStaticSceneRefTrueEntityId;

		// Token: 0x04023313 RID: 144147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IList<ControlPointData> ControlPointsStates;

		// Token: 0x04023314 RID: 144148
		private bool[] ControlPointsUsable;

		// Token: 0x04023315 RID: 144149
		private static TimeTrackControlModel _Instance;
	}
}
