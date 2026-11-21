using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B89 RID: 19337
	public struct ITestSuite : IFlatbufferObject
	{
		// Token: 0x170088C0 RID: 35008
		// (get) Token: 0x0601D754 RID: 120660 RVA: 0x00422E20 File Offset: 0x00421020
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D755 RID: 120661 RVA: 0x00422E2D File Offset: 0x0042102D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D756 RID: 120662 RVA: 0x00422E34 File Offset: 0x00421034
		public static ITestSuite GetRootAsITestSuite(ByteBuffer _bb)
		{
			return ITestSuite.GetRootAsITestSuite(_bb, default(ITestSuite));
		}

		// Token: 0x0601D757 RID: 120663 RVA: 0x00422E50 File Offset: 0x00421050
		public static ITestSuite GetRootAsITestSuite(ByteBuffer _bb, ITestSuite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D758 RID: 120664 RVA: 0x00422E6D File Offset: 0x0042106D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D759 RID: 120665 RVA: 0x00422E7C File Offset: 0x0042107C
		public ITestSuite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088C1 RID: 35009
		// (get) Token: 0x0601D75A RID: 120666 RVA: 0x00422E8C File Offset: 0x0042108C
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

		// Token: 0x0601D75B RID: 120667 RVA: 0x00422EC3 File Offset: 0x004210C3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D75C RID: 120668 RVA: 0x00422ED2 File Offset: 0x004210D2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170088C2 RID: 35010
		// (get) Token: 0x0601D75D RID: 120669 RVA: 0x00422EE0 File Offset: 0x004210E0
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

		// Token: 0x0601D75E RID: 120670 RVA: 0x00422F17 File Offset: 0x00421117
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D75F RID: 120671 RVA: 0x00422F26 File Offset: 0x00421126
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D760 RID: 120672 RVA: 0x00422F34 File Offset: 0x00421134
		public ITestCase? Cases(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITestCase?(default(ITestCase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170088C3 RID: 35011
		// (get) Token: 0x0601D761 RID: 120673 RVA: 0x00422F94 File Offset: 0x00421194
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

		// Token: 0x0601D762 RID: 120674 RVA: 0x00422FBF File Offset: 0x004211BF
		public static Offset<ITestSuite> CreateITestSuite(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), VectorOffset CasesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ITestSuite.AddCases(builder, CasesOffset);
			ITestSuite.AddName(builder, NameOffset);
			ITestSuite.AddId(builder, IdOffset);
			return ITestSuite.EndITestSuite(builder);
		}

		// Token: 0x0601D763 RID: 120675 RVA: 0x00422FE3 File Offset: 0x004211E3
		public static void StartITestSuite(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D764 RID: 120676 RVA: 0x00422FEC File Offset: 0x004211EC
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601D765 RID: 120677 RVA: 0x00422FFC File Offset: 0x004211FC
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601D766 RID: 120678 RVA: 0x0042300C File Offset: 0x0042120C
		public static void AddCases(FlatBufferBuilder builder, VectorOffset casesOffset)
		{
			builder.AddOffset(2, casesOffset.Value, 0);
		}

		// Token: 0x0601D767 RID: 120679 RVA: 0x0042301C File Offset: 0x0042121C
		public static VectorOffset CreateCasesVector(FlatBufferBuilder builder, Offset<ITestCase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D768 RID: 120680 RVA: 0x0042305C File Offset: 0x0042125C
		public static VectorOffset CreateCasesVectorBlock(FlatBufferBuilder builder, Offset<ITestCase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITestCase>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D769 RID: 120681 RVA: 0x00423076 File Offset: 0x00421276
		public static VectorOffset CreateCasesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITestCase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITestCase>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D76A RID: 120682 RVA: 0x00423094 File Offset: 0x00421294
		public static VectorOffset CreateCasesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITestCase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D76B RID: 120683 RVA: 0x004230AD File Offset: 0x004212AD
		public static void StartCasesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D76C RID: 120684 RVA: 0x004230B8 File Offset: 0x004212B8
		public static Offset<ITestSuite> EndITestSuite(FlatBufferBuilder builder)
		{
			return new Offset<ITestSuite>(builder.EndTable());
		}

		// Token: 0x0601D76D RID: 120685 RVA: 0x004230C8 File Offset: 0x004212C8
		public ITestSuiteT UnPack()
		{
			ITestSuiteT testSuiteT = new ITestSuiteT();
			this.UnPackTo(testSuiteT);
			return testSuiteT;
		}

		// Token: 0x0601D76E RID: 120686 RVA: 0x004230E4 File Offset: 0x004212E4
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

		// Token: 0x0601D76F RID: 120687 RVA: 0x0042315C File Offset: 0x0042135C
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

		// Token: 0x0400D427 RID: 54311
		private Table __p;
	}
}
