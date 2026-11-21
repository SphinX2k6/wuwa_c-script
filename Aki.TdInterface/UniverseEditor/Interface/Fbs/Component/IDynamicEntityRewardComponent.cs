using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005640 RID: 22080
	public struct IDynamicEntityRewardComponent : IFlatbufferObject
	{
		// Token: 0x17009E9B RID: 40603
		// (get) Token: 0x06023459 RID: 144473 RVA: 0x004DA67B File Offset: 0x004D887B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602345A RID: 144474 RVA: 0x004DA688 File Offset: 0x004D8888
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602345B RID: 144475 RVA: 0x004DA690 File Offset: 0x004D8890
		public static IDynamicEntityRewardComponent GetRootAsIDynamicEntityRewardComponent(ByteBuffer _bb)
		{
			return IDynamicEntityRewardComponent.GetRootAsIDynamicEntityRewardComponent(_bb, default(IDynamicEntityRewardComponent));
		}

		// Token: 0x0602345C RID: 144476 RVA: 0x004DA6AC File Offset: 0x004D88AC
		public static IDynamicEntityRewardComponent GetRootAsIDynamicEntityRewardComponent(ByteBuffer _bb, IDynamicEntityRewardComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602345D RID: 144477 RVA: 0x004DA6C9 File Offset: 0x004D88C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602345E RID: 144478 RVA: 0x004DA6D8 File Offset: 0x004D88D8
		public IDynamicEntityRewardComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E9C RID: 40604
		// (get) Token: 0x0602345F RID: 144479 RVA: 0x004DA6E8 File Offset: 0x004D88E8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E9D RID: 40605
		// (get) Token: 0x06023460 RID: 144480 RVA: 0x004DA728 File Offset: 0x004D8928
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

		// Token: 0x06023461 RID: 144481 RVA: 0x004DA788 File Offset: 0x004D8988
		public EClaimDynamicEntityRewardType ClaimTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return EClaimDynamicEntityRewardType.Hook;
			}
			return (EClaimDynamicEntityRewardType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009E9E RID: 40606
		// (get) Token: 0x06023462 RID: 144482 RVA: 0x004DA7C8 File Offset: 0x004D89C8
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

		// Token: 0x06023463 RID: 144483 RVA: 0x004DA7F3 File Offset: 0x004D89F3
		public Span<EClaimDynamicEntityRewardType> GetClaimTypesBytes()
		{
			return this.__p.__vector_as_span<EClaimDynamicEntityRewardType>(8, 1);
		}

		// Token: 0x06023464 RID: 144484 RVA: 0x004DA804 File Offset: 0x004D8A04
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

		// Token: 0x06023465 RID: 144485 RVA: 0x004DA870 File Offset: 0x004D8A70
		public IActionInfo? RewardActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E9F RID: 40607
		// (get) Token: 0x06023466 RID: 144486 RVA: 0x004DA8D4 File Offset: 0x004D8AD4
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

		// Token: 0x17009EA0 RID: 40608
		// (get) Token: 0x06023467 RID: 144487 RVA: 0x004DA900 File Offset: 0x004D8B00
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

		// Token: 0x06023468 RID: 144488 RVA: 0x004DA93D File Offset: 0x004D8B3D
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

		// Token: 0x06023469 RID: 144489 RVA: 0x004DA971 File Offset: 0x004D8B71
		public static void StartIDynamicEntityRewardComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602346A RID: 144490 RVA: 0x004DA97A File Offset: 0x004D8B7A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602346B RID: 144491 RVA: 0x004DA985 File Offset: 0x004D8B85
		public static void AddRewardType(FlatBufferBuilder builder, Offset<IDynamicTrafficReward> rewardTypeOffset)
		{
			builder.AddOffset(1, rewardTypeOffset.Value, 0);
		}

		// Token: 0x0602346C RID: 144492 RVA: 0x004DA995 File Offset: 0x004D8B95
		public static void AddClaimTypes(FlatBufferBuilder builder, VectorOffset claimTypesOffset)
		{
			builder.AddOffset(2, claimTypesOffset.Value, 0);
		}

		// Token: 0x0602346D RID: 144493 RVA: 0x004DA9A8 File Offset: 0x004D8BA8
		public static VectorOffset CreateClaimTypesVector(FlatBufferBuilder builder, EClaimDynamicEntityRewardType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602346E RID: 144494 RVA: 0x004DA9DF File Offset: 0x004D8BDF
		public static VectorOffset CreateClaimTypesVectorBlock(FlatBufferBuilder builder, EClaimDynamicEntityRewardType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EClaimDynamicEntityRewardType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602346F RID: 144495 RVA: 0x004DA9F9 File Offset: 0x004D8BF9
		public static VectorOffset CreateClaimTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<EClaimDynamicEntityRewardType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EClaimDynamicEntityRewardType>(data);
			return builder.EndVector();
		}

		// Token: 0x06023470 RID: 144496 RVA: 0x004DAA17 File Offset: 0x004D8C17
		public static VectorOffset CreateClaimTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EClaimDynamicEntityRewardType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023471 RID: 144497 RVA: 0x004DAA30 File Offset: 0x004D8C30
		public static void StartClaimTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06023472 RID: 144498 RVA: 0x004DAA3B File Offset: 0x004D8C3B
		public static void AddRewardActions(FlatBufferBuilder builder, VectorOffset rewardActionsOffset)
		{
			builder.AddOffset(3, rewardActionsOffset.Value, 0);
		}

		// Token: 0x06023473 RID: 144499 RVA: 0x004DAA4C File Offset: 0x004D8C4C
		public static VectorOffset CreateRewardActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023474 RID: 144500 RVA: 0x004DAA8C File Offset: 0x004D8C8C
		public static VectorOffset CreateRewardActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023475 RID: 144501 RVA: 0x004DAAA6 File Offset: 0x004D8CA6
		public static VectorOffset CreateRewardActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023476 RID: 144502 RVA: 0x004DAAC4 File Offset: 0x004D8CC4
		public static VectorOffset CreateRewardActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023477 RID: 144503 RVA: 0x004DAADD File Offset: 0x004D8CDD
		public static void StartRewardActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023478 RID: 144504 RVA: 0x004DAAE8 File Offset: 0x004D8CE8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023479 RID: 144505 RVA: 0x004DAAF3 File Offset: 0x004D8CF3
		public static Offset<IDynamicEntityRewardComponent> EndIDynamicEntityRewardComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicEntityRewardComponent>(builder.EndTable());
		}

		// Token: 0x0602347A RID: 144506 RVA: 0x004DAB00 File Offset: 0x004D8D00
		public IDynamicEntityRewardComponentT UnPack()
		{
			IDynamicEntityRewardComponentT dynamicEntityRewardComponentT = new IDynamicEntityRewardComponentT();
			this.UnPackTo(dynamicEntityRewardComponentT);
			return dynamicEntityRewardComponentT;
		}

		// Token: 0x0602347B RID: 144507 RVA: 0x004DAB1C File Offset: 0x004D8D1C
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

		// Token: 0x0602347C RID: 144508 RVA: 0x004DABF4 File Offset: 0x004D8DF4
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

		// Token: 0x0400ED25 RID: 60709
		private Table __p;
	}
}
