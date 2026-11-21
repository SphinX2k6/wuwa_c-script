using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E3F RID: 20031
	public struct ICheckAvailableSunSpiritCount : IFlatbufferObject
	{
		// Token: 0x17008EAF RID: 36527
		// (get) Token: 0x0601EFB3 RID: 126899 RVA: 0x00453A5C File Offset: 0x00451C5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFB4 RID: 126900 RVA: 0x00453A69 File Offset: 0x00451C69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFB5 RID: 126901 RVA: 0x00453A70 File Offset: 0x00451C70
		public static ICheckAvailableSunSpiritCount GetRootAsICheckAvailableSunSpiritCount(ByteBuffer _bb)
		{
			return ICheckAvailableSunSpiritCount.GetRootAsICheckAvailableSunSpiritCount(_bb, default(ICheckAvailableSunSpiritCount));
		}

		// Token: 0x0601EFB6 RID: 126902 RVA: 0x00453A8C File Offset: 0x00451C8C
		public static ICheckAvailableSunSpiritCount GetRootAsICheckAvailableSunSpiritCount(ByteBuffer _bb, ICheckAvailableSunSpiritCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFB7 RID: 126903 RVA: 0x00453AA9 File Offset: 0x00451CA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFB8 RID: 126904 RVA: 0x00453AB8 File Offset: 0x00451CB8
		public ICheckAvailableSunSpiritCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EB0 RID: 36528
		// (get) Token: 0x0601EFB9 RID: 126905 RVA: 0x00453AC8 File Offset: 0x00451CC8
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

		// Token: 0x17008EB1 RID: 36529
		// (get) Token: 0x0601EFBA RID: 126906 RVA: 0x00453B04 File Offset: 0x00451D04
		public int AreaId
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

		// Token: 0x17008EB2 RID: 36530
		// (get) Token: 0x0601EFBB RID: 126907 RVA: 0x00453B40 File Offset: 0x00451D40
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

		// Token: 0x17008EB3 RID: 36531
		// (get) Token: 0x0601EFBC RID: 126908 RVA: 0x00453B7C File Offset: 0x00451D7C
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

		// Token: 0x0601EFBD RID: 126909 RVA: 0x00453BB9 File Offset: 0x00451DB9
		public static Offset<ICheckAvailableSunSpiritCount> CreateICheckAvailableSunSpiritCount(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AreaId = 0, ECompare Compare = ECompare.Eq, int Count = 0)
		{
			builder.StartTable(4);
			ICheckAvailableSunSpiritCount.AddCount(builder, Count);
			ICheckAvailableSunSpiritCount.AddAreaId(builder, AreaId);
			ICheckAvailableSunSpiritCount.AddCompare(builder, Compare);
			ICheckAvailableSunSpiritCount.AddType(builder, Type);
			return ICheckAvailableSunSpiritCount.EndICheckAvailableSunSpiritCount(builder);
		}

		// Token: 0x0601EFBE RID: 126910 RVA: 0x00453BE5 File Offset: 0x00451DE5
		public static void StartICheckAvailableSunSpiritCount(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EFBF RID: 126911 RVA: 0x00453BEE File Offset: 0x00451DEE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFC0 RID: 126912 RVA: 0x00453BF9 File Offset: 0x00451DF9
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601EFC1 RID: 126913 RVA: 0x00453C04 File Offset: 0x00451E04
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601EFC2 RID: 126914 RVA: 0x00453C0F File Offset: 0x00451E0F
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		// Token: 0x0601EFC3 RID: 126915 RVA: 0x00453C1A File Offset: 0x00451E1A
		public static Offset<ICheckAvailableSunSpiritCount> EndICheckAvailableSunSpiritCount(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAvailableSunSpiritCount>(builder.EndTable());
		}

		// Token: 0x0601EFC4 RID: 126916 RVA: 0x00453C28 File Offset: 0x00451E28
		public ICheckAvailableSunSpiritCountT UnPack()
		{
			ICheckAvailableSunSpiritCountT checkAvailableSunSpiritCountT = new ICheckAvailableSunSpiritCountT();
			this.UnPackTo(checkAvailableSunSpiritCountT);
			return checkAvailableSunSpiritCountT;
		}

		// Token: 0x0601EFC5 RID: 126917 RVA: 0x00453C43 File Offset: 0x00451E43
		public void UnPackTo(ICheckAvailableSunSpiritCountT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
		}

		// Token: 0x0601EFC6 RID: 126918 RVA: 0x00453C78 File Offset: 0x00451E78
		public static Offset<ICheckAvailableSunSpiritCount> Pack(FlatBufferBuilder builder, ICheckAvailableSunSpiritCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAvailableSunSpiritCount>);
			}
			return ICheckAvailableSunSpiritCount.CreateICheckAvailableSunSpiritCount(builder, _o.Type, _o.AreaId, _o.Compare, _o.Count);
		}

		// Token: 0x0400DC5C RID: 56412
		private Table __p;
	}
}
