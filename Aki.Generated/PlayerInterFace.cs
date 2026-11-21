using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102B RID: 4139
	public struct PlayerInterFace : IFlatbufferObject
	{
		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600B7CE RID: 47054 RVA: 0x002E47B9 File Offset: 0x002E29B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x002E47C6 File Offset: 0x002E29C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x002E47D0 File Offset: 0x002E29D0
		public static PlayerInterFace GetRootAsPlayerInterFace(ByteBuffer _bb)
		{
			return PlayerInterFace.GetRootAsPlayerInterFace(_bb, default(PlayerInterFace));
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x002E47EC File Offset: 0x002E29EC
		public static PlayerInterFace GetRootAsPlayerInterFace(ByteBuffer _bb, PlayerInterFace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x002E4809 File Offset: 0x002E2A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x002E4818 File Offset: 0x002E2A18
		public PlayerInterFace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600B7D4 RID: 47060 RVA: 0x002E4828 File Offset: 0x002E2A28
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

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0600B7D5 RID: 47061 RVA: 0x002E4864 File Offset: 0x002E2A64
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

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x002E489B File Offset: 0x002E2A9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x002E48AA File Offset: 0x002E2AAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x002E48C4 File Offset: 0x002E2AC4
		public string MainName
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

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x002E48FB File Offset: 0x002E2AFB
		public Span<byte> GetMainNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x002E490A File Offset: 0x002E2B0A
		public byte[] GetMainNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040055F8 RID: 22008
		private Table __p;
	}
}
