using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC0 RID: 3264
	public struct FloroRanchWeeklyChoice : IFlatbufferObject
	{
		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600752E RID: 29998 RVA: 0x0023F6DC File Offset: 0x0023D8DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x0023F6E9 File Offset: 0x0023D8E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x0023F6F0 File Offset: 0x0023D8F0
		public static FloroRanchWeeklyChoice GetRootAsFloroRanchWeeklyChoice(ByteBuffer _bb)
		{
			return FloroRanchWeeklyChoice.GetRootAsFloroRanchWeeklyChoice(_bb, default(FloroRanchWeeklyChoice));
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x0023F70C File Offset: 0x0023D90C
		public static FloroRanchWeeklyChoice GetRootAsFloroRanchWeeklyChoice(ByteBuffer _bb, FloroRanchWeeklyChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x0023F729 File Offset: 0x0023D929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x0023F738 File Offset: 0x0023D938
		public FloroRanchWeeklyChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06007534 RID: 30004 RVA: 0x0023F748 File Offset: 0x0023D948
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

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x0023F784 File Offset: 0x0023D984
		public string Desc
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

		// Token: 0x06007536 RID: 30006 RVA: 0x0023F7BB File Offset: 0x0023D9BB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x0023F7CA File Offset: 0x0023D9CA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0023F7E4 File Offset: 0x0023D9E4
		public string NameParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06007539 RID: 30009 RVA: 0x0023F820 File Offset: 0x0023DA20
		public int NameParamLength
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

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x0600753A RID: 30010 RVA: 0x0023F84C File Offset: 0x0023DA4C
		public int NeedRemoveToyCount
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

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600753B RID: 30011 RVA: 0x0023F88C File Offset: 0x0023DA8C
		public int NeedEmptyGridCount
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

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600753C RID: 30012 RVA: 0x0023F8CC File Offset: 0x0023DACC
		public int ToyRelateQuality
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

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x0023F90C File Offset: 0x0023DB0C
		public int GetToyRelateQuality
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

		// Token: 0x0600753E RID: 30014 RVA: 0x0023F949 File Offset: 0x0023DB49
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NameParamIter()或GetNameParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] NameParam()
		{
			return this.NameParamIter().ToArray<string>();
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x0023F956 File Offset: 0x0023DB56
		[NullableContext(1)]
		public readonly IEnumerable<string> NameParamIter()
		{
			FloroRanchWeeklyChoice.<NameParamIter>d__26 <NameParamIter>d__ = new FloroRanchWeeklyChoice.<NameParamIter>d__26(-2);
			<NameParamIter>d__.<>3__<>4__this = this;
			return <NameParamIter>d__;
		}

		// Token: 0x04004D30 RID: 19760
		private Table __p;
	}
}
