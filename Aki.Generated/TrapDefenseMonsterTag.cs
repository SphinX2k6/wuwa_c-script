using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A0 RID: 4768
	public struct TrapDefenseMonsterTag : IFlatbufferObject
	{
		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x0600F1BB RID: 61883 RVA: 0x0036520C File Offset: 0x0036340C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1BC RID: 61884 RVA: 0x00365219 File Offset: 0x00363419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1BD RID: 61885 RVA: 0x00365220 File Offset: 0x00363420
		public static TrapDefenseMonsterTag GetRootAsTrapDefenseMonsterTag(ByteBuffer _bb)
		{
			return TrapDefenseMonsterTag.GetRootAsTrapDefenseMonsterTag(_bb, default(TrapDefenseMonsterTag));
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x0036523C File Offset: 0x0036343C
		public static TrapDefenseMonsterTag GetRootAsTrapDefenseMonsterTag(ByteBuffer _bb, TrapDefenseMonsterTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x00365259 File Offset: 0x00363459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x00365268 File Offset: 0x00363468
		public TrapDefenseMonsterTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0600F1C1 RID: 61889 RVA: 0x00365278 File Offset: 0x00363478
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

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0600F1C2 RID: 61890 RVA: 0x003652B4 File Offset: 0x003634B4
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

		// Token: 0x0600F1C3 RID: 61891 RVA: 0x003652EB File Offset: 0x003634EB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x003652FA File Offset: 0x003634FA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0600F1C5 RID: 61893 RVA: 0x00365314 File Offset: 0x00363514
		public string Name
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

		// Token: 0x0600F1C6 RID: 61894 RVA: 0x0036534B File Offset: 0x0036354B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F1C7 RID: 61895 RVA: 0x0036535A File Offset: 0x0036355A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F3 RID: 22771
		private Table __p;
	}
}
