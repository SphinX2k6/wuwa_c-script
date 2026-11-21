using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200129F RID: 4767
	public struct TrapDefenseMonsterRisk : IFlatbufferObject
	{
		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0600F1A8 RID: 61864 RVA: 0x00364FE1 File Offset: 0x003631E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1A9 RID: 61865 RVA: 0x00364FEE File Offset: 0x003631EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1AA RID: 61866 RVA: 0x00364FF8 File Offset: 0x003631F8
		public static TrapDefenseMonsterRisk GetRootAsTrapDefenseMonsterRisk(ByteBuffer _bb)
		{
			return TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(_bb, default(TrapDefenseMonsterRisk));
		}

		// Token: 0x0600F1AB RID: 61867 RVA: 0x00365014 File Offset: 0x00363214
		public static TrapDefenseMonsterRisk GetRootAsTrapDefenseMonsterRisk(ByteBuffer _bb, TrapDefenseMonsterRisk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1AC RID: 61868 RVA: 0x00365031 File Offset: 0x00363231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1AD RID: 61869 RVA: 0x00365040 File Offset: 0x00363240
		public TrapDefenseMonsterRisk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x0600F1AE RID: 61870 RVA: 0x00365050 File Offset: 0x00363250
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

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x0600F1AF RID: 61871 RVA: 0x0036508C File Offset: 0x0036328C
		public string Name
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

		// Token: 0x0600F1B0 RID: 61872 RVA: 0x003650C3 File Offset: 0x003632C3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F1B1 RID: 61873 RVA: 0x003650D2 File Offset: 0x003632D2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x0600F1B2 RID: 61874 RVA: 0x003650EC File Offset: 0x003632EC
		public string GridQualityPath
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

		// Token: 0x0600F1B3 RID: 61875 RVA: 0x00365123 File Offset: 0x00363323
		public Span<byte> GetGridQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F1B4 RID: 61876 RVA: 0x00365132 File Offset: 0x00363332
		public byte[] GetGridQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x0600F1B5 RID: 61877 RVA: 0x0036514C File Offset: 0x0036334C
		public string DescQualityPath
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

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x00365184 File Offset: 0x00363384
		public Span<byte> GetDescQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F1B7 RID: 61879 RVA: 0x00365194 File Offset: 0x00363394
		public byte[] GetDescQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x0600F1B8 RID: 61880 RVA: 0x003651AC File Offset: 0x003633AC
		public string Icon
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

		// Token: 0x0600F1B9 RID: 61881 RVA: 0x003651E4 File Offset: 0x003633E4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F1BA RID: 61882 RVA: 0x003651F4 File Offset: 0x003633F4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F2 RID: 22770
		private Table __p;
	}
}
