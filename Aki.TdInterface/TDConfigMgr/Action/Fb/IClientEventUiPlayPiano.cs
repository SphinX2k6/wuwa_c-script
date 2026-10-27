using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A44 RID: 10820
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventUiPlayPiano : IClientEventUi
	{
		// Token: 0x0600EE35 RID: 60981 RVA: 0x0022B0A6 File Offset: 0x002292A6
		public static IClientEventUiPlayPiano Create(IClientEventUiPlayPiano? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUiPlayPiano
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x0022B0C5 File Offset: 0x002292C5
		public override EClientEventUiType Type
		{
			get
			{
				return (EClientEventUiType)this.Instance.Type;
			}
		}

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x0600EE37 RID: 60983 RVA: 0x0022B0D2 File Offset: 0x002292D2
		public virtual IClientEventPianoEvent EventType
		{
			get
			{
				if (this._EventTypeInited)
				{
					return this._EventTypeCache;
				}
				this._EventTypeInited = true;
				this._EventTypeCache = ActionReadHelper.ReadIClientEventUiPlayPiano_EventType(this.Instance);
				return this._EventTypeCache;
			}
		}

		// Token: 0x04008314 RID: 33556
		private IClientEventUiPlayPiano Instance;

		// Token: 0x04008315 RID: 33557
		private IClientEventPianoEvent _EventTypeCache;

		// Token: 0x04008316 RID: 33558
		private bool _EventTypeInited;
	}
}
