using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D2 RID: 8402
	public class ISpecialCustomLoadingOption
	{
		// Token: 0x0600B266 RID: 45670 RVA: 0x00190AFC File Offset: 0x0018ECFC
		private ISpecialCustomLoadingOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialCustomLoadingOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialCustomLoadingOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialCustomLoadingOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x00190B34 File Offset: 0x0018ED34
		public static ISpecialCustomLoadingOption Create([Nullable(2)] ISpecialCustomLoadingOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialCustomLoadingOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x00190B47 File Offset: 0x0018ED47
		public static ISpecialCustomLoadingOption CreateFromSetValue([Nullable(2)] ISpecialCustomLoadingOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialCustomLoadingOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x00190B5A File Offset: 0x0018ED5A
		public ISpecialCustomLoadingOption_SetValue ToSetValue()
		{
			return new ISpecialCustomLoadingOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x00190B6D File Offset: 0x0018ED6D
		// (set) Token: 0x0600B26B RID: 45675 RVA: 0x00190B98 File Offset: 0x0018ED98
		public virtual ESpecialCustomLoadingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialCustomLoadingType.HonamiStory;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040069E0 RID: 27104
		[Nullable(2)]
		protected ISpecialCustomLoadingOption FbInstance;

		// Token: 0x040069E1 RID: 27105
		[Nullable(2)]
		protected ISpecialCustomLoadingOption_SetValue PocoInterface;
	}
}
