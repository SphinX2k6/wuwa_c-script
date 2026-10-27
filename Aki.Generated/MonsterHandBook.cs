using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E15 RID: 3605
	public struct MonsterHandBook : IFlatbufferObject
	{
		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x060094F2 RID: 38130 RVA: 0x00287514 File Offset: 0x00285714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00287521 File Offset: 0x00285721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x00287528 File Offset: 0x00285728
		public static MonsterHandBook GetRootAsMonsterHandBook(ByteBuffer _bb)
		{
			return MonsterHandBook.GetRootAsMonsterHandBook(_bb, default(MonsterHandBook));
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x00287544 File Offset: 0x00285744
		public static MonsterHandBook GetRootAsMonsterHandBook(ByteBuffer _bb, MonsterHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x00287561 File Offset: 0x00285761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x00287570 File Offset: 0x00285770
		public MonsterHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x060094F8 RID: 38136 RVA: 0x00287580 File Offset: 0x00285780
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

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x002875BC File Offset: 0x002857BC
		public int MonsterId
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

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x060094FA RID: 38138 RVA: 0x002875F8 File Offset: 0x002857F8
		public int Type
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

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x060094FB RID: 38139 RVA: 0x00287634 File Offset: 0x00285834
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

		// Token: 0x060094FC RID: 38140 RVA: 0x0028766C File Offset: 0x0028586C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x0028767C File Offset: 0x0028587C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x060094FE RID: 38142 RVA: 0x00287694 File Offset: 0x00285894
		public int Classification
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 16;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x060094FF RID: 38143 RVA: 0x002876D4 File Offset: 0x002858D4
		public int MeshId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06009500 RID: 38144 RVA: 0x00287714 File Offset: 0x00285914
		public string Descrtption
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

		// Token: 0x06009501 RID: 38145 RVA: 0x0028774C File Offset: 0x0028594C
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x0028775C File Offset: 0x0028595C
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06009503 RID: 38147 RVA: 0x00287774 File Offset: 0x00285974
		public string HandBookBp
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

		// Token: 0x06009504 RID: 38148 RVA: 0x002877AC File Offset: 0x002859AC
		public Span<byte> GetHandBookBpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x002877BC File Offset: 0x002859BC
		public byte[] GetHandBookBpArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06009506 RID: 38150 RVA: 0x002877D4 File Offset: 0x002859D4
		public int MonsterBodyType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06009507 RID: 38151 RVA: 0x00287814 File Offset: 0x00285A14
		public string HandBookCamera
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

		// Token: 0x06009508 RID: 38152 RVA: 0x0028784C File Offset: 0x00285A4C
		public Span<byte> GetHandBookCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x0028785C File Offset: 0x00285A5C
		public byte[] GetHandBookCameraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x00287874 File Offset: 0x00285A74
		public int ResistanceElement(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x0600950B RID: 38155 RVA: 0x002878B4 File Offset: 0x00285AB4
		public int ResistanceElementLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x002878E0 File Offset: 0x00285AE0
		public Span<int> GetResistanceElementBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x002878F0 File Offset: 0x00285AF0
		public int[] GetResistanceElementArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x0600950E RID: 38158 RVA: 0x00287908 File Offset: 0x00285B08
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600950F RID: 38159 RVA: 0x00287948 File Offset: 0x00285B48
		public bool IsSkin
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06009510 RID: 38160 RVA: 0x00287988 File Offset: 0x00285B88
		public int OriginalFormInfoId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x002879C8 File Offset: 0x00285BC8
		public bool DefaultUnlock
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x00287A08 File Offset: 0x00285C08
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ResistanceElementIter()或GetResistanceElementBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ResistanceElement()
		{
			MonsterHandBook monsterHandBook = this;
			return monsterHandBook.GetResistanceElementArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x00287A2C File Offset: 0x00285C2C
		[NullableContext(1)]
		public readonly IEnumerable<int> ResistanceElementIter()
		{
			MonsterHandBook.<ResistanceElementIter>d__50 <ResistanceElementIter>d__ = new MonsterHandBook.<ResistanceElementIter>d__50(-2);
			<ResistanceElementIter>d__.<>3__<>4__this = this;
			return <ResistanceElementIter>d__;
		}

		// Token: 0x04004EBA RID: 20154
		private Table __p;
	}
}
