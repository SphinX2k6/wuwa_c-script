using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECB RID: 28363
	public class IResumeSystemRewardPopupType_UnionUnion
	{
		// Token: 0x1700D310 RID: 54032
		// (get) Token: 0x060321F9 RID: 205305 RVA: 0x006C6AC1 File Offset: 0x006C4CC1
		// (set) Token: 0x060321FA RID: 205306 RVA: 0x006C6AC9 File Offset: 0x006C4CC9
		public IResumeSystemRewardPopupType_Union Type { get; set; }

		// Token: 0x1700D311 RID: 54033
		// (get) Token: 0x060321FB RID: 205307 RVA: 0x006C6AD2 File Offset: 0x006C4CD2
		// (set) Token: 0x060321FC RID: 205308 RVA: 0x006C6ADA File Offset: 0x006C4CDA
		public object Value { get; set; }

		// Token: 0x060321FD RID: 205309 RVA: 0x006C6AE3 File Offset: 0x006C4CE3
		public IResumeSystemRewardPopupType_UnionUnion()
		{
			this.Type = IResumeSystemRewardPopupType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060321FE RID: 205310 RVA: 0x006C6AF9 File Offset: 0x006C4CF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060321FF RID: 205311 RVA: 0x006C6B0B File Offset: 0x006C4D0B
		public IResumeSystemRewardPopupTypeT AsIResumeSystemRewardPopupType()
		{
			return this.As<IResumeSystemRewardPopupTypeT>();
		}

		// Token: 0x06032200 RID: 205312 RVA: 0x006C6B13 File Offset: 0x006C4D13
		public static IResumeSystemRewardPopupType_UnionUnion FromIResumeSystemRewardPopupType(IResumeSystemRewardPopupTypeT _iresumesystemrewardpopuptype)
		{
			return new IResumeSystemRewardPopupType_UnionUnion
			{
				Type = IResumeSystemRewardPopupType_Union.IResumeSystemRewardPopupType,
				Value = _iresumesystemrewardpopuptype
			};
		}

		// Token: 0x06032201 RID: 205313 RVA: 0x006C6B28 File Offset: 0x006C4D28
		public IResumeGiantDeliveryRewardPopupT AsIResumeGiantDeliveryRewardPopup()
		{
			return this.As<IResumeGiantDeliveryRewardPopupT>();
		}

		// Token: 0x06032202 RID: 205314 RVA: 0x006C6B30 File Offset: 0x006C4D30
		public static IResumeSystemRewardPopupType_UnionUnion FromIResumeGiantDeliveryRewardPopup(IResumeGiantDeliveryRewardPopupT _iresumegiantdeliveryrewardpopup)
		{
			return new IResumeSystemRewardPopupType_UnionUnion
			{
				Type = IResumeSystemRewardPopupType_Union.IResumeGiantDeliveryRewardPopup,
				Value = _iresumegiantdeliveryrewardpopup
			};
		}

		// Token: 0x06032203 RID: 205315 RVA: 0x006C6B48 File Offset: 0x006C4D48
		public static int Pack(FlatBufferBuilder builder, IResumeSystemRewardPopupType_UnionUnion _o)
		{
			IResumeSystemRewardPopupType_Union type = _o.Type;
			if (type == IResumeSystemRewardPopupType_Union.IResumeSystemRewardPopupType)
			{
				return IResumeSystemRewardPopupType.Pack(builder, _o.AsIResumeSystemRewardPopupType()).Value;
			}
			if (type != IResumeSystemRewardPopupType_Union.IResumeGiantDeliveryRewardPopup)
			{
				return 0;
			}
			return IResumeGiantDeliveryRewardPopup.Pack(builder, _o.AsIResumeGiantDeliveryRewardPopup()).Value;
		}
	}
}
