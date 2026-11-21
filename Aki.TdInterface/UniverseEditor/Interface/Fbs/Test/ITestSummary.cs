using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003F7D RID: 16253
	public struct ITestSummary : IFlatbufferObject
	{
		// Token: 0x17006DEB RID: 28139
		// (get) Token: 0x06016215 RID: 90645 RVA: 0x0032CC44 File Offset: 0x0032AE44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016216 RID: 90646 RVA: 0x0032CC51 File Offset: 0x0032AE51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016217 RID: 90647 RVA: 0x0032CC58 File Offset: 0x0032AE58
		public static ITestSummary GetRootAsITestSummary(ByteBuffer _bb)
		{
			return ITestSummary.GetRootAsITestSummary(_bb, default(ITestSummary));
		}

		// Token: 0x06016218 RID: 90648 RVA: 0x0032CC74 File Offset: 0x0032AE74
		public static ITestSummary GetRootAsITestSummary(ByteBuffer _bb, ITestSummary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016219 RID: 90649 RVA: 0x0032CC91 File Offset: 0x0032AE91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601621A RID: 90650 RVA: 0x0032CCA0 File Offset: 0x0032AEA0
		public ITestSummary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DEC RID: 28140
		// (get) Token: 0x0601621B RID: 90651 RVA: 0x0032CCB0 File Offset: 0x0032AEB0
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

		// Token: 0x17006DED RID: 28141
		// (get) Token: 0x0601621C RID: 90652 RVA: 0x0032CCEC File Offset: 0x0032AEEC
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

		// Token: 0x17006DEE RID: 28142
		// (get) Token: 0x0601621D RID: 90653 RVA: 0x0032CD28 File Offset: 0x0032AF28
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

		// Token: 0x17006DEF RID: 28143
		// (get) Token: 0x0601621E RID: 90654 RVA: 0x0032CD64 File Offset: 0x0032AF64
		public bool IsRequiredCaseAllPassed
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006DF0 RID: 28144
		// (get) Token: 0x0601621F RID: 90655 RVA: 0x0032CDA4 File Offset: 0x0032AFA4
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

		// Token: 0x17006DF1 RID: 28145
		// (get) Token: 0x06016220 RID: 90656 RVA: 0x0032CDE4 File Offset: 0x0032AFE4
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

		// Token: 0x06016221 RID: 90657 RVA: 0x0032CE1C File Offset: 0x0032B01C
		public Span<byte> GetErrorMsgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06016222 RID: 90658 RVA: 0x0032CE2C File Offset: 0x0032B02C
		public byte[] GetErrorMsgArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17006DF2 RID: 28146
		// (get) Token: 0x06016223 RID: 90659 RVA: 0x0032CE3C File Offset: 0x0032B03C
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

		// Token: 0x06016224 RID: 90660 RVA: 0x0032CE7C File Offset: 0x0032B07C
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

		// Token: 0x06016225 RID: 90661 RVA: 0x0032CECB File Offset: 0x0032B0CB
		public static void StartITestSummary(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06016226 RID: 90662 RVA: 0x0032CED4 File Offset: 0x0032B0D4
		public static void AddTotal(FlatBufferBuilder builder, int total)
		{
			builder.AddInt(0, total, 0);
		}

		// Token: 0x06016227 RID: 90663 RVA: 0x0032CEDF File Offset: 0x0032B0DF
		public static void AddPassed(FlatBufferBuilder builder, int passed)
		{
			builder.AddInt(1, passed, 0);
		}

		// Token: 0x06016228 RID: 90664 RVA: 0x0032CEEA File Offset: 0x0032B0EA
		public static void AddFailed(FlatBufferBuilder builder, int failed)
		{
			builder.AddInt(2, failed, 0);
		}

		// Token: 0x06016229 RID: 90665 RVA: 0x0032CEF5 File Offset: 0x0032B0F5
		public static void AddIsRequiredCaseAllPassed(FlatBufferBuilder builder, bool isRequiredCaseAllPassed)
		{
			builder.AddBool(3, isRequiredCaseAllPassed, false);
		}

		// Token: 0x0601622A RID: 90666 RVA: 0x0032CF00 File Offset: 0x0032B100
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(4, time, 0);
		}

		// Token: 0x0601622B RID: 90667 RVA: 0x0032CF0B File Offset: 0x0032B10B
		public static void AddErrorMsg(FlatBufferBuilder builder, StringOffset errorMsgOffset)
		{
			builder.AddOffset(5, errorMsgOffset.Value, 0);
		}

		// Token: 0x0601622C RID: 90668 RVA: 0x0032CF1B File Offset: 0x0032B11B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601622D RID: 90669 RVA: 0x0032CF26 File Offset: 0x0032B126
		public static Offset<ITestSummary> EndITestSummary(FlatBufferBuilder builder)
		{
			return new Offset<ITestSummary>(builder.EndTable());
		}

		// Token: 0x0601622E RID: 90670 RVA: 0x0032CF34 File Offset: 0x0032B134
		public ITestSummaryT UnPack()
		{
			ITestSummaryT testSummaryT = new ITestSummaryT();
			this.UnPackTo(testSummaryT);
			return testSummaryT;
		}

		// Token: 0x0601622F RID: 90671 RVA: 0x0032CF50 File Offset: 0x0032B150
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

		// Token: 0x06016230 RID: 90672 RVA: 0x0032CFB4 File Offset: 0x0032B1B4
		public static Offset<ITestSummary> Pack(FlatBufferBuilder builder, ITestSummaryT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITestSummary>);
			}
			StringOffset errorMsgOffset = (_o.ErrorMsg == null) ? default(StringOffset) : builder.CreateString(_o.ErrorMsg);
			return ITestSummary.CreateITestSummary(builder, _o.Total, _o.Passed, _o.Failed, _o.IsRequiredCaseAllPassed, _o.Time, errorMsgOffset, _o.NullMask);
		}

		// Token: 0x0400BA38 RID: 47672
		private Table __p;
	}
}
