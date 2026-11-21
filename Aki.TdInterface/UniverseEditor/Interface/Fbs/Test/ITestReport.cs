using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003F7A RID: 16250
	public struct ITestReport : IFlatbufferObject
	{
		// Token: 0x17006DD8 RID: 28120
		// (get) Token: 0x060161D5 RID: 90581 RVA: 0x0032C3BF File Offset: 0x0032A5BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060161D6 RID: 90582 RVA: 0x0032C3CC File Offset: 0x0032A5CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060161D7 RID: 90583 RVA: 0x0032C3D4 File Offset: 0x0032A5D4
		public static ITestReport GetRootAsITestReport(ByteBuffer _bb)
		{
			return ITestReport.GetRootAsITestReport(_bb, default(ITestReport));
		}

		// Token: 0x060161D8 RID: 90584 RVA: 0x0032C3F0 File Offset: 0x0032A5F0
		public static ITestReport GetRootAsITestReport(ByteBuffer _bb, ITestReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060161D9 RID: 90585 RVA: 0x0032C40D File Offset: 0x0032A60D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060161DA RID: 90586 RVA: 0x0032C41C File Offset: 0x0032A61C
		public ITestReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DD9 RID: 28121
		// (get) Token: 0x060161DB RID: 90587 RVA: 0x0032C42C File Offset: 0x0032A62C
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

		// Token: 0x060161DC RID: 90588 RVA: 0x0032C463 File Offset: 0x0032A663
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060161DD RID: 90589 RVA: 0x0032C472 File Offset: 0x0032A672
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006DDA RID: 28122
		// (get) Token: 0x060161DE RID: 90590 RVA: 0x0032C480 File Offset: 0x0032A680
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

		// Token: 0x17006DDB RID: 28123
		// (get) Token: 0x060161DF RID: 90591 RVA: 0x0032C4BC File Offset: 0x0032A6BC
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

		// Token: 0x060161E0 RID: 90592 RVA: 0x0032C4F3 File Offset: 0x0032A6F3
		public Span<byte> GetFileBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060161E1 RID: 90593 RVA: 0x0032C502 File Offset: 0x0032A702
		public byte[] GetFileArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006DDC RID: 28124
		// (get) Token: 0x060161E2 RID: 90594 RVA: 0x0032C510 File Offset: 0x0032A710
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

		// Token: 0x060161E3 RID: 90595 RVA: 0x0032C548 File Offset: 0x0032A748
		public Span<byte> GetFollowerBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060161E4 RID: 90596 RVA: 0x0032C558 File Offset: 0x0032A758
		public byte[] GetFollowerArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17006DDD RID: 28125
		// (get) Token: 0x060161E5 RID: 90597 RVA: 0x0032C568 File Offset: 0x0032A768
		public bool PackageNeedPass
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006DDE RID: 28126
		// (get) Token: 0x060161E6 RID: 90598 RVA: 0x0032C5A8 File Offset: 0x0032A7A8
		public bool Resolving
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006DDF RID: 28127
		// (get) Token: 0x060161E7 RID: 90599 RVA: 0x0032C5E8 File Offset: 0x0032A7E8
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

		// Token: 0x060161E8 RID: 90600 RVA: 0x0032C620 File Offset: 0x0032A820
		public Span<byte> GetErrorMsgBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060161E9 RID: 90601 RVA: 0x0032C630 File Offset: 0x0032A830
		public byte[] GetErrorMsgArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x060161EA RID: 90602 RVA: 0x0032C640 File Offset: 0x0032A840
		public ITestReport? SubReports(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new ITestReport?(default(ITestReport).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006DE0 RID: 28128
		// (get) Token: 0x060161EB RID: 90603 RVA: 0x0032C6A4 File Offset: 0x0032A8A4
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

		// Token: 0x17006DE1 RID: 28129
		// (get) Token: 0x060161EC RID: 90604 RVA: 0x0032C6D0 File Offset: 0x0032A8D0
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

		// Token: 0x060161ED RID: 90605 RVA: 0x0032C710 File Offset: 0x0032A910
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

		// Token: 0x060161EE RID: 90606 RVA: 0x0032C770 File Offset: 0x0032A970
		public static void StartITestReport(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060161EF RID: 90607 RVA: 0x0032C77A File Offset: 0x0032A97A
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x060161F0 RID: 90608 RVA: 0x0032C78A File Offset: 0x0032A98A
		public static void AddRunTime(FlatBufferBuilder builder, int runTime)
		{
			builder.AddInt(1, runTime, 0);
		}

		// Token: 0x060161F1 RID: 90609 RVA: 0x0032C795 File Offset: 0x0032A995
		public static void AddFile(FlatBufferBuilder builder, StringOffset fileOffset)
		{
			builder.AddOffset(2, fileOffset.Value, 0);
		}

		// Token: 0x060161F2 RID: 90610 RVA: 0x0032C7A5 File Offset: 0x0032A9A5
		public static void AddFollower(FlatBufferBuilder builder, StringOffset followerOffset)
		{
			builder.AddOffset(3, followerOffset.Value, 0);
		}

		// Token: 0x060161F3 RID: 90611 RVA: 0x0032C7B5 File Offset: 0x0032A9B5
		public static void AddPackageNeedPass(FlatBufferBuilder builder, bool packageNeedPass)
		{
			builder.AddBool(4, packageNeedPass, false);
		}

		// Token: 0x060161F4 RID: 90612 RVA: 0x0032C7C0 File Offset: 0x0032A9C0
		public static void AddResolving(FlatBufferBuilder builder, bool resolving)
		{
			builder.AddBool(5, resolving, false);
		}

		// Token: 0x060161F5 RID: 90613 RVA: 0x0032C7CB File Offset: 0x0032A9CB
		public static void AddErrorMsg(FlatBufferBuilder builder, StringOffset errorMsgOffset)
		{
			builder.AddOffset(6, errorMsgOffset.Value, 0);
		}

		// Token: 0x060161F6 RID: 90614 RVA: 0x0032C7DB File Offset: 0x0032A9DB
		public static void AddSubReports(FlatBufferBuilder builder, VectorOffset subReportsOffset)
		{
			builder.AddOffset(7, subReportsOffset.Value, 0);
		}

		// Token: 0x060161F7 RID: 90615 RVA: 0x0032C7EC File Offset: 0x0032A9EC
		public static VectorOffset CreateSubReportsVector(FlatBufferBuilder builder, Offset<ITestReport>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060161F8 RID: 90616 RVA: 0x0032C82C File Offset: 0x0032AA2C
		public static VectorOffset CreateSubReportsVectorBlock(FlatBufferBuilder builder, Offset<ITestReport>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITestReport>>(data);
			return builder.EndVector();
		}

		// Token: 0x060161F9 RID: 90617 RVA: 0x0032C846 File Offset: 0x0032AA46
		public static VectorOffset CreateSubReportsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITestReport>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITestReport>>(data);
			return builder.EndVector();
		}

		// Token: 0x060161FA RID: 90618 RVA: 0x0032C864 File Offset: 0x0032AA64
		public static VectorOffset CreateSubReportsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITestReport>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060161FB RID: 90619 RVA: 0x0032C87D File Offset: 0x0032AA7D
		public static void StartSubReportsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060161FC RID: 90620 RVA: 0x0032C888 File Offset: 0x0032AA88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060161FD RID: 90621 RVA: 0x0032C893 File Offset: 0x0032AA93
		public static Offset<ITestReport> EndITestReport(FlatBufferBuilder builder)
		{
			return new Offset<ITestReport>(builder.EndTable());
		}

		// Token: 0x060161FE RID: 90622 RVA: 0x0032C8A0 File Offset: 0x0032AAA0
		public ITestReportT UnPack()
		{
			ITestReportT testReportT = new ITestReportT();
			this.UnPackTo(testReportT);
			return testReportT;
		}

		// Token: 0x060161FF RID: 90623 RVA: 0x0032C8BC File Offset: 0x0032AABC
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

		// Token: 0x06016200 RID: 90624 RVA: 0x0032C97C File Offset: 0x0032AB7C
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

		// Token: 0x0400BA2E RID: 47662
		private Table __p;
	}
}
