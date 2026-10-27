using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAE RID: 28078
	public class IPresentationType_UnionUnion
	{
		// Token: 0x1700D162 RID: 53602
		// (get) Token: 0x0603198B RID: 203147 RVA: 0x006B88A5 File Offset: 0x006B6AA5
		// (set) Token: 0x0603198C RID: 203148 RVA: 0x006B88AD File Offset: 0x006B6AAD
		public IPresentationType_Union Type { get; set; }

		// Token: 0x1700D163 RID: 53603
		// (get) Token: 0x0603198D RID: 203149 RVA: 0x006B88B6 File Offset: 0x006B6AB6
		// (set) Token: 0x0603198E RID: 203150 RVA: 0x006B88BE File Offset: 0x006B6ABE
		public object Value { get; set; }

		// Token: 0x0603198F RID: 203151 RVA: 0x006B88C7 File Offset: 0x006B6AC7
		public IPresentationType_UnionUnion()
		{
			this.Type = IPresentationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031990 RID: 203152 RVA: 0x006B88DD File Offset: 0x006B6ADD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031991 RID: 203153 RVA: 0x006B88EF File Offset: 0x006B6AEF
		public IPresentationTypeT AsIPresentationType()
		{
			return this.As<IPresentationTypeT>();
		}

		// Token: 0x06031992 RID: 203154 RVA: 0x006B88F7 File Offset: 0x006B6AF7
		public static IPresentationType_UnionUnion FromIPresentationType(IPresentationTypeT _ipresentationtype)
		{
			return new IPresentationType_UnionUnion
			{
				Type = IPresentationType_Union.IPresentationType,
				Value = _ipresentationtype
			};
		}

		// Token: 0x06031993 RID: 203155 RVA: 0x006B890C File Offset: 0x006B6B0C
		public IResetPresentationFailureT AsIResetPresentationFailure()
		{
			return this.As<IResetPresentationFailureT>();
		}

		// Token: 0x06031994 RID: 203156 RVA: 0x006B8914 File Offset: 0x006B6B14
		public static IPresentationType_UnionUnion FromIResetPresentationFailure(IResetPresentationFailureT _iresetpresentationfailure)
		{
			return new IPresentationType_UnionUnion
			{
				Type = IPresentationType_Union.IResetPresentationFailure,
				Value = _iresetpresentationfailure
			};
		}

		// Token: 0x06031995 RID: 203157 RVA: 0x006B892C File Offset: 0x006B6B2C
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
