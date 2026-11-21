using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.TimeTrackControl
{
	// Token: 0x02005B43 RID: 23363
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class TimeTrackControlModel : ModelBase
	{
		// Token: 0x17006D5C RID: 27996
		// (get) Token: 0x0603973C RID: 235324 RVA: 0x0101F5CE File Offset: 0x0101D7CE
		public long CreatureDataId
		{
			get
			{
				return this.CurCreatureDataId;
			}
		}

		// Token: 0x17006D5D RID: 27997
		// (get) Token: 0x0603973D RID: 235325 RVA: 0x0101F5D6 File Offset: 0x0101D7D6
		public int ControlPoint
		{
			get
			{
				return this.CurControlPoint;
			}
		}

		// Token: 0x17006D5E RID: 27998
		// (get) Token: 0x0603973E RID: 235326 RVA: 0x0101F5DE File Offset: 0x0101D7DE
		// (set) Token: 0x0603973F RID: 235327 RVA: 0x0101F5E6 File Offset: 0x0101D7E6
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

		// Token: 0x17006D5F RID: 27999
		// (get) Token: 0x06039740 RID: 235328 RVA: 0x0101F5EF File Offset: 0x0101D7EF
		// (set) Token: 0x06039741 RID: 235329 RVA: 0x0101F5F7 File Offset: 0x0101D7F7
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

		// Token: 0x17006D60 RID: 28000
		// (get) Token: 0x06039742 RID: 235330 RVA: 0x0101F600 File Offset: 0x0101D800
		// (set) Token: 0x06039743 RID: 235331 RVA: 0x0101F608 File Offset: 0x0101D808
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

		// Token: 0x17006D61 RID: 28001
		// (get) Token: 0x06039744 RID: 235332 RVA: 0x0101F611 File Offset: 0x0101D811
		public EntityHandle ControllerEntity
		{
			get
			{
				return this.CurTimeTrackControlEntity;
			}
		}

		// Token: 0x06039745 RID: 235333 RVA: 0x0101F61C File Offset: 0x0101D81C
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

		// Token: 0x06039746 RID: 235334 RVA: 0x0101F680 File Offset: 0x0101D880
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

		// Token: 0x06039747 RID: 235335 RVA: 0x0101F6D0 File Offset: 0x0101D8D0
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

		// Token: 0x06039748 RID: 235336 RVA: 0x0101F744 File Offset: 0x0101D944
		public float GetConfigSegmentTime()
		{
			if (this.CurConfig == null)
			{
				return 0.5f;
			}
			return this.CurConfig.SegmentTime.GetValueOrDefault(0.5f);
		}

		// Token: 0x06039749 RID: 235337 RVA: 0x0101F777 File Offset: 0x0101D977
		[NullableContext(1)]
		public void InitControlInfo(TimelineTraceStartResponse inInfo)
		{
			this.CurControlPoint = inInfo.ControlPoint;
			this.ControlPointsStates = inInfo.PointDatas;
			this.UpdatePointsUsable();
		}

		// Token: 0x0603974A RID: 235338 RVA: 0x0101F797 File Offset: 0x0101D997
		public void UpdateControlInfo(int inIndex)
		{
			this.CurControlPoint = inIndex;
			this.UpdatePointsUsable();
		}

		// Token: 0x0603974B RID: 235339 RVA: 0x0101F7A8 File Offset: 0x0101D9A8
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

		// Token: 0x0603974C RID: 235340 RVA: 0x0101F8B5 File Offset: 0x0101DAB5
		public bool IsControlPointUsable(int index)
		{
			return this.ControlPointsUsable != null && this.ControlPointsUsable.Length != 0 && index <= this.ControlPointsUsable.Length - 1 && this.ControlPointsUsable[index];
		}

		// Token: 0x17006D62 RID: 28002
		// (get) Token: 0x0603974D RID: 235341 RVA: 0x0101F8E1 File Offset: 0x0101DAE1
		[Nullable(1)]
		public static TimeTrackControlModel Instance
		{
			[NullableContext(1)]
			get
			{
				return TimeTrackControlModel._Instance;
			}
		}

		// Token: 0x0603974E RID: 235342 RVA: 0x0101F8E8 File Offset: 0x0101DAE8
		[NullableContext(1)]
		public static TimeTrackControlModel GetOrCreateInstance()
		{
			if (TimeTrackControlModel._Instance == null)
			{
				TimeTrackControlModel.CreateInstance();
			}
			return TimeTrackControlModel._Instance;
		}

		// Token: 0x0603974F RID: 235343 RVA: 0x0101F8FC File Offset: 0x0101DAFC
		public static bool CreateInstance()
		{
			if (TimeTrackControlModel._Instance != null)
			{
				return true;
			}
			TimeTrackControlModel._Instance = new TimeTrackControlModel();
			return true;
		}

		// Token: 0x06039750 RID: 235344 RVA: 0x0101F912 File Offset: 0x0101DB12
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039751 RID: 235345 RVA: 0x0101F914 File Offset: 0x0101DB14
		public static void ResetStaticDefaultValue()
		{
			TimeTrackControlModel._Instance = null;
		}

		// Token: 0x06039752 RID: 235346 RVA: 0x0101F91C File Offset: 0x0101DB1C
		static TimeTrackControlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TimeTrackControlModel.CreateStaticDefaultValue), new Action(TimeTrackControlModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E4FB RID: 124155
		private EntityHandle CurTimeTrackControlEntity;

		// Token: 0x0401E4FC RID: 124156
		private int? CurConfigIndex;

		// Token: 0x0401E4FD RID: 124157
		private ITimelineControlGroup CurConfig;

		// Token: 0x0401E4FE RID: 124158
		private long CurCreatureDataId;

		// Token: 0x0401E4FF RID: 124159
		private int CurControlPoint;

		// Token: 0x0401E500 RID: 124160
		private bool CanUpdate;

		// Token: 0x0401E501 RID: 124161
		private long CurStaticSceneRefEntityId;

		// Token: 0x0401E502 RID: 124162
		private long CurStaticSceneRefTrueEntityId;

		// Token: 0x0401E503 RID: 124163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IList<ControlPointData> ControlPointsStates;

		// Token: 0x0401E504 RID: 124164
		private bool[] ControlPointsUsable;

		// Token: 0x0401E505 RID: 124165
		private static TimeTrackControlModel _Instance;
	}
}
