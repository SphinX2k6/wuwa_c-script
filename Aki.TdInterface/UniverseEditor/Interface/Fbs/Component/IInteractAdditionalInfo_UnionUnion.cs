using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BB RID: 22971
	public class IInteractAdditionalInfo_UnionUnion
	{
		// Token: 0x1700A6C1 RID: 42689
		// (get) Token: 0x06025749 RID: 153417 RVA: 0x005231F9 File Offset: 0x005213F9
		// (set) Token: 0x0602574A RID: 153418 RVA: 0x00523201 File Offset: 0x00521401
		public IInteractAdditionalInfo_Union Type { get; set; }

		// Token: 0x1700A6C2 RID: 42690
		// (get) Token: 0x0602574B RID: 153419 RVA: 0x0052320A File Offset: 0x0052140A
		// (set) Token: 0x0602574C RID: 153420 RVA: 0x00523212 File Offset: 0x00521412
		public object Value { get; set; }

		// Token: 0x0602574D RID: 153421 RVA: 0x0052321B File Offset: 0x0052141B
		public IInteractAdditionalInfo_UnionUnion()
		{
			this.Type = IInteractAdditionalInfo_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602574E RID: 153422 RVA: 0x00523231 File Offset: 0x00521431
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602574F RID: 153423 RVA: 0x00523243 File Offset: 0x00521443
		public IInteractAdditionalInfoT AsIInteractAdditionalInfo()
		{
			return this.As<IInteractAdditionalInfoT>();
		}

		// Token: 0x06025750 RID: 153424 RVA: 0x0052324B File Offset: 0x0052144B
		public static IInteractAdditionalInfo_UnionUnion FromIInteractAdditionalInfo(IInteractAdditionalInfoT _iinteractadditionalinfo)
		{
			return new IInteractAdditionalInfo_UnionUnion
			{
				Type = IInteractAdditionalInfo_Union.IInteractAdditionalInfo,
				Value = _iinteractadditionalinfo
			};
		}

		// Token: 0x06025751 RID: 153425 RVA: 0x00523260 File Offset: 0x00521460
		public IFishingPointAdditionalInfoT AsIFishingPointAdditionalInfo()
		{
			return this.As<IFishingPointAdditionalInfoT>();
		}

		// Token: 0x06025752 RID: 153426 RVA: 0x00523268 File Offset: 0x00521468
		public static IInteractAdditionalInfo_UnionUnion FromIFishingPointAdditionalInfo(IFishingPointAdditionalInfoT _ifishingpointadditionalinfo)
		{
			return new IInteractAdditionalInfo_UnionUnion
			{
				Type = IInteractAdditionalInfo_Union.IFishingPointAdditionalInfo,
				Value = _ifishingpointadditionalinfo
			};
		}

		// Token: 0x06025753 RID: 153427 RVA: 0x00523280 File Offset: 0x00521480
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
