using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004947 RID: 18759
	public struct IInteractRewardParam : IFlatbufferObject
	{
		// Token: 0x170082B1 RID: 33457
		// (get) Token: 0x0601BD95 RID: 114069 RVA: 0x003EF4E8 File Offset: 0x003ED6E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD96 RID: 114070 RVA: 0x003EF4F5 File Offset: 0x003ED6F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD97 RID: 114071 RVA: 0x003EF4FC File Offset: 0x003ED6FC
		public static IInteractRewardParam GetRootAsIInteractRewardParam(ByteBuffer _bb)
		{
			return IInteractRewardParam.GetRootAsIInteractRewardParam(_bb, default(IInteractRewardParam));
		}

		// Token: 0x0601BD98 RID: 114072 RVA: 0x003EF518 File Offset: 0x003ED718
		public static IInteractRewardParam GetRootAsIInteractRewardParam(ByteBuffer _bb, IInteractRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD99 RID: 114073 RVA: 0x003EF535 File Offset: 0x003ED735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD9A RID: 114074 RVA: 0x003EF544 File Offset: 0x003ED744
		public IInteractRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082B2 RID: 33458
		// (get) Token: 0x0601BD9B RID: 114075 RVA: 0x003EF554 File Offset: 0x003ED754
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

		// Token: 0x170082B3 RID: 33459
		// (get) Token: 0x0601BD9C RID: 114076 RVA: 0x003EF590 File Offset: 0x003ED790
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

		// Token: 0x170082B4 RID: 33460
		// (get) Token: 0x0601BD9D RID: 114077 RVA: 0x003EF5CC File Offset: 0x003ED7CC
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

		// Token: 0x170082B5 RID: 33461
		// (get) Token: 0x0601BD9E RID: 114078 RVA: 0x003EF608 File Offset: 0x003ED808
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

		// Token: 0x170082B6 RID: 33462
		// (get) Token: 0x0601BD9F RID: 114079 RVA: 0x003EF648 File Offset: 0x003ED848
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

		// Token: 0x0601BDA0 RID: 114080 RVA: 0x003EF6A8 File Offset: 0x003ED8A8
		public IActionInfo? RewardCompleteActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082B7 RID: 33463
		// (get) Token: 0x0601BDA1 RID: 114081 RVA: 0x003EF70C File Offset: 0x003ED90C
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

		// Token: 0x0601BDA2 RID: 114082 RVA: 0x003EF738 File Offset: 0x003ED938
		public IActionInfo? FirstCompleteActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082B8 RID: 33464
		// (get) Token: 0x0601BDA3 RID: 114083 RVA: 0x003EF79C File Offset: 0x003ED99C
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

		// Token: 0x170082B9 RID: 33465
		// (get) Token: 0x0601BDA4 RID: 114084 RVA: 0x003EF7C8 File Offset: 0x003ED9C8
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

		// Token: 0x0601BDA5 RID: 114085 RVA: 0x003EF808 File Offset: 0x003EDA08
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

		// Token: 0x0601BDA6 RID: 114086 RVA: 0x003EF85F File Offset: 0x003EDA5F
		public static void StartIInteractRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601BDA7 RID: 114087 RVA: 0x003EF868 File Offset: 0x003EDA68
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BDA8 RID: 114088 RVA: 0x003EF873 File Offset: 0x003EDA73
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x0601BDA9 RID: 114089 RVA: 0x003EF87E File Offset: 0x003EDA7E
		public static void AddFirstRewardId(FlatBufferBuilder builder, int firstRewardId)
		{
			builder.AddInt(2, firstRewardId, 0);
		}

		// Token: 0x0601BDAA RID: 114090 RVA: 0x003EF889 File Offset: 0x003EDA89
		public static void AddRewardEntityId(FlatBufferBuilder builder, int rewardEntityId)
		{
			builder.AddInt(3, rewardEntityId, 0);
		}

		// Token: 0x0601BDAB RID: 114091 RVA: 0x003EF894 File Offset: 0x003EDA94
		public static void AddReset(FlatBufferBuilder builder, Offset<ILevelPlayInteractResetOption> resetOffset)
		{
			builder.AddOffset(4, resetOffset.Value, 0);
		}

		// Token: 0x0601BDAC RID: 114092 RVA: 0x003EF8A4 File Offset: 0x003EDAA4
		public static void AddRewardCompleteActions(FlatBufferBuilder builder, VectorOffset rewardCompleteActionsOffset)
		{
			builder.AddOffset(5, rewardCompleteActionsOffset.Value, 0);
		}

		// Token: 0x0601BDAD RID: 114093 RVA: 0x003EF8B4 File Offset: 0x003EDAB4
		public static VectorOffset CreateRewardCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BDAE RID: 114094 RVA: 0x003EF8F4 File Offset: 0x003EDAF4
		public static VectorOffset CreateRewardCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDAF RID: 114095 RVA: 0x003EF90E File Offset: 0x003EDB0E
		public static VectorOffset CreateRewardCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDB0 RID: 114096 RVA: 0x003EF92C File Offset: 0x003EDB2C
		public static VectorOffset CreateRewardCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BDB1 RID: 114097 RVA: 0x003EF945 File Offset: 0x003EDB45
		public static void StartRewardCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BDB2 RID: 114098 RVA: 0x003EF950 File Offset: 0x003EDB50
		public static void AddFirstCompleteActions(FlatBufferBuilder builder, VectorOffset firstCompleteActionsOffset)
		{
			builder.AddOffset(6, firstCompleteActionsOffset.Value, 0);
		}

		// Token: 0x0601BDB3 RID: 114099 RVA: 0x003EF960 File Offset: 0x003EDB60
		public static VectorOffset CreateFirstCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BDB4 RID: 114100 RVA: 0x003EF9A0 File Offset: 0x003EDBA0
		public static VectorOffset CreateFirstCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDB5 RID: 114101 RVA: 0x003EF9BA File Offset: 0x003EDBBA
		public static VectorOffset CreateFirstCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDB6 RID: 114102 RVA: 0x003EF9D8 File Offset: 0x003EDBD8
		public static VectorOffset CreateFirstCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BDB7 RID: 114103 RVA: 0x003EF9F1 File Offset: 0x003EDBF1
		public static void StartFirstCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BDB8 RID: 114104 RVA: 0x003EF9FC File Offset: 0x003EDBFC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601BDB9 RID: 114105 RVA: 0x003EFA07 File Offset: 0x003EDC07
		public static Offset<IInteractRewardParam> EndIInteractRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<IInteractRewardParam>(builder.EndTable());
		}

		// Token: 0x0601BDBA RID: 114106 RVA: 0x003EFA14 File Offset: 0x003EDC14
		public IInteractRewardParamT UnPack()
		{
			IInteractRewardParamT interactRewardParamT = new IInteractRewardParamT();
			this.UnPackTo(interactRewardParamT);
			return interactRewardParamT;
		}

		// Token: 0x0601BDBB RID: 114107 RVA: 0x003EFA30 File Offset: 0x003EDC30
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

		// Token: 0x0601BDBC RID: 114108 RVA: 0x003EFB54 File Offset: 0x003EDD54
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

		// Token: 0x0400CF26 RID: 53030
		private Table __p;
	}
}
