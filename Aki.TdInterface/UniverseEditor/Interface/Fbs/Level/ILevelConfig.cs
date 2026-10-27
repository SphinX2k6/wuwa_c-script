using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004409 RID: 17417
	public struct ILevelConfig : IFlatbufferObject
	{
		// Token: 0x17007ADE RID: 31454
		// (get) Token: 0x06019ED8 RID: 106200 RVA: 0x003B561E File Offset: 0x003B381E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019ED9 RID: 106201 RVA: 0x003B562B File Offset: 0x003B382B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019EDA RID: 106202 RVA: 0x003B5634 File Offset: 0x003B3834
		public static ILevelConfig GetRootAsILevelConfig(ByteBuffer _bb)
		{
			return ILevelConfig.GetRootAsILevelConfig(_bb, default(ILevelConfig));
		}

		// Token: 0x06019EDB RID: 106203 RVA: 0x003B5650 File Offset: 0x003B3850
		public static ILevelConfig GetRootAsILevelConfig(ByteBuffer _bb, ILevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019EDC RID: 106204 RVA: 0x003B566D File Offset: 0x003B386D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019EDD RID: 106205 RVA: 0x003B567C File Offset: 0x003B387C
		public ILevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ADF RID: 31455
		// (get) Token: 0x06019EDE RID: 106206 RVA: 0x003B568C File Offset: 0x003B388C
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

		// Token: 0x17007AE0 RID: 31456
		// (get) Token: 0x06019EDF RID: 106207 RVA: 0x003B56C8 File Offset: 0x003B38C8
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

		// Token: 0x06019EE0 RID: 106208 RVA: 0x003B56FF File Offset: 0x003B38FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019EE1 RID: 106209 RVA: 0x003B570E File Offset: 0x003B390E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007AE1 RID: 31457
		// (get) Token: 0x06019EE2 RID: 106210 RVA: 0x003B571C File Offset: 0x003B391C
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

		// Token: 0x06019EE3 RID: 106211 RVA: 0x003B5753 File Offset: 0x003B3953
		public Span<byte> GetContentPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019EE4 RID: 106212 RVA: 0x003B5762 File Offset: 0x003B3962
		public byte[] GetContentPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007AE2 RID: 31458
		// (get) Token: 0x06019EE5 RID: 106213 RVA: 0x003B5770 File Offset: 0x003B3970
		public bool IsPartition
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007AE3 RID: 31459
		// (get) Token: 0x06019EE6 RID: 106214 RVA: 0x003B57B0 File Offset: 0x003B39B0
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

		// Token: 0x17007AE4 RID: 31460
		// (get) Token: 0x06019EE7 RID: 106215 RVA: 0x003B5810 File Offset: 0x003B3A10
		public bool IsTest
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019EE8 RID: 106216 RVA: 0x003B5850 File Offset: 0x003B3A50
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

		// Token: 0x06019EE9 RID: 106217 RVA: 0x003B588C File Offset: 0x003B3A8C
		public static void StartILevelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019EEA RID: 106218 RVA: 0x003B5895 File Offset: 0x003B3A95
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06019EEB RID: 106219 RVA: 0x003B58A0 File Offset: 0x003B3AA0
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06019EEC RID: 106220 RVA: 0x003B58B0 File Offset: 0x003B3AB0
		public static void AddContentPath(FlatBufferBuilder builder, StringOffset contentPathOffset)
		{
			builder.AddOffset(2, contentPathOffset.Value, 0);
		}

		// Token: 0x06019EED RID: 106221 RVA: 0x003B58C0 File Offset: 0x003B3AC0
		public static void AddIsPartition(FlatBufferBuilder builder, bool isPartition)
		{
			builder.AddBool(3, isPartition, false);
		}

		// Token: 0x06019EEE RID: 106222 RVA: 0x003B58CB File Offset: 0x003B3ACB
		public static void AddPartitionData(FlatBufferBuilder builder, Offset<IMainWpPartitionData> partitionDataOffset)
		{
			builder.AddOffset(4, partitionDataOffset.Value, 0);
		}

		// Token: 0x06019EEF RID: 106223 RVA: 0x003B58DB File Offset: 0x003B3ADB
		public static void AddIsTest(FlatBufferBuilder builder, bool isTest)
		{
			builder.AddBool(5, isTest, false);
		}

		// Token: 0x06019EF0 RID: 106224 RVA: 0x003B58E6 File Offset: 0x003B3AE6
		public static Offset<ILevelConfig> EndILevelConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelConfig>(builder.EndTable());
		}

		// Token: 0x06019EF1 RID: 106225 RVA: 0x003B58F4 File Offset: 0x003B3AF4
		public ILevelConfigT UnPack()
		{
			ILevelConfigT levelConfigT = new ILevelConfigT();
			this.UnPackTo(levelConfigT);
			return levelConfigT;
		}

		// Token: 0x06019EF2 RID: 106226 RVA: 0x003B5910 File Offset: 0x003B3B10
		public void UnPackTo(ILevelConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.ContentPath = this.ContentPath;
			_o.IsPartition = this.IsPartition;
			_o.PartitionData = ((this.PartitionData != null) ? this.PartitionData.Value.UnPack() : null);
			_o.IsTest = this.IsTest;
		}

		// Token: 0x06019EF3 RID: 106227 RVA: 0x003B5988 File Offset: 0x003B3B88
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

		// Token: 0x0400C364 RID: 50020
		private Table __p;
	}
}
