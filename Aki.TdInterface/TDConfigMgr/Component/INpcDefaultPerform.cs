using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200055C RID: 1372
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDefaultPerform
	{
		// Token: 0x06001C10 RID: 7184 RVA: 0x0005097C File Offset: 0x0004EB7C
		[NullableContext(1)]
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

		// Token: 0x06001C11 RID: 7185 RVA: 0x000509B4 File Offset: 0x0004EBB4
		[NullableContext(1)]
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

		// Token: 0x06001C12 RID: 7186 RVA: 0x000509C7 File Offset: 0x0004EBC7
		[NullableContext(1)]
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

		// Token: 0x06001C13 RID: 7187 RVA: 0x000509DA File Offset: 0x0004EBDA
		[NullableContext(1)]
		public INpcDefaultPerform_SetValue ToSetValue()
		{
			return new INpcDefaultPerform_SetValue
			{
				BuffEffectIds = this.BuffEffectIds
			};
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000509ED File Offset: 0x0004EBED
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x00050A14 File Offset: 0x0004EC14
		public virtual List<int> BuffEffectIds
		{
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
			set
			{
				this.GetOrCreatePoco().BuffEffectIds = value;
			}
		}

		// Token: 0x04001419 RID: 5145
		protected INpcDefaultPerform FbInstance;

		// Token: 0x0400141A RID: 5146
		protected INpcDefaultPerform_SetValue PocoInterface;
	}
}
