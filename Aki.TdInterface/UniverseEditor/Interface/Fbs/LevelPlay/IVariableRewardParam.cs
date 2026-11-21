using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A52 RID: 19026
	public struct IVariableRewardParam : IFlatbufferObject
	{
		// Token: 0x17008583 RID: 34179
		// (get) Token: 0x0601C982 RID: 117122 RVA: 0x00409183 File Offset: 0x00407383
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C983 RID: 117123 RVA: 0x00409190 File Offset: 0x00407390
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C984 RID: 117124 RVA: 0x00409198 File Offset: 0x00407398
		public static IVariableRewardParam GetRootAsIVariableRewardParam(ByteBuffer _bb)
		{
			return IVariableRewardParam.GetRootAsIVariableRewardParam(_bb, default(IVariableRewardParam));
		}

		// Token: 0x0601C985 RID: 117125 RVA: 0x004091B4 File Offset: 0x004073B4
		public static IVariableRewardParam GetRootAsIVariableRewardParam(ByteBuffer _bb, IVariableRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C986 RID: 117126 RVA: 0x004091D1 File Offset: 0x004073D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C987 RID: 117127 RVA: 0x004091E0 File Offset: 0x004073E0
		public IVariableRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008584 RID: 34180
		// (get) Token: 0x0601C988 RID: 117128 RVA: 0x004091F0 File Offset: 0x004073F0
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

		// Token: 0x0601C989 RID: 117129 RVA: 0x0040922C File Offset: 0x0040742C
		public IVariableRewardConfig? RewardConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVariableRewardConfig?(default(IVariableRewardConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008585 RID: 34181
		// (get) Token: 0x0601C98A RID: 117130 RVA: 0x0040928C File Offset: 0x0040748C
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

		// Token: 0x0601C98B RID: 117131 RVA: 0x004092B7 File Offset: 0x004074B7
		public static Offset<IVariableRewardParam> CreateIVariableRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None, VectorOffset RewardConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IVariableRewardParam.AddRewardConfig(builder, RewardConfigOffset);
			IVariableRewardParam.AddType(builder, Type);
			return IVariableRewardParam.EndIVariableRewardParam(builder);
		}

		// Token: 0x0601C98C RID: 117132 RVA: 0x004092D4 File Offset: 0x004074D4
		public static void StartIVariableRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C98D RID: 117133 RVA: 0x004092DD File Offset: 0x004074DD
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C98E RID: 117134 RVA: 0x004092E8 File Offset: 0x004074E8
		public static void AddRewardConfig(FlatBufferBuilder builder, VectorOffset rewardConfigOffset)
		{
			builder.AddOffset(1, rewardConfigOffset.Value, 0);
		}

		// Token: 0x0601C98F RID: 117135 RVA: 0x004092F8 File Offset: 0x004074F8
		public static VectorOffset CreateRewardConfigVector(FlatBufferBuilder builder, Offset<IVariableRewardConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C990 RID: 117136 RVA: 0x00409338 File Offset: 0x00407538
		public static VectorOffset CreateRewardConfigVectorBlock(FlatBufferBuilder builder, Offset<IVariableRewardConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVariableRewardConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C991 RID: 117137 RVA: 0x00409352 File Offset: 0x00407552
		public static VectorOffset CreateRewardConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVariableRewardConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVariableRewardConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C992 RID: 117138 RVA: 0x00409370 File Offset: 0x00407570
		public static VectorOffset CreateRewardConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVariableRewardConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C993 RID: 117139 RVA: 0x00409389 File Offset: 0x00407589
		public static void StartRewardConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C994 RID: 117140 RVA: 0x00409394 File Offset: 0x00407594
		public static Offset<IVariableRewardParam> EndIVariableRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<IVariableRewardParam>(builder.EndTable());
		}

		// Token: 0x0601C995 RID: 117141 RVA: 0x004093A4 File Offset: 0x004075A4
		public IVariableRewardParamT UnPack()
		{
			IVariableRewardParamT variableRewardParamT = new IVariableRewardParamT();
			this.UnPackTo(variableRewardParamT);
			return variableRewardParamT;
		}

		// Token: 0x0601C996 RID: 117142 RVA: 0x004093C0 File Offset: 0x004075C0
		public void UnPackTo(IVariableRewardParamT _o)
		{
			_o.Type = this.Type;
			_o.RewardConfig = new List<IVariableRewardConfigT>();
			for (int i = 0; i < this.RewardConfigLength; i++)
			{
				_o.RewardConfig.Add((this.RewardConfig(i) != null) ? this.RewardConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C997 RID: 117143 RVA: 0x0040942C File Offset: 0x0040762C
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

		// Token: 0x0400D0FB RID: 53499
		private Table __p;
	}
}
