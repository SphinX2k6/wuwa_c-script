using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000743 RID: 1859
	public class ISceneItemEventConfig
	{
		// Token: 0x06002780 RID: 10112 RVA: 0x000699F4 File Offset: 0x00067BF4
		private ISceneItemEventConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemEventConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemEventConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemEventConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00069A2C File Offset: 0x00067C2C
		public static ISceneItemEventConfig Create([Nullable(2)] ISceneItemEventConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemEventConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00069A3F File Offset: 0x00067C3F
		public static ISceneItemEventConfig CreateFromSetValue([Nullable(2)] ISceneItemEventConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemEventConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00069A52 File Offset: 0x00067C52
		public ISceneItemEventConfig_SetValue ToSetValue()
		{
			return new ISceneItemEventConfig_SetValue
			{
				EntityStateTagName = this.EntityStateTagName,
				SequenceEvents = this.SequenceEvents
			};
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00069A71 File Offset: 0x00067C71
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x00069A9C File Offset: 0x00067C9C
		public virtual string EntityStateTagName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityStateTagName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityStateTagName;
			}
			set
			{
				this.GetOrCreatePoco().EntityStateTagName = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x00069AAC File Offset: 0x00067CAC
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x00069B3F File Offset: 0x00067D3F
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
				if (this.FbInstance != null)
				{
					List<ISceneItemSequenceEventData> sequenceEvents = this.FbInstance.SequenceEvents;
					if (sequenceEvents != null)
					{
						this._SequenceEventsCache = new List<ISceneItemSequenceEventData>(sequenceEvents.Count);
						for (int i = 0; i < sequenceEvents.Count; i++)
						{
							this._SequenceEventsCache.Add(ISceneItemSequenceEventData.Create(sequenceEvents[i]));
						}
					}
				}
				else
				{
					ISceneItemEventConfig_SetValue pocoInterface = this.PocoInterface;
					this._SequenceEventsCache = ((pocoInterface != null) ? pocoInterface.SequenceEvents : null);
				}
				return this._SequenceEventsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().SequenceEvents = value;
				this._SequenceEventsInited = false;
			}
		}

		// Token: 0x04001AF9 RID: 6905
		[Nullable(2)]
		protected ISceneItemEventConfig FbInstance;

		// Token: 0x04001AFA RID: 6906
		[Nullable(2)]
		protected ISceneItemEventConfig_SetValue PocoInterface;

		// Token: 0x04001AFB RID: 6907
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ISceneItemSequenceEventData> _SequenceEventsCache;

		// Token: 0x04001AFC RID: 6908
		private bool _SequenceEventsInited;
	}
}
