using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8B RID: 3723
	public struct NewTowerBuff : IFlatbufferObject
	{
		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x0029D9BC File Offset: 0x0029BBBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x0029D9C9 File Offset: 0x0029BBC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x0029D9D0 File Offset: 0x0029BBD0
		public static NewTowerBuff GetRootAsNewTowerBuff(ByteBuffer _bb)
		{
			return NewTowerBuff.GetRootAsNewTowerBuff(_bb, default(NewTowerBuff));
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x0029D9EC File Offset: 0x0029BBEC
		public static NewTowerBuff GetRootAsNewTowerBuff(ByteBuffer _bb, NewTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x0029DA09 File Offset: 0x0029BC09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x0029DA18 File Offset: 0x0029BC18
		public NewTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06009F20 RID: 40736 RVA: 0x0029DA28 File Offset: 0x0029BC28
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

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06009F21 RID: 40737 RVA: 0x0029DA64 File Offset: 0x0029BC64
		public string Icon
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

		// Token: 0x06009F22 RID: 40738 RVA: 0x0029DA9B File Offset: 0x0029BC9B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x0029DAAA File Offset: 0x0029BCAA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06009F24 RID: 40740 RVA: 0x0029DAC4 File Offset: 0x0029BCC4
		public string Name
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

		// Token: 0x06009F25 RID: 40741 RVA: 0x0029DAFB File Offset: 0x0029BCFB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x0029DB0A File Offset: 0x0029BD0A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06009F27 RID: 40743 RVA: 0x0029DB24 File Offset: 0x0029BD24
		public string Desc
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

		// Token: 0x06009F28 RID: 40744 RVA: 0x0029DB5C File Offset: 0x0029BD5C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x0029DB6C File Offset: 0x0029BD6C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x0029DB84 File Offset: 0x0029BD84
		public string DescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06009F2B RID: 40747 RVA: 0x0029DBC0 File Offset: 0x0029BDC0
		public int DescParamLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06009F2C RID: 40748 RVA: 0x0029DBEC File Offset: 0x0029BDEC
		public string SmallIcon
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

		// Token: 0x06009F2D RID: 40749 RVA: 0x0029DC24 File Offset: 0x0029BE24
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x0029DC34 File Offset: 0x0029BE34
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x0029DC4C File Offset: 0x0029BE4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamIter()或GetDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x0029DC59 File Offset: 0x0029BE59
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamIter()
		{
			NewTowerBuff.<DescParamIter>d__30 <DescParamIter>d__ = new NewTowerBuff.<DescParamIter>d__30(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x04004F39 RID: 20281
		private Table __p;
	}
}
