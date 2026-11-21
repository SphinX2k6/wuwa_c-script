using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CB RID: 17099
	public struct IHandInItems : IFlatbufferObject
	{
		// Token: 0x17007509 RID: 29961
		// (get) Token: 0x06017FB1 RID: 98225 RVA: 0x0036C55F File Offset: 0x0036A75F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017FB2 RID: 98226 RVA: 0x0036C56C File Offset: 0x0036A76C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017FB3 RID: 98227 RVA: 0x0036C574 File Offset: 0x0036A774
		public static IHandInItems GetRootAsIHandInItems(ByteBuffer _bb)
		{
			return IHandInItems.GetRootAsIHandInItems(_bb, default(IHandInItems));
		}

		// Token: 0x06017FB4 RID: 98228 RVA: 0x0036C590 File Offset: 0x0036A790
		public static IHandInItems GetRootAsIHandInItems(ByteBuffer _bb, IHandInItems obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017FB5 RID: 98229 RVA: 0x0036C5AD File Offset: 0x0036A7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017FB6 RID: 98230 RVA: 0x0036C5BC File Offset: 0x0036A7BC
		public IHandInItems __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06017FB7 RID: 98231 RVA: 0x0036C5CC File Offset: 0x0036A7CC
		public IHandInItem? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IHandInItem?(default(IHandInItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700750A RID: 29962
		// (get) Token: 0x06017FB8 RID: 98232 RVA: 0x0036C62C File Offset: 0x0036A82C
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

		// Token: 0x1700750B RID: 29963
		// (get) Token: 0x06017FB9 RID: 98233 RVA: 0x0036C658 File Offset: 0x0036A858
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

		// Token: 0x1700750C RID: 29964
		// (get) Token: 0x06017FBA RID: 98234 RVA: 0x0036C6B8 File Offset: 0x0036A8B8
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

		// Token: 0x06017FBB RID: 98235 RVA: 0x0036C6EF File Offset: 0x0036A8EF
		public Span<byte> GetTidTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06017FBC RID: 98236 RVA: 0x0036C6FE File Offset: 0x0036A8FE
		public byte[] GetTidTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700750D RID: 29965
		// (get) Token: 0x06017FBD RID: 98237 RVA: 0x0036C70C File Offset: 0x0036A90C
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

		// Token: 0x06017FBE RID: 98238 RVA: 0x0036C744 File Offset: 0x0036A944
		public Span<byte> GetTidDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06017FBF RID: 98239 RVA: 0x0036C754 File Offset: 0x0036A954
		public byte[] GetTidDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700750E RID: 29966
		// (get) Token: 0x06017FC0 RID: 98240 RVA: 0x0036C764 File Offset: 0x0036A964
		public bool RepeatItems
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700750F RID: 29967
		// (get) Token: 0x06017FC1 RID: 98241 RVA: 0x0036C7A4 File Offset: 0x0036A9A4
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

		// Token: 0x06017FC2 RID: 98242 RVA: 0x0036C7E1 File Offset: 0x0036A9E1
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

		// Token: 0x06017FC3 RID: 98243 RVA: 0x0036C81D File Offset: 0x0036AA1D
		public static void StartIHandInItems(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017FC4 RID: 98244 RVA: 0x0036C826 File Offset: 0x0036AA26
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x06017FC5 RID: 98245 RVA: 0x0036C838 File Offset: 0x0036AA38
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IHandInItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017FC6 RID: 98246 RVA: 0x0036C878 File Offset: 0x0036AA78
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IHandInItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHandInItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FC7 RID: 98247 RVA: 0x0036C892 File Offset: 0x0036AA92
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHandInItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHandInItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FC8 RID: 98248 RVA: 0x0036C8B0 File Offset: 0x0036AAB0
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHandInItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017FC9 RID: 98249 RVA: 0x0036C8C9 File Offset: 0x0036AAC9
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017FCA RID: 98250 RVA: 0x0036C8D4 File Offset: 0x0036AAD4
		public static void AddGroupConfig(FlatBufferBuilder builder, Offset<IHandInGroup> groupConfigOffset)
		{
			builder.AddOffset(1, groupConfigOffset.Value, 0);
		}

		// Token: 0x06017FCB RID: 98251 RVA: 0x0036C8E4 File Offset: 0x0036AAE4
		public static void AddTidTitleText(FlatBufferBuilder builder, StringOffset tidTitleTextOffset)
		{
			builder.AddOffset(2, tidTitleTextOffset.Value, 0);
		}

		// Token: 0x06017FCC RID: 98252 RVA: 0x0036C8F4 File Offset: 0x0036AAF4
		public static void AddTidDescText(FlatBufferBuilder builder, StringOffset tidDescTextOffset)
		{
			builder.AddOffset(3, tidDescTextOffset.Value, 0);
		}

		// Token: 0x06017FCD RID: 98253 RVA: 0x0036C904 File Offset: 0x0036AB04
		public static void AddRepeatItems(FlatBufferBuilder builder, bool repeatItems)
		{
			builder.AddBool(4, repeatItems, false);
		}

		// Token: 0x06017FCE RID: 98254 RVA: 0x0036C90F File Offset: 0x0036AB0F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06017FCF RID: 98255 RVA: 0x0036C91A File Offset: 0x0036AB1A
		public static Offset<IHandInItems> EndIHandInItems(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItems>(builder.EndTable());
		}

		// Token: 0x06017FD0 RID: 98256 RVA: 0x0036C928 File Offset: 0x0036AB28
		public IHandInItemsT UnPack()
		{
			IHandInItemsT handInItemsT = new IHandInItemsT();
			this.UnPackTo(handInItemsT);
			return handInItemsT;
		}

		// Token: 0x06017FD1 RID: 98257 RVA: 0x0036C944 File Offset: 0x0036AB44
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

		// Token: 0x06017FD2 RID: 98258 RVA: 0x0036CA04 File Offset: 0x0036AC04
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

		// Token: 0x0400C229 RID: 49705
		private Table __p;
	}
}
