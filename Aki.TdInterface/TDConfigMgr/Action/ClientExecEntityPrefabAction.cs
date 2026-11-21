using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001656 RID: 5718
	public class ClientExecEntityPrefabAction : ActionParams
	{
		// Token: 0x060080F1 RID: 33009 RVA: 0x00132954 File Offset: 0x00130B54
		private ClientExecEntityPrefabAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientExecEntityPrefabAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientExecEntityPrefabAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientExecEntityPrefabAction_SetValue());
			}
			return result;
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x0013298C File Offset: 0x00130B8C
		public static ClientExecEntityPrefabAction Create([Nullable(2)] ClientExecEntityPrefabAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientExecEntityPrefabAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x0013299F File Offset: 0x00130B9F
		public static ClientExecEntityPrefabAction CreateFromSetValue([Nullable(2)] ClientExecEntityPrefabAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientExecEntityPrefabAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x001329B2 File Offset: 0x00130BB2
		public ClientExecEntityPrefabAction_SetValue ToSetValue()
		{
			return new ClientExecEntityPrefabAction_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x060080F5 RID: 33013 RVA: 0x001329C8 File Offset: 0x00130BC8
		// (set) Token: 0x060080F6 RID: 33014 RVA: 0x00132A29 File Offset: 0x00130C29
		public virtual IClientModifyEntityPrefabParams Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IClientModifyEntityPrefabParams.Create(this.FbInstance.Option);
				}
				else
				{
					ClientExecEntityPrefabAction_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x04004A63 RID: 19043
		[Nullable(2)]
		protected new ClientExecEntityPrefabAction FbInstance;

		// Token: 0x04004A64 RID: 19044
		[Nullable(2)]
		protected ClientExecEntityPrefabAction_SetValue PocoInterface;

		// Token: 0x04004A65 RID: 19045
		private IClientModifyEntityPrefabParams _OptionCache;

		// Token: 0x04004A66 RID: 19046
		private bool _OptionInited;
	}
}
