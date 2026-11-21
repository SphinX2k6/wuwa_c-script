using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C3 RID: 1475
	public class INpcDefaultPerform
	{
		// Token: 0x06001E0C RID: 7692 RVA: 0x00055738 File Offset: 0x00053938
		private INpcDefaultPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcDefaultPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcDefaultPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcDefaultPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00055770 File Offset: 0x00053970
		public static INpcDefaultPerform Create([Nullable(2)] INpcDefaultPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDefaultPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00055783 File Offset: 0x00053983
		public static INpcDefaultPerform CreateFromSetValue([Nullable(2)] INpcDefaultPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcDefaultPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00055796 File Offset: 0x00053996
		public INpcDefaultPerform_SetValue ToSetValue()
		{
			return new INpcDefaultPerform_SetValue
			{
				BuffEffectIds = this.BuffEffectIds
			};
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000557A9 File Offset: 0x000539A9
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x000557D0 File Offset: 0x000539D0
		[Nullable(2)]
		public virtual List<int> BuffEffectIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffEffectIds;
				}
				INpcDefaultPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BuffEffectIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BuffEffectIds = value;
			}
		}

		// Token: 0x04001583 RID: 5507
		[Nullable(2)]
		protected INpcDefaultPerform FbInstance;

		// Token: 0x04001584 RID: 5508
		[Nullable(2)]
		protected INpcDefaultPerform_SetValue PocoInterface;
	}
}
