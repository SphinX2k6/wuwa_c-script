using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C46 RID: 3142
	public struct ExecutionConf : IFlatbufferObject
	{
		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x002268C9 File Offset: 0x00224AC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x002268D6 File Offset: 0x00224AD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x002268E0 File Offset: 0x00224AE0
		public static ExecutionConf GetRootAsExecutionConf(ByteBuffer _bb)
		{
			return ExecutionConf.GetRootAsExecutionConf(_bb, default(ExecutionConf));
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x002268FC File Offset: 0x00224AFC
		public static ExecutionConf GetRootAsExecutionConf(ByteBuffer _bb, ExecutionConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x00226919 File Offset: 0x00224B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x00226928 File Offset: 0x00224B28
		public ExecutionConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x00226938 File Offset: 0x00224B38
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

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06006ABD RID: 27325 RVA: 0x00226974 File Offset: 0x00224B74
		public int ExecutionRoleId
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

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x002269B0 File Offset: 0x00224BB0
		public int ExecutionSkillId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x002269EC File Offset: 0x00224BEC
		public string LimitExecutionTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x00226A28 File Offset: 0x00224C28
		public int LimitExecutionTagsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x00226A54 File Offset: 0x00224C54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitExecutionTagsIter()或GetLimitExecutionTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LimitExecutionTags()
		{
			return this.LimitExecutionTagsIter().ToArray<string>();
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x00226A61 File Offset: 0x00224C61
		[NullableContext(1)]
		public readonly IEnumerable<string> LimitExecutionTagsIter()
		{
			ExecutionConf.<LimitExecutionTagsIter>d__18 <LimitExecutionTagsIter>d__ = new ExecutionConf.<LimitExecutionTagsIter>d__18(-2);
			<LimitExecutionTagsIter>d__.<>3__<>4__this = this;
			return <LimitExecutionTagsIter>d__;
		}

		// Token: 0x04004C8B RID: 19595
		private Table __p;
	}
}
