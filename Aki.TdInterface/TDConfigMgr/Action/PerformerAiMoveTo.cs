using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FB RID: 8443
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformerAiMoveTo : ActionParams
	{
		// Token: 0x0600B9C2 RID: 47554 RVA: 0x001AD780 File Offset: 0x001AB980
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

		// Token: 0x0600B9C3 RID: 47555 RVA: 0x001AD7B8 File Offset: 0x001AB9B8
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

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x001AD7CB File Offset: 0x001AB9CB
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

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x001AD7DE File Offset: 0x001AB9DE
		public PerformerAiMoveTo_SetValue ToSetValue()
		{
			return new PerformerAiMoveTo_SetValue
			{
				Config = this.Config,
				StopDistance = this.StopDistance
			};
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600B9C6 RID: 47558 RVA: 0x001AD7FD File Offset: 0x001AB9FD
		// (set) Token: 0x0600B9C7 RID: 47559 RVA: 0x001AD824 File Offset: 0x001ABA24
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

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600B9C8 RID: 47560 RVA: 0x001AD834 File Offset: 0x001ABA34
		// (set) Token: 0x0600B9C9 RID: 47561 RVA: 0x001AD86E File Offset: 0x001ABA6E
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

		// Token: 0x04006F41 RID: 28481
		[Nullable(2)]
		protected new PerformerAiMoveTo FbInstance;

		// Token: 0x04006F42 RID: 28482
		[Nullable(2)]
		protected PerformerAiMoveTo_SetValue PocoInterface;
	}
}
