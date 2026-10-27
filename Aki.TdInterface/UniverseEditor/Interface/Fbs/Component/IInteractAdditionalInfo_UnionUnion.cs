using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005435 RID: 21557
	public class IInteractAdditionalInfo_UnionUnion
	{
		// Token: 0x17009E87 RID: 40583
		// (get) Token: 0x06023691 RID: 145041 RVA: 0x004E61CD File Offset: 0x004E43CD
		// (set) Token: 0x06023692 RID: 145042 RVA: 0x004E61D5 File Offset: 0x004E43D5
		public IInteractAdditionalInfo_Union Type { get; set; }

		// Token: 0x17009E88 RID: 40584
		// (get) Token: 0x06023693 RID: 145043 RVA: 0x004E61DE File Offset: 0x004E43DE
		// (set) Token: 0x06023694 RID: 145044 RVA: 0x004E61E6 File Offset: 0x004E43E6
		public object Value { get; set; }

		// Token: 0x06023695 RID: 145045 RVA: 0x004E61EF File Offset: 0x004E43EF
		public IInteractAdditionalInfo_UnionUnion()
		{
			this.Type = IInteractAdditionalInfo_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023696 RID: 145046 RVA: 0x004E6205 File Offset: 0x004E4405
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023697 RID: 145047 RVA: 0x004E6217 File Offset: 0x004E4417
		public IInteractAdditionalInfoT AsIInteractAdditionalInfo()
		{
			return this.As<IInteractAdditionalInfoT>();
		}

		// Token: 0x06023698 RID: 145048 RVA: 0x004E621F File Offset: 0x004E441F
		public static IInteractAdditionalInfo_UnionUnion FromIInteractAdditionalInfo(IInteractAdditionalInfoT _iinteractadditionalinfo)
		{
			return new IInteractAdditionalInfo_UnionUnion
			{
				Type = IInteractAdditionalInfo_Union.IInteractAdditionalInfo,
				Value = _iinteractadditionalinfo
			};
		}

		// Token: 0x06023699 RID: 145049 RVA: 0x004E6234 File Offset: 0x004E4434
		public IFishingPointAdditionalInfoT AsIFishingPointAdditionalInfo()
		{
			return this.As<IFishingPointAdditionalInfoT>();
		}

		// Token: 0x0602369A RID: 145050 RVA: 0x004E623C File Offset: 0x004E443C
		public static IInteractAdditionalInfo_UnionUnion FromIFishingPointAdditionalInfo(IFishingPointAdditionalInfoT _ifishingpointadditionalinfo)
		{
			return new IInteractAdditionalInfo_UnionUnion
			{
				Type = IInteractAdditionalInfo_Union.IFishingPointAdditionalInfo,
				Value = _ifishingpointadditionalinfo
			};
		}

		// Token: 0x0602369B RID: 145051 RVA: 0x004E6254 File Offset: 0x004E4454
		public static int Pack(FlatBufferBuilder builder, IInteractAdditionalInfo_UnionUnion _o)
		{
			IInteractAdditionalInfo_Union type = _o.Type;
			if (type == IInteractAdditionalInfo_Union.IInteractAdditionalInfo)
			{
				return IInteractAdditionalInfo.Pack(builder, _o.AsIInteractAdditionalInfo()).Value;
			}
			if (type != IInteractAdditionalInfo_Union.IFishingPointAdditionalInfo)
			{
				return 0;
			}
			return IFishingPointAdditionalInfo.Pack(builder, _o.AsIFishingPointAdditionalInfo()).Value;
		}
	}
}
