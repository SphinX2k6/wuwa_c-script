using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B32 RID: 15154
	public struct IWoodenBoxProliferateRandomInRange : IFlatbufferObject
	{
		// Token: 0x170067FE RID: 26622
		// (get) Token: 0x06014B59 RID: 84825 RVA: 0x00303190 File Offset: 0x00301390
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014B5A RID: 84826 RVA: 0x0030319D File Offset: 0x0030139D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014B5B RID: 84827 RVA: 0x003031A4 File Offset: 0x003013A4
		public static IWoodenBoxProliferateRandomInRange GetRootAsIWoodenBoxProliferateRandomInRange(ByteBuffer _bb)
		{
			return IWoodenBoxProliferateRandomInRange.GetRootAsIWoodenBoxProliferateRandomInRange(_bb, default(IWoodenBoxProliferateRandomInRange));
		}

		// Token: 0x06014B5C RID: 84828 RVA: 0x003031C0 File Offset: 0x003013C0
		public static IWoodenBoxProliferateRandomInRange GetRootAsIWoodenBoxProliferateRandomInRange(ByteBuffer _bb, IWoodenBoxProliferateRandomInRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014B5D RID: 84829 RVA: 0x003031DD File Offset: 0x003013DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014B5E RID: 84830 RVA: 0x003031EC File Offset: 0x003013EC
		public IWoodenBoxProliferateRandomInRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067FF RID: 26623
		// (get) Token: 0x06014B5F RID: 84831 RVA: 0x003031FC File Offset: 0x003013FC
		public EWoodenBoxProliferateSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWoodenBoxProliferateSpawnType.RandomInRange;
				}
				return (EWoodenBoxProliferateSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006800 RID: 26624
		// (get) Token: 0x06014B60 RID: 84832 RVA: 0x00303238 File Offset: 0x00301438
		public float RangeRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006801 RID: 26625
		// (get) Token: 0x06014B61 RID: 84833 RVA: 0x00303278 File Offset: 0x00301478
		public int Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B62 RID: 84834 RVA: 0x003032B4 File Offset: 0x003014B4
		public static Offset<IWoodenBoxProliferateRandomInRange> CreateIWoodenBoxProliferateRandomInRange(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType Type = EWoodenBoxProliferateSpawnType.RandomInRange, float RangeRadius = 0f, int Count = 0)
		{
			builder.StartTable(3);
			IWoodenBoxProliferateRandomInRange.AddCount(builder, Count);
			IWoodenBoxProliferateRandomInRange.AddRangeRadius(builder, RangeRadius);
			IWoodenBoxProliferateRandomInRange.AddType(builder, Type);
			return IWoodenBoxProliferateRandomInRange.EndIWoodenBoxProliferateRandomInRange(builder);
		}

		// Token: 0x06014B63 RID: 84835 RVA: 0x003032D8 File Offset: 0x003014D8
		public static void StartIWoodenBoxProliferateRandomInRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014B64 RID: 84836 RVA: 0x003032E1 File Offset: 0x003014E1
		public static void AddType(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014B65 RID: 84837 RVA: 0x003032EC File Offset: 0x003014EC
		public static void AddRangeRadius(FlatBufferBuilder builder, float rangeRadius)
		{
			builder.AddFloat(1, rangeRadius, 0.0);
		}

		// Token: 0x06014B66 RID: 84838 RVA: 0x003032FF File Offset: 0x003014FF
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06014B67 RID: 84839 RVA: 0x0030330A File Offset: 0x0030150A
		public static Offset<IWoodenBoxProliferateRandomInRange> EndIWoodenBoxProliferateRandomInRange(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferateRandomInRange>(builder.EndTable());
		}

		// Token: 0x06014B68 RID: 84840 RVA: 0x00303318 File Offset: 0x00301518
		public IWoodenBoxProliferateRandomInRangeT UnPack()
		{
			IWoodenBoxProliferateRandomInRangeT woodenBoxProliferateRandomInRangeT = new IWoodenBoxProliferateRandomInRangeT();
			this.UnPackTo(woodenBoxProliferateRandomInRangeT);
			return woodenBoxProliferateRandomInRangeT;
		}

		// Token: 0x06014B69 RID: 84841 RVA: 0x00303333 File Offset: 0x00301533
		public void UnPackTo(IWoodenBoxProliferateRandomInRangeT _o)
		{
			_o.Type = this.Type;
			_o.RangeRadius = this.RangeRadius;
			_o.Count = this.Count;
		}

		// Token: 0x06014B6A RID: 84842 RVA: 0x0030335C File Offset: 0x0030155C
		public static Offset<IWoodenBoxProliferateRandomInRange> Pack(FlatBufferBuilder builder, IWoodenBoxProliferateRandomInRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenBoxProliferateRandomInRange>);
			}
			return IWoodenBoxProliferateRandomInRange.CreateIWoodenBoxProliferateRandomInRange(builder, _o.Type, _o.RangeRadius, _o.Count);
		}

		// Token: 0x0400B012 RID: 45074
		private Table __p;
	}
}
