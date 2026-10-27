using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004636 RID: 17974
	public struct IAddItem : IFlatbufferObject
	{
		// Token: 0x17007F8A RID: 32650
		// (get) Token: 0x0601B387 RID: 111495 RVA: 0x003E006D File Offset: 0x003DE26D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B388 RID: 111496 RVA: 0x003E007A File Offset: 0x003DE27A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B389 RID: 111497 RVA: 0x003E0084 File Offset: 0x003DE284
		public static IAddItem GetRootAsIAddItem(ByteBuffer _bb)
		{
			return IAddItem.GetRootAsIAddItem(_bb, default(IAddItem));
		}

		// Token: 0x0601B38A RID: 111498 RVA: 0x003E00A0 File Offset: 0x003DE2A0
		public static IAddItem GetRootAsIAddItem(ByteBuffer _bb, IAddItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B38B RID: 111499 RVA: 0x003E00BD File Offset: 0x003DE2BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B38C RID: 111500 RVA: 0x003E00CC File Offset: 0x003DE2CC
		public IAddItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F8B RID: 32651
		// (get) Token: 0x0601B38D RID: 111501 RVA: 0x003E00DC File Offset: 0x003DE2DC
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

		// Token: 0x17007F8C RID: 32652
		// (get) Token: 0x0601B38E RID: 111502 RVA: 0x003E0118 File Offset: 0x003DE318
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

		// Token: 0x17007F8D RID: 32653
		// (get) Token: 0x0601B38F RID: 111503 RVA: 0x003E0154 File Offset: 0x003DE354
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

		// Token: 0x0601B390 RID: 111504 RVA: 0x003E0190 File Offset: 0x003DE390
		public static Offset<IAddItem> CreateIAddItem(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(3);
			IAddItem.AddCount(builder, Count);
			IAddItem.AddItemId(builder, ItemId);
			IAddItem.AddType(builder, Type);
			return IAddItem.EndIAddItem(builder);
		}

		// Token: 0x0601B391 RID: 111505 RVA: 0x003E01B4 File Offset: 0x003DE3B4
		public static void StartIAddItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B392 RID: 111506 RVA: 0x003E01BD File Offset: 0x003DE3BD
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B393 RID: 111507 RVA: 0x003E01C8 File Offset: 0x003DE3C8
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x0601B394 RID: 111508 RVA: 0x003E01D3 File Offset: 0x003DE3D3
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x0601B395 RID: 111509 RVA: 0x003E01DE File Offset: 0x003DE3DE
		public static Offset<IAddItem> EndIAddItem(FlatBufferBuilder builder)
		{
			return new Offset<IAddItem>(builder.EndTable());
		}

		// Token: 0x0601B396 RID: 111510 RVA: 0x003E01EC File Offset: 0x003DE3EC
		public IAddItemT UnPack()
		{
			IAddItemT addItemT = new IAddItemT();
			this.UnPackTo(addItemT);
			return addItemT;
		}

		// Token: 0x0601B397 RID: 111511 RVA: 0x003E0207 File Offset: 0x003DE407
		public void UnPackTo(IAddItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0601B398 RID: 111512 RVA: 0x003E0230 File Offset: 0x003DE430
		public static Offset<IAddItem> Pack(FlatBufferBuilder builder, IAddItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddItem>);
			}
			return IAddItem.CreateIAddItem(builder, _o.Type, _o.ItemId, _o.Count);
		}

		// Token: 0x0400C7AC RID: 51116
		private Table __p;
	}
}
