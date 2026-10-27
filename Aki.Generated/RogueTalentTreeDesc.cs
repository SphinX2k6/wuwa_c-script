using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001024 RID: 4132
	public struct RogueTalentTreeDesc : IFlatbufferObject
	{
		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600C53A RID: 50490 RVA: 0x002F2AB5 File Offset: 0x002F0CB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x002F2AC2 File Offset: 0x002F0CC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x002F2ACC File Offset: 0x002F0CCC
		public static RogueTalentTreeDesc GetRootAsRogueTalentTreeDesc(ByteBuffer _bb)
		{
			return RogueTalentTreeDesc.GetRootAsRogueTalentTreeDesc(_bb, default(RogueTalentTreeDesc));
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x002F2AE8 File Offset: 0x002F0CE8
		public static RogueTalentTreeDesc GetRootAsRogueTalentTreeDesc(ByteBuffer _bb, RogueTalentTreeDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x002F2B05 File Offset: 0x002F0D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x002F2B14 File Offset: 0x002F0D14
		public RogueTalentTreeDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600C540 RID: 50496 RVA: 0x002F2B24 File Offset: 0x002F0D24
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

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600C541 RID: 50497 RVA: 0x002F2B60 File Offset: 0x002F0D60
		public string BaseDesc
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

		// Token: 0x0600C542 RID: 50498 RVA: 0x002F2B97 File Offset: 0x002F0D97
		public Span<byte> GetBaseDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x002F2BA6 File Offset: 0x002F0DA6
		public byte[] GetBaseDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x002F2BC0 File Offset: 0x002F0DC0
		public IntArray? Args(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600C545 RID: 50501 RVA: 0x002F2C20 File Offset: 0x002F0E20
		public int ArgsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x002F2C4C File Offset: 0x002F0E4C
		public string Params(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600C547 RID: 50503 RVA: 0x002F2C88 File Offset: 0x002F0E88
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600C548 RID: 50504 RVA: 0x002F2CB4 File Offset: 0x002F0EB4
		public string TalentIcon
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

		// Token: 0x0600C549 RID: 50505 RVA: 0x002F2CEC File Offset: 0x002F0EEC
		public Span<byte> GetTalentIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C54A RID: 50506 RVA: 0x002F2CFC File Offset: 0x002F0EFC
		public byte[] GetTalentIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600C54B RID: 50507 RVA: 0x002F2D14 File Offset: 0x002F0F14
		public string TalentName
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

		// Token: 0x0600C54C RID: 50508 RVA: 0x002F2D4C File Offset: 0x002F0F4C
		public Span<byte> GetTalentNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x002F2D5C File Offset: 0x002F0F5C
		public byte[] GetTalentNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C54E RID: 50510 RVA: 0x002F2D74 File Offset: 0x002F0F74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArgsIter()或GetArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] Args()
		{
			return this.ArgsIter().ToArray<IntArray>();
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x002F2D81 File Offset: 0x002F0F81
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> ArgsIter()
		{
			RogueTalentTreeDesc.<ArgsIter>d__29 <ArgsIter>d__ = new RogueTalentTreeDesc.<ArgsIter>d__29(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x002F2D96 File Offset: 0x002F0F96
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x002F2DA3 File Offset: 0x002F0FA3
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamsIter()
		{
			RogueTalentTreeDesc.<ParamsIter>d__31 <ParamsIter>d__ = new RogueTalentTreeDesc.<ParamsIter>d__31(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005117 RID: 20759
		private Table __p;
	}
}
