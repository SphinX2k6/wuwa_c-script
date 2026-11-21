using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200619A RID: 24986
	public class IWindSourceBase_UnionUnion
	{
		// Token: 0x1700BA54 RID: 47700
		// (get) Token: 0x0602A76D RID: 173933 RVA: 0x005CADF5 File Offset: 0x005C8FF5
		// (set) Token: 0x0602A76E RID: 173934 RVA: 0x005CADFD File Offset: 0x005C8FFD
		public IWindSourceBase_Union Type { get; set; }

		// Token: 0x1700BA55 RID: 47701
		// (get) Token: 0x0602A76F RID: 173935 RVA: 0x005CAE06 File Offset: 0x005C9006
		// (set) Token: 0x0602A770 RID: 173936 RVA: 0x005CAE0E File Offset: 0x005C900E
		public object Value { get; set; }

		// Token: 0x0602A771 RID: 173937 RVA: 0x005CAE17 File Offset: 0x005C9017
		public IWindSourceBase_UnionUnion()
		{
			this.Type = IWindSourceBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A772 RID: 173938 RVA: 0x005CAE2D File Offset: 0x005C902D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A773 RID: 173939 RVA: 0x005CAE3F File Offset: 0x005C903F
		public IWindSourceBaseT AsIWindSourceBase()
		{
			return this.As<IWindSourceBaseT>();
		}

		// Token: 0x0602A774 RID: 173940 RVA: 0x005CAE47 File Offset: 0x005C9047
		public static IWindSourceBase_UnionUnion FromIWindSourceBase(IWindSourceBaseT _iwindsourcebase)
		{
			return new IWindSourceBase_UnionUnion
			{
				Type = IWindSourceBase_Union.IWindSourceBase,
				Value = _iwindsourcebase
			};
		}

		// Token: 0x0602A775 RID: 173941 RVA: 0x005CAE5C File Offset: 0x005C905C
		public IWindDirectionalT AsIWindDirectional()
		{
			return this.As<IWindDirectionalT>();
		}

		// Token: 0x0602A776 RID: 173942 RVA: 0x005CAE64 File Offset: 0x005C9064
		public static IWindSourceBase_UnionUnion FromIWindDirectional(IWindDirectionalT _iwinddirectional)
		{
			return new IWindSourceBase_UnionUnion
			{
				Type = IWindSourceBase_Union.IWindDirectional,
				Value = _iwinddirectional
			};
		}

		// Token: 0x0602A777 RID: 173943 RVA: 0x005CAE7C File Offset: 0x005C907C
		public static int Pack(FlatBufferBuilder builder, IWindSourceBase_UnionUnion _o)
		{
			IWindSourceBase_Union type = _o.Type;
			if (type == IWindSourceBase_Union.IWindSourceBase)
			{
				return IWindSourceBase.Pack(builder, _o.AsIWindSourceBase()).Value;
			}
			if (type != IWindSourceBase_Union.IWindDirectional)
			{
				return 0;
			}
			return IWindDirectional.Pack(builder, _o.AsIWindDirectional()).Value;
		}
	}
}
