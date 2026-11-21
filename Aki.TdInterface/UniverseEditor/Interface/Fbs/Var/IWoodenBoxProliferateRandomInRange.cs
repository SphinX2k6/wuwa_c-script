using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F34 RID: 16180
	public struct IWoodenBoxProliferateRandomInRange : IFlatbufferObject
	{
		// Token: 0x17006D99 RID: 28057
		// (get) Token: 0x06016003 RID: 90115 RVA: 0x00329420 File Offset: 0x00327620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016004 RID: 90116 RVA: 0x0032942D File Offset: 0x0032762D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016005 RID: 90117 RVA: 0x00329434 File Offset: 0x00327634
		public static IWoodenBoxProliferateRandomInRange GetRootAsIWoodenBoxProliferateRandomInRange(ByteBuffer _bb)
		{
			return IWoodenBoxProliferateRandomInRange.GetRootAsIWoodenBoxProliferateRandomInRange(_bb, default(IWoodenBoxProliferateRandomInRange));
		}

		// Token: 0x06016006 RID: 90118 RVA: 0x00329450 File Offset: 0x00327650
		public static IWoodenBoxProliferateRandomInRange GetRootAsIWoodenBoxProliferateRandomInRange(ByteBuffer _bb, IWoodenBoxProliferateRandomInRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016007 RID: 90119 RVA: 0x0032946D File Offset: 0x0032766D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016008 RID: 90120 RVA: 0x0032947C File Offset: 0x0032767C
		public IWoodenBoxProliferateRandomInRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D9A RID: 28058
		// (get) Token: 0x06016009 RID: 90121 RVA: 0x0032948C File Offset: 0x0032768C
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

		// Token: 0x17006D9B RID: 28059
		// (get) Token: 0x0601600A RID: 90122 RVA: 0x003294C8 File Offset: 0x003276C8
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

		// Token: 0x17006D9C RID: 28060
		// (get) Token: 0x0601600B RID: 90123 RVA: 0x00329508 File Offset: 0x00327708
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

		// Token: 0x0601600C RID: 90124 RVA: 0x00329544 File Offset: 0x00327744
		public static Offset<IWoodenBoxProliferateRandomInRange> CreateIWoodenBoxProliferateRandomInRange(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType Type = EWoodenBoxProliferateSpawnType.RandomInRange, float RangeRadius = 0f, int Count = 0)
		{
			builder.StartTable(3);
			IWoodenBoxProliferateRandomInRange.AddCount(builder, Count);
			IWoodenBoxProliferateRandomInRange.AddRangeRadius(builder, RangeRadius);
			IWoodenBoxProliferateRandomInRange.AddType(builder, Type);
			return IWoodenBoxProliferateRandomInRange.EndIWoodenBoxProliferateRandomInRange(builder);
		}

		// Token: 0x0601600D RID: 90125 RVA: 0x00329568 File Offset: 0x00327768
		public static void StartIWoodenBoxProliferateRandomInRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601600E RID: 90126 RVA: 0x00329571 File Offset: 0x00327771
		public static void AddType(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601600F RID: 90127 RVA: 0x0032957C File Offset: 0x0032777C
		public static void AddRangeRadius(FlatBufferBuilder builder, float rangeRadius)
		{
			builder.AddFloat(1, rangeRadius, 0.0);
		}

		// Token: 0x06016010 RID: 90128 RVA: 0x0032958F File Offset: 0x0032778F
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06016011 RID: 90129 RVA: 0x0032959A File Offset: 0x0032779A
		public static Offset<IWoodenBoxProliferateRandomInRange> EndIWoodenBoxProliferateRandomInRange(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferateRandomInRange>(builder.EndTable());
		}

		// Token: 0x06016012 RID: 90130 RVA: 0x003295A8 File Offset: 0x003277A8
		public IWoodenBoxProliferateRandomInRangeT UnPack()
		{
			IWoodenBoxProliferateRandomInRangeT woodenBoxProliferateRandomInRangeT = new IWoodenBoxProliferateRandomInRangeT();
			this.UnPackTo(woodenBoxProliferateRandomInRangeT);
			return woodenBoxProliferateRandomInRangeT;
		}

		// Token: 0x06016013 RID: 90131 RVA: 0x003295C3 File Offset: 0x003277C3
		public void UnPackTo(IWoodenBoxProliferateRandomInRangeT _o)
		{
			_o.Type = this.Type;
			_o.RangeRadius = this.RangeRadius;
			_o.Count = this.Count;
		}

		// Token: 0x06016014 RID: 90132 RVA: 0x003295EC File Offset: 0x003277EC
		public static Offset<IWoodenBoxProliferateRandomInRange> Pack(FlatBufferBuilder builder, IWoodenBoxProliferateRandomInRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenBoxProliferateRandomInRange>);
			}
			return IWoodenBoxProliferateRandomInRange.CreateIWoodenBoxProliferateRandomInRange(builder, _o.Type, _o.RangeRadius, _o.Count);
		}

		// Token: 0x0400B97F RID: 47487
		private Table __p;
	}
}
