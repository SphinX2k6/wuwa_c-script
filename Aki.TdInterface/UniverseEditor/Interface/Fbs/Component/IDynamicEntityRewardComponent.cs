using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050DB RID: 20699
	public struct IDynamicEntityRewardComponent : IFlatbufferObject
	{
		// Token: 0x170096AE RID: 38574
		// (get) Token: 0x06021505 RID: 136453 RVA: 0x004A06EF File Offset: 0x0049E8EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021506 RID: 136454 RVA: 0x004A06FC File Offset: 0x0049E8FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021507 RID: 136455 RVA: 0x004A0704 File Offset: 0x0049E904
		public static IDynamicEntityRewardComponent GetRootAsIDynamicEntityRewardComponent(ByteBuffer _bb)
		{
			return IDynamicEntityRewardComponent.GetRootAsIDynamicEntityRewardComponent(_bb, default(IDynamicEntityRewardComponent));
		}

		// Token: 0x06021508 RID: 136456 RVA: 0x004A0720 File Offset: 0x0049E920
		public static IDynamicEntityRewardComponent GetRootAsIDynamicEntityRewardComponent(ByteBuffer _bb, IDynamicEntityRewardComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021509 RID: 136457 RVA: 0x004A073D File Offset: 0x0049E93D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602150A RID: 136458 RVA: 0x004A074C File Offset: 0x0049E94C
		public IDynamicEntityRewardComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096AF RID: 38575
		// (get) Token: 0x0602150B RID: 136459 RVA: 0x004A075C File Offset: 0x0049E95C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170096B0 RID: 38576
		// (get) Token: 0x0602150C RID: 136460 RVA: 0x004A079C File Offset: 0x0049E99C
		public IDynamicTrafficReward? RewardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicTrafficReward?(default(IDynamicTrafficReward).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602150D RID: 136461 RVA: 0x004A07FC File Offset: 0x0049E9FC
		public EClaimDynamicEntityRewardType ClaimTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return EClaimDynamicEntityRewardType.Hook;
			}
			return (EClaimDynamicEntityRewardType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170096B1 RID: 38577
		// (get) Token: 0x0602150E RID: 136462 RVA: 0x004A083C File Offset: 0x0049EA3C
		public int ClaimTypesLength
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

		// Token: 0x0602150F RID: 136463 RVA: 0x004A0867 File Offset: 0x0049EA67
		public Span<EClaimDynamicEntityRewardType> GetClaimTypesBytes()
		{
			return this.__p.__vector_as_span<EClaimDynamicEntityRewardType>(8, 1);
		}

		// Token: 0x06021510 RID: 136464 RVA: 0x004A0878 File Offset: 0x0049EA78
		public EClaimDynamicEntityRewardType[] GetClaimTypesArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EClaimDynamicEntityRewardType[] array = new EClaimDynamicEntityRewardType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EClaimDynamicEntityRewardType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06021511 RID: 136465 RVA: 0x004A08E4 File Offset: 0x0049EAE4
		public IActionInfo? RewardActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170096B2 RID: 38578
		// (get) Token: 0x06021512 RID: 136466 RVA: 0x004A0948 File Offset: 0x0049EB48
		public int RewardActionsLength
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

		// Token: 0x170096B3 RID: 38579
		// (get) Token: 0x06021513 RID: 136467 RVA: 0x004A0974 File Offset: 0x0049EB74
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

		// Token: 0x06021514 RID: 136468 RVA: 0x004A09B1 File Offset: 0x0049EBB1
		public static Offset<IDynamicEntityRewardComponent> CreateIDynamicEntityRewardComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IDynamicTrafficReward> RewardTypeOffset = default(Offset<IDynamicTrafficReward>), VectorOffset ClaimTypesOffset = default(VectorOffset), VectorOffset RewardActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IDynamicEntityRewardComponent.AddRewardActions(builder, RewardActionsOffset);
			IDynamicEntityRewardComponent.AddClaimTypes(builder, ClaimTypesOffset);
			IDynamicEntityRewardComponent.AddRewardType(builder, RewardTypeOffset);
			IDynamicEntityRewardComponent.AddNullMask(builder, NullMask);
			IDynamicEntityRewardComponent.AddDisabled(builder, Disabled);
			return IDynamicEntityRewardComponent.EndIDynamicEntityRewardComponent(builder);
		}

		// Token: 0x06021515 RID: 136469 RVA: 0x004A09E5 File Offset: 0x0049EBE5
		public static void StartIDynamicEntityRewardComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021516 RID: 136470 RVA: 0x004A09EE File Offset: 0x0049EBEE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021517 RID: 136471 RVA: 0x004A09F9 File Offset: 0x0049EBF9
		public static void AddRewardType(FlatBufferBuilder builder, Offset<IDynamicTrafficReward> rewardTypeOffset)
		{
			builder.AddOffset(1, rewardTypeOffset.Value, 0);
		}

		// Token: 0x06021518 RID: 136472 RVA: 0x004A0A09 File Offset: 0x0049EC09
		public static void AddClaimTypes(FlatBufferBuilder builder, VectorOffset claimTypesOffset)
		{
			builder.AddOffset(2, claimTypesOffset.Value, 0);
		}

		// Token: 0x06021519 RID: 136473 RVA: 0x004A0A1C File Offset: 0x0049EC1C
		public static VectorOffset CreateClaimTypesVector(FlatBufferBuilder builder, EClaimDynamicEntityRewardType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602151A RID: 136474 RVA: 0x004A0A53 File Offset: 0x0049EC53
		public static VectorOffset CreateClaimTypesVectorBlock(FlatBufferBuilder builder, EClaimDynamicEntityRewardType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EClaimDynamicEntityRewardType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602151B RID: 136475 RVA: 0x004A0A6D File Offset: 0x0049EC6D
		public static VectorOffset CreateClaimTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<EClaimDynamicEntityRewardType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EClaimDynamicEntityRewardType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602151C RID: 136476 RVA: 0x004A0A8B File Offset: 0x0049EC8B
		public static VectorOffset CreateClaimTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EClaimDynamicEntityRewardType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602151D RID: 136477 RVA: 0x004A0AA4 File Offset: 0x0049ECA4
		public static void StartClaimTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602151E RID: 136478 RVA: 0x004A0AAF File Offset: 0x0049ECAF
		public static void AddRewardActions(FlatBufferBuilder builder, VectorOffset rewardActionsOffset)
		{
			builder.AddOffset(3, rewardActionsOffset.Value, 0);
		}

		// Token: 0x0602151F RID: 136479 RVA: 0x004A0AC0 File Offset: 0x0049ECC0
		public static VectorOffset CreateRewardActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021520 RID: 136480 RVA: 0x004A0B00 File Offset: 0x0049ED00
		public static VectorOffset CreateRewardActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021521 RID: 136481 RVA: 0x004A0B1A File Offset: 0x0049ED1A
		public static VectorOffset CreateRewardActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021522 RID: 136482 RVA: 0x004A0B38 File Offset: 0x0049ED38
		public static VectorOffset CreateRewardActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021523 RID: 136483 RVA: 0x004A0B51 File Offset: 0x0049ED51
		public static void StartRewardActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021524 RID: 136484 RVA: 0x004A0B5C File Offset: 0x0049ED5C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021525 RID: 136485 RVA: 0x004A0B67 File Offset: 0x0049ED67
		public static Offset<IDynamicEntityRewardComponent> EndIDynamicEntityRewardComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicEntityRewardComponent>(builder.EndTable());
		}

		// Token: 0x06021526 RID: 136486 RVA: 0x004A0B74 File Offset: 0x0049ED74
		public IDynamicEntityRewardComponentT UnPack()
		{
			IDynamicEntityRewardComponentT dynamicEntityRewardComponentT = new IDynamicEntityRewardComponentT();
			this.UnPackTo(dynamicEntityRewardComponentT);
			return dynamicEntityRewardComponentT;
		}

		// Token: 0x06021527 RID: 136487 RVA: 0x004A0B90 File Offset: 0x0049ED90
		public void UnPackTo(IDynamicEntityRewardComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RewardType = ((this.RewardType != null) ? this.RewardType.Value.UnPack() : null);
			_o.ClaimTypes = new List<EClaimDynamicEntityRewardType>();
			for (int i = 0; i < this.ClaimTypesLength; i++)
			{
				_o.ClaimTypes.Add(this.ClaimTypes(i));
			}
			_o.RewardActions = new List<IActionInfoT>();
			for (int j = 0; j < this.RewardActionsLength; j++)
			{
				_o.RewardActions.Add((this.RewardActions(j) != null) ? this.RewardActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021528 RID: 136488 RVA: 0x004A0C68 File Offset: 0x0049EE68
		public static Offset<IDynamicEntityRewardComponent> Pack(FlatBufferBuilder builder, IDynamicEntityRewardComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicEntityRewardComponent>);
			}
			Offset<IDynamicTrafficReward> rewardTypeOffset = (_o.RewardType == null) ? default(Offset<IDynamicTrafficReward>) : IDynamicTrafficReward.Pack(builder, _o.RewardType);
			VectorOffset claimTypesOffset = default(VectorOffset);
			if (_o.ClaimTypes != null)
			{
				EClaimDynamicEntityRewardType[] data = _o.ClaimTypes.ToArray();
				claimTypesOffset = IDynamicEntityRewardComponent.CreateClaimTypesVector(builder, data);
			}
			VectorOffset rewardActionsOffset = default(VectorOffset);
			if (_o.RewardActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.RewardActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.RewardActions[i]);
				}
				rewardActionsOffset = IDynamicEntityRewardComponent.CreateRewardActionsVector(builder, array);
			}
			return IDynamicEntityRewardComponent.CreateIDynamicEntityRewardComponent(builder, _o.Disabled, rewardTypeOffset, claimTypesOffset, rewardActionsOffset, _o.NullMask);
		}

		// Token: 0x0400E128 RID: 57640
		private Table __p;
	}
}
