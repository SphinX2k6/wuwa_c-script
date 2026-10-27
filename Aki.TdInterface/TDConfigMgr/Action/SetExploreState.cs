using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B5 RID: 8629
	[NullableContext(1)]
	[Nullable(0)]
	public class SetExploreState : ActionParams
	{
		// Token: 0x0600BD7A RID: 48506 RVA: 0x001B446C File Offset: 0x001B266C
		private SetExploreState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetExploreState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetExploreState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetExploreState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x001B44A4 File Offset: 0x001B26A4
		public static SetExploreState Create([Nullable(2)] SetExploreState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetExploreState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD7C RID: 48508 RVA: 0x001B44B7 File Offset: 0x001B26B7
		public static SetExploreState CreateFromSetValue([Nullable(2)] SetExploreState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetExploreState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD7D RID: 48509 RVA: 0x001B44CA File Offset: 0x001B26CA
		public SetExploreState_SetValue ToSetValue()
		{
			return new SetExploreState_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600BD7E RID: 48510 RVA: 0x001B44E0 File Offset: 0x001B26E0
		// (set) Token: 0x0600BD7F RID: 48511 RVA: 0x001B4541 File Offset: 0x001B2741
		public virtual ITeleControlConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = ITeleControlConfig.Create(this.FbInstance.Config);
				}
				else
				{
					SetExploreState_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04007109 RID: 28937
		[Nullable(2)]
		protected new SetExploreState FbInstance;

		// Token: 0x0400710A RID: 28938
		[Nullable(2)]
		protected SetExploreState_SetValue PocoInterface;

		// Token: 0x0400710B RID: 28939
		private ITeleControlConfig _ConfigCache;

		// Token: 0x0400710C RID: 28940
		private bool _ConfigInited;
	}
}
