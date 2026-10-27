using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB0 RID: 3248
	public struct FloroRanchSkill : IFlatbufferObject
	{
		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060073C3 RID: 29635 RVA: 0x0023BF31 File Offset: 0x0023A131
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x0023BF3E File Offset: 0x0023A13E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x0023BF48 File Offset: 0x0023A148
		public static FloroRanchSkill GetRootAsFloroRanchSkill(ByteBuffer _bb)
		{
			return FloroRanchSkill.GetRootAsFloroRanchSkill(_bb, default(FloroRanchSkill));
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x0023BF64 File Offset: 0x0023A164
		public static FloroRanchSkill GetRootAsFloroRanchSkill(ByteBuffer _bb, FloroRanchSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x0023BF81 File Offset: 0x0023A181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x0023BF90 File Offset: 0x0023A190
		public FloroRanchSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060073C9 RID: 29641 RVA: 0x0023BFA0 File Offset: 0x0023A1A0
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

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x060073CA RID: 29642 RVA: 0x0023BFDC File Offset: 0x0023A1DC
		public int Condition
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

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x060073CB RID: 29643 RVA: 0x0023C018 File Offset: 0x0023A218
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

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x060073CC RID: 29644 RVA: 0x0023C054 File Offset: 0x0023A254
		public int Mode
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

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x060073CD RID: 29645 RVA: 0x0023C094 File Offset: 0x0023A294
		public int UseNum
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

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x0023C0D4 File Offset: 0x0023A2D4
		public int SkillType
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

		// Token: 0x060073CF RID: 29647 RVA: 0x0023C114 File Offset: 0x0023A314
		public DicStringString? Param(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x060073D0 RID: 29648 RVA: 0x0023C178 File Offset: 0x0023A378
		public int ParamLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x060073D1 RID: 29649 RVA: 0x0023C1A4 File Offset: 0x0023A3A4
		public string Name
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

		// Token: 0x060073D2 RID: 29650 RVA: 0x0023C1DC File Offset: 0x0023A3DC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x0023C1EC File Offset: 0x0023A3EC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x060073D4 RID: 29652 RVA: 0x0023C204 File Offset: 0x0023A404
		public string Desc
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

		// Token: 0x060073D5 RID: 29653 RVA: 0x0023C23C File Offset: 0x0023A43C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x0023C24C File Offset: 0x0023A44C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x0023C264 File Offset: 0x0023A464
		public string Icon
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

		// Token: 0x060073D8 RID: 29656 RVA: 0x0023C29C File Offset: 0x0023A49C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x0023C2AC File Offset: 0x0023A4AC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x0023C2C4 File Offset: 0x0023A4C4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ParamFrozenDict()缓存字典，遍历请使用ParamIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param()
		{
			return this.ParamIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x0023C31A File Offset: 0x0023A51A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> ParamIter()
		{
			FloroRanchSkill.<ParamIter>d__36 <ParamIter>d__ = new FloroRanchSkill.<ParamIter>d__36(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x0023C330 File Offset: 0x0023A530
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam(string key)
		{
			this.EnsureParamCacheIfNeeded();
			string result;
			if (!this.ParamCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x0023C358 File Offset: 0x0023A558
		private void EnsureParamCacheIfNeeded()
		{
			if (this.ParamCache != null)
			{
				return;
			}
			this.ParamCache = this.ParamIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x0023C3BE File Offset: 0x0023A5BE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParamFrozenDict(string key)
		{
			this.EnsureParamCacheIfNeeded();
			return this.ParamCache;
		}

		// Token: 0x04004D14 RID: 19732
		private Table __p;

		// Token: 0x04004D15 RID: 19733
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ParamCache;
	}
}
