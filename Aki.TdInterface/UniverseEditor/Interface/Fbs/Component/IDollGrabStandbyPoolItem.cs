using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050AE RID: 20654
	public struct IDollGrabStandbyPoolItem : IFlatbufferObject
	{
		// Token: 0x17009619 RID: 38425
		// (get) Token: 0x060212E3 RID: 135907 RVA: 0x0049C30C File Offset: 0x0049A50C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060212E4 RID: 135908 RVA: 0x0049C319 File Offset: 0x0049A519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060212E5 RID: 135909 RVA: 0x0049C320 File Offset: 0x0049A520
		public static IDollGrabStandbyPoolItem GetRootAsIDollGrabStandbyPoolItem(ByteBuffer _bb)
		{
			return IDollGrabStandbyPoolItem.GetRootAsIDollGrabStandbyPoolItem(_bb, default(IDollGrabStandbyPoolItem));
		}

		// Token: 0x060212E6 RID: 135910 RVA: 0x0049C33C File Offset: 0x0049A53C
		public static IDollGrabStandbyPoolItem GetRootAsIDollGrabStandbyPoolItem(ByteBuffer _bb, IDollGrabStandbyPoolItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060212E7 RID: 135911 RVA: 0x0049C359 File Offset: 0x0049A559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060212E8 RID: 135912 RVA: 0x0049C368 File Offset: 0x0049A568
		public IDollGrabStandbyPoolItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700961A RID: 38426
		// (get) Token: 0x060212E9 RID: 135913 RVA: 0x0049C378 File Offset: 0x0049A578
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

		// Token: 0x1700961B RID: 38427
		// (get) Token: 0x060212EA RID: 135914 RVA: 0x0049C3B4 File Offset: 0x0049A5B4
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

		// Token: 0x060212EB RID: 135915 RVA: 0x0049C3F0 File Offset: 0x0049A5F0
		public static Offset<IDollGrabStandbyPoolItem> CreateIDollGrabStandbyPoolItem(FlatBufferBuilder builder, int UniqueId = 0, int ItemId = 0)
		{
			builder.StartTable(2);
			IDollGrabStandbyPoolItem.AddItemId(builder, ItemId);
			IDollGrabStandbyPoolItem.AddUniqueId(builder, UniqueId);
			return IDollGrabStandbyPoolItem.EndIDollGrabStandbyPoolItem(builder);
		}

		// Token: 0x060212EC RID: 135916 RVA: 0x0049C40D File Offset: 0x0049A60D
		public static void StartIDollGrabStandbyPoolItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060212ED RID: 135917 RVA: 0x0049C416 File Offset: 0x0049A616
		public static void AddUniqueId(FlatBufferBuilder builder, int uniqueId)
		{
			builder.AddInt(0, uniqueId, 0);
		}

		// Token: 0x060212EE RID: 135918 RVA: 0x0049C421 File Offset: 0x0049A621
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x060212EF RID: 135919 RVA: 0x0049C42C File Offset: 0x0049A62C
		public static Offset<IDollGrabStandbyPoolItem> EndIDollGrabStandbyPoolItem(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabStandbyPoolItem>(builder.EndTable());
		}

		// Token: 0x060212F0 RID: 135920 RVA: 0x0049C43C File Offset: 0x0049A63C
		public IDollGrabStandbyPoolItemT UnPack()
		{
			IDollGrabStandbyPoolItemT dollGrabStandbyPoolItemT = new IDollGrabStandbyPoolItemT();
			this.UnPackTo(dollGrabStandbyPoolItemT);
			return dollGrabStandbyPoolItemT;
		}

		// Token: 0x060212F1 RID: 135921 RVA: 0x0049C457 File Offset: 0x0049A657
		public void UnPackTo(IDollGrabStandbyPoolItemT _o)
		{
			_o.UniqueId = this.UniqueId;
			_o.ItemId = this.ItemId;
		}

		// Token: 0x060212F2 RID: 135922 RVA: 0x0049C474 File Offset: 0x0049A674
		public static Offset<IDollGrabStandbyPoolItem> Pack(FlatBufferBuilder builder, IDollGrabStandbyPoolItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabStandbyPoolItem>);
			}
			return IDollGrabStandbyPoolItem.CreateIDollGrabStandbyPoolItem(builder, _o.UniqueId, _o.ItemId);
		}

		// Token: 0x0400E0D6 RID: 57558
		private Table __p;
	}
}
