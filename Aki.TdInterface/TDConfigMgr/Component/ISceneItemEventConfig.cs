using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A2 RID: 1698
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemEventConfig
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x00062A2C File Offset: 0x00060C2C
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

		// Token: 0x06002465 RID: 9317 RVA: 0x00062A64 File Offset: 0x00060C64
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

		// Token: 0x06002466 RID: 9318 RVA: 0x00062A77 File Offset: 0x00060C77
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

		// Token: 0x06002467 RID: 9319 RVA: 0x00062A8A File Offset: 0x00060C8A
		public ISceneItemEventConfig_SetValue ToSetValue()
		{
			return new ISceneItemEventConfig_SetValue
			{
				EntityStateTagName = this.EntityStateTagName,
				SequenceEvents = this.SequenceEvents
			};
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x00062AA9 File Offset: 0x00060CA9
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x00062AD4 File Offset: 0x00060CD4
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

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x00062AE4 File Offset: 0x00060CE4
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x00062B77 File Offset: 0x00060D77
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().SequenceEvents = value;
				this._SequenceEventsInited = false;
			}
		}

		// Token: 0x040018FC RID: 6396
		[Nullable(2)]
		protected ISceneItemEventConfig FbInstance;

		// Token: 0x040018FD RID: 6397
		[Nullable(2)]
		protected ISceneItemEventConfig_SetValue PocoInterface;

		// Token: 0x040018FE RID: 6398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISceneItemSequenceEventData> _SequenceEventsCache;

		// Token: 0x040018FF RID: 6399
		private bool _SequenceEventsInited;
	}
}
