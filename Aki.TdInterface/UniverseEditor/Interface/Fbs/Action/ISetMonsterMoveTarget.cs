using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007019 RID: 28697
	public struct ISetMonsterMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700D513 RID: 54547
		// (get) Token: 0x06032C0F RID: 207887 RVA: 0x006D8E22 File Offset: 0x006D7022
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C10 RID: 207888 RVA: 0x006D8E2F File Offset: 0x006D702F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C11 RID: 207889 RVA: 0x006D8E38 File Offset: 0x006D7038
		public static ISetMonsterMoveTarget GetRootAsISetMonsterMoveTarget(ByteBuffer _bb)
		{
			return ISetMonsterMoveTarget.GetRootAsISetMonsterMoveTarget(_bb, default(ISetMonsterMoveTarget));
		}

		// Token: 0x06032C12 RID: 207890 RVA: 0x006D8E54 File Offset: 0x006D7054
		public static ISetMonsterMoveTarget GetRootAsISetMonsterMoveTarget(ByteBuffer _bb, ISetMonsterMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C13 RID: 207891 RVA: 0x006D8E71 File Offset: 0x006D7071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C14 RID: 207892 RVA: 0x006D8E80 File Offset: 0x006D7080
		public ISetMonsterMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D514 RID: 54548
		// (get) Token: 0x06032C15 RID: 207893 RVA: 0x006D8E90 File Offset: 0x006D7090
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D515 RID: 54549
		// (get) Token: 0x06032C16 RID: 207894 RVA: 0x006D8ECC File Offset: 0x006D70CC
		public int TargetEntityId
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

		// Token: 0x1700D516 RID: 54550
		// (get) Token: 0x06032C17 RID: 207895 RVA: 0x006D8F08 File Offset: 0x006D7108
		public EMoveEvent MoveEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMoveEvent.Walk;
				}
				return (EMoveEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032C18 RID: 207896 RVA: 0x006D8F44 File Offset: 0x006D7144
		public int MonsterEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D517 RID: 54551
		// (get) Token: 0x06032C19 RID: 207897 RVA: 0x006D8F84 File Offset: 0x006D7184
		public int MonsterEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032C1A RID: 207898 RVA: 0x006D8FB0 File Offset: 0x006D71B0
		public Span<int> GetMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06032C1B RID: 207899 RVA: 0x006D8FC0 File Offset: 0x006D71C0
		public int[] GetMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700D518 RID: 54552
		// (get) Token: 0x06032C1C RID: 207900 RVA: 0x006D8FD0 File Offset: 0x006D71D0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032C1D RID: 207901 RVA: 0x006D900D File Offset: 0x006D720D
		public static Offset<ISetMonsterMoveTarget> CreateISetMonsterMoveTarget(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, int TargetEntityId = 0, EMoveEvent MoveEvent = EMoveEvent.Walk, VectorOffset MonsterEntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ISetMonsterMoveTarget.AddMonsterEntityIds(builder, MonsterEntityIdsOffset);
			ISetMonsterMoveTarget.AddTargetEntityId(builder, TargetEntityId);
			ISetMonsterMoveTarget.AddNullMask(builder, NullMask);
			ISetMonsterMoveTarget.AddMoveEvent(builder, MoveEvent);
			ISetMonsterMoveTarget.AddType(builder, Type);
			return ISetMonsterMoveTarget.EndISetMonsterMoveTarget(builder);
		}

		// Token: 0x06032C1E RID: 207902 RVA: 0x006D9041 File Offset: 0x006D7241
		public static void StartISetMonsterMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032C1F RID: 207903 RVA: 0x006D904A File Offset: 0x006D724A
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C20 RID: 207904 RVA: 0x006D9055 File Offset: 0x006D7255
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x06032C21 RID: 207905 RVA: 0x006D9060 File Offset: 0x006D7260
		public static void AddMoveEvent(FlatBufferBuilder builder, EMoveEvent moveEvent)
		{
			builder.AddByte(2, (byte)moveEvent, 0);
		}

		// Token: 0x06032C22 RID: 207906 RVA: 0x006D906B File Offset: 0x006D726B
		public static void AddMonsterEntityIds(FlatBufferBuilder builder, VectorOffset monsterEntityIdsOffset)
		{
			builder.AddOffset(3, monsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x06032C23 RID: 207907 RVA: 0x006D907C File Offset: 0x006D727C
		public static VectorOffset CreateMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032C24 RID: 207908 RVA: 0x006D90B3 File Offset: 0x006D72B3
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C25 RID: 207909 RVA: 0x006D90CD File Offset: 0x006D72CD
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C26 RID: 207910 RVA: 0x006D90EB File Offset: 0x006D72EB
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032C27 RID: 207911 RVA: 0x006D9104 File Offset: 0x006D7304
		public static void StartMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032C28 RID: 207912 RVA: 0x006D910F File Offset: 0x006D730F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06032C29 RID: 207913 RVA: 0x006D911A File Offset: 0x006D731A
		public static Offset<ISetMonsterMoveTarget> EndISetMonsterMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISetMonsterMoveTarget>(builder.EndTable());
		}

		// Token: 0x06032C2A RID: 207914 RVA: 0x006D9128 File Offset: 0x006D7328
		public ISetMonsterMoveTargetT UnPack()
		{
			ISetMonsterMoveTargetT setMonsterMoveTargetT = new ISetMonsterMoveTargetT();
			this.UnPackTo(setMonsterMoveTargetT);
			return setMonsterMoveTargetT;
		}

		// Token: 0x06032C2B RID: 207915 RVA: 0x006D9144 File Offset: 0x006D7344
		public void UnPackTo(ISetMonsterMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
			_o.MoveEvent = this.MoveEvent;
			_o.MonsterEntityIds = new List<int>();
			for (int i = 0; i < this.MonsterEntityIdsLength; i++)
			{
				_o.MonsterEntityIds.Add(this.MonsterEntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032C2C RID: 207916 RVA: 0x006D91B0 File Offset: 0x006D73B0
		public static Offset<ISetMonsterMoveTarget> Pack(FlatBufferBuilder builder, ISetMonsterMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMonsterMoveTarget>);
			}
			VectorOffset monsterEntityIdsOffset = default(VectorOffset);
			if (_o.MonsterEntityIds != null)
			{
				int[] data = _o.MonsterEntityIds.ToArray();
				monsterEntityIdsOffset = ISetMonsterMoveTarget.CreateMonsterEntityIdsVector(builder, data);
			}
			return ISetMonsterMoveTarget.CreateISetMonsterMoveTarget(builder, _o.Type, _o.TargetEntityId, _o.MoveEvent, monsterEntityIdsOffset, _o.NullMask);
		}

		// Token: 0x04011A3F RID: 72255
		private Table __p;
	}
}
