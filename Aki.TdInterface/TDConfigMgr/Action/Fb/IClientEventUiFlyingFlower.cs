using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A47 RID: 10823
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventUiFlyingFlower : IClientEventUi
	{
		// Token: 0x0600EE40 RID: 60992 RVA: 0x0022B1A5 File Offset: 0x002293A5
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

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x0600EE41 RID: 60993 RVA: 0x0022B1C4 File Offset: 0x002293C4
		public override EClientEventUiType Type
		{
			get
			{
				return (EClientEventUiType)this.Instance.Type;
			}
		}

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x0600EE42 RID: 60994 RVA: 0x0022B1D1 File Offset: 0x002293D1
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

		// Token: 0x0400831B RID: 33563
		private IClientEventUiFlyingFlower Instance;

		// Token: 0x0400831C RID: 33564
		[Nullable(2)]
		private IClientEventFlyingFlowerUpdateSubtitle _EventTypeCache;

		// Token: 0x0400831D RID: 33565
		private bool _EventTypeInited;
	}
}
