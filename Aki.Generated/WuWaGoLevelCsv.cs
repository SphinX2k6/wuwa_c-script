using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A9 RID: 4521
	public struct WuWaGoLevelCsv : IFlatbufferObject
	{
		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0600E96A RID: 59754 RVA: 0x0034613A File Offset: 0x0034433A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x00346147 File Offset: 0x00344347
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x00346150 File Offset: 0x00344350
		public static WuWaGoLevelCsv GetRootAsWuWaGoLevelCsv(ByteBuffer _bb)
		{
			return WuWaGoLevelCsv.GetRootAsWuWaGoLevelCsv(_bb, default(WuWaGoLevelCsv));
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x0034616C File Offset: 0x0034436C
		public static WuWaGoLevelCsv GetRootAsWuWaGoLevelCsv(ByteBuffer _bb, WuWaGoLevelCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x00346189 File Offset: 0x00344389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x00346198 File Offset: 0x00344398
		public WuWaGoLevelCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0600E970 RID: 59760 RVA: 0x003461A8 File Offset: 0x003443A8
		public string Key
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

		// Token: 0x0600E971 RID: 59761 RVA: 0x003461DF File Offset: 0x003443DF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x003461EE File Offset: 0x003443EE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0600E973 RID: 59763 RVA: 0x00346208 File Offset: 0x00344408
		public string RoleList
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

		// Token: 0x0600E974 RID: 59764 RVA: 0x0034623F File Offset: 0x0034443F
		public Span<byte> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x0034624E File Offset: 0x0034444E
		public byte[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0600E976 RID: 59766 RVA: 0x00346268 File Offset: 0x00344468
		public string GridDatas
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

		// Token: 0x0600E977 RID: 59767 RVA: 0x0034629F File Offset: 0x0034449F
		public Span<byte> GetGridDatasBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E978 RID: 59768 RVA: 0x003462AE File Offset: 0x003444AE
		public byte[] GetGridDatasArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052F6 RID: 21238
		private Table __p;
	}
}
