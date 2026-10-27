using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE9 RID: 3817
	public struct PhantomGain : IFlatbufferObject
	{
		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600A8BD RID: 43197 RVA: 0x002B37E9 File Offset: 0x002B19E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x002B37F6 File Offset: 0x002B19F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x002B3800 File Offset: 0x002B1A00
		public static PhantomGain GetRootAsPhantomGain(ByteBuffer _bb)
		{
			return PhantomGain.GetRootAsPhantomGain(_bb, default(PhantomGain));
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x002B381C File Offset: 0x002B1A1C
		public static PhantomGain GetRootAsPhantomGain(ByteBuffer _bb, PhantomGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x002B3839 File Offset: 0x002B1A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x002B3848 File Offset: 0x002B1A48
		public PhantomGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x002B3858 File Offset: 0x002B1A58
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

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x002B3894 File Offset: 0x002B1A94
		public int MonsterInfoId
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

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x002B38D0 File Offset: 0x002B1AD0
		public int ActivityId
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

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x0600A8C6 RID: 43206 RVA: 0x002B390C File Offset: 0x002B1B0C
		public int UnLockReward
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

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x0600A8C7 RID: 43207 RVA: 0x002B394C File Offset: 0x002B1B4C
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x002B398C File Offset: 0x002B1B8C
		public string Name
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

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x002B39C4 File Offset: 0x002B1BC4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A8CA RID: 43210 RVA: 0x002B39D4 File Offset: 0x002B1BD4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x002B39EC File Offset: 0x002B1BEC
		public string TexPhantom
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

		// Token: 0x0600A8CC RID: 43212 RVA: 0x002B3A24 File Offset: 0x002B1C24
		public Span<byte> GetTexPhantomBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x002B3A34 File Offset: 0x002B1C34
		public byte[] GetTexPhantomArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FAB RID: 20395
		private Table __p;
	}
}
