using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC0 RID: 3264
	public struct DangoSkill : IFlatbufferObject
	{
		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x0022FA5C File Offset: 0x0022DC5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x0022FA69 File Offset: 0x0022DC69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x0022FA70 File Offset: 0x0022DC70
		public static DangoSkill GetRootAsDangoSkill(ByteBuffer _bb)
		{
			return DangoSkill.GetRootAsDangoSkill(_bb, default(DangoSkill));
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x0022FA8C File Offset: 0x0022DC8C
		public static DangoSkill GetRootAsDangoSkill(ByteBuffer _bb, DangoSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x0022FAA9 File Offset: 0x0022DCA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x0022FAB8 File Offset: 0x0022DCB8
		public DangoSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x0022FAC8 File Offset: 0x0022DCC8
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600669F RID: 26271 RVA: 0x0022FB04 File Offset: 0x0022DD04
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

		// Token: 0x060066A0 RID: 26272 RVA: 0x0022FB3B File Offset: 0x0022DD3B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x0022FB4A File Offset: 0x0022DD4A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x0022FB64 File Offset: 0x0022DD64
		public string Desc
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

		// Token: 0x060066A3 RID: 26275 RVA: 0x0022FB9B File Offset: 0x0022DD9B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x0022FBAA File Offset: 0x0022DDAA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x0022FBC4 File Offset: 0x0022DDC4
		public string ActivateDesc
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

		// Token: 0x060066A6 RID: 26278 RVA: 0x0022FBFC File Offset: 0x0022DDFC
		public Span<byte> GetActivateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x0022FC0C File Offset: 0x0022DE0C
		public byte[] GetActivateDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x0022FC24 File Offset: 0x0022DE24
		public int SkillEffect
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

		// Token: 0x060066A9 RID: 26281 RVA: 0x0022FC64 File Offset: 0x0022DE64
		public string Params(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x0022FCA0 File Offset: 0x0022DEA0
		public int ParamsLength
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

		// Token: 0x060066AB RID: 26283 RVA: 0x0022FCCC File Offset: 0x0022DECC
		[NullableContext(1)]
		public string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x0022FCD9 File Offset: 0x0022DED9
		[NullableContext(1)]
		public IEnumerable<string> ParamsIter()
		{
			DangoSkill.<ParamsIter>d__28 <ParamsIter>d__ = new DangoSkill.<ParamsIter>d__28(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x040051ED RID: 20973
		private Table __p;
	}
}
