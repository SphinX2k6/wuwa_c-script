using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED6 RID: 3798
	public struct PhantomBattleMasterLevel : IFlatbufferObject
	{
		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x0600A784 RID: 42884 RVA: 0x002B0C9A File Offset: 0x002AEE9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x002B0CA7 File Offset: 0x002AEEA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x002B0CB0 File Offset: 0x002AEEB0
		public static PhantomBattleMasterLevel GetRootAsPhantomBattleMasterLevel(ByteBuffer _bb)
		{
			return PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(_bb, default(PhantomBattleMasterLevel));
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x002B0CCC File Offset: 0x002AEECC
		public static PhantomBattleMasterLevel GetRootAsPhantomBattleMasterLevel(ByteBuffer _bb, PhantomBattleMasterLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x002B0CE9 File Offset: 0x002AEEE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x002B0CF8 File Offset: 0x002AEEF8
		public PhantomBattleMasterLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x002B0D08 File Offset: 0x002AEF08
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

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x002B0D44 File Offset: 0x002AEF44
		public int Level
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

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x0600A78C RID: 42892 RVA: 0x002B0D80 File Offset: 0x002AEF80
		public int ActivityId
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

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0600A78D RID: 42893 RVA: 0x002B0DBC File Offset: 0x002AEFBC
		public int Exp
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

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x002B0DFC File Offset: 0x002AEFFC
		public int ExpNext
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

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x002B0E3C File Offset: 0x002AF03C
		public int ExpNeed
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

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x002B0E7C File Offset: 0x002AF07C
		public int UnlockDropId
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

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x002B0EBC File Offset: 0x002AF0BC
		public int NormalDropId
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

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x002B0EFC File Offset: 0x002AF0FC
		public int TitleId
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

		// Token: 0x0600A793 RID: 42899 RVA: 0x002B0F3C File Offset: 0x002AF13C
		public string Desc(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0600A794 RID: 42900 RVA: 0x002B0F78 File Offset: 0x002AF178
		public int DescLength
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

		// Token: 0x0600A795 RID: 42901 RVA: 0x002B0FA4 File Offset: 0x002AF1A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescIter()或GetDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Desc()
		{
			return this.DescIter().ToArray<string>();
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x002B0FB1 File Offset: 0x002AF1B1
		[NullableContext(1)]
		public readonly IEnumerable<string> DescIter()
		{
			PhantomBattleMasterLevel.<DescIter>d__30 <DescIter>d__ = new PhantomBattleMasterLevel.<DescIter>d__30(-2);
			<DescIter>d__.<>3__<>4__this = this;
			return <DescIter>d__;
		}

		// Token: 0x04004F94 RID: 20372
		private Table __p;
	}
}
