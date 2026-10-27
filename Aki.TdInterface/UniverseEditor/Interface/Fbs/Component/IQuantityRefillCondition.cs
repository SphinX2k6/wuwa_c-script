using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C6 RID: 22470
	public struct IQuantityRefillCondition : IFlatbufferObject
	{
		// Token: 0x1700A7B1 RID: 42929
		// (get) Token: 0x06025B62 RID: 154466 RVA: 0x00533626 File Offset: 0x00531826
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B63 RID: 154467 RVA: 0x00533633 File Offset: 0x00531833
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B64 RID: 154468 RVA: 0x0053363C File Offset: 0x0053183C
		public static IQuantityRefillCondition GetRootAsIQuantityRefillCondition(ByteBuffer _bb)
		{
			return IQuantityRefillCondition.GetRootAsIQuantityRefillCondition(_bb, default(IQuantityRefillCondition));
		}

		// Token: 0x06025B65 RID: 154469 RVA: 0x00533658 File Offset: 0x00531858
		public static IQuantityRefillCondition GetRootAsIQuantityRefillCondition(ByteBuffer _bb, IQuantityRefillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B66 RID: 154470 RVA: 0x00533675 File Offset: 0x00531875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B67 RID: 154471 RVA: 0x00533684 File Offset: 0x00531884
		public IQuantityRefillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7B2 RID: 42930
		// (get) Token: 0x06025B68 RID: 154472 RVA: 0x00533694 File Offset: 0x00531894
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

		// Token: 0x1700A7B3 RID: 42931
		// (get) Token: 0x06025B69 RID: 154473 RVA: 0x005336D0 File Offset: 0x005318D0
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

		// Token: 0x1700A7B4 RID: 42932
		// (get) Token: 0x06025B6A RID: 154474 RVA: 0x0053370C File Offset: 0x0053190C
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

		// Token: 0x1700A7B5 RID: 42933
		// (get) Token: 0x06025B6B RID: 154475 RVA: 0x0053374C File Offset: 0x0053194C
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

		// Token: 0x06025B6C RID: 154476 RVA: 0x00533789 File Offset: 0x00531989
		public static Offset<IQuantityRefillCondition> CreateIQuantityRefillCondition(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition Type = ESpawnMonsterCompleteCondition.AllKill, int Quantity = 0, float DelayRefill = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IQuantityRefillCondition.AddDelayRefill(builder, DelayRefill);
			IQuantityRefillCondition.AddQuantity(builder, Quantity);
			IQuantityRefillCondition.AddNullMask(builder, NullMask);
			IQuantityRefillCondition.AddType(builder, Type);
			return IQuantityRefillCondition.EndIQuantityRefillCondition(builder);
		}

		// Token: 0x06025B6D RID: 154477 RVA: 0x005337B5 File Offset: 0x005319B5
		public static void StartIQuantityRefillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025B6E RID: 154478 RVA: 0x005337BE File Offset: 0x005319BE
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025B6F RID: 154479 RVA: 0x005337C9 File Offset: 0x005319C9
		public static void AddQuantity(FlatBufferBuilder builder, int quantity)
		{
			builder.AddInt(1, quantity, 0);
		}

		// Token: 0x06025B70 RID: 154480 RVA: 0x005337D4 File Offset: 0x005319D4
		public static void AddDelayRefill(FlatBufferBuilder builder, float delayRefill)
		{
			builder.AddFloat(2, delayRefill, 0.0);
		}

		// Token: 0x06025B71 RID: 154481 RVA: 0x005337E7 File Offset: 0x005319E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025B72 RID: 154482 RVA: 0x005337F2 File Offset: 0x005319F2
		public static Offset<IQuantityRefillCondition> EndIQuantityRefillCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuantityRefillCondition>(builder.EndTable());
		}

		// Token: 0x06025B73 RID: 154483 RVA: 0x00533800 File Offset: 0x00531A00
		public IQuantityRefillConditionT UnPack()
		{
			IQuantityRefillConditionT quantityRefillConditionT = new IQuantityRefillConditionT();
			this.UnPackTo(quantityRefillConditionT);
			return quantityRefillConditionT;
		}

		// Token: 0x06025B74 RID: 154484 RVA: 0x0053381B File Offset: 0x00531A1B
		public void UnPackTo(IQuantityRefillConditionT _o)
		{
			_o.Type = this.Type;
			_o.Quantity = this.Quantity;
			_o.DelayRefill = this.DelayRefill;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025B75 RID: 154485 RVA: 0x00533850 File Offset: 0x00531A50
		public static Offset<IQuantityRefillCondition> Pack(FlatBufferBuilder builder, IQuantityRefillConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuantityRefillCondition>);
			}
			return IQuantityRefillCondition.CreateIQuantityRefillCondition(builder, _o.Type, _o.Quantity, _o.DelayRefill, _o.NullMask);
		}

		// Token: 0x0400ECA2 RID: 60578
		private Table __p;
	}
}
