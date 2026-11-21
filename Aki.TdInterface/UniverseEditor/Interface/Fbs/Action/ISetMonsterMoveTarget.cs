using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E2 RID: 30690
	public struct ISetMonsterMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700E0E7 RID: 57575
		// (get) Token: 0x06035E75 RID: 220789 RVA: 0x00738A66 File Offset: 0x00736C66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E76 RID: 220790 RVA: 0x00738A73 File Offset: 0x00736C73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E77 RID: 220791 RVA: 0x00738A7C File Offset: 0x00736C7C
		public static ISetMonsterMoveTarget GetRootAsISetMonsterMoveTarget(ByteBuffer _bb)
		{
			return ISetMonsterMoveTarget.GetRootAsISetMonsterMoveTarget(_bb, default(ISetMonsterMoveTarget));
		}

		// Token: 0x06035E78 RID: 220792 RVA: 0x00738A98 File Offset: 0x00736C98
		public static ISetMonsterMoveTarget GetRootAsISetMonsterMoveTarget(ByteBuffer _bb, ISetMonsterMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E79 RID: 220793 RVA: 0x00738AB5 File Offset: 0x00736CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E7A RID: 220794 RVA: 0x00738AC4 File Offset: 0x00736CC4
		public ISetMonsterMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0E8 RID: 57576
		// (get) Token: 0x06035E7B RID: 220795 RVA: 0x00738AD4 File Offset: 0x00736CD4
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

		// Token: 0x1700E0E9 RID: 57577
		// (get) Token: 0x06035E7C RID: 220796 RVA: 0x00738B10 File Offset: 0x00736D10
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

		// Token: 0x1700E0EA RID: 57578
		// (get) Token: 0x06035E7D RID: 220797 RVA: 0x00738B4C File Offset: 0x00736D4C
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

		// Token: 0x06035E7E RID: 220798 RVA: 0x00738B88 File Offset: 0x00736D88
		public int MonsterEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E0EB RID: 57579
		// (get) Token: 0x06035E7F RID: 220799 RVA: 0x00738BC8 File Offset: 0x00736DC8
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

		// Token: 0x06035E80 RID: 220800 RVA: 0x00738BF4 File Offset: 0x00736DF4
		public Span<int> GetMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06035E81 RID: 220801 RVA: 0x00738C04 File Offset: 0x00736E04
		public int[] GetMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700E0EC RID: 57580
		// (get) Token: 0x06035E82 RID: 220802 RVA: 0x00738C14 File Offset: 0x00736E14
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

		// Token: 0x06035E83 RID: 220803 RVA: 0x00738C51 File Offset: 0x00736E51
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

		// Token: 0x06035E84 RID: 220804 RVA: 0x00738C85 File Offset: 0x00736E85
		public static void StartISetMonsterMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06035E85 RID: 220805 RVA: 0x00738C8E File Offset: 0x00736E8E
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E86 RID: 220806 RVA: 0x00738C99 File Offset: 0x00736E99
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x06035E87 RID: 220807 RVA: 0x00738CA4 File Offset: 0x00736EA4
		public static void AddMoveEvent(FlatBufferBuilder builder, EMoveEvent moveEvent)
		{
			builder.AddByte(2, (byte)moveEvent, 0);
		}

		// Token: 0x06035E88 RID: 220808 RVA: 0x00738CAF File Offset: 0x00736EAF
		public static void AddMonsterEntityIds(FlatBufferBuilder builder, VectorOffset monsterEntityIdsOffset)
		{
			builder.AddOffset(3, monsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x06035E89 RID: 220809 RVA: 0x00738CC0 File Offset: 0x00736EC0
		public static VectorOffset CreateMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035E8A RID: 220810 RVA: 0x00738CF7 File Offset: 0x00736EF7
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035E8B RID: 220811 RVA: 0x00738D11 File Offset: 0x00736F11
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035E8C RID: 220812 RVA: 0x00738D2F File Offset: 0x00736F2F
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035E8D RID: 220813 RVA: 0x00738D48 File Offset: 0x00736F48
		public static void StartMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035E8E RID: 220814 RVA: 0x00738D53 File Offset: 0x00736F53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06035E8F RID: 220815 RVA: 0x00738D5E File Offset: 0x00736F5E
		public static Offset<ISetMonsterMoveTarget> EndISetMonsterMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISetMonsterMoveTarget>(builder.EndTable());
		}

		// Token: 0x06035E90 RID: 220816 RVA: 0x00738D6C File Offset: 0x00736F6C
		public ISetMonsterMoveTargetT UnPack()
		{
			ISetMonsterMoveTargetT setMonsterMoveTargetT = new ISetMonsterMoveTargetT();
			this.UnPackTo(setMonsterMoveTargetT);
			return setMonsterMoveTargetT;
		}

		// Token: 0x06035E91 RID: 220817 RVA: 0x00738D88 File Offset: 0x00736F88
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

		// Token: 0x06035E92 RID: 220818 RVA: 0x00738DF4 File Offset: 0x00736FF4
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

		// Token: 0x04012A24 RID: 76324
		private Table __p;
	}
}
