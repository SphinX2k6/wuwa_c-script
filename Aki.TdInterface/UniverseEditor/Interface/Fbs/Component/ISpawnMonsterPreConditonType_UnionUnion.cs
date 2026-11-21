using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F6A RID: 24426
	public class ISpawnMonsterPreConditonType_UnionUnion
	{
		// Token: 0x1700B4EC RID: 46316
		// (get) Token: 0x060290F7 RID: 168183 RVA: 0x0059BC69 File Offset: 0x00599E69
		// (set) Token: 0x060290F8 RID: 168184 RVA: 0x0059BC71 File Offset: 0x00599E71
		public ISpawnMonsterPreConditonType_Union Type { get; set; }

		// Token: 0x1700B4ED RID: 46317
		// (get) Token: 0x060290F9 RID: 168185 RVA: 0x0059BC7A File Offset: 0x00599E7A
		// (set) Token: 0x060290FA RID: 168186 RVA: 0x0059BC82 File Offset: 0x00599E82
		public object Value { get; set; }

		// Token: 0x060290FB RID: 168187 RVA: 0x0059BC8B File Offset: 0x00599E8B
		public ISpawnMonsterPreConditonType_UnionUnion()
		{
			this.Type = ISpawnMonsterPreConditonType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060290FC RID: 168188 RVA: 0x0059BCA1 File Offset: 0x00599EA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060290FD RID: 168189 RVA: 0x0059BCB3 File Offset: 0x00599EB3
		public ISpawnMonsterPreConditonTypeT AsISpawnMonsterPreConditonType()
		{
			return this.As<ISpawnMonsterPreConditonTypeT>();
		}

		// Token: 0x060290FE RID: 168190 RVA: 0x0059BCBB File Offset: 0x00599EBB
		public static ISpawnMonsterPreConditonType_UnionUnion FromISpawnMonsterPreConditonType(ISpawnMonsterPreConditonTypeT _ispawnmonsterpreconditontype)
		{
			return new ISpawnMonsterPreConditonType_UnionUnion
			{
				Type = ISpawnMonsterPreConditonType_Union.ISpawnMonsterPreConditonType,
				Value = _ispawnmonsterpreconditontype
			};
		}

		// Token: 0x060290FF RID: 168191 RVA: 0x0059BCD0 File Offset: 0x00599ED0
		public ISpawnMonsterPreDependOnPrecedingT AsISpawnMonsterPreDependOnPreceding()
		{
			return this.As<ISpawnMonsterPreDependOnPrecedingT>();
		}

		// Token: 0x06029100 RID: 168192 RVA: 0x0059BCD8 File Offset: 0x00599ED8
		public static ISpawnMonsterPreConditonType_UnionUnion FromISpawnMonsterPreDependOnPreceding(ISpawnMonsterPreDependOnPrecedingT _ispawnmonsterpredependonpreceding)
		{
			return new ISpawnMonsterPreConditonType_UnionUnion
			{
				Type = ISpawnMonsterPreConditonType_Union.ISpawnMonsterPreDependOnPreceding,
				Value = _ispawnmonsterpredependonpreceding
			};
		}

		// Token: 0x06029101 RID: 168193 RVA: 0x0059BCF0 File Offset: 0x00599EF0
		public static int Pack(FlatBufferBuilder builder, ISpawnMonsterPreConditonType_UnionUnion _o)
		{
			ISpawnMonsterPreConditonType_Union type = _o.Type;
			if (type == ISpawnMonsterPreConditonType_Union.ISpawnMonsterPreConditonType)
			{
				return ISpawnMonsterPreConditonType.Pack(builder, _o.AsISpawnMonsterPreConditonType()).Value;
			}
			if (type != ISpawnMonsterPreConditonType_Union.ISpawnMonsterPreDependOnPreceding)
			{
				return 0;
			}
			return ISpawnMonsterPreDependOnPreceding.Pack(builder, _o.AsISpawnMonsterPreDependOnPreceding()).Value;
		}
	}
}
