using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE4 RID: 3044
	public struct DebugCommandConfig : IFlatbufferObject
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x00211344 File Offset: 0x0020F544
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x00211351 File Offset: 0x0020F551
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x00211358 File Offset: 0x0020F558
		public static DebugCommandConfig GetRootAsDebugCommandConfig(ByteBuffer _bb)
		{
			return DebugCommandConfig.GetRootAsDebugCommandConfig(_bb, default(DebugCommandConfig));
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x00211374 File Offset: 0x0020F574
		public static DebugCommandConfig GetRootAsDebugCommandConfig(ByteBuffer _bb, DebugCommandConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00211391 File Offset: 0x0020F591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x002113A0 File Offset: 0x0020F5A0
		public DebugCommandConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06006139 RID: 24889 RVA: 0x002113B0 File Offset: 0x0020F5B0
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x002113EC File Offset: 0x0020F5EC
		public int GetTargetStage
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

		// Token: 0x0600613B RID: 24891 RVA: 0x00211428 File Offset: 0x0020F628
		public string ParamGetTarget(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600613C RID: 24892 RVA: 0x00211464 File Offset: 0x0020F664
		public int ParamGetTargetLength
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

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x00211490 File Offset: 0x0020F690
		public int EffectStage
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

		// Token: 0x0600613E RID: 24894 RVA: 0x002114D0 File Offset: 0x0020F6D0
		public string ParamEffect(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x0021150C File Offset: 0x0020F70C
		public int ParamEffectLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x00211538 File Offset: 0x0020F738
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamEffectIter()或GetParamEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ParamEffect()
		{
			return this.ParamEffectIter().ToArray<string>();
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x00211545 File Offset: 0x0020F745
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamEffectIter()
		{
			DebugCommandConfig.<ParamEffectIter>d__21 <ParamEffectIter>d__ = new DebugCommandConfig.<ParamEffectIter>d__21(-2);
			<ParamEffectIter>d__.<>3__<>4__this = this;
			return <ParamEffectIter>d__;
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x0021155A File Offset: 0x0020F75A
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamGetTargetIter()或GetParamGetTargetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ParamGetTarget()
		{
			return this.ParamGetTargetIter().ToArray<string>();
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x00211567 File Offset: 0x0020F767
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamGetTargetIter()
		{
			DebugCommandConfig.<ParamGetTargetIter>d__23 <ParamGetTargetIter>d__ = new DebugCommandConfig.<ParamGetTargetIter>d__23(-2);
			<ParamGetTargetIter>d__.<>3__<>4__this = this;
			return <ParamGetTargetIter>d__;
		}

		// Token: 0x04004C11 RID: 19473
		private Table __p;
	}
}
