using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044DF RID: 17631
	public struct IInteractRewardParam : IFlatbufferObject
	{
		// Token: 0x17007C72 RID: 31858
		// (get) Token: 0x0601A5C4 RID: 107972 RVA: 0x003C32DC File Offset: 0x003C14DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A5C5 RID: 107973 RVA: 0x003C32E9 File Offset: 0x003C14E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A5C6 RID: 107974 RVA: 0x003C32F0 File Offset: 0x003C14F0
		public static IInteractRewardParam GetRootAsIInteractRewardParam(ByteBuffer _bb)
		{
			return IInteractRewardParam.GetRootAsIInteractRewardParam(_bb, default(IInteractRewardParam));
		}

		// Token: 0x0601A5C7 RID: 107975 RVA: 0x003C330C File Offset: 0x003C150C
		public static IInteractRewardParam GetRootAsIInteractRewardParam(ByteBuffer _bb, IInteractRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A5C8 RID: 107976 RVA: 0x003C3329 File Offset: 0x003C1529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A5C9 RID: 107977 RVA: 0x003C3338 File Offset: 0x003C1538
		public IInteractRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C73 RID: 31859
		// (get) Token: 0x0601A5CA RID: 107978 RVA: 0x003C3348 File Offset: 0x003C1548
		public ELevelPlayRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRewardType.None;
				}
				return (ELevelPlayRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007C74 RID: 31860
		// (get) Token: 0x0601A5CB RID: 107979 RVA: 0x003C3384 File Offset: 0x003C1584
		public int RewardId
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

		// Token: 0x17007C75 RID: 31861
		// (get) Token: 0x0601A5CC RID: 107980 RVA: 0x003C33C0 File Offset: 0x003C15C0
		public int FirstRewardId
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

		// Token: 0x17007C76 RID: 31862
		// (get) Token: 0x0601A5CD RID: 107981 RVA: 0x003C33FC File Offset: 0x003C15FC
		public int RewardEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007C77 RID: 31863
		// (get) Token: 0x0601A5CE RID: 107982 RVA: 0x003C343C File Offset: 0x003C163C
		public ILevelPlayInteractResetOption? Reset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayInteractResetOption?(default(ILevelPlayInteractResetOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A5CF RID: 107983 RVA: 0x003C349C File Offset: 0x003C169C
		public IActionInfo? RewardCompleteActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C78 RID: 31864
		// (get) Token: 0x0601A5D0 RID: 107984 RVA: 0x003C3500 File Offset: 0x003C1700
		public int RewardCompleteActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601A5D1 RID: 107985 RVA: 0x003C352C File Offset: 0x003C172C
		public IActionInfo? FirstCompleteActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C79 RID: 31865
		// (get) Token: 0x0601A5D2 RID: 107986 RVA: 0x003C3590 File Offset: 0x003C1790
		public int FirstCompleteActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007C7A RID: 31866
		// (get) Token: 0x0601A5D3 RID: 107987 RVA: 0x003C35BC File Offset: 0x003C17BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A5D4 RID: 107988 RVA: 0x003C35FC File Offset: 0x003C17FC
		public static Offset<IInteractRewardParam> CreateIInteractRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None, int RewardId = 0, int FirstRewardId = 0, int RewardEntityId = 0, Offset<ILevelPlayInteractResetOption> ResetOffset = default(Offset<ILevelPlayInteractResetOption>), VectorOffset RewardCompleteActionsOffset = default(VectorOffset), VectorOffset FirstCompleteActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IInteractRewardParam.AddFirstCompleteActions(builder, FirstCompleteActionsOffset);
			IInteractRewardParam.AddRewardCompleteActions(builder, RewardCompleteActionsOffset);
			IInteractRewardParam.AddReset(builder, ResetOffset);
			IInteractRewardParam.AddRewardEntityId(builder, RewardEntityId);
			IInteractRewardParam.AddFirstRewardId(builder, FirstRewardId);
			IInteractRewardParam.AddRewardId(builder, RewardId);
			IInteractRewardParam.AddNullMask(builder, NullMask);
			IInteractRewardParam.AddType(builder, Type);
			return IInteractRewardParam.EndIInteractRewardParam(builder);
		}

		// Token: 0x0601A5D5 RID: 107989 RVA: 0x003C3653 File Offset: 0x003C1853
		public static void StartIInteractRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601A5D6 RID: 107990 RVA: 0x003C365C File Offset: 0x003C185C
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A5D7 RID: 107991 RVA: 0x003C3667 File Offset: 0x003C1867
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x0601A5D8 RID: 107992 RVA: 0x003C3672 File Offset: 0x003C1872
		public static void AddFirstRewardId(FlatBufferBuilder builder, int firstRewardId)
		{
			builder.AddInt(2, firstRewardId, 0);
		}

		// Token: 0x0601A5D9 RID: 107993 RVA: 0x003C367D File Offset: 0x003C187D
		public static void AddRewardEntityId(FlatBufferBuilder builder, int rewardEntityId)
		{
			builder.AddInt(3, rewardEntityId, 0);
		}

		// Token: 0x0601A5DA RID: 107994 RVA: 0x003C3688 File Offset: 0x003C1888
		public static void AddReset(FlatBufferBuilder builder, Offset<ILevelPlayInteractResetOption> resetOffset)
		{
			builder.AddOffset(4, resetOffset.Value, 0);
		}

		// Token: 0x0601A5DB RID: 107995 RVA: 0x003C3698 File Offset: 0x003C1898
		public static void AddRewardCompleteActions(FlatBufferBuilder builder, VectorOffset rewardCompleteActionsOffset)
		{
			builder.AddOffset(5, rewardCompleteActionsOffset.Value, 0);
		}

		// Token: 0x0601A5DC RID: 107996 RVA: 0x003C36A8 File Offset: 0x003C18A8
		public static VectorOffset CreateRewardCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A5DD RID: 107997 RVA: 0x003C36E8 File Offset: 0x003C18E8
		public static VectorOffset CreateRewardCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A5DE RID: 107998 RVA: 0x003C3702 File Offset: 0x003C1902
		public static VectorOffset CreateRewardCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A5DF RID: 107999 RVA: 0x003C3720 File Offset: 0x003C1920
		public static VectorOffset CreateRewardCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A5E0 RID: 108000 RVA: 0x003C3739 File Offset: 0x003C1939
		public static void StartRewardCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A5E1 RID: 108001 RVA: 0x003C3744 File Offset: 0x003C1944
		public static void AddFirstCompleteActions(FlatBufferBuilder builder, VectorOffset firstCompleteActionsOffset)
		{
			builder.AddOffset(6, firstCompleteActionsOffset.Value, 0);
		}

		// Token: 0x0601A5E2 RID: 108002 RVA: 0x003C3754 File Offset: 0x003C1954
		public static VectorOffset CreateFirstCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A5E3 RID: 108003 RVA: 0x003C3794 File Offset: 0x003C1994
		public static VectorOffset CreateFirstCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A5E4 RID: 108004 RVA: 0x003C37AE File Offset: 0x003C19AE
		public static VectorOffset CreateFirstCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A5E5 RID: 108005 RVA: 0x003C37CC File Offset: 0x003C19CC
		public static VectorOffset CreateFirstCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A5E6 RID: 108006 RVA: 0x003C37E5 File Offset: 0x003C19E5
		public static void StartFirstCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A5E7 RID: 108007 RVA: 0x003C37F0 File Offset: 0x003C19F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601A5E8 RID: 108008 RVA: 0x003C37FB File Offset: 0x003C19FB
		public static Offset<IInteractRewardParam> EndIInteractRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<IInteractRewardParam>(builder.EndTable());
		}

		// Token: 0x0601A5E9 RID: 108009 RVA: 0x003C3808 File Offset: 0x003C1A08
		public IInteractRewardParamT UnPack()
		{
			IInteractRewardParamT interactRewardParamT = new IInteractRewardParamT();
			this.UnPackTo(interactRewardParamT);
			return interactRewardParamT;
		}

		// Token: 0x0601A5EA RID: 108010 RVA: 0x003C3824 File Offset: 0x003C1A24
		public void UnPackTo(IInteractRewardParamT _o)
		{
			_o.Type = this.Type;
			_o.RewardId = this.RewardId;
			_o.FirstRewardId = this.FirstRewardId;
			_o.RewardEntityId = this.RewardEntityId;
			_o.Reset = ((this.Reset != null) ? this.Reset.Value.UnPack() : null);
			_o.RewardCompleteActions = new List<IActionInfoT>();
			for (int i = 0; i < this.RewardCompleteActionsLength; i++)
			{
				_o.RewardCompleteActions.Add((this.RewardCompleteActions(i) != null) ? this.RewardCompleteActions(i).Value.UnPack() : null);
			}
			_o.FirstCompleteActions = new List<IActionInfoT>();
			for (int j = 0; j < this.FirstCompleteActionsLength; j++)
			{
				_o.FirstCompleteActions.Add((this.FirstCompleteActions(j) != null) ? this.FirstCompleteActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A5EB RID: 108011 RVA: 0x003C3948 File Offset: 0x003C1B48
		public static Offset<IInteractRewardParam> Pack(FlatBufferBuilder builder, IInteractRewardParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractRewardParam>);
			}
			Offset<ILevelPlayInteractResetOption> resetOffset = (_o.Reset == null) ? default(Offset<ILevelPlayInteractResetOption>) : ILevelPlayInteractResetOption.Pack(builder, _o.Reset);
			VectorOffset rewardCompleteActionsOffset = default(VectorOffset);
			if (_o.RewardCompleteActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.RewardCompleteActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.RewardCompleteActions[i]);
				}
				rewardCompleteActionsOffset = IInteractRewardParam.CreateRewardCompleteActionsVector(builder, array);
			}
			VectorOffset firstCompleteActionsOffset = default(VectorOffset);
			if (_o.FirstCompleteActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.FirstCompleteActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.FirstCompleteActions[j]);
				}
				firstCompleteActionsOffset = IInteractRewardParam.CreateFirstCompleteActionsVector(builder, array2);
			}
			return IInteractRewardParam.CreateIInteractRewardParam(builder, _o.Type, _o.RewardId, _o.FirstRewardId, _o.RewardEntityId, resetOffset, rewardCompleteActionsOffset, firstCompleteActionsOffset, _o.NullMask);
		}

		// Token: 0x0400C4F8 RID: 50424
		private Table __p;
	}
}
