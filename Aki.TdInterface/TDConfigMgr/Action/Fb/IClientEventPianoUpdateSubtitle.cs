using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D2F RID: 11567
	public class IClientEventPianoUpdateSubtitle : IClientEventPianoEvent
	{
		// Token: 0x0600FCC5 RID: 64709 RVA: 0x002489B1 File Offset: 0x00246BB1
		public static IClientEventPianoUpdateSubtitle Create(IClientEventPianoUpdateSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoUpdateSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x0600FCC6 RID: 64710 RVA: 0x002489D0 File Offset: 0x00246BD0
		public override EClientEventPianoEventType Type
		{
			get
			{
				return (EClientEventPianoEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x0600FCC7 RID: 64711 RVA: 0x002489DD File Offset: 0x00246BDD
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

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x0600FCC8 RID: 64712 RVA: 0x00248A11 File Offset: 0x00246C11
		public virtual bool DisableMove
		{
			get
			{
				return this.Instance.DisableMove;
			}
		}

		// Token: 0x04008A03 RID: 35331
		private IClientEventPianoUpdateSubtitle Instance;

		// Token: 0x04008A04 RID: 35332
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008A05 RID: 35333
		private bool _FlowInited;
	}
}
