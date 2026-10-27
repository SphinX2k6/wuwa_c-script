using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694C RID: 26956
	public class IInfrActivityBuildStageOption_UnionUnion
	{
		// Token: 0x1700C7F7 RID: 51191
		// (get) Token: 0x0602F10A RID: 192778 RVA: 0x0066A2DD File Offset: 0x006684DD
		// (set) Token: 0x0602F10B RID: 192779 RVA: 0x0066A2E5 File Offset: 0x006684E5
		public IInfrActivityBuildStageOption_Union Type { get; set; }

		// Token: 0x1700C7F8 RID: 51192
		// (get) Token: 0x0602F10C RID: 192780 RVA: 0x0066A2EE File Offset: 0x006684EE
		// (set) Token: 0x0602F10D RID: 192781 RVA: 0x0066A2F6 File Offset: 0x006684F6
		public object Value { get; set; }

		// Token: 0x0602F10E RID: 192782 RVA: 0x0066A2FF File Offset: 0x006684FF
		public IInfrActivityBuildStageOption_UnionUnion()
		{
			this.Type = IInfrActivityBuildStageOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F10F RID: 192783 RVA: 0x0066A315 File Offset: 0x00668515
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F110 RID: 192784 RVA: 0x0066A327 File Offset: 0x00668527
		public IInfrActivityBuildStageOptionT AsIInfrActivityBuildStageOption()
		{
			return this.As<IInfrActivityBuildStageOptionT>();
		}

		// Token: 0x0602F111 RID: 192785 RVA: 0x0066A32F File Offset: 0x0066852F
		public static IInfrActivityBuildStageOption_UnionUnion FromIInfrActivityBuildStageOption(IInfrActivityBuildStageOptionT _iinfractivitybuildstageoption)
		{
			return new IInfrActivityBuildStageOption_UnionUnion
			{
				Type = IInfrActivityBuildStageOption_Union.IInfrActivityBuildStageOption,
				Value = _iinfractivitybuildstageoption
			};
		}

		// Token: 0x0602F112 RID: 192786 RVA: 0x0066A344 File Offset: 0x00668544
		public IInfrActivityInfrastructureStageT AsIInfrActivityInfrastructureStage()
		{
			return this.As<IInfrActivityInfrastructureStageT>();
		}

		// Token: 0x0602F113 RID: 192787 RVA: 0x0066A34C File Offset: 0x0066854C
		public static IInfrActivityBuildStageOption_UnionUnion FromIInfrActivityInfrastructureStage(IInfrActivityInfrastructureStageT _iinfractivityinfrastructurestage)
		{
			return new IInfrActivityBuildStageOption_UnionUnion
			{
				Type = IInfrActivityBuildStageOption_Union.IInfrActivityInfrastructureStage,
				Value = _iinfractivityinfrastructurestage
			};
		}

		// Token: 0x0602F114 RID: 192788 RVA: 0x0066A361 File Offset: 0x00668561
		public IInfrActivityRoadProcessT AsIInfrActivityRoadProcess()
		{
			return this.As<IInfrActivityRoadProcessT>();
		}

		// Token: 0x0602F115 RID: 192789 RVA: 0x0066A369 File Offset: 0x00668569
		public static IInfrActivityBuildStageOption_UnionUnion FromIInfrActivityRoadProcess(IInfrActivityRoadProcessT _iinfractivityroadprocess)
		{
			return new IInfrActivityBuildStageOption_UnionUnion
			{
				Type = IInfrActivityBuildStageOption_Union.IInfrActivityRoadProcess,
				Value = _iinfractivityroadprocess
			};
		}

		// Token: 0x0602F116 RID: 192790 RVA: 0x0066A380 File Offset: 0x00668580
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
