using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C3A RID: 7226
	public class IFlowTemplateTransitionEffect
	{
		// Token: 0x060099B6 RID: 39350 RVA: 0x00164238 File Offset: 0x00162438
		private IFlowTemplateTransitionEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTemplateTransitionEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTemplateTransitionEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTemplateTransitionEffect_SetValue());
			}
			return result;
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x00164270 File Offset: 0x00162470
		public static IFlowTemplateTransitionEffect Create([Nullable(2)] IFlowTemplateTransitionEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateTransitionEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x00164283 File Offset: 0x00162483
		public static IFlowTemplateTransitionEffect CreateFromSetValue([Nullable(2)] IFlowTemplateTransitionEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTemplateTransitionEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x00164296 File Offset: 0x00162496
		public IFlowTemplateTransitionEffect_SetValue ToSetValue()
		{
			return new IFlowTemplateTransitionEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x001642A9 File Offset: 0x001624A9
		// (set) Token: 0x060099BB RID: 39355 RVA: 0x001642D4 File Offset: 0x001624D4
		public virtual EFlowTemplateTransitionEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFlowTemplateTransitionEffectType.Blur;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E7E RID: 24190
		[Nullable(2)]
		protected IFlowTemplateTransitionEffect FbInstance;

		// Token: 0x04005E7F RID: 24191
		[Nullable(2)]
		protected IFlowTemplateTransitionEffect_SetValue PocoInterface;
	}
}
