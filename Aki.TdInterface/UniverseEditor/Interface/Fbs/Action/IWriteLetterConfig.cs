using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E27 RID: 32295
	public struct IWriteLetterConfig : IFlatbufferObject
	{
		// Token: 0x1700F1D6 RID: 61910
		// (get) Token: 0x0603A5B7 RID: 239031 RVA: 0x007DC2A6 File Offset: 0x007DA4A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A5B8 RID: 239032 RVA: 0x007DC2B3 File Offset: 0x007DA4B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A5B9 RID: 239033 RVA: 0x007DC2BC File Offset: 0x007DA4BC
		public static IWriteLetterConfig GetRootAsIWriteLetterConfig(ByteBuffer _bb)
		{
			return IWriteLetterConfig.GetRootAsIWriteLetterConfig(_bb, default(IWriteLetterConfig));
		}

		// Token: 0x0603A5BA RID: 239034 RVA: 0x007DC2D8 File Offset: 0x007DA4D8
		public static IWriteLetterConfig GetRootAsIWriteLetterConfig(ByteBuffer _bb, IWriteLetterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A5BB RID: 239035 RVA: 0x007DC2F5 File Offset: 0x007DA4F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A5BC RID: 239036 RVA: 0x007DC304 File Offset: 0x007DA504
		public IWriteLetterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1D7 RID: 61911
		// (get) Token: 0x0603A5BD RID: 239037 RVA: 0x007DC314 File Offset: 0x007DA514
		public int LetterId
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

		// Token: 0x0603A5BE RID: 239038 RVA: 0x007DC350 File Offset: 0x007DA550
		public static Offset<IWriteLetterConfig> CreateIWriteLetterConfig(FlatBufferBuilder builder, int LetterId = 0)
		{
			builder.StartTable(1);
			IWriteLetterConfig.AddLetterId(builder, LetterId);
			return IWriteLetterConfig.EndIWriteLetterConfig(builder);
		}

		// Token: 0x0603A5BF RID: 239039 RVA: 0x007DC366 File Offset: 0x007DA566
		public static void StartIWriteLetterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A5C0 RID: 239040 RVA: 0x007DC36F File Offset: 0x007DA56F
		public static void AddLetterId(FlatBufferBuilder builder, int letterId)
		{
			builder.AddInt(0, letterId, 0);
		}

		// Token: 0x0603A5C1 RID: 239041 RVA: 0x007DC37A File Offset: 0x007DA57A
		public static Offset<IWriteLetterConfig> EndIWriteLetterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWriteLetterConfig>(builder.EndTable());
		}

		// Token: 0x0603A5C2 RID: 239042 RVA: 0x007DC388 File Offset: 0x007DA588
		public IWriteLetterConfigT UnPack()
		{
			IWriteLetterConfigT writeLetterConfigT = new IWriteLetterConfigT();
			this.UnPackTo(writeLetterConfigT);
			return writeLetterConfigT;
		}

		// Token: 0x0603A5C3 RID: 239043 RVA: 0x007DC3A3 File Offset: 0x007DA5A3
		public void UnPackTo(IWriteLetterConfigT _o)
		{
			_o.LetterId = this.LetterId;
		}

		// Token: 0x0603A5C4 RID: 239044 RVA: 0x007DC3B4 File Offset: 0x007DA5B4
		public static Offset<IWriteLetterConfig> Pack(FlatBufferBuilder builder, IWriteLetterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWriteLetterConfig>);
			}
			return IWriteLetterConfig.CreateIWriteLetterConfig(builder, _o.LetterId);
		}

		// Token: 0x040135D0 RID: 79312
		private Table __p;
	}
}
