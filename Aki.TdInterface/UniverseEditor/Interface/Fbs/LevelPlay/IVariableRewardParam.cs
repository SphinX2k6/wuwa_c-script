using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045EA RID: 17898
	public struct IVariableRewardParam : IFlatbufferObject
	{
		// Token: 0x17007F42 RID: 32578
		// (get) Token: 0x0601B1AD RID: 111021 RVA: 0x003DCEE7 File Offset: 0x003DB0E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B1AE RID: 111022 RVA: 0x003DCEF4 File Offset: 0x003DB0F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B1AF RID: 111023 RVA: 0x003DCEFC File Offset: 0x003DB0FC
		public static IVariableRewardParam GetRootAsIVariableRewardParam(ByteBuffer _bb)
		{
			return IVariableRewardParam.GetRootAsIVariableRewardParam(_bb, default(IVariableRewardParam));
		}

		// Token: 0x0601B1B0 RID: 111024 RVA: 0x003DCF18 File Offset: 0x003DB118
		public static IVariableRewardParam GetRootAsIVariableRewardParam(ByteBuffer _bb, IVariableRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B1B1 RID: 111025 RVA: 0x003DCF35 File Offset: 0x003DB135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B1B2 RID: 111026 RVA: 0x003DCF44 File Offset: 0x003DB144
		public IVariableRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F43 RID: 32579
		// (get) Token: 0x0601B1B3 RID: 111027 RVA: 0x003DCF54 File Offset: 0x003DB154
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

		// Token: 0x0601B1B4 RID: 111028 RVA: 0x003DCF90 File Offset: 0x003DB190
		public IVariableRewardConfig? RewardConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVariableRewardConfig?(default(IVariableRewardConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007F44 RID: 32580
		// (get) Token: 0x0601B1B5 RID: 111029 RVA: 0x003DCFF0 File Offset: 0x003DB1F0
		public int RewardConfigLength
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

		// Token: 0x0601B1B6 RID: 111030 RVA: 0x003DD01B File Offset: 0x003DB21B
		public static Offset<IVariableRewardParam> CreateIVariableRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None, VectorOffset RewardConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IVariableRewardParam.AddRewardConfig(builder, RewardConfigOffset);
			IVariableRewardParam.AddType(builder, Type);
			return IVariableRewardParam.EndIVariableRewardParam(builder);
		}

		// Token: 0x0601B1B7 RID: 111031 RVA: 0x003DD038 File Offset: 0x003DB238
		public static void StartIVariableRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B1B8 RID: 111032 RVA: 0x003DD041 File Offset: 0x003DB241
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B1B9 RID: 111033 RVA: 0x003DD04C File Offset: 0x003DB24C
		public static void AddRewardConfig(FlatBufferBuilder builder, VectorOffset rewardConfigOffset)
		{
			builder.AddOffset(1, rewardConfigOffset.Value, 0);
		}

		// Token: 0x0601B1BA RID: 111034 RVA: 0x003DD05C File Offset: 0x003DB25C
		public static VectorOffset CreateRewardConfigVector(FlatBufferBuilder builder, Offset<IVariableRewardConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1BB RID: 111035 RVA: 0x003DD09C File Offset: 0x003DB29C
		public static VectorOffset CreateRewardConfigVectorBlock(FlatBufferBuilder builder, Offset<IVariableRewardConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVariableRewardConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1BC RID: 111036 RVA: 0x003DD0B6 File Offset: 0x003DB2B6
		public static VectorOffset CreateRewardConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVariableRewardConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVariableRewardConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1BD RID: 111037 RVA: 0x003DD0D4 File Offset: 0x003DB2D4
		public static VectorOffset CreateRewardConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVariableRewardConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1BE RID: 111038 RVA: 0x003DD0ED File Offset: 0x003DB2ED
		public static void StartRewardConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B1BF RID: 111039 RVA: 0x003DD0F8 File Offset: 0x003DB2F8
		public static Offset<IVariableRewardParam> EndIVariableRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<IVariableRewardParam>(builder.EndTable());
		}

		// Token: 0x0601B1C0 RID: 111040 RVA: 0x003DD108 File Offset: 0x003DB308
		public IVariableRewardParamT UnPack()
		{
			IVariableRewardParamT variableRewardParamT = new IVariableRewardParamT();
			this.UnPackTo(variableRewardParamT);
			return variableRewardParamT;
		}

		// Token: 0x0601B1C1 RID: 111041 RVA: 0x003DD124 File Offset: 0x003DB324
		public void UnPackTo(IVariableRewardParamT _o)
		{
			_o.Type = this.Type;
			_o.RewardConfig = new List<IVariableRewardConfigT>();
			for (int i = 0; i < this.RewardConfigLength; i++)
			{
				_o.RewardConfig.Add((this.RewardConfig(i) != null) ? this.RewardConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B1C2 RID: 111042 RVA: 0x003DD190 File Offset: 0x003DB390
		public static Offset<IVariableRewardParam> Pack(FlatBufferBuilder builder, IVariableRewardParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVariableRewardParam>);
			}
			VectorOffset rewardConfigOffset = default(VectorOffset);
			if (_o.RewardConfig != null)
			{
				Offset<IVariableRewardConfig>[] array = new Offset<IVariableRewardConfig>[_o.RewardConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVariableRewardConfig.Pack(builder, _o.RewardConfig[i]);
				}
				rewardConfigOffset = IVariableRewardParam.CreateRewardConfigVector(builder, array);
			}
			return IVariableRewardParam.CreateIVariableRewardParam(builder, _o.Type, rewardConfigOffset);
		}

		// Token: 0x0400C6CC RID: 50892
		private Table __p;
	}
}
