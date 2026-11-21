using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD8 RID: 7384
	public class IInfrActivityBuildStageOption
	{
		// Token: 0x06009CC0 RID: 40128 RVA: 0x00169308 File Offset: 0x00167508
		private IInfrActivityBuildStageOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrActivityBuildStageOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrActivityBuildStageOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrActivityBuildStageOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x00169340 File Offset: 0x00167540
		public static IInfrActivityBuildStageOption Create([Nullable(2)] IInfrActivityBuildStageOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityBuildStageOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x00169353 File Offset: 0x00167553
		public static IInfrActivityBuildStageOption CreateFromSetValue([Nullable(2)] IInfrActivityBuildStageOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrActivityBuildStageOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x00169366 File Offset: 0x00167566
		public IInfrActivityBuildStageOption_SetValue ToSetValue()
		{
			return new IInfrActivityBuildStageOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x00169379 File Offset: 0x00167579
		// (set) Token: 0x06009CC5 RID: 40133 RVA: 0x001693A4 File Offset: 0x001675A4
		public virtual EInfrActivityBuildStageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FC8 RID: 24520
		[Nullable(2)]
		protected IInfrActivityBuildStageOption FbInstance;

		// Token: 0x04005FC9 RID: 24521
		[Nullable(2)]
		protected IInfrActivityBuildStageOption_SetValue PocoInterface;
	}
}
