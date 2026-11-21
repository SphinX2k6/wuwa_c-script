using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005613 RID: 22035
	public struct IDollGrabStandbyPoolItem : IFlatbufferObject
	{
		// Token: 0x17009E06 RID: 40454
		// (get) Token: 0x06023237 RID: 143927 RVA: 0x004D6298 File Offset: 0x004D4498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023238 RID: 143928 RVA: 0x004D62A5 File Offset: 0x004D44A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023239 RID: 143929 RVA: 0x004D62AC File Offset: 0x004D44AC
		public static IDollGrabStandbyPoolItem GetRootAsIDollGrabStandbyPoolItem(ByteBuffer _bb)
		{
			return IDollGrabStandbyPoolItem.GetRootAsIDollGrabStandbyPoolItem(_bb, default(IDollGrabStandbyPoolItem));
		}

		// Token: 0x0602323A RID: 143930 RVA: 0x004D62C8 File Offset: 0x004D44C8
		public static IDollGrabStandbyPoolItem GetRootAsIDollGrabStandbyPoolItem(ByteBuffer _bb, IDollGrabStandbyPoolItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602323B RID: 143931 RVA: 0x004D62E5 File Offset: 0x004D44E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602323C RID: 143932 RVA: 0x004D62F4 File Offset: 0x004D44F4
		public IDollGrabStandbyPoolItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E07 RID: 40455
		// (get) Token: 0x0602323D RID: 143933 RVA: 0x004D6304 File Offset: 0x004D4504
		public int UniqueId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E08 RID: 40456
		// (get) Token: 0x0602323E RID: 143934 RVA: 0x004D6340 File Offset: 0x004D4540
		public int ItemId
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

		// Token: 0x0602323F RID: 143935 RVA: 0x004D637C File Offset: 0x004D457C
		public static Offset<IDollGrabStandbyPoolItem> CreateIDollGrabStandbyPoolItem(FlatBufferBuilder builder, int UniqueId = 0, int ItemId = 0)
		{
			builder.StartTable(2);
			IDollGrabStandbyPoolItem.AddItemId(builder, ItemId);
			IDollGrabStandbyPoolItem.AddUniqueId(builder, UniqueId);
			return IDollGrabStandbyPoolItem.EndIDollGrabStandbyPoolItem(builder);
		}

		// Token: 0x06023240 RID: 143936 RVA: 0x004D6399 File Offset: 0x004D4599
		public static void StartIDollGrabStandbyPoolItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023241 RID: 143937 RVA: 0x004D63A2 File Offset: 0x004D45A2
		public static void AddUniqueId(FlatBufferBuilder builder, int uniqueId)
		{
			builder.AddInt(0, uniqueId, 0);
		}

		// Token: 0x06023242 RID: 143938 RVA: 0x004D63AD File Offset: 0x004D45AD
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x06023243 RID: 143939 RVA: 0x004D63B8 File Offset: 0x004D45B8
		public static Offset<IDollGrabStandbyPoolItem> EndIDollGrabStandbyPoolItem(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabStandbyPoolItem>(builder.EndTable());
		}

		// Token: 0x06023244 RID: 143940 RVA: 0x004D63C8 File Offset: 0x004D45C8
		public IDollGrabStandbyPoolItemT UnPack()
		{
			IDollGrabStandbyPoolItemT dollGrabStandbyPoolItemT = new IDollGrabStandbyPoolItemT();
			this.UnPackTo(dollGrabStandbyPoolItemT);
			return dollGrabStandbyPoolItemT;
		}

		// Token: 0x06023245 RID: 143941 RVA: 0x004D63E3 File Offset: 0x004D45E3
		public void UnPackTo(IDollGrabStandbyPoolItemT _o)
		{
			_o.UniqueId = this.UniqueId;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x06023246 RID: 143942 RVA: 0x004D6400 File Offset: 0x004D4600
		public static Offset<IDollGrabStandbyPoolItem> Pack(FlatBufferBuilder builder, IDollGrabStandbyPoolItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabStandbyPoolItem>);
			}
			return IDollGrabStandbyPoolItem.CreateIDollGrabStandbyPoolItem(builder, _o.UniqueId, _o.ItemId);
		}

		// Token: 0x0400ECD3 RID: 60627
		private Table __p;
	}
}
