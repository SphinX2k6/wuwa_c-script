using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFF RID: 28671
	public class IInfrActivityBuildStageOption_UnionUnion
	{
		// Token: 0x1700D1FA RID: 53754
		// (get) Token: 0x06031ADA RID: 203482 RVA: 0x006BA7C5 File Offset: 0x006B89C5
		// (set) Token: 0x06031ADB RID: 203483 RVA: 0x006BA7CD File Offset: 0x006B89CD
		public IInfrActivityBuildStageOption_Union Type { get; set; }

		// Token: 0x1700D1FB RID: 53755
		// (get) Token: 0x06031ADC RID: 203484 RVA: 0x006BA7D6 File Offset: 0x006B89D6
		// (set) Token: 0x06031ADD RID: 203485 RVA: 0x006BA7DE File Offset: 0x006B89DE
		public object Value { get; set; }

		// Token: 0x06031ADE RID: 203486 RVA: 0x006BA7E7 File Offset: 0x006B89E7
		public IInfrActivityBuildStageOption_UnionUnion()
		{
			this.Type = IInfrActivityBuildStageOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031ADF RID: 203487 RVA: 0x006BA7FD File Offset: 0x006B89FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031AE0 RID: 203488 RVA: 0x006BA80F File Offset: 0x006B8A0F
		public IInfrActivityBuildStageOptionT AsIInfrActivityBuildStageOption()
		{
			return this.As<IInfrActivityBuildStageOptionT>();
		}

		// Token: 0x06031AE1 RID: 203489 RVA: 0x006BA817 File Offset: 0x006B8A17
		public static IInfrActivityBuildStageOption_UnionUnion FromIInfrActivityBuildStageOption(IInfrActivityBuildStageOptionT _iinfractivitybuildstageoption)
		{
			return new IInfrActivityBuildStageOption_UnionUnion
			{
				Type = IInfrActivityBuildStageOption_Union.IInfrActivityBuildStageOption,
				Value = _iinfractivitybuildstageoption
			};
		}

		// Token: 0x06031AE2 RID: 203490 RVA: 0x006BA82C File Offset: 0x006B8A2C
		public IInfrActivityInfrastructureStageT AsIInfrActivityInfrastructureStage()
		{
			return this.As<IInfrActivityInfrastructureStageT>();
		}

		// Token: 0x06031AE3 RID: 203491 RVA: 0x006BA834 File Offset: 0x006B8A34
		public static IInfrActivityBuildStageOption_UnionUnion FromIInfrActivityInfrastructureStage(IInfrActivityInfrastructureStageT _iinfractivityinfrastructurestage)
		{
			return new IInfrActivityBuildStageOption_UnionUnion
			{
				Type = IInfrActivityBuildStageOption_Union.IInfrActivityInfrastructureStage,
				Value = _iinfractivityinfrastructurestage
			};
		}

		// Token: 0x06031AE4 RID: 203492 RVA: 0x006BA849 File Offset: 0x006B8A49
		public IInfrActivityRoadProcessT AsIInfrActivityRoadProcess()
		{
			return this.As<IInfrActivityRoadProcessT>();
		}

		// Token: 0x06031AE5 RID: 203493 RVA: 0x006BA851 File Offset: 0x006B8A51
		public static IInfrActivityBuildStageOption_UnionUnion FromIInfrActivityRoadProcess(IInfrActivityRoadProcessT _iinfractivityroadprocess)
		{
			return new IInfrActivityBuildStageOption_UnionUnion
			{
				Type = IInfrActivityBuildStageOption_Union.IInfrActivityRoadProcess,
				Value = _iinfractivityroadprocess
			};
		}

		// Token: 0x06031AE6 RID: 203494 RVA: 0x006BA868 File Offset: 0x006B8A68
		public static int Pack(FlatBufferBuilder builder, IInfrActivityBuildStageOption_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInfrActivityBuildStageOption_Union.IInfrActivityBuildStageOption:
				return IInfrActivityBuildStageOption.Pack(builder, _o.AsIInfrActivityBuildStageOption()).Value;
			case IInfrActivityBuildStageOption_Union.IInfrActivityInfrastructureStage:
				return IInfrActivityInfrastructureStage.Pack(builder, _o.AsIInfrActivityInfrastructureStage()).Value;
			case IInfrActivityBuildStageOption_Union.IInfrActivityRoadProcess:
				return IInfrActivityRoadProcess.Pack(builder, _o.AsIInfrActivityRoadProcess()).Value;
			default:
				return 0;
			}
		}
	}
}
