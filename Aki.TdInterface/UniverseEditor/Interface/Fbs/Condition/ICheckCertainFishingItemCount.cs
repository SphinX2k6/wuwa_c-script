using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E4B RID: 20043
	public struct ICheckCertainFishingItemCount : IFlatbufferObject
	{
		// Token: 0x17008ECD RID: 36557
		// (get) Token: 0x0601F01F RID: 127007 RVA: 0x00454524 File Offset: 0x00452724
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F020 RID: 127008 RVA: 0x00454531 File Offset: 0x00452731
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F021 RID: 127009 RVA: 0x00454538 File Offset: 0x00452738
		public static ICheckCertainFishingItemCount GetRootAsICheckCertainFishingItemCount(ByteBuffer _bb)
		{
			return ICheckCertainFishingItemCount.GetRootAsICheckCertainFishingItemCount(_bb, default(ICheckCertainFishingItemCount));
		}

		// Token: 0x0601F022 RID: 127010 RVA: 0x00454554 File Offset: 0x00452754
		public static ICheckCertainFishingItemCount GetRootAsICheckCertainFishingItemCount(ByteBuffer _bb, ICheckCertainFishingItemCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F023 RID: 127011 RVA: 0x00454571 File Offset: 0x00452771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F024 RID: 127012 RVA: 0x00454580 File Offset: 0x00452780
		public ICheckCertainFishingItemCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ECE RID: 36558
		// (get) Token: 0x0601F025 RID: 127013 RVA: 0x00454590 File Offset: 0x00452790
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ECF RID: 36559
		// (get) Token: 0x0601F026 RID: 127014 RVA: 0x004545CC File Offset: 0x004527CC
		public int Id
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

		// Token: 0x17008ED0 RID: 36560
		// (get) Token: 0x0601F027 RID: 127015 RVA: 0x00454608 File Offset: 0x00452808
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ED1 RID: 36561
		// (get) Token: 0x0601F028 RID: 127016 RVA: 0x00454644 File Offset: 0x00452844
		public int Count
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F029 RID: 127017 RVA: 0x00454681 File Offset: 0x00452881
		public static Offset<ICheckCertainFishingItemCount> CreateICheckCertainFishingItemCount(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int Id = 0, ECompare Compare = ECompare.Eq, int Count = 0)
		{
			builder.StartTable(4);
			ICheckCertainFishingItemCount.AddCount(builder, Count);
			ICheckCertainFishingItemCount.AddId(builder, Id);
			ICheckCertainFishingItemCount.AddCompare(builder, Compare);
			ICheckCertainFishingItemCount.AddType(builder, Type);
			return ICheckCertainFishingItemCount.EndICheckCertainFishingItemCount(builder);
		}

		// Token: 0x0601F02A RID: 127018 RVA: 0x004546AD File Offset: 0x004528AD
		public static void StartICheckCertainFishingItemCount(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F02B RID: 127019 RVA: 0x004546B6 File Offset: 0x004528B6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F02C RID: 127020 RVA: 0x004546C1 File Offset: 0x004528C1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601F02D RID: 127021 RVA: 0x004546CC File Offset: 0x004528CC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F02E RID: 127022 RVA: 0x004546D7 File Offset: 0x004528D7
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		// Token: 0x0601F02F RID: 127023 RVA: 0x004546E2 File Offset: 0x004528E2
		public static Offset<ICheckCertainFishingItemCount> EndICheckCertainFishingItemCount(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCertainFishingItemCount>(builder.EndTable());
		}

		// Token: 0x0601F030 RID: 127024 RVA: 0x004546F0 File Offset: 0x004528F0
		public ICheckCertainFishingItemCountT UnPack()
		{
			ICheckCertainFishingItemCountT checkCertainFishingItemCountT = new ICheckCertainFishingItemCountT();
			this.UnPackTo(checkCertainFishingItemCountT);
			return checkCertainFishingItemCountT;
		}

		// Token: 0x0601F031 RID: 127025 RVA: 0x0045470B File Offset: 0x0045290B
		public void UnPackTo(ICheckCertainFishingItemCountT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
		}

		// Token: 0x0601F032 RID: 127026 RVA: 0x00454740 File Offset: 0x00452940
		public static Offset<ICheckCertainFishingItemCount> Pack(FlatBufferBuilder builder, ICheckCertainFishingItemCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCertainFishingItemCount>);
			}
			return ICheckCertainFishingItemCount.CreateICheckCertainFishingItemCount(builder, _o.Type, _o.Id, _o.Compare, _o.Count);
		}

		// Token: 0x0400DC6D RID: 56429
		private Table __p;
	}
}
