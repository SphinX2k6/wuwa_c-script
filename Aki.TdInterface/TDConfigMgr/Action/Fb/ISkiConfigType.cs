using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EE RID: 10478
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkiConfigType
	{
		// Token: 0x0600E8C5 RID: 59589 RVA: 0x002227C9 File Offset: 0x002209C9
		public static ISkiConfigType Create(ISkiConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x0600E8C6 RID: 59590 RVA: 0x002227E8 File Offset: 0x002209E8
		public virtual ESkiConfig Type
		{
			get
			{
				return (ESkiConfig)this.Instance.Type;
			}
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x002227F5 File Offset: 0x002209F5
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadISkiConfigType_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008080 RID: 32896
		private ISkiConfigType Instance;

		// Token: 0x04008081 RID: 32897
		private ITargetEntityType _TargetCache;

		// Token: 0x04008082 RID: 32898
		private bool _TargetInited;
	}
}
