using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E90 RID: 16016
	public struct IHandInItems : IFlatbufferObject
	{
		// Token: 0x17006F21 RID: 28449
		// (get) Token: 0x0601697A RID: 92538 RVA: 0x003437DB File Offset: 0x003419DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601697B RID: 92539 RVA: 0x003437E8 File Offset: 0x003419E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601697C RID: 92540 RVA: 0x003437F0 File Offset: 0x003419F0
		public static IHandInItems GetRootAsIHandInItems(ByteBuffer _bb)
		{
			return IHandInItems.GetRootAsIHandInItems(_bb, default(IHandInItems));
		}

		// Token: 0x0601697D RID: 92541 RVA: 0x0034380C File Offset: 0x00341A0C
		public static IHandInItems GetRootAsIHandInItems(ByteBuffer _bb, IHandInItems obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601697E RID: 92542 RVA: 0x00343829 File Offset: 0x00341A29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601697F RID: 92543 RVA: 0x00343838 File Offset: 0x00341A38
		public IHandInItems __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06016980 RID: 92544 RVA: 0x00343848 File Offset: 0x00341A48
		public IHandInItem? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IHandInItem?(default(IHandInItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006F22 RID: 28450
		// (get) Token: 0x06016981 RID: 92545 RVA: 0x003438A8 File Offset: 0x00341AA8
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006F23 RID: 28451
		// (get) Token: 0x06016982 RID: 92546 RVA: 0x003438D4 File Offset: 0x00341AD4
		public IHandInGroup? GroupConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHandInGroup?(default(IHandInGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006F24 RID: 28452
		// (get) Token: 0x06016983 RID: 92547 RVA: 0x00343934 File Offset: 0x00341B34
		public string TidTitleText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016984 RID: 92548 RVA: 0x0034396B File Offset: 0x00341B6B
		public Span<byte> GetTidTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016985 RID: 92549 RVA: 0x0034397A File Offset: 0x00341B7A
		public byte[] GetTidTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006F25 RID: 28453
		// (get) Token: 0x06016986 RID: 92550 RVA: 0x00343988 File Offset: 0x00341B88
		public string TidDescText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016987 RID: 92551 RVA: 0x003439C0 File Offset: 0x00341BC0
		public Span<byte> GetTidDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06016988 RID: 92552 RVA: 0x003439D0 File Offset: 0x00341BD0
		public byte[] GetTidDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17006F26 RID: 28454
		// (get) Token: 0x06016989 RID: 92553 RVA: 0x003439E0 File Offset: 0x00341BE0
		public bool RepeatItems
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006F27 RID: 28455
		// (get) Token: 0x0601698A RID: 92554 RVA: 0x00343A20 File Offset: 0x00341C20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601698B RID: 92555 RVA: 0x00343A5D File Offset: 0x00341C5D
		public static Offset<IHandInItems> CreateIHandInItems(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset), Offset<IHandInGroup> GroupConfigOffset = default(Offset<IHandInGroup>), StringOffset TidTitleTextOffset = default(StringOffset), StringOffset TidDescTextOffset = default(StringOffset), bool RepeatItems = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IHandInItems.AddTidDescText(builder, TidDescTextOffset);
			IHandInItems.AddTidTitleText(builder, TidTitleTextOffset);
			IHandInItems.AddGroupConfig(builder, GroupConfigOffset);
			IHandInItems.AddItems(builder, ItemsOffset);
			IHandInItems.AddNullMask(builder, NullMask);
			IHandInItems.AddRepeatItems(builder, RepeatItems);
			return IHandInItems.EndIHandInItems(builder);
		}

		// Token: 0x0601698C RID: 92556 RVA: 0x00343A99 File Offset: 0x00341C99
		public static void StartIHandInItems(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601698D RID: 92557 RVA: 0x00343AA2 File Offset: 0x00341CA2
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0601698E RID: 92558 RVA: 0x00343AB4 File Offset: 0x00341CB4
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IHandInItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601698F RID: 92559 RVA: 0x00343AF4 File Offset: 0x00341CF4
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IHandInItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHandInItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016990 RID: 92560 RVA: 0x00343B0E File Offset: 0x00341D0E
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHandInItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHandInItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016991 RID: 92561 RVA: 0x00343B2C File Offset: 0x00341D2C
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHandInItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016992 RID: 92562 RVA: 0x00343B45 File Offset: 0x00341D45
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016993 RID: 92563 RVA: 0x00343B50 File Offset: 0x00341D50
		public static void AddGroupConfig(FlatBufferBuilder builder, Offset<IHandInGroup> groupConfigOffset)
		{
			builder.AddOffset(1, groupConfigOffset.Value, 0);
		}

		// Token: 0x06016994 RID: 92564 RVA: 0x00343B60 File Offset: 0x00341D60
		public static void AddTidTitleText(FlatBufferBuilder builder, StringOffset tidTitleTextOffset)
		{
			builder.AddOffset(2, tidTitleTextOffset.Value, 0);
		}

		// Token: 0x06016995 RID: 92565 RVA: 0x00343B70 File Offset: 0x00341D70
		public static void AddTidDescText(FlatBufferBuilder builder, StringOffset tidDescTextOffset)
		{
			builder.AddOffset(3, tidDescTextOffset.Value, 0);
		}

		// Token: 0x06016996 RID: 92566 RVA: 0x00343B80 File Offset: 0x00341D80
		public static void AddRepeatItems(FlatBufferBuilder builder, bool repeatItems)
		{
			builder.AddBool(4, repeatItems, false);
		}

		// Token: 0x06016997 RID: 92567 RVA: 0x00343B8B File Offset: 0x00341D8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06016998 RID: 92568 RVA: 0x00343B96 File Offset: 0x00341D96
		public static Offset<IHandInItems> EndIHandInItems(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItems>(builder.EndTable());
		}

		// Token: 0x06016999 RID: 92569 RVA: 0x00343BA4 File Offset: 0x00341DA4
		public IHandInItemsT UnPack()
		{
			IHandInItemsT handInItemsT = new IHandInItemsT();
			this.UnPackTo(handInItemsT);
			return handInItemsT;
		}

		// Token: 0x0601699A RID: 92570 RVA: 0x00343BC0 File Offset: 0x00341DC0
		public void UnPackTo(IHandInItemsT _o)
		{
			_o.Items = new List<IHandInItemT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
			_o.GroupConfig = ((this.GroupConfig != null) ? this.GroupConfig.Value.UnPack() : null);
			_o.TidTitleText = this.TidTitleText;
			_o.TidDescText = this.TidDescText;
			_o.RepeatItems = this.RepeatItems;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601699B RID: 92571 RVA: 0x00343C80 File Offset: 0x00341E80
		public static Offset<IHandInItems> Pack(FlatBufferBuilder builder, IHandInItemsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItems>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IHandInItem>[] array = new Offset<IHandInItem>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IHandInItem.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IHandInItems.CreateItemsVector(builder, array);
			}
			Offset<IHandInGroup> groupConfigOffset = (_o.GroupConfig == null) ? default(Offset<IHandInGroup>) : IHandInGroup.Pack(builder, _o.GroupConfig);
			StringOffset tidTitleTextOffset = (_o.TidTitleText == null) ? default(StringOffset) : builder.CreateString(_o.TidTitleText);
			StringOffset tidDescTextOffset = (_o.TidDescText == null) ? default(StringOffset) : builder.CreateString(_o.TidDescText);
			return IHandInItems.CreateIHandInItems(builder, itemsOffset, groupConfigOffset, tidTitleTextOffset, tidDescTextOffset, _o.RepeatItems, _o.NullMask);
		}

		// Token: 0x0400B850 RID: 47184
		private Table __p;
	}
}
