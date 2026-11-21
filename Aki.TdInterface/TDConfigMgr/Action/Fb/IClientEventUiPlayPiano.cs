using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D31 RID: 11569
	public class IClientEventUiPlayPiano : IClientEventUi
	{
		// Token: 0x0600FCCD RID: 64717 RVA: 0x00248A5A File Offset: 0x00246C5A
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

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x0600FCCE RID: 64718 RVA: 0x00248A79 File Offset: 0x00246C79
		public override EClientEventUiType Type
		{
			get
			{
				return (EClientEventUiType)this.Instance.Type;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x0600FCCF RID: 64719 RVA: 0x00248A86 File Offset: 0x00246C86
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

		// Token: 0x04008A07 RID: 35335
		private IClientEventUiPlayPiano Instance;

		// Token: 0x04008A08 RID: 35336
		private IClientEventPianoEvent _EventTypeCache;

		// Token: 0x04008A09 RID: 35337
		private bool _EventTypeInited;
	}
}
