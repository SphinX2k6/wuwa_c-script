using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EF RID: 10479
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSkiConfig : ISkiConfigType
	{
		// Token: 0x0600E8C9 RID: 59593 RVA: 0x0022282C File Offset: 0x00220A2C
		public static IOpenSkiConfig Create(IOpenSkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x0600E8CA RID: 59594 RVA: 0x0022284B File Offset: 0x00220A4B
		public override ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x0600E8CB RID: 59595 RVA: 0x00222858 File Offset: 0x00220A58
		public override ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIOpenSkiConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x0600E8CC RID: 59596 RVA: 0x00222887 File Offset: 0x00220A87
		public virtual string SkiConfig
		{
			get
			{
				return this.Instance.SkiConfig;
			}
		}

		// Token: 0x04008083 RID: 32899
		private IOpenSkiConfig Instance;

		// Token: 0x04008084 RID: 32900
		private ITargetEntityType _TargetCache;

		// Token: 0x04008085 RID: 32901
		private bool _TargetInited;
	}
}
