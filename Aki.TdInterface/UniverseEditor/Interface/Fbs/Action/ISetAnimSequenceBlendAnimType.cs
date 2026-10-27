using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9C RID: 28572
	public struct ISetAnimSequenceBlendAnimType : IFlatbufferObject
	{
		// Token: 0x1700D430 RID: 54320
		// (get) Token: 0x060327E3 RID: 206819 RVA: 0x006D0BB8 File Offset: 0x006CEDB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060327E4 RID: 206820 RVA: 0x006D0BC5 File Offset: 0x006CEDC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060327E5 RID: 206821 RVA: 0x006D0BCC File Offset: 0x006CEDCC
		public static ISetAnimSequenceBlendAnimType GetRootAsISetAnimSequenceBlendAnimType(ByteBuffer _bb)
		{
			return ISetAnimSequenceBlendAnimType.GetRootAsISetAnimSequenceBlendAnimType(_bb, default(ISetAnimSequenceBlendAnimType));
		}

		// Token: 0x060327E6 RID: 206822 RVA: 0x006D0BE8 File Offset: 0x006CEDE8
		public static ISetAnimSequenceBlendAnimType GetRootAsISetAnimSequenceBlendAnimType(ByteBuffer _bb, ISetAnimSequenceBlendAnimType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060327E7 RID: 206823 RVA: 0x006D0C05 File Offset: 0x006CEE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060327E8 RID: 206824 RVA: 0x006D0C14 File Offset: 0x006CEE14
		public ISetAnimSequenceBlendAnimType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D431 RID: 54321
		// (get) Token: 0x060327E9 RID: 206825 RVA: 0x006D0C24 File Offset: 0x006CEE24
		public EBlendAnimType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimType.StateMachine;
				}
				return (EBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D432 RID: 54322
		// (get) Token: 0x060327EA RID: 206826 RVA: 0x006D0C60 File Offset: 0x006CEE60
		public string AnimSequence
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

		// Token: 0x060327EB RID: 206827 RVA: 0x006D0C97 File Offset: 0x006CEE97
		public Span<byte> GetAnimSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060327EC RID: 206828 RVA: 0x006D0CA6 File Offset: 0x006CEEA6
		public byte[] GetAnimSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D433 RID: 54323
		// (get) Token: 0x060327ED RID: 206829 RVA: 0x006D0CB4 File Offset: 0x006CEEB4
		public float ProtectTime
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

		// Token: 0x1700D434 RID: 54324
		// (get) Token: 0x060327EE RID: 206830 RVA: 0x006D0CF4 File Offset: 0x006CEEF4
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

		// Token: 0x060327EF RID: 206831 RVA: 0x006D0D31 File Offset: 0x006CEF31
		public static Offset<ISetAnimSequenceBlendAnimType> CreateISetAnimSequenceBlendAnimType(FlatBufferBuilder builder, EBlendAnimType Type = EBlendAnimType.StateMachine, StringOffset AnimSequenceOffset = default(StringOffset), float ProtectTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetAnimSequenceBlendAnimType.AddProtectTime(builder, ProtectTime);
			ISetAnimSequenceBlendAnimType.AddAnimSequence(builder, AnimSequenceOffset);
			ISetAnimSequenceBlendAnimType.AddNullMask(builder, NullMask);
			ISetAnimSequenceBlendAnimType.AddType(builder, Type);
			return ISetAnimSequenceBlendAnimType.EndISetAnimSequenceBlendAnimType(builder);
		}

		// Token: 0x060327F0 RID: 206832 RVA: 0x006D0D5D File Offset: 0x006CEF5D
		public static void StartISetAnimSequenceBlendAnimType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060327F1 RID: 206833 RVA: 0x006D0D66 File Offset: 0x006CEF66
		public static void AddType(FlatBufferBuilder builder, EBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060327F2 RID: 206834 RVA: 0x006D0D71 File Offset: 0x006CEF71
		public static void AddAnimSequence(FlatBufferBuilder builder, StringOffset animSequenceOffset)
		{
			builder.AddOffset(1, animSequenceOffset.Value, 0);
		}

		// Token: 0x060327F3 RID: 206835 RVA: 0x006D0D81 File Offset: 0x006CEF81
		public static void AddProtectTime(FlatBufferBuilder builder, float protectTime)
		{
			builder.AddFloat(2, protectTime, 0.0);
		}

		// Token: 0x060327F4 RID: 206836 RVA: 0x006D0D94 File Offset: 0x006CEF94
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060327F5 RID: 206837 RVA: 0x006D0D9F File Offset: 0x006CEF9F
		public static Offset<ISetAnimSequenceBlendAnimType> EndISetAnimSequenceBlendAnimType(FlatBufferBuilder builder)
		{
			return new Offset<ISetAnimSequenceBlendAnimType>(builder.EndTable());
		}

		// Token: 0x060327F6 RID: 206838 RVA: 0x006D0DAC File Offset: 0x006CEFAC
		public ISetAnimSequenceBlendAnimTypeT UnPack()
		{
			ISetAnimSequenceBlendAnimTypeT setAnimSequenceBlendAnimTypeT = new ISetAnimSequenceBlendAnimTypeT();
			this.UnPackTo(setAnimSequenceBlendAnimTypeT);
			return setAnimSequenceBlendAnimTypeT;
		}

		// Token: 0x060327F7 RID: 206839 RVA: 0x006D0DC7 File Offset: 0x006CEFC7
		public void UnPackTo(ISetAnimSequenceBlendAnimTypeT _o)
		{
			_o.Type = this.Type;
			_o.AnimSequence = this.AnimSequence;
			_o.ProtectTime = this.ProtectTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060327F8 RID: 206840 RVA: 0x006D0DFC File Offset: 0x006CEFFC
		public static Offset<ISetAnimSequenceBlendAnimType> Pack(FlatBufferBuilder builder, ISetAnimSequenceBlendAnimTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAnimSequenceBlendAnimType>);
			}
			StringOffset animSequenceOffset = (_o.AnimSequence == null) ? default(StringOffset) : builder.CreateString(_o.AnimSequence);
			return ISetAnimSequenceBlendAnimType.CreateISetAnimSequenceBlendAnimType(builder, _o.Type, animSequenceOffset, _o.ProtectTime, _o.NullMask);
		}

		// Token: 0x0401199E RID: 72094
		private Table __p;
	}
}
