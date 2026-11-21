using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BB RID: 29627
	public struct IOverrideAiBehaviorTree : IFlatbufferObject
	{
		// Token: 0x1700D9A4 RID: 55716
		// (get) Token: 0x06033D16 RID: 212246 RVA: 0x006FD482 File Offset: 0x006FB682
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D17 RID: 212247 RVA: 0x006FD48F File Offset: 0x006FB68F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D18 RID: 212248 RVA: 0x006FD498 File Offset: 0x006FB698
		public static IOverrideAiBehaviorTree GetRootAsIOverrideAiBehaviorTree(ByteBuffer _bb)
		{
			return IOverrideAiBehaviorTree.GetRootAsIOverrideAiBehaviorTree(_bb, default(IOverrideAiBehaviorTree));
		}

		// Token: 0x06033D19 RID: 212249 RVA: 0x006FD4B4 File Offset: 0x006FB6B4
		public static IOverrideAiBehaviorTree GetRootAsIOverrideAiBehaviorTree(ByteBuffer _bb, IOverrideAiBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D1A RID: 212250 RVA: 0x006FD4D1 File Offset: 0x006FB6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D1B RID: 212251 RVA: 0x006FD4E0 File Offset: 0x006FB6E0
		public IOverrideAiBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9A5 RID: 55717
		// (get) Token: 0x06033D1C RID: 212252 RVA: 0x006FD4F0 File Offset: 0x006FB6F0
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

		// Token: 0x06033D1D RID: 212253 RVA: 0x006FD527 File Offset: 0x006FB727
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033D1E RID: 212254 RVA: 0x006FD536 File Offset: 0x006FB736
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06033D1F RID: 212255 RVA: 0x006FD544 File Offset: 0x006FB744
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D9A6 RID: 55718
		// (get) Token: 0x06033D20 RID: 212256 RVA: 0x006FD584 File Offset: 0x006FB784
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

		// Token: 0x06033D21 RID: 212257 RVA: 0x006FD5AF File Offset: 0x006FB7AF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033D22 RID: 212258 RVA: 0x006FD5BE File Offset: 0x006FB7BE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D9A7 RID: 55719
		// (get) Token: 0x06033D23 RID: 212259 RVA: 0x006FD5CC File Offset: 0x006FB7CC
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

		// Token: 0x1700D9A8 RID: 55720
		// (get) Token: 0x06033D24 RID: 212260 RVA: 0x006FD608 File Offset: 0x006FB808
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

		// Token: 0x1700D9A9 RID: 55721
		// (get) Token: 0x06033D25 RID: 212261 RVA: 0x006FD668 File Offset: 0x006FB868
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

		// Token: 0x06033D26 RID: 212262 RVA: 0x006FD6C6 File Offset: 0x006FB8C6
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

		// Token: 0x06033D27 RID: 212263 RVA: 0x006FD6FA File Offset: 0x006FB8FA
		public static void StartIOverrideAiBehaviorTree(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033D28 RID: 212264 RVA: 0x006FD703 File Offset: 0x006FB903
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06033D29 RID: 212265 RVA: 0x006FD713 File Offset: 0x006FB913
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06033D2A RID: 212266 RVA: 0x006FD724 File Offset: 0x006FB924
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033D2B RID: 212267 RVA: 0x006FD75B File Offset: 0x006FB95B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033D2C RID: 212268 RVA: 0x006FD775 File Offset: 0x006FB975
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033D2D RID: 212269 RVA: 0x006FD793 File Offset: 0x006FB993
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033D2E RID: 212270 RVA: 0x006FD7AC File Offset: 0x006FB9AC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033D2F RID: 212271 RVA: 0x006FD7B7 File Offset: 0x006FB9B7
		public static void AddBehaviorTree(FlatBufferBuilder builder, int behaviorTree)
		{
			builder.AddInt(2, behaviorTree, 0);
		}

		// Token: 0x06033D30 RID: 212272 RVA: 0x006FD7C2 File Offset: 0x006FB9C2
		public static void AddCommonBtOverride(FlatBufferBuilder builder, Offset<ICommonBtOverride> commonBtOverrideOffset)
		{
			builder.AddOffset(3, commonBtOverrideOffset.Value, 0);
		}

		// Token: 0x06033D31 RID: 212273 RVA: 0x006FD7D2 File Offset: 0x006FB9D2
		public static void AddRemoveCondition(FlatBufferBuilder builder, Offset<IConditionGroup> removeConditionOffset)
		{
			builder.AddOffset(4, removeConditionOffset.Value, 0);
		}

		// Token: 0x06033D32 RID: 212274 RVA: 0x006FD7E2 File Offset: 0x006FB9E2
		public static Offset<IOverrideAiBehaviorTree> EndIOverrideAiBehaviorTree(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideAiBehaviorTree>(builder.EndTable());
		}

		// Token: 0x06033D33 RID: 212275 RVA: 0x006FD7F0 File Offset: 0x006FB9F0
		public IOverrideAiBehaviorTreeT UnPack()
		{
			IOverrideAiBehaviorTreeT overrideAiBehaviorTreeT = new IOverrideAiBehaviorTreeT();
			this.UnPackTo(overrideAiBehaviorTreeT);
			return overrideAiBehaviorTreeT;
		}

		// Token: 0x06033D34 RID: 212276 RVA: 0x006FD80C File Offset: 0x006FBA0C
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

		// Token: 0x06033D35 RID: 212277 RVA: 0x006FD8C0 File Offset: 0x006FBAC0
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

		// Token: 0x040124EC RID: 74988
		private Table __p;
	}
}
