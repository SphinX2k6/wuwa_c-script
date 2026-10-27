using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5E RID: 3422
	public struct InfoDisplayGroup : IFlatbufferObject
	{
		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060082EB RID: 33515 RVA: 0x0025DD30 File Offset: 0x0025BF30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x0025DD3D File Offset: 0x0025BF3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x0025DD44 File Offset: 0x0025BF44
		public static InfoDisplayGroup GetRootAsInfoDisplayGroup(ByteBuffer _bb)
		{
			return InfoDisplayGroup.GetRootAsInfoDisplayGroup(_bb, default(InfoDisplayGroup));
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x0025DD60 File Offset: 0x0025BF60
		public static InfoDisplayGroup GetRootAsInfoDisplayGroup(ByteBuffer _bb, InfoDisplayGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x0025DD7D File Offset: 0x0025BF7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x0025DD8C File Offset: 0x0025BF8C
		public InfoDisplayGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060082F1 RID: 33521 RVA: 0x0025DD9C File Offset: 0x0025BF9C
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

		// Token: 0x060082F2 RID: 33522 RVA: 0x0025DDD8 File Offset: 0x0025BFD8
		public int InfoList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060082F3 RID: 33523 RVA: 0x0025DE18 File Offset: 0x0025C018
		public int InfoListLength
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

		// Token: 0x060082F4 RID: 33524 RVA: 0x0025DE43 File Offset: 0x0025C043
		public Span<int> GetInfoListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x0025DE52 File Offset: 0x0025C052
		public int[] GetInfoListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x0025DE6C File Offset: 0x0025C06C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InfoListIter()或GetInfoListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InfoList()
		{
			InfoDisplayGroup infoDisplayGroup = this;
			return infoDisplayGroup.GetInfoListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x0025DE90 File Offset: 0x0025C090
		[NullableContext(1)]
		public readonly IEnumerable<int> InfoListIter()
		{
			InfoDisplayGroup.<InfoListIter>d__16 <InfoListIter>d__ = new InfoDisplayGroup.<InfoListIter>d__16(-2);
			<InfoListIter>d__.<>3__<>4__this = this;
			return <InfoListIter>d__;
		}

		// Token: 0x04004DDD RID: 19933
		private Table __p;
	}
}
