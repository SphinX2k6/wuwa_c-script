using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A1 RID: 31137
	public struct IStopGuestCartethyia : IFlatbufferObject
	{
		// Token: 0x1700E46B RID: 58475
		// (get) Token: 0x06036DDB RID: 224731 RVA: 0x00756A8E File Offset: 0x00754C8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036DDC RID: 224732 RVA: 0x00756A9B File Offset: 0x00754C9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036DDD RID: 224733 RVA: 0x00756AA4 File Offset: 0x00754CA4
		public static IStopGuestCartethyia GetRootAsIStopGuestCartethyia(ByteBuffer _bb)
		{
			return IStopGuestCartethyia.GetRootAsIStopGuestCartethyia(_bb, default(IStopGuestCartethyia));
		}

		// Token: 0x06036DDE RID: 224734 RVA: 0x00756AC0 File Offset: 0x00754CC0
		public static IStopGuestCartethyia GetRootAsIStopGuestCartethyia(ByteBuffer _bb, IStopGuestCartethyia obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DDF RID: 224735 RVA: 0x00756ADD File Offset: 0x00754CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DE0 RID: 224736 RVA: 0x00756AEC File Offset: 0x00754CEC
		public IStopGuestCartethyia __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E46C RID: 58476
		// (get) Token: 0x06036DE1 RID: 224737 RVA: 0x00756AFC File Offset: 0x00754CFC
		public EGuestUiAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuestUiAnimationType.GuestCartethyia;
				}
				return (EGuestUiAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036DE2 RID: 224738 RVA: 0x00756B38 File Offset: 0x00754D38
		public static Offset<IStopGuestCartethyia> CreateIStopGuestCartethyia(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IStopGuestCartethyia.AddType(builder, Type);
			return IStopGuestCartethyia.EndIStopGuestCartethyia(builder);
		}

		// Token: 0x06036DE3 RID: 224739 RVA: 0x00756B4E File Offset: 0x00754D4E
		public static void StartIStopGuestCartethyia(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036DE4 RID: 224740 RVA: 0x00756B57 File Offset: 0x00754D57
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036DE5 RID: 224741 RVA: 0x00756B62 File Offset: 0x00754D62
		public static Offset<IStopGuestCartethyia> EndIStopGuestCartethyia(FlatBufferBuilder builder)
		{
			return new Offset<IStopGuestCartethyia>(builder.EndTable());
		}

		// Token: 0x06036DE6 RID: 224742 RVA: 0x00756B70 File Offset: 0x00754D70
		public IStopGuestCartethyiaT UnPack()
		{
			IStopGuestCartethyiaT stopGuestCartethyiaT = new IStopGuestCartethyiaT();
			this.UnPackTo(stopGuestCartethyiaT);
			return stopGuestCartethyiaT;
		}

		// Token: 0x06036DE7 RID: 224743 RVA: 0x00756B8B File Offset: 0x00754D8B
		public void UnPackTo(IStopGuestCartethyiaT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036DE8 RID: 224744 RVA: 0x00756B9C File Offset: 0x00754D9C
		public static Offset<IStopGuestCartethyia> Pack(FlatBufferBuilder builder, IStopGuestCartethyiaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopGuestCartethyia>);
			}
			return IStopGuestCartethyia.CreateIStopGuestCartethyia(builder, _o.Type);
		}

		// Token: 0x04012CB0 RID: 76976
		private Table __p;
	}
}
