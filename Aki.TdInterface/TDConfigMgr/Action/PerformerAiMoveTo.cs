using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235C RID: 9052
	public class PerformerAiMoveTo : ActionParams
	{
		// Token: 0x0600C54E RID: 50510 RVA: 0x001C48E0 File Offset: 0x001C2AE0
		private PerformerAiMoveTo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PerformerAiMoveTo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PerformerAiMoveTo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PerformerAiMoveTo_SetValue());
			}
			return result;
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x001C4918 File Offset: 0x001C2B18
		public static PerformerAiMoveTo Create([Nullable(2)] PerformerAiMoveTo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformerAiMoveTo
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x001C492B File Offset: 0x001C2B2B
		public static PerformerAiMoveTo CreateFromSetValue([Nullable(2)] PerformerAiMoveTo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PerformerAiMoveTo
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x001C493E File Offset: 0x001C2B3E
		public PerformerAiMoveTo_SetValue ToSetValue()
		{
			return new PerformerAiMoveTo_SetValue
			{
				Config = this.Config,
				StopDistance = this.StopDistance
			};
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600C552 RID: 50514 RVA: 0x001C495D File Offset: 0x001C2B5D
		// (set) Token: 0x0600C553 RID: 50515 RVA: 0x001C4984 File Offset: 0x001C2B84
		public virtual IPerformerAiMoveConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				PerformerAiMoveTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600C554 RID: 50516 RVA: 0x001C4994 File Offset: 0x001C2B94
		// (set) Token: 0x0600C555 RID: 50517 RVA: 0x001C49CE File Offset: 0x001C2BCE
		public virtual float? StopDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopDistance;
				}
				PerformerAiMoveTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopDistance;
			}
			set
			{
				this.GetOrCreatePoco().StopDistance = value;
			}
		}

		// Token: 0x04007575 RID: 30069
		[Nullable(2)]
		protected new PerformerAiMoveTo FbInstance;

		// Token: 0x04007576 RID: 30070
		[Nullable(2)]
		protected PerformerAiMoveTo_SetValue PocoInterface;
	}
}
