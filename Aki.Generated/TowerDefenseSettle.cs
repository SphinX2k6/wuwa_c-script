using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113F RID: 4415
	public struct TowerDefenseSettle : IFlatbufferObject
	{
		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600E032 RID: 57394 RVA: 0x00330ED1 File Offset: 0x0032F0D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E033 RID: 57395 RVA: 0x00330EDE File Offset: 0x0032F0DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E034 RID: 57396 RVA: 0x00330EE8 File Offset: 0x0032F0E8
		public static TowerDefenseSettle GetRootAsTowerDefenseSettle(ByteBuffer _bb)
		{
			return TowerDefenseSettle.GetRootAsTowerDefenseSettle(_bb, default(TowerDefenseSettle));
		}

		// Token: 0x0600E035 RID: 57397 RVA: 0x00330F04 File Offset: 0x0032F104
		public static TowerDefenseSettle GetRootAsTowerDefenseSettle(ByteBuffer _bb, TowerDefenseSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E036 RID: 57398 RVA: 0x00330F21 File Offset: 0x0032F121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E037 RID: 57399 RVA: 0x00330F30 File Offset: 0x0032F130
		public TowerDefenseSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600E038 RID: 57400 RVA: 0x00330F40 File Offset: 0x0032F140
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

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600E039 RID: 57401 RVA: 0x00330F7C File Offset: 0x0032F17C
		public bool IsTotalRatio
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0600E03A RID: 57402 RVA: 0x00330FBC File Offset: 0x0032F1BC
		public string BaseTitle
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

		// Token: 0x0600E03B RID: 57403 RVA: 0x00330FF3 File Offset: 0x0032F1F3
		public Span<byte> GetBaseTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E03C RID: 57404 RVA: 0x00331002 File Offset: 0x0032F202
		public byte[] GetBaseTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0600E03D RID: 57405 RVA: 0x0033101C File Offset: 0x0032F21C
		public string Title
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

		// Token: 0x0600E03E RID: 57406 RVA: 0x00331054 File Offset: 0x0032F254
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x00331064 File Offset: 0x0032F264
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005280 RID: 21120
		private Table __p;
	}
}
