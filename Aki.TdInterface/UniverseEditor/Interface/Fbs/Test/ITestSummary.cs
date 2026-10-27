using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003B75 RID: 15221
	public struct ITestSummary : IFlatbufferObject
	{
		// Token: 0x1700684C RID: 26700
		// (get) Token: 0x06014D4B RID: 85323 RVA: 0x003066AC File Offset: 0x003048AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014D4C RID: 85324 RVA: 0x003066B9 File Offset: 0x003048B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014D4D RID: 85325 RVA: 0x003066C0 File Offset: 0x003048C0
		public static ITestSummary GetRootAsITestSummary(ByteBuffer _bb)
		{
			return ITestSummary.GetRootAsITestSummary(_bb, default(ITestSummary));
		}

		// Token: 0x06014D4E RID: 85326 RVA: 0x003066DC File Offset: 0x003048DC
		public static ITestSummary GetRootAsITestSummary(ByteBuffer _bb, ITestSummary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014D4F RID: 85327 RVA: 0x003066F9 File Offset: 0x003048F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014D50 RID: 85328 RVA: 0x00306708 File Offset: 0x00304908
		public ITestSummary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700684D RID: 26701
		// (get) Token: 0x06014D51 RID: 85329 RVA: 0x00306718 File Offset: 0x00304918
		public int Total
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

		// Token: 0x1700684E RID: 26702
		// (get) Token: 0x06014D52 RID: 85330 RVA: 0x00306754 File Offset: 0x00304954
		public int Passed
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

		// Token: 0x1700684F RID: 26703
		// (get) Token: 0x06014D53 RID: 85331 RVA: 0x00306790 File Offset: 0x00304990
		public int Failed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006850 RID: 26704
		// (get) Token: 0x06014D54 RID: 85332 RVA: 0x003067CC File Offset: 0x003049CC
		public bool IsRequiredCaseAllPassed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006851 RID: 26705
		// (get) Token: 0x06014D55 RID: 85333 RVA: 0x0030680C File Offset: 0x00304A0C
		public int Time
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006852 RID: 26706
		// (get) Token: 0x06014D56 RID: 85334 RVA: 0x0030684C File Offset: 0x00304A4C
		public string ErrorMsg
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

		// Token: 0x06014D57 RID: 85335 RVA: 0x00306884 File Offset: 0x00304A84
		public Span<byte> GetErrorMsgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06014D58 RID: 85336 RVA: 0x00306894 File Offset: 0x00304A94
		public byte[] GetErrorMsgArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17006853 RID: 26707
		// (get) Token: 0x06014D59 RID: 85337 RVA: 0x003068A4 File Offset: 0x00304AA4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014D5A RID: 85338 RVA: 0x003068E4 File Offset: 0x00304AE4
		public static Offset<ITestSummary> CreateITestSummary(FlatBufferBuilder builder, int Total = 0, int Passed = 0, int Failed = 0, bool IsRequiredCaseAllPassed = false, int Time = 0, StringOffset ErrorMsgOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ITestSummary.AddErrorMsg(builder, ErrorMsgOffset);
			ITestSummary.AddTime(builder, Time);
			ITestSummary.AddFailed(builder, Failed);
			ITestSummary.AddPassed(builder, Passed);
			ITestSummary.AddTotal(builder, Total);
			ITestSummary.AddNullMask(builder, NullMask);
			ITestSummary.AddIsRequiredCaseAllPassed(builder, IsRequiredCaseAllPassed);
			return ITestSummary.EndITestSummary(builder);
		}

		// Token: 0x06014D5B RID: 85339 RVA: 0x00306933 File Offset: 0x00304B33
		public static void StartITestSummary(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06014D5C RID: 85340 RVA: 0x0030693C File Offset: 0x00304B3C
		public static void AddTotal(FlatBufferBuilder builder, int total)
		{
			builder.AddInt(0, total, 0);
		}

		// Token: 0x06014D5D RID: 85341 RVA: 0x00306947 File Offset: 0x00304B47
		public static void AddPassed(FlatBufferBuilder builder, int passed)
		{
			builder.AddInt(1, passed, 0);
		}

		// Token: 0x06014D5E RID: 85342 RVA: 0x00306952 File Offset: 0x00304B52
		public static void AddFailed(FlatBufferBuilder builder, int failed)
		{
			builder.AddInt(2, failed, 0);
		}

		// Token: 0x06014D5F RID: 85343 RVA: 0x0030695D File Offset: 0x00304B5D
		public static void AddIsRequiredCaseAllPassed(FlatBufferBuilder builder, bool isRequiredCaseAllPassed)
		{
			builder.AddBool(3, isRequiredCaseAllPassed, false);
		}

		// Token: 0x06014D60 RID: 85344 RVA: 0x00306968 File Offset: 0x00304B68
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(4, time, 0);
		}

		// Token: 0x06014D61 RID: 85345 RVA: 0x00306973 File Offset: 0x00304B73
		public static void AddErrorMsg(FlatBufferBuilder builder, StringOffset errorMsgOffset)
		{
			builder.AddOffset(5, errorMsgOffset.Value, 0);
		}

		// Token: 0x06014D62 RID: 85346 RVA: 0x00306983 File Offset: 0x00304B83
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06014D63 RID: 85347 RVA: 0x0030698E File Offset: 0x00304B8E
		public static Offset<ITestSummary> EndITestSummary(FlatBufferBuilder builder)
		{
			return new Offset<ITestSummary>(builder.EndTable());
		}

		// Token: 0x06014D64 RID: 85348 RVA: 0x0030699C File Offset: 0x00304B9C
		public ITestSummaryT UnPack()
		{
			ITestSummaryT testSummaryT = new ITestSummaryT();
			this.UnPackTo(testSummaryT);
			return testSummaryT;
		}

		// Token: 0x06014D65 RID: 85349 RVA: 0x003069B8 File Offset: 0x00304BB8
		public void UnPackTo(ITestSummaryT _o)
		{
			_o.Total = this.Total;
			_o.Passed = this.Passed;
			_o.Failed = this.Failed;
			_o.IsRequiredCaseAllPassed = this.IsRequiredCaseAllPassed;
			_o.Time = this.Time;
			_o.ErrorMsg = this.ErrorMsg;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014D66 RID: 85350 RVA: 0x00306A1C File Offset: 0x00304C1C
		public static Offset<ITestSummary> Pack(FlatBufferBuilder builder, ITestSummaryT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITestSummary>);
			}
			StringOffset errorMsgOffset = (_o.ErrorMsg == null) ? default(StringOffset) : builder.CreateString(_o.ErrorMsg);
			return ITestSummary.CreateITestSummary(builder, _o.Total, _o.Passed, _o.Failed, _o.IsRequiredCaseAllPassed, _o.Time, errorMsgOffset, _o.NullMask);
		}

		// Token: 0x0400B0BB RID: 45243
		private Table __p;
	}
}
