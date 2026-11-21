using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C82 RID: 23682
	public class IPasserbyNpcGenerateTypeBase_UnionUnion
	{
		// Token: 0x1700ADFF RID: 44543
		// (get) Token: 0x0602748D RID: 160909 RVA: 0x00561405 File Offset: 0x0055F605
		// (set) Token: 0x0602748E RID: 160910 RVA: 0x0056140D File Offset: 0x0055F60D
		public IPasserbyNpcGenerateTypeBase_Union Type { get; set; }

		// Token: 0x1700AE00 RID: 44544
		// (get) Token: 0x0602748F RID: 160911 RVA: 0x00561416 File Offset: 0x0055F616
		// (set) Token: 0x06027490 RID: 160912 RVA: 0x0056141E File Offset: 0x0055F61E
		public object Value { get; set; }

		// Token: 0x06027491 RID: 160913 RVA: 0x00561427 File Offset: 0x0055F627
		public IPasserbyNpcGenerateTypeBase_UnionUnion()
		{
			this.Type = IPasserbyNpcGenerateTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027492 RID: 160914 RVA: 0x0056143D File Offset: 0x0055F63D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027493 RID: 160915 RVA: 0x0056144F File Offset: 0x0055F64F
		public IPasserbyNpcGenerateTypeBaseT AsIPasserbyNpcGenerateTypeBase()
		{
			return this.As<IPasserbyNpcGenerateTypeBaseT>();
		}

		// Token: 0x06027494 RID: 160916 RVA: 0x00561457 File Offset: 0x0055F657
		public static IPasserbyNpcGenerateTypeBase_UnionUnion FromIPasserbyNpcGenerateTypeBase(IPasserbyNpcGenerateTypeBaseT _ipasserbynpcgeneratetypebase)
		{
			return new IPasserbyNpcGenerateTypeBase_UnionUnion
			{
				Type = IPasserbyNpcGenerateTypeBase_Union.IPasserbyNpcGenerateTypeBase,
				Value = _ipasserbynpcgeneratetypebase
			};
		}

		// Token: 0x06027495 RID: 160917 RVA: 0x0056146C File Offset: 0x0055F66C
		public IPasserbyNpcRandomStandGenerateT AsIPasserbyNpcRandomStandGenerate()
		{
			return this.As<IPasserbyNpcRandomStandGenerateT>();
		}

		// Token: 0x06027496 RID: 160918 RVA: 0x00561474 File Offset: 0x0055F674
		public static IPasserbyNpcGenerateTypeBase_UnionUnion FromIPasserbyNpcRandomStandGenerate(IPasserbyNpcRandomStandGenerateT _ipasserbynpcrandomstandgenerate)
		{
			return new IPasserbyNpcGenerateTypeBase_UnionUnion
			{
				Type = IPasserbyNpcGenerateTypeBase_Union.IPasserbyNpcRandomStandGenerate,
				Value = _ipasserbynpcrandomstandgenerate
			};
		}

		// Token: 0x06027497 RID: 160919 RVA: 0x0056148C File Offset: 0x0055F68C
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcGenerateTypeBase_UnionUnion _o)
		{
			IPasserbyNpcGenerateTypeBase_Union type = _o.Type;
			if (type == IPasserbyNpcGenerateTypeBase_Union.IPasserbyNpcGenerateTypeBase)
			{
				return IPasserbyNpcGenerateTypeBase.Pack(builder, _o.AsIPasserbyNpcGenerateTypeBase()).Value;
			}
			if (type != IPasserbyNpcGenerateTypeBase_Union.IPasserbyNpcRandomStandGenerate)
			{
				return 0;
			}
			return IPasserbyNpcRandomStandGenerate.Pack(builder, _o.AsIPasserbyNpcRandomStandGenerate()).Value;
		}
	}
}
