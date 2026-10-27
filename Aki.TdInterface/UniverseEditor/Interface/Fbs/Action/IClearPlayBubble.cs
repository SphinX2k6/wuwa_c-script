using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006388 RID: 25480
	public struct IClearPlayBubble : IFlatbufferObject
	{
		// Token: 0x1700BDF4 RID: 48628
		// (get) Token: 0x0602C11A RID: 180506 RVA: 0x0060D996 File Offset: 0x0060BB96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C11B RID: 180507 RVA: 0x0060D9A3 File Offset: 0x0060BBA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C11C RID: 180508 RVA: 0x0060D9AC File Offset: 0x0060BBAC
		public static IClearPlayBubble GetRootAsIClearPlayBubble(ByteBuffer _bb)
		{
			return IClearPlayBubble.GetRootAsIClearPlayBubble(_bb, default(IClearPlayBubble));
		}

		// Token: 0x0602C11D RID: 180509 RVA: 0x0060D9C8 File Offset: 0x0060BBC8
		public static IClearPlayBubble GetRootAsIClearPlayBubble(ByteBuffer _bb, IClearPlayBubble obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C11E RID: 180510 RVA: 0x0060D9E5 File Offset: 0x0060BBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C11F RID: 180511 RVA: 0x0060D9F4 File Offset: 0x0060BBF4
		public IClearPlayBubble __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C120 RID: 180512 RVA: 0x0060DA04 File Offset: 0x0060BC04
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BDF5 RID: 48629
		// (get) Token: 0x0602C121 RID: 180513 RVA: 0x0060DA44 File Offset: 0x0060BC44
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

		// Token: 0x0602C122 RID: 180514 RVA: 0x0060DA6F File Offset: 0x0060BC6F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602C123 RID: 180515 RVA: 0x0060DA7E File Offset: 0x0060BC7E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700BDF6 RID: 48630
		// (get) Token: 0x0602C124 RID: 180516 RVA: 0x0060DA8C File Offset: 0x0060BC8C
		public bool OnlyClearRedDot
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BDF7 RID: 48631
		// (get) Token: 0x0602C125 RID: 180517 RVA: 0x0060DACC File Offset: 0x0060BCCC
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

		// Token: 0x0602C126 RID: 180518 RVA: 0x0060DB08 File Offset: 0x0060BD08
		public static Offset<IClearPlayBubble> CreateIClearPlayBubble(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool OnlyClearRedDot = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClearPlayBubble.AddEntityIds(builder, EntityIdsOffset);
			IClearPlayBubble.AddNullMask(builder, NullMask);
			IClearPlayBubble.AddOnlyClearRedDot(builder, OnlyClearRedDot);
			return IClearPlayBubble.EndIClearPlayBubble(builder);
		}

		// Token: 0x0602C127 RID: 180519 RVA: 0x0060DB2C File Offset: 0x0060BD2C
		public static void StartIClearPlayBubble(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C128 RID: 180520 RVA: 0x0060DB35 File Offset: 0x0060BD35
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602C129 RID: 180521 RVA: 0x0060DB48 File Offset: 0x0060BD48
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C12A RID: 180522 RVA: 0x0060DB7F File Offset: 0x0060BD7F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C12B RID: 180523 RVA: 0x0060DB99 File Offset: 0x0060BD99
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C12C RID: 180524 RVA: 0x0060DBB7 File Offset: 0x0060BDB7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C12D RID: 180525 RVA: 0x0060DBD0 File Offset: 0x0060BDD0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C12E RID: 180526 RVA: 0x0060DBDB File Offset: 0x0060BDDB
		public static void AddOnlyClearRedDot(FlatBufferBuilder builder, bool onlyClearRedDot)
		{
			builder.AddBool(1, onlyClearRedDot, false);
		}

		// Token: 0x0602C12F RID: 180527 RVA: 0x0060DBE6 File Offset: 0x0060BDE6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C130 RID: 180528 RVA: 0x0060DBF1 File Offset: 0x0060BDF1
		public static Offset<IClearPlayBubble> EndIClearPlayBubble(FlatBufferBuilder builder)
		{
			return new Offset<IClearPlayBubble>(builder.EndTable());
		}

		// Token: 0x0602C131 RID: 180529 RVA: 0x0060DC00 File Offset: 0x0060BE00
		public IClearPlayBubbleT UnPack()
		{
			IClearPlayBubbleT clearPlayBubbleT = new IClearPlayBubbleT();
			this.UnPackTo(clearPlayBubbleT);
			return clearPlayBubbleT;
		}

		// Token: 0x0602C132 RID: 180530 RVA: 0x0060DC1C File Offset: 0x0060BE1C
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

		// Token: 0x0602C133 RID: 180531 RVA: 0x0060DC70 File Offset: 0x0060BE70
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

		// Token: 0x04010951 RID: 67921
		private Table __p;
	}
}
