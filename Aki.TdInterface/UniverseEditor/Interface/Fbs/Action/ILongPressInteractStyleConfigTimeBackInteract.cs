using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A47 RID: 27207
	public struct ILongPressInteractStyleConfigTimeBackInteract : IFlatbufferObject
	{
		// Token: 0x1700C9DB RID: 51675
		// (get) Token: 0x0602FA2C RID: 195116 RVA: 0x0067BF25 File Offset: 0x0067A125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA2D RID: 195117 RVA: 0x0067BF32 File Offset: 0x0067A132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA2E RID: 195118 RVA: 0x0067BF3C File Offset: 0x0067A13C
		public static ILongPressInteractStyleConfigTimeBackInteract GetRootAsILongPressInteractStyleConfigTimeBackInteract(ByteBuffer _bb)
		{
			return ILongPressInteractStyleConfigTimeBackInteract.GetRootAsILongPressInteractStyleConfigTimeBackInteract(_bb, default(ILongPressInteractStyleConfigTimeBackInteract));
		}

		// Token: 0x0602FA2F RID: 195119 RVA: 0x0067BF58 File Offset: 0x0067A158
		public static ILongPressInteractStyleConfigTimeBackInteract GetRootAsILongPressInteractStyleConfigTimeBackInteract(ByteBuffer _bb, ILongPressInteractStyleConfigTimeBackInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA30 RID: 195120 RVA: 0x0067BF75 File Offset: 0x0067A175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA31 RID: 195121 RVA: 0x0067BF84 File Offset: 0x0067A184
		public ILongPressInteractStyleConfigTimeBackInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9DC RID: 51676
		// (get) Token: 0x0602FA32 RID: 195122 RVA: 0x0067BF94 File Offset: 0x0067A194
		public ELongPressInteractStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELongPressInteractStyle.Default;
				}
				return (ELongPressInteractStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C9DD RID: 51677
		// (get) Token: 0x0602FA33 RID: 195123 RVA: 0x0067BFD0 File Offset: 0x0067A1D0
		public string TidContent
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

		// Token: 0x0602FA34 RID: 195124 RVA: 0x0067C007 File Offset: 0x0067A207
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602FA35 RID: 195125 RVA: 0x0067C016 File Offset: 0x0067A216
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C9DE RID: 51678
		// (get) Token: 0x0602FA36 RID: 195126 RVA: 0x0067C024 File Offset: 0x0067A224
		public float StartProgress
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C9DF RID: 51679
		// (get) Token: 0x0602FA37 RID: 195127 RVA: 0x0067C064 File Offset: 0x0067A264
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA38 RID: 195128 RVA: 0x0067C0A1 File Offset: 0x0067A2A1
		public static Offset<ILongPressInteractStyleConfigTimeBackInteract> CreateILongPressInteractStyleConfigTimeBackInteract(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default, StringOffset TidContentOffset = default(StringOffset), float StartProgress = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILongPressInteractStyleConfigTimeBackInteract.AddStartProgress(builder, StartProgress);
			ILongPressInteractStyleConfigTimeBackInteract.AddTidContent(builder, TidContentOffset);
			ILongPressInteractStyleConfigTimeBackInteract.AddNullMask(builder, NullMask);
			ILongPressInteractStyleConfigTimeBackInteract.AddType(builder, Type);
			return ILongPressInteractStyleConfigTimeBackInteract.EndILongPressInteractStyleConfigTimeBackInteract(builder);
		}

		// Token: 0x0602FA39 RID: 195129 RVA: 0x0067C0CD File Offset: 0x0067A2CD
		public static void StartILongPressInteractStyleConfigTimeBackInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FA3A RID: 195130 RVA: 0x0067C0D6 File Offset: 0x0067A2D6
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA3B RID: 195131 RVA: 0x0067C0E1 File Offset: 0x0067A2E1
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(1, tidContentOffset.Value, 0);
		}

		// Token: 0x0602FA3C RID: 195132 RVA: 0x0067C0F1 File Offset: 0x0067A2F1
		public static void AddStartProgress(FlatBufferBuilder builder, float startProgress)
		{
			builder.AddFloat(2, startProgress, 0.0);
		}

		// Token: 0x0602FA3D RID: 195133 RVA: 0x0067C104 File Offset: 0x0067A304
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FA3E RID: 195134 RVA: 0x0067C10F File Offset: 0x0067A30F
		public static Offset<ILongPressInteractStyleConfigTimeBackInteract> EndILongPressInteractStyleConfigTimeBackInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleConfigTimeBackInteract>(builder.EndTable());
		}

		// Token: 0x0602FA3F RID: 195135 RVA: 0x0067C11C File Offset: 0x0067A31C
		public ILongPressInteractStyleConfigTimeBackInteractT UnPack()
		{
			ILongPressInteractStyleConfigTimeBackInteractT longPressInteractStyleConfigTimeBackInteractT = new ILongPressInteractStyleConfigTimeBackInteractT();
			this.UnPackTo(longPressInteractStyleConfigTimeBackInteractT);
			return longPressInteractStyleConfigTimeBackInteractT;
		}

		// Token: 0x0602FA40 RID: 195136 RVA: 0x0067C137 File Offset: 0x0067A337
		public void UnPackTo(ILongPressInteractStyleConfigTimeBackInteractT _o)
		{
			_o.Type = this.Type;
			_o.TidContent = this.TidContent;
			_o.StartProgress = this.StartProgress;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FA41 RID: 195137 RVA: 0x0067C16C File Offset: 0x0067A36C
		public static Offset<ILongPressInteractStyleConfigTimeBackInteract> Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfigTimeBackInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleConfigTimeBackInteract>);
			}
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			return ILongPressInteractStyleConfigTimeBackInteract.CreateILongPressInteractStyleConfigTimeBackInteract(builder, _o.Type, tidContentOffset, _o.StartProgress, _o.NullMask);
		}

		// Token: 0x04011260 RID: 70240
		private Table __p;
	}
}
