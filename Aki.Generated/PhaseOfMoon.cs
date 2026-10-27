using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFE RID: 3838
	public struct PhaseOfMoon : IFlatbufferObject
	{
		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x002B7DC0 File Offset: 0x002B5FC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x002B7DCD File Offset: 0x002B5FCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x002B7DD4 File Offset: 0x002B5FD4
		public static PhaseOfMoon GetRootAsPhaseOfMoon(ByteBuffer _bb)
		{
			return PhaseOfMoon.GetRootAsPhaseOfMoon(_bb, default(PhaseOfMoon));
		}

		// Token: 0x0600AAA1 RID: 43681 RVA: 0x002B7DF0 File Offset: 0x002B5FF0
		public static PhaseOfMoon GetRootAsPhaseOfMoon(ByteBuffer _bb, PhaseOfMoon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x002B7E0D File Offset: 0x002B600D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x002B7E1C File Offset: 0x002B601C
		public PhaseOfMoon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600AAA4 RID: 43684 RVA: 0x002B7E2C File Offset: 0x002B602C
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

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600AAA5 RID: 43685 RVA: 0x002B7E68 File Offset: 0x002B6068
		public int Reward
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

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x002B7EA4 File Offset: 0x002B60A4
		public string BuffDes
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

		// Token: 0x0600AAA7 RID: 43687 RVA: 0x002B7EDB File Offset: 0x002B60DB
		public Span<byte> GetBuffDesBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AAA8 RID: 43688 RVA: 0x002B7EEA File Offset: 0x002B60EA
		public byte[] GetBuffDesArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x0600AAA9 RID: 43689 RVA: 0x002B7F04 File Offset: 0x002B6104
		public string BuffName
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

		// Token: 0x0600AAAA RID: 43690 RVA: 0x002B7F3C File Offset: 0x002B613C
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x002B7F4C File Offset: 0x002B614C
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600AAAC RID: 43692 RVA: 0x002B7F64 File Offset: 0x002B6164
		public string BuffTexture
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

		// Token: 0x0600AAAD RID: 43693 RVA: 0x002B7F9C File Offset: 0x002B619C
		public Span<byte> GetBuffTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x002B7FAC File Offset: 0x002B61AC
		public byte[] GetBuffTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600AAAF RID: 43695 RVA: 0x002B7FC4 File Offset: 0x002B61C4
		public string Texture
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

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x002B7FFC File Offset: 0x002B61FC
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AAB1 RID: 43697 RVA: 0x002B800C File Offset: 0x002B620C
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x0600AAB2 RID: 43698 RVA: 0x002B8024 File Offset: 0x002B6224
		public string RewardTexture
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

		// Token: 0x0600AAB3 RID: 43699 RVA: 0x002B805C File Offset: 0x002B625C
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AAB4 RID: 43700 RVA: 0x002B806C File Offset: 0x002B626C
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x0600AAB5 RID: 43701 RVA: 0x002B8084 File Offset: 0x002B6284
		public string MoonName
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

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x002B80BC File Offset: 0x002B62BC
		public Span<byte> GetMoonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x002B80CC File Offset: 0x002B62CC
		public byte[] GetMoonNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x0600AAB8 RID: 43704 RVA: 0x002B80E4 File Offset: 0x002B62E4
		public string MoonDes
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

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x002B811C File Offset: 0x002B631C
		public Span<byte> GetMoonDesBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AABA RID: 43706 RVA: 0x002B812C File Offset: 0x002B632C
		public byte[] GetMoonDesArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AABB RID: 43707 RVA: 0x002B8144 File Offset: 0x002B6344
		public string Talk(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x0600AABC RID: 43708 RVA: 0x002B8180 File Offset: 0x002B6380
		public int TalkLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AABD RID: 43709 RVA: 0x002B81AC File Offset: 0x002B63AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TalkIter()或GetTalkBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Talk()
		{
			return this.TalkIter().ToArray<string>();
		}

		// Token: 0x0600AABE RID: 43710 RVA: 0x002B81B9 File Offset: 0x002B63B9
		[NullableContext(1)]
		public readonly IEnumerable<string> TalkIter()
		{
			PhaseOfMoon.<TalkIter>d__44 <TalkIter>d__ = new PhaseOfMoon.<TalkIter>d__44(-2);
			<TalkIter>d__.<>3__<>4__this = this;
			return <TalkIter>d__;
		}

		// Token: 0x04004FC6 RID: 20422
		private Table __p;
	}
}
