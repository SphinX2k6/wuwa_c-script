using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200513C RID: 20796
	public struct IItemConfig : IFlatbufferObject
	{
		// Token: 0x1700950A RID: 38154
		// (get) Token: 0x06020B57 RID: 133975 RVA: 0x004883A4 File Offset: 0x004865A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B58 RID: 133976 RVA: 0x004883B1 File Offset: 0x004865B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B59 RID: 133977 RVA: 0x004883B8 File Offset: 0x004865B8
		public static IItemConfig GetRootAsIItemConfig(ByteBuffer _bb)
		{
			return IItemConfig.GetRootAsIItemConfig(_bb, default(IItemConfig));
		}

		// Token: 0x06020B5A RID: 133978 RVA: 0x004883D4 File Offset: 0x004865D4
		public static IItemConfig GetRootAsIItemConfig(ByteBuffer _bb, IItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B5B RID: 133979 RVA: 0x004883F1 File Offset: 0x004865F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B5C RID: 133980 RVA: 0x00488400 File Offset: 0x00486600
		public IItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700950B RID: 38155
		// (get) Token: 0x06020B5D RID: 133981 RVA: 0x00488410 File Offset: 0x00486610
		public int ItemId
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

		// Token: 0x1700950C RID: 38156
		// (get) Token: 0x06020B5E RID: 133982 RVA: 0x0048844C File Offset: 0x0048664C
		public int Count
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

		// Token: 0x06020B5F RID: 133983 RVA: 0x00488488 File Offset: 0x00486688
		public static Offset<IItemConfig> CreateIItemConfig(FlatBufferBuilder builder, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(2);
			IItemConfig.AddCount(builder, Count);
			IItemConfig.AddItemId(builder, ItemId);
			return IItemConfig.EndIItemConfig(builder);
		}

		// Token: 0x06020B60 RID: 133984 RVA: 0x004884A5 File Offset: 0x004866A5
		public static void StartIItemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B61 RID: 133985 RVA: 0x004884AE File Offset: 0x004866AE
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x06020B62 RID: 133986 RVA: 0x004884B9 File Offset: 0x004866B9
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06020B63 RID: 133987 RVA: 0x004884C4 File Offset: 0x004866C4
		public static Offset<IItemConfig> EndIItemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IItemConfig>(builder.EndTable());
		}

		// Token: 0x06020B64 RID: 133988 RVA: 0x004884D4 File Offset: 0x004866D4
		public IItemConfigT UnPack()
		{
			IItemConfigT itemConfigT = new IItemConfigT();
			this.UnPackTo(itemConfigT);
			return itemConfigT;
		}

		// Token: 0x06020B65 RID: 133989 RVA: 0x004884EF File Offset: 0x004866EF
		public void UnPackTo(IItemConfigT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x06020B66 RID: 133990 RVA: 0x0048850C File Offset: 0x0048670C
		public static Offset<IItemConfig> Pack(FlatBufferBuilder builder, IItemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemConfig>);
			}
			return IItemConfig.CreateIItemConfig(builder, _o.ItemId, _o.Count);
		}

		// Token: 0x0400E10F RID: 57615
		private Table __p;
	}
}
