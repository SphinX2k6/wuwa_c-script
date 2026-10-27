using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D89 RID: 3465
	public struct KeyPool : IFlatbufferObject
	{
		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600873D RID: 34621 RVA: 0x00267EF5 File Offset: 0x002660F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600873E RID: 34622 RVA: 0x00267F02 File Offset: 0x00266102
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600873F RID: 34623 RVA: 0x00267F0C File Offset: 0x0026610C
		public static KeyPool GetRootAsKeyPool(ByteBuffer _bb)
		{
			return KeyPool.GetRootAsKeyPool(_bb, default(KeyPool));
		}

		// Token: 0x06008740 RID: 34624 RVA: 0x00267F28 File Offset: 0x00266128
		public static KeyPool GetRootAsKeyPool(ByteBuffer _bb, KeyPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x00267F45 File Offset: 0x00266145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00267F54 File Offset: 0x00266154
		public KeyPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06008743 RID: 34627 RVA: 0x00267F64 File Offset: 0x00266164
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x00267F9B File Offset: 0x0026619B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x00267FAA File Offset: 0x002661AA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x00267FC4 File Offset: 0x002661C4
		public string ValidKeys(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06008747 RID: 34631 RVA: 0x00268000 File Offset: 0x00266200
		public int ValidKeysLength
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

		// Token: 0x06008748 RID: 34632 RVA: 0x0026802B File Offset: 0x0026622B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ValidKeysIter()或GetValidKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ValidKeys()
		{
			return this.ValidKeysIter().ToArray<string>();
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x00268038 File Offset: 0x00266238
		[NullableContext(1)]
		public readonly IEnumerable<string> ValidKeysIter()
		{
			KeyPool.<ValidKeysIter>d__16 <ValidKeysIter>d__ = new KeyPool.<ValidKeysIter>d__16(-2);
			<ValidKeysIter>d__.<>3__<>4__this = this;
			return <ValidKeysIter>d__;
		}

		// Token: 0x04004E15 RID: 19989
		private Table __p;
	}
}
