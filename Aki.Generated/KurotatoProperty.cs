using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E93 RID: 3731
	public struct KurotatoProperty : IFlatbufferObject
	{
		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x0028FCF0 File Offset: 0x0028DEF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x0028FCFD File Offset: 0x0028DEFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x0028FD04 File Offset: 0x0028DF04
		public static KurotatoProperty GetRootAsKurotatoProperty(ByteBuffer _bb)
		{
			return KurotatoProperty.GetRootAsKurotatoProperty(_bb, default(KurotatoProperty));
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x0028FD20 File Offset: 0x0028DF20
		public static KurotatoProperty GetRootAsKurotatoProperty(ByteBuffer _bb, KurotatoProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x0028FD3D File Offset: 0x0028DF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009135 RID: 37173 RVA: 0x0028FD4C File Offset: 0x0028DF4C
		public KurotatoProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x0028FD5C File Offset: 0x0028DF5C
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

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06009137 RID: 37175 RVA: 0x0028FD98 File Offset: 0x0028DF98
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

		// Token: 0x06009138 RID: 37176 RVA: 0x0028FDCF File Offset: 0x0028DFCF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x0028FDDE File Offset: 0x0028DFDE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x0600913A RID: 37178 RVA: 0x0028FDF8 File Offset: 0x0028DFF8
		public string KSCBasePropertyVarName
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

		// Token: 0x0600913B RID: 37179 RVA: 0x0028FE2F File Offset: 0x0028E02F
		public Span<byte> GetKSCBasePropertyVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x0028FE3E File Offset: 0x0028E03E
		public byte[] GetKSCBasePropertyVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x0600913D RID: 37181 RVA: 0x0028FE58 File Offset: 0x0028E058
		public string ShowName
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

		// Token: 0x0600913E RID: 37182 RVA: 0x0028FE90 File Offset: 0x0028E090
		public Span<byte> GetShowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x0028FEA0 File Offset: 0x0028E0A0
		public byte[] GetShowNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06009140 RID: 37184 RVA: 0x0028FEB8 File Offset: 0x0028E0B8
		public string WeaponPropertyDesc
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

		// Token: 0x06009141 RID: 37185 RVA: 0x0028FEF0 File Offset: 0x0028E0F0
		public Span<byte> GetWeaponPropertyDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009142 RID: 37186 RVA: 0x0028FF00 File Offset: 0x0028E100
		public byte[] GetWeaponPropertyDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x0028FF18 File Offset: 0x0028E118
		public string WeaponPropertyDescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x0028FF54 File Offset: 0x0028E154
		public int WeaponPropertyDescParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06009145 RID: 37189 RVA: 0x0028FF80 File Offset: 0x0028E180
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06009146 RID: 37190 RVA: 0x0028FFC0 File Offset: 0x0028E1C0
		public string Desc
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

		// Token: 0x06009147 RID: 37191 RVA: 0x0028FFF8 File Offset: 0x0028E1F8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x00290008 File Offset: 0x0028E208
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009149 RID: 37193 RVA: 0x00290020 File Offset: 0x0028E220
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x0600914A RID: 37194 RVA: 0x0029005C File Offset: 0x0028E25C
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x0600914B RID: 37195 RVA: 0x00290088 File Offset: 0x0028E288
		public int BasicValue
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x0600914C RID: 37196 RVA: 0x002900C8 File Offset: 0x0028E2C8
		public int Min
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return int.MinValue;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x0600914D RID: 37197 RVA: 0x0029010C File Offset: 0x0028E30C
		public int Max
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return int.MaxValue;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x0600914E RID: 37198 RVA: 0x00290150 File Offset: 0x0028E350
		public string Icon
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

		// Token: 0x0600914F RID: 37199 RVA: 0x00290188 File Offset: 0x0028E388
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x00290198 File Offset: 0x0028E398
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x002901B0 File Offset: 0x0028E3B0
		public int RoleType
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

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06009152 RID: 37202 RVA: 0x002901F0 File Offset: 0x0028E3F0
		public int ShowType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06009153 RID: 37203 RVA: 0x00290230 File Offset: 0x0028E430
		public int Precision
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06009154 RID: 37204 RVA: 0x00290270 File Offset: 0x0028E470
		public bool IsBlockFloat
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x002902B0 File Offset: 0x0028E4B0
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x002902BD File Offset: 0x0028E4BD
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			KurotatoProperty.<DescParamsIter>d__57 <DescParamsIter>d__ = new KurotatoProperty.<DescParamsIter>d__57(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x002902D2 File Offset: 0x0028E4D2
		[NullableContext(1)]
		public string[] WeaponPropertyDescParam()
		{
			return this.WeaponPropertyDescParamIter().ToArray<string>();
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x002902DF File Offset: 0x0028E4DF
		[NullableContext(1)]
		public IEnumerable<string> WeaponPropertyDescParamIter()
		{
			KurotatoProperty.<WeaponPropertyDescParamIter>d__59 <WeaponPropertyDescParamIter>d__ = new KurotatoProperty.<WeaponPropertyDescParamIter>d__59(-2);
			<WeaponPropertyDescParamIter>d__.<>3__<>4__this = this;
			return <WeaponPropertyDescParamIter>d__;
		}

		// Token: 0x04005425 RID: 21541
		private Table __p;
	}
}
