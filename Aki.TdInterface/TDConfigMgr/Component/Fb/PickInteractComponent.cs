using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2E RID: 3630
	public class PickInteractComponent : IComponentBase
	{
		// Token: 0x0600523C RID: 21052 RVA: 0x000CB640 File Offset: 0x000C9840
		public static PickInteractComponent Create(IPickInteractComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PickInteractComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x000CB660 File Offset: 0x000C9860
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x000CB698 File Offset: 0x000C9898
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x000CB6AE File Offset: 0x000C98AE
		public virtual IChessmanPickInteraction PickInteractType
		{
			get
			{
				if (this._PickInteractTypeInited)
				{
					return this._PickInteractTypeCache;
				}
				this._PickInteractTypeInited = true;
				this._PickInteractTypeCache = IChessmanPickInteraction.Create(this.Instance.PickInteractType);
				return this._PickInteractTypeCache;
			}
		}

		// Token: 0x04002EF5 RID: 12021
		private IPickInteractComponent Instance;

		// Token: 0x04002EF6 RID: 12022
		[Nullable(2)]
		private IChessmanPickInteraction _PickInteractTypeCache;

		// Token: 0x04002EF7 RID: 12023
		private bool _PickInteractTypeInited;
	}
}
