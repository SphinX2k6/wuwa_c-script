using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D63 RID: 7523
	public class ILiveLikeParam : ILiveParamConfig
	{
		// Token: 0x06009FBF RID: 40895 RVA: 0x0016EAE0 File Offset: 0x0016CCE0
		private ILiveLikeParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveLikeParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveLikeParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveLikeParam_SetValue());
			}
			return result;
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x0016EB18 File Offset: 0x0016CD18
		public static ILiveLikeParam Create([Nullable(2)] ILiveLikeParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveLikeParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x0016EB2B File Offset: 0x0016CD2B
		public static ILiveLikeParam CreateFromSetValue([Nullable(2)] ILiveLikeParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveLikeParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x0016EB3E File Offset: 0x0016CD3E
		public new ILiveLikeParam_SetValue ToSetValue()
		{
			return new ILiveLikeParam_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x0016EB5D File Offset: 0x0016CD5D
		// (set) Token: 0x06009FC4 RID: 40900 RVA: 0x0016EB88 File Offset: 0x0016CD88
		public override ELiveParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveParamType.Heat;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x0016EB96 File Offset: 0x0016CD96
		// (set) Token: 0x06009FC6 RID: 40902 RVA: 0x0016EBC1 File Offset: 0x0016CDC1
		public virtual ELiveLikeState State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return ELiveLikeState.Enable;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04006130 RID: 24880
		[Nullable(2)]
		protected new ILiveLikeParam FbInstance;

		// Token: 0x04006131 RID: 24881
		[Nullable(2)]
		protected new ILiveLikeParam_SetValue PocoInterface;
	}
}
