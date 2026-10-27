using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004838 RID: 18488
	public struct ICommitLog : IFlatbufferObject
	{
		// Token: 0x170084AA RID: 33962
		// (get) Token: 0x0601C93D RID: 117053 RVA: 0x0040A5AA File Offset: 0x004087AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C93E RID: 117054 RVA: 0x0040A5B7 File Offset: 0x004087B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C93F RID: 117055 RVA: 0x0040A5C0 File Offset: 0x004087C0
		public static ICommitLog GetRootAsICommitLog(ByteBuffer _bb)
		{
			return ICommitLog.GetRootAsICommitLog(_bb, default(ICommitLog));
		}

		// Token: 0x0601C940 RID: 117056 RVA: 0x0040A5DC File Offset: 0x004087DC
		public static ICommitLog GetRootAsICommitLog(ByteBuffer _bb, ICommitLog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C941 RID: 117057 RVA: 0x0040A5F9 File Offset: 0x004087F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C942 RID: 117058 RVA: 0x0040A608 File Offset: 0x00408808
		public ICommitLog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084AB RID: 33963
		// (get) Token: 0x0601C943 RID: 117059 RVA: 0x0040A618 File Offset: 0x00408818
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

		// Token: 0x0601C944 RID: 117060 RVA: 0x0040A64F File Offset: 0x0040884F
		public Span<byte> GetDateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C945 RID: 117061 RVA: 0x0040A65E File Offset: 0x0040885E
		public byte[] GetDateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170084AC RID: 33964
		// (get) Token: 0x0601C946 RID: 117062 RVA: 0x0040A66C File Offset: 0x0040886C
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

		// Token: 0x0601C947 RID: 117063 RVA: 0x0040A6A3 File Offset: 0x004088A3
		public Span<byte> GetLogBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C948 RID: 117064 RVA: 0x0040A6B2 File Offset: 0x004088B2
		public byte[] GetLogArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C949 RID: 117065 RVA: 0x0040A6C0 File Offset: 0x004088C0
		public static Offset<ICommitLog> CreateICommitLog(FlatBufferBuilder builder, StringOffset DateOffset = default(StringOffset), StringOffset LogOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommitLog.AddLog(builder, LogOffset);
			ICommitLog.AddDate(builder, DateOffset);
			return ICommitLog.EndICommitLog(builder);
		}

		// Token: 0x0601C94A RID: 117066 RVA: 0x0040A6DD File Offset: 0x004088DD
		public static void StartICommitLog(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C94B RID: 117067 RVA: 0x0040A6E6 File Offset: 0x004088E6
		public static void AddDate(FlatBufferBuilder builder, StringOffset dateOffset)
		{
			builder.AddOffset(0, dateOffset.Value, 0);
		}

		// Token: 0x0601C94C RID: 117068 RVA: 0x0040A6F6 File Offset: 0x004088F6
		public static void AddLog(FlatBufferBuilder builder, StringOffset logOffset)
		{
			builder.AddOffset(1, logOffset.Value, 0);
		}

		// Token: 0x0601C94D RID: 117069 RVA: 0x0040A706 File Offset: 0x00408906
		public static Offset<ICommitLog> EndICommitLog(FlatBufferBuilder builder)
		{
			return new Offset<ICommitLog>(builder.EndTable());
		}

		// Token: 0x0601C94E RID: 117070 RVA: 0x0040A714 File Offset: 0x00408914
		public ICommitLogT UnPack()
		{
			ICommitLogT commitLogT = new ICommitLogT();
			this.UnPackTo(commitLogT);
			return commitLogT;
		}

		// Token: 0x0601C94F RID: 117071 RVA: 0x0040A72F File Offset: 0x0040892F
		public void UnPackTo(ICommitLogT _o)
		{
			_o.Date = this.Date;
			_o.Log = this.Log;
		}

		// Token: 0x0601C950 RID: 117072 RVA: 0x0040A74C File Offset: 0x0040894C
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

		// Token: 0x0400CD63 RID: 52579
		private Table __p;
	}
}
