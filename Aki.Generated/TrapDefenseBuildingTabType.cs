using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001293 RID: 4755
	public struct TrapDefenseBuildingTabType : IFlatbufferObject
	{
		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0600F08C RID: 61580 RVA: 0x00362A95 File Offset: 0x00360C95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F08D RID: 61581 RVA: 0x00362AA2 File Offset: 0x00360CA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F08E RID: 61582 RVA: 0x00362AAC File Offset: 0x00360CAC
		public static TrapDefenseBuildingTabType GetRootAsTrapDefenseBuildingTabType(ByteBuffer _bb)
		{
			return TrapDefenseBuildingTabType.GetRootAsTrapDefenseBuildingTabType(_bb, default(TrapDefenseBuildingTabType));
		}

		// Token: 0x0600F08F RID: 61583 RVA: 0x00362AC8 File Offset: 0x00360CC8
		public static TrapDefenseBuildingTabType GetRootAsTrapDefenseBuildingTabType(ByteBuffer _bb, TrapDefenseBuildingTabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F090 RID: 61584 RVA: 0x00362AE5 File Offset: 0x00360CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F091 RID: 61585 RVA: 0x00362AF4 File Offset: 0x00360CF4
		public TrapDefenseBuildingTabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0600F092 RID: 61586 RVA: 0x00362B04 File Offset: 0x00360D04
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

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0600F093 RID: 61587 RVA: 0x00362B40 File Offset: 0x00360D40
		public string Icon
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

		// Token: 0x0600F094 RID: 61588 RVA: 0x00362B77 File Offset: 0x00360D77
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F095 RID: 61589 RVA: 0x00362B86 File Offset: 0x00360D86
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0600F096 RID: 61590 RVA: 0x00362BA0 File Offset: 0x00360DA0
		public string TabName
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

		// Token: 0x0600F097 RID: 61591 RVA: 0x00362BD7 File Offset: 0x00360DD7
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F098 RID: 61592 RVA: 0x00362BE6 File Offset: 0x00360DE6
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x0600F099 RID: 61593 RVA: 0x00362C00 File Offset: 0x00360E00
		public string RedDot
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

		// Token: 0x0600F09A RID: 61594 RVA: 0x00362C38 File Offset: 0x00360E38
		public Span<byte> GetRedDotBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F09B RID: 61595 RVA: 0x00362C48 File Offset: 0x00360E48
		public byte[] GetRedDotArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058E5 RID: 22757
		private Table __p;
	}
}
