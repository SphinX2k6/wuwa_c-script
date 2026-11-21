using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F8 RID: 17144
	public struct IItemObtain : IFlatbufferObject
	{
		// Token: 0x17007561 RID: 30049
		// (get) Token: 0x0601813F RID: 98623 RVA: 0x0036F744 File Offset: 0x0036D944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018140 RID: 98624 RVA: 0x0036F751 File Offset: 0x0036D951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018141 RID: 98625 RVA: 0x0036F758 File Offset: 0x0036D958
		public static IItemObtain GetRootAsIItemObtain(ByteBuffer _bb)
		{
			return IItemObtain.GetRootAsIItemObtain(_bb, default(IItemObtain));
		}

		// Token: 0x06018142 RID: 98626 RVA: 0x0036F774 File Offset: 0x0036D974
		public static IItemObtain GetRootAsIItemObtain(ByteBuffer _bb, IItemObtain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018143 RID: 98627 RVA: 0x0036F791 File Offset: 0x0036D991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018144 RID: 98628 RVA: 0x0036F7A0 File Offset: 0x0036D9A0
		public IItemObtain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007562 RID: 30050
		// (get) Token: 0x06018145 RID: 98629 RVA: 0x0036F7B0 File Offset: 0x0036D9B0
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018146 RID: 98630 RVA: 0x0036F7EC File Offset: 0x0036D9EC
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007563 RID: 30051
		// (get) Token: 0x06018147 RID: 98631 RVA: 0x0036F82C File Offset: 0x0036DA2C
		public int ItemIdsLength
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

		// Token: 0x06018148 RID: 98632 RVA: 0x0036F857 File Offset: 0x0036DA57
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018149 RID: 98633 RVA: 0x0036F866 File Offset: 0x0036DA66
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17007564 RID: 30052
		// (get) Token: 0x0601814A RID: 98634 RVA: 0x0036F874 File Offset: 0x0036DA74
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601814B RID: 98635 RVA: 0x0036F8B0 File Offset: 0x0036DAB0
		public static Offset<IItemObtain> CreateIItemObtain(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset ItemIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IItemObtain.AddItemIds(builder, ItemIdsOffset);
			IItemObtain.AddNullMask(builder, NullMask);
			IItemObtain.AddType(builder, Type);
			return IItemObtain.EndIItemObtain(builder);
		}

		// Token: 0x0601814C RID: 98636 RVA: 0x0036F8D4 File Offset: 0x0036DAD4
		public static void StartIItemObtain(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601814D RID: 98637 RVA: 0x0036F8DD File Offset: 0x0036DADD
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601814E RID: 98638 RVA: 0x0036F8E8 File Offset: 0x0036DAE8
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x0601814F RID: 98639 RVA: 0x0036F8F8 File Offset: 0x0036DAF8
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018150 RID: 98640 RVA: 0x0036F92F File Offset: 0x0036DB2F
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018151 RID: 98641 RVA: 0x0036F949 File Offset: 0x0036DB49
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018152 RID: 98642 RVA: 0x0036F967 File Offset: 0x0036DB67
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018153 RID: 98643 RVA: 0x0036F980 File Offset: 0x0036DB80
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018154 RID: 98644 RVA: 0x0036F98B File Offset: 0x0036DB8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06018155 RID: 98645 RVA: 0x0036F996 File Offset: 0x0036DB96
		public static Offset<IItemObtain> EndIItemObtain(FlatBufferBuilder builder)
		{
			return new Offset<IItemObtain>(builder.EndTable());
		}

		// Token: 0x06018156 RID: 98646 RVA: 0x0036F9A4 File Offset: 0x0036DBA4
		public IItemObtainT UnPack()
		{
			IItemObtainT itemObtainT = new IItemObtainT();
			this.UnPackTo(itemObtainT);
			return itemObtainT;
		}

		// Token: 0x06018157 RID: 98647 RVA: 0x0036F9C0 File Offset: 0x0036DBC0
		public void UnPackTo(IItemObtainT _o)
		{
			_o.Type = this.Type;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018158 RID: 98648 RVA: 0x0036FA14 File Offset: 0x0036DC14
		public static Offset<IItemObtain> Pack(FlatBufferBuilder builder, IItemObtainT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemObtain>);
			}
			VectorOffset itemIdsOffset = default(VectorOffset);
			if (_o.ItemIds != null)
			{
				int[] data = _o.ItemIds.ToArray();
				itemIdsOffset = IItemObtain.CreateItemIdsVector(builder, data);
			}
			return IItemObtain.CreateIItemObtain(builder, _o.Type, itemIdsOffset, _o.NullMask);
		}

		// Token: 0x0400C267 RID: 49767
		private Table __p;
	}
}
