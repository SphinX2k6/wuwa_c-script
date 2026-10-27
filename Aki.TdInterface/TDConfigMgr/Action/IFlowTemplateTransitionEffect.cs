using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA1 RID: 6817
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTemplateTransitionEffect
	{
		// Token: 0x06009236 RID: 37430 RVA: 0x0015404C File Offset: 0x0015224C
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

		// Token: 0x06009237 RID: 37431 RVA: 0x00154084 File Offset: 0x00152284
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

		// Token: 0x06009238 RID: 37432 RVA: 0x00154097 File Offset: 0x00152297
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

		// Token: 0x06009239 RID: 37433 RVA: 0x001540AA File Offset: 0x001522AA
		public IFlowTemplateTransitionEffect_SetValue ToSetValue()
		{
			return new IFlowTemplateTransitionEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600923A RID: 37434 RVA: 0x001540BD File Offset: 0x001522BD
		// (set) Token: 0x0600923B RID: 37435 RVA: 0x001540E8 File Offset: 0x001522E8
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

		// Token: 0x04005A0E RID: 23054
		[Nullable(2)]
		protected IFlowTemplateTransitionEffect FbInstance;

		// Token: 0x04005A0F RID: 23055
		[Nullable(2)]
		protected IFlowTemplateTransitionEffect_SetValue PocoInterface;
	}
}
