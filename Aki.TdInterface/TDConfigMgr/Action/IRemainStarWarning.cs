using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D92 RID: 7570
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemainStarWarning : ICommonTipType
	{
		// Token: 0x0600A243 RID: 41539 RVA: 0x00171270 File Offset: 0x0016F470
		private IRemainStarWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemainStarWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemainStarWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemainStarWarning_SetValue());
			}
			return result;
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x001712A8 File Offset: 0x0016F4A8
		public static IRemainStarWarning Create([Nullable(2)] IRemainStarWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemainStarWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x001712BB File Offset: 0x0016F4BB
		public static IRemainStarWarning CreateFromSetValue([Nullable(2)] IRemainStarWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemainStarWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x001712CE File Offset: 0x0016F4CE
		public new IRemainStarWarning_SetValue ToSetValue()
		{
			return new IRemainStarWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A247 RID: 41543 RVA: 0x001712ED File Offset: 0x0016F4ED
		// (set) Token: 0x0600A248 RID: 41544 RVA: 0x00171318 File Offset: 0x0016F518
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

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A249 RID: 41545 RVA: 0x00171326 File Offset: 0x0016F526
		// (set) Token: 0x0600A24A RID: 41546 RVA: 0x00171351 File Offset: 0x0016F551
		public virtual string WarningText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WarningText;
			}
			set
			{
				this.GetOrCreatePoco().WarningText = value;
			}
		}

		// Token: 0x0400617C RID: 24956
		[Nullable(2)]
		protected new IRemainStarWarning FbInstance;

		// Token: 0x0400617D RID: 24957
		[Nullable(2)]
		protected new IRemainStarWarning_SetValue PocoInterface;
	}
}
