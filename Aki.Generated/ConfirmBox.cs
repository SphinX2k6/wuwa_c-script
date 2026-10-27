using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B97 RID: 2967
	public struct ConfirmBox : IFlatbufferObject
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x001FE6A6 File Offset: 0x001FC8A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x001FE6B3 File Offset: 0x001FC8B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x001FE6BC File Offset: 0x001FC8BC
		public static ConfirmBox GetRootAsConfirmBox(ByteBuffer _bb)
		{
			return ConfirmBox.GetRootAsConfirmBox(_bb, default(ConfirmBox));
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x001FE6D8 File Offset: 0x001FC8D8
		public static ConfirmBox GetRootAsConfirmBox(ByteBuffer _bb, ConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x001FE6F5 File Offset: 0x001FC8F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x001FE704 File Offset: 0x001FC904
		public ConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060058DD RID: 22749 RVA: 0x001FE714 File Offset: 0x001FC914
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x001FE750 File Offset: 0x001FC950
		public string Title
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

		// Token: 0x060058DF RID: 22751 RVA: 0x001FE787 File Offset: 0x001FC987
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x001FE796 File Offset: 0x001FC996
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x001FE7B0 File Offset: 0x001FC9B0
		public string Content
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

		// Token: 0x060058E2 RID: 22754 RVA: 0x001FE7E7 File Offset: 0x001FC9E7
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x001FE7F6 File Offset: 0x001FC9F6
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x001FE810 File Offset: 0x001FCA10
		public string SecondaryContent
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

		// Token: 0x060058E5 RID: 22757 RVA: 0x001FE848 File Offset: 0x001FCA48
		public Span<byte> GetSecondaryContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x001FE858 File Offset: 0x001FCA58
		public byte[] GetSecondaryContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x001FE870 File Offset: 0x001FCA70
		public string ButtonText(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x001FE8AC File Offset: 0x001FCAAC
		public int ButtonTextLength
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x001FE8D8 File Offset: 0x001FCAD8
		public int DelayTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x001FE918 File Offset: 0x001FCB18
		public int DelayButtonIndex
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060058EB RID: 22763 RVA: 0x001FE958 File Offset: 0x001FCB58
		public bool NeedMaskClose
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x001FE998 File Offset: 0x001FCB98
		public int UiShowType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060058ED RID: 22765 RVA: 0x001FE9D8 File Offset: 0x001FCBD8
		public bool NeedClose
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x001FEA18 File Offset: 0x001FCC18
		public bool NeedUpload
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060058EF RID: 22767 RVA: 0x001FEA58 File Offset: 0x001FCC58
		public int TimeDilation
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x001FEA98 File Offset: 0x001FCC98
		public int ToggleType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x001FEAD5 File Offset: 0x001FCCD5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ButtonTextIter()或GetButtonTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ButtonText()
		{
			return this.ButtonTextIter().ToArray<string>();
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x001FEAE2 File Offset: 0x001FCCE2
		[NullableContext(1)]
		public readonly IEnumerable<string> ButtonTextIter()
		{
			ConfirmBox.<ButtonTextIter>d__42 <ButtonTextIter>d__ = new ConfirmBox.<ButtonTextIter>d__42(-2);
			<ButtonTextIter>d__.<>3__<>4__this = this;
			return <ButtonTextIter>d__;
		}

		// Token: 0x04004BB8 RID: 19384
		private Table __p;
	}
}
