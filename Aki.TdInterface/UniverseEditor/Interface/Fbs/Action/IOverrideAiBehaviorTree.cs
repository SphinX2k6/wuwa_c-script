using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C54 RID: 27732
	public struct IOverrideAiBehaviorTree : IFlatbufferObject
	{
		// Token: 0x1700CE89 RID: 52873
		// (get) Token: 0x06030DBB RID: 200123 RVA: 0x006A2F82 File Offset: 0x006A1182
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DBC RID: 200124 RVA: 0x006A2F8F File Offset: 0x006A118F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DBD RID: 200125 RVA: 0x006A2F98 File Offset: 0x006A1198
		public static IOverrideAiBehaviorTree GetRootAsIOverrideAiBehaviorTree(ByteBuffer _bb)
		{
			return IOverrideAiBehaviorTree.GetRootAsIOverrideAiBehaviorTree(_bb, default(IOverrideAiBehaviorTree));
		}

		// Token: 0x06030DBE RID: 200126 RVA: 0x006A2FB4 File Offset: 0x006A11B4
		public static IOverrideAiBehaviorTree GetRootAsIOverrideAiBehaviorTree(ByteBuffer _bb, IOverrideAiBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DBF RID: 200127 RVA: 0x006A2FD1 File Offset: 0x006A11D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DC0 RID: 200128 RVA: 0x006A2FE0 File Offset: 0x006A11E0
		public IOverrideAiBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE8A RID: 52874
		// (get) Token: 0x06030DC1 RID: 200129 RVA: 0x006A2FF0 File Offset: 0x006A11F0
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030DC2 RID: 200130 RVA: 0x006A3027 File Offset: 0x006A1227
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030DC3 RID: 200131 RVA: 0x006A3036 File Offset: 0x006A1236
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06030DC4 RID: 200132 RVA: 0x006A3044 File Offset: 0x006A1244
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CE8B RID: 52875
		// (get) Token: 0x06030DC5 RID: 200133 RVA: 0x006A3084 File Offset: 0x006A1284
		public int EntityIdsLength
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

		// Token: 0x06030DC6 RID: 200134 RVA: 0x006A30AF File Offset: 0x006A12AF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06030DC7 RID: 200135 RVA: 0x006A30BE File Offset: 0x006A12BE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700CE8C RID: 52876
		// (get) Token: 0x06030DC8 RID: 200136 RVA: 0x006A30CC File Offset: 0x006A12CC
		public int BehaviorTree
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE8D RID: 52877
		// (get) Token: 0x06030DC9 RID: 200137 RVA: 0x006A3108 File Offset: 0x006A1308
		public ICommonBtOverride? CommonBtOverride
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtOverride?(default(ICommonBtOverride).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CE8E RID: 52878
		// (get) Token: 0x06030DCA RID: 200138 RVA: 0x006A3168 File Offset: 0x006A1368
		public IConditionGroup? RemoveCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06030DCB RID: 200139 RVA: 0x006A31C6 File Offset: 0x006A13C6
		public static Offset<IOverrideAiBehaviorTree> CreateIOverrideAiBehaviorTree(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset EntityIdsOffset = default(VectorOffset), int BehaviorTree = 0, Offset<ICommonBtOverride> CommonBtOverrideOffset = default(Offset<ICommonBtOverride>), Offset<IConditionGroup> RemoveConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(5);
			IOverrideAiBehaviorTree.AddRemoveCondition(builder, RemoveConditionOffset);
			IOverrideAiBehaviorTree.AddCommonBtOverride(builder, CommonBtOverrideOffset);
			IOverrideAiBehaviorTree.AddBehaviorTree(builder, BehaviorTree);
			IOverrideAiBehaviorTree.AddEntityIds(builder, EntityIdsOffset);
			IOverrideAiBehaviorTree.AddKey(builder, KeyOffset);
			return IOverrideAiBehaviorTree.EndIOverrideAiBehaviorTree(builder);
		}

		// Token: 0x06030DCC RID: 200140 RVA: 0x006A31FA File Offset: 0x006A13FA
		public static void StartIOverrideAiBehaviorTree(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030DCD RID: 200141 RVA: 0x006A3203 File Offset: 0x006A1403
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06030DCE RID: 200142 RVA: 0x006A3213 File Offset: 0x006A1413
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06030DCF RID: 200143 RVA: 0x006A3224 File Offset: 0x006A1424
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030DD0 RID: 200144 RVA: 0x006A325B File Offset: 0x006A145B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030DD1 RID: 200145 RVA: 0x006A3275 File Offset: 0x006A1475
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030DD2 RID: 200146 RVA: 0x006A3293 File Offset: 0x006A1493
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030DD3 RID: 200147 RVA: 0x006A32AC File Offset: 0x006A14AC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030DD4 RID: 200148 RVA: 0x006A32B7 File Offset: 0x006A14B7
		public static void AddBehaviorTree(FlatBufferBuilder builder, int behaviorTree)
		{
			builder.AddInt(2, behaviorTree, 0);
		}

		// Token: 0x06030DD5 RID: 200149 RVA: 0x006A32C2 File Offset: 0x006A14C2
		public static void AddCommonBtOverride(FlatBufferBuilder builder, Offset<ICommonBtOverride> commonBtOverrideOffset)
		{
			builder.AddOffset(3, commonBtOverrideOffset.Value, 0);
		}

		// Token: 0x06030DD6 RID: 200150 RVA: 0x006A32D2 File Offset: 0x006A14D2
		public static void AddRemoveCondition(FlatBufferBuilder builder, Offset<IConditionGroup> removeConditionOffset)
		{
			builder.AddOffset(4, removeConditionOffset.Value, 0);
		}

		// Token: 0x06030DD7 RID: 200151 RVA: 0x006A32E2 File Offset: 0x006A14E2
		public static Offset<IOverrideAiBehaviorTree> EndIOverrideAiBehaviorTree(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideAiBehaviorTree>(builder.EndTable());
		}

		// Token: 0x06030DD8 RID: 200152 RVA: 0x006A32F0 File Offset: 0x006A14F0
		public IOverrideAiBehaviorTreeT UnPack()
		{
			IOverrideAiBehaviorTreeT overrideAiBehaviorTreeT = new IOverrideAiBehaviorTreeT();
			this.UnPackTo(overrideAiBehaviorTreeT);
			return overrideAiBehaviorTreeT;
		}

		// Token: 0x06030DD9 RID: 200153 RVA: 0x006A330C File Offset: 0x006A150C
		public void UnPackTo(IOverrideAiBehaviorTreeT _o)
		{
			_o.Key = this.Key;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.BehaviorTree = this.BehaviorTree;
			_o.CommonBtOverride = ((this.CommonBtOverride != null) ? this.CommonBtOverride.Value.UnPack() : null);
			_o.RemoveCondition = ((this.RemoveCondition != null) ? this.RemoveCondition.Value.UnPack() : null);
		}

		// Token: 0x06030DDA RID: 200154 RVA: 0x006A33C0 File Offset: 0x006A15C0
		public static Offset<IOverrideAiBehaviorTree> Pack(FlatBufferBuilder builder, IOverrideAiBehaviorTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideAiBehaviorTree>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IOverrideAiBehaviorTree.CreateEntityIdsVector(builder, data);
			}
			Offset<ICommonBtOverride> commonBtOverrideOffset = (_o.CommonBtOverride == null) ? default(Offset<ICommonBtOverride>) : ICommonBtOverride.Pack(builder, _o.CommonBtOverride);
			Offset<IConditionGroup> removeConditionOffset = (_o.RemoveCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.RemoveCondition);
			return IOverrideAiBehaviorTree.CreateIOverrideAiBehaviorTree(builder, keyOffset, entityIdsOffset, _o.BehaviorTree, commonBtOverrideOffset, removeConditionOffset);
		}

		// Token: 0x04011594 RID: 71060
		private Table __p;
	}
}
