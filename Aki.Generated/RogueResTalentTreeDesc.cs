using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001016 RID: 4118
	public struct RogueResTalentTreeDesc : IFlatbufferObject
	{
		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0600C418 RID: 50200 RVA: 0x002F0129 File Offset: 0x002EE329
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x002F0136 File Offset: 0x002EE336
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C41A RID: 50202 RVA: 0x002F0140 File Offset: 0x002EE340
		public static RogueResTalentTreeDesc GetRootAsRogueResTalentTreeDesc(ByteBuffer _bb)
		{
			return RogueResTalentTreeDesc.GetRootAsRogueResTalentTreeDesc(_bb, default(RogueResTalentTreeDesc));
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x002F015C File Offset: 0x002EE35C
		public static RogueResTalentTreeDesc GetRootAsRogueResTalentTreeDesc(ByteBuffer _bb, RogueResTalentTreeDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C41C RID: 50204 RVA: 0x002F0179 File Offset: 0x002EE379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C41D RID: 50205 RVA: 0x002F0188 File Offset: 0x002EE388
		public RogueResTalentTreeDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600C41E RID: 50206 RVA: 0x002F0198 File Offset: 0x002EE398
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

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600C41F RID: 50207 RVA: 0x002F01D4 File Offset: 0x002EE3D4
		public string TalentName
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

		// Token: 0x0600C420 RID: 50208 RVA: 0x002F020B File Offset: 0x002EE40B
		public Span<byte> GetTalentNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x002F021A File Offset: 0x002EE41A
		public byte[] GetTalentNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600C422 RID: 50210 RVA: 0x002F0234 File Offset: 0x002EE434
		public string TalentDesc
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

		// Token: 0x0600C423 RID: 50211 RVA: 0x002F026B File Offset: 0x002EE46B
		public Span<byte> GetTalentDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C424 RID: 50212 RVA: 0x002F027A File Offset: 0x002EE47A
		public byte[] GetTalentDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C425 RID: 50213 RVA: 0x002F0294 File Offset: 0x002EE494
		public string Args(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600C426 RID: 50214 RVA: 0x002F02D0 File Offset: 0x002EE4D0
		public int ArgsLength
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

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600C427 RID: 50215 RVA: 0x002F02FC File Offset: 0x002EE4FC
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

		// Token: 0x0600C428 RID: 50216 RVA: 0x002F0334 File Offset: 0x002EE534
		public Span<byte> GetTalentIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x002F0344 File Offset: 0x002EE544
		public byte[] GetTalentIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C42A RID: 50218 RVA: 0x002F035C File Offset: 0x002EE55C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArgsIter()或GetArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Args()
		{
			return this.ArgsIter().ToArray<string>();
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x002F0369 File Offset: 0x002EE569
		[NullableContext(1)]
		public readonly IEnumerable<string> ArgsIter()
		{
			RogueResTalentTreeDesc.<ArgsIter>d__26 <ArgsIter>d__ = new RogueResTalentTreeDesc.<ArgsIter>d__26(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x04005104 RID: 20740
		private Table __p;
	}
}
