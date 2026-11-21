using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AAF RID: 6831
	public class ICommonTipTriggerDelegation : ICommonTipType
	{
		// Token: 0x06009131 RID: 37169 RVA: 0x00154F98 File Offset: 0x00153198
		private ICommonTipTriggerDelegation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipTriggerDelegation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipTriggerDelegation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipTriggerDelegation_SetValue());
			}
			return result;
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x00154FD0 File Offset: 0x001531D0
		public static ICommonTipTriggerDelegation Create([Nullable(2)] ICommonTipTriggerDelegation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipTriggerDelegation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x00154FE3 File Offset: 0x001531E3
		public static ICommonTipTriggerDelegation CreateFromSetValue([Nullable(2)] ICommonTipTriggerDelegation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipTriggerDelegation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x00154FF8 File Offset: 0x001531F8
		public new ICommonTipTriggerDelegation_SetValue ToSetValue()
		{
			return new ICommonTipTriggerDelegation_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x06009135 RID: 37173 RVA: 0x00155046 File Offset: 0x00153246
		// (set) Token: 0x06009136 RID: 37174 RVA: 0x00155071 File Offset: 0x00153271
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x06009137 RID: 37175 RVA: 0x0015507F File Offset: 0x0015327F
		// (set) Token: 0x06009138 RID: 37176 RVA: 0x001550AA File Offset: 0x001532AA
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x06009139 RID: 37177 RVA: 0x001550B8 File Offset: 0x001532B8
		// (set) Token: 0x0600913A RID: 37178 RVA: 0x001550E3 File Offset: 0x001532E3
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600913B RID: 37179 RVA: 0x001550F1 File Offset: 0x001532F1
		// (set) Token: 0x0600913C RID: 37180 RVA: 0x00155108 File Offset: 0x00153308
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600913D RID: 37181 RVA: 0x00155116 File Offset: 0x00153316
		// (set) Token: 0x0600913E RID: 37182 RVA: 0x0015512D File Offset: 0x0015332D
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x04005AAB RID: 23211
		[Nullable(2)]
		protected new ICommonTipTriggerDelegation FbInstance;

		// Token: 0x04005AAC RID: 23212
		[Nullable(2)]
		protected new ICommonTipTriggerDelegation_SetValue PocoInterface;
	}
}
