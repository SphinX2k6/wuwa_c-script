using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584D RID: 22605
	public struct IFrequencyPaintEncloseLine : IFlatbufferObject
	{
		// Token: 0x1700A3C0 RID: 41920
		// (get) Token: 0x060249FF RID: 150015 RVA: 0x005084CE File Offset: 0x005066CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A00 RID: 150016 RVA: 0x005084DB File Offset: 0x005066DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A01 RID: 150017 RVA: 0x005084E4 File Offset: 0x005066E4
		public static IFrequencyPaintEncloseLine GetRootAsIFrequencyPaintEncloseLine(ByteBuffer _bb)
		{
			return IFrequencyPaintEncloseLine.GetRootAsIFrequencyPaintEncloseLine(_bb, default(IFrequencyPaintEncloseLine));
		}

		// Token: 0x06024A02 RID: 150018 RVA: 0x00508500 File Offset: 0x00506700
		public static IFrequencyPaintEncloseLine GetRootAsIFrequencyPaintEncloseLine(ByteBuffer _bb, IFrequencyPaintEncloseLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A03 RID: 150019 RVA: 0x0050851D File Offset: 0x0050671D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A04 RID: 150020 RVA: 0x0050852C File Offset: 0x0050672C
		public IFrequencyPaintEncloseLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3C1 RID: 41921
		// (get) Token: 0x06024A05 RID: 150021 RVA: 0x0050853C File Offset: 0x0050673C
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

		// Token: 0x06024A06 RID: 150022 RVA: 0x00508578 File Offset: 0x00506778
		public static Offset<IFrequencyPaintEncloseLine> CreateIFrequencyPaintEncloseLine(FlatBufferBuilder builder, EFrequencyPaintLineType Type = EFrequencyPaintLineType.Straight)
		{
			builder.StartTable(1);
			IFrequencyPaintEncloseLine.AddType(builder, Type);
			return IFrequencyPaintEncloseLine.EndIFrequencyPaintEncloseLine(builder);
		}

		// Token: 0x06024A07 RID: 150023 RVA: 0x0050858E File Offset: 0x0050678E
		public static void StartIFrequencyPaintEncloseLine(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024A08 RID: 150024 RVA: 0x00508597 File Offset: 0x00506797
		public static void AddType(FlatBufferBuilder builder, EFrequencyPaintLineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024A09 RID: 150025 RVA: 0x005085A2 File Offset: 0x005067A2
		public static Offset<IFrequencyPaintEncloseLine> EndIFrequencyPaintEncloseLine(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyPaintEncloseLine>(builder.EndTable());
		}

		// Token: 0x06024A0A RID: 150026 RVA: 0x005085B0 File Offset: 0x005067B0
		public IFrequencyPaintEncloseLineT UnPack()
		{
			IFrequencyPaintEncloseLineT frequencyPaintEncloseLineT = new IFrequencyPaintEncloseLineT();
			this.UnPackTo(frequencyPaintEncloseLineT);
			return frequencyPaintEncloseLineT;
		}

		// Token: 0x06024A0B RID: 150027 RVA: 0x005085CB File Offset: 0x005067CB
		public void UnPackTo(IFrequencyPaintEncloseLineT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024A0C RID: 150028 RVA: 0x005085DC File Offset: 0x005067DC
		public static Offset<IFrequencyPaintEncloseLine> Pack(FlatBufferBuilder builder, IFrequencyPaintEncloseLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyPaintEncloseLine>);
			}
			return IFrequencyPaintEncloseLine.CreateIFrequencyPaintEncloseLine(builder, _o.Type);
		}

		// Token: 0x0400F08A RID: 61578
		private Table __p;
	}
}
