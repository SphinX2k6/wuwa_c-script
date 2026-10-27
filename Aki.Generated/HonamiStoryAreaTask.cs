using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2F RID: 3375
	public struct HonamiStoryAreaTask : IFlatbufferObject
	{
		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06007F00 RID: 32512 RVA: 0x00255634 File Offset: 0x00253834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x00255641 File Offset: 0x00253841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x00255648 File Offset: 0x00253848
		public static HonamiStoryAreaTask GetRootAsHonamiStoryAreaTask(ByteBuffer _bb)
		{
			return HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(_bb, default(HonamiStoryAreaTask));
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x00255664 File Offset: 0x00253864
		public static HonamiStoryAreaTask GetRootAsHonamiStoryAreaTask(ByteBuffer _bb, HonamiStoryAreaTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x00255681 File Offset: 0x00253881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x00255690 File Offset: 0x00253890
		public HonamiStoryAreaTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06007F06 RID: 32518 RVA: 0x002556A0 File Offset: 0x002538A0
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

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06007F07 RID: 32519 RVA: 0x002556DC File Offset: 0x002538DC
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

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06007F08 RID: 32520 RVA: 0x00255718 File Offset: 0x00253918
		public int AreaId
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

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06007F09 RID: 32521 RVA: 0x00255754 File Offset: 0x00253954
		public int DropId
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

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06007F0A RID: 32522 RVA: 0x00255794 File Offset: 0x00253994
		public int Weight
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

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06007F0B RID: 32523 RVA: 0x002557D4 File Offset: 0x002539D4
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06007F0C RID: 32524 RVA: 0x00255814 File Offset: 0x00253A14
		public string MainTargetDesText
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

		// Token: 0x06007F0D RID: 32525 RVA: 0x0025584C File Offset: 0x00253A4C
		public Span<byte> GetMainTargetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x0025585C File Offset: 0x00253A5C
		public byte[] GetMainTargetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x00255874 File Offset: 0x00253A74
		public string TargetDesText(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06007F10 RID: 32528 RVA: 0x002558B0 File Offset: 0x00253AB0
		public int TargetDesTextLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06007F11 RID: 32529 RVA: 0x002558DC File Offset: 0x00253ADC
		public string Name
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

		// Token: 0x06007F12 RID: 32530 RVA: 0x00255914 File Offset: 0x00253B14
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x00255924 File Offset: 0x00253B24
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06007F14 RID: 32532 RVA: 0x0025593C File Offset: 0x00253B3C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x00255974 File Offset: 0x00253B74
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x00255984 File Offset: 0x00253B84
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06007F17 RID: 32535 RVA: 0x0025599C File Offset: 0x00253B9C
		public int BTId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x002559D9 File Offset: 0x00253BD9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetDesTextIter()或GetTargetDesTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TargetDesText()
		{
			return this.TargetDesTextIter().ToArray<string>();
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x002559E6 File Offset: 0x00253BE6
		[NullableContext(1)]
		public readonly IEnumerable<string> TargetDesTextIter()
		{
			HonamiStoryAreaTask.<TargetDesTextIter>d__38 <TargetDesTextIter>d__ = new HonamiStoryAreaTask.<TargetDesTextIter>d__38(-2);
			<TargetDesTextIter>d__.<>3__<>4__this = this;
			return <TargetDesTextIter>d__;
		}

		// Token: 0x04004DA8 RID: 19880
		private Table __p;
	}
}
