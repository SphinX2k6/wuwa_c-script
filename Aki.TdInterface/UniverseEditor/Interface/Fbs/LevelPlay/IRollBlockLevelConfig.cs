using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A2 RID: 17826
	public struct IRollBlockLevelConfig : IFlatbufferObject
	{
		// Token: 0x17007EA6 RID: 32422
		// (get) Token: 0x0601AEF5 RID: 110325 RVA: 0x003D77F1 File Offset: 0x003D59F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AEF6 RID: 110326 RVA: 0x003D77FE File Offset: 0x003D59FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AEF7 RID: 110327 RVA: 0x003D7808 File Offset: 0x003D5A08
		public static IRollBlockLevelConfig GetRootAsIRollBlockLevelConfig(ByteBuffer _bb)
		{
			return IRollBlockLevelConfig.GetRootAsIRollBlockLevelConfig(_bb, default(IRollBlockLevelConfig));
		}

		// Token: 0x0601AEF8 RID: 110328 RVA: 0x003D7824 File Offset: 0x003D5A24
		public static IRollBlockLevelConfig GetRootAsIRollBlockLevelConfig(ByteBuffer _bb, IRollBlockLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AEF9 RID: 110329 RVA: 0x003D7841 File Offset: 0x003D5A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AEFA RID: 110330 RVA: 0x003D7850 File Offset: 0x003D5A50
		public IRollBlockLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EA7 RID: 32423
		// (get) Token: 0x0601AEFB RID: 110331 RVA: 0x003D7860 File Offset: 0x003D5A60
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EA8 RID: 32424
		// (get) Token: 0x0601AEFC RID: 110332 RVA: 0x003D789C File Offset: 0x003D5A9C
		public IRollBlockBoardConfig? GridConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRollBlockBoardConfig?(default(IRollBlockBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007EA9 RID: 32425
		// (get) Token: 0x0601AEFD RID: 110333 RVA: 0x003D78FC File Offset: 0x003D5AFC
		public int DefaultControlledBlockId
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

		// Token: 0x17007EAA RID: 32426
		// (get) Token: 0x0601AEFE RID: 110334 RVA: 0x003D7938 File Offset: 0x003D5B38
		public int HintStepThreshold
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

		// Token: 0x0601AEFF RID: 110335 RVA: 0x003D7978 File Offset: 0x003D5B78
		public TRollBlockHintStep HintStepsType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TRollBlockHintStep.NONE;
			}
			return (TRollBlockHintStep)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007EAB RID: 32427
		// (get) Token: 0x0601AF00 RID: 110336 RVA: 0x003D79B8 File Offset: 0x003D5BB8
		public int HintStepsTypeLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601AF01 RID: 110337 RVA: 0x003D79E4 File Offset: 0x003D5BE4
		public Span<TRollBlockHintStep> GetHintStepsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockHintStep>(12, 1);
		}

		// Token: 0x0601AF02 RID: 110338 RVA: 0x003D79F4 File Offset: 0x003D5BF4
		public TRollBlockHintStep[] GetHintStepsTypeArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TRollBlockHintStep[] array = new TRollBlockHintStep[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TRollBlockHintStep)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601AF03 RID: 110339 RVA: 0x003D7A60 File Offset: 0x003D5C60
		public TTable? HintSteps<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007EAC RID: 32428
		// (get) Token: 0x0601AF04 RID: 110340 RVA: 0x003D7AA8 File Offset: 0x003D5CA8
		public int HintStepsLength
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

		// Token: 0x17007EAD RID: 32429
		// (get) Token: 0x0601AF05 RID: 110341 RVA: 0x003D7AD4 File Offset: 0x003D5CD4
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EAE RID: 32430
		// (get) Token: 0x0601AF06 RID: 110342 RVA: 0x003D7B14 File Offset: 0x003D5D14
		public int SubCameraTag
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EAF RID: 32431
		// (get) Token: 0x0601AF07 RID: 110343 RVA: 0x003D7B54 File Offset: 0x003D5D54
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AF08 RID: 110344 RVA: 0x003D7B94 File Offset: 0x003D5D94
		public static Offset<IRollBlockLevelConfig> CreateIRollBlockLevelConfig(FlatBufferBuilder builder, int Difficulty = 0, Offset<IRollBlockBoardConfig> GridConfigOffset = default(Offset<IRollBlockBoardConfig>), int DefaultControlledBlockId = 0, int HintStepThreshold = 0, VectorOffset HintSteps_typeOffset = default(VectorOffset), VectorOffset HintStepsOffset = default(VectorOffset), int RewardId = 0, int SubCameraTag = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IRollBlockLevelConfig.AddSubCameraTag(builder, SubCameraTag);
			IRollBlockLevelConfig.AddRewardId(builder, RewardId);
			IRollBlockLevelConfig.AddHintSteps(builder, HintStepsOffset);
			IRollBlockLevelConfig.AddHintStepsType(builder, HintSteps_typeOffset);
			IRollBlockLevelConfig.AddHintStepThreshold(builder, HintStepThreshold);
			IRollBlockLevelConfig.AddDefaultControlledBlockId(builder, DefaultControlledBlockId);
			IRollBlockLevelConfig.AddGridConfig(builder, GridConfigOffset);
			IRollBlockLevelConfig.AddDifficulty(builder, Difficulty);
			IRollBlockLevelConfig.AddNullMask(builder, NullMask);
			return IRollBlockLevelConfig.EndIRollBlockLevelConfig(builder);
		}

		// Token: 0x0601AF09 RID: 110345 RVA: 0x003D7BF4 File Offset: 0x003D5DF4
		public static void StartIRollBlockLevelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601AF0A RID: 110346 RVA: 0x003D7BFE File Offset: 0x003D5DFE
		public static void AddDifficulty(FlatBufferBuilder builder, int difficulty)
		{
			builder.AddInt(0, difficulty, 0);
		}

		// Token: 0x0601AF0B RID: 110347 RVA: 0x003D7C09 File Offset: 0x003D5E09
		public static void AddGridConfig(FlatBufferBuilder builder, Offset<IRollBlockBoardConfig> gridConfigOffset)
		{
			builder.AddOffset(1, gridConfigOffset.Value, 0);
		}

		// Token: 0x0601AF0C RID: 110348 RVA: 0x003D7C19 File Offset: 0x003D5E19
		public static void AddDefaultControlledBlockId(FlatBufferBuilder builder, int defaultControlledBlockId)
		{
			builder.AddInt(2, defaultControlledBlockId, 0);
		}

		// Token: 0x0601AF0D RID: 110349 RVA: 0x003D7C24 File Offset: 0x003D5E24
		public static void AddHintStepThreshold(FlatBufferBuilder builder, int hintStepThreshold)
		{
			builder.AddInt(3, hintStepThreshold, 0);
		}

		// Token: 0x0601AF0E RID: 110350 RVA: 0x003D7C2F File Offset: 0x003D5E2F
		public static void AddHintStepsType(FlatBufferBuilder builder, VectorOffset hintStepsTypeOffset)
		{
			builder.AddOffset(4, hintStepsTypeOffset.Value, 0);
		}

		// Token: 0x0601AF0F RID: 110351 RVA: 0x003D7C40 File Offset: 0x003D5E40
		public static VectorOffset CreateHintStepsTypeVector(FlatBufferBuilder builder, TRollBlockHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AF10 RID: 110352 RVA: 0x003D7C77 File Offset: 0x003D5E77
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AF11 RID: 110353 RVA: 0x003D7C91 File Offset: 0x003D5E91
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockHintStep> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AF12 RID: 110354 RVA: 0x003D7CAF File Offset: 0x003D5EAF
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockHintStep>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AF13 RID: 110355 RVA: 0x003D7CC8 File Offset: 0x003D5EC8
		public static void StartHintStepsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AF14 RID: 110356 RVA: 0x003D7CD3 File Offset: 0x003D5ED3
		public static void AddHintSteps(FlatBufferBuilder builder, VectorOffset hintStepsOffset)
		{
			builder.AddOffset(5, hintStepsOffset.Value, 0);
		}

		// Token: 0x0601AF15 RID: 110357 RVA: 0x003D7CE4 File Offset: 0x003D5EE4
		public static VectorOffset CreateHintStepsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AF16 RID: 110358 RVA: 0x003D7D1B File Offset: 0x003D5F1B
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AF17 RID: 110359 RVA: 0x003D7D35 File Offset: 0x003D5F35
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AF18 RID: 110360 RVA: 0x003D7D53 File Offset: 0x003D5F53
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AF19 RID: 110361 RVA: 0x003D7D6C File Offset: 0x003D5F6C
		public static void StartHintStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AF1A RID: 110362 RVA: 0x003D7D77 File Offset: 0x003D5F77
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(6, rewardId, 0);
		}

		// Token: 0x0601AF1B RID: 110363 RVA: 0x003D7D82 File Offset: 0x003D5F82
		public static void AddSubCameraTag(FlatBufferBuilder builder, int subCameraTag)
		{
			builder.AddInt(7, subCameraTag, 0);
		}

		// Token: 0x0601AF1C RID: 110364 RVA: 0x003D7D8D File Offset: 0x003D5F8D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601AF1D RID: 110365 RVA: 0x003D7D98 File Offset: 0x003D5F98
		public static Offset<IRollBlockLevelConfig> EndIRollBlockLevelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockLevelConfig>(builder.EndTable());
		}

		// Token: 0x0601AF1E RID: 110366 RVA: 0x003D7DA8 File Offset: 0x003D5FA8
		public IRollBlockLevelConfigT UnPack()
		{
			IRollBlockLevelConfigT rollBlockLevelConfigT = new IRollBlockLevelConfigT();
			this.UnPackTo(rollBlockLevelConfigT);
			return rollBlockLevelConfigT;
		}

		// Token: 0x0601AF1F RID: 110367 RVA: 0x003D7DC4 File Offset: 0x003D5FC4
		public void UnPackTo(IRollBlockLevelConfigT _o)
		{
			_o.Difficulty = this.Difficulty;
			_o.GridConfig = ((this.GridConfig != null) ? this.GridConfig.Value.UnPack() : null);
			_o.DefaultControlledBlockId = this.DefaultControlledBlockId;
			_o.HintStepThreshold = this.HintStepThreshold;
			_o.HintSteps = new List<TRollBlockHintStepUnion>();
			for (int i = 0; i < this.HintStepsLength; i++)
			{
				TRollBlockHintStepUnion trollBlockHintStepUnion = new TRollBlockHintStepUnion();
				trollBlockHintStepUnion.Type = this.HintStepsType(i);
				switch (this.HintStepsType(i))
				{
				case TRollBlockHintStep.IRollBlockHintStepJump:
					trollBlockHintStepUnion.Value = ((this.HintSteps<IRollBlockHintStepJump>(i) != null) ? this.HintSteps<IRollBlockHintStepJump>(i).Value.UnPack() : null);
					break;
				case TRollBlockHintStep.IRollBlockHintStepOperation:
					trollBlockHintStepUnion.Value = ((this.HintSteps<IRollBlockHintStepOperation>(i) != null) ? this.HintSteps<IRollBlockHintStepOperation>(i).Value.UnPack() : null);
					break;
				case TRollBlockHintStep.IRollBlockHintStepRoll:
					trollBlockHintStepUnion.Value = ((this.HintSteps<IRollBlockHintStepRoll>(i) != null) ? this.HintSteps<IRollBlockHintStepRoll>(i).Value.UnPack() : null);
					break;
				}
				_o.HintSteps.Add(trollBlockHintStepUnion);
			}
			_o.RewardId = this.RewardId;
			_o.SubCameraTag = this.SubCameraTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AF20 RID: 110368 RVA: 0x003D7F4C File Offset: 0x003D614C
		public static Offset<IRollBlockLevelConfig> Pack(FlatBufferBuilder builder, IRollBlockLevelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockLevelConfig>);
			}
			Offset<IRollBlockBoardConfig> gridConfigOffset = (_o.GridConfig == null) ? default(Offset<IRollBlockBoardConfig>) : IRollBlockBoardConfig.Pack(builder, _o.GridConfig);
			VectorOffset hintSteps_typeOffset = default(VectorOffset);
			if (_o.HintSteps != null)
			{
				TRollBlockHintStep[] array = new TRollBlockHintStep[_o.HintSteps.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.HintSteps[i].Type;
				}
				hintSteps_typeOffset = IRollBlockLevelConfig.CreateHintStepsTypeVector(builder, array);
			}
			VectorOffset hintStepsOffset = default(VectorOffset);
			if (_o.HintSteps != null)
			{
				int[] array2 = new int[_o.HintSteps.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockHintStepUnion.Pack(builder, _o.HintSteps[j]);
				}
				hintStepsOffset = IRollBlockLevelConfig.CreateHintStepsVector(builder, array2);
			}
			return IRollBlockLevelConfig.CreateIRollBlockLevelConfig(builder, _o.Difficulty, gridConfigOffset, _o.DefaultControlledBlockId, _o.HintStepThreshold, hintSteps_typeOffset, hintStepsOffset, _o.RewardId, _o.SubCameraTag, _o.NullMask);
		}

		// Token: 0x0400C664 RID: 50788
		private Table __p;
	}
}
