using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007619 RID: 30233
	public struct IWriteLetterConfig : IFlatbufferObject
	{
		// Token: 0x1700E598 RID: 58776
		// (get) Token: 0x06037112 RID: 225554 RVA: 0x007781AA File Offset: 0x007763AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037113 RID: 225555 RVA: 0x007781B7 File Offset: 0x007763B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037114 RID: 225556 RVA: 0x007781C0 File Offset: 0x007763C0
		public static IWriteLetterConfig GetRootAsIWriteLetterConfig(ByteBuffer _bb)
		{
			return IWriteLetterConfig.GetRootAsIWriteLetterConfig(_bb, default(IWriteLetterConfig));
		}

		// Token: 0x06037115 RID: 225557 RVA: 0x007781DC File Offset: 0x007763DC
		public static IWriteLetterConfig GetRootAsIWriteLetterConfig(ByteBuffer _bb, IWriteLetterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037116 RID: 225558 RVA: 0x007781F9 File Offset: 0x007763F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037117 RID: 225559 RVA: 0x00778208 File Offset: 0x00776408
		public IWriteLetterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E599 RID: 58777
		// (get) Token: 0x06037118 RID: 225560 RVA: 0x00778218 File Offset: 0x00776418
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

		// Token: 0x06037119 RID: 225561 RVA: 0x00778254 File Offset: 0x00776454
		public static Offset<IWriteLetterConfig> CreateIWriteLetterConfig(FlatBufferBuilder builder, int LetterId = 0)
		{
			builder.StartTable(1);
			IWriteLetterConfig.AddLetterId(builder, LetterId);
			return IWriteLetterConfig.EndIWriteLetterConfig(builder);
		}

		// Token: 0x0603711A RID: 225562 RVA: 0x0077826A File Offset: 0x0077646A
		public static void StartIWriteLetterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603711B RID: 225563 RVA: 0x00778273 File Offset: 0x00776473
		public static void AddLetterId(FlatBufferBuilder builder, int letterId)
		{
			builder.AddInt(0, letterId, 0);
		}

		// Token: 0x0603711C RID: 225564 RVA: 0x0077827E File Offset: 0x0077647E
		public static Offset<IWriteLetterConfig> EndIWriteLetterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWriteLetterConfig>(builder.EndTable());
		}

		// Token: 0x0603711D RID: 225565 RVA: 0x0077828C File Offset: 0x0077648C
		public IWriteLetterConfigT UnPack()
		{
			IWriteLetterConfigT writeLetterConfigT = new IWriteLetterConfigT();
			this.UnPackTo(writeLetterConfigT);
			return writeLetterConfigT;
		}

		// Token: 0x0603711E RID: 225566 RVA: 0x007782A7 File Offset: 0x007764A7
		public void UnPackTo(IWriteLetterConfigT _o)
		{
			_o.LetterId = this.LetterId;
		}

		// Token: 0x0603711F RID: 225567 RVA: 0x007782B8 File Offset: 0x007764B8
		public static Offset<IWriteLetterConfig> Pack(FlatBufferBuilder builder, IWriteLetterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWriteLetterConfig>);
			}
			return IWriteLetterConfig.CreateIWriteLetterConfig(builder, _o.LetterId);
		}

		// Token: 0x04012586 RID: 75142
		private Table __p;
	}
}
