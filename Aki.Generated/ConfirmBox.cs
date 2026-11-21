using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C79 RID: 3193
	public struct ConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06005EB0 RID: 24240 RVA: 0x0021E446 File Offset: 0x0021C646
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x0021E453 File Offset: 0x0021C653
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x0021E45C File Offset: 0x0021C65C
		public static ConfirmBox GetRootAsConfirmBox(ByteBuffer _bb)
		{
			return ConfirmBox.GetRootAsConfirmBox(_bb, default(ConfirmBox));
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x0021E478 File Offset: 0x0021C678
		public static ConfirmBox GetRootAsConfirmBox(ByteBuffer _bb, ConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x0021E495 File Offset: 0x0021C695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x0021E4A4 File Offset: 0x0021C6A4
		public ConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x0021E4B4 File Offset: 0x0021C6B4
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

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x0021E4F0 File Offset: 0x0021C6F0
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

		// Token: 0x06005EB8 RID: 24248 RVA: 0x0021E527 File Offset: 0x0021C727
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x0021E536 File Offset: 0x0021C736
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06005EBA RID: 24250 RVA: 0x0021E550 File Offset: 0x0021C750
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

		// Token: 0x06005EBB RID: 24251 RVA: 0x0021E587 File Offset: 0x0021C787
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x0021E596 File Offset: 0x0021C796
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x0021E5B0 File Offset: 0x0021C7B0
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

		// Token: 0x06005EBE RID: 24254 RVA: 0x0021E5E8 File Offset: 0x0021C7E8
		public Span<byte> GetSecondaryContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0021E5F8 File Offset: 0x0021C7F8
		public byte[] GetSecondaryContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x0021E610 File Offset: 0x0021C810
		public string ButtonText(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x0021E64C File Offset: 0x0021C84C
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

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x0021E678 File Offset: 0x0021C878
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

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x0021E6B8 File Offset: 0x0021C8B8
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

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x0021E6F8 File Offset: 0x0021C8F8
		public bool NeedMaskClose
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x0021E738 File Offset: 0x0021C938
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

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06005EC6 RID: 24262 RVA: 0x0021E778 File Offset: 0x0021C978
		public bool NeedClose
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x0021E7B8 File Offset: 0x0021C9B8
		public bool NeedUpload
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x0021E7F8 File Offset: 0x0021C9F8
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

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x0021E838 File Offset: 0x0021CA38
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

		// Token: 0x06005ECA RID: 24266 RVA: 0x0021E875 File Offset: 0x0021CA75
		[NullableContext(1)]
		public string[] ButtonText()
		{
			return this.ButtonTextIter().ToArray<string>();
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x0021E882 File Offset: 0x0021CA82
		[NullableContext(1)]
		public IEnumerable<string> ButtonTextIter()
		{
			ConfirmBox.<ButtonTextIter>d__42 <ButtonTextIter>d__ = new ConfirmBox.<ButtonTextIter>d__42(-2);
			<ButtonTextIter>d__.<>3__<>4__this = this;
			return <ButtonTextIter>d__;
		}

		// Token: 0x0400519A RID: 20890
		private Table __p;
	}
}
