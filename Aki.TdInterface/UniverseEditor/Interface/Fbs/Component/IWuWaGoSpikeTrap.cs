using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD9 RID: 23513
	public struct IWuWaGoSpikeTrap : IFlatbufferObject
	{
		// Token: 0x1700B1B0 RID: 45488
		// (get) Token: 0x060284B3 RID: 165043 RVA: 0x00589586 File Offset: 0x00587786
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060284B4 RID: 165044 RVA: 0x00589593 File Offset: 0x00587793
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060284B5 RID: 165045 RVA: 0x0058959C File Offset: 0x0058779C
		public static IWuWaGoSpikeTrap GetRootAsIWuWaGoSpikeTrap(ByteBuffer _bb)
		{
			return IWuWaGoSpikeTrap.GetRootAsIWuWaGoSpikeTrap(_bb, default(IWuWaGoSpikeTrap));
		}

		// Token: 0x060284B6 RID: 165046 RVA: 0x005895B8 File Offset: 0x005877B8
		public static IWuWaGoSpikeTrap GetRootAsIWuWaGoSpikeTrap(ByteBuffer _bb, IWuWaGoSpikeTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060284B7 RID: 165047 RVA: 0x005895D5 File Offset: 0x005877D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060284B8 RID: 165048 RVA: 0x005895E4 File Offset: 0x005877E4
		public IWuWaGoSpikeTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1B1 RID: 45489
		// (get) Token: 0x060284B9 RID: 165049 RVA: 0x005895F4 File Offset: 0x005877F4
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B1B2 RID: 45490
		// (get) Token: 0x060284BA RID: 165050 RVA: 0x00589630 File Offset: 0x00587830
		public IWuWaGoGridLinkData? LinkData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x060284BB RID: 165051 RVA: 0x00589682 File Offset: 0x00587882
		public static Offset<IWuWaGoSpikeTrap> CreateIWuWaGoSpikeTrap(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null)
		{
			builder.StartTable(2);
			IWuWaGoSpikeTrap.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoSpikeTrap.AddType(builder, Type);
			return IWuWaGoSpikeTrap.EndIWuWaGoSpikeTrap(builder);
		}

		// Token: 0x060284BC RID: 165052 RVA: 0x005896A5 File Offset: 0x005878A5
		public static void StartIWuWaGoSpikeTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060284BD RID: 165053 RVA: 0x005896AE File Offset: 0x005878AE
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060284BE RID: 165054 RVA: 0x005896B9 File Offset: 0x005878B9
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x060284BF RID: 165055 RVA: 0x005896C9 File Offset: 0x005878C9
		public static Offset<IWuWaGoSpikeTrap> EndIWuWaGoSpikeTrap(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoSpikeTrap>(builder.EndTable());
		}

		// Token: 0x060284C0 RID: 165056 RVA: 0x005896D8 File Offset: 0x005878D8
		public IWuWaGoSpikeTrapT UnPack()
		{
			IWuWaGoSpikeTrapT wuWaGoSpikeTrapT = new IWuWaGoSpikeTrapT();
			this.UnPackTo(wuWaGoSpikeTrapT);
			return wuWaGoSpikeTrapT;
		}

		// Token: 0x060284C1 RID: 165057 RVA: 0x005896F4 File Offset: 0x005878F4
		public void UnPackTo(IWuWaGoSpikeTrapT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
		}

		// Token: 0x060284C2 RID: 165058 RVA: 0x0058973C File Offset: 0x0058793C
		public static Offset<IWuWaGoSpikeTrap> Pack(FlatBufferBuilder builder, IWuWaGoSpikeTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoSpikeTrap>);
			}
			return IWuWaGoSpikeTrap.CreateIWuWaGoSpikeTrap(builder, _o.Type, _o.LinkData);
		}

		// Token: 0x0400F35A RID: 62298
		private Table __p;
	}
}
