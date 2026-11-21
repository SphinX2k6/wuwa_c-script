using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007645 RID: 30277
	public struct IResumeGiantDeliveryRewardPopup : IFlatbufferObject
	{
		// Token: 0x1700DE5E RID: 56926
		// (get) Token: 0x06035203 RID: 217603 RVA: 0x0072230A File Offset: 0x0072050A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035204 RID: 217604 RVA: 0x00722317 File Offset: 0x00720517
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035205 RID: 217605 RVA: 0x00722320 File Offset: 0x00720520
		public static IResumeGiantDeliveryRewardPopup GetRootAsIResumeGiantDeliveryRewardPopup(ByteBuffer _bb)
		{
			return IResumeGiantDeliveryRewardPopup.GetRootAsIResumeGiantDeliveryRewardPopup(_bb, default(IResumeGiantDeliveryRewardPopup));
		}

		// Token: 0x06035206 RID: 217606 RVA: 0x0072233C File Offset: 0x0072053C
		public static IResumeGiantDeliveryRewardPopup GetRootAsIResumeGiantDeliveryRewardPopup(ByteBuffer _bb, IResumeGiantDeliveryRewardPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035207 RID: 217607 RVA: 0x00722359 File Offset: 0x00720559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035208 RID: 217608 RVA: 0x00722368 File Offset: 0x00720568
		public IResumeGiantDeliveryRewardPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE5F RID: 56927
		// (get) Token: 0x06035209 RID: 217609 RVA: 0x00722378 File Offset: 0x00720578
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603520A RID: 217610 RVA: 0x007223B4 File Offset: 0x007205B4
		public static Offset<IResumeGiantDeliveryRewardPopup> CreateIResumeGiantDeliveryRewardPopup(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop)
		{
			builder.StartTable(1);
			IResumeGiantDeliveryRewardPopup.AddType(builder, Type);
			return IResumeGiantDeliveryRewardPopup.EndIResumeGiantDeliveryRewardPopup(builder);
		}

		// Token: 0x0603520B RID: 217611 RVA: 0x007223CA File Offset: 0x007205CA
		public static void StartIResumeGiantDeliveryRewardPopup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603520C RID: 217612 RVA: 0x007223D3 File Offset: 0x007205D3
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603520D RID: 217613 RVA: 0x007223DE File Offset: 0x007205DE
		public static Offset<IResumeGiantDeliveryRewardPopup> EndIResumeGiantDeliveryRewardPopup(FlatBufferBuilder builder)
		{
			return new Offset<IResumeGiantDeliveryRewardPopup>(builder.EndTable());
		}

		// Token: 0x0603520E RID: 217614 RVA: 0x007223EC File Offset: 0x007205EC
		public IResumeGiantDeliveryRewardPopupT UnPack()
		{
			IResumeGiantDeliveryRewardPopupT resumeGiantDeliveryRewardPopupT = new IResumeGiantDeliveryRewardPopupT();
			this.UnPackTo(resumeGiantDeliveryRewardPopupT);
			return resumeGiantDeliveryRewardPopupT;
		}

		// Token: 0x0603520F RID: 217615 RVA: 0x00722407 File Offset: 0x00720607
		public void UnPackTo(IResumeGiantDeliveryRewardPopupT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035210 RID: 217616 RVA: 0x00722418 File Offset: 0x00720618
		public static Offset<IResumeGiantDeliveryRewardPopup> Pack(FlatBufferBuilder builder, IResumeGiantDeliveryRewardPopupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResumeGiantDeliveryRewardPopup>);
			}
			return IResumeGiantDeliveryRewardPopup.CreateIResumeGiantDeliveryRewardPopup(builder, _o.Type);
		}

		// Token: 0x04012838 RID: 75832
		private Table __p;
	}
}
