using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D58 RID: 3416
	public struct HotKeyView : IFlatbufferObject
	{
		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600824C RID: 33356 RVA: 0x0025C931 File Offset: 0x0025AB31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x0025C93E File Offset: 0x0025AB3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x0025C948 File Offset: 0x0025AB48
		public static HotKeyView GetRootAsHotKeyView(ByteBuffer _bb)
		{
			return HotKeyView.GetRootAsHotKeyView(_bb, default(HotKeyView));
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x0025C964 File Offset: 0x0025AB64
		public static HotKeyView GetRootAsHotKeyView(ByteBuffer _bb, HotKeyView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x0025C981 File Offset: 0x0025AB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x0025C990 File Offset: 0x0025AB90
		public HotKeyView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x0025C9A0 File Offset: 0x0025ABA0
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

		// Token: 0x06008253 RID: 33363 RVA: 0x0025C9DC File Offset: 0x0025ABDC
		public int FunctionButtonArray(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x0025CA1C File Offset: 0x0025AC1C
		public int FunctionButtonArrayLength
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

		// Token: 0x06008255 RID: 33365 RVA: 0x0025CA47 File Offset: 0x0025AC47
		public Span<int> GetFunctionButtonArrayBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x0025CA56 File Offset: 0x0025AC56
		public int[] GetFunctionButtonArrayArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x0025CA70 File Offset: 0x0025AC70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FunctionButtonArrayIter()或GetFunctionButtonArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FunctionButtonArray()
		{
			HotKeyView hotKeyView = this;
			return hotKeyView.GetFunctionButtonArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x0025CA94 File Offset: 0x0025AC94
		[NullableContext(1)]
		public readonly IEnumerable<int> FunctionButtonArrayIter()
		{
			HotKeyView.<FunctionButtonArrayIter>d__16 <FunctionButtonArrayIter>d__ = new HotKeyView.<FunctionButtonArrayIter>d__16(-2);
			<FunctionButtonArrayIter>d__.<>3__<>4__this = this;
			return <FunctionButtonArrayIter>d__;
		}

		// Token: 0x04004DD7 RID: 19927
		private Table __p;
	}
}
