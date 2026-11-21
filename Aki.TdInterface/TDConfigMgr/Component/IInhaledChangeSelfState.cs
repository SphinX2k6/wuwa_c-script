using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B5 RID: 1205
	public class IInhaledChangeSelfState : IInhaledPerResultType
	{
		// Token: 0x06001827 RID: 6183 RVA: 0x000494A8 File Offset: 0x000476A8
		private IInhaledChangeSelfState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhaledChangeSelfState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhaledChangeSelfState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhaledChangeSelfState_SetValue());
			}
			return result;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000494E0 File Offset: 0x000476E0
		public static IInhaledChangeSelfState Create([Nullable(2)] IInhaledChangeSelfState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledChangeSelfState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000494F3 File Offset: 0x000476F3
		public static IInhaledChangeSelfState CreateFromSetValue([Nullable(2)] IInhaledChangeSelfState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhaledChangeSelfState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00049506 File Offset: 0x00047706
		public new IInhaledChangeSelfState_SetValue ToSetValue()
		{
			return new IInhaledChangeSelfState_SetValue
			{
				Type = this.Type,
				ChangeSelfState = this.ChangeSelfState
			};
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00049525 File Offset: 0x00047725
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00049550 File Offset: 0x00047750
		public override EInhaledPerResultType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0004955E File Offset: 0x0004775E
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00049589 File Offset: 0x00047789
		public virtual string ChangeSelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ChangeSelfState;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfState = value;
			}
		}

		// Token: 0x0400124F RID: 4687
		[Nullable(2)]
		protected new IInhaledChangeSelfState FbInstance;

		// Token: 0x04001250 RID: 4688
		[Nullable(2)]
		protected new IInhaledChangeSelfState_SetValue PocoInterface;
	}
}
