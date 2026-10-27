using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C49 RID: 19529
	public struct IItemConfig : IFlatbufferObject
	{
		// Token: 0x17008DE1 RID: 36321
		// (get) Token: 0x0601EF53 RID: 126803 RVA: 0x00454AC8 File Offset: 0x00452CC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF54 RID: 126804 RVA: 0x00454AD5 File Offset: 0x00452CD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF55 RID: 126805 RVA: 0x00454ADC File Offset: 0x00452CDC
		public static IItemConfig GetRootAsIItemConfig(ByteBuffer _bb)
		{
			return IItemConfig.GetRootAsIItemConfig(_bb, default(IItemConfig));
		}

		// Token: 0x0601EF56 RID: 126806 RVA: 0x00454AF8 File Offset: 0x00452CF8
		public static IItemConfig GetRootAsIItemConfig(ByteBuffer _bb, IItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF57 RID: 126807 RVA: 0x00454B15 File Offset: 0x00452D15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF58 RID: 126808 RVA: 0x00454B24 File Offset: 0x00452D24
		public IItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DE2 RID: 36322
		// (get) Token: 0x0601EF59 RID: 126809 RVA: 0x00454B34 File Offset: 0x00452D34
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

		// Token: 0x17008DE3 RID: 36323
		// (get) Token: 0x0601EF5A RID: 126810 RVA: 0x00454B70 File Offset: 0x00452D70
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

		// Token: 0x0601EF5B RID: 126811 RVA: 0x00454BAC File Offset: 0x00452DAC
		public static Offset<IItemConfig> CreateIItemConfig(FlatBufferBuilder builder, int ItemId = 0, int Count = 0)
		{
			builder.StartTable(2);
			IItemConfig.AddCount(builder, Count);
			IItemConfig.AddItemId(builder, ItemId);
			return IItemConfig.EndIItemConfig(builder);
		}

		// Token: 0x0601EF5C RID: 126812 RVA: 0x00454BC9 File Offset: 0x00452DC9
		public static void StartIItemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EF5D RID: 126813 RVA: 0x00454BD2 File Offset: 0x00452DD2
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0601EF5E RID: 126814 RVA: 0x00454BDD File Offset: 0x00452DDD
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0601EF5F RID: 126815 RVA: 0x00454BE8 File Offset: 0x00452DE8
		public static Offset<IItemConfig> EndIItemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IItemConfig>(builder.EndTable());
		}

		// Token: 0x0601EF60 RID: 126816 RVA: 0x00454BF8 File Offset: 0x00452DF8
		public IItemConfigT UnPack()
		{
			IItemConfigT itemConfigT = new IItemConfigT();
			this.UnPackTo(itemConfigT);
			return itemConfigT;
		}

		// Token: 0x0601EF61 RID: 126817 RVA: 0x00454C13 File Offset: 0x00452E13
		public void UnPackTo(IItemConfigT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
		}

		// Token: 0x0601EF62 RID: 126818 RVA: 0x00454C30 File Offset: 0x00452E30
		public static Offset<IItemConfig> Pack(FlatBufferBuilder builder, IItemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemConfig>);
			}
			return IItemConfig.CreateIItemConfig(builder, _o.ItemId, _o.Count);
		}

		// Token: 0x0400D5F0 RID: 54768
		private Table __p;
	}
}
