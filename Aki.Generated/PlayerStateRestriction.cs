using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F47 RID: 3911
	public struct PlayerStateRestriction : IFlatbufferObject
	{
		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x0600B1BA RID: 45498 RVA: 0x002C80B9 File Offset: 0x002C62B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x002C80C6 File Offset: 0x002C62C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x002C80D0 File Offset: 0x002C62D0
		public static PlayerStateRestriction GetRootAsPlayerStateRestriction(ByteBuffer _bb)
		{
			return PlayerStateRestriction.GetRootAsPlayerStateRestriction(_bb, default(PlayerStateRestriction));
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x002C80EC File Offset: 0x002C62EC
		public static PlayerStateRestriction GetRootAsPlayerStateRestriction(ByteBuffer _bb, PlayerStateRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x002C8109 File Offset: 0x002C6309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x002C8118 File Offset: 0x002C6318
		public PlayerStateRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x0600B1C0 RID: 45504 RVA: 0x002C8128 File Offset: 0x002C6328
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

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0600B1C1 RID: 45505 RVA: 0x002C8164 File Offset: 0x002C6364
		public string Type
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

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x002C819B File Offset: 0x002C639B
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x002C81AA File Offset: 0x002C63AA
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x002C81C4 File Offset: 0x002C63C4
		public string IncludedTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0600B1C5 RID: 45509 RVA: 0x002C8200 File Offset: 0x002C6400
		public int IncludedTagsLength
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

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x002C822C File Offset: 0x002C642C
		public string ExcludedTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600B1C7 RID: 45511 RVA: 0x002C8268 File Offset: 0x002C6468
		public int ExcludedTagsLength
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

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600B1C8 RID: 45512 RVA: 0x002C8294 File Offset: 0x002C6494
		public int CreatorId
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

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600B1C9 RID: 45513 RVA: 0x002C82D4 File Offset: 0x002C64D4
		public string Remark
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

		// Token: 0x0600B1CA RID: 45514 RVA: 0x002C830C File Offset: 0x002C650C
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x002C831C File Offset: 0x002C651C
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x002C8334 File Offset: 0x002C6534
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExcludedTagsIter()或GetExcludedTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExcludedTags()
		{
			return this.ExcludedTagsIter().ToArray<string>();
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x002C8341 File Offset: 0x002C6541
		[NullableContext(1)]
		public readonly IEnumerable<string> ExcludedTagsIter()
		{
			PlayerStateRestriction.<ExcludedTagsIter>d__27 <ExcludedTagsIter>d__ = new PlayerStateRestriction.<ExcludedTagsIter>d__27(-2);
			<ExcludedTagsIter>d__.<>3__<>4__this = this;
			return <ExcludedTagsIter>d__;
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x002C8356 File Offset: 0x002C6556
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IncludedTagsIter()或GetIncludedTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IncludedTags()
		{
			return this.IncludedTagsIter().ToArray<string>();
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x002C8363 File Offset: 0x002C6563
		[NullableContext(1)]
		public readonly IEnumerable<string> IncludedTagsIter()
		{
			PlayerStateRestriction.<IncludedTagsIter>d__29 <IncludedTagsIter>d__ = new PlayerStateRestriction.<IncludedTagsIter>d__29(-2);
			<IncludedTagsIter>d__.<>3__<>4__this = this;
			return <IncludedTagsIter>d__;
		}

		// Token: 0x04005014 RID: 20500
		private Table __p;
	}
}
