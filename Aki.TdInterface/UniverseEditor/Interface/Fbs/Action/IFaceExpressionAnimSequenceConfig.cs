using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC4 RID: 28100
	public struct IFaceExpressionAnimSequenceConfig : IFlatbufferObject
	{
		// Token: 0x1700CDF9 RID: 52729
		// (get) Token: 0x060307F3 RID: 198643 RVA: 0x00696356 File Offset: 0x00694556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307F4 RID: 198644 RVA: 0x00696363 File Offset: 0x00694563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307F5 RID: 198645 RVA: 0x0069636C File Offset: 0x0069456C
		public static IFaceExpressionAnimSequenceConfig GetRootAsIFaceExpressionAnimSequenceConfig(ByteBuffer _bb)
		{
			return IFaceExpressionAnimSequenceConfig.GetRootAsIFaceExpressionAnimSequenceConfig(_bb, default(IFaceExpressionAnimSequenceConfig));
		}

		// Token: 0x060307F6 RID: 198646 RVA: 0x00696388 File Offset: 0x00694588
		public static IFaceExpressionAnimSequenceConfig GetRootAsIFaceExpressionAnimSequenceConfig(ByteBuffer _bb, IFaceExpressionAnimSequenceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307F7 RID: 198647 RVA: 0x006963A5 File Offset: 0x006945A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307F8 RID: 198648 RVA: 0x006963B4 File Offset: 0x006945B4
		public IFaceExpressionAnimSequenceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDFA RID: 52730
		// (get) Token: 0x060307F9 RID: 198649 RVA: 0x006963C4 File Offset: 0x006945C4
		public EFaceExpressionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return (EFaceExpressionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDFB RID: 52731
		// (get) Token: 0x060307FA RID: 198650 RVA: 0x00696400 File Offset: 0x00694600
		public string Path
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

		// Token: 0x060307FB RID: 198651 RVA: 0x00696437 File Offset: 0x00694637
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060307FC RID: 198652 RVA: 0x00696446 File Offset: 0x00694646
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060307FD RID: 198653 RVA: 0x00696454 File Offset: 0x00694654
		public static Offset<IFaceExpressionAnimSequenceConfig> CreateIFaceExpressionAnimSequenceConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFaceExpressionAnimSequenceConfig.AddPath(builder, PathOffset);
			IFaceExpressionAnimSequenceConfig.AddType(builder, Type);
			return IFaceExpressionAnimSequenceConfig.EndIFaceExpressionAnimSequenceConfig(builder);
		}

		// Token: 0x060307FE RID: 198654 RVA: 0x00696471 File Offset: 0x00694671
		public static void StartIFaceExpressionAnimSequenceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060307FF RID: 198655 RVA: 0x0069647A File Offset: 0x0069467A
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030800 RID: 198656 RVA: 0x00696485 File Offset: 0x00694685
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06030801 RID: 198657 RVA: 0x00696495 File Offset: 0x00694695
		public static Offset<IFaceExpressionAnimSequenceConfig> EndIFaceExpressionAnimSequenceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionAnimSequenceConfig>(builder.EndTable());
		}

		// Token: 0x06030802 RID: 198658 RVA: 0x006964A4 File Offset: 0x006946A4
		public IFaceExpressionAnimSequenceConfigT UnPack()
		{
			IFaceExpressionAnimSequenceConfigT faceExpressionAnimSequenceConfigT = new IFaceExpressionAnimSequenceConfigT();
			this.UnPackTo(faceExpressionAnimSequenceConfigT);
			return faceExpressionAnimSequenceConfigT;
		}

		// Token: 0x06030803 RID: 198659 RVA: 0x006964BF File Offset: 0x006946BF
		public void UnPackTo(IFaceExpressionAnimSequenceConfigT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06030804 RID: 198660 RVA: 0x006964DC File Offset: 0x006946DC
		public static Offset<IFaceExpressionAnimSequenceConfig> Pack(FlatBufferBuilder builder, IFaceExpressionAnimSequenceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionAnimSequenceConfig>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IFaceExpressionAnimSequenceConfig.CreateIFaceExpressionAnimSequenceConfig(builder, _o.Type, pathOffset);
		}

		// Token: 0x04011C60 RID: 72800
		private Table __p;
	}
}
