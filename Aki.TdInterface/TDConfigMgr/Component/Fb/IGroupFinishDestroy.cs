using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA8 RID: 2984
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupFinishDestroy : IGroupFinishConfig
	{
		// Token: 0x06004479 RID: 17529 RVA: 0x000ADE39 File Offset: 0x000AC039
		[NullableContext(1)]
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

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x000ADE58 File Offset: 0x000AC058
		public override EGroupFinishConfig Type
		{
			get
			{
				return (EGroupFinishConfig)this.Instance.Type;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x000ADE65 File Offset: 0x000AC065
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

		// Token: 0x040026A9 RID: 9897
		private IGroupFinishDestroy Instance;

		// Token: 0x040026AA RID: 9898
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x040026AB RID: 9899
		private bool _SwitchSpecifiedStatusInited;
	}
}
