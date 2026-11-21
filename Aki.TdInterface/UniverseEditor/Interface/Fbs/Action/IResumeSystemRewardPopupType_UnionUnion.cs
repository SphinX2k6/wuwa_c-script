using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764F RID: 30287
	public class IResumeSystemRewardPopupType_UnionUnion
	{
		// Token: 0x1700DE67 RID: 56935
		// (get) Token: 0x06035239 RID: 217657 RVA: 0x007227F5 File Offset: 0x007209F5
		// (set) Token: 0x0603523A RID: 217658 RVA: 0x007227FD File Offset: 0x007209FD
		public IResumeSystemRewardPopupType_Union Type { get; set; }

		// Token: 0x1700DE68 RID: 56936
		// (get) Token: 0x0603523B RID: 217659 RVA: 0x00722806 File Offset: 0x00720A06
		// (set) Token: 0x0603523C RID: 217660 RVA: 0x0072280E File Offset: 0x00720A0E
		public object Value { get; set; }

		// Token: 0x0603523D RID: 217661 RVA: 0x00722817 File Offset: 0x00720A17
		public IResumeSystemRewardPopupType_UnionUnion()
		{
			this.Type = IResumeSystemRewardPopupType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603523E RID: 217662 RVA: 0x0072282D File Offset: 0x00720A2D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603523F RID: 217663 RVA: 0x0072283F File Offset: 0x00720A3F
		public IResumeSystemRewardPopupTypeT AsIResumeSystemRewardPopupType()
		{
			return this.As<IResumeSystemRewardPopupTypeT>();
		}

		// Token: 0x06035240 RID: 217664 RVA: 0x00722847 File Offset: 0x00720A47
		public static IResumeSystemRewardPopupType_UnionUnion FromIResumeSystemRewardPopupType(IResumeSystemRewardPopupTypeT _iresumesystemrewardpopuptype)
		{
			return new IResumeSystemRewardPopupType_UnionUnion
			{
				Type = IResumeSystemRewardPopupType_Union.IResumeSystemRewardPopupType,
				Value = _iresumesystemrewardpopuptype
			};
		}

		// Token: 0x06035241 RID: 217665 RVA: 0x0072285C File Offset: 0x00720A5C
		public IResumeGiantDeliveryRewardPopupT AsIResumeGiantDeliveryRewardPopup()
		{
			return this.As<IResumeGiantDeliveryRewardPopupT>();
		}

		// Token: 0x06035242 RID: 217666 RVA: 0x00722864 File Offset: 0x00720A64
		public static IResumeSystemRewardPopupType_UnionUnion FromIResumeGiantDeliveryRewardPopup(IResumeGiantDeliveryRewardPopupT _iresumegiantdeliveryrewardpopup)
		{
			return new IResumeSystemRewardPopupType_UnionUnion
			{
				Type = IResumeSystemRewardPopupType_Union.IResumeGiantDeliveryRewardPopup,
				Value = _iresumegiantdeliveryrewardpopup
			};
		}

		// Token: 0x06035243 RID: 217667 RVA: 0x0072287C File Offset: 0x00720A7C
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
