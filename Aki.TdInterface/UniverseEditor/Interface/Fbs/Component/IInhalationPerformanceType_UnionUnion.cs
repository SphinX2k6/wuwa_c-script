using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005405 RID: 21509
	public class IInhalationPerformanceType_UnionUnion
	{
		// Token: 0x17009E42 RID: 40514
		// (get) Token: 0x06023529 RID: 144681 RVA: 0x004E3CA9 File Offset: 0x004E1EA9
		// (set) Token: 0x0602352A RID: 144682 RVA: 0x004E3CB1 File Offset: 0x004E1EB1
		public IInhalationPerformanceType_Union Type { get; set; }

		// Token: 0x17009E43 RID: 40515
		// (get) Token: 0x0602352B RID: 144683 RVA: 0x004E3CBA File Offset: 0x004E1EBA
		// (set) Token: 0x0602352C RID: 144684 RVA: 0x004E3CC2 File Offset: 0x004E1EC2
		public object Value { get; set; }

		// Token: 0x0602352D RID: 144685 RVA: 0x004E3CCB File Offset: 0x004E1ECB
		public IInhalationPerformanceType_UnionUnion()
		{
			this.Type = IInhalationPerformanceType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602352E RID: 144686 RVA: 0x004E3CE1 File Offset: 0x004E1EE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602352F RID: 144687 RVA: 0x004E3CF3 File Offset: 0x004E1EF3
		public IInhalationPerformanceTypeT AsIInhalationPerformanceType()
		{
			return this.As<IInhalationPerformanceTypeT>();
		}

		// Token: 0x06023530 RID: 144688 RVA: 0x004E3CFB File Offset: 0x004E1EFB
		public static IInhalationPerformanceType_UnionUnion FromIInhalationPerformanceType(IInhalationPerformanceTypeT _iinhalationperformancetype)
		{
			return new IInhalationPerformanceType_UnionUnion
			{
				Type = IInhalationPerformanceType_Union.IInhalationPerformanceType,
				Value = _iinhalationperformancetype
			};
		}

		// Token: 0x06023531 RID: 144689 RVA: 0x004E3D10 File Offset: 0x004E1F10
		public IRoleInhalationT AsIRoleInhalation()
		{
			return this.As<IRoleInhalationT>();
		}

		// Token: 0x06023532 RID: 144690 RVA: 0x004E3D18 File Offset: 0x004E1F18
		public static IInhalationPerformanceType_UnionUnion FromIRoleInhalation(IRoleInhalationT _iroleinhalation)
		{
			return new IInhalationPerformanceType_UnionUnion
			{
				Type = IInhalationPerformanceType_Union.IRoleInhalation,
				Value = _iroleinhalation
			};
		}

		// Token: 0x06023533 RID: 144691 RVA: 0x004E3D2D File Offset: 0x004E1F2D
		public ISceneItemInhalationT AsISceneItemInhalation()
		{
			return this.As<ISceneItemInhalationT>();
		}

		// Token: 0x06023534 RID: 144692 RVA: 0x004E3D35 File Offset: 0x004E1F35
		public static IInhalationPerformanceType_UnionUnion FromISceneItemInhalation(ISceneItemInhalationT _isceneiteminhalation)
		{
			return new IInhalationPerformanceType_UnionUnion
			{
				Type = IInhalationPerformanceType_Union.ISceneItemInhalation,
				Value = _isceneiteminhalation
			};
		}

		// Token: 0x06023535 RID: 144693 RVA: 0x004E3D4C File Offset: 0x004E1F4C
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
