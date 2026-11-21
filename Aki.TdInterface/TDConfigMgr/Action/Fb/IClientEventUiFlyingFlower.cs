using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D34 RID: 11572
	public class IClientEventUiFlyingFlower : IClientEventUi
	{
		// Token: 0x0600FCD8 RID: 64728 RVA: 0x00248B59 File Offset: 0x00246D59
		public static IClientEventUiFlyingFlower Create(IClientEventUiFlyingFlower? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUiFlyingFlower
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x0600FCD9 RID: 64729 RVA: 0x00248B78 File Offset: 0x00246D78
		public override EClientEventUiType Type
		{
			get
			{
				return (EClientEventUiType)this.Instance.Type;
			}
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x0600FCDA RID: 64730 RVA: 0x00248B85 File Offset: 0x00246D85
		public virtual IClientEventFlyingFlowerUpdateSubtitle EventType
		{
			get
			{
				if (this._EventTypeInited)
				{
					return this._EventTypeCache;
				}
				this._EventTypeInited = true;
				this._EventTypeCache = IClientEventFlyingFlowerUpdateSubtitle.Create(this.Instance.EventType);
				return this._EventTypeCache;
			}
		}

		// Token: 0x04008A0E RID: 35342
		private IClientEventUiFlyingFlower Instance;

		// Token: 0x04008A0F RID: 35343
		[Nullable(2)]
		private IClientEventFlyingFlowerUpdateSubtitle _EventTypeCache;

		// Token: 0x04008A10 RID: 35344
		private bool _EventTypeInited;
	}
}
