using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200662D RID: 26157
	public struct IEffectPlayerPos2 : IFlatbufferObject
	{
		// Token: 0x1700C255 RID: 49749
		// (get) Token: 0x0602D6C3 RID: 186051 RVA: 0x00639063 File Offset: 0x00637263
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D6C4 RID: 186052 RVA: 0x00639070 File Offset: 0x00637270
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D6C5 RID: 186053 RVA: 0x00639078 File Offset: 0x00637278
		public static IEffectPlayerPos2 GetRootAsIEffectPlayerPos2(ByteBuffer _bb)
		{
			return IEffectPlayerPos2.GetRootAsIEffectPlayerPos2(_bb, default(IEffectPlayerPos2));
		}

		// Token: 0x0602D6C6 RID: 186054 RVA: 0x00639094 File Offset: 0x00637294
		public static IEffectPlayerPos2 GetRootAsIEffectPlayerPos2(ByteBuffer _bb, IEffectPlayerPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D6C7 RID: 186055 RVA: 0x006390B1 File Offset: 0x006372B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D6C8 RID: 186056 RVA: 0x006390C0 File Offset: 0x006372C0
		public IEffectPlayerPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C256 RID: 49750
		// (get) Token: 0x0602D6C9 RID: 186057 RVA: 0x006390D0 File Offset: 0x006372D0
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C257 RID: 49751
		// (get) Token: 0x0602D6CA RID: 186058 RVA: 0x0063910C File Offset: 0x0063730C
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C258 RID: 49752
		// (get) Token: 0x0602D6CB RID: 186059 RVA: 0x0063916C File Offset: 0x0063736C
		public string AttachSocket
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

		// Token: 0x0602D6CC RID: 186060 RVA: 0x006391A3 File Offset: 0x006373A3
		public Span<byte> GetAttachSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602D6CD RID: 186061 RVA: 0x006391B2 File Offset: 0x006373B2
		public byte[] GetAttachSocketArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602D6CE RID: 186062 RVA: 0x006391C0 File Offset: 0x006373C0
		public static Offset<IEffectPlayerPos2> CreateIEffectPlayerPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), StringOffset AttachSocketOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IEffectPlayerPos2.AddAttachSocket(builder, AttachSocketOffset);
			IEffectPlayerPos2.AddOffset(builder, OffsetOffset);
			IEffectPlayerPos2.AddType(builder, Type);
			return IEffectPlayerPos2.EndIEffectPlayerPos2(builder);
		}

		// Token: 0x0602D6CF RID: 186063 RVA: 0x006391E4 File Offset: 0x006373E4
		public static void StartIEffectPlayerPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D6D0 RID: 186064 RVA: 0x006391ED File Offset: 0x006373ED
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6D1 RID: 186065 RVA: 0x006391F8 File Offset: 0x006373F8
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602D6D2 RID: 186066 RVA: 0x00639208 File Offset: 0x00637408
		public static void AddAttachSocket(FlatBufferBuilder builder, StringOffset attachSocketOffset)
		{
			builder.AddOffset(2, attachSocketOffset.Value, 0);
		}

		// Token: 0x0602D6D3 RID: 186067 RVA: 0x00639218 File Offset: 0x00637418
		public static Offset<IEffectPlayerPos2> EndIEffectPlayerPos2(FlatBufferBuilder builder)
		{
			return new Offset<IEffectPlayerPos2>(builder.EndTable());
		}

		// Token: 0x0602D6D4 RID: 186068 RVA: 0x00639228 File Offset: 0x00637428
		public IEffectPlayerPos2T UnPack()
		{
			IEffectPlayerPos2T effectPlayerPos2T = new IEffectPlayerPos2T();
			this.UnPackTo(effectPlayerPos2T);
			return effectPlayerPos2T;
		}

		// Token: 0x0602D6D5 RID: 186069 RVA: 0x00639244 File Offset: 0x00637444
		public void UnPackTo(IEffectPlayerPos2T _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.AttachSocket = this.AttachSocket;
		}

		// Token: 0x0602D6D6 RID: 186070 RVA: 0x00639298 File Offset: 0x00637498
		public static Offset<IEffectPlayerPos2> Pack(FlatBufferBuilder builder, IEffectPlayerPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectPlayerPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			StringOffset attachSocketOffset = (_o.AttachSocket == null) ? default(StringOffset) : builder.CreateString(_o.AttachSocket);
			return IEffectPlayerPos2.CreateIEffectPlayerPos2(builder, _o.Type, offsetOffset, attachSocketOffset);
		}

		// Token: 0x04010CBF RID: 68799
		private Table __p;
	}
}
