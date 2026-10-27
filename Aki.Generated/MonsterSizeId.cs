using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1D RID: 3613
	public struct MonsterSizeId : IFlatbufferObject
	{
		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600958E RID: 38286 RVA: 0x002889BD File Offset: 0x00286BBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x002889CA File Offset: 0x00286BCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x002889D4 File Offset: 0x00286BD4
		public static MonsterSizeId GetRootAsMonsterSizeId(ByteBuffer _bb)
		{
			return MonsterSizeId.GetRootAsMonsterSizeId(_bb, default(MonsterSizeId));
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x002889F0 File Offset: 0x00286BF0
		public static MonsterSizeId GetRootAsMonsterSizeId(ByteBuffer _bb, MonsterSizeId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x00288A0D File Offset: 0x00286C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x00288A1C File Offset: 0x00286C1C
		public MonsterSizeId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06009594 RID: 38292 RVA: 0x00288A2C File Offset: 0x00286C2C
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

		// Token: 0x06009595 RID: 38293 RVA: 0x00288A68 File Offset: 0x00286C68
		public string MonsterSizeTag(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06009596 RID: 38294 RVA: 0x00288AA4 File Offset: 0x00286CA4
		public int MonsterSizeTagLength
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

		// Token: 0x06009597 RID: 38295 RVA: 0x00288ACF File Offset: 0x00286CCF
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterSizeTagIter()或GetMonsterSizeTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MonsterSizeTag()
		{
			return this.MonsterSizeTagIter().ToArray<string>();
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x00288ADC File Offset: 0x00286CDC
		[NullableContext(1)]
		public readonly IEnumerable<string> MonsterSizeTagIter()
		{
			MonsterSizeId.<MonsterSizeTagIter>d__14 <MonsterSizeTagIter>d__ = new MonsterSizeId.<MonsterSizeTagIter>d__14(-2);
			<MonsterSizeTagIter>d__.<>3__<>4__this = this;
			return <MonsterSizeTagIter>d__;
		}

		// Token: 0x04004EC2 RID: 20162
		private Table __p;
	}
}
