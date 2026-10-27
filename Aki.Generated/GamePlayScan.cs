using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CED RID: 3309
	public struct GamePlayScan : IFlatbufferObject
	{
		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06007954 RID: 31060 RVA: 0x00248A0D File Offset: 0x00246C0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x00248A1A File Offset: 0x00246C1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x00248A24 File Offset: 0x00246C24
		public static GamePlayScan GetRootAsGamePlayScan(ByteBuffer _bb)
		{
			return GamePlayScan.GetRootAsGamePlayScan(_bb, default(GamePlayScan));
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00248A40 File Offset: 0x00246C40
		public static GamePlayScan GetRootAsGamePlayScan(ByteBuffer _bb, GamePlayScan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00248A5D File Offset: 0x00246C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00248A6C File Offset: 0x00246C6C
		public GamePlayScan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x0600795A RID: 31066 RVA: 0x00248A7C File Offset: 0x00246C7C
		public int UId
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

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x0600795B RID: 31067 RVA: 0x00248AB8 File Offset: 0x00246CB8
		public string IconPath
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

		// Token: 0x0600795C RID: 31068 RVA: 0x00248AEF File Offset: 0x00246CEF
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x00248AFE File Offset: 0x00246CFE
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x0600795E RID: 31070 RVA: 0x00248B18 File Offset: 0x00246D18
		public float Interval
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600795F RID: 31071 RVA: 0x00248B58 File Offset: 0x00246D58
		public Vector? Offset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06007960 RID: 31072 RVA: 0x00248BB8 File Offset: 0x00246DB8
		public string ResourcePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x00248BF0 File Offset: 0x00246DF0
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x00248C00 File Offset: 0x00246E00
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06007963 RID: 31075 RVA: 0x00248C18 File Offset: 0x00246E18
		public int Color
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D5E RID: 19806
		private Table __p;
	}
}
