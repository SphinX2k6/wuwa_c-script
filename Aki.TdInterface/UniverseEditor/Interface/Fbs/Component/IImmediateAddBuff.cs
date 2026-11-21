using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596F RID: 22895
	public struct IImmediateAddBuff : IFlatbufferObject
	{
		// Token: 0x1700A656 RID: 42582
		// (get) Token: 0x06025523 RID: 152867 RVA: 0x0051F81A File Offset: 0x0051DA1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025524 RID: 152868 RVA: 0x0051F827 File Offset: 0x0051DA27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025525 RID: 152869 RVA: 0x0051F830 File Offset: 0x0051DA30
		public static IImmediateAddBuff GetRootAsIImmediateAddBuff(ByteBuffer _bb)
		{
			return IImmediateAddBuff.GetRootAsIImmediateAddBuff(_bb, default(IImmediateAddBuff));
		}

		// Token: 0x06025526 RID: 152870 RVA: 0x0051F84C File Offset: 0x0051DA4C
		public static IImmediateAddBuff GetRootAsIImmediateAddBuff(ByteBuffer _bb, IImmediateAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025527 RID: 152871 RVA: 0x0051F869 File Offset: 0x0051DA69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025528 RID: 152872 RVA: 0x0051F878 File Offset: 0x0051DA78
		public IImmediateAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A657 RID: 42583
		// (get) Token: 0x06025529 RID: 152873 RVA: 0x0051F888 File Offset: 0x0051DA88
		public EBuffProducerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffProducerMode.Immediate;
				}
				return (EBuffProducerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602552A RID: 152874 RVA: 0x0051F8C4 File Offset: 0x0051DAC4
		public static Offset<IImmediateAddBuff> CreateIImmediateAddBuff(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate)
		{
			builder.StartTable(1);
			IImmediateAddBuff.AddType(builder, Type);
			return IImmediateAddBuff.EndIImmediateAddBuff(builder);
		}

		// Token: 0x0602552B RID: 152875 RVA: 0x0051F8DA File Offset: 0x0051DADA
		public static void StartIImmediateAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602552C RID: 152876 RVA: 0x0051F8E3 File Offset: 0x0051DAE3
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602552D RID: 152877 RVA: 0x0051F8EE File Offset: 0x0051DAEE
		public static Offset<IImmediateAddBuff> EndIImmediateAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IImmediateAddBuff>(builder.EndTable());
		}

		// Token: 0x0602552E RID: 152878 RVA: 0x0051F8FC File Offset: 0x0051DAFC
		public IImmediateAddBuffT UnPack()
		{
			IImmediateAddBuffT immediateAddBuffT = new IImmediateAddBuffT();
			this.UnPackTo(immediateAddBuffT);
			return immediateAddBuffT;
		}

		// Token: 0x0602552F RID: 152879 RVA: 0x0051F917 File Offset: 0x0051DB17
		public void UnPackTo(IImmediateAddBuffT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025530 RID: 152880 RVA: 0x0051F928 File Offset: 0x0051DB28
		public static Offset<IImmediateAddBuff> Pack(FlatBufferBuilder builder, IImmediateAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IImmediateAddBuff>);
			}
			return IImmediateAddBuff.CreateIImmediateAddBuff(builder, _o.Type);
		}

		// Token: 0x0400F25C RID: 62044
		private Table __p;
	}
}
