using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001028 RID: 4136
	public struct PlatformIcon : IFlatbufferObject
	{
		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600B76C RID: 46956 RVA: 0x002E3B3C File Offset: 0x002E1D3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x002E3B49 File Offset: 0x002E1D49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x002E3B50 File Offset: 0x002E1D50
		public static PlatformIcon GetRootAsPlatformIcon(ByteBuffer _bb)
		{
			return PlatformIcon.GetRootAsPlatformIcon(_bb, default(PlatformIcon));
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x002E3B6C File Offset: 0x002E1D6C
		public static PlatformIcon GetRootAsPlatformIcon(ByteBuffer _bb, PlatformIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x002E3B89 File Offset: 0x002E1D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x002E3B98 File Offset: 0x002E1D98
		public PlatformIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x002E3BA8 File Offset: 0x002E1DA8
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

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0600B773 RID: 46963 RVA: 0x002E3BE4 File Offset: 0x002E1DE4
		public string IconName
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

		// Token: 0x0600B774 RID: 46964 RVA: 0x002E3C1B File Offset: 0x002E1E1B
		public Span<byte> GetIconNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x002E3C2A File Offset: 0x002E1E2A
		public byte[] GetIconNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0600B776 RID: 46966 RVA: 0x002E3C44 File Offset: 0x002E1E44
		public string IconPath
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

		// Token: 0x0600B777 RID: 46967 RVA: 0x002E3C7B File Offset: 0x002E1E7B
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x002E3C8A File Offset: 0x002E1E8A
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0600B779 RID: 46969 RVA: 0x002E3CA4 File Offset: 0x002E1EA4
		public string MobileIconPath
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

		// Token: 0x0600B77A RID: 46970 RVA: 0x002E3CDC File Offset: 0x002E1EDC
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x002E3CEC File Offset: 0x002E1EEC
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040055F5 RID: 22005
		private Table __p;
	}
}
