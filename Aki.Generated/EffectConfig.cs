using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C20 RID: 3104
	public struct EffectConfig : IFlatbufferObject
	{
		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x0021FFFD File Offset: 0x0021E1FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x0022000A File Offset: 0x0021E20A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x00220014 File Offset: 0x0021E214
		public static EffectConfig GetRootAsEffectConfig(ByteBuffer _bb)
		{
			return EffectConfig.GetRootAsEffectConfig(_bb, default(EffectConfig));
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x00220030 File Offset: 0x0021E230
		public static EffectConfig GetRootAsEffectConfig(ByteBuffer _bb, EffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x0022004D File Offset: 0x0021E24D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x0022005C File Offset: 0x0021E25C
		public EffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x0600678E RID: 26510 RVA: 0x0022006C File Offset: 0x0021E26C
		public string Id
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

		// Token: 0x0600678F RID: 26511 RVA: 0x002200A3 File Offset: 0x0021E2A3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x002200B2 File Offset: 0x0021E2B2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x002200CC File Offset: 0x0021E2CC
		public string Path
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

		// Token: 0x06006792 RID: 26514 RVA: 0x00220103 File Offset: 0x0021E303
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00220112 File Offset: 0x0021E312
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C60 RID: 19552
		private Table __p;
	}
}
