using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA6 RID: 3750
	public class ISceneItemEventConfig
	{
		// Token: 0x060054A0 RID: 21664 RVA: 0x000D0561 File Offset: 0x000CE761
		public static ISceneItemEventConfig Create(ISceneItemEventConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemEventConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x000D0580 File Offset: 0x000CE780
		public virtual string EntityStateTagName
		{
			get
			{
				return this.Instance.EntityStateTagName;
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x000D0590 File Offset: 0x000CE790
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ISceneItemSequenceEventData> SequenceEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._SequenceEventsInited)
				{
					return this._SequenceEventsCache;
				}
				this._SequenceEventsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int sequenceEventsLength = this.Instance.SequenceEventsLength;
				this._SequenceEventsCache = new List<ISceneItemSequenceEventData>(sequenceEventsLength);
				for (int i = 0; i < sequenceEventsLength; i++)
				{
					this._SequenceEventsCache.Add(ISceneItemSequenceEventData.Create(this.Instance.SequenceEvents(i)));
				}
				return this._SequenceEventsCache;
			}
		}

		// Token: 0x04003061 RID: 12385
		private ISceneItemEventConfig Instance;

		// Token: 0x04003062 RID: 12386
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ISceneItemSequenceEventData> _SequenceEventsCache;

		// Token: 0x04003063 RID: 12387
		private bool _SequenceEventsInited;
	}
}
