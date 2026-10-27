using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A42 RID: 10818
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventPianoUpdateSubtitle : IClientEventPianoEvent
	{
		// Token: 0x0600EE2D RID: 60973 RVA: 0x0022AFFD File Offset: 0x002291FD
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

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x0600EE2E RID: 60974 RVA: 0x0022B01C File Offset: 0x0022921C
		public override EClientEventPianoEventType Type
		{
			get
			{
				return (EClientEventPianoEventType)this.Instance.Type;
			}
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x0600EE2F RID: 60975 RVA: 0x0022B029 File Offset: 0x00229229
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

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x0600EE30 RID: 60976 RVA: 0x0022B05D File Offset: 0x0022925D
		public virtual bool DisableMove
		{
			get
			{
				return this.Instance.DisableMove;
			}
		}

		// Token: 0x04008310 RID: 33552
		private IClientEventPianoUpdateSubtitle Instance;

		// Token: 0x04008311 RID: 33553
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008312 RID: 33554
		private bool _FlowInited;
	}
}
