using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA7 RID: 4007
	public struct PhantomBattleCardElement : IFlatbufferObject
	{
		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x0600AB9B RID: 43931 RVA: 0x002C9634 File Offset: 0x002C7834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB9C RID: 43932 RVA: 0x002C9641 File Offset: 0x002C7841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x002C9648 File Offset: 0x002C7848
		public static PhantomBattleCardElement GetRootAsPhantomBattleCardElement(ByteBuffer _bb)
		{
			return PhantomBattleCardElement.GetRootAsPhantomBattleCardElement(_bb, default(PhantomBattleCardElement));
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x002C9664 File Offset: 0x002C7864
		public static PhantomBattleCardElement GetRootAsPhantomBattleCardElement(ByteBuffer _bb, PhantomBattleCardElement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x002C9681 File Offset: 0x002C7881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x002C9690 File Offset: 0x002C7890
		public PhantomBattleCardElement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x002C96A0 File Offset: 0x002C78A0
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

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x002C96DC File Offset: 0x002C78DC
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

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x002C9713 File Offset: 0x002C7913
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x002C9722 File Offset: 0x002C7922
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x0600ABA5 RID: 43941 RVA: 0x002C973C File Offset: 0x002C793C
		public string TabIcon
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

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x002C9773 File Offset: 0x002C7973
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x002C9782 File Offset: 0x002C7982
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x0600ABA8 RID: 43944 RVA: 0x002C979C File Offset: 0x002C799C
		public string TabElementColor
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

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x002C97D4 File Offset: 0x002C79D4
		public Span<byte> GetTabElementColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x002C97E4 File Offset: 0x002C79E4
		public byte[] GetTabElementColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x002C97FC File Offset: 0x002C79FC
		public string CardElementIcon
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

		// Token: 0x0600ABAC RID: 43948 RVA: 0x002C9834 File Offset: 0x002C7A34
		public Span<byte> GetCardElementIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x002C9844 File Offset: 0x002C7A44
		public byte[] GetCardElementIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x0600ABAE RID: 43950 RVA: 0x002C985C File Offset: 0x002C7A5C
		public string DeleteFilterIcon
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

		// Token: 0x0600ABAF RID: 43951 RVA: 0x002C9894 File Offset: 0x002C7A94
		public Span<byte> GetDeleteFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x002C98A4 File Offset: 0x002C7AA4
		public byte[] GetDeleteFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x0600ABB1 RID: 43953 RVA: 0x002C98BC File Offset: 0x002C7ABC
		public string QuicklyBuildFilterIcon
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

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x002C98F4 File Offset: 0x002C7AF4
		public Span<byte> GetQuicklyBuildFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x002C9904 File Offset: 0x002C7B04
		public byte[] GetQuicklyBuildFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x0600ABB4 RID: 43956 RVA: 0x002C991C File Offset: 0x002C7B1C
		public string FieldActivateUi
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

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x002C9954 File Offset: 0x002C7B54
		public Span<byte> GetFieldActivateUiBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x002C9964 File Offset: 0x002C7B64
		public byte[] GetFieldActivateUiArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x0600ABB7 RID: 43959 RVA: 0x002C997C File Offset: 0x002C7B7C
		public string FieldActivateMaterial
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

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x002C99B4 File Offset: 0x002C7BB4
		public Span<byte> GetFieldActivateMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x002C99C4 File Offset: 0x002C7BC4
		public byte[] GetFieldActivateMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x0600ABBA RID: 43962 RVA: 0x002C99DC File Offset: 0x002C7BDC
		public string FieldElementNiagara
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

		// Token: 0x0600ABBB RID: 43963 RVA: 0x002C9A14 File Offset: 0x002C7C14
		public Span<byte> GetFieldElementNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x002C9A24 File Offset: 0x002C7C24
		public byte[] GetFieldElementNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x0600ABBD RID: 43965 RVA: 0x002C9A3C File Offset: 0x002C7C3C
		public string FieldActivateElementNiagara
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

		// Token: 0x0600ABBE RID: 43966 RVA: 0x002C9A74 File Offset: 0x002C7C74
		public Span<byte> GetFieldActivateElementNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x002C9A84 File Offset: 0x002C7C84
		public byte[] GetFieldActivateElementNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x0600ABC0 RID: 43968 RVA: 0x002C9A9C File Offset: 0x002C7C9C
		public string FieldCardElementInDeck
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

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x002C9AD4 File Offset: 0x002C7CD4
		public Span<byte> GetFieldCardElementInDeckBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x002C9AE4 File Offset: 0x002C7CE4
		public byte[] GetFieldCardElementInDeckArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x002C9AFC File Offset: 0x002C7CFC
		public string FieldAudio
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x002C9B34 File Offset: 0x002C7D34
		public Span<byte> GetFieldAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x002C9B44 File Offset: 0x002C7D44
		public byte[] GetFieldAudioArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x04005563 RID: 21859
		private Table __p;
	}
}
