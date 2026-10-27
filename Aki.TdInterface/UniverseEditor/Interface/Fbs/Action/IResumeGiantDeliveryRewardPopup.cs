using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC1 RID: 28353
	public struct IResumeGiantDeliveryRewardPopup : IFlatbufferObject
	{
		// Token: 0x1700D307 RID: 54023
		// (get) Token: 0x060321C3 RID: 205251 RVA: 0x006C65D6 File Offset: 0x006C47D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321C4 RID: 205252 RVA: 0x006C65E3 File Offset: 0x006C47E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321C5 RID: 205253 RVA: 0x006C65EC File Offset: 0x006C47EC
		public static IResumeGiantDeliveryRewardPopup GetRootAsIResumeGiantDeliveryRewardPopup(ByteBuffer _bb)
		{
			return IResumeGiantDeliveryRewardPopup.GetRootAsIResumeGiantDeliveryRewardPopup(_bb, default(IResumeGiantDeliveryRewardPopup));
		}

		// Token: 0x060321C6 RID: 205254 RVA: 0x006C6608 File Offset: 0x006C4808
		public static IResumeGiantDeliveryRewardPopup GetRootAsIResumeGiantDeliveryRewardPopup(ByteBuffer _bb, IResumeGiantDeliveryRewardPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321C7 RID: 205255 RVA: 0x006C6625 File Offset: 0x006C4825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321C8 RID: 205256 RVA: 0x006C6634 File Offset: 0x006C4834
		public IResumeGiantDeliveryRewardPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D308 RID: 54024
		// (get) Token: 0x060321C9 RID: 205257 RVA: 0x006C6644 File Offset: 0x006C4844
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

		// Token: 0x060321CA RID: 205258 RVA: 0x006C6680 File Offset: 0x006C4880
		public static Offset<IResumeGiantDeliveryRewardPopup> CreateIResumeGiantDeliveryRewardPopup(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop)
		{
			builder.StartTable(1);
			IResumeGiantDeliveryRewardPopup.AddType(builder, Type);
			return IResumeGiantDeliveryRewardPopup.EndIResumeGiantDeliveryRewardPopup(builder);
		}

		// Token: 0x060321CB RID: 205259 RVA: 0x006C6696 File Offset: 0x006C4896
		public static void StartIResumeGiantDeliveryRewardPopup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060321CC RID: 205260 RVA: 0x006C669F File Offset: 0x006C489F
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060321CD RID: 205261 RVA: 0x006C66AA File Offset: 0x006C48AA
		public static Offset<IResumeGiantDeliveryRewardPopup> EndIResumeGiantDeliveryRewardPopup(FlatBufferBuilder builder)
		{
			return new Offset<IResumeGiantDeliveryRewardPopup>(builder.EndTable());
		}

		// Token: 0x060321CE RID: 205262 RVA: 0x006C66B8 File Offset: 0x006C48B8
		public IResumeGiantDeliveryRewardPopupT UnPack()
		{
			IResumeGiantDeliveryRewardPopupT resumeGiantDeliveryRewardPopupT = new IResumeGiantDeliveryRewardPopupT();
			this.UnPackTo(resumeGiantDeliveryRewardPopupT);
			return resumeGiantDeliveryRewardPopupT;
		}

		// Token: 0x060321CF RID: 205263 RVA: 0x006C66D3 File Offset: 0x006C48D3
		public void UnPackTo(IResumeGiantDeliveryRewardPopupT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060321D0 RID: 205264 RVA: 0x006C66E4 File Offset: 0x006C48E4
		public static Offset<IResumeGiantDeliveryRewardPopup> Pack(FlatBufferBuilder builder, IResumeGiantDeliveryRewardPopupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResumeGiantDeliveryRewardPopup>);
			}
			return IResumeGiantDeliveryRewardPopup.CreateIResumeGiantDeliveryRewardPopup(builder, _o.Type);
		}

		// Token: 0x040118B3 RID: 71859
		private Table __p;
	}
}
