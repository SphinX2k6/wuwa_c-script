using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A0A RID: 18954
	public struct IRollBlockLevelConfig : IFlatbufferObject
	{
		// Token: 0x170084E7 RID: 34023
		// (get) Token: 0x0601C6CA RID: 116426 RVA: 0x00403A8D File Offset: 0x00401C8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C6CB RID: 116427 RVA: 0x00403A9A File Offset: 0x00401C9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C6CC RID: 116428 RVA: 0x00403AA4 File Offset: 0x00401CA4
		public static IRollBlockLevelConfig GetRootAsIRollBlockLevelConfig(ByteBuffer _bb)
		{
			return IRollBlockLevelConfig.GetRootAsIRollBlockLevelConfig(_bb, default(IRollBlockLevelConfig));
		}

		// Token: 0x0601C6CD RID: 116429 RVA: 0x00403AC0 File Offset: 0x00401CC0
		public static IRollBlockLevelConfig GetRootAsIRollBlockLevelConfig(ByteBuffer _bb, IRollBlockLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C6CE RID: 116430 RVA: 0x00403ADD File Offset: 0x00401CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C6CF RID: 116431 RVA: 0x00403AEC File Offset: 0x00401CEC
		public IRollBlockLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084E8 RID: 34024
		// (get) Token: 0x0601C6D0 RID: 116432 RVA: 0x00403AFC File Offset: 0x00401CFC
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

		// Token: 0x170084E9 RID: 34025
		// (get) Token: 0x0601C6D1 RID: 116433 RVA: 0x00403B38 File Offset: 0x00401D38
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

		// Token: 0x170084EA RID: 34026
		// (get) Token: 0x0601C6D2 RID: 116434 RVA: 0x00403B98 File Offset: 0x00401D98
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

		// Token: 0x170084EB RID: 34027
		// (get) Token: 0x0601C6D3 RID: 116435 RVA: 0x00403BD4 File Offset: 0x00401DD4
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

		// Token: 0x0601C6D4 RID: 116436 RVA: 0x00403C14 File Offset: 0x00401E14
		public TRollBlockHintStep HintStepsType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TRollBlockHintStep.NONE;
			}
			return (TRollBlockHintStep)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170084EC RID: 34028
		// (get) Token: 0x0601C6D5 RID: 116437 RVA: 0x00403C54 File Offset: 0x00401E54
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

		// Token: 0x0601C6D6 RID: 116438 RVA: 0x00403C80 File Offset: 0x00401E80
		public Span<TRollBlockHintStep> GetHintStepsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockHintStep>(12, 1);
		}

		// Token: 0x0601C6D7 RID: 116439 RVA: 0x00403C90 File Offset: 0x00401E90
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

		// Token: 0x0601C6D8 RID: 116440 RVA: 0x00403CFC File Offset: 0x00401EFC
		public TTable? HintSteps<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170084ED RID: 34029
		// (get) Token: 0x0601C6D9 RID: 116441 RVA: 0x00403D44 File Offset: 0x00401F44
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

		// Token: 0x170084EE RID: 34030
		// (get) Token: 0x0601C6DA RID: 116442 RVA: 0x00403D70 File Offset: 0x00401F70
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

		// Token: 0x170084EF RID: 34031
		// (get) Token: 0x0601C6DB RID: 116443 RVA: 0x00403DB0 File Offset: 0x00401FB0
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

		// Token: 0x170084F0 RID: 34032
		// (get) Token: 0x0601C6DC RID: 116444 RVA: 0x00403DF0 File Offset: 0x00401FF0
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

		// Token: 0x0601C6DD RID: 116445 RVA: 0x00403E30 File Offset: 0x00402030
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

		// Token: 0x0601C6DE RID: 116446 RVA: 0x00403E90 File Offset: 0x00402090
		public static void StartIRollBlockLevelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601C6DF RID: 116447 RVA: 0x00403E9A File Offset: 0x0040209A
		public static void AddDifficulty(FlatBufferBuilder builder, int difficulty)
		{
			builder.AddInt(0, difficulty, 0);
		}

		// Token: 0x0601C6E0 RID: 116448 RVA: 0x00403EA5 File Offset: 0x004020A5
		public static void AddGridConfig(FlatBufferBuilder builder, Offset<IRollBlockBoardConfig> gridConfigOffset)
		{
			builder.AddOffset(1, gridConfigOffset.Value, 0);
		}

		// Token: 0x0601C6E1 RID: 116449 RVA: 0x00403EB5 File Offset: 0x004020B5
		public static void AddDefaultControlledBlockId(FlatBufferBuilder builder, int defaultControlledBlockId)
		{
			builder.AddInt(2, defaultControlledBlockId, 0);
		}

		// Token: 0x0601C6E2 RID: 116450 RVA: 0x00403EC0 File Offset: 0x004020C0
		public static void AddHintStepThreshold(FlatBufferBuilder builder, int hintStepThreshold)
		{
			builder.AddInt(3, hintStepThreshold, 0);
		}

		// Token: 0x0601C6E3 RID: 116451 RVA: 0x00403ECB File Offset: 0x004020CB
		public static void AddHintStepsType(FlatBufferBuilder builder, VectorOffset hintStepsTypeOffset)
		{
			builder.AddOffset(4, hintStepsTypeOffset.Value, 0);
		}

		// Token: 0x0601C6E4 RID: 116452 RVA: 0x00403EDC File Offset: 0x004020DC
		public static VectorOffset CreateHintStepsTypeVector(FlatBufferBuilder builder, TRollBlockHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C6E5 RID: 116453 RVA: 0x00403F13 File Offset: 0x00402113
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockHintStep[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6E6 RID: 116454 RVA: 0x00403F2D File Offset: 0x0040212D
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockHintStep> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockHintStep>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6E7 RID: 116455 RVA: 0x00403F4B File Offset: 0x0040214B
		public static VectorOffset CreateHintStepsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockHintStep>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C6E8 RID: 116456 RVA: 0x00403F64 File Offset: 0x00402164
		public static void StartHintStepsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C6E9 RID: 116457 RVA: 0x00403F6F File Offset: 0x0040216F
		public static void AddHintSteps(FlatBufferBuilder builder, VectorOffset hintStepsOffset)
		{
			builder.AddOffset(5, hintStepsOffset.Value, 0);
		}

		// Token: 0x0601C6EA RID: 116458 RVA: 0x00403F80 File Offset: 0x00402180
		public static VectorOffset CreateHintStepsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C6EB RID: 116459 RVA: 0x00403FB7 File Offset: 0x004021B7
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6EC RID: 116460 RVA: 0x00403FD1 File Offset: 0x004021D1
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6ED RID: 116461 RVA: 0x00403FEF File Offset: 0x004021EF
		public static VectorOffset CreateHintStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C6EE RID: 116462 RVA: 0x00404008 File Offset: 0x00402208
		public static void StartHintStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C6EF RID: 116463 RVA: 0x00404013 File Offset: 0x00402213
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(6, rewardId, 0);
		}

		// Token: 0x0601C6F0 RID: 116464 RVA: 0x0040401E File Offset: 0x0040221E
		public static void AddSubCameraTag(FlatBufferBuilder builder, int subCameraTag)
		{
			builder.AddInt(7, subCameraTag, 0);
		}

		// Token: 0x0601C6F1 RID: 116465 RVA: 0x00404029 File Offset: 0x00402229
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601C6F2 RID: 116466 RVA: 0x00404034 File Offset: 0x00402234
		public static Offset<IRollBlockLevelConfig> EndIRollBlockLevelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockLevelConfig>(builder.EndTable());
		}

		// Token: 0x0601C6F3 RID: 116467 RVA: 0x00404044 File Offset: 0x00402244
		public IRollBlockLevelConfigT UnPack()
		{
			IRollBlockLevelConfigT rollBlockLevelConfigT = new IRollBlockLevelConfigT();
			this.UnPackTo(rollBlockLevelConfigT);
			return rollBlockLevelConfigT;
		}

		// Token: 0x0601C6F4 RID: 116468 RVA: 0x00404060 File Offset: 0x00402260
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

		// Token: 0x0601C6F5 RID: 116469 RVA: 0x004041E8 File Offset: 0x004023E8
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

		// Token: 0x0400D093 RID: 53395
		private Table __p;
	}
}
