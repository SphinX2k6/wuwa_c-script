using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F07 RID: 32519
	public class TInfrActivityBuildStageTypeUnion
	{
		// Token: 0x1700F27D RID: 62077
		// (get) Token: 0x0603AA79 RID: 240249 RVA: 0x007E3B54 File Offset: 0x007E1D54
		// (set) Token: 0x0603AA7A RID: 240250 RVA: 0x007E3B5C File Offset: 0x007E1D5C
		public TInfrActivityBuildStageType Type { get; set; }

		// Token: 0x1700F27E RID: 62078
		// (get) Token: 0x0603AA7B RID: 240251 RVA: 0x007E3B65 File Offset: 0x007E1D65
		// (set) Token: 0x0603AA7C RID: 240252 RVA: 0x007E3B6D File Offset: 0x007E1D6D
		public object Value { get; set; }

		// Token: 0x0603AA7D RID: 240253 RVA: 0x007E3B76 File Offset: 0x007E1D76
		public TInfrActivityBuildStageTypeUnion()
		{
			this.Type = TInfrActivityBuildStageType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA7E RID: 240254 RVA: 0x007E3B8C File Offset: 0x007E1D8C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA7F RID: 240255 RVA: 0x007E3B9E File Offset: 0x007E1D9E
		public IInfrActivityInfrastructureStageT AsIInfrActivityInfrastructureStage()
		{
			return this.As<IInfrActivityInfrastructureStageT>();
		}

		// Token: 0x0603AA80 RID: 240256 RVA: 0x007E3BA6 File Offset: 0x007E1DA6
		public static TInfrActivityBuildStageTypeUnion FromIInfrActivityInfrastructureStage(IInfrActivityInfrastructureStageT _iinfractivityinfrastructurestage)
		{
			return new TInfrActivityBuildStageTypeUnion
			{
				Type = TInfrActivityBuildStageType.IInfrActivityInfrastructureStage,
				Value = _iinfractivityinfrastructurestage
			};
		}

		// Token: 0x0603AA81 RID: 240257 RVA: 0x007E3BBB File Offset: 0x007E1DBB
		public IInfrActivityRoadProcessT AsIInfrActivityRoadProcess()
		{
			return this.As<IInfrActivityRoadProcessT>();
		}

		// Token: 0x0603AA82 RID: 240258 RVA: 0x007E3BC3 File Offset: 0x007E1DC3
		public static TInfrActivityBuildStageTypeUnion FromIInfrActivityRoadProcess(IInfrActivityRoadProcessT _iinfractivityroadprocess)
		{
			return new TInfrActivityBuildStageTypeUnion
			{
				Type = TInfrActivityBuildStageType.IInfrActivityRoadProcess,
				Value = _iinfractivityroadprocess
			};
		}

		// Token: 0x0603AA83 RID: 240259 RVA: 0x007E3BD8 File Offset: 0x007E1DD8
		public static int Pack(FlatBufferBuilder builder, TInfrActivityBuildStageTypeUnion _o)
		{
			TInfrActivityBuildStageType type = _o.Type;
			if (type == TInfrActivityBuildStageType.IInfrActivityInfrastructureStage)
			{
				return IInfrActivityInfrastructureStage.Pack(builder, _o.AsIInfrActivityInfrastructureStage()).Value;
			}
			if (type != TInfrActivityBuildStageType.IInfrActivityRoadProcess)
			{
				return 0;
			}
			return IInfrActivityRoadProcess.Pack(builder, _o.AsIInfrActivityRoadProcess()).Value;
		}
	}
}
