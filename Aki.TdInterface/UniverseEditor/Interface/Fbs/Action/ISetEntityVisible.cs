using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE9 RID: 28649
	public struct ISetEntityVisible : IFlatbufferObject
	{
		// Token: 0x1700D4BA RID: 54458
		// (get) Token: 0x06032A76 RID: 207478 RVA: 0x006D5700 File Offset: 0x006D3900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A77 RID: 207479 RVA: 0x006D570D File Offset: 0x006D390D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A78 RID: 207480 RVA: 0x006D5714 File Offset: 0x006D3914
		public static ISetEntityVisible GetRootAsISetEntityVisible(ByteBuffer _bb)
		{
			return ISetEntityVisible.GetRootAsISetEntityVisible(_bb, default(ISetEntityVisible));
		}

		// Token: 0x06032A79 RID: 207481 RVA: 0x006D5730 File Offset: 0x006D3930
		public static ISetEntityVisible GetRootAsISetEntityVisible(ByteBuffer _bb, ISetEntityVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A7A RID: 207482 RVA: 0x006D574D File Offset: 0x006D394D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A7B RID: 207483 RVA: 0x006D575C File Offset: 0x006D395C
		public ISetEntityVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032A7C RID: 207484 RVA: 0x006D576C File Offset: 0x006D396C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D4BB RID: 54459
		// (get) Token: 0x06032A7D RID: 207485 RVA: 0x006D57AC File Offset: 0x006D39AC
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

		// Token: 0x06032A7E RID: 207486 RVA: 0x006D57D7 File Offset: 0x006D39D7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06032A7F RID: 207487 RVA: 0x006D57E6 File Offset: 0x006D39E6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D4BC RID: 54460
		// (get) Token: 0x06032A80 RID: 207488 RVA: 0x006D57F4 File Offset: 0x006D39F4
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4BD RID: 54461
		// (get) Token: 0x06032A81 RID: 207489 RVA: 0x006D5834 File Offset: 0x006D3A34
		public bool PerformDestroy
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4BE RID: 54462
		// (get) Token: 0x06032A82 RID: 207490 RVA: 0x006D5874 File Offset: 0x006D3A74
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032A83 RID: 207491 RVA: 0x006D58B1 File Offset: 0x006D3AB1
		public static Offset<ISetEntityVisible> CreateISetEntityVisible(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool Visible = false, bool PerformDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetEntityVisible.AddEntityIds(builder, EntityIdsOffset);
			ISetEntityVisible.AddNullMask(builder, NullMask);
			ISetEntityVisible.AddPerformDestroy(builder, PerformDestroy);
			ISetEntityVisible.AddVisible(builder, Visible);
			return ISetEntityVisible.EndISetEntityVisible(builder);
		}

		// Token: 0x06032A84 RID: 207492 RVA: 0x006D58DD File Offset: 0x006D3ADD
		public static void StartISetEntityVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032A85 RID: 207493 RVA: 0x006D58E6 File Offset: 0x006D3AE6
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06032A86 RID: 207494 RVA: 0x006D58F8 File Offset: 0x006D3AF8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032A87 RID: 207495 RVA: 0x006D592F File Offset: 0x006D3B2F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032A88 RID: 207496 RVA: 0x006D5949 File Offset: 0x006D3B49
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032A89 RID: 207497 RVA: 0x006D5967 File Offset: 0x006D3B67
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032A8A RID: 207498 RVA: 0x006D5980 File Offset: 0x006D3B80
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032A8B RID: 207499 RVA: 0x006D598B File Offset: 0x006D3B8B
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(1, visible, false);
		}

		// Token: 0x06032A8C RID: 207500 RVA: 0x006D5996 File Offset: 0x006D3B96
		public static void AddPerformDestroy(FlatBufferBuilder builder, bool performDestroy)
		{
			builder.AddBool(2, performDestroy, false);
		}

		// Token: 0x06032A8D RID: 207501 RVA: 0x006D59A1 File Offset: 0x006D3BA1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032A8E RID: 207502 RVA: 0x006D59AC File Offset: 0x006D3BAC
		public static Offset<ISetEntityVisible> EndISetEntityVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityVisible>(builder.EndTable());
		}

		// Token: 0x06032A8F RID: 207503 RVA: 0x006D59BC File Offset: 0x006D3BBC
		public ISetEntityVisibleT UnPack()
		{
			ISetEntityVisibleT setEntityVisibleT = new ISetEntityVisibleT();
			this.UnPackTo(setEntityVisibleT);
			return setEntityVisibleT;
		}

		// Token: 0x06032A90 RID: 207504 RVA: 0x006D59D8 File Offset: 0x006D3BD8
		public void UnPackTo(ISetEntityVisibleT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Visible = this.Visible;
			_o.PerformDestroy = this.PerformDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032A91 RID: 207505 RVA: 0x006D5A38 File Offset: 0x006D3C38
		public static Offset<ISetEntityVisible> Pack(FlatBufferBuilder builder, ISetEntityVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityVisible>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ISetEntityVisible.CreateEntityIdsVector(builder, data);
			}
			return ISetEntityVisible.CreateISetEntityVisible(builder, entityIdsOffset, _o.Visible, _o.PerformDestroy, _o.NullMask);
		}

		// Token: 0x040119FC RID: 72188
		private Table __p;
	}
}
