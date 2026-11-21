using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103A RID: 4154
	public struct PreheatQuestText : IFlatbufferObject
	{
		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x002E6BF0 File Offset: 0x002E4DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x002E6BFD File Offset: 0x002E4DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x002E6C04 File Offset: 0x002E4E04
		public static PreheatQuestText GetRootAsPreheatQuestText(ByteBuffer _bb)
		{
			return PreheatQuestText.GetRootAsPreheatQuestText(_bb, default(PreheatQuestText));
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x002E6C20 File Offset: 0x002E4E20
		public static PreheatQuestText GetRootAsPreheatQuestText(ByteBuffer _bb, PreheatQuestText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x002E6C3D File Offset: 0x002E4E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x002E6C4C File Offset: 0x002E4E4C
		public PreheatQuestText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x002E6C5C File Offset: 0x002E4E5C
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

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0600B8FB RID: 47355 RVA: 0x002E6C98 File Offset: 0x002E4E98
		public string MainTexPath
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

		// Token: 0x0600B8FC RID: 47356 RVA: 0x002E6CCF File Offset: 0x002E4ECF
		public Span<byte> GetMainTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B8FD RID: 47357 RVA: 0x002E6CDE File Offset: 0x002E4EDE
		public byte[] GetMainTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x002E6CF8 File Offset: 0x002E4EF8
		public int CrestIndex
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

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x002E6D34 File Offset: 0x002E4F34
		public string ThemeBefore
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

		// Token: 0x0600B900 RID: 47360 RVA: 0x002E6D6C File Offset: 0x002E4F6C
		public Span<byte> GetThemeBeforeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x002E6D7C File Offset: 0x002E4F7C
		public byte[] GetThemeBeforeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x002E6D94 File Offset: 0x002E4F94
		public string ThemeAfter
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

		// Token: 0x0600B903 RID: 47363 RVA: 0x002E6DCC File Offset: 0x002E4FCC
		public Span<byte> GetThemeAfterBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x002E6DDC File Offset: 0x002E4FDC
		public byte[] GetThemeAfterArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600B905 RID: 47365 RVA: 0x002E6DF4 File Offset: 0x002E4FF4
		public string QuestContent
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

		// Token: 0x0600B906 RID: 47366 RVA: 0x002E6E2C File Offset: 0x002E502C
		public Span<byte> GetQuestContentBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x002E6E3C File Offset: 0x002E503C
		public byte[] GetQuestContentArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600B908 RID: 47368 RVA: 0x002E6E54 File Offset: 0x002E5054
		public string DisplayTex
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

		// Token: 0x0600B909 RID: 47369 RVA: 0x002E6E8C File Offset: 0x002E508C
		public Span<byte> GetDisplayTexBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x002E6E9C File Offset: 0x002E509C
		public byte[] GetDisplayTexArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600B90B RID: 47371 RVA: 0x002E6EB4 File Offset: 0x002E50B4
		public string ShareTex
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

		// Token: 0x0600B90C RID: 47372 RVA: 0x002E6EEC File Offset: 0x002E50EC
		public Span<byte> GetShareTexBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x002E6EFC File Offset: 0x002E50FC
		public byte[] GetShareTexArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005607 RID: 22023
		private Table __p;
	}
}
