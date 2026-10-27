using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D87 RID: 3463
	public struct JokerSkill : IFlatbufferObject
	{
		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06008713 RID: 34579 RVA: 0x002679C0 File Offset: 0x00265BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x002679CD File Offset: 0x00265BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x002679D4 File Offset: 0x00265BD4
		public static JokerSkill GetRootAsJokerSkill(ByteBuffer _bb)
		{
			return JokerSkill.GetRootAsJokerSkill(_bb, default(JokerSkill));
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x002679F0 File Offset: 0x00265BF0
		public static JokerSkill GetRootAsJokerSkill(ByteBuffer _bb, JokerSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x00267A0D File Offset: 0x00265C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x00267A1C File Offset: 0x00265C1C
		public JokerSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06008719 RID: 34585 RVA: 0x00267A2C File Offset: 0x00265C2C
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

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600871A RID: 34586 RVA: 0x00267A68 File Offset: 0x00265C68
		public string SkillName
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

		// Token: 0x0600871B RID: 34587 RVA: 0x00267A9F File Offset: 0x00265C9F
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x00267AAE File Offset: 0x00265CAE
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600871D RID: 34589 RVA: 0x00267AC8 File Offset: 0x00265CC8
		public string SkillDesc
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

		// Token: 0x0600871E RID: 34590 RVA: 0x00267AFF File Offset: 0x00265CFF
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x00267B0E File Offset: 0x00265D0E
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06008720 RID: 34592 RVA: 0x00267B28 File Offset: 0x00265D28
		public string ShortSkillDesc
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

		// Token: 0x06008721 RID: 34593 RVA: 0x00267B60 File Offset: 0x00265D60
		public Span<byte> GetShortSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00267B70 File Offset: 0x00265D70
		public byte[] GetShortSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06008723 RID: 34595 RVA: 0x00267B88 File Offset: 0x00265D88
		public string SkillIconPath
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

		// Token: 0x06008724 RID: 34596 RVA: 0x00267BC0 File Offset: 0x00265DC0
		public Span<byte> GetSkillIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x00267BD0 File Offset: 0x00265DD0
		public byte[] GetSkillIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06008726 RID: 34598 RVA: 0x00267BE8 File Offset: 0x00265DE8
		public string WhiteSkillIconPath
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

		// Token: 0x06008727 RID: 34599 RVA: 0x00267C20 File Offset: 0x00265E20
		public Span<byte> GetWhiteSkillIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x00267C30 File Offset: 0x00265E30
		public byte[] GetWhiteSkillIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x00267C48 File Offset: 0x00265E48
		public string SkillPlayTexture(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600872A RID: 34602 RVA: 0x00267C84 File Offset: 0x00265E84
		public int SkillPlayTextureLength
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

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x0600872B RID: 34603 RVA: 0x00267CB0 File Offset: 0x00265EB0
		public int EffectPlayStrategy
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x0600872C RID: 34604 RVA: 0x00267CF0 File Offset: 0x00265EF0
		public bool ShowGiveUpTip
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x0600872D RID: 34605 RVA: 0x00267D30 File Offset: 0x00265F30
		public int HelpId
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

		// Token: 0x0600872E RID: 34606 RVA: 0x00267D6D File Offset: 0x00265F6D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillPlayTextureIter()或GetSkillPlayTextureBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillPlayTexture()
		{
			return this.SkillPlayTextureIter().ToArray<string>();
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x00267D7A File Offset: 0x00265F7A
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillPlayTextureIter()
		{
			JokerSkill.<SkillPlayTextureIter>d__40 <SkillPlayTextureIter>d__ = new JokerSkill.<SkillPlayTextureIter>d__40(-2);
			<SkillPlayTextureIter>d__.<>3__<>4__this = this;
			return <SkillPlayTextureIter>d__;
		}

		// Token: 0x04004E13 RID: 19987
		private Table __p;
	}
}
