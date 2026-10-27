using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA8 RID: 3240
	public struct FloroRanchEvent : IFlatbufferObject
	{
		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600732A RID: 29482 RVA: 0x0023AA18 File Offset: 0x00238C18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x0023AA25 File Offset: 0x00238C25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x0023AA2C File Offset: 0x00238C2C
		public static FloroRanchEvent GetRootAsFloroRanchEvent(ByteBuffer _bb)
		{
			return FloroRanchEvent.GetRootAsFloroRanchEvent(_bb, default(FloroRanchEvent));
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x0023AA48 File Offset: 0x00238C48
		public static FloroRanchEvent GetRootAsFloroRanchEvent(ByteBuffer _bb, FloroRanchEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x0023AA65 File Offset: 0x00238C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x0023AA74 File Offset: 0x00238C74
		public FloroRanchEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06007330 RID: 29488 RVA: 0x0023AA84 File Offset: 0x00238C84
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

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06007331 RID: 29489 RVA: 0x0023AAC0 File Offset: 0x00238CC0
		public int ActivityId
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06007332 RID: 29490 RVA: 0x0023AAFC File Offset: 0x00238CFC
		public int Unique
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

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x0023AB38 File Offset: 0x00238D38
		public string Title
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

		// Token: 0x06007334 RID: 29492 RVA: 0x0023AB70 File Offset: 0x00238D70
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x0023AB80 File Offset: 0x00238D80
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06007336 RID: 29494 RVA: 0x0023AB98 File Offset: 0x00238D98
		public string Desc
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

		// Token: 0x06007337 RID: 29495 RVA: 0x0023ABD0 File Offset: 0x00238DD0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x0023ABE0 File Offset: 0x00238DE0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x0023ABF8 File Offset: 0x00238DF8
		public int Choice(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x0023AC38 File Offset: 0x00238E38
		public int ChoiceLength
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

		// Token: 0x0600733B RID: 29499 RVA: 0x0023AC64 File Offset: 0x00238E64
		public Span<int> GetChoiceBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0023AC74 File Offset: 0x00238E74
		public int[] GetChoiceArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x0023AC8C File Offset: 0x00238E8C
		public int Rate
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

		// Token: 0x0600733E RID: 29502 RVA: 0x0023ACCC File Offset: 0x00238ECC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChoiceIter()或GetChoiceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Choice()
		{
			FloroRanchEvent floroRanchEvent = this;
			return floroRanchEvent.GetChoiceArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x0023ACF0 File Offset: 0x00238EF0
		[NullableContext(1)]
		public readonly IEnumerable<int> ChoiceIter()
		{
			FloroRanchEvent.<ChoiceIter>d__30 <ChoiceIter>d__ = new FloroRanchEvent.<ChoiceIter>d__30(-2);
			<ChoiceIter>d__.<>3__<>4__this = this;
			return <ChoiceIter>d__;
		}

		// Token: 0x04004D0A RID: 19722
		private Table __p;
	}
}
