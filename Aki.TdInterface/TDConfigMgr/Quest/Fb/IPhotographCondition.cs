using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200155B RID: 5467
	public class IPhotographCondition
	{
		// Token: 0x06007B47 RID: 31559 RVA: 0x00125480 File Offset: 0x00123680
		public static IPhotographCondition Create(IPhotographCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x0012549F File Offset: 0x0012369F
		public virtual string TidTip
		{
			get
			{
				return this.Instance.TidTip;
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06007B49 RID: 31561 RVA: 0x001254AC File Offset: 0x001236AC
		public virtual IPhotographTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = QuestReadHelper.ReadIPhotographCondition_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06007B4A RID: 31562 RVA: 0x001254DB File Offset: 0x001236DB
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPhotographSubTarget> SubTargets
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._SubTargetsInited)
				{
					return this._SubTargetsCache;
				}
				this._SubTargetsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				this._SubTargetsCache = QuestReadHelper.ReadIPhotographCondition_SubTargets(this.Instance);
				return this._SubTargetsCache;
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x0012551B File Offset: 0x0012371B
		[Nullable(2)]
		public virtual string EdTidTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040046FD RID: 18173
		private IPhotographCondition Instance;

		// Token: 0x040046FE RID: 18174
		private IPhotographTarget _TargetCache;

		// Token: 0x040046FF RID: 18175
		private bool _TargetInited;

		// Token: 0x04004700 RID: 18176
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPhotographSubTarget> _SubTargetsCache;

		// Token: 0x04004701 RID: 18177
		private bool _SubTargetsInited;
	}
}
