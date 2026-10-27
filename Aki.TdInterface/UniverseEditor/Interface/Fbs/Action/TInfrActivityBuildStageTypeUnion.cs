using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F3 RID: 30451
	public class TInfrActivityBuildStageTypeUnion
	{
		// Token: 0x1700E63B RID: 58939
		// (get) Token: 0x060375AC RID: 226732 RVA: 0x0077F648 File Offset: 0x0077D848
		// (set) Token: 0x060375AD RID: 226733 RVA: 0x0077F650 File Offset: 0x0077D850
		public TInfrActivityBuildStageType Type { get; set; }

		// Token: 0x1700E63C RID: 58940
		// (get) Token: 0x060375AE RID: 226734 RVA: 0x0077F659 File Offset: 0x0077D859
		// (set) Token: 0x060375AF RID: 226735 RVA: 0x0077F661 File Offset: 0x0077D861
		public object Value { get; set; }

		// Token: 0x060375B0 RID: 226736 RVA: 0x0077F66A File Offset: 0x0077D86A
		public TInfrActivityBuildStageTypeUnion()
		{
			this.Type = TInfrActivityBuildStageType.NONE;
			this.Value = null;
		}

		// Token: 0x060375B1 RID: 226737 RVA: 0x0077F680 File Offset: 0x0077D880
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375B2 RID: 226738 RVA: 0x0077F692 File Offset: 0x0077D892
		public IInfrActivityInfrastructureStageT AsIInfrActivityInfrastructureStage()
		{
			return this.As<IInfrActivityInfrastructureStageT>();
		}

		// Token: 0x060375B3 RID: 226739 RVA: 0x0077F69A File Offset: 0x0077D89A
		public static TInfrActivityBuildStageTypeUnion FromIInfrActivityInfrastructureStage(IInfrActivityInfrastructureStageT _iinfractivityinfrastructurestage)
		{
			return new TInfrActivityBuildStageTypeUnion
			{
				Type = TInfrActivityBuildStageType.IInfrActivityInfrastructureStage,
				Value = _iinfractivityinfrastructurestage
			};
		}

		// Token: 0x060375B4 RID: 226740 RVA: 0x0077F6AF File Offset: 0x0077D8AF
		public IInfrActivityRoadProcessT AsIInfrActivityRoadProcess()
		{
			return this.As<IInfrActivityRoadProcessT>();
		}

		// Token: 0x060375B5 RID: 226741 RVA: 0x0077F6B7 File Offset: 0x0077D8B7
		public static TInfrActivityBuildStageTypeUnion FromIInfrActivityRoadProcess(IInfrActivityRoadProcessT _iinfractivityroadprocess)
		{
			return new TInfrActivityBuildStageTypeUnion
			{
				Type = TInfrActivityBuildStageType.IInfrActivityRoadProcess,
				Value = _iinfractivityroadprocess
			};
		}

		// Token: 0x060375B6 RID: 226742 RVA: 0x0077F6CC File Offset: 0x0077D8CC
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
