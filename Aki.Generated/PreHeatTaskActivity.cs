using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103C RID: 4156
	public struct PreHeatTaskActivity : IFlatbufferObject
	{
		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x002E70B1 File Offset: 0x002E52B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x002E70BE File Offset: 0x002E52BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x002E70C8 File Offset: 0x002E52C8
		public static PreHeatTaskActivity GetRootAsPreHeatTaskActivity(ByteBuffer _bb)
		{
			return PreHeatTaskActivity.GetRootAsPreHeatTaskActivity(_bb, default(PreHeatTaskActivity));
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x002E70E4 File Offset: 0x002E52E4
		public static PreHeatTaskActivity GetRootAsPreHeatTaskActivity(ByteBuffer _bb, PreHeatTaskActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x002E7101 File Offset: 0x002E5301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x002E7110 File Offset: 0x002E5310
		public PreHeatTaskActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600B91F RID: 47391 RVA: 0x002E7120 File Offset: 0x002E5320
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

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0600B920 RID: 47392 RVA: 0x002E715C File Offset: 0x002E535C
		public int ActivityId
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

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x002E7198 File Offset: 0x002E5398
		public int QuestId
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

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600B922 RID: 47394 RVA: 0x002E71D4 File Offset: 0x002E53D4
		public int OpenDay
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

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600B923 RID: 47395 RVA: 0x002E7214 File Offset: 0x002E5414
		public string ItemIconPath
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

		// Token: 0x0600B924 RID: 47396 RVA: 0x002E724C File Offset: 0x002E544C
		public Span<byte> GetItemIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x002E725C File Offset: 0x002E545C
		public byte[] GetItemIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600B926 RID: 47398 RVA: 0x002E7274 File Offset: 0x002E5474
		public string ShadowItemIconPath
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

		// Token: 0x0600B927 RID: 47399 RVA: 0x002E72AC File Offset: 0x002E54AC
		public Span<byte> GetShadowItemIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x002E72BC File Offset: 0x002E54BC
		public byte[] GetShadowItemIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600B929 RID: 47401 RVA: 0x002E72D4 File Offset: 0x002E54D4
		public string IconPath
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

		// Token: 0x0600B92A RID: 47402 RVA: 0x002E730C File Offset: 0x002E550C
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x002E731C File Offset: 0x002E551C
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600B92C RID: 47404 RVA: 0x002E7334 File Offset: 0x002E5534
		public string ShadowIconPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x002E736C File Offset: 0x002E556C
		public Span<byte> GetShadowIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x002E737C File Offset: 0x002E557C
		public byte[] GetShadowIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600B92F RID: 47407 RVA: 0x002E7394 File Offset: 0x002E5594
		public string Title
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x002E73CC File Offset: 0x002E55CC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x002E73DC File Offset: 0x002E55DC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x002E73F4 File Offset: 0x002E55F4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x002E742C File Offset: 0x002E562C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x002E743C File Offset: 0x002E563C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0600B935 RID: 47413 RVA: 0x002E7454 File Offset: 0x002E5654
		public string BgPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x002E748C File Offset: 0x002E568C
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x002E749C File Offset: 0x002E569C
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0600B938 RID: 47416 RVA: 0x002E74B4 File Offset: 0x002E56B4
		public string ParsingMatPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x002E74EC File Offset: 0x002E56EC
		public Span<byte> GetParsingMatPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x002E74FC File Offset: 0x002E56FC
		public byte[] GetParsingMatPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04005609 RID: 22025
		private Table __p;
	}
}
