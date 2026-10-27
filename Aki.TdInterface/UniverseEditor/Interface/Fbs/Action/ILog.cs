using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A35 RID: 27189
	public struct ILog : IFlatbufferObject
	{
		// Token: 0x1700C9A9 RID: 51625
		// (get) Token: 0x0602F950 RID: 194896 RVA: 0x0067A052 File Offset: 0x00678252
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F951 RID: 194897 RVA: 0x0067A05F File Offset: 0x0067825F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F952 RID: 194898 RVA: 0x0067A068 File Offset: 0x00678268
		public static ILog GetRootAsILog(ByteBuffer _bb)
		{
			return ILog.GetRootAsILog(_bb, default(ILog));
		}

		// Token: 0x0602F953 RID: 194899 RVA: 0x0067A084 File Offset: 0x00678284
		public static ILog GetRootAsILog(ByteBuffer _bb, ILog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F954 RID: 194900 RVA: 0x0067A0A1 File Offset: 0x006782A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F955 RID: 194901 RVA: 0x0067A0B0 File Offset: 0x006782B0
		public ILog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9AA RID: 51626
		// (get) Token: 0x0602F956 RID: 194902 RVA: 0x0067A0C0 File Offset: 0x006782C0
		public string Level
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

		// Token: 0x0602F957 RID: 194903 RVA: 0x0067A0F7 File Offset: 0x006782F7
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F958 RID: 194904 RVA: 0x0067A106 File Offset: 0x00678306
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C9AB RID: 51627
		// (get) Token: 0x0602F959 RID: 194905 RVA: 0x0067A114 File Offset: 0x00678314
		public string Content
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

		// Token: 0x0602F95A RID: 194906 RVA: 0x0067A14B File Offset: 0x0067834B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F95B RID: 194907 RVA: 0x0067A15A File Offset: 0x0067835A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F95C RID: 194908 RVA: 0x0067A168 File Offset: 0x00678368
		public static Offset<ILog> CreateILog(FlatBufferBuilder builder, StringOffset LevelOffset = default(StringOffset), StringOffset ContentOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILog.AddContent(builder, ContentOffset);
			ILog.AddLevel(builder, LevelOffset);
			return ILog.EndILog(builder);
		}

		// Token: 0x0602F95D RID: 194909 RVA: 0x0067A185 File Offset: 0x00678385
		public static void StartILog(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F95E RID: 194910 RVA: 0x0067A18E File Offset: 0x0067838E
		public static void AddLevel(FlatBufferBuilder builder, StringOffset levelOffset)
		{
			builder.AddOffset(0, levelOffset.Value, 0);
		}

		// Token: 0x0602F95F RID: 194911 RVA: 0x0067A19E File Offset: 0x0067839E
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x0602F960 RID: 194912 RVA: 0x0067A1AE File Offset: 0x006783AE
		public static Offset<ILog> EndILog(FlatBufferBuilder builder)
		{
			return new Offset<ILog>(builder.EndTable());
		}

		// Token: 0x0602F961 RID: 194913 RVA: 0x0067A1BC File Offset: 0x006783BC
		public ILogT UnPack()
		{
			ILogT logT = new ILogT();
			this.UnPackTo(logT);
			return logT;
		}

		// Token: 0x0602F962 RID: 194914 RVA: 0x0067A1D7 File Offset: 0x006783D7
		public void UnPackTo(ILogT _o)
		{
			_o.Level = this.Level;
			_o.Content = this.Content;
		}

		// Token: 0x0602F963 RID: 194915 RVA: 0x0067A1F4 File Offset: 0x006783F4
		public static Offset<ILog> Pack(FlatBufferBuilder builder, ILogT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILog>);
			}
			StringOffset levelOffset = (_o.Level == null) ? default(StringOffset) : builder.CreateString(_o.Level);
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			return ILog.CreateILog(builder, levelOffset, contentOffset);
		}

		// Token: 0x04011244 RID: 70212
		private Table __p;
	}
}
