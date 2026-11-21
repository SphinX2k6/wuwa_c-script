using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B8C RID: 19340
	public struct ITestSuiteCollection : IFlatbufferObject
	{
		// Token: 0x170088C7 RID: 35015
		// (get) Token: 0x0601D778 RID: 120696 RVA: 0x004232C7 File Offset: 0x004214C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D779 RID: 120697 RVA: 0x004232D4 File Offset: 0x004214D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D77A RID: 120698 RVA: 0x004232DC File Offset: 0x004214DC
		public static ITestSuiteCollection GetRootAsITestSuiteCollection(ByteBuffer _bb)
		{
			return ITestSuiteCollection.GetRootAsITestSuiteCollection(_bb, default(ITestSuiteCollection));
		}

		// Token: 0x0601D77B RID: 120699 RVA: 0x004232F8 File Offset: 0x004214F8
		public static ITestSuiteCollection GetRootAsITestSuiteCollection(ByteBuffer _bb, ITestSuiteCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D77C RID: 120700 RVA: 0x00423315 File Offset: 0x00421515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D77D RID: 120701 RVA: 0x00423324 File Offset: 0x00421524
		public ITestSuiteCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088C8 RID: 35016
		// (get) Token: 0x0601D77E RID: 120702 RVA: 0x00423334 File Offset: 0x00421534
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

		// Token: 0x0601D77F RID: 120703 RVA: 0x0042336B File Offset: 0x0042156B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D780 RID: 120704 RVA: 0x0042337A File Offset: 0x0042157A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170088C9 RID: 35017
		// (get) Token: 0x0601D781 RID: 120705 RVA: 0x00423388 File Offset: 0x00421588
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

		// Token: 0x0601D782 RID: 120706 RVA: 0x004233C4 File Offset: 0x004215C4
		public ITestSuite? Suites(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITestSuite?(default(ITestSuite).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170088CA RID: 35018
		// (get) Token: 0x0601D783 RID: 120707 RVA: 0x00423424 File Offset: 0x00421624
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

		// Token: 0x0601D784 RID: 120708 RVA: 0x0042344F File Offset: 0x0042164F
		public static Offset<ITestSuiteCollection> CreateITestSuiteCollection(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), int LevelId = 0, VectorOffset SuitesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITestSuiteCollection.AddSuites(builder, SuitesOffset);
			ITestSuiteCollection.AddLevelId(builder, LevelId);
			ITestSuiteCollection.AddId(builder, IdOffset);
			return ITestSuiteCollection.EndITestSuiteCollection(builder);
		}

		// Token: 0x0601D785 RID: 120709 RVA: 0x00423473 File Offset: 0x00421673
		public static void StartITestSuiteCollection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D786 RID: 120710 RVA: 0x0042347C File Offset: 0x0042167C
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601D787 RID: 120711 RVA: 0x0042348C File Offset: 0x0042168C
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601D788 RID: 120712 RVA: 0x00423497 File Offset: 0x00421697
		public static void AddSuites(FlatBufferBuilder builder, VectorOffset suitesOffset)
		{
			builder.AddOffset(2, suitesOffset.Value, 0);
		}

		// Token: 0x0601D789 RID: 120713 RVA: 0x004234A8 File Offset: 0x004216A8
		public static VectorOffset CreateSuitesVector(FlatBufferBuilder builder, Offset<ITestSuite>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D78A RID: 120714 RVA: 0x004234E8 File Offset: 0x004216E8
		public static VectorOffset CreateSuitesVectorBlock(FlatBufferBuilder builder, Offset<ITestSuite>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITestSuite>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D78B RID: 120715 RVA: 0x00423502 File Offset: 0x00421702
		public static VectorOffset CreateSuitesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITestSuite>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITestSuite>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D78C RID: 120716 RVA: 0x00423520 File Offset: 0x00421720
		public static VectorOffset CreateSuitesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITestSuite>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D78D RID: 120717 RVA: 0x00423539 File Offset: 0x00421739
		public static void StartSuitesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D78E RID: 120718 RVA: 0x00423544 File Offset: 0x00421744
		public static Offset<ITestSuiteCollection> EndITestSuiteCollection(FlatBufferBuilder builder)
		{
			return new Offset<ITestSuiteCollection>(builder.EndTable());
		}

		// Token: 0x0601D78F RID: 120719 RVA: 0x00423554 File Offset: 0x00421754
		public ITestSuiteCollectionT UnPack()
		{
			ITestSuiteCollectionT testSuiteCollectionT = new ITestSuiteCollectionT();
			this.UnPackTo(testSuiteCollectionT);
			return testSuiteCollectionT;
		}

		// Token: 0x0601D790 RID: 120720 RVA: 0x00423570 File Offset: 0x00421770
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

		// Token: 0x0601D791 RID: 120721 RVA: 0x004235E8 File Offset: 0x004217E8
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

		// Token: 0x0400D42B RID: 54315
		private Table __p;
	}
}
