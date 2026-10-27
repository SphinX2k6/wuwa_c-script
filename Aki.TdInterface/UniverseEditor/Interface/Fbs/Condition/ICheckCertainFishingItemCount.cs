using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004994 RID: 18836
	public struct ICheckCertainFishingItemCount : IFlatbufferObject
	{
		// Token: 0x17008812 RID: 34834
		// (get) Token: 0x0601D5FA RID: 120314 RVA: 0x00424070 File Offset: 0x00422270
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D5FB RID: 120315 RVA: 0x0042407D File Offset: 0x0042227D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D5FC RID: 120316 RVA: 0x00424084 File Offset: 0x00422284
		public static ICheckCertainFishingItemCount GetRootAsICheckCertainFishingItemCount(ByteBuffer _bb)
		{
			return ICheckCertainFishingItemCount.GetRootAsICheckCertainFishingItemCount(_bb, default(ICheckCertainFishingItemCount));
		}

		// Token: 0x0601D5FD RID: 120317 RVA: 0x004240A0 File Offset: 0x004222A0
		public static ICheckCertainFishingItemCount GetRootAsICheckCertainFishingItemCount(ByteBuffer _bb, ICheckCertainFishingItemCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D5FE RID: 120318 RVA: 0x004240BD File Offset: 0x004222BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D5FF RID: 120319 RVA: 0x004240CC File Offset: 0x004222CC
		public ICheckCertainFishingItemCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008813 RID: 34835
		// (get) Token: 0x0601D600 RID: 120320 RVA: 0x004240DC File Offset: 0x004222DC
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

		// Token: 0x17008814 RID: 34836
		// (get) Token: 0x0601D601 RID: 120321 RVA: 0x00424118 File Offset: 0x00422318
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

		// Token: 0x17008815 RID: 34837
		// (get) Token: 0x0601D602 RID: 120322 RVA: 0x00424154 File Offset: 0x00422354
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

		// Token: 0x17008816 RID: 34838
		// (get) Token: 0x0601D603 RID: 120323 RVA: 0x00424190 File Offset: 0x00422390
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

		// Token: 0x0601D604 RID: 120324 RVA: 0x004241CD File Offset: 0x004223CD
		public static Offset<ICheckCertainFishingItemCount> CreateICheckCertainFishingItemCount(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int Id = 0, ECompare Compare = ECompare.Eq, int Count = 0)
		{
			builder.StartTable(4);
			ICheckCertainFishingItemCount.AddCount(builder, Count);
			ICheckCertainFishingItemCount.AddId(builder, Id);
			ICheckCertainFishingItemCount.AddCompare(builder, Compare);
			ICheckCertainFishingItemCount.AddType(builder, Type);
			return ICheckCertainFishingItemCount.EndICheckCertainFishingItemCount(builder);
		}

		// Token: 0x0601D605 RID: 120325 RVA: 0x004241F9 File Offset: 0x004223F9
		public static void StartICheckCertainFishingItemCount(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D606 RID: 120326 RVA: 0x00424202 File Offset: 0x00422402
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D607 RID: 120327 RVA: 0x0042420D File Offset: 0x0042240D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601D608 RID: 120328 RVA: 0x00424218 File Offset: 0x00422418
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601D609 RID: 120329 RVA: 0x00424223 File Offset: 0x00422423
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		// Token: 0x0601D60A RID: 120330 RVA: 0x0042422E File Offset: 0x0042242E
		public static Offset<ICheckCertainFishingItemCount> EndICheckCertainFishingItemCount(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCertainFishingItemCount>(builder.EndTable());
		}

		// Token: 0x0601D60B RID: 120331 RVA: 0x0042423C File Offset: 0x0042243C
		public ICheckCertainFishingItemCountT UnPack()
		{
			ICheckCertainFishingItemCountT checkCertainFishingItemCountT = new ICheckCertainFishingItemCountT();
			this.UnPackTo(checkCertainFishingItemCountT);
			return checkCertainFishingItemCountT;
		}

		// Token: 0x0601D60C RID: 120332 RVA: 0x00424257 File Offset: 0x00422457
		public void UnPackTo(ICheckCertainFishingItemCountT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
		}

		// Token: 0x0601D60D RID: 120333 RVA: 0x0042428C File Offset: 0x0042248C
		public static Offset<ICheckCertainFishingItemCount> Pack(FlatBufferBuilder builder, ICheckCertainFishingItemCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCertainFishingItemCount>);
			}
			return ICheckCertainFishingItemCount.CreateICheckCertainFishingItemCount(builder, _o.Type, _o.Id, _o.Compare, _o.Count);
		}

		// Token: 0x0400D1A5 RID: 53669
		private Table __p;
	}
}
