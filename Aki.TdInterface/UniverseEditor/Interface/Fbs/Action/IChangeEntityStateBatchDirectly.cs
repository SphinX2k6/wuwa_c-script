using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695E RID: 26974
	public struct IChangeEntityStateBatchDirectly : IFlatbufferObject
	{
		// Token: 0x1700C683 RID: 50819
		// (get) Token: 0x0602E3BC RID: 189372 RVA: 0x0065064E File Offset: 0x0064E84E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E3BD RID: 189373 RVA: 0x0065065B File Offset: 0x0064E85B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E3BE RID: 189374 RVA: 0x00650664 File Offset: 0x0064E864
		public static IChangeEntityStateBatchDirectly GetRootAsIChangeEntityStateBatchDirectly(ByteBuffer _bb)
		{
			return IChangeEntityStateBatchDirectly.GetRootAsIChangeEntityStateBatchDirectly(_bb, default(IChangeEntityStateBatchDirectly));
		}

		// Token: 0x0602E3BF RID: 189375 RVA: 0x00650680 File Offset: 0x0064E880
		public static IChangeEntityStateBatchDirectly GetRootAsIChangeEntityStateBatchDirectly(ByteBuffer _bb, IChangeEntityStateBatchDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E3C0 RID: 189376 RVA: 0x0065069D File Offset: 0x0064E89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E3C1 RID: 189377 RVA: 0x006506AC File Offset: 0x0064E8AC
		public IChangeEntityStateBatchDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C684 RID: 50820
		// (get) Token: 0x0602E3C2 RID: 189378 RVA: 0x006506BC File Offset: 0x0064E8BC
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

		// Token: 0x1700C685 RID: 50821
		// (get) Token: 0x0602E3C3 RID: 189379 RVA: 0x006506F8 File Offset: 0x0064E8F8
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

		// Token: 0x0602E3C4 RID: 189380 RVA: 0x00650734 File Offset: 0x0064E934
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C686 RID: 50822
		// (get) Token: 0x0602E3C5 RID: 189381 RVA: 0x00650774 File Offset: 0x0064E974
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

		// Token: 0x0602E3C6 RID: 189382 RVA: 0x0065079F File Offset: 0x0064E99F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602E3C7 RID: 189383 RVA: 0x006507AE File Offset: 0x0064E9AE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700C687 RID: 50823
		// (get) Token: 0x0602E3C8 RID: 189384 RVA: 0x006507BC File Offset: 0x0064E9BC
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

		// Token: 0x0602E3C9 RID: 189385 RVA: 0x006507F4 File Offset: 0x0064E9F4
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602E3CA RID: 189386 RVA: 0x00650804 File Offset: 0x0064EA04
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C688 RID: 50824
		// (get) Token: 0x0602E3CB RID: 189387 RVA: 0x00650814 File Offset: 0x0064EA14
		public bool DelayChange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C689 RID: 50825
		// (get) Token: 0x0602E3CC RID: 189388 RVA: 0x00650854 File Offset: 0x0064EA54
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

		// Token: 0x0602E3CD RID: 189389 RVA: 0x00650891 File Offset: 0x0064EA91
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

		// Token: 0x0602E3CE RID: 189390 RVA: 0x006508CD File Offset: 0x0064EACD
		public static void StartIChangeEntityStateBatchDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E3CF RID: 189391 RVA: 0x006508D6 File Offset: 0x0064EAD6
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3D0 RID: 189392 RVA: 0x006508E1 File Offset: 0x0064EAE1
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E3D1 RID: 189393 RVA: 0x006508EC File Offset: 0x0064EAEC
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602E3D2 RID: 189394 RVA: 0x006508FC File Offset: 0x0064EAFC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E3D3 RID: 189395 RVA: 0x00650933 File Offset: 0x0064EB33
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E3D4 RID: 189396 RVA: 0x0065094D File Offset: 0x0064EB4D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E3D5 RID: 189397 RVA: 0x0065096B File Offset: 0x0064EB6B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E3D6 RID: 189398 RVA: 0x00650984 File Offset: 0x0064EB84
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E3D7 RID: 189399 RVA: 0x0065098F File Offset: 0x0064EB8F
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x0602E3D8 RID: 189400 RVA: 0x0065099F File Offset: 0x0064EB9F
		public static void AddDelayChange(FlatBufferBuilder builder, bool delayChange)
		{
			builder.AddBool(4, delayChange, false);
		}

		// Token: 0x0602E3D9 RID: 189401 RVA: 0x006509AA File Offset: 0x0064EBAA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602E3DA RID: 189402 RVA: 0x006509B5 File Offset: 0x0064EBB5
		public static Offset<IChangeEntityStateBatchDirectly> EndIChangeEntityStateBatchDirectly(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityStateBatchDirectly>(builder.EndTable());
		}

		// Token: 0x0602E3DB RID: 189403 RVA: 0x006509C4 File Offset: 0x0064EBC4
		public IChangeEntityStateBatchDirectlyT UnPack()
		{
			IChangeEntityStateBatchDirectlyT changeEntityStateBatchDirectlyT = new IChangeEntityStateBatchDirectlyT();
			this.UnPackTo(changeEntityStateBatchDirectlyT);
			return changeEntityStateBatchDirectlyT;
		}

		// Token: 0x0602E3DC RID: 189404 RVA: 0x006509E0 File Offset: 0x0064EBE0
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

		// Token: 0x0602E3DD RID: 189405 RVA: 0x00650A58 File Offset: 0x0064EC58
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

		// Token: 0x040116B0 RID: 71344
		private Table __p;
	}
}
