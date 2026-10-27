using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD8 RID: 3544
	public struct LongPressConfig : IFlatbufferObject
	{
		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06008F4D RID: 36685 RVA: 0x0027A879 File Offset: 0x00278A79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x0027A886 File Offset: 0x00278A86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F4F RID: 36687 RVA: 0x0027A890 File Offset: 0x00278A90
		public static LongPressConfig GetRootAsLongPressConfig(ByteBuffer _bb)
		{
			return LongPressConfig.GetRootAsLongPressConfig(_bb, default(LongPressConfig));
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x0027A8AC File Offset: 0x00278AAC
		public static LongPressConfig GetRootAsLongPressConfig(ByteBuffer _bb, LongPressConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x0027A8C9 File Offset: 0x00278AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x0027A8D8 File Offset: 0x00278AD8
		public LongPressConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06008F53 RID: 36691 RVA: 0x0027A8E8 File Offset: 0x00278AE8
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

		// Token: 0x06008F54 RID: 36692 RVA: 0x0027A924 File Offset: 0x00278B24
		public int PressTime(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06008F55 RID: 36693 RVA: 0x0027A964 File Offset: 0x00278B64
		public int PressTimeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0027A98F File Offset: 0x00278B8F
		public Span<int> GetPressTimeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008F57 RID: 36695 RVA: 0x0027A99E File Offset: 0x00278B9E
		public int[] GetPressTimeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008F58 RID: 36696 RVA: 0x0027A9B8 File Offset: 0x00278BB8
		public int TriggerTime(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x0027A9F8 File Offset: 0x00278BF8
		public int TriggerTimeLength
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

		// Token: 0x06008F5A RID: 36698 RVA: 0x0027AA23 File Offset: 0x00278C23
		public Span<int> GetTriggerTimeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x0027AA32 File Offset: 0x00278C32
		public int[] GetTriggerTimeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06008F5C RID: 36700 RVA: 0x0027AA4C File Offset: 0x00278C4C
		public int AudioIntervalLimit
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

		// Token: 0x06008F5D RID: 36701 RVA: 0x0027AA8C File Offset: 0x00278C8C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PressTimeIter()或GetPressTimeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PressTime()
		{
			LongPressConfig longPressConfig = this;
			return longPressConfig.GetPressTimeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x0027AAB0 File Offset: 0x00278CB0
		[NullableContext(1)]
		public readonly IEnumerable<int> PressTimeIter()
		{
			LongPressConfig.<PressTimeIter>d__23 <PressTimeIter>d__ = new LongPressConfig.<PressTimeIter>d__23(-2);
			<PressTimeIter>d__.<>3__<>4__this = this;
			return <PressTimeIter>d__;
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x0027AAC8 File Offset: 0x00278CC8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerTimeIter()或GetTriggerTimeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TriggerTime()
		{
			LongPressConfig longPressConfig = this;
			return longPressConfig.GetTriggerTimeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0027AAEC File Offset: 0x00278CEC
		[NullableContext(1)]
		public readonly IEnumerable<int> TriggerTimeIter()
		{
			LongPressConfig.<TriggerTimeIter>d__25 <TriggerTimeIter>d__ = new LongPressConfig.<TriggerTimeIter>d__25(-2);
			<TriggerTimeIter>d__.<>3__<>4__this = this;
			return <TriggerTimeIter>d__;
		}

		// Token: 0x04004E73 RID: 20083
		private Table __p;
	}
}
