using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200455A RID: 17754
	public struct IRollBlockGlobalConfig : IFlatbufferObject
	{
		// Token: 0x17007DF1 RID: 32241
		// (get) Token: 0x0601AB9F RID: 109471 RVA: 0x003CFC76 File Offset: 0x003CDE76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ABA0 RID: 109472 RVA: 0x003CFC83 File Offset: 0x003CDE83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ABA1 RID: 109473 RVA: 0x003CFC8C File Offset: 0x003CDE8C
		public static IRollBlockGlobalConfig GetRootAsIRollBlockGlobalConfig(ByteBuffer _bb)
		{
			return IRollBlockGlobalConfig.GetRootAsIRollBlockGlobalConfig(_bb, default(IRollBlockGlobalConfig));
		}

		// Token: 0x0601ABA2 RID: 109474 RVA: 0x003CFCA8 File Offset: 0x003CDEA8
		public static IRollBlockGlobalConfig GetRootAsIRollBlockGlobalConfig(ByteBuffer _bb, IRollBlockGlobalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ABA3 RID: 109475 RVA: 0x003CFCC5 File Offset: 0x003CDEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ABA4 RID: 109476 RVA: 0x003CFCD4 File Offset: 0x003CDED4
		public IRollBlockGlobalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DF2 RID: 32242
		// (get) Token: 0x0601ABA5 RID: 109477 RVA: 0x003CFCE4 File Offset: 0x003CDEE4
		public int Id
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

		// Token: 0x17007DF3 RID: 32243
		// (get) Token: 0x0601ABA6 RID: 109478 RVA: 0x003CFD20 File Offset: 0x003CDF20
		public string GroupName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ABA7 RID: 109479 RVA: 0x003CFD57 File Offset: 0x003CDF57
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ABA8 RID: 109480 RVA: 0x003CFD66 File Offset: 0x003CDF66
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ABA9 RID: 109481 RVA: 0x003CFD74 File Offset: 0x003CDF74
		public IRollBlockLevelConfig? Levels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IRollBlockLevelConfig?(default(IRollBlockLevelConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007DF4 RID: 32244
		// (get) Token: 0x0601ABAA RID: 109482 RVA: 0x003CFDD4 File Offset: 0x003CDFD4
		public int LevelsLength
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

		// Token: 0x0601ABAB RID: 109483 RVA: 0x003CFDFF File Offset: 0x003CDFFF
		public static Offset<IRollBlockGlobalConfig> CreateIRollBlockGlobalConfig(FlatBufferBuilder builder, int Id = 0, StringOffset GroupNameOffset = default(StringOffset), VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRollBlockGlobalConfig.AddLevels(builder, LevelsOffset);
			IRollBlockGlobalConfig.AddGroupName(builder, GroupNameOffset);
			IRollBlockGlobalConfig.AddId(builder, Id);
			return IRollBlockGlobalConfig.EndIRollBlockGlobalConfig(builder);
		}

		// Token: 0x0601ABAC RID: 109484 RVA: 0x003CFE23 File Offset: 0x003CE023
		public static void StartIRollBlockGlobalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601ABAD RID: 109485 RVA: 0x003CFE2C File Offset: 0x003CE02C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601ABAE RID: 109486 RVA: 0x003CFE37 File Offset: 0x003CE037
		public static void AddGroupName(FlatBufferBuilder builder, StringOffset groupNameOffset)
		{
			builder.AddOffset(1, groupNameOffset.Value, 0);
		}

		// Token: 0x0601ABAF RID: 109487 RVA: 0x003CFE47 File Offset: 0x003CE047
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(2, levelsOffset.Value, 0);
		}

		// Token: 0x0601ABB0 RID: 109488 RVA: 0x003CFE58 File Offset: 0x003CE058
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<IRollBlockLevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601ABB1 RID: 109489 RVA: 0x003CFE98 File Offset: 0x003CE098
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, Offset<IRollBlockLevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRollBlockLevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ABB2 RID: 109490 RVA: 0x003CFEB2 File Offset: 0x003CE0B2
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRollBlockLevelConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRollBlockLevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601ABB3 RID: 109491 RVA: 0x003CFED0 File Offset: 0x003CE0D0
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRollBlockLevelConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601ABB4 RID: 109492 RVA: 0x003CFEE9 File Offset: 0x003CE0E9
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601ABB5 RID: 109493 RVA: 0x003CFEF4 File Offset: 0x003CE0F4
		public static Offset<IRollBlockGlobalConfig> EndIRollBlockGlobalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGlobalConfig>(builder.EndTable());
		}

		// Token: 0x0601ABB6 RID: 109494 RVA: 0x003CFF04 File Offset: 0x003CE104
		public IRollBlockGlobalConfigT UnPack()
		{
			IRollBlockGlobalConfigT rollBlockGlobalConfigT = new IRollBlockGlobalConfigT();
			this.UnPackTo(rollBlockGlobalConfigT);
			return rollBlockGlobalConfigT;
		}

		// Token: 0x0601ABB7 RID: 109495 RVA: 0x003CFF20 File Offset: 0x003CE120
		public void UnPackTo(IRollBlockGlobalConfigT _o)
		{
			_o.Id = this.Id;
			_o.GroupName = this.GroupName;
			_o.Levels = new List<IRollBlockLevelConfigT>();
			for (int i = 0; i < this.LevelsLength; i++)
			{
				_o.Levels.Add((this.Levels(i) != null) ? this.Levels(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601ABB8 RID: 109496 RVA: 0x003CFF98 File Offset: 0x003CE198
		public static Offset<IRollBlockGlobalConfig> Pack(FlatBufferBuilder builder, IRollBlockGlobalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGlobalConfig>);
			}
			StringOffset groupNameOffset = (_o.GroupName == null) ? default(StringOffset) : builder.CreateString(_o.GroupName);
			VectorOffset levelsOffset = default(VectorOffset);
			if (_o.Levels != null)
			{
				Offset<IRollBlockLevelConfig>[] array = new Offset<IRollBlockLevelConfig>[_o.Levels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRollBlockLevelConfig.Pack(builder, _o.Levels[i]);
				}
				levelsOffset = IRollBlockGlobalConfig.CreateLevelsVector(builder, array);
			}
			return IRollBlockGlobalConfig.CreateIRollBlockGlobalConfig(builder, _o.Id, groupNameOffset, levelsOffset);
		}

		// Token: 0x0400C5E9 RID: 50665
		private Table __p;
	}
}
