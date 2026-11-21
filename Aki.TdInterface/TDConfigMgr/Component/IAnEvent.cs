using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E2 RID: 482
	public class IAnEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x000256D8 File Offset: 0x000238D8
		private IAnEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAnEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAnEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAnEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00025710 File Offset: 0x00023910
		public static IAnEvent Create([Nullable(2)] IAnEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00025723 File Offset: 0x00023923
		public static IAnEvent CreateFromSetValue([Nullable(2)] IAnEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAnEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00025736 File Offset: 0x00023936
		public new IAnEvent_SetValue ToSetValue()
		{
			return new IAnEvent_SetValue
			{
				Type = this.Type,
				EventName = this.EventName,
				Action = this.Action
			};
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00025761 File Offset: 0x00023961
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0002578C File Offset: 0x0002398C
		public override ESceneItemSeqEventCbType Type
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0002579A File Offset: 0x0002399A
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000257C5 File Offset: 0x000239C5
		public override string EventName
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000257D4 File Offset: 0x000239D4
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00025835 File Offset: 0x00023A35
		public override ActionInfo Action
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
					IAnEvent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040008E3 RID: 2275
		[Nullable(2)]
		protected new IAnEvent FbInstance;

		// Token: 0x040008E4 RID: 2276
		[Nullable(2)]
		protected new IAnEvent_SetValue PocoInterface;

		// Token: 0x040008E5 RID: 2277
		private ActionInfo _ActionCache;

		// Token: 0x040008E6 RID: 2278
		private bool _ActionInited;
	}
}
