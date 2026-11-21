using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C76 RID: 3190
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupFinishDestroy : IGroupFinishConfig
	{
		// Token: 0x060048D2 RID: 18642 RVA: 0x000B7EFD File Offset: 0x000B60FD
		[NullableContext(0)]
		public static IGroupFinishDestroy Create(IGroupFinishDestroy? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishDestroy
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x000B7F1C File Offset: 0x000B611C
		public override EGroupFinishConfig Type
		{
			get
			{
				return (EGroupFinishConfig)this.Instance.Type;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x000B7F29 File Offset: 0x000B6129
		public virtual IEntityState SwitchSpecifiedStatus
		{
			get
			{
				if (this._SwitchSpecifiedStatusInited)
				{
					return this._SwitchSpecifiedStatusCache;
				}
				this._SwitchSpecifiedStatusInited = true;
				this._SwitchSpecifiedStatusCache = IEntityState.Create(this.Instance.SwitchSpecifiedStatus);
				return this._SwitchSpecifiedStatusCache;
			}
		}

		// Token: 0x040028F1 RID: 10481
		private IGroupFinishDestroy Instance;

		// Token: 0x040028F2 RID: 10482
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x040028F3 RID: 10483
		private bool _SwitchSpecifiedStatusInited;
	}
}
