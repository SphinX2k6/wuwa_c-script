using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002420 RID: 9248
	public class SetExploreState : ActionParams
	{
		// Token: 0x0600C934 RID: 51508 RVA: 0x001CBAA4 File Offset: 0x001C9CA4
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

		// Token: 0x0600C935 RID: 51509 RVA: 0x001CBADC File Offset: 0x001C9CDC
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

		// Token: 0x0600C936 RID: 51510 RVA: 0x001CBAEF File Offset: 0x001C9CEF
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

		// Token: 0x0600C937 RID: 51511 RVA: 0x001CBB02 File Offset: 0x001C9D02
		public SetExploreState_SetValue ToSetValue()
		{
			return new SetExploreState_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600C938 RID: 51512 RVA: 0x001CBB18 File Offset: 0x001C9D18
		// (set) Token: 0x0600C939 RID: 51513 RVA: 0x001CBB79 File Offset: 0x001C9D79
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

		// Token: 0x04007751 RID: 30545
		[Nullable(2)]
		protected new SetExploreState FbInstance;

		// Token: 0x04007752 RID: 30546
		[Nullable(2)]
		protected SetExploreState_SetValue PocoInterface;

		// Token: 0x04007753 RID: 30547
		private ITeleControlConfig _ConfigCache;

		// Token: 0x04007754 RID: 30548
		private bool _ConfigInited;
	}
}
