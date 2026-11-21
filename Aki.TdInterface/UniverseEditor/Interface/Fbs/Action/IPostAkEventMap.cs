using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EF RID: 29935
	public struct IPostAkEventMap : IFlatbufferObject
	{
		// Token: 0x1700DC52 RID: 56402
		// (get) Token: 0x060347D0 RID: 214992 RVA: 0x007110DD File Offset: 0x0070F2DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060347D1 RID: 214993 RVA: 0x007110EA File Offset: 0x0070F2EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060347D2 RID: 214994 RVA: 0x007110F4 File Offset: 0x0070F2F4
		public static IPostAkEventMap GetRootAsIPostAkEventMap(ByteBuffer _bb)
		{
			return IPostAkEventMap.GetRootAsIPostAkEventMap(_bb, default(IPostAkEventMap));
		}

		// Token: 0x060347D3 RID: 214995 RVA: 0x00711110 File Offset: 0x0070F310
		public static IPostAkEventMap GetRootAsIPostAkEventMap(ByteBuffer _bb, IPostAkEventMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060347D4 RID: 214996 RVA: 0x0071112D File Offset: 0x0070F32D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060347D5 RID: 214997 RVA: 0x0071113C File Offset: 0x0070F33C
		public IPostAkEventMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC53 RID: 56403
		// (get) Token: 0x060347D6 RID: 214998 RVA: 0x0071114C File Offset: 0x0070F34C
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

		// Token: 0x1700DC54 RID: 56404
		// (get) Token: 0x060347D7 RID: 214999 RVA: 0x00711188 File Offset: 0x0070F388
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

		// Token: 0x1700DC55 RID: 56405
		// (get) Token: 0x060347D8 RID: 215000 RVA: 0x007111E8 File Offset: 0x0070F3E8
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

		// Token: 0x060347D9 RID: 215001 RVA: 0x0071121F File Offset: 0x0070F41F
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060347DA RID: 215002 RVA: 0x0071122E File Offset: 0x0070F42E
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060347DB RID: 215003 RVA: 0x0071123C File Offset: 0x0070F43C
		public static Offset<IPostAkEventMap> CreateIPostAkEventMap(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, Offset<IPlayMapMusic> MapEventTypeOffset = default(Offset<IPlayMapMusic>), StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPostAkEventMap.AddAkEvent(builder, AkEventOffset);
			IPostAkEventMap.AddMapEventType(builder, MapEventTypeOffset);
			IPostAkEventMap.AddType(builder, Type);
			return IPostAkEventMap.EndIPostAkEventMap(builder);
		}

		// Token: 0x060347DC RID: 215004 RVA: 0x00711260 File Offset: 0x0070F460
		public static void StartIPostAkEventMap(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060347DD RID: 215005 RVA: 0x00711269 File Offset: 0x0070F469
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060347DE RID: 215006 RVA: 0x00711274 File Offset: 0x0070F474
		public static void AddMapEventType(FlatBufferBuilder builder, Offset<IPlayMapMusic> mapEventTypeOffset)
		{
			builder.AddOffset(1, mapEventTypeOffset.Value, 0);
		}

		// Token: 0x060347DF RID: 215007 RVA: 0x00711284 File Offset: 0x0070F484
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(2, akEventOffset.Value, 0);
		}

		// Token: 0x060347E0 RID: 215008 RVA: 0x00711294 File Offset: 0x0070F494
		public static Offset<IPostAkEventMap> EndIPostAkEventMap(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventMap>(builder.EndTable());
		}

		// Token: 0x060347E1 RID: 215009 RVA: 0x007112A4 File Offset: 0x0070F4A4
		public IPostAkEventMapT UnPack()
		{
			IPostAkEventMapT postAkEventMapT = new IPostAkEventMapT();
			this.UnPackTo(postAkEventMapT);
			return postAkEventMapT;
		}

		// Token: 0x060347E2 RID: 215010 RVA: 0x007112C0 File Offset: 0x0070F4C0
		public void UnPackTo(IPostAkEventMapT _o)
		{
			_o.Type = this.Type;
			_o.MapEventType = ((this.MapEventType != null) ? this.MapEventType.Value.UnPack() : null);
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x060347E3 RID: 215011 RVA: 0x00711314 File Offset: 0x0070F514
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

		// Token: 0x040126B3 RID: 75443
		private Table __p;
	}
}
