using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F46 RID: 3910
	public struct PlayerInterFace : IFlatbufferObject
	{
		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600B1AD RID: 45485 RVA: 0x002C7F51 File Offset: 0x002C6151
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x002C7F5E File Offset: 0x002C615E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x002C7F68 File Offset: 0x002C6168
		public static PlayerInterFace GetRootAsPlayerInterFace(ByteBuffer _bb)
		{
			return PlayerInterFace.GetRootAsPlayerInterFace(_bb, default(PlayerInterFace));
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x002C7F84 File Offset: 0x002C6184
		public static PlayerInterFace GetRootAsPlayerInterFace(ByteBuffer _bb, PlayerInterFace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x002C7FA1 File Offset: 0x002C61A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x002C7FB0 File Offset: 0x002C61B0
		public PlayerInterFace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600B1B3 RID: 45491 RVA: 0x002C7FC0 File Offset: 0x002C61C0
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

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0600B1B4 RID: 45492 RVA: 0x002C7FFC File Offset: 0x002C61FC
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

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x002C8033 File Offset: 0x002C6233
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x002C8042 File Offset: 0x002C6242
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0600B1B7 RID: 45495 RVA: 0x002C805C File Offset: 0x002C625C
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

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x002C8093 File Offset: 0x002C6293
		public Span<byte> GetMainNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x002C80A2 File Offset: 0x002C62A2
		public byte[] GetMainNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005013 RID: 20499
		private Table __p;
	}
}
