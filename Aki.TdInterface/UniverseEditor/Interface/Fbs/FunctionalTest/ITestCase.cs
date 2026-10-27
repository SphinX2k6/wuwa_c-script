using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x0200471E RID: 18206
	public struct ITestCase : IFlatbufferObject
	{
		// Token: 0x17008270 RID: 33392
		// (get) Token: 0x0601BF45 RID: 114501 RVA: 0x003F6464 File Offset: 0x003F4664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF46 RID: 114502 RVA: 0x003F6471 File Offset: 0x003F4671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF47 RID: 114503 RVA: 0x003F6478 File Offset: 0x003F4678
		public static ITestCase GetRootAsITestCase(ByteBuffer _bb)
		{
			return ITestCase.GetRootAsITestCase(_bb, default(ITestCase));
		}

		// Token: 0x0601BF48 RID: 114504 RVA: 0x003F6494 File Offset: 0x003F4694
		public static ITestCase GetRootAsITestCase(ByteBuffer _bb, ITestCase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF49 RID: 114505 RVA: 0x003F64B1 File Offset: 0x003F46B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF4A RID: 114506 RVA: 0x003F64C0 File Offset: 0x003F46C0
		public ITestCase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008271 RID: 33393
		// (get) Token: 0x0601BF4B RID: 114507 RVA: 0x003F64D0 File Offset: 0x003F46D0
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

		// Token: 0x0601BF4C RID: 114508 RVA: 0x003F6507 File Offset: 0x003F4707
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BF4D RID: 114509 RVA: 0x003F6516 File Offset: 0x003F4716
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008272 RID: 33394
		// (get) Token: 0x0601BF4E RID: 114510 RVA: 0x003F6524 File Offset: 0x003F4724
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

		// Token: 0x0601BF4F RID: 114511 RVA: 0x003F655B File Offset: 0x003F475B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BF50 RID: 114512 RVA: 0x003F656A File Offset: 0x003F476A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008273 RID: 33395
		// (get) Token: 0x0601BF51 RID: 114513 RVA: 0x003F6578 File Offset: 0x003F4778
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

		// Token: 0x0601BF52 RID: 114514 RVA: 0x003F65AF File Offset: 0x003F47AF
		public Span<byte> GetAuthorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601BF53 RID: 114515 RVA: 0x003F65BE File Offset: 0x003F47BE
		public byte[] GetAuthorArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008274 RID: 33396
		// (get) Token: 0x0601BF54 RID: 114516 RVA: 0x003F65CC File Offset: 0x003F47CC
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

		// Token: 0x0601BF55 RID: 114517 RVA: 0x003F6604 File Offset: 0x003F4804
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601BF56 RID: 114518 RVA: 0x003F6614 File Offset: 0x003F4814
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601BF57 RID: 114519 RVA: 0x003F6624 File Offset: 0x003F4824
		public string Steps(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008275 RID: 33397
		// (get) Token: 0x0601BF58 RID: 114520 RVA: 0x003F6660 File Offset: 0x003F4860
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

		// Token: 0x17008276 RID: 33398
		// (get) Token: 0x0601BF59 RID: 114521 RVA: 0x003F668C File Offset: 0x003F488C
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

		// Token: 0x0601BF5A RID: 114522 RVA: 0x003F66C4 File Offset: 0x003F48C4
		public Span<byte> GetResultBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601BF5B RID: 114523 RVA: 0x003F66D4 File Offset: 0x003F48D4
		public byte[] GetResultArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008277 RID: 33399
		// (get) Token: 0x0601BF5C RID: 114524 RVA: 0x003F66E4 File Offset: 0x003F48E4
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

		// Token: 0x0601BF5D RID: 114525 RVA: 0x003F6724 File Offset: 0x003F4924
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

		// Token: 0x0601BF5E RID: 114526 RVA: 0x003F6773 File Offset: 0x003F4973
		public static void StartITestCase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601BF5F RID: 114527 RVA: 0x003F677C File Offset: 0x003F497C
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601BF60 RID: 114528 RVA: 0x003F678C File Offset: 0x003F498C
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601BF61 RID: 114529 RVA: 0x003F679C File Offset: 0x003F499C
		public static void AddAuthor(FlatBufferBuilder builder, StringOffset authorOffset)
		{
			builder.AddOffset(2, authorOffset.Value, 0);
		}

		// Token: 0x0601BF62 RID: 114530 RVA: 0x003F67AC File Offset: 0x003F49AC
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(3, descOffset.Value, 0);
		}

		// Token: 0x0601BF63 RID: 114531 RVA: 0x003F67BC File Offset: 0x003F49BC
		public static void AddSteps(FlatBufferBuilder builder, VectorOffset stepsOffset)
		{
			builder.AddOffset(4, stepsOffset.Value, 0);
		}

		// Token: 0x0601BF64 RID: 114532 RVA: 0x003F67CC File Offset: 0x003F49CC
		public static VectorOffset CreateStepsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BF65 RID: 114533 RVA: 0x003F680C File Offset: 0x003F4A0C
		public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BF66 RID: 114534 RVA: 0x003F6826 File Offset: 0x003F4A26
		public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BF67 RID: 114535 RVA: 0x003F6844 File Offset: 0x003F4A44
		public static VectorOffset CreateStepsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BF68 RID: 114536 RVA: 0x003F685D File Offset: 0x003F4A5D
		public static void StartStepsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BF69 RID: 114537 RVA: 0x003F6868 File Offset: 0x003F4A68
		public static void AddResult(FlatBufferBuilder builder, StringOffset resultOffset)
		{
			builder.AddOffset(5, resultOffset.Value, 0);
		}

		// Token: 0x0601BF6A RID: 114538 RVA: 0x003F6878 File Offset: 0x003F4A78
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(6, entityId, 0);
		}

		// Token: 0x0601BF6B RID: 114539 RVA: 0x003F6883 File Offset: 0x003F4A83
		public static Offset<ITestCase> EndITestCase(FlatBufferBuilder builder)
		{
			return new Offset<ITestCase>(builder.EndTable());
		}

		// Token: 0x0601BF6C RID: 114540 RVA: 0x003F6890 File Offset: 0x003F4A90
		public ITestCaseT UnPack()
		{
			ITestCaseT testCaseT = new ITestCaseT();
			this.UnPackTo(testCaseT);
			return testCaseT;
		}

		// Token: 0x0601BF6D RID: 114541 RVA: 0x003F68AC File Offset: 0x003F4AAC
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

		// Token: 0x0601BF6E RID: 114542 RVA: 0x003F6930 File Offset: 0x003F4B30
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

		// Token: 0x0400C9F0 RID: 51696
		private Table __p;
	}
}
