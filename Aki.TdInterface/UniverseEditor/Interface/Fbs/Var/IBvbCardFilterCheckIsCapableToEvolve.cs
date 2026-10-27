using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A33 RID: 14899
	public struct IBvbCardFilterCheckIsCapableToEvolve : IFlatbufferObject
	{
		// Token: 0x17006618 RID: 26136
		// (get) Token: 0x06014288 RID: 82568 RVA: 0x002F2A88 File Offset: 0x002F0C88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014289 RID: 82569 RVA: 0x002F2A95 File Offset: 0x002F0C95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601428A RID: 82570 RVA: 0x002F2A9C File Offset: 0x002F0C9C
		public static IBvbCardFilterCheckIsCapableToEvolve GetRootAsIBvbCardFilterCheckIsCapableToEvolve(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckIsCapableToEvolve.GetRootAsIBvbCardFilterCheckIsCapableToEvolve(_bb, default(IBvbCardFilterCheckIsCapableToEvolve));
		}

		// Token: 0x0601428B RID: 82571 RVA: 0x002F2AB8 File Offset: 0x002F0CB8
		public static IBvbCardFilterCheckIsCapableToEvolve GetRootAsIBvbCardFilterCheckIsCapableToEvolve(ByteBuffer _bb, IBvbCardFilterCheckIsCapableToEvolve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601428C RID: 82572 RVA: 0x002F2AD5 File Offset: 0x002F0CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601428D RID: 82573 RVA: 0x002F2AE4 File Offset: 0x002F0CE4
		public IBvbCardFilterCheckIsCapableToEvolve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006619 RID: 26137
		// (get) Token: 0x0601428E RID: 82574 RVA: 0x002F2AF4 File Offset: 0x002F0CF4
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

		// Token: 0x1700661A RID: 26138
		// (get) Token: 0x0601428F RID: 82575 RVA: 0x002F2B30 File Offset: 0x002F0D30
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

		// Token: 0x06014290 RID: 82576 RVA: 0x002F2B6C File Offset: 0x002F0D6C
		public static Offset<IBvbCardFilterCheckIsCapableToEvolve> CreateIBvbCardFilterCheckIsCapableToEvolve(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, int Cost = 0)
		{
			builder.StartTable(2);
			IBvbCardFilterCheckIsCapableToEvolve.AddCost(builder, Cost);
			IBvbCardFilterCheckIsCapableToEvolve.AddType(builder, Type);
			return IBvbCardFilterCheckIsCapableToEvolve.EndIBvbCardFilterCheckIsCapableToEvolve(builder);
		}

		// Token: 0x06014291 RID: 82577 RVA: 0x002F2B89 File Offset: 0x002F0D89
		public static void StartIBvbCardFilterCheckIsCapableToEvolve(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014292 RID: 82578 RVA: 0x002F2B92 File Offset: 0x002F0D92
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014293 RID: 82579 RVA: 0x002F2B9D File Offset: 0x002F0D9D
		public static void AddCost(FlatBufferBuilder builder, int cost)
		{
			builder.AddInt(1, cost, 0);
		}

		// Token: 0x06014294 RID: 82580 RVA: 0x002F2BA8 File Offset: 0x002F0DA8
		public static Offset<IBvbCardFilterCheckIsCapableToEvolve> EndIBvbCardFilterCheckIsCapableToEvolve(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckIsCapableToEvolve>(builder.EndTable());
		}

		// Token: 0x06014295 RID: 82581 RVA: 0x002F2BB8 File Offset: 0x002F0DB8
		public IBvbCardFilterCheckIsCapableToEvolveT UnPack()
		{
			IBvbCardFilterCheckIsCapableToEvolveT bvbCardFilterCheckIsCapableToEvolveT = new IBvbCardFilterCheckIsCapableToEvolveT();
			this.UnPackTo(bvbCardFilterCheckIsCapableToEvolveT);
			return bvbCardFilterCheckIsCapableToEvolveT;
		}

		// Token: 0x06014296 RID: 82582 RVA: 0x002F2BD3 File Offset: 0x002F0DD3
		public void UnPackTo(IBvbCardFilterCheckIsCapableToEvolveT _o)
		{
			_o.Type = this.Type;
			_o.Cost = this.Cost;
		}

		// Token: 0x06014297 RID: 82583 RVA: 0x002F2BF0 File Offset: 0x002F0DF0
		public static Offset<IBvbCardFilterCheckIsCapableToEvolve> Pack(FlatBufferBuilder builder, IBvbCardFilterCheckIsCapableToEvolveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCheckIsCapableToEvolve>);
			}
			return IBvbCardFilterCheckIsCapableToEvolve.CreateIBvbCardFilterCheckIsCapableToEvolve(builder, _o.Type, _o.Cost);
		}

		// Token: 0x0400AEB2 RID: 44722
		private Table __p;
	}
}
