using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E9 RID: 21481
	public struct IImmediateAddBuff : IFlatbufferObject
	{
		// Token: 0x17009E1C RID: 40476
		// (get) Token: 0x0602346B RID: 144491 RVA: 0x004E27EE File Offset: 0x004E09EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602346C RID: 144492 RVA: 0x004E27FB File Offset: 0x004E09FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602346D RID: 144493 RVA: 0x004E2804 File Offset: 0x004E0A04
		public static IImmediateAddBuff GetRootAsIImmediateAddBuff(ByteBuffer _bb)
		{
			return IImmediateAddBuff.GetRootAsIImmediateAddBuff(_bb, default(IImmediateAddBuff));
		}

		// Token: 0x0602346E RID: 144494 RVA: 0x004E2820 File Offset: 0x004E0A20
		public static IImmediateAddBuff GetRootAsIImmediateAddBuff(ByteBuffer _bb, IImmediateAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602346F RID: 144495 RVA: 0x004E283D File Offset: 0x004E0A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023470 RID: 144496 RVA: 0x004E284C File Offset: 0x004E0A4C
		public IImmediateAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E1D RID: 40477
		// (get) Token: 0x06023471 RID: 144497 RVA: 0x004E285C File Offset: 0x004E0A5C
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

		// Token: 0x06023472 RID: 144498 RVA: 0x004E2898 File Offset: 0x004E0A98
		public static Offset<IImmediateAddBuff> CreateIImmediateAddBuff(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate)
		{
			builder.StartTable(1);
			IImmediateAddBuff.AddType(builder, Type);
			return IImmediateAddBuff.EndIImmediateAddBuff(builder);
		}

		// Token: 0x06023473 RID: 144499 RVA: 0x004E28AE File Offset: 0x004E0AAE
		public static void StartIImmediateAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023474 RID: 144500 RVA: 0x004E28B7 File Offset: 0x004E0AB7
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023475 RID: 144501 RVA: 0x004E28C2 File Offset: 0x004E0AC2
		public static Offset<IImmediateAddBuff> EndIImmediateAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IImmediateAddBuff>(builder.EndTable());
		}

		// Token: 0x06023476 RID: 144502 RVA: 0x004E28D0 File Offset: 0x004E0AD0
		public IImmediateAddBuffT UnPack()
		{
			IImmediateAddBuffT immediateAddBuffT = new IImmediateAddBuffT();
			this.UnPackTo(immediateAddBuffT);
			return immediateAddBuffT;
		}

		// Token: 0x06023477 RID: 144503 RVA: 0x004E28EB File Offset: 0x004E0AEB
		public void UnPackTo(IImmediateAddBuffT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023478 RID: 144504 RVA: 0x004E28FC File Offset: 0x004E0AFC
		public static Offset<IImmediateAddBuff> Pack(FlatBufferBuilder builder, IImmediateAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IImmediateAddBuff>);
			}
			return IImmediateAddBuff.CreateIImmediateAddBuff(builder, _o.Type);
		}

		// Token: 0x0400E62B RID: 58923
		private Table __p;
	}
}
