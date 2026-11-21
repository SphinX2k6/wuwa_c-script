using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005856 RID: 22614
	public struct IFrequencyPaintStraightLine : IFlatbufferObject
	{
		// Token: 0x1700A3C8 RID: 41928
		// (get) Token: 0x06024A35 RID: 150069 RVA: 0x00508988 File Offset: 0x00506B88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A36 RID: 150070 RVA: 0x00508995 File Offset: 0x00506B95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A37 RID: 150071 RVA: 0x0050899C File Offset: 0x00506B9C
		public static IFrequencyPaintStraightLine GetRootAsIFrequencyPaintStraightLine(ByteBuffer _bb)
		{
			return IFrequencyPaintStraightLine.GetRootAsIFrequencyPaintStraightLine(_bb, default(IFrequencyPaintStraightLine));
		}

		// Token: 0x06024A38 RID: 150072 RVA: 0x005089B8 File Offset: 0x00506BB8
		public static IFrequencyPaintStraightLine GetRootAsIFrequencyPaintStraightLine(ByteBuffer _bb, IFrequencyPaintStraightLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A39 RID: 150073 RVA: 0x005089D5 File Offset: 0x00506BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A3A RID: 150074 RVA: 0x005089E4 File Offset: 0x00506BE4
		public IFrequencyPaintStraightLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3C9 RID: 41929
		// (get) Token: 0x06024A3B RID: 150075 RVA: 0x005089F4 File Offset: 0x00506BF4
		public EFrequencyPaintLineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFrequencyPaintLineType.Straight;
				}
				return (EFrequencyPaintLineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024A3C RID: 150076 RVA: 0x00508A30 File Offset: 0x00506C30
		public static Offset<IFrequencyPaintStraightLine> CreateIFrequencyPaintStraightLine(FlatBufferBuilder builder, EFrequencyPaintLineType Type = EFrequencyPaintLineType.Straight)
		{
			builder.StartTable(1);
			IFrequencyPaintStraightLine.AddType(builder, Type);
			return IFrequencyPaintStraightLine.EndIFrequencyPaintStraightLine(builder);
		}

		// Token: 0x06024A3D RID: 150077 RVA: 0x00508A46 File Offset: 0x00506C46
		public static void StartIFrequencyPaintStraightLine(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024A3E RID: 150078 RVA: 0x00508A4F File Offset: 0x00506C4F
		public static void AddType(FlatBufferBuilder builder, EFrequencyPaintLineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024A3F RID: 150079 RVA: 0x00508A5A File Offset: 0x00506C5A
		public static Offset<IFrequencyPaintStraightLine> EndIFrequencyPaintStraightLine(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintStraightLine>(builder.EndTable());
		}

		// Token: 0x06024A40 RID: 150080 RVA: 0x00508A68 File Offset: 0x00506C68
		public IFrequencyPaintStraightLineT UnPack()
		{
			IFrequencyPaintStraightLineT frequencyPaintStraightLineT = new IFrequencyPaintStraightLineT();
			this.UnPackTo(frequencyPaintStraightLineT);
			return frequencyPaintStraightLineT;
		}

		// Token: 0x06024A41 RID: 150081 RVA: 0x00508A83 File Offset: 0x00506C83
		public void UnPackTo(IFrequencyPaintStraightLineT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024A42 RID: 150082 RVA: 0x00508A94 File Offset: 0x00506C94
		public static Offset<IFrequencyPaintStraightLine> Pack(FlatBufferBuilder builder, IFrequencyPaintStraightLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintStraightLine>);
			}
			return IFrequencyPaintStraightLine.CreateIFrequencyPaintStraightLine(builder, _o.Type);
		}

		// Token: 0x0400F097 RID: 61591
		private Table __p;
	}
}
