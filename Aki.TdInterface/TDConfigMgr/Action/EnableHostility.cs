using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200163E RID: 5694
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableHostility : ActionParams
	{
		// Token: 0x06007C55 RID: 31829 RVA: 0x0012B074 File Offset: 0x00129274
		private EnableHostility_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableHostility 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableHostility_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableHostility_SetValue());
			}
			return result;
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x0012B0AC File Offset: 0x001292AC
		public static EnableHostility Create([Nullable(2)] EnableHostility instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableHostility
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x0012B0BF File Offset: 0x001292BF
		public static EnableHostility CreateFromSetValue([Nullable(2)] EnableHostility_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableHostility
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x0012B0D2 File Offset: 0x001292D2
		public EnableHostility_SetValue ToSetValue()
		{
			return new EnableHostility_SetValue
			{
				IsEnable = this.IsEnable,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x0012B0F1 File Offset: 0x001292F1
		// (set) Token: 0x06007C5A RID: 31834 RVA: 0x0012B11C File Offset: 0x0012931C
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x06007C5B RID: 31835 RVA: 0x0012B12A File Offset: 0x0012932A
		// (set) Token: 0x06007C5C RID: 31836 RVA: 0x0012B151 File Offset: 0x00129351
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				EnableHostility_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04004C62 RID: 19554
		[Nullable(2)]
		protected new EnableHostility FbInstance;

		// Token: 0x04004C63 RID: 19555
		[Nullable(2)]
		protected EnableHostility_SetValue PocoInterface;
	}
}
