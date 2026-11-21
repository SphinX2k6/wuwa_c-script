using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200129D RID: 4765
	public struct TrapDefenseMonsterBody : IFlatbufferObject
	{
		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x0600F194 RID: 61844 RVA: 0x00364DD4 File Offset: 0x00362FD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F195 RID: 61845 RVA: 0x00364DE1 File Offset: 0x00362FE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F196 RID: 61846 RVA: 0x00364DE8 File Offset: 0x00362FE8
		public static TrapDefenseMonsterBody GetRootAsTrapDefenseMonsterBody(ByteBuffer _bb)
		{
			return TrapDefenseMonsterBody.GetRootAsTrapDefenseMonsterBody(_bb, default(TrapDefenseMonsterBody));
		}

		// Token: 0x0600F197 RID: 61847 RVA: 0x00364E04 File Offset: 0x00363004
		public static TrapDefenseMonsterBody GetRootAsTrapDefenseMonsterBody(ByteBuffer _bb, TrapDefenseMonsterBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F198 RID: 61848 RVA: 0x00364E21 File Offset: 0x00363021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F199 RID: 61849 RVA: 0x00364E30 File Offset: 0x00363030
		public TrapDefenseMonsterBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x0600F19A RID: 61850 RVA: 0x00364E40 File Offset: 0x00363040
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

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0600F19B RID: 61851 RVA: 0x00364E7C File Offset: 0x0036307C
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

		// Token: 0x0600F19C RID: 61852 RVA: 0x00364EB3 File Offset: 0x003630B3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F19D RID: 61853 RVA: 0x00364EC2 File Offset: 0x003630C2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F0 RID: 22768
		private Table __p;
	}
}
