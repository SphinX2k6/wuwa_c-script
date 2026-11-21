using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6E RID: 3694
	public struct KeyPool : IFlatbufferObject
	{
		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06008D58 RID: 36184 RVA: 0x00286125 File Offset: 0x00284325
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00286132 File Offset: 0x00284332
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D5A RID: 36186 RVA: 0x0028613C File Offset: 0x0028433C
		public static KeyPool GetRootAsKeyPool(ByteBuffer _bb)
		{
			return KeyPool.GetRootAsKeyPool(_bb, default(KeyPool));
		}

		// Token: 0x06008D5B RID: 36187 RVA: 0x00286158 File Offset: 0x00284358
		public static KeyPool GetRootAsKeyPool(ByteBuffer _bb, KeyPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D5C RID: 36188 RVA: 0x00286175 File Offset: 0x00284375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D5D RID: 36189 RVA: 0x00286184 File Offset: 0x00284384
		public KeyPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06008D5E RID: 36190 RVA: 0x00286194 File Offset: 0x00284394
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

		// Token: 0x06008D5F RID: 36191 RVA: 0x002861CB File Offset: 0x002843CB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x002861DA File Offset: 0x002843DA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x002861F4 File Offset: 0x002843F4
		public string ValidKeys(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06008D62 RID: 36194 RVA: 0x00286230 File Offset: 0x00284430
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

		// Token: 0x06008D63 RID: 36195 RVA: 0x0028625B File Offset: 0x0028445B
		[NullableContext(1)]
		public string[] ValidKeys()
		{
			return this.ValidKeysIter().ToArray<string>();
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x00286268 File Offset: 0x00284468
		[NullableContext(1)]
		public IEnumerable<string> ValidKeysIter()
		{
			KeyPool.<ValidKeysIter>d__16 <ValidKeysIter>d__ = new KeyPool.<ValidKeysIter>d__16(-2);
			<ValidKeysIter>d__.<>3__<>4__this = this;
			return <ValidKeysIter>d__;
		}

		// Token: 0x040053FA RID: 21498
		private Table __p;
	}
}
