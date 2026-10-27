using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104F RID: 4175
	public struct RoleInfluence : IFlatbufferObject
	{
		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600C8B8 RID: 51384 RVA: 0x002FAA99 File Offset: 0x002F8C99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x002FAAA6 File Offset: 0x002F8CA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C8BA RID: 51386 RVA: 0x002FAAB0 File Offset: 0x002F8CB0
		public static RoleInfluence GetRootAsRoleInfluence(ByteBuffer _bb)
		{
			return RoleInfluence.GetRootAsRoleInfluence(_bb, default(RoleInfluence));
		}

		// Token: 0x0600C8BB RID: 51387 RVA: 0x002FAACC File Offset: 0x002F8CCC
		public static RoleInfluence GetRootAsRoleInfluence(ByteBuffer _bb, RoleInfluence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C8BC RID: 51388 RVA: 0x002FAAE9 File Offset: 0x002F8CE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x002FAAF8 File Offset: 0x002F8CF8
		public RoleInfluence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600C8BE RID: 51390 RVA: 0x002FAB08 File Offset: 0x002F8D08
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

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600C8BF RID: 51391 RVA: 0x002FAB44 File Offset: 0x002F8D44
		public string Title
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

		// Token: 0x0600C8C0 RID: 51392 RVA: 0x002FAB7B File Offset: 0x002F8D7B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C8C1 RID: 51393 RVA: 0x002FAB8A File Offset: 0x002F8D8A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600C8C2 RID: 51394 RVA: 0x002FABA4 File Offset: 0x002F8DA4
		public string BackGround
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

		// Token: 0x0600C8C3 RID: 51395 RVA: 0x002FABDB File Offset: 0x002F8DDB
		public Span<byte> GetBackGroundBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x002FABEA File Offset: 0x002F8DEA
		public byte[] GetBackGroundArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600C8C5 RID: 51397 RVA: 0x002FAC04 File Offset: 0x002F8E04
		public int InfluenceId
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

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600C8C6 RID: 51398 RVA: 0x002FAC44 File Offset: 0x002F8E44
		public int CountryId
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

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600C8C7 RID: 51399 RVA: 0x002FAC84 File Offset: 0x002F8E84
		public string FilterIcon
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

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x002FACBC File Offset: 0x002F8EBC
		public Span<byte> GetFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x002FACCC File Offset: 0x002F8ECC
		public byte[] GetFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600C8CA RID: 51402 RVA: 0x002FACE4 File Offset: 0x002F8EE4
		public IntArray? Role
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IntArray?(default(IntArray).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0400514D RID: 20813
		private Table __p;
	}
}
