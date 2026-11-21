using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F9 RID: 27129
	public struct IClearPlayBubble : IFlatbufferObject
	{
		// Token: 0x1700C77C RID: 51068
		// (get) Token: 0x0602E884 RID: 190596 RVA: 0x00658AEA File Offset: 0x00656CEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E885 RID: 190597 RVA: 0x00658AF7 File Offset: 0x00656CF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E886 RID: 190598 RVA: 0x00658B00 File Offset: 0x00656D00
		public static IClearPlayBubble GetRootAsIClearPlayBubble(ByteBuffer _bb)
		{
			return IClearPlayBubble.GetRootAsIClearPlayBubble(_bb, default(IClearPlayBubble));
		}

		// Token: 0x0602E887 RID: 190599 RVA: 0x00658B1C File Offset: 0x00656D1C
		public static IClearPlayBubble GetRootAsIClearPlayBubble(ByteBuffer _bb, IClearPlayBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E888 RID: 190600 RVA: 0x00658B39 File Offset: 0x00656D39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E889 RID: 190601 RVA: 0x00658B48 File Offset: 0x00656D48
		public IClearPlayBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E88A RID: 190602 RVA: 0x00658B58 File Offset: 0x00656D58
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C77D RID: 51069
		// (get) Token: 0x0602E88B RID: 190603 RVA: 0x00658B98 File Offset: 0x00656D98
		public int EntityIdsLength
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

		// Token: 0x0602E88C RID: 190604 RVA: 0x00658BC3 File Offset: 0x00656DC3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602E88D RID: 190605 RVA: 0x00658BD2 File Offset: 0x00656DD2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700C77E RID: 51070
		// (get) Token: 0x0602E88E RID: 190606 RVA: 0x00658BE0 File Offset: 0x00656DE0
		public bool OnlyClearRedDot
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C77F RID: 51071
		// (get) Token: 0x0602E88F RID: 190607 RVA: 0x00658C20 File Offset: 0x00656E20
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

		// Token: 0x0602E890 RID: 190608 RVA: 0x00658C5C File Offset: 0x00656E5C
		public static Offset<IClearPlayBubble> CreateIClearPlayBubble(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool OnlyClearRedDot = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClearPlayBubble.AddEntityIds(builder, EntityIdsOffset);
			IClearPlayBubble.AddNullMask(builder, NullMask);
			IClearPlayBubble.AddOnlyClearRedDot(builder, OnlyClearRedDot);
			return IClearPlayBubble.EndIClearPlayBubble(builder);
		}

		// Token: 0x0602E891 RID: 190609 RVA: 0x00658C80 File Offset: 0x00656E80
		public static void StartIClearPlayBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E892 RID: 190610 RVA: 0x00658C89 File Offset: 0x00656E89
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602E893 RID: 190611 RVA: 0x00658C9C File Offset: 0x00656E9C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E894 RID: 190612 RVA: 0x00658CD3 File Offset: 0x00656ED3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E895 RID: 190613 RVA: 0x00658CED File Offset: 0x00656EED
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E896 RID: 190614 RVA: 0x00658D0B File Offset: 0x00656F0B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E897 RID: 190615 RVA: 0x00658D24 File Offset: 0x00656F24
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E898 RID: 190616 RVA: 0x00658D2F File Offset: 0x00656F2F
		public static void AddOnlyClearRedDot(FlatBufferBuilder builder, bool onlyClearRedDot)
		{
			builder.AddBool(1, onlyClearRedDot, false);
		}

		// Token: 0x0602E899 RID: 190617 RVA: 0x00658D3A File Offset: 0x00656F3A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602E89A RID: 190618 RVA: 0x00658D45 File Offset: 0x00656F45
		public static Offset<IClearPlayBubble> EndIClearPlayBubble(FlatBufferBuilder builder)
		{
			return new Offset<IClearPlayBubble>(builder.EndTable());
		}

		// Token: 0x0602E89B RID: 190619 RVA: 0x00658D54 File Offset: 0x00656F54
		public IClearPlayBubbleT UnPack()
		{
			IClearPlayBubbleT clearPlayBubbleT = new IClearPlayBubbleT();
			this.UnPackTo(clearPlayBubbleT);
			return clearPlayBubbleT;
		}

		// Token: 0x0602E89C RID: 190620 RVA: 0x00658D70 File Offset: 0x00656F70
		public void UnPackTo(IClearPlayBubbleT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.OnlyClearRedDot = this.OnlyClearRedDot;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E89D RID: 190621 RVA: 0x00658DC4 File Offset: 0x00656FC4
		public static Offset<IClearPlayBubble> Pack(FlatBufferBuilder builder, IClearPlayBubbleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClearPlayBubble>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IClearPlayBubble.CreateEntityIdsVector(builder, data);
			}
			return IClearPlayBubble.CreateIClearPlayBubble(builder, entityIdsOffset, _o.OnlyClearRedDot, _o.NullMask);
		}

		// Token: 0x04011766 RID: 71526
		private Table __p;
	}
}
