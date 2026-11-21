using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005139 RID: 20793
	public struct IItemCondition : IFlatbufferObject
	{
		// Token: 0x17009505 RID: 38149
		// (get) Token: 0x06020B3B RID: 133947 RVA: 0x00487FF6 File Offset: 0x004861F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B3C RID: 133948 RVA: 0x00488003 File Offset: 0x00486203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B3D RID: 133949 RVA: 0x0048800C File Offset: 0x0048620C
		public static IItemCondition GetRootAsIItemCondition(ByteBuffer _bb)
		{
			return IItemCondition.GetRootAsIItemCondition(_bb, default(IItemCondition));
		}

		// Token: 0x06020B3E RID: 133950 RVA: 0x00488028 File Offset: 0x00486228
		public static IItemCondition GetRootAsIItemCondition(ByteBuffer _bb, IItemCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B3F RID: 133951 RVA: 0x00488045 File Offset: 0x00486245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B40 RID: 133952 RVA: 0x00488054 File Offset: 0x00486254
		public IItemCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009506 RID: 38150
		// (get) Token: 0x06020B41 RID: 133953 RVA: 0x00488064 File Offset: 0x00486264
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

		// Token: 0x06020B42 RID: 133954 RVA: 0x004880A0 File Offset: 0x004862A0
		public IItemConfig? Items(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009507 RID: 38151
		// (get) Token: 0x06020B43 RID: 133955 RVA: 0x00488100 File Offset: 0x00486300
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

		// Token: 0x06020B44 RID: 133956 RVA: 0x0048812B File Offset: 0x0048632B
		public static Offset<IItemCondition> CreateIItemCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IItemCondition.AddItems(builder, ItemsOffset);
			IItemCondition.AddType(builder, Type);
			return IItemCondition.EndIItemCondition(builder);
		}

		// Token: 0x06020B45 RID: 133957 RVA: 0x00488148 File Offset: 0x00486348
		public static void StartIItemCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B46 RID: 133958 RVA: 0x00488151 File Offset: 0x00486351
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020B47 RID: 133959 RVA: 0x0048815C File Offset: 0x0048635C
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(1, itemsOffset.Value, 0);
		}

		// Token: 0x06020B48 RID: 133960 RVA: 0x0048816C File Offset: 0x0048636C
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020B49 RID: 133961 RVA: 0x004881AC File Offset: 0x004863AC
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020B4A RID: 133962 RVA: 0x004881C6 File Offset: 0x004863C6
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020B4B RID: 133963 RVA: 0x004881E4 File Offset: 0x004863E4
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020B4C RID: 133964 RVA: 0x004881FD File Offset: 0x004863FD
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020B4D RID: 133965 RVA: 0x00488208 File Offset: 0x00486408
		public static Offset<IItemCondition> EndIItemCondition(FlatBufferBuilder builder)
		{
			return new Offset<IItemCondition>(builder.EndTable());
		}

		// Token: 0x06020B4E RID: 133966 RVA: 0x00488218 File Offset: 0x00486418
		public IItemConditionT UnPack()
		{
			IItemConditionT itemConditionT = new IItemConditionT();
			this.UnPackTo(itemConditionT);
			return itemConditionT;
		}

		// Token: 0x06020B4F RID: 133967 RVA: 0x00488234 File Offset: 0x00486434
		public void UnPackTo(IItemConditionT _o)
		{
			_o.Type = this.Type;
			_o.Items = new List<IItemConfigT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020B50 RID: 133968 RVA: 0x004882A0 File Offset: 0x004864A0
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

		// Token: 0x0400E10C RID: 57612
		private Table __p;
	}
}
