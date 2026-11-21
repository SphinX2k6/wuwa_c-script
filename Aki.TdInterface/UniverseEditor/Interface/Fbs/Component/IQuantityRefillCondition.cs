using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DCD RID: 24013
	public struct IQuantityRefillCondition : IFlatbufferObject
	{
		// Token: 0x1700B0D5 RID: 45269
		// (get) Token: 0x06028082 RID: 163970 RVA: 0x005797B2 File Offset: 0x005779B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028083 RID: 163971 RVA: 0x005797BF File Offset: 0x005779BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028084 RID: 163972 RVA: 0x005797C8 File Offset: 0x005779C8
		public static IQuantityRefillCondition GetRootAsIQuantityRefillCondition(ByteBuffer _bb)
		{
			return IQuantityRefillCondition.GetRootAsIQuantityRefillCondition(_bb, default(IQuantityRefillCondition));
		}

		// Token: 0x06028085 RID: 163973 RVA: 0x005797E4 File Offset: 0x005779E4
		public static IQuantityRefillCondition GetRootAsIQuantityRefillCondition(ByteBuffer _bb, IQuantityRefillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028086 RID: 163974 RVA: 0x00579801 File Offset: 0x00577A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028087 RID: 163975 RVA: 0x00579810 File Offset: 0x00577A10
		public IQuantityRefillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0D6 RID: 45270
		// (get) Token: 0x06028088 RID: 163976 RVA: 0x00579820 File Offset: 0x00577A20
		public ESpawnMonsterCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return (ESpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0D7 RID: 45271
		// (get) Token: 0x06028089 RID: 163977 RVA: 0x0057985C File Offset: 0x00577A5C
		public int Quantity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0D8 RID: 45272
		// (get) Token: 0x0602808A RID: 163978 RVA: 0x00579898 File Offset: 0x00577A98
		public float DelayRefill
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

		// Token: 0x1700B0D9 RID: 45273
		// (get) Token: 0x0602808B RID: 163979 RVA: 0x005798D8 File Offset: 0x00577AD8
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

		// Token: 0x0602808C RID: 163980 RVA: 0x00579915 File Offset: 0x00577B15
		public static Offset<IQuantityRefillCondition> CreateIQuantityRefillCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill, int Quantity = 0, float DelayRefill = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuantityRefillCondition.AddDelayRefill(builder, DelayRefill);
			IQuantityRefillCondition.AddQuantity(builder, Quantity);
			IQuantityRefillCondition.AddNullMask(builder, NullMask);
			IQuantityRefillCondition.AddType(builder, Type);
			return IQuantityRefillCondition.EndIQuantityRefillCondition(builder);
		}

		// Token: 0x0602808D RID: 163981 RVA: 0x00579941 File Offset: 0x00577B41
		public static void StartIQuantityRefillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602808E RID: 163982 RVA: 0x0057994A File Offset: 0x00577B4A
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602808F RID: 163983 RVA: 0x00579955 File Offset: 0x00577B55
		public static void AddQuantity(FlatBufferBuilder builder, int quantity)
		{
			builder.AddInt(1, quantity, 0);
		}

		// Token: 0x06028090 RID: 163984 RVA: 0x00579960 File Offset: 0x00577B60
		public static void AddDelayRefill(FlatBufferBuilder builder, float delayRefill)
		{
			builder.AddFloat(2, delayRefill, 0.0);
		}

		// Token: 0x06028091 RID: 163985 RVA: 0x00579973 File Offset: 0x00577B73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028092 RID: 163986 RVA: 0x0057997E File Offset: 0x00577B7E
		public static Offset<IQuantityRefillCondition> EndIQuantityRefillCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuantityRefillCondition>(builder.EndTable());
		}

		// Token: 0x06028093 RID: 163987 RVA: 0x0057998C File Offset: 0x00577B8C
		public IQuantityRefillConditionT UnPack()
		{
			IQuantityRefillConditionT quantityRefillConditionT = new IQuantityRefillConditionT();
			this.UnPackTo(quantityRefillConditionT);
			return quantityRefillConditionT;
		}

		// Token: 0x06028094 RID: 163988 RVA: 0x005799A7 File Offset: 0x00577BA7
		public void UnPackTo(IQuantityRefillConditionT _o)
		{
			_o.Type = this.Type;
			_o.Quantity = this.Quantity;
			_o.DelayRefill = this.DelayRefill;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028095 RID: 163989 RVA: 0x005799DC File Offset: 0x00577BDC
		public static Offset<IQuantityRefillCondition> Pack(FlatBufferBuilder builder, IQuantityRefillConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuantityRefillCondition>);
			}
			return IQuantityRefillCondition.CreateIQuantityRefillCondition(builder, _o.Type, _o.Quantity, _o.DelayRefill, _o.NullMask);
		}

		// Token: 0x0400F98D RID: 63885
		private Table __p;
	}
}
