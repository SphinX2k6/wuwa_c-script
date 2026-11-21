using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB8 RID: 4024
	public struct PhantomBattleGym : IFlatbufferObject
	{
		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x002CD478 File Offset: 0x002CB678
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x002CD485 File Offset: 0x002CB685
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x002CD48C File Offset: 0x002CB68C
		public static PhantomBattleGym GetRootAsPhantomBattleGym(ByteBuffer _bb)
		{
			return PhantomBattleGym.GetRootAsPhantomBattleGym(_bb, default(PhantomBattleGym));
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x002CD4A8 File Offset: 0x002CB6A8
		public static PhantomBattleGym GetRootAsPhantomBattleGym(ByteBuffer _bb, PhantomBattleGym obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x002CD4C5 File Offset: 0x002CB6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x002CD4D4 File Offset: 0x002CB6D4
		public PhantomBattleGym __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x0600AD69 RID: 44393 RVA: 0x002CD4E4 File Offset: 0x002CB6E4
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

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600AD6A RID: 44394 RVA: 0x002CD520 File Offset: 0x002CB720
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

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600AD6B RID: 44395 RVA: 0x002CD55C File Offset: 0x002CB75C
		public int Level
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

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600AD6C RID: 44396 RVA: 0x002CD598 File Offset: 0x002CB798
		public string Name
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

		// Token: 0x0600AD6D RID: 44397 RVA: 0x002CD5D0 File Offset: 0x002CB7D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x002CD5E0 File Offset: 0x002CB7E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600AD6F RID: 44399 RVA: 0x002CD5F8 File Offset: 0x002CB7F8
		public bool IfRepeat
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600AD70 RID: 44400 RVA: 0x002CD638 File Offset: 0x002CB838
		public string TextureBg
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

		// Token: 0x0600AD71 RID: 44401 RVA: 0x002CD670 File Offset: 0x002CB870
		public Span<byte> GetTextureBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x002CD680 File Offset: 0x002CB880
		public byte[] GetTextureBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600AD73 RID: 44403 RVA: 0x002CD698 File Offset: 0x002CB898
		public string Icon
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

		// Token: 0x0600AD74 RID: 44404 RVA: 0x002CD6D0 File Offset: 0x002CB8D0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x002CD6E0 File Offset: 0x002CB8E0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600AD76 RID: 44406 RVA: 0x002CD6F8 File Offset: 0x002CB8F8
		public string IconLock
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

		// Token: 0x0600AD77 RID: 44407 RVA: 0x002CD730 File Offset: 0x002CB930
		public Span<byte> GetIconLockBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x002CD740 File Offset: 0x002CB940
		public byte[] GetIconLockArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600AD79 RID: 44409 RVA: 0x002CD758 File Offset: 0x002CB958
		public string IconBg
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

		// Token: 0x0600AD7A RID: 44410 RVA: 0x002CD790 File Offset: 0x002CB990
		public Span<byte> GetIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x002CD7A0 File Offset: 0x002CB9A0
		public byte[] GetIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x0600AD7C RID: 44412 RVA: 0x002CD7B8 File Offset: 0x002CB9B8
		public string IconRoman
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

		// Token: 0x0600AD7D RID: 44413 RVA: 0x002CD7F0 File Offset: 0x002CB9F0
		public Span<byte> GetIconRomanBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AD7E RID: 44414 RVA: 0x002CD800 File Offset: 0x002CBA00
		public byte[] GetIconRomanArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005576 RID: 21878
		private Table __p;
	}
}
