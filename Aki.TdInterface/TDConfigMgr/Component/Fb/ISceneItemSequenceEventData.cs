using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA9 RID: 3497
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemSequenceEventData
	{
		// Token: 0x06004F76 RID: 20342 RVA: 0x000C4CA1 File Offset: 0x000C2EA1
		public static ISceneItemSequenceEventData Create(ISceneItemSequenceEventData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSequenceEventData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x000C4CC0 File Offset: 0x000C2EC0
		public virtual string SeqGuid
		{
			get
			{
				return this.Instance.SeqGuid;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x000C4CCD File Offset: 0x000C2ECD
		public virtual string SeqPath
		{
			get
			{
				return this.Instance.SeqPath;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x000C4CDA File Offset: 0x000C2EDA
		public virtual List<ISceneItemSeqEventCbType> EventCallbacks
		{
			get
			{
				if (this._EventCallbacksInited)
				{
					return this._EventCallbacksCache;
				}
				this._EventCallbacksInited = true;
				this._EventCallbacksCache = ComponentReadHelper.ReadISceneItemSequenceEventData_EventCallbacks(this.Instance);
				return this._EventCallbacksCache;
			}
		}

		// Token: 0x04002D98 RID: 11672
		private ISceneItemSequenceEventData Instance;

		// Token: 0x04002D99 RID: 11673
		private List<ISceneItemSeqEventCbType> _EventCallbacksCache;

		// Token: 0x04002D9A RID: 11674
		private bool _EventCallbacksInited;
	}
}
