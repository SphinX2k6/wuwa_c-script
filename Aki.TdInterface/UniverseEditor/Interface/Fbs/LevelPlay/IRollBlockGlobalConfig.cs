using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C2 RID: 18882
	public struct IRollBlockGlobalConfig : IFlatbufferObject
	{
		// Token: 0x17008432 RID: 33842
		// (get) Token: 0x0601C374 RID: 115572 RVA: 0x003FBF12 File Offset: 0x003FA112
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C375 RID: 115573 RVA: 0x003FBF1F File Offset: 0x003FA11F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C376 RID: 115574 RVA: 0x003FBF28 File Offset: 0x003FA128
		public static IRollBlockGlobalConfig GetRootAsIRollBlockGlobalConfig(ByteBuffer _bb)
		{
			return IRollBlockGlobalConfig.GetRootAsIRollBlockGlobalConfig(_bb, default(IRollBlockGlobalConfig));
		}

		// Token: 0x0601C377 RID: 115575 RVA: 0x003FBF44 File Offset: 0x003FA144
		public static IRollBlockGlobalConfig GetRootAsIRollBlockGlobalConfig(ByteBuffer _bb, IRollBlockGlobalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C378 RID: 115576 RVA: 0x003FBF61 File Offset: 0x003FA161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C379 RID: 115577 RVA: 0x003FBF70 File Offset: 0x003FA170
		public IRollBlockGlobalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008433 RID: 33843
		// (get) Token: 0x0601C37A RID: 115578 RVA: 0x003FBF80 File Offset: 0x003FA180
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

		// Token: 0x17008434 RID: 33844
		// (get) Token: 0x0601C37B RID: 115579 RVA: 0x003FBFBC File Offset: 0x003FA1BC
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

		// Token: 0x0601C37C RID: 115580 RVA: 0x003FBFF3 File Offset: 0x003FA1F3
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C37D RID: 115581 RVA: 0x003FC002 File Offset: 0x003FA202
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C37E RID: 115582 RVA: 0x003FC010 File Offset: 0x003FA210
		public IRollBlockLevelConfig? Levels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IRollBlockLevelConfig?(default(IRollBlockLevelConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008435 RID: 33845
		// (get) Token: 0x0601C37F RID: 115583 RVA: 0x003FC070 File Offset: 0x003FA270
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

		// Token: 0x0601C380 RID: 115584 RVA: 0x003FC09B File Offset: 0x003FA29B
		public static Offset<IRollBlockGlobalConfig> CreateIRollBlockGlobalConfig(FlatBufferBuilder builder, int Id = 0, StringOffset GroupNameOffset = default(StringOffset), VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRollBlockGlobalConfig.AddLevels(builder, LevelsOffset);
			IRollBlockGlobalConfig.AddGroupName(builder, GroupNameOffset);
			IRollBlockGlobalConfig.AddId(builder, Id);
			return IRollBlockGlobalConfig.EndIRollBlockGlobalConfig(builder);
		}

		// Token: 0x0601C381 RID: 115585 RVA: 0x003FC0BF File Offset: 0x003FA2BF
		public static void StartIRollBlockGlobalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C382 RID: 115586 RVA: 0x003FC0C8 File Offset: 0x003FA2C8
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C383 RID: 115587 RVA: 0x003FC0D3 File Offset: 0x003FA2D3
		public static void AddGroupName(FlatBufferBuilder builder, StringOffset groupNameOffset)
		{
			builder.AddOffset(1, groupNameOffset.Value, 0);
		}

		// Token: 0x0601C384 RID: 115588 RVA: 0x003FC0E3 File Offset: 0x003FA2E3
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(2, levelsOffset.Value, 0);
		}

		// Token: 0x0601C385 RID: 115589 RVA: 0x003FC0F4 File Offset: 0x003FA2F4
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<IRollBlockLevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C386 RID: 115590 RVA: 0x003FC134 File Offset: 0x003FA334
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, Offset<IRollBlockLevelConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRollBlockLevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C387 RID: 115591 RVA: 0x003FC14E File Offset: 0x003FA34E
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRollBlockLevelConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRollBlockLevelConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C388 RID: 115592 RVA: 0x003FC16C File Offset: 0x003FA36C
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRollBlockLevelConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C389 RID: 115593 RVA: 0x003FC185 File Offset: 0x003FA385
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C38A RID: 115594 RVA: 0x003FC190 File Offset: 0x003FA390
		public static Offset<IRollBlockGlobalConfig> EndIRollBlockGlobalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGlobalConfig>(builder.EndTable());
		}

		// Token: 0x0601C38B RID: 115595 RVA: 0x003FC1A0 File Offset: 0x003FA3A0
		public IRollBlockGlobalConfigT UnPack()
		{
			IRollBlockGlobalConfigT rollBlockGlobalConfigT = new IRollBlockGlobalConfigT();
			this.UnPackTo(rollBlockGlobalConfigT);
			return rollBlockGlobalConfigT;
		}

		// Token: 0x0601C38C RID: 115596 RVA: 0x003FC1BC File Offset: 0x003FA3BC
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

		// Token: 0x0601C38D RID: 115597 RVA: 0x003FC234 File Offset: 0x003FA434
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

		// Token: 0x0400D018 RID: 53272
		private Table __p;
	}
}
