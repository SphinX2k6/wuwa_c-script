using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3C RID: 3644
	public struct HotKeyType : IFlatbufferObject
	{
		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x0027AEA9 File Offset: 0x002790A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x0027AEB6 File Offset: 0x002790B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x0027AEC0 File Offset: 0x002790C0
		public static HotKeyType GetRootAsHotKeyType(ByteBuffer _bb)
		{
			return HotKeyType.GetRootAsHotKeyType(_bb, default(HotKeyType));
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x0027AEDC File Offset: 0x002790DC
		public static HotKeyType GetRootAsHotKeyType(ByteBuffer _bb, HotKeyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x0027AEF9 File Offset: 0x002790F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600885D RID: 34909 RVA: 0x0027AF08 File Offset: 0x00279108
		public HotKeyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x0027AF18 File Offset: 0x00279118
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

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x0027AF54 File Offset: 0x00279154
		public int Type
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

		// Token: 0x06008860 RID: 34912 RVA: 0x0027AF90 File Offset: 0x00279190
		public int HotKeyList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06008861 RID: 34913 RVA: 0x0027AFD0 File Offset: 0x002791D0
		public int HotKeyListLength
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

		// Token: 0x06008862 RID: 34914 RVA: 0x0027AFFB File Offset: 0x002791FB
		public Span<int> GetHotKeyListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x0027B00A File Offset: 0x0027920A
		public int[] GetHotKeyListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x0027B021 File Offset: 0x00279221
		[NullableContext(1)]
		public int[] HotKeyList()
		{
			return this.GetHotKeyListArray();
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x0027B029 File Offset: 0x00279229
		[NullableContext(1)]
		public IEnumerable<int> HotKeyListIter()
		{
			HotKeyType.<HotKeyListIter>d__18 <HotKeyListIter>d__ = new HotKeyType.<HotKeyListIter>d__18(-2);
			<HotKeyListIter>d__.<>3__<>4__this = this;
			return <HotKeyListIter>d__;
		}

		// Token: 0x040053BB RID: 21435
		private Table __p;
	}
}
