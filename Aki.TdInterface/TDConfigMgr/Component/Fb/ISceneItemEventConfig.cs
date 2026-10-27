using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAA RID: 3498
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemEventConfig
	{
		// Token: 0x06004F7B RID: 20347 RVA: 0x000C4D11 File Offset: 0x000C2F11
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

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06004F7C RID: 20348 RVA: 0x000C4D30 File Offset: 0x000C2F30
		public virtual string EntityStateTagName
		{
			get
			{
				return this.Instance.EntityStateTagName;
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x000C4D40 File Offset: 0x000C2F40
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ISceneItemSequenceEventData> SequenceEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002D9B RID: 11675
		private ISceneItemEventConfig Instance;

		// Token: 0x04002D9C RID: 11676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISceneItemSequenceEventData> _SequenceEventsCache;

		// Token: 0x04002D9D RID: 11677
		private bool _SequenceEventsInited;
	}
}
