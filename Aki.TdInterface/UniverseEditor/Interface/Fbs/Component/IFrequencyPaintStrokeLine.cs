using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005859 RID: 22617
	public struct IFrequencyPaintStrokeLine : IFlatbufferObject
	{
		// Token: 0x1700A3CB RID: 41931
		// (get) Token: 0x06024A47 RID: 150087 RVA: 0x00508AFD File Offset: 0x00506CFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A48 RID: 150088 RVA: 0x00508B0A File Offset: 0x00506D0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A49 RID: 150089 RVA: 0x00508B14 File Offset: 0x00506D14
		public static IFrequencyPaintStrokeLine GetRootAsIFrequencyPaintStrokeLine(ByteBuffer _bb)
		{
			return IFrequencyPaintStrokeLine.GetRootAsIFrequencyPaintStrokeLine(_bb, default(IFrequencyPaintStrokeLine));
		}

		// Token: 0x06024A4A RID: 150090 RVA: 0x00508B30 File Offset: 0x00506D30
		public static IFrequencyPaintStrokeLine GetRootAsIFrequencyPaintStrokeLine(ByteBuffer _bb, IFrequencyPaintStrokeLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A4B RID: 150091 RVA: 0x00508B4D File Offset: 0x00506D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A4C RID: 150092 RVA: 0x00508B5C File Offset: 0x00506D5C
		public IFrequencyPaintStrokeLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3CC RID: 41932
		// (get) Token: 0x06024A4D RID: 150093 RVA: 0x00508B6C File Offset: 0x00506D6C
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

		// Token: 0x06024A4E RID: 150094 RVA: 0x00508BA8 File Offset: 0x00506DA8
		public static Offset<IFrequencyPaintStrokeLine> CreateIFrequencyPaintStrokeLine(FlatBufferBuilder builder, EFrequencyPaintLineType Type = EFrequencyPaintLineType.Straight)
		{
			builder.StartTable(1);
			IFrequencyPaintStrokeLine.AddType(builder, Type);
			return IFrequencyPaintStrokeLine.EndIFrequencyPaintStrokeLine(builder);
		}

		// Token: 0x06024A4F RID: 150095 RVA: 0x00508BBE File Offset: 0x00506DBE
		public static void StartIFrequencyPaintStrokeLine(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024A50 RID: 150096 RVA: 0x00508BC7 File Offset: 0x00506DC7
		public static void AddType(FlatBufferBuilder builder, EFrequencyPaintLineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024A51 RID: 150097 RVA: 0x00508BD2 File Offset: 0x00506DD2
		public static Offset<IFrequencyPaintStrokeLine> EndIFrequencyPaintStrokeLine(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintStrokeLine>(builder.EndTable());
		}

		// Token: 0x06024A52 RID: 150098 RVA: 0x00508BE0 File Offset: 0x00506DE0
		public IFrequencyPaintStrokeLineT UnPack()
		{
			IFrequencyPaintStrokeLineT frequencyPaintStrokeLineT = new IFrequencyPaintStrokeLineT();
			this.UnPackTo(frequencyPaintStrokeLineT);
			return frequencyPaintStrokeLineT;
		}

		// Token: 0x06024A53 RID: 150099 RVA: 0x00508BFB File Offset: 0x00506DFB
		public void UnPackTo(IFrequencyPaintStrokeLineT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024A54 RID: 150100 RVA: 0x00508C0C File Offset: 0x00506E0C
		public static Offset<IFrequencyPaintStrokeLine> Pack(FlatBufferBuilder builder, IFrequencyPaintStrokeLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintStrokeLine>);
			}
			return IFrequencyPaintStrokeLine.CreateIFrequencyPaintStrokeLine(builder, _o.Type);
		}

		// Token: 0x0400F099 RID: 61593
		private Table __p;
	}
}
