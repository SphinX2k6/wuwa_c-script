using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E65 RID: 7781
	public class INpcGroupSequenceBindingBase
	{
		// Token: 0x0600A56B RID: 42347 RVA: 0x00179544 File Offset: 0x00177744
		private INpcGroupSequenceBindingBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupSequenceBindingBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupSequenceBindingBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupSequenceBindingBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x0017957C File Offset: 0x0017777C
		public static INpcGroupSequenceBindingBase Create([Nullable(2)] INpcGroupSequenceBindingBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceBindingBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x0017958F File Offset: 0x0017778F
		public static INpcGroupSequenceBindingBase CreateFromSetValue([Nullable(2)] INpcGroupSequenceBindingBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupSequenceBindingBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x001795A2 File Offset: 0x001777A2
		public INpcGroupSequenceBindingBase_SetValue ToSetValue()
		{
			return new INpcGroupSequenceBindingBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600A56F RID: 42351 RVA: 0x001795B5 File Offset: 0x001777B5
		// (set) Token: 0x0600A570 RID: 42352 RVA: 0x001795E0 File Offset: 0x001777E0
		public virtual ENpcGroupSequenceBindingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupSequenceBindingType.StaticEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063E9 RID: 25577
		[Nullable(2)]
		protected INpcGroupSequenceBindingBase FbInstance;

		// Token: 0x040063EA RID: 25578
		[Nullable(2)]
		protected INpcGroupSequenceBindingBase_SetValue PocoInterface;
	}
}
