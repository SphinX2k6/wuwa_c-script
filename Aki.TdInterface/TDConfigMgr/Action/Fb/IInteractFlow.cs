using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002608 RID: 9736
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractFlow : IInteractType
	{
		// Token: 0x0600DAA8 RID: 55976 RVA: 0x002093E1 File Offset: 0x002075E1
		public static IInteractFlow Create(IInteractFlow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractFlow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x00209400 File Offset: 0x00207600
		public override EInteractOption Type
		{
			get
			{
				return (EInteractOption)this.Instance.Type;
			}
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0600DAAA RID: 55978 RVA: 0x0020940D File Offset: 0x0020760D
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x04007974 RID: 31092
		private IInteractFlow Instance;

		// Token: 0x04007975 RID: 31093
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04007976 RID: 31094
		private bool _FlowInited;
	}
}
