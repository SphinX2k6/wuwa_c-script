using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E0E RID: 15886
	public struct IBvbCardFilterCheckIsCapableToEvolve : IFlatbufferObject
	{
		// Token: 0x17006B48 RID: 27464
		// (get) Token: 0x060155A4 RID: 87460 RVA: 0x00315C74 File Offset: 0x00313E74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155A5 RID: 87461 RVA: 0x00315C81 File Offset: 0x00313E81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155A6 RID: 87462 RVA: 0x00315C88 File Offset: 0x00313E88
		public static IBvbCardFilterCheckIsCapableToEvolve GetRootAsIBvbCardFilterCheckIsCapableToEvolve(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckIsCapableToEvolve.GetRootAsIBvbCardFilterCheckIsCapableToEvolve(_bb, default(IBvbCardFilterCheckIsCapableToEvolve));
		}

		// Token: 0x060155A7 RID: 87463 RVA: 0x00315CA4 File Offset: 0x00313EA4
		public static IBvbCardFilterCheckIsCapableToEvolve GetRootAsIBvbCardFilterCheckIsCapableToEvolve(ByteBuffer _bb, IBvbCardFilterCheckIsCapableToEvolve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060155A8 RID: 87464 RVA: 0x00315CC1 File Offset: 0x00313EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060155A9 RID: 87465 RVA: 0x00315CD0 File Offset: 0x00313ED0
		public IBvbCardFilterCheckIsCapableToEvolve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B49 RID: 27465
		// (get) Token: 0x060155AA RID: 87466 RVA: 0x00315CE0 File Offset: 0x00313EE0
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B4A RID: 27466
		// (get) Token: 0x060155AB RID: 87467 RVA: 0x00315D1C File Offset: 0x00313F1C
		public int Cost
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

		// Token: 0x060155AC RID: 87468 RVA: 0x00315D58 File Offset: 0x00313F58
		public static Offset<IBvbCardFilterCheckIsCapableToEvolve> CreateIBvbCardFilterCheckIsCapableToEvolve(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, int Cost = 0)
		{
			builder.StartTable(2);
			IBvbCardFilterCheckIsCapableToEvolve.AddCost(builder, Cost);
			IBvbCardFilterCheckIsCapableToEvolve.AddType(builder, Type);
			return IBvbCardFilterCheckIsCapableToEvolve.EndIBvbCardFilterCheckIsCapableToEvolve(builder);
		}

		// Token: 0x060155AD RID: 87469 RVA: 0x00315D75 File Offset: 0x00313F75
		public static void StartIBvbCardFilterCheckIsCapableToEvolve(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060155AE RID: 87470 RVA: 0x00315D7E File Offset: 0x00313F7E
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155AF RID: 87471 RVA: 0x00315D89 File Offset: 0x00313F89
		public static void AddCost(FlatBufferBuilder builder, int cost)
		{
			builder.AddInt(1, cost, 0);
		}

		// Token: 0x060155B0 RID: 87472 RVA: 0x00315D94 File Offset: 0x00313F94
		public static Offset<IBvbCardFilterCheckIsCapableToEvolve> EndIBvbCardFilterCheckIsCapableToEvolve(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckIsCapableToEvolve>(builder.EndTable());
		}

		// Token: 0x060155B1 RID: 87473 RVA: 0x00315DA4 File Offset: 0x00313FA4
		public IBvbCardFilterCheckIsCapableToEvolveT UnPack()
		{
			IBvbCardFilterCheckIsCapableToEvolveT bvbCardFilterCheckIsCapableToEvolveT = new IBvbCardFilterCheckIsCapableToEvolveT();
			this.UnPackTo(bvbCardFilterCheckIsCapableToEvolveT);
			return bvbCardFilterCheckIsCapableToEvolveT;
		}

		// Token: 0x060155B2 RID: 87474 RVA: 0x00315DBF File Offset: 0x00313FBF
		public void UnPackTo(IBvbCardFilterCheckIsCapableToEvolveT _o)
		{
			_o.Type = this.Type;
			_o.Cost = this.Cost;
		}

		// Token: 0x060155B3 RID: 87475 RVA: 0x00315DDC File Offset: 0x00313FDC
		public static Offset<IBvbCardFilterCheckIsCapableToEvolve> Pack(FlatBufferBuilder builder, IBvbCardFilterCheckIsCapableToEvolveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCheckIsCapableToEvolve>);
			}
			return IBvbCardFilterCheckIsCapableToEvolve.CreateIBvbCardFilterCheckIsCapableToEvolve(builder, _o.Type, _o.Cost);
		}

		// Token: 0x0400B7D4 RID: 47060
		private Table __p;
	}
}
