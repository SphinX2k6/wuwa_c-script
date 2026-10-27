using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC0 RID: 3008
	public struct DangoBrawlEffect : IFlatbufferObject
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06005D73 RID: 23923 RVA: 0x00208FF5 File Offset: 0x002071F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x00209002 File Offset: 0x00207202
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x0020900C File Offset: 0x0020720C
		public static DangoBrawlEffect GetRootAsDangoBrawlEffect(ByteBuffer _bb)
		{
			return DangoBrawlEffect.GetRootAsDangoBrawlEffect(_bb, default(DangoBrawlEffect));
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x00209028 File Offset: 0x00207228
		public static DangoBrawlEffect GetRootAsDangoBrawlEffect(ByteBuffer _bb, DangoBrawlEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x00209045 File Offset: 0x00207245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x00209054 File Offset: 0x00207254
		public DangoBrawlEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06005D79 RID: 23929 RVA: 0x00209064 File Offset: 0x00207264
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

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06005D7A RID: 23930 RVA: 0x002090A0 File Offset: 0x002072A0
		public int ActionType
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

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06005D7B RID: 23931 RVA: 0x002090DC File Offset: 0x002072DC
		public int TriggerLimit
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

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06005D7C RID: 23932 RVA: 0x00209118 File Offset: 0x00207318
		public int ShowId
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

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06005D7D RID: 23933 RVA: 0x00209158 File Offset: 0x00207358
		public bool IsClient
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004BE9 RID: 19433
		private Table __p;
	}
}
