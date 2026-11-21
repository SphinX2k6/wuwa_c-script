using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598B RID: 22923
	public class IInhalationPerformanceType_UnionUnion
	{
		// Token: 0x1700A67C RID: 42620
		// (get) Token: 0x060255E1 RID: 153057 RVA: 0x00520CD5 File Offset: 0x0051EED5
		// (set) Token: 0x060255E2 RID: 153058 RVA: 0x00520CDD File Offset: 0x0051EEDD
		public IInhalationPerformanceType_Union Type { get; set; }

		// Token: 0x1700A67D RID: 42621
		// (get) Token: 0x060255E3 RID: 153059 RVA: 0x00520CE6 File Offset: 0x0051EEE6
		// (set) Token: 0x060255E4 RID: 153060 RVA: 0x00520CEE File Offset: 0x0051EEEE
		public object Value { get; set; }

		// Token: 0x060255E5 RID: 153061 RVA: 0x00520CF7 File Offset: 0x0051EEF7
		public IInhalationPerformanceType_UnionUnion()
		{
			this.Type = IInhalationPerformanceType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060255E6 RID: 153062 RVA: 0x00520D0D File Offset: 0x0051EF0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060255E7 RID: 153063 RVA: 0x00520D1F File Offset: 0x0051EF1F
		public IInhalationPerformanceTypeT AsIInhalationPerformanceType()
		{
			return this.As<IInhalationPerformanceTypeT>();
		}

		// Token: 0x060255E8 RID: 153064 RVA: 0x00520D27 File Offset: 0x0051EF27
		public static IInhalationPerformanceType_UnionUnion FromIInhalationPerformanceType(IInhalationPerformanceTypeT _iinhalationperformancetype)
		{
			return new IInhalationPerformanceType_UnionUnion
			{
				Type = IInhalationPerformanceType_Union.IInhalationPerformanceType,
				Value = _iinhalationperformancetype
			};
		}

		// Token: 0x060255E9 RID: 153065 RVA: 0x00520D3C File Offset: 0x0051EF3C
		public IRoleInhalationT AsIRoleInhalation()
		{
			return this.As<IRoleInhalationT>();
		}

		// Token: 0x060255EA RID: 153066 RVA: 0x00520D44 File Offset: 0x0051EF44
		public static IInhalationPerformanceType_UnionUnion FromIRoleInhalation(IRoleInhalationT _iroleinhalation)
		{
			return new IInhalationPerformanceType_UnionUnion
			{
				Type = IInhalationPerformanceType_Union.IRoleInhalation,
				Value = _iroleinhalation
			};
		}

		// Token: 0x060255EB RID: 153067 RVA: 0x00520D59 File Offset: 0x0051EF59
		public ISceneItemInhalationT AsISceneItemInhalation()
		{
			return this.As<ISceneItemInhalationT>();
		}

		// Token: 0x060255EC RID: 153068 RVA: 0x00520D61 File Offset: 0x0051EF61
		public static IInhalationPerformanceType_UnionUnion FromISceneItemInhalation(ISceneItemInhalationT _isceneiteminhalation)
		{
			return new IInhalationPerformanceType_UnionUnion
			{
				Type = IInhalationPerformanceType_Union.ISceneItemInhalation,
				Value = _isceneiteminhalation
			};
		}

		// Token: 0x060255ED RID: 153069 RVA: 0x00520D78 File Offset: 0x0051EF78
		public static int Pack(FlatBufferBuilder builder, IInhalationPerformanceType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInhalationPerformanceType_Union.IInhalationPerformanceType:
				return IInhalationPerformanceType.Pack(builder, _o.AsIInhalationPerformanceType()).Value;
			case IInhalationPerformanceType_Union.IRoleInhalation:
				return IRoleInhalation.Pack(builder, _o.AsIRoleInhalation()).Value;
			case IInhalationPerformanceType_Union.ISceneItemInhalation:
				return ISceneItemInhalation.Pack(builder, _o.AsISceneItemInhalation()).Value;
			default:
				return 0;
			}
		}
	}
}
