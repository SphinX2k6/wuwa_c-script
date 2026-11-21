using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EC RID: 29932
	public struct IPostAkEventGlobal : IFlatbufferObject
	{
		// Token: 0x1700DC4D RID: 56397
		// (get) Token: 0x060347B8 RID: 214968 RVA: 0x00710EAA File Offset: 0x0070F0AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060347B9 RID: 214969 RVA: 0x00710EB7 File Offset: 0x0070F0B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060347BA RID: 214970 RVA: 0x00710EC0 File Offset: 0x0070F0C0
		public static IPostAkEventGlobal GetRootAsIPostAkEventGlobal(ByteBuffer _bb)
		{
			return IPostAkEventGlobal.GetRootAsIPostAkEventGlobal(_bb, default(IPostAkEventGlobal));
		}

		// Token: 0x060347BB RID: 214971 RVA: 0x00710EDC File Offset: 0x0070F0DC
		public static IPostAkEventGlobal GetRootAsIPostAkEventGlobal(ByteBuffer _bb, IPostAkEventGlobal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060347BC RID: 214972 RVA: 0x00710EF9 File Offset: 0x0070F0F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060347BD RID: 214973 RVA: 0x00710F08 File Offset: 0x0070F108
		public IPostAkEventGlobal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC4E RID: 56398
		// (get) Token: 0x060347BE RID: 214974 RVA: 0x00710F18 File Offset: 0x0070F118
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

		// Token: 0x1700DC4F RID: 56399
		// (get) Token: 0x060347BF RID: 214975 RVA: 0x00710F54 File Offset: 0x0070F154
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060347C0 RID: 214976 RVA: 0x00710F8B File Offset: 0x0070F18B
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060347C1 RID: 214977 RVA: 0x00710F9A File Offset: 0x0070F19A
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060347C2 RID: 214978 RVA: 0x00710FA8 File Offset: 0x0070F1A8
		public static Offset<IPostAkEventGlobal> CreateIPostAkEventGlobal(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPostAkEventGlobal.AddAkEvent(builder, AkEventOffset);
			IPostAkEventGlobal.AddType(builder, Type);
			return IPostAkEventGlobal.EndIPostAkEventGlobal(builder);
		}

		// Token: 0x060347C3 RID: 214979 RVA: 0x00710FC5 File Offset: 0x0070F1C5
		public static void StartIPostAkEventGlobal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060347C4 RID: 214980 RVA: 0x00710FCE File Offset: 0x0070F1CE
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060347C5 RID: 214981 RVA: 0x00710FD9 File Offset: 0x0070F1D9
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(1, akEventOffset.Value, 0);
		}

		// Token: 0x060347C6 RID: 214982 RVA: 0x00710FE9 File Offset: 0x0070F1E9
		public static Offset<IPostAkEventGlobal> EndIPostAkEventGlobal(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventGlobal>(builder.EndTable());
		}

		// Token: 0x060347C7 RID: 214983 RVA: 0x00710FF8 File Offset: 0x0070F1F8
		public IPostAkEventGlobalT UnPack()
		{
			IPostAkEventGlobalT postAkEventGlobalT = new IPostAkEventGlobalT();
			this.UnPackTo(postAkEventGlobalT);
			return postAkEventGlobalT;
		}

		// Token: 0x060347C8 RID: 214984 RVA: 0x00711013 File Offset: 0x0070F213
		public void UnPackTo(IPostAkEventGlobalT _o)
		{
			_o.Type = this.Type;
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x060347C9 RID: 214985 RVA: 0x00711030 File Offset: 0x0070F230
		public static Offset<IPostAkEventGlobal> Pack(FlatBufferBuilder builder, IPostAkEventGlobalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventGlobal>);
			}
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IPostAkEventGlobal.CreateIPostAkEventGlobal(builder, _o.Type, akEventOffset);
		}

		// Token: 0x040126B0 RID: 75440
		private Table __p;
	}
}
