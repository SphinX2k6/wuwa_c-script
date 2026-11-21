using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007529 RID: 29993
	public class IPresentationType_UnionUnion
	{
		// Token: 0x1700DCAA RID: 56490
		// (get) Token: 0x06034987 RID: 215431 RVA: 0x00713F8D File Offset: 0x0071218D
		// (set) Token: 0x06034988 RID: 215432 RVA: 0x00713F95 File Offset: 0x00712195
		public IPresentationType_Union Type { get; set; }

		// Token: 0x1700DCAB RID: 56491
		// (get) Token: 0x06034989 RID: 215433 RVA: 0x00713F9E File Offset: 0x0071219E
		// (set) Token: 0x0603498A RID: 215434 RVA: 0x00713FA6 File Offset: 0x007121A6
		public object Value { get; set; }

		// Token: 0x0603498B RID: 215435 RVA: 0x00713FAF File Offset: 0x007121AF
		public IPresentationType_UnionUnion()
		{
			this.Type = IPresentationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603498C RID: 215436 RVA: 0x00713FC5 File Offset: 0x007121C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603498D RID: 215437 RVA: 0x00713FD7 File Offset: 0x007121D7
		public IPresentationTypeT AsIPresentationType()
		{
			return this.As<IPresentationTypeT>();
		}

		// Token: 0x0603498E RID: 215438 RVA: 0x00713FDF File Offset: 0x007121DF
		public static IPresentationType_UnionUnion FromIPresentationType(IPresentationTypeT _ipresentationtype)
		{
			return new IPresentationType_UnionUnion
			{
				Type = IPresentationType_Union.IPresentationType,
				Value = _ipresentationtype
			};
		}

		// Token: 0x0603498F RID: 215439 RVA: 0x00713FF4 File Offset: 0x007121F4
		public IResetPresentationFailureT AsIResetPresentationFailure()
		{
			return this.As<IResetPresentationFailureT>();
		}

		// Token: 0x06034990 RID: 215440 RVA: 0x00713FFC File Offset: 0x007121FC
		public static IPresentationType_UnionUnion FromIResetPresentationFailure(IResetPresentationFailureT _iresetpresentationfailure)
		{
			return new IPresentationType_UnionUnion
			{
				Type = IPresentationType_Union.IResetPresentationFailure,
				Value = _iresetpresentationfailure
			};
		}

		// Token: 0x06034991 RID: 215441 RVA: 0x00714014 File Offset: 0x00712214
		public static int Pack(FlatBufferBuilder builder, IPresentationType_UnionUnion _o)
		{
			IPresentationType_Union type = _o.Type;
			if (type == IPresentationType_Union.IPresentationType)
			{
				return IPresentationType.Pack(builder, _o.AsIPresentationType()).Value;
			}
			if (type != IPresentationType_Union.IResetPresentationFailure)
			{
				return 0;
			}
			return IResetPresentationFailure.Pack(builder, _o.AsIResetPresentationFailure()).Value;
		}
	}
}
