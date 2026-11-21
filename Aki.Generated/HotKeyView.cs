using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3D RID: 3645
	public struct HotKeyView : IFlatbufferObject
	{
		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06008866 RID: 34918 RVA: 0x0027B03E File Offset: 0x0027923E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008867 RID: 34919 RVA: 0x0027B04B File Offset: 0x0027924B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x0027B054 File Offset: 0x00279254
		public static HotKeyView GetRootAsHotKeyView(ByteBuffer _bb)
		{
			return HotKeyView.GetRootAsHotKeyView(_bb, default(HotKeyView));
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x0027B070 File Offset: 0x00279270
		public static HotKeyView GetRootAsHotKeyView(ByteBuffer _bb, HotKeyView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x0027B08D File Offset: 0x0027928D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x0027B09C File Offset: 0x0027929C
		public HotKeyView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x0600886C RID: 34924 RVA: 0x0027B0AC File Offset: 0x002792AC
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

		// Token: 0x0600886D RID: 34925 RVA: 0x0027B0E8 File Offset: 0x002792E8
		public int FunctionButtonArray(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x0600886E RID: 34926 RVA: 0x0027B128 File Offset: 0x00279328
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

		// Token: 0x0600886F RID: 34927 RVA: 0x0027B153 File Offset: 0x00279353
		public Span<int> GetFunctionButtonArrayBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x0027B162 File Offset: 0x00279362
		public int[] GetFunctionButtonArrayArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x0027B179 File Offset: 0x00279379
		[NullableContext(1)]
		public int[] FunctionButtonArray()
		{
			return this.GetFunctionButtonArrayArray();
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x0027B181 File Offset: 0x00279381
		[NullableContext(1)]
		public IEnumerable<int> FunctionButtonArrayIter()
		{
			HotKeyView.<FunctionButtonArrayIter>d__16 <FunctionButtonArrayIter>d__ = new HotKeyView.<FunctionButtonArrayIter>d__16(-2);
			<FunctionButtonArrayIter>d__.<>3__<>4__this = this;
			return <FunctionButtonArrayIter>d__;
		}

		// Token: 0x040053BC RID: 21436
		private Table __p;
	}
}
