using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003B72 RID: 15218
	public struct ITestReport : IFlatbufferObject
	{
		// Token: 0x17006839 RID: 26681
		// (get) Token: 0x06014D0B RID: 85259 RVA: 0x00305E27 File Offset: 0x00304027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014D0C RID: 85260 RVA: 0x00305E34 File Offset: 0x00304034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014D0D RID: 85261 RVA: 0x00305E3C File Offset: 0x0030403C
		public static ITestReport GetRootAsITestReport(ByteBuffer _bb)
		{
			return ITestReport.GetRootAsITestReport(_bb, default(ITestReport));
		}

		// Token: 0x06014D0E RID: 85262 RVA: 0x00305E58 File Offset: 0x00304058
		public static ITestReport GetRootAsITestReport(ByteBuffer _bb, ITestReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014D0F RID: 85263 RVA: 0x00305E75 File Offset: 0x00304075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014D10 RID: 85264 RVA: 0x00305E84 File Offset: 0x00304084
		public ITestReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700683A RID: 26682
		// (get) Token: 0x06014D11 RID: 85265 RVA: 0x00305E94 File Offset: 0x00304094
		public string Name
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

		// Token: 0x06014D12 RID: 85266 RVA: 0x00305ECB File Offset: 0x003040CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014D13 RID: 85267 RVA: 0x00305EDA File Offset: 0x003040DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700683B RID: 26683
		// (get) Token: 0x06014D14 RID: 85268 RVA: 0x00305EE8 File Offset: 0x003040E8
		public int RunTime
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

		// Token: 0x1700683C RID: 26684
		// (get) Token: 0x06014D15 RID: 85269 RVA: 0x00305F24 File Offset: 0x00304124
		public string File
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

		// Token: 0x06014D16 RID: 85270 RVA: 0x00305F5B File Offset: 0x0030415B
		public Span<byte> GetFileBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06014D17 RID: 85271 RVA: 0x00305F6A File Offset: 0x0030416A
		public byte[] GetFileArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700683D RID: 26685
		// (get) Token: 0x06014D18 RID: 85272 RVA: 0x00305F78 File Offset: 0x00304178
		public string Follower
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

		// Token: 0x06014D19 RID: 85273 RVA: 0x00305FB0 File Offset: 0x003041B0
		public Span<byte> GetFollowerBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06014D1A RID: 85274 RVA: 0x00305FC0 File Offset: 0x003041C0
		public byte[] GetFollowerArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700683E RID: 26686
		// (get) Token: 0x06014D1B RID: 85275 RVA: 0x00305FD0 File Offset: 0x003041D0
		public bool PackageNeedPass
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700683F RID: 26687
		// (get) Token: 0x06014D1C RID: 85276 RVA: 0x00306010 File Offset: 0x00304210
		public bool Resolving
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006840 RID: 26688
		// (get) Token: 0x06014D1D RID: 85277 RVA: 0x00306050 File Offset: 0x00304250
		public string ErrorMsg
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014D1E RID: 85278 RVA: 0x00306088 File Offset: 0x00304288
		public Span<byte> GetErrorMsgBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06014D1F RID: 85279 RVA: 0x00306098 File Offset: 0x00304298
		public byte[] GetErrorMsgArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x06014D20 RID: 85280 RVA: 0x003060A8 File Offset: 0x003042A8
		public ITestReport? SubReports(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new ITestReport?(default(ITestReport).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006841 RID: 26689
		// (get) Token: 0x06014D21 RID: 85281 RVA: 0x0030610C File Offset: 0x0030430C
		public int SubReportsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006842 RID: 26690
		// (get) Token: 0x06014D22 RID: 85282 RVA: 0x00306138 File Offset: 0x00304338
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014D23 RID: 85283 RVA: 0x00306178 File Offset: 0x00304378
		public static Offset<ITestReport> CreateITestReport(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), int RunTime = 0, StringOffset FileOffset = default(StringOffset), StringOffset FollowerOffset = default(StringOffset), bool PackageNeedPass = false, bool Resolving = false, StringOffset ErrorMsgOffset = default(StringOffset), VectorOffset SubReportsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITestReport.AddSubReports(builder, SubReportsOffset);
			ITestReport.AddErrorMsg(builder, ErrorMsgOffset);
			ITestReport.AddFollower(builder, FollowerOffset);
			ITestReport.AddFile(builder, FileOffset);
			ITestReport.AddRunTime(builder, RunTime);
			ITestReport.AddName(builder, NameOffset);
			ITestReport.AddNullMask(builder, NullMask);
			ITestReport.AddResolving(builder, Resolving);
			ITestReport.AddPackageNeedPass(builder, PackageNeedPass);
			return ITestReport.EndITestReport(builder);
		}

		// Token: 0x06014D24 RID: 85284 RVA: 0x003061D8 File Offset: 0x003043D8
		public static void StartITestReport(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06014D25 RID: 85285 RVA: 0x003061E2 File Offset: 0x003043E2
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06014D26 RID: 85286 RVA: 0x003061F2 File Offset: 0x003043F2
		public static void AddRunTime(FlatBufferBuilder builder, int runTime)
		{
			builder.AddInt(1, runTime, 0);
		}

		// Token: 0x06014D27 RID: 85287 RVA: 0x003061FD File Offset: 0x003043FD
		public static void AddFile(FlatBufferBuilder builder, StringOffset fileOffset)
		{
			builder.AddOffset(2, fileOffset.Value, 0);
		}

		// Token: 0x06014D28 RID: 85288 RVA: 0x0030620D File Offset: 0x0030440D
		public static void AddFollower(FlatBufferBuilder builder, StringOffset followerOffset)
		{
			builder.AddOffset(3, followerOffset.Value, 0);
		}

		// Token: 0x06014D29 RID: 85289 RVA: 0x0030621D File Offset: 0x0030441D
		public static void AddPackageNeedPass(FlatBufferBuilder builder, bool packageNeedPass)
		{
			builder.AddBool(4, packageNeedPass, false);
		}

		// Token: 0x06014D2A RID: 85290 RVA: 0x00306228 File Offset: 0x00304428
		public static void AddResolving(FlatBufferBuilder builder, bool resolving)
		{
			builder.AddBool(5, resolving, false);
		}

		// Token: 0x06014D2B RID: 85291 RVA: 0x00306233 File Offset: 0x00304433
		public static void AddErrorMsg(FlatBufferBuilder builder, StringOffset errorMsgOffset)
		{
			builder.AddOffset(6, errorMsgOffset.Value, 0);
		}

		// Token: 0x06014D2C RID: 85292 RVA: 0x00306243 File Offset: 0x00304443
		public static void AddSubReports(FlatBufferBuilder builder, VectorOffset subReportsOffset)
		{
			builder.AddOffset(7, subReportsOffset.Value, 0);
		}

		// Token: 0x06014D2D RID: 85293 RVA: 0x00306254 File Offset: 0x00304454
		public static VectorOffset CreateSubReportsVector(FlatBufferBuilder builder, Offset<ITestReport>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014D2E RID: 85294 RVA: 0x00306294 File Offset: 0x00304494
		public static VectorOffset CreateSubReportsVectorBlock(FlatBufferBuilder builder, Offset<ITestReport>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITestReport>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014D2F RID: 85295 RVA: 0x003062AE File Offset: 0x003044AE
		public static VectorOffset CreateSubReportsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITestReport>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITestReport>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014D30 RID: 85296 RVA: 0x003062CC File Offset: 0x003044CC
		public static VectorOffset CreateSubReportsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITestReport>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014D31 RID: 85297 RVA: 0x003062E5 File Offset: 0x003044E5
		public static void StartSubReportsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014D32 RID: 85298 RVA: 0x003062F0 File Offset: 0x003044F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06014D33 RID: 85299 RVA: 0x003062FB File Offset: 0x003044FB
		public static Offset<ITestReport> EndITestReport(FlatBufferBuilder builder)
		{
			return new Offset<ITestReport>(builder.EndTable());
		}

		// Token: 0x06014D34 RID: 85300 RVA: 0x00306308 File Offset: 0x00304508
		public ITestReportT UnPack()
		{
			ITestReportT testReportT = new ITestReportT();
			this.UnPackTo(testReportT);
			return testReportT;
		}

		// Token: 0x06014D35 RID: 85301 RVA: 0x00306324 File Offset: 0x00304524
		public void UnPackTo(ITestReportT _o)
		{
			_o.Name = this.Name;
			_o.RunTime = this.RunTime;
			_o.File = this.File;
			_o.Follower = this.Follower;
			_o.PackageNeedPass = this.PackageNeedPass;
			_o.Resolving = this.Resolving;
			_o.ErrorMsg = this.ErrorMsg;
			_o.SubReports = new List<ITestReportT>();
			for (int i = 0; i < this.SubReportsLength; i++)
			{
				_o.SubReports.Add((this.SubReports(i) != null) ? this.SubReports(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014D36 RID: 85302 RVA: 0x003063E4 File Offset: 0x003045E4
		public static Offset<ITestReport> Pack(FlatBufferBuilder builder, ITestReportT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITestReport>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset fileOffset = (_o.File == null) ? default(StringOffset) : builder.CreateString(_o.File);
			StringOffset followerOffset = (_o.Follower == null) ? default(StringOffset) : builder.CreateString(_o.Follower);
			StringOffset errorMsgOffset = (_o.ErrorMsg == null) ? default(StringOffset) : builder.CreateString(_o.ErrorMsg);
			VectorOffset subReportsOffset = default(VectorOffset);
			if (_o.SubReports != null)
			{
				Offset<ITestReport>[] array = new Offset<ITestReport>[_o.SubReports.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITestReport.Pack(builder, _o.SubReports[i]);
				}
				subReportsOffset = ITestReport.CreateSubReportsVector(builder, array);
			}
			return ITestReport.CreateITestReport(builder, nameOffset, _o.RunTime, fileOffset, followerOffset, _o.PackageNeedPass, _o.Resolving, errorMsgOffset, subReportsOffset, _o.NullMask);
		}

		// Token: 0x0400B0B1 RID: 45233
		private Table __p;
	}
}
