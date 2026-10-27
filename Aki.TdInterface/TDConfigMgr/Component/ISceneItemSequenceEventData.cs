using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006AA RID: 1706
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemSequenceEventData
	{
		// Token: 0x06002492 RID: 9362 RVA: 0x00063074 File Offset: 0x00061274
		private ISceneItemSequenceEventData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemSequenceEventData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemSequenceEventData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemSequenceEventData_SetValue());
			}
			return result;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x000630AC File Offset: 0x000612AC
		public static ISceneItemSequenceEventData Create([Nullable(2)] ISceneItemSequenceEventData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSequenceEventData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x000630BF File Offset: 0x000612BF
		public static ISceneItemSequenceEventData CreateFromSetValue([Nullable(2)] ISceneItemSequenceEventData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemSequenceEventData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x000630D2 File Offset: 0x000612D2
		public ISceneItemSequenceEventData_SetValue ToSetValue()
		{
			return new ISceneItemSequenceEventData_SetValue
			{
				SeqGuid = this.SeqGuid,
				SeqPath = this.SeqPath,
				EventCallbacks = this.EventCallbacks
			};
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x000630FD File Offset: 0x000612FD
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x00063128 File Offset: 0x00061328
		public virtual string SeqGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqGuid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SeqGuid;
			}
			set
			{
				this.GetOrCreatePoco().SeqGuid = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x00063136 File Offset: 0x00061336
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x00063161 File Offset: 0x00061361
		public virtual string SeqPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SeqPath;
			}
			set
			{
				this.GetOrCreatePoco().SeqPath = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0006316F File Offset: 0x0006136F
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x00063196 File Offset: 0x00061396
		public virtual List<ISceneItemSeqEventCbType> EventCallbacks
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventCallbacks;
				}
				ISceneItemSequenceEventData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EventCallbacks;
			}
			set
			{
				this.GetOrCreatePoco().EventCallbacks = value;
			}
		}

		// Token: 0x04001919 RID: 6425
		[Nullable(2)]
		protected ISceneItemSequenceEventData FbInstance;

		// Token: 0x0400191A RID: 6426
		[Nullable(2)]
		protected ISceneItemSequenceEventData_SetValue PocoInterface;
	}
}
