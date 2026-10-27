using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006744 RID: 26436
	public struct IFaceExpressionAnimSequenceConfig : IFlatbufferObject
	{
		// Token: 0x1700C443 RID: 50243
		// (get) Token: 0x0602DFAD RID: 188333 RVA: 0x00648C12 File Offset: 0x00646E12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DFAE RID: 188334 RVA: 0x00648C1F File Offset: 0x00646E1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DFAF RID: 188335 RVA: 0x00648C28 File Offset: 0x00646E28
		public static IFaceExpressionAnimSequenceConfig GetRootAsIFaceExpressionAnimSequenceConfig(ByteBuffer _bb)
		{
			return IFaceExpressionAnimSequenceConfig.GetRootAsIFaceExpressionAnimSequenceConfig(_bb, default(IFaceExpressionAnimSequenceConfig));
		}

		// Token: 0x0602DFB0 RID: 188336 RVA: 0x00648C44 File Offset: 0x00646E44
		public static IFaceExpressionAnimSequenceConfig GetRootAsIFaceExpressionAnimSequenceConfig(ByteBuffer _bb, IFaceExpressionAnimSequenceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DFB1 RID: 188337 RVA: 0x00648C61 File Offset: 0x00646E61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DFB2 RID: 188338 RVA: 0x00648C70 File Offset: 0x00646E70
		public IFaceExpressionAnimSequenceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C444 RID: 50244
		// (get) Token: 0x0602DFB3 RID: 188339 RVA: 0x00648C80 File Offset: 0x00646E80
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

		// Token: 0x1700C445 RID: 50245
		// (get) Token: 0x0602DFB4 RID: 188340 RVA: 0x00648CBC File Offset: 0x00646EBC
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

		// Token: 0x0602DFB5 RID: 188341 RVA: 0x00648CF3 File Offset: 0x00646EF3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DFB6 RID: 188342 RVA: 0x00648D02 File Offset: 0x00646F02
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602DFB7 RID: 188343 RVA: 0x00648D10 File Offset: 0x00646F10
		public static Offset<IFaceExpressionAnimSequenceConfig> CreateIFaceExpressionAnimSequenceConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFaceExpressionAnimSequenceConfig.AddPath(builder, PathOffset);
			IFaceExpressionAnimSequenceConfig.AddType(builder, Type);
			return IFaceExpressionAnimSequenceConfig.EndIFaceExpressionAnimSequenceConfig(builder);
		}

		// Token: 0x0602DFB8 RID: 188344 RVA: 0x00648D2D File Offset: 0x00646F2D
		public static void StartIFaceExpressionAnimSequenceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DFB9 RID: 188345 RVA: 0x00648D36 File Offset: 0x00646F36
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DFBA RID: 188346 RVA: 0x00648D41 File Offset: 0x00646F41
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0602DFBB RID: 188347 RVA: 0x00648D51 File Offset: 0x00646F51
		public static Offset<IFaceExpressionAnimSequenceConfig> EndIFaceExpressionAnimSequenceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionAnimSequenceConfig>(builder.EndTable());
		}

		// Token: 0x0602DFBC RID: 188348 RVA: 0x00648D60 File Offset: 0x00646F60
		public IFaceExpressionAnimSequenceConfigT UnPack()
		{
			IFaceExpressionAnimSequenceConfigT faceExpressionAnimSequenceConfigT = new IFaceExpressionAnimSequenceConfigT();
			this.UnPackTo(faceExpressionAnimSequenceConfigT);
			return faceExpressionAnimSequenceConfigT;
		}

		// Token: 0x0602DFBD RID: 188349 RVA: 0x00648D7B File Offset: 0x00646F7B
		public void UnPackTo(IFaceExpressionAnimSequenceConfigT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x0602DFBE RID: 188350 RVA: 0x00648D98 File Offset: 0x00646F98
		public static Offset<IFaceExpressionAnimSequenceConfig> Pack(FlatBufferBuilder builder, IFaceExpressionAnimSequenceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionAnimSequenceConfig>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IFaceExpressionAnimSequenceConfig.CreateIFaceExpressionAnimSequenceConfig(builder, _o.Type, pathOffset);
		}

		// Token: 0x04010E2E RID: 69166
		private Table __p;
	}
}
