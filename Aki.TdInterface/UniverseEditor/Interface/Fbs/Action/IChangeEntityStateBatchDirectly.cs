using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062ED RID: 25325
	public struct IChangeEntityStateBatchDirectly : IFlatbufferObject
	{
		// Token: 0x1700BCF9 RID: 48377
		// (get) Token: 0x0602BC53 RID: 179283 RVA: 0x00605642 File Offset: 0x00603842
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC54 RID: 179284 RVA: 0x0060564F File Offset: 0x0060384F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC55 RID: 179285 RVA: 0x00605658 File Offset: 0x00603858
		public static IChangeEntityStateBatchDirectly GetRootAsIChangeEntityStateBatchDirectly(ByteBuffer _bb)
		{
			return IChangeEntityStateBatchDirectly.GetRootAsIChangeEntityStateBatchDirectly(_bb, default(IChangeEntityStateBatchDirectly));
		}

		// Token: 0x0602BC56 RID: 179286 RVA: 0x00605674 File Offset: 0x00603874
		public static IChangeEntityStateBatchDirectly GetRootAsIChangeEntityStateBatchDirectly(ByteBuffer _bb, IChangeEntityStateBatchDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC57 RID: 179287 RVA: 0x00605691 File Offset: 0x00603891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC58 RID: 179288 RVA: 0x006056A0 File Offset: 0x006038A0
		public IChangeEntityStateBatchDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCFA RID: 48378
		// (get) Token: 0x0602BC59 RID: 179289 RVA: 0x006056B0 File Offset: 0x006038B0
		public EChangeEntityState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityState.Directly;
				}
				return (EChangeEntityState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCFB RID: 48379
		// (get) Token: 0x0602BC5A RID: 179290 RVA: 0x006056EC File Offset: 0x006038EC
		public int EntityId
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

		// Token: 0x0602BC5B RID: 179291 RVA: 0x00605728 File Offset: 0x00603928
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BCFC RID: 48380
		// (get) Token: 0x0602BC5C RID: 179292 RVA: 0x00605768 File Offset: 0x00603968
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602BC5D RID: 179293 RVA: 0x00605793 File Offset: 0x00603993
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602BC5E RID: 179294 RVA: 0x006057A2 File Offset: 0x006039A2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700BCFD RID: 48381
		// (get) Token: 0x0602BC5F RID: 179295 RVA: 0x006057B0 File Offset: 0x006039B0
		public string State
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

		// Token: 0x0602BC60 RID: 179296 RVA: 0x006057E8 File Offset: 0x006039E8
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602BC61 RID: 179297 RVA: 0x006057F8 File Offset: 0x006039F8
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BCFE RID: 48382
		// (get) Token: 0x0602BC62 RID: 179298 RVA: 0x00605808 File Offset: 0x00603A08
		public bool DelayChange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BCFF RID: 48383
		// (get) Token: 0x0602BC63 RID: 179299 RVA: 0x00605848 File Offset: 0x00603A48
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

		// Token: 0x0602BC64 RID: 179300 RVA: 0x00605885 File Offset: 0x00603A85
		public static Offset<IChangeEntityStateBatchDirectly> CreateIChangeEntityStateBatchDirectly(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0, VectorOffset EntityIdsOffset = default(VectorOffset), StringOffset StateOffset = default(StringOffset), bool DelayChange = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IChangeEntityStateBatchDirectly.AddState(builder, StateOffset);
			IChangeEntityStateBatchDirectly.AddEntityIds(builder, EntityIdsOffset);
			IChangeEntityStateBatchDirectly.AddEntityId(builder, EntityId);
			IChangeEntityStateBatchDirectly.AddNullMask(builder, NullMask);
			IChangeEntityStateBatchDirectly.AddDelayChange(builder, DelayChange);
			IChangeEntityStateBatchDirectly.AddType(builder, Type);
			return IChangeEntityStateBatchDirectly.EndIChangeEntityStateBatchDirectly(builder);
		}

		// Token: 0x0602BC65 RID: 179301 RVA: 0x006058C1 File Offset: 0x00603AC1
		public static void StartIChangeEntityStateBatchDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602BC66 RID: 179302 RVA: 0x006058CA File Offset: 0x00603ACA
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BC67 RID: 179303 RVA: 0x006058D5 File Offset: 0x00603AD5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602BC68 RID: 179304 RVA: 0x006058E0 File Offset: 0x00603AE0
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602BC69 RID: 179305 RVA: 0x006058F0 File Offset: 0x00603AF0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BC6A RID: 179306 RVA: 0x00605927 File Offset: 0x00603B27
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BC6B RID: 179307 RVA: 0x00605941 File Offset: 0x00603B41
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BC6C RID: 179308 RVA: 0x0060595F File Offset: 0x00603B5F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BC6D RID: 179309 RVA: 0x00605978 File Offset: 0x00603B78
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BC6E RID: 179310 RVA: 0x00605983 File Offset: 0x00603B83
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x0602BC6F RID: 179311 RVA: 0x00605993 File Offset: 0x00603B93
		public static void AddDelayChange(FlatBufferBuilder builder, bool delayChange)
		{
			builder.AddBool(4, delayChange, false);
		}

		// Token: 0x0602BC70 RID: 179312 RVA: 0x0060599E File Offset: 0x00603B9E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602BC71 RID: 179313 RVA: 0x006059A9 File Offset: 0x00603BA9
		public static Offset<IChangeEntityStateBatchDirectly> EndIChangeEntityStateBatchDirectly(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityStateBatchDirectly>(builder.EndTable());
		}

		// Token: 0x0602BC72 RID: 179314 RVA: 0x006059B8 File Offset: 0x00603BB8
		public IChangeEntityStateBatchDirectlyT UnPack()
		{
			IChangeEntityStateBatchDirectlyT changeEntityStateBatchDirectlyT = new IChangeEntityStateBatchDirectlyT();
			this.UnPackTo(changeEntityStateBatchDirectlyT);
			return changeEntityStateBatchDirectlyT;
		}

		// Token: 0x0602BC73 RID: 179315 RVA: 0x006059D4 File Offset: 0x00603BD4
		public void UnPackTo(IChangeEntityStateBatchDirectlyT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.State = this.State;
			_o.DelayChange = this.DelayChange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BC74 RID: 179316 RVA: 0x00605A4C File Offset: 0x00603C4C
		public static Offset<IChangeEntityStateBatchDirectly> Pack(FlatBufferBuilder builder, IChangeEntityStateBatchDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityStateBatchDirectly>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IChangeEntityStateBatchDirectly.CreateEntityIdsVector(builder, data);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeEntityStateBatchDirectly.CreateIChangeEntityStateBatchDirectly(builder, _o.Type, _o.EntityId, entityIdsOffset, stateOffset, _o.DelayChange, _o.NullMask);
		}

		// Token: 0x0401089A RID: 67738
		private Table __p;
	}
}
