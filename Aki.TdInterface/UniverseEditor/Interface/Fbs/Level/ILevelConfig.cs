using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004871 RID: 18545
	public struct ILevelConfig : IFlatbufferObject
	{
		// Token: 0x1700811D RID: 33053
		// (get) Token: 0x0601B6A9 RID: 112297 RVA: 0x003E182C File Offset: 0x003DFA2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6AA RID: 112298 RVA: 0x003E1839 File Offset: 0x003DFA39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6AB RID: 112299 RVA: 0x003E1840 File Offset: 0x003DFA40
		public static ILevelConfig GetRootAsILevelConfig(ByteBuffer _bb)
		{
			return ILevelConfig.GetRootAsILevelConfig(_bb, default(ILevelConfig));
		}

		// Token: 0x0601B6AC RID: 112300 RVA: 0x003E185C File Offset: 0x003DFA5C
		public static ILevelConfig GetRootAsILevelConfig(ByteBuffer _bb, ILevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6AD RID: 112301 RVA: 0x003E1879 File Offset: 0x003DFA79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B6AE RID: 112302 RVA: 0x003E1888 File Offset: 0x003DFA88
		public ILevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700811E RID: 33054
		// (get) Token: 0x0601B6AF RID: 112303 RVA: 0x003E1898 File Offset: 0x003DFA98
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

		// Token: 0x1700811F RID: 33055
		// (get) Token: 0x0601B6B0 RID: 112304 RVA: 0x003E18D4 File Offset: 0x003DFAD4
		public string Name
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

		// Token: 0x0601B6B1 RID: 112305 RVA: 0x003E190B File Offset: 0x003DFB0B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B6B2 RID: 112306 RVA: 0x003E191A File Offset: 0x003DFB1A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008120 RID: 33056
		// (get) Token: 0x0601B6B3 RID: 112307 RVA: 0x003E1928 File Offset: 0x003DFB28
		public string ContentPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B6B4 RID: 112308 RVA: 0x003E195F File Offset: 0x003DFB5F
		public Span<byte> GetContentPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B6B5 RID: 112309 RVA: 0x003E196E File Offset: 0x003DFB6E
		public byte[] GetContentPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008121 RID: 33057
		// (get) Token: 0x0601B6B6 RID: 112310 RVA: 0x003E197C File Offset: 0x003DFB7C
		public bool IsPartition
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008122 RID: 33058
		// (get) Token: 0x0601B6B7 RID: 112311 RVA: 0x003E19BC File Offset: 0x003DFBBC
		public IMainWpPartitionData? PartitionData
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IMainWpPartitionData?(default(IMainWpPartitionData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008123 RID: 33059
		// (get) Token: 0x0601B6B8 RID: 112312 RVA: 0x003E1A1C File Offset: 0x003DFC1C
		public bool IsTest
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B6B9 RID: 112313 RVA: 0x003E1A5C File Offset: 0x003DFC5C
		public static Offset<ILevelConfig> CreateILevelConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), StringOffset ContentPathOffset = default(StringOffset), bool IsPartition = false, Offset<IMainWpPartitionData> PartitionDataOffset = default(Offset<IMainWpPartitionData>), bool IsTest = false)
		{
			builder.StartTable(6);
			ILevelConfig.AddPartitionData(builder, PartitionDataOffset);
			ILevelConfig.AddContentPath(builder, ContentPathOffset);
			ILevelConfig.AddName(builder, NameOffset);
			ILevelConfig.AddId(builder, Id);
			ILevelConfig.AddIsTest(builder, IsTest);
			ILevelConfig.AddIsPartition(builder, IsPartition);
			return ILevelConfig.EndILevelConfig(builder);
		}

		// Token: 0x0601B6BA RID: 112314 RVA: 0x003E1A98 File Offset: 0x003DFC98
		public static void StartILevelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601B6BB RID: 112315 RVA: 0x003E1AA1 File Offset: 0x003DFCA1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B6BC RID: 112316 RVA: 0x003E1AAC File Offset: 0x003DFCAC
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601B6BD RID: 112317 RVA: 0x003E1ABC File Offset: 0x003DFCBC
		public static void AddContentPath(FlatBufferBuilder builder, StringOffset contentPathOffset)
		{
			builder.AddOffset(2, contentPathOffset.Value, 0);
		}

		// Token: 0x0601B6BE RID: 112318 RVA: 0x003E1ACC File Offset: 0x003DFCCC
		public static void AddIsPartition(FlatBufferBuilder builder, bool isPartition)
		{
			builder.AddBool(3, isPartition, false);
		}

		// Token: 0x0601B6BF RID: 112319 RVA: 0x003E1AD7 File Offset: 0x003DFCD7
		public static void AddPartitionData(FlatBufferBuilder builder, Offset<IMainWpPartitionData> partitionDataOffset)
		{
			builder.AddOffset(4, partitionDataOffset.Value, 0);
		}

		// Token: 0x0601B6C0 RID: 112320 RVA: 0x003E1AE7 File Offset: 0x003DFCE7
		public static void AddIsTest(FlatBufferBuilder builder, bool isTest)
		{
			builder.AddBool(5, isTest, false);
		}

		// Token: 0x0601B6C1 RID: 112321 RVA: 0x003E1AF2 File Offset: 0x003DFCF2
		public static Offset<ILevelConfig> EndILevelConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelConfig>(builder.EndTable());
		}

		// Token: 0x0601B6C2 RID: 112322 RVA: 0x003E1B00 File Offset: 0x003DFD00
		public ILevelConfigT UnPack()
		{
			ILevelConfigT levelConfigT = new ILevelConfigT();
			this.UnPackTo(levelConfigT);
			return levelConfigT;
		}

		// Token: 0x0601B6C3 RID: 112323 RVA: 0x003E1B1C File Offset: 0x003DFD1C
		public void UnPackTo(ILevelConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.ContentPath = this.ContentPath;
			_o.IsPartition = this.IsPartition;
			_o.PartitionData = ((this.PartitionData != null) ? this.PartitionData.Value.UnPack() : null);
			_o.IsTest = this.IsTest;
		}

		// Token: 0x0601B6C4 RID: 112324 RVA: 0x003E1B94 File Offset: 0x003DFD94
		public static Offset<ILevelConfig> Pack(FlatBufferBuilder builder, ILevelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset contentPathOffset = (_o.ContentPath == null) ? default(StringOffset) : builder.CreateString(_o.ContentPath);
			Offset<IMainWpPartitionData> partitionDataOffset = (_o.PartitionData == null) ? default(Offset<IMainWpPartitionData>) : IMainWpPartitionData.Pack(builder, _o.PartitionData);
			return ILevelConfig.CreateILevelConfig(builder, _o.Id, nameOffset, contentPathOffset, _o.IsPartition, partitionDataOffset, _o.IsTest);
		}

		// Token: 0x0400CD91 RID: 52625
		private Table __p;
	}
}
