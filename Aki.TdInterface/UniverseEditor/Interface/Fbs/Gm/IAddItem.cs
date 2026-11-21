using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A9E RID: 19102
	public struct IAddItem : IFlatbufferObject
	{
		// Token: 0x170085CB RID: 34251
		// (get) Token: 0x0601CB5C RID: 117596 RVA: 0x0040C309 File Offset: 0x0040A509
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB5D RID: 117597 RVA: 0x0040C316 File Offset: 0x0040A516
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB5E RID: 117598 RVA: 0x0040C320 File Offset: 0x0040A520
		public static IAddItem GetRootAsIAddItem(ByteBuffer _bb)
		{
			return IAddItem.GetRootAsIAddItem(_bb, default(IAddItem));
		}

		// Token: 0x0601CB5F RID: 117599 RVA: 0x0040C33C File Offset: 0x0040A53C
		public static IAddItem GetRootAsIAddItem(ByteBuffer _bb, IAddItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB60 RID: 117600 RVA: 0x0040C359 File Offset: 0x0040A559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB61 RID: 117601 RVA: 0x0040C368 File Offset: 0x0040A568
		public IAddItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085CC RID: 34252
		// (get) Token: 0x0601CB62 RID: 117602 RVA: 0x0040C378 File Offset: 0x0040A578
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085CD RID: 34253
		// (get) Token: 0x0601CB63 RID: 117603 RVA: 0x0040C3B4 File Offset: 0x0040A5B4
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

		// Token: 0x170085CE RID: 34254
		// (get) Token: 0x0601CB64 RID: 117604 RVA: 0x0040C3F0 File Offset: 0x0040A5F0
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

		// Token: 0x0601CB65 RID: 117605 RVA: 0x0040C42C File Offset: 0x0040A62C
		public static Offset<IAddItem> CreateIAddItem(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(3);
			IAddItem.AddCount(builder, Count);
			IAddItem.AddItemId(builder, ItemId);
			IAddItem.AddType(builder, Type);
			return IAddItem.EndIAddItem(builder);
		}

		// Token: 0x0601CB66 RID: 117606 RVA: 0x0040C450 File Offset: 0x0040A650
		public static void StartIAddItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CB67 RID: 117607 RVA: 0x0040C459 File Offset: 0x0040A659
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB68 RID: 117608 RVA: 0x0040C464 File Offset: 0x0040A664
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601CB69 RID: 117609 RVA: 0x0040C46F File Offset: 0x0040A66F
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x0601CB6A RID: 117610 RVA: 0x0040C47A File Offset: 0x0040A67A
		public static Offset<IAddItem> EndIAddItem(FlatBufferBuilder builder)
		{
			return new Offset<IAddItem>(builder.EndTable());
		}

		// Token: 0x0601CB6B RID: 117611 RVA: 0x0040C488 File Offset: 0x0040A688
		public IAddItemT UnPack()
		{
			IAddItemT addItemT = new IAddItemT();
			this.UnPackTo(addItemT);
			return addItemT;
		}

		// Token: 0x0601CB6C RID: 117612 RVA: 0x0040C4A3 File Offset: 0x0040A6A3
		public void UnPackTo(IAddItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0601CB6D RID: 117613 RVA: 0x0040C4CC File Offset: 0x0040A6CC
		public static Offset<IAddItem> Pack(FlatBufferBuilder builder, IAddItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddItem>);
			}
			return IAddItem.CreateIAddItem(builder, _o.Type, _o.ItemId, _o.Count);
		}

		// Token: 0x0400D1DB RID: 53723
		private Table __p;
	}
}
