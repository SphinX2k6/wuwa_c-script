using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004721 RID: 18209
	public struct ITestSuite : IFlatbufferObject
	{
		// Token: 0x1700827F RID: 33407
		// (get) Token: 0x0601BF7F RID: 114559 RVA: 0x003F6B84 File Offset: 0x003F4D84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF80 RID: 114560 RVA: 0x003F6B91 File Offset: 0x003F4D91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF81 RID: 114561 RVA: 0x003F6B98 File Offset: 0x003F4D98
		public static ITestSuite GetRootAsITestSuite(ByteBuffer _bb)
		{
			return ITestSuite.GetRootAsITestSuite(_bb, default(ITestSuite));
		}

		// Token: 0x0601BF82 RID: 114562 RVA: 0x003F6BB4 File Offset: 0x003F4DB4
		public static ITestSuite GetRootAsITestSuite(ByteBuffer _bb, ITestSuite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF83 RID: 114563 RVA: 0x003F6BD1 File Offset: 0x003F4DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF84 RID: 114564 RVA: 0x003F6BE0 File Offset: 0x003F4DE0
		public ITestSuite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008280 RID: 33408
		// (get) Token: 0x0601BF85 RID: 114565 RVA: 0x003F6BF0 File Offset: 0x003F4DF0
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

		// Token: 0x0601BF86 RID: 114566 RVA: 0x003F6C27 File Offset: 0x003F4E27
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BF87 RID: 114567 RVA: 0x003F6C36 File Offset: 0x003F4E36
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008281 RID: 33409
		// (get) Token: 0x0601BF88 RID: 114568 RVA: 0x003F6C44 File Offset: 0x003F4E44
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

		// Token: 0x0601BF89 RID: 114569 RVA: 0x003F6C7B File Offset: 0x003F4E7B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BF8A RID: 114570 RVA: 0x003F6C8A File Offset: 0x003F4E8A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601BF8B RID: 114571 RVA: 0x003F6C98 File Offset: 0x003F4E98
		public ITestCase? Cases(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITestCase?(default(ITestCase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008282 RID: 33410
		// (get) Token: 0x0601BF8C RID: 114572 RVA: 0x003F6CF8 File Offset: 0x003F4EF8
		public int CasesLength
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

		// Token: 0x0601BF8D RID: 114573 RVA: 0x003F6D23 File Offset: 0x003F4F23
		public static Offset<ITestSuite> CreateITestSuite(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), VectorOffset CasesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITestSuite.AddCases(builder, CasesOffset);
			ITestSuite.AddName(builder, NameOffset);
			ITestSuite.AddId(builder, IdOffset);
			return ITestSuite.EndITestSuite(builder);
		}

		// Token: 0x0601BF8E RID: 114574 RVA: 0x003F6D47 File Offset: 0x003F4F47
		public static void StartITestSuite(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BF8F RID: 114575 RVA: 0x003F6D50 File Offset: 0x003F4F50
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601BF90 RID: 114576 RVA: 0x003F6D60 File Offset: 0x003F4F60
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601BF91 RID: 114577 RVA: 0x003F6D70 File Offset: 0x003F4F70
		public static void AddCases(FlatBufferBuilder builder, VectorOffset casesOffset)
		{
			builder.AddOffset(2, casesOffset.Value, 0);
		}

		// Token: 0x0601BF92 RID: 114578 RVA: 0x003F6D80 File Offset: 0x003F4F80
		public static VectorOffset CreateCasesVector(FlatBufferBuilder builder, Offset<ITestCase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BF93 RID: 114579 RVA: 0x003F6DC0 File Offset: 0x003F4FC0
		public static VectorOffset CreateCasesVectorBlock(FlatBufferBuilder builder, Offset<ITestCase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITestCase>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BF94 RID: 114580 RVA: 0x003F6DDA File Offset: 0x003F4FDA
		public static VectorOffset CreateCasesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITestCase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITestCase>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BF95 RID: 114581 RVA: 0x003F6DF8 File Offset: 0x003F4FF8
		public static VectorOffset CreateCasesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITestCase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BF96 RID: 114582 RVA: 0x003F6E11 File Offset: 0x003F5011
		public static void StartCasesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BF97 RID: 114583 RVA: 0x003F6E1C File Offset: 0x003F501C
		public static Offset<ITestSuite> EndITestSuite(FlatBufferBuilder builder)
		{
			return new Offset<ITestSuite>(builder.EndTable());
		}

		// Token: 0x0601BF98 RID: 114584 RVA: 0x003F6E2C File Offset: 0x003F502C
		public ITestSuiteT UnPack()
		{
			ITestSuiteT testSuiteT = new ITestSuiteT();
			this.UnPackTo(testSuiteT);
			return testSuiteT;
		}

		// Token: 0x0601BF99 RID: 114585 RVA: 0x003F6E48 File Offset: 0x003F5048
		public void UnPackTo(ITestSuiteT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Cases = new List<ITestCaseT>();
			for (int i = 0; i < this.CasesLength; i++)
			{
				_o.Cases.Add((this.Cases(i) != null) ? this.Cases(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BF9A RID: 114586 RVA: 0x003F6EC0 File Offset: 0x003F50C0
		public static Offset<ITestSuite> Pack(FlatBufferBuilder builder, ITestSuiteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITestSuite>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset casesOffset = default(VectorOffset);
			if (_o.Cases != null)
			{
				Offset<ITestCase>[] array = new Offset<ITestCase>[_o.Cases.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITestCase.Pack(builder, _o.Cases[i]);
				}
				casesOffset = ITestSuite.CreateCasesVector(builder, array);
			}
			return ITestSuite.CreateITestSuite(builder, idOffset, nameOffset, casesOffset);
		}

		// Token: 0x0400C9F8 RID: 51704
		private Table __p;
	}
}
