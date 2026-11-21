using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119D RID: 4509
	public struct SheriffProgress : IFlatbufferObject
	{
		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x0032CAE0 File Offset: 0x0032ACE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8FB RID: 55547 RVA: 0x0032CAED File Offset: 0x0032ACED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8FC RID: 55548 RVA: 0x0032CAF4 File Offset: 0x0032ACF4
		public static SheriffProgress GetRootAsSheriffProgress(ByteBuffer _bb)
		{
			return SheriffProgress.GetRootAsSheriffProgress(_bb, default(SheriffProgress));
		}

		// Token: 0x0600D8FD RID: 55549 RVA: 0x0032CB10 File Offset: 0x0032AD10
		public static SheriffProgress GetRootAsSheriffProgress(ByteBuffer _bb, SheriffProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8FE RID: 55550 RVA: 0x0032CB2D File Offset: 0x0032AD2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8FF RID: 55551 RVA: 0x0032CB3C File Offset: 0x0032AD3C
		public SheriffProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600D900 RID: 55552 RVA: 0x0032CB4C File Offset: 0x0032AD4C
		public int Id
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

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600D901 RID: 55553 RVA: 0x0032CB88 File Offset: 0x0032AD88
		public int SheriffAnomalyId
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

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600D902 RID: 55554 RVA: 0x0032CBC4 File Offset: 0x0032ADC4
		public int ProgressType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600D903 RID: 55555 RVA: 0x0032CC00 File Offset: 0x0032AE00
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600D904 RID: 55556 RVA: 0x0032CC40 File Offset: 0x0032AE40
		public int GroupPriority
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

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600D905 RID: 55557 RVA: 0x0032CC80 File Offset: 0x0032AE80
		public string Title
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

		// Token: 0x0600D906 RID: 55558 RVA: 0x0032CCB8 File Offset: 0x0032AEB8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x0032CCC8 File Offset: 0x0032AEC8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600D908 RID: 55560 RVA: 0x0032CCE0 File Offset: 0x0032AEE0
		public string Context
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

		// Token: 0x0600D909 RID: 55561 RVA: 0x0032CD18 File Offset: 0x0032AF18
		public Span<byte> GetContextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D90A RID: 55562 RVA: 0x0032CD28 File Offset: 0x0032AF28
		public byte[] GetContextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600D90B RID: 55563 RVA: 0x0032CD40 File Offset: 0x0032AF40
		public int Percent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040057AF RID: 22447
		private Table __p;
	}
}
