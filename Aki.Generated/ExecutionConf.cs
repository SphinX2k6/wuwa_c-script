using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D29 RID: 3369
	public struct ExecutionConf : IFlatbufferObject
	{
		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060070B8 RID: 28856 RVA: 0x00245C11 File Offset: 0x00243E11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00245C1E File Offset: 0x00243E1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x00245C28 File Offset: 0x00243E28
		public static ExecutionConf GetRootAsExecutionConf(ByteBuffer _bb)
		{
			return ExecutionConf.GetRootAsExecutionConf(_bb, default(ExecutionConf));
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x00245C44 File Offset: 0x00243E44
		public static ExecutionConf GetRootAsExecutionConf(ByteBuffer _bb, ExecutionConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x00245C61 File Offset: 0x00243E61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x00245C70 File Offset: 0x00243E70
		public ExecutionConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060070BE RID: 28862 RVA: 0x00245C80 File Offset: 0x00243E80
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x00245CBC File Offset: 0x00243EBC
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

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x00245CF8 File Offset: 0x00243EF8
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

		// Token: 0x060070C1 RID: 28865 RVA: 0x00245D34 File Offset: 0x00243F34
		public string LimitExecutionTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060070C2 RID: 28866 RVA: 0x00245D70 File Offset: 0x00243F70
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

		// Token: 0x060070C3 RID: 28867 RVA: 0x00245D9C File Offset: 0x00243F9C
		[NullableContext(1)]
		public string[] LimitExecutionTags()
		{
			return this.LimitExecutionTagsIter().ToArray<string>();
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x00245DA9 File Offset: 0x00243FA9
		[NullableContext(1)]
		public IEnumerable<string> LimitExecutionTagsIter()
		{
			ExecutionConf.<LimitExecutionTagsIter>d__18 <LimitExecutionTagsIter>d__ = new ExecutionConf.<LimitExecutionTagsIter>d__18(-2);
			<LimitExecutionTagsIter>d__.<>3__<>4__this = this;
			return <LimitExecutionTagsIter>d__;
		}

		// Token: 0x0400526E RID: 21102
		private Table __p;
	}
}
