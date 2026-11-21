using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B86 RID: 19334
	public struct ITestCase : IFlatbufferObject
	{
		// Token: 0x170088B1 RID: 34993
		// (get) Token: 0x0601D71A RID: 120602 RVA: 0x00422700 File Offset: 0x00420900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D71B RID: 120603 RVA: 0x0042270D File Offset: 0x0042090D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D71C RID: 120604 RVA: 0x00422714 File Offset: 0x00420914
		public static ITestCase GetRootAsITestCase(ByteBuffer _bb)
		{
			return ITestCase.GetRootAsITestCase(_bb, default(ITestCase));
		}

		// Token: 0x0601D71D RID: 120605 RVA: 0x00422730 File Offset: 0x00420930
		public static ITestCase GetRootAsITestCase(ByteBuffer _bb, ITestCase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D71E RID: 120606 RVA: 0x0042274D File Offset: 0x0042094D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D71F RID: 120607 RVA: 0x0042275C File Offset: 0x0042095C
		public ITestCase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088B2 RID: 34994
		// (get) Token: 0x0601D720 RID: 120608 RVA: 0x0042276C File Offset: 0x0042096C
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

		// Token: 0x0601D721 RID: 120609 RVA: 0x004227A3 File Offset: 0x004209A3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D722 RID: 120610 RVA: 0x004227B2 File Offset: 0x004209B2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170088B3 RID: 34995
		// (get) Token: 0x0601D723 RID: 120611 RVA: 0x004227C0 File Offset: 0x004209C0
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

		// Token: 0x0601D724 RID: 120612 RVA: 0x004227F7 File Offset: 0x004209F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D725 RID: 120613 RVA: 0x00422806 File Offset: 0x00420A06
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170088B4 RID: 34996
		// (get) Token: 0x0601D726 RID: 120614 RVA: 0x00422814 File Offset: 0x00420A14
		public string Author
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

		// Token: 0x0601D727 RID: 120615 RVA: 0x0042284B File Offset: 0x00420A4B
		public Span<byte> GetAuthorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D728 RID: 120616 RVA: 0x0042285A File Offset: 0x00420A5A
		public byte[] GetAuthorArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170088B5 RID: 34997
		// (get) Token: 0x0601D729 RID: 120617 RVA: 0x00422868 File Offset: 0x00420A68
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D72A RID: 120618 RVA: 0x004228A0 File Offset: 0x00420AA0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601D72B RID: 120619 RVA: 0x004228B0 File Offset: 0x00420AB0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601D72C RID: 120620 RVA: 0x004228C0 File Offset: 0x00420AC0
		public string Steps(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170088B6 RID: 34998
		// (get) Token: 0x0601D72D RID: 120621 RVA: 0x004228FC File Offset: 0x00420AFC
		public int StepsLength
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

		// Token: 0x170088B7 RID: 34999
		// (get) Token: 0x0601D72E RID: 120622 RVA: 0x00422928 File Offset: 0x00420B28
		public string Result
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D72F RID: 120623 RVA: 0x00422960 File Offset: 0x00420B60
		public Span<byte> GetResultBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601D730 RID: 120624 RVA: 0x00422970 File Offset: 0x00420B70
		public byte[] GetResultArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170088B8 RID: 35000
		// (get) Token: 0x0601D731 RID: 120625 RVA: 0x00422980 File Offset: 0x00420B80
		public int EntityId
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

		// Token: 0x0601D732 RID: 120626 RVA: 0x004229C0 File Offset: 0x00420BC0
		public static Offset<ITestCase> CreateITestCase(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), StringOffset AuthorOffset = default(StringOffset), StringOffset DescOffset = default(StringOffset), VectorOffset StepsOffset = default(VectorOffset), StringOffset ResultOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(7);
			ITestCase.AddEntityId(builder, EntityId);
			ITestCase.AddResult(builder, ResultOffset);
			ITestCase.AddSteps(builder, StepsOffset);
			ITestCase.AddDesc(builder, DescOffset);
			ITestCase.AddAuthor(builder, AuthorOffset);
			ITestCase.AddName(builder, NameOffset);
			ITestCase.AddId(builder, IdOffset);
			return ITestCase.EndITestCase(builder);
		}

		// Token: 0x0601D733 RID: 120627 RVA: 0x00422A0F File Offset: 0x00420C0F
		public static void StartITestCase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D734 RID: 120628 RVA: 0x00422A18 File Offset: 0x00420C18
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601D735 RID: 120629 RVA: 0x00422A28 File Offset: 0x00420C28
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601D736 RID: 120630 RVA: 0x00422A38 File Offset: 0x00420C38
		public static void AddAuthor(FlatBufferBuilder builder, StringOffset authorOffset)
		{
			builder.AddOffset(2, authorOffset.Value, 0);
		}

		// Token: 0x0601D737 RID: 120631 RVA: 0x00422A48 File Offset: 0x00420C48
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(3, descOffset.Value, 0);
		}

		// Token: 0x0601D738 RID: 120632 RVA: 0x00422A58 File Offset: 0x00420C58
		public static void AddSteps(FlatBufferBuilder builder, VectorOffset stepsOffset)
		{
			builder.AddOffset(4, stepsOffset.Value, 0);
		}

		// Token: 0x0601D739 RID: 120633 RVA: 0x00422A68 File Offset: 0x00420C68
		public static VectorOffset CreateStepsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D73A RID: 120634 RVA: 0x00422AA8 File Offset: 0x00420CA8
		public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D73B RID: 120635 RVA: 0x00422AC2 File Offset: 0x00420CC2
		public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D73C RID: 120636 RVA: 0x00422AE0 File Offset: 0x00420CE0
		public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D73D RID: 120637 RVA: 0x00422AF9 File Offset: 0x00420CF9
		public static void StartStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D73E RID: 120638 RVA: 0x00422B04 File Offset: 0x00420D04
		public static void AddResult(FlatBufferBuilder builder, StringOffset resultOffset)
		{
			builder.AddOffset(5, resultOffset.Value, 0);
		}

		// Token: 0x0601D73F RID: 120639 RVA: 0x00422B14 File Offset: 0x00420D14
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(6, entityId, 0);
		}

		// Token: 0x0601D740 RID: 120640 RVA: 0x00422B1F File Offset: 0x00420D1F
		public static Offset<ITestCase> EndITestCase(FlatBufferBuilder builder)
		{
			return new Offset<ITestCase>(builder.EndTable());
		}

		// Token: 0x0601D741 RID: 120641 RVA: 0x00422B2C File Offset: 0x00420D2C
		public ITestCaseT UnPack()
		{
			ITestCaseT testCaseT = new ITestCaseT();
			this.UnPackTo(testCaseT);
			return testCaseT;
		}

		// Token: 0x0601D742 RID: 120642 RVA: 0x00422B48 File Offset: 0x00420D48
		public void UnPackTo(ITestCaseT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Author = this.Author;
			_o.Desc = this.Desc;
			_o.Steps = new List<string>();
			for (int i = 0; i < this.StepsLength; i++)
			{
				_o.Steps.Add(this.Steps(i));
			}
			_o.Result = this.Result;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601D743 RID: 120643 RVA: 0x00422BCC File Offset: 0x00420DCC
		public static Offset<ITestCase> Pack(FlatBufferBuilder builder, ITestCaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITestCase>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset authorOffset = (_o.Author == null) ? default(StringOffset) : builder.CreateString(_o.Author);
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			VectorOffset stepsOffset = default(VectorOffset);
			if (_o.Steps != null)
			{
				StringOffset[] array = new StringOffset[_o.Steps.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Steps[i]);
				}
				stepsOffset = ITestCase.CreateStepsVector(builder, array);
			}
			StringOffset resultOffset = (_o.Result == null) ? default(StringOffset) : builder.CreateString(_o.Result);
			return ITestCase.CreateITestCase(builder, idOffset, nameOffset, authorOffset, descOffset, stepsOffset, resultOffset, _o.EntityId);
		}

		// Token: 0x0400D41F RID: 54303
		private Table __p;
	}
}
