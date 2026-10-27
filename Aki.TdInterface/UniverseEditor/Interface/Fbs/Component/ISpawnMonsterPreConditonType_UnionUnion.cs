using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595D RID: 22877
	public class ISpawnMonsterPreConditonType_UnionUnion
	{
		// Token: 0x1700ABB8 RID: 43960
		// (get) Token: 0x06026B8D RID: 158605 RVA: 0x00554FFD File Offset: 0x005531FD
		// (set) Token: 0x06026B8E RID: 158606 RVA: 0x00555005 File Offset: 0x00553205
		public ISpawnMonsterPreConditonType_Union Type { get; set; }

		// Token: 0x1700ABB9 RID: 43961
		// (get) Token: 0x06026B8F RID: 158607 RVA: 0x0055500E File Offset: 0x0055320E
		// (set) Token: 0x06026B90 RID: 158608 RVA: 0x00555016 File Offset: 0x00553216
		public object Value { get; set; }

		// Token: 0x06026B91 RID: 158609 RVA: 0x0055501F File Offset: 0x0055321F
		public ISpawnMonsterPreConditonType_UnionUnion()
		{
			this.Type = ISpawnMonsterPreConditonType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026B92 RID: 158610 RVA: 0x00555035 File Offset: 0x00553235
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026B93 RID: 158611 RVA: 0x00555047 File Offset: 0x00553247
		public ISpawnMonsterPreConditonTypeT AsISpawnMonsterPreConditonType()
		{
			return this.As<ISpawnMonsterPreConditonTypeT>();
		}

		// Token: 0x06026B94 RID: 158612 RVA: 0x0055504F File Offset: 0x0055324F
		public static ISpawnMonsterPreConditonType_UnionUnion FromISpawnMonsterPreConditonType(ISpawnMonsterPreConditonTypeT _ispawnmonsterpreconditontype)
		{
			return new ISpawnMonsterPreConditonType_UnionUnion
			{
				Type = ISpawnMonsterPreConditonType_Union.ISpawnMonsterPreConditonType,
				Value = _ispawnmonsterpreconditontype
			};
		}

		// Token: 0x06026B95 RID: 158613 RVA: 0x00555064 File Offset: 0x00553264
		public ISpawnMonsterPreDependOnPrecedingT AsISpawnMonsterPreDependOnPreceding()
		{
			return this.As<ISpawnMonsterPreDependOnPrecedingT>();
		}

		// Token: 0x06026B96 RID: 158614 RVA: 0x0055506C File Offset: 0x0055326C
		public static ISpawnMonsterPreConditonType_UnionUnion FromISpawnMonsterPreDependOnPreceding(ISpawnMonsterPreDependOnPrecedingT _ispawnmonsterpredependonpreceding)
		{
			return new ISpawnMonsterPreConditonType_UnionUnion
			{
				Type = ISpawnMonsterPreConditonType_Union.ISpawnMonsterPreDependOnPreceding,
				Value = _ispawnmonsterpredependonpreceding
			};
		}

		// Token: 0x06026B97 RID: 158615 RVA: 0x00555084 File Offset: 0x00553284
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
