using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D94 RID: 3476
	public struct FloroRanchSkill : IFlatbufferObject
	{
		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x060079CE RID: 31182 RVA: 0x0025ADAD File Offset: 0x00258FAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x0025ADBA File Offset: 0x00258FBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x0025ADC4 File Offset: 0x00258FC4
		public static FloroRanchSkill GetRootAsFloroRanchSkill(ByteBuffer _bb)
		{
			return FloroRanchSkill.GetRootAsFloroRanchSkill(_bb, default(FloroRanchSkill));
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x0025ADE0 File Offset: 0x00258FE0
		public static FloroRanchSkill GetRootAsFloroRanchSkill(ByteBuffer _bb, FloroRanchSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x0025ADFD File Offset: 0x00258FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x0025AE0C File Offset: 0x0025900C
		public FloroRanchSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x060079D4 RID: 31188 RVA: 0x0025AE1C File Offset: 0x0025901C
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

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x060079D5 RID: 31189 RVA: 0x0025AE58 File Offset: 0x00259058
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

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x0025AE94 File Offset: 0x00259094
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

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x0025AED0 File Offset: 0x002590D0
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

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x0025AF10 File Offset: 0x00259110
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

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x060079D9 RID: 31193 RVA: 0x0025AF50 File Offset: 0x00259150
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

		// Token: 0x060079DA RID: 31194 RVA: 0x0025AF90 File Offset: 0x00259190
		public DicStringString? Param(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x0025AFF4 File Offset: 0x002591F4
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

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x0025B020 File Offset: 0x00259220
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

		// Token: 0x060079DD RID: 31197 RVA: 0x0025B058 File Offset: 0x00259258
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x0025B068 File Offset: 0x00259268
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x0025B080 File Offset: 0x00259280
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

		// Token: 0x060079E0 RID: 31200 RVA: 0x0025B0B8 File Offset: 0x002592B8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x0025B0C8 File Offset: 0x002592C8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0025B0E0 File Offset: 0x002592E0
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

		// Token: 0x060079E3 RID: 31203 RVA: 0x0025B118 File Offset: 0x00259318
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x0025B128 File Offset: 0x00259328
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x0025B140 File Offset: 0x00259340
		[NullableContext(1)]
		public Dictionary<string, string> Param()
		{
			return this.ParamIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x0025B196 File Offset: 0x00259396
		[NullableContext(1)]
		public IEnumerable<DicStringString> ParamIter()
		{
			FloroRanchSkill.<ParamIter>d__36 <ParamIter>d__ = new FloroRanchSkill.<ParamIter>d__36(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x0025B1AC File Offset: 0x002593AC
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

		// Token: 0x060079E8 RID: 31208 RVA: 0x0025B1D4 File Offset: 0x002593D4
		private void EnsureParamCacheIfNeeded()
		{
			if (this.ParamCache != null)
			{
				return;
			}
			this.ParamCache = this.ParamIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x0025B23A File Offset: 0x0025943A
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParamFrozenDict()
		{
			this.EnsureParamCacheIfNeeded();
			return this.ParamCache;
		}

		// Token: 0x040052F8 RID: 21240
		private Table __p;

		// Token: 0x040052F9 RID: 21241
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ParamCache;
	}
}
