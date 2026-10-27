using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D34 RID: 3380
	public struct HonamiStoryEffect : IFlatbufferObject
	{
		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06007F68 RID: 32616 RVA: 0x00256570 File Offset: 0x00254770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x0025657D File Offset: 0x0025477D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x00256584 File Offset: 0x00254784
		public static HonamiStoryEffect GetRootAsHonamiStoryEffect(ByteBuffer _bb)
		{
			return HonamiStoryEffect.GetRootAsHonamiStoryEffect(_bb, default(HonamiStoryEffect));
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x002565A0 File Offset: 0x002547A0
		public static HonamiStoryEffect GetRootAsHonamiStoryEffect(ByteBuffer _bb, HonamiStoryEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x002565BD File Offset: 0x002547BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x002565CC File Offset: 0x002547CC
		public HonamiStoryEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x002565DC File Offset: 0x002547DC
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

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x00256618 File Offset: 0x00254818
		public int EffectType
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

		// Token: 0x06007F70 RID: 32624 RVA: 0x00256654 File Offset: 0x00254854
		public string Param(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x00256690 File Offset: 0x00254890
		public int ParamLength
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

		// Token: 0x06007F72 RID: 32626 RVA: 0x002566BB File Offset: 0x002548BB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamIter()或GetParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Param()
		{
			return this.ParamIter().ToArray<string>();
		}

		// Token: 0x06007F73 RID: 32627 RVA: 0x002566C8 File Offset: 0x002548C8
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamIter()
		{
			HonamiStoryEffect.<ParamIter>d__16 <ParamIter>d__ = new HonamiStoryEffect.<ParamIter>d__16(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x04004DAE RID: 19886
		private Table __p;
	}
}
