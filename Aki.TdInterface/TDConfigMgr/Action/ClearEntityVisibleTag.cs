using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014F6 RID: 5366
	[NullableContext(1)]
	[Nullable(0)]
	public class ClearEntityVisibleTag : ActionParams
	{
		// Token: 0x06007A08 RID: 31240 RVA: 0x00123A80 File Offset: 0x00121C80
		private ClearEntityVisibleTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClearEntityVisibleTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClearEntityVisibleTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClearEntityVisibleTag_SetValue());
			}
			return result;
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x00123AB8 File Offset: 0x00121CB8
		public static ClearEntityVisibleTag Create([Nullable(2)] ClearEntityVisibleTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearEntityVisibleTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00123ACB File Offset: 0x00121CCB
		public static ClearEntityVisibleTag CreateFromSetValue([Nullable(2)] ClearEntityVisibleTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClearEntityVisibleTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00123ADE File Offset: 0x00121CDE
		public ClearEntityVisibleTag_SetValue ToSetValue()
		{
			return new ClearEntityVisibleTag_SetValue
			{
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x00123AF1 File Offset: 0x00121CF1
		// (set) Token: 0x06007A0D RID: 31245 RVA: 0x00123B18 File Offset: 0x00121D18
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				ClearEntityVisibleTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040046BD RID: 18109
		[Nullable(2)]
		protected new ClearEntityVisibleTag FbInstance;

		// Token: 0x040046BE RID: 18110
		[Nullable(2)]
		protected ClearEntityVisibleTag_SetValue PocoInterface;
	}
}
