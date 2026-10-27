using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C46 RID: 19526
	public struct IItemCondition : IFlatbufferObject
	{
		// Token: 0x17008DDC RID: 36316
		// (get) Token: 0x0601EF37 RID: 126775 RVA: 0x0045471A File Offset: 0x0045291A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF38 RID: 126776 RVA: 0x00454727 File Offset: 0x00452927
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF39 RID: 126777 RVA: 0x00454730 File Offset: 0x00452930
		public static IItemCondition GetRootAsIItemCondition(ByteBuffer _bb)
		{
			return IItemCondition.GetRootAsIItemCondition(_bb, default(IItemCondition));
		}

		// Token: 0x0601EF3A RID: 126778 RVA: 0x0045474C File Offset: 0x0045294C
		public static IItemCondition GetRootAsIItemCondition(ByteBuffer _bb, IItemCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF3B RID: 126779 RVA: 0x00454769 File Offset: 0x00452969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF3C RID: 126780 RVA: 0x00454778 File Offset: 0x00452978
		public IItemCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DDD RID: 36317
		// (get) Token: 0x0601EF3D RID: 126781 RVA: 0x00454788 File Offset: 0x00452988
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF3E RID: 126782 RVA: 0x004547C4 File Offset: 0x004529C4
		public IItemConfig? Items(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008DDE RID: 36318
		// (get) Token: 0x0601EF3F RID: 126783 RVA: 0x00454824 File Offset: 0x00452A24
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601EF40 RID: 126784 RVA: 0x0045484F File Offset: 0x00452A4F
		public static Offset<IItemCondition> CreateIItemCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IItemCondition.AddItems(builder, ItemsOffset);
			IItemCondition.AddType(builder, Type);
			return IItemCondition.EndIItemCondition(builder);
		}

		// Token: 0x0601EF41 RID: 126785 RVA: 0x0045486C File Offset: 0x00452A6C
		public static void StartIItemCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EF42 RID: 126786 RVA: 0x00454875 File Offset: 0x00452A75
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF43 RID: 126787 RVA: 0x00454880 File Offset: 0x00452A80
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(1, itemsOffset.Value, 0);
		}

		// Token: 0x0601EF44 RID: 126788 RVA: 0x00454890 File Offset: 0x00452A90
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EF45 RID: 126789 RVA: 0x004548D0 File Offset: 0x00452AD0
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EF46 RID: 126790 RVA: 0x004548EA File Offset: 0x00452AEA
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EF47 RID: 126791 RVA: 0x00454908 File Offset: 0x00452B08
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EF48 RID: 126792 RVA: 0x00454921 File Offset: 0x00452B21
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EF49 RID: 126793 RVA: 0x0045492C File Offset: 0x00452B2C
		public static Offset<IItemCondition> EndIItemCondition(FlatBufferBuilder builder)
		{
			return new Offset<IItemCondition>(builder.EndTable());
		}

		// Token: 0x0601EF4A RID: 126794 RVA: 0x0045493C File Offset: 0x00452B3C
		public IItemConditionT UnPack()
		{
			IItemConditionT itemConditionT = new IItemConditionT();
			this.UnPackTo(itemConditionT);
			return itemConditionT;
		}

		// Token: 0x0601EF4B RID: 126795 RVA: 0x00454958 File Offset: 0x00452B58
		public void UnPackTo(IItemConditionT _o)
		{
			_o.Type = this.Type;
			_o.Items = new List<IItemConfigT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601EF4C RID: 126796 RVA: 0x004549C4 File Offset: 0x00452BC4
		public static Offset<IItemCondition> Pack(FlatBufferBuilder builder, IItemConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemCondition>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IItemConfig>[] array = new Offset<IItemConfig>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IItemConfig.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IItemCondition.CreateItemsVector(builder, array);
			}
			return IItemCondition.CreateIItemCondition(builder, _o.Type, itemsOffset);
		}

		// Token: 0x0400D5ED RID: 54765
		private Table __p;
	}
}
