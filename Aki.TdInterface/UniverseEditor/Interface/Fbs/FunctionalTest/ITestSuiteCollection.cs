using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004724 RID: 18212
	public struct ITestSuiteCollection : IFlatbufferObject
	{
		// Token: 0x17008286 RID: 33414
		// (get) Token: 0x0601BFA3 RID: 114595 RVA: 0x003F702B File Offset: 0x003F522B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BFA4 RID: 114596 RVA: 0x003F7038 File Offset: 0x003F5238
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BFA5 RID: 114597 RVA: 0x003F7040 File Offset: 0x003F5240
		public static ITestSuiteCollection GetRootAsITestSuiteCollection(ByteBuffer _bb)
		{
			return ITestSuiteCollection.GetRootAsITestSuiteCollection(_bb, default(ITestSuiteCollection));
		}

		// Token: 0x0601BFA6 RID: 114598 RVA: 0x003F705C File Offset: 0x003F525C
		public static ITestSuiteCollection GetRootAsITestSuiteCollection(ByteBuffer _bb, ITestSuiteCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BFA7 RID: 114599 RVA: 0x003F7079 File Offset: 0x003F5279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BFA8 RID: 114600 RVA: 0x003F7088 File Offset: 0x003F5288
		public ITestSuiteCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008287 RID: 33415
		// (get) Token: 0x0601BFA9 RID: 114601 RVA: 0x003F7098 File Offset: 0x003F5298
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BFAA RID: 114602 RVA: 0x003F70CF File Offset: 0x003F52CF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BFAB RID: 114603 RVA: 0x003F70DE File Offset: 0x003F52DE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008288 RID: 33416
		// (get) Token: 0x0601BFAC RID: 114604 RVA: 0x003F70EC File Offset: 0x003F52EC
		public int LevelId
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

		// Token: 0x0601BFAD RID: 114605 RVA: 0x003F7128 File Offset: 0x003F5328
		public ITestSuite? Suites(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITestSuite?(default(ITestSuite).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008289 RID: 33417
		// (get) Token: 0x0601BFAE RID: 114606 RVA: 0x003F7188 File Offset: 0x003F5388
		public int SuitesLength
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

		// Token: 0x0601BFAF RID: 114607 RVA: 0x003F71B3 File Offset: 0x003F53B3
		public static Offset<ITestSuiteCollection> CreateITestSuiteCollection(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), int LevelId = 0, VectorOffset SuitesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITestSuiteCollection.AddSuites(builder, SuitesOffset);
			ITestSuiteCollection.AddLevelId(builder, LevelId);
			ITestSuiteCollection.AddId(builder, IdOffset);
			return ITestSuiteCollection.EndITestSuiteCollection(builder);
		}

		// Token: 0x0601BFB0 RID: 114608 RVA: 0x003F71D7 File Offset: 0x003F53D7
		public static void StartITestSuiteCollection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BFB1 RID: 114609 RVA: 0x003F71E0 File Offset: 0x003F53E0
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601BFB2 RID: 114610 RVA: 0x003F71F0 File Offset: 0x003F53F0
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601BFB3 RID: 114611 RVA: 0x003F71FB File Offset: 0x003F53FB
		public static void AddSuites(FlatBufferBuilder builder, VectorOffset suitesOffset)
		{
			builder.AddOffset(2, suitesOffset.Value, 0);
		}

		// Token: 0x0601BFB4 RID: 114612 RVA: 0x003F720C File Offset: 0x003F540C
		public static VectorOffset CreateSuitesVector(FlatBufferBuilder builder, Offset<ITestSuite>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BFB5 RID: 114613 RVA: 0x003F724C File Offset: 0x003F544C
		public static VectorOffset CreateSuitesVectorBlock(FlatBufferBuilder builder, Offset<ITestSuite>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITestSuite>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFB6 RID: 114614 RVA: 0x003F7266 File Offset: 0x003F5466
		public static VectorOffset CreateSuitesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITestSuite>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITestSuite>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFB7 RID: 114615 RVA: 0x003F7284 File Offset: 0x003F5484
		public static VectorOffset CreateSuitesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITestSuite>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BFB8 RID: 114616 RVA: 0x003F729D File Offset: 0x003F549D
		public static void StartSuitesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BFB9 RID: 114617 RVA: 0x003F72A8 File Offset: 0x003F54A8
		public static Offset<ITestSuiteCollection> EndITestSuiteCollection(FlatBufferBuilder builder)
		{
			return new Offset<ITestSuiteCollection>(builder.EndTable());
		}

		// Token: 0x0601BFBA RID: 114618 RVA: 0x003F72B8 File Offset: 0x003F54B8
		public ITestSuiteCollectionT UnPack()
		{
			ITestSuiteCollectionT testSuiteCollectionT = new ITestSuiteCollectionT();
			this.UnPackTo(testSuiteCollectionT);
			return testSuiteCollectionT;
		}

		// Token: 0x0601BFBB RID: 114619 RVA: 0x003F72D4 File Offset: 0x003F54D4
		public void UnPackTo(ITestSuiteCollectionT _o)
		{
			_o.Id = this.Id;
			_o.LevelId = this.LevelId;
			_o.Suites = new List<ITestSuiteT>();
			for (int i = 0; i < this.SuitesLength; i++)
			{
				_o.Suites.Add((this.Suites(i) != null) ? this.Suites(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BFBC RID: 114620 RVA: 0x003F734C File Offset: 0x003F554C
		public static Offset<ITestSuiteCollection> Pack(FlatBufferBuilder builder, ITestSuiteCollectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITestSuiteCollection>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			VectorOffset suitesOffset = default(VectorOffset);
			if (_o.Suites != null)
			{
				Offset<ITestSuite>[] array = new Offset<ITestSuite>[_o.Suites.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITestSuite.Pack(builder, _o.Suites[i]);
				}
				suitesOffset = ITestSuiteCollection.CreateSuitesVector(builder, array);
			}
			return ITestSuiteCollection.CreateITestSuiteCollection(builder, idOffset, _o.LevelId, suitesOffset);
		}

		// Token: 0x0400C9FC RID: 51708
		private Table __p;
	}
}
