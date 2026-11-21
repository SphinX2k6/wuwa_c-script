using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA0 RID: 19616
	public struct ICommitLog : IFlatbufferObject
	{
		// Token: 0x17008AF5 RID: 35573
		// (get) Token: 0x0601E13A RID: 123194 RVA: 0x00436EFA File Offset: 0x004350FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E13B RID: 123195 RVA: 0x00436F07 File Offset: 0x00435107
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E13C RID: 123196 RVA: 0x00436F10 File Offset: 0x00435110
		public static ICommitLog GetRootAsICommitLog(ByteBuffer _bb)
		{
			return ICommitLog.GetRootAsICommitLog(_bb, default(ICommitLog));
		}

		// Token: 0x0601E13D RID: 123197 RVA: 0x00436F2C File Offset: 0x0043512C
		public static ICommitLog GetRootAsICommitLog(ByteBuffer _bb, ICommitLog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E13E RID: 123198 RVA: 0x00436F49 File Offset: 0x00435149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E13F RID: 123199 RVA: 0x00436F58 File Offset: 0x00435158
		public ICommitLog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AF6 RID: 35574
		// (get) Token: 0x0601E140 RID: 123200 RVA: 0x00436F68 File Offset: 0x00435168
		public string Date
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

		// Token: 0x0601E141 RID: 123201 RVA: 0x00436F9F File Offset: 0x0043519F
		public Span<byte> GetDateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E142 RID: 123202 RVA: 0x00436FAE File Offset: 0x004351AE
		public byte[] GetDateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008AF7 RID: 35575
		// (get) Token: 0x0601E143 RID: 123203 RVA: 0x00436FBC File Offset: 0x004351BC
		public string Log
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

		// Token: 0x0601E144 RID: 123204 RVA: 0x00436FF3 File Offset: 0x004351F3
		public Span<byte> GetLogBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E145 RID: 123205 RVA: 0x00437002 File Offset: 0x00435202
		public byte[] GetLogArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601E146 RID: 123206 RVA: 0x00437010 File Offset: 0x00435210
		public static Offset<ICommitLog> CreateICommitLog(FlatBufferBuilder builder, StringOffset DateOffset = default(StringOffset), StringOffset LogOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommitLog.AddLog(builder, LogOffset);
			ICommitLog.AddDate(builder, DateOffset);
			return ICommitLog.EndICommitLog(builder);
		}

		// Token: 0x0601E147 RID: 123207 RVA: 0x0043702D File Offset: 0x0043522D
		public static void StartICommitLog(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E148 RID: 123208 RVA: 0x00437036 File Offset: 0x00435236
		public static void AddDate(FlatBufferBuilder builder, StringOffset dateOffset)
		{
			builder.AddOffset(0, dateOffset.Value, 0);
		}

		// Token: 0x0601E149 RID: 123209 RVA: 0x00437046 File Offset: 0x00435246
		public static void AddLog(FlatBufferBuilder builder, StringOffset logOffset)
		{
			builder.AddOffset(1, logOffset.Value, 0);
		}

		// Token: 0x0601E14A RID: 123210 RVA: 0x00437056 File Offset: 0x00435256
		public static Offset<ICommitLog> EndICommitLog(FlatBufferBuilder builder)
		{
			return new Offset<ICommitLog>(builder.EndTable());
		}

		// Token: 0x0601E14B RID: 123211 RVA: 0x00437064 File Offset: 0x00435264
		public ICommitLogT UnPack()
		{
			ICommitLogT commitLogT = new ICommitLogT();
			this.UnPackTo(commitLogT);
			return commitLogT;
		}

		// Token: 0x0601E14C RID: 123212 RVA: 0x0043707F File Offset: 0x0043527F
		public void UnPackTo(ICommitLogT _o)
		{
			_o.Date = this.Date;
			_o.Log = this.Log;
		}

		// Token: 0x0601E14D RID: 123213 RVA: 0x0043709C File Offset: 0x0043529C
		public static Offset<ICommitLog> Pack(FlatBufferBuilder builder, ICommitLogT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommitLog>);
			}
			StringOffset dateOffset = (_o.Date == null) ? default(StringOffset) : builder.CreateString(_o.Date);
			StringOffset logOffset = (_o.Log == null) ? default(StringOffset) : builder.CreateString(_o.Log);
			return ICommitLog.CreateICommitLog(builder, dateOffset, logOffset);
		}

		// Token: 0x0400D79E RID: 55198
		private Table __p;
	}
}
