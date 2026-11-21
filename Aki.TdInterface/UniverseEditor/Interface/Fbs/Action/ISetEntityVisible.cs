using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B2 RID: 30642
	public struct ISetEntityVisible : IFlatbufferObject
	{
		// Token: 0x1700E08E RID: 57486
		// (get) Token: 0x06035CDC RID: 220380 RVA: 0x00735344 File Offset: 0x00733544
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035CDD RID: 220381 RVA: 0x00735351 File Offset: 0x00733551
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035CDE RID: 220382 RVA: 0x00735358 File Offset: 0x00733558
		public static ISetEntityVisible GetRootAsISetEntityVisible(ByteBuffer _bb)
		{
			return ISetEntityVisible.GetRootAsISetEntityVisible(_bb, default(ISetEntityVisible));
		}

		// Token: 0x06035CDF RID: 220383 RVA: 0x00735374 File Offset: 0x00733574
		public static ISetEntityVisible GetRootAsISetEntityVisible(ByteBuffer _bb, ISetEntityVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035CE0 RID: 220384 RVA: 0x00735391 File Offset: 0x00733591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035CE1 RID: 220385 RVA: 0x007353A0 File Offset: 0x007335A0
		public ISetEntityVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035CE2 RID: 220386 RVA: 0x007353B0 File Offset: 0x007335B0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E08F RID: 57487
		// (get) Token: 0x06035CE3 RID: 220387 RVA: 0x007353F0 File Offset: 0x007335F0
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

		// Token: 0x06035CE4 RID: 220388 RVA: 0x0073541B File Offset: 0x0073361B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06035CE5 RID: 220389 RVA: 0x0073542A File Offset: 0x0073362A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700E090 RID: 57488
		// (get) Token: 0x06035CE6 RID: 220390 RVA: 0x00735438 File Offset: 0x00733638
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E091 RID: 57489
		// (get) Token: 0x06035CE7 RID: 220391 RVA: 0x00735478 File Offset: 0x00733678
		public bool PerformDestroy
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E092 RID: 57490
		// (get) Token: 0x06035CE8 RID: 220392 RVA: 0x007354B8 File Offset: 0x007336B8
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

		// Token: 0x06035CE9 RID: 220393 RVA: 0x007354F5 File Offset: 0x007336F5
		public static Offset<ISetEntityVisible> CreateISetEntityVisible(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool Visible = false, bool PerformDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetEntityVisible.AddEntityIds(builder, EntityIdsOffset);
			ISetEntityVisible.AddNullMask(builder, NullMask);
			ISetEntityVisible.AddPerformDestroy(builder, PerformDestroy);
			ISetEntityVisible.AddVisible(builder, Visible);
			return ISetEntityVisible.EndISetEntityVisible(builder);
		}

		// Token: 0x06035CEA RID: 220394 RVA: 0x00735521 File Offset: 0x00733721
		public static void StartISetEntityVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035CEB RID: 220395 RVA: 0x0073552A File Offset: 0x0073372A
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06035CEC RID: 220396 RVA: 0x0073553C File Offset: 0x0073373C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035CED RID: 220397 RVA: 0x00735573 File Offset: 0x00733773
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035CEE RID: 220398 RVA: 0x0073558D File Offset: 0x0073378D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035CEF RID: 220399 RVA: 0x007355AB File Offset: 0x007337AB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035CF0 RID: 220400 RVA: 0x007355C4 File Offset: 0x007337C4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035CF1 RID: 220401 RVA: 0x007355CF File Offset: 0x007337CF
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(1, visible, false);
		}

		// Token: 0x06035CF2 RID: 220402 RVA: 0x007355DA File Offset: 0x007337DA
		public static void AddPerformDestroy(FlatBufferBuilder builder, bool performDestroy)
		{
			builder.AddBool(2, performDestroy, false);
		}

		// Token: 0x06035CF3 RID: 220403 RVA: 0x007355E5 File Offset: 0x007337E5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035CF4 RID: 220404 RVA: 0x007355F0 File Offset: 0x007337F0
		public static Offset<ISetEntityVisible> EndISetEntityVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityVisible>(builder.EndTable());
		}

		// Token: 0x06035CF5 RID: 220405 RVA: 0x00735600 File Offset: 0x00733800
		public ISetEntityVisibleT UnPack()
		{
			ISetEntityVisibleT setEntityVisibleT = new ISetEntityVisibleT();
			this.UnPackTo(setEntityVisibleT);
			return setEntityVisibleT;
		}

		// Token: 0x06035CF6 RID: 220406 RVA: 0x0073561C File Offset: 0x0073381C
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

		// Token: 0x06035CF7 RID: 220407 RVA: 0x0073567C File Offset: 0x0073387C
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

		// Token: 0x040129E1 RID: 76257
		private Table __p;
	}
}
