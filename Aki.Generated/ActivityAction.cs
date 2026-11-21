using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B97 RID: 2967
	public struct ActivityAction : IFlatbufferObject
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x001EAE2E File Offset: 0x001E902E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x001EAE3B File Offset: 0x001E903B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x001EAE44 File Offset: 0x001E9044
		public static ActivityAction GetRootAsActivityAction(ByteBuffer _bb)
		{
			return ActivityAction.GetRootAsActivityAction(_bb, default(ActivityAction));
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x001EAE60 File Offset: 0x001E9060
		public static ActivityAction GetRootAsActivityAction(ByteBuffer _bb, ActivityAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x001EAE7D File Offset: 0x001E907D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x001EAE8C File Offset: 0x001E908C
		public ActivityAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x001EAE9C File Offset: 0x001E909C
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x001EAED8 File Offset: 0x001E90D8
		public int ActionType
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

		// Token: 0x06004838 RID: 18488 RVA: 0x001EAF14 File Offset: 0x001E9114
		public DicStringString? ActionParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x001EAF74 File Offset: 0x001E9174
		public int ActionParamsLength
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x001EAFA0 File Offset: 0x001E91A0
		public int Priority
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

		// Token: 0x0600483B RID: 18491 RVA: 0x001EAFE0 File Offset: 0x001E91E0
		[NullableContext(1)]
		public Dictionary<string, string> ActionParams()
		{
			return this.ActionParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x001EB036 File Offset: 0x001E9236
		[NullableContext(1)]
		public IEnumerable<DicStringString> ActionParamsIter()
		{
			ActivityAction.<ActionParamsIter>d__18 <ActionParamsIter>d__ = new ActivityAction.<ActionParamsIter>d__18(-2);
			<ActionParamsIter>d__.<>3__<>4__this = this;
			return <ActionParamsIter>d__;
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x001EB04C File Offset: 0x001E924C
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetActionParams(string key)
		{
			this.EnsureActionParamsCacheIfNeeded();
			string result;
			if (!this.ActionParamsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x001EB074 File Offset: 0x001E9274
		private void EnsureActionParamsCacheIfNeeded()
		{
			if (this.ActionParamsCache != null)
			{
				return;
			}
			this.ActionParamsCache = this.ActionParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x001EB0DA File Offset: 0x001E92DA
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetActionParamsFrozenDict()
		{
			this.EnsureActionParamsCacheIfNeeded();
			return this.ActionParamsCache;
		}

		// Token: 0x04005071 RID: 20593
		private Table __p;

		// Token: 0x04005072 RID: 20594
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ActionParamsCache;
	}
}
