using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE2 RID: 3298
	public struct DrinksDialog : IFlatbufferObject
	{
		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x0600699C RID: 27036 RVA: 0x00236516 File Offset: 0x00234716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x00236523 File Offset: 0x00234723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x0023652C File Offset: 0x0023472C
		public static DrinksDialog GetRootAsDrinksDialog(ByteBuffer _bb)
		{
			return DrinksDialog.GetRootAsDrinksDialog(_bb, default(DrinksDialog));
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x00236548 File Offset: 0x00234748
		public static DrinksDialog GetRootAsDrinksDialog(ByteBuffer _bb, DrinksDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x00236565 File Offset: 0x00234765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x00236574 File Offset: 0x00234774
		public DrinksDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x00236584 File Offset: 0x00234784
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

		// Token: 0x060069A3 RID: 27043 RVA: 0x002365BB File Offset: 0x002347BB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x002365CA File Offset: 0x002347CA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x002365E4 File Offset: 0x002347E4
		public int RoleId
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

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x00236620 File Offset: 0x00234820
		public string Text
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

		// Token: 0x060069A7 RID: 27047 RVA: 0x00236657 File Offset: 0x00234857
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x00236666 File Offset: 0x00234866
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x00236680 File Offset: 0x00234880
		public string AudioEvent
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

		// Token: 0x060069AA RID: 27050 RVA: 0x002366B8 File Offset: 0x002348B8
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x002366C8 File Offset: 0x002348C8
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060069AC RID: 27052 RVA: 0x002366E0 File Offset: 0x002348E0
		public int Delay
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005217 RID: 21015
		private Table __p;
	}
}
