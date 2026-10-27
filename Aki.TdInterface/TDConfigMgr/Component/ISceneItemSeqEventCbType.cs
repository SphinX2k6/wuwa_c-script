using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A8 RID: 1704
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemSeqEventCbType
	{
		// Token: 0x06002486 RID: 9350 RVA: 0x00062EF0 File Offset: 0x000610F0
		private ISceneItemSeqEventCbType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemSeqEventCbType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemSeqEventCbType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemSeqEventCbType_SetValue());
			}
			return result;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00062F28 File Offset: 0x00061128
		public static ISceneItemSeqEventCbType Create([Nullable(2)] ISceneItemSeqEventCbType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSeqEventCbType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00062F3B File Offset: 0x0006113B
		public static ISceneItemSeqEventCbType CreateFromSetValue([Nullable(2)] ISceneItemSeqEventCbType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemSeqEventCbType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00062F4E File Offset: 0x0006114E
		public ISceneItemSeqEventCbType_SetValue ToSetValue()
		{
			return new ISceneItemSeqEventCbType_SetValue
			{
				Type = this.Type,
				EventName = this.EventName,
				Action = this.Action
			};
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x00062F79 File Offset: 0x00061179
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00062FA4 File Offset: 0x000611A4
		public virtual ESceneItemSeqEventCbType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneItemSeqEventCbType.ANS;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x00062FB2 File Offset: 0x000611B2
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x00062FDD File Offset: 0x000611DD
		public virtual string EventName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EventName;
			}
			set
			{
				this.GetOrCreatePoco().EventName = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00062FEC File Offset: 0x000611EC
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0006304D File Offset: 0x0006124D
		public virtual ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				if (this.FbInstance != null)
				{
					this._ActionCache = ActionInfo.Create(this.FbInstance.Action);
				}
				else
				{
					ISceneItemSeqEventCbType_SetValue pocoInterface = this.PocoInterface;
					this._ActionCache = ((pocoInterface != null) ? pocoInterface.Action : null);
				}
				return this._ActionCache;
			}
			set
			{
				this.GetOrCreatePoco().Action = value;
				this._ActionInited = false;
			}
		}

		// Token: 0x04001912 RID: 6418
		[Nullable(2)]
		protected ISceneItemSeqEventCbType FbInstance;

		// Token: 0x04001913 RID: 6419
		[Nullable(2)]
		protected ISceneItemSeqEventCbType_SetValue PocoInterface;

		// Token: 0x04001914 RID: 6420
		private ActionInfo _ActionCache;

		// Token: 0x04001915 RID: 6421
		private bool _ActionInited;
	}
}
