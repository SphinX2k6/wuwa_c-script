using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005850 RID: 22608
	public struct IFrequencyPaintLineBase : IFlatbufferObject
	{
		// Token: 0x1700A3C3 RID: 41923
		// (get) Token: 0x06024A11 RID: 150033 RVA: 0x00508645 File Offset: 0x00506845
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A12 RID: 150034 RVA: 0x00508652 File Offset: 0x00506852
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A13 RID: 150035 RVA: 0x0050865C File Offset: 0x0050685C
		public static IFrequencyPaintLineBase GetRootAsIFrequencyPaintLineBase(ByteBuffer _bb)
		{
			return IFrequencyPaintLineBase.GetRootAsIFrequencyPaintLineBase(_bb, default(IFrequencyPaintLineBase));
		}

		// Token: 0x06024A14 RID: 150036 RVA: 0x00508678 File Offset: 0x00506878
		public static IFrequencyPaintLineBase GetRootAsIFrequencyPaintLineBase(ByteBuffer _bb, IFrequencyPaintLineBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A15 RID: 150037 RVA: 0x00508695 File Offset: 0x00506895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A16 RID: 150038 RVA: 0x005086A4 File Offset: 0x005068A4
		public IFrequencyPaintLineBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3C4 RID: 41924
		// (get) Token: 0x06024A17 RID: 150039 RVA: 0x005086B4 File Offset: 0x005068B4
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

		// Token: 0x06024A18 RID: 150040 RVA: 0x005086F0 File Offset: 0x005068F0
		public static Offset<IFrequencyPaintLineBase> CreateIFrequencyPaintLineBase(FlatBufferBuilder builder, EFrequencyPaintLineType Type = EFrequencyPaintLineType.Straight)
		{
			builder.StartTable(1);
			IFrequencyPaintLineBase.AddType(builder, Type);
			return IFrequencyPaintLineBase.EndIFrequencyPaintLineBase(builder);
		}

		// Token: 0x06024A19 RID: 150041 RVA: 0x00508706 File Offset: 0x00506906
		public static void StartIFrequencyPaintLineBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024A1A RID: 150042 RVA: 0x0050870F File Offset: 0x0050690F
		public static void AddType(FlatBufferBuilder builder, EFrequencyPaintLineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024A1B RID: 150043 RVA: 0x0050871A File Offset: 0x0050691A
		public static Offset<IFrequencyPaintLineBase> EndIFrequencyPaintLineBase(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintLineBase>(builder.EndTable());
		}

		// Token: 0x06024A1C RID: 150044 RVA: 0x00508728 File Offset: 0x00506928
		public IFrequencyPaintLineBaseT UnPack()
		{
			IFrequencyPaintLineBaseT frequencyPaintLineBaseT = new IFrequencyPaintLineBaseT();
			this.UnPackTo(frequencyPaintLineBaseT);
			return frequencyPaintLineBaseT;
		}

		// Token: 0x06024A1D RID: 150045 RVA: 0x00508743 File Offset: 0x00506943
		public void UnPackTo(IFrequencyPaintLineBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024A1E RID: 150046 RVA: 0x00508754 File Offset: 0x00506954
		public static Offset<IFrequencyPaintLineBase> Pack(FlatBufferBuilder builder, IFrequencyPaintLineBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintLineBase>);
			}
			return IFrequencyPaintLineBase.CreateIFrequencyPaintLineBase(builder, _o.Type);
		}

		// Token: 0x0400F08C RID: 61580
		private Table __p;
	}
}
