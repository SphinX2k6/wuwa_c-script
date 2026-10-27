using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D74 RID: 28020
	public struct IPostAkEventMap : IFlatbufferObject
	{
		// Token: 0x1700D10A RID: 53514
		// (get) Token: 0x060317D4 RID: 202708 RVA: 0x006B59F5 File Offset: 0x006B3BF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060317D5 RID: 202709 RVA: 0x006B5A02 File Offset: 0x006B3C02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060317D6 RID: 202710 RVA: 0x006B5A0C File Offset: 0x006B3C0C
		public static IPostAkEventMap GetRootAsIPostAkEventMap(ByteBuffer _bb)
		{
			return IPostAkEventMap.GetRootAsIPostAkEventMap(_bb, default(IPostAkEventMap));
		}

		// Token: 0x060317D7 RID: 202711 RVA: 0x006B5A28 File Offset: 0x006B3C28
		public static IPostAkEventMap GetRootAsIPostAkEventMap(ByteBuffer _bb, IPostAkEventMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060317D8 RID: 202712 RVA: 0x006B5A45 File Offset: 0x006B3C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060317D9 RID: 202713 RVA: 0x006B5A54 File Offset: 0x006B3C54
		public IPostAkEventMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D10B RID: 53515
		// (get) Token: 0x060317DA RID: 202714 RVA: 0x006B5A64 File Offset: 0x006B3C64
		public EPostAkEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPostAkEvent.Global;
				}
				return (EPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D10C RID: 53516
		// (get) Token: 0x060317DB RID: 202715 RVA: 0x006B5AA0 File Offset: 0x006B3CA0
		public IPlayMapMusic? MapEventType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayMapMusic?(default(IPlayMapMusic).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D10D RID: 53517
		// (get) Token: 0x060317DC RID: 202716 RVA: 0x006B5B00 File Offset: 0x006B3D00
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060317DD RID: 202717 RVA: 0x006B5B37 File Offset: 0x006B3D37
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060317DE RID: 202718 RVA: 0x006B5B46 File Offset: 0x006B3D46
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060317DF RID: 202719 RVA: 0x006B5B54 File Offset: 0x006B3D54
		public static Offset<IPostAkEventMap> CreateIPostAkEventMap(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, Offset<IPlayMapMusic> MapEventTypeOffset = default(Offset<IPlayMapMusic>), StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPostAkEventMap.AddAkEvent(builder, AkEventOffset);
			IPostAkEventMap.AddMapEventType(builder, MapEventTypeOffset);
			IPostAkEventMap.AddType(builder, Type);
			return IPostAkEventMap.EndIPostAkEventMap(builder);
		}

		// Token: 0x060317E0 RID: 202720 RVA: 0x006B5B78 File Offset: 0x006B3D78
		public static void StartIPostAkEventMap(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060317E1 RID: 202721 RVA: 0x006B5B81 File Offset: 0x006B3D81
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060317E2 RID: 202722 RVA: 0x006B5B8C File Offset: 0x006B3D8C
		public static void AddMapEventType(FlatBufferBuilder builder, Offset<IPlayMapMusic> mapEventTypeOffset)
		{
			builder.AddOffset(1, mapEventTypeOffset.Value, 0);
		}

		// Token: 0x060317E3 RID: 202723 RVA: 0x006B5B9C File Offset: 0x006B3D9C
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(2, akEventOffset.Value, 0);
		}

		// Token: 0x060317E4 RID: 202724 RVA: 0x006B5BAC File Offset: 0x006B3DAC
		public static Offset<IPostAkEventMap> EndIPostAkEventMap(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventMap>(builder.EndTable());
		}

		// Token: 0x060317E5 RID: 202725 RVA: 0x006B5BBC File Offset: 0x006B3DBC
		public IPostAkEventMapT UnPack()
		{
			IPostAkEventMapT postAkEventMapT = new IPostAkEventMapT();
			this.UnPackTo(postAkEventMapT);
			return postAkEventMapT;
		}

		// Token: 0x060317E6 RID: 202726 RVA: 0x006B5BD8 File Offset: 0x006B3DD8
		public void UnPackTo(IPostAkEventMapT _o)
		{
			_o.Type = this.Type;
			_o.MapEventType = ((this.MapEventType != null) ? this.MapEventType.Value.UnPack() : null);
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x060317E7 RID: 202727 RVA: 0x006B5C2C File Offset: 0x006B3E2C
		public static Offset<IPostAkEventMap> Pack(FlatBufferBuilder builder, IPostAkEventMapT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventMap>);
			}
			Offset<IPlayMapMusic> mapEventTypeOffset = (_o.MapEventType == null) ? default(Offset<IPlayMapMusic>) : IPlayMapMusic.Pack(builder, _o.MapEventType);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IPostAkEventMap.CreateIPostAkEventMap(builder, _o.Type, mapEventTypeOffset, akEventOffset);
		}

		// Token: 0x04011737 RID: 71479
		private Table __p;
	}
}
