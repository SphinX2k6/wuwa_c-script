using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001632 RID: 5682
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableAI : ActionParams
	{
		// Token: 0x06007C19 RID: 31769 RVA: 0x0012AA00 File Offset: 0x00128C00
		private EnableAI_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableAI 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableAI_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableAI_SetValue());
			}
			return result;
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x0012AA38 File Offset: 0x00128C38
		public static EnableAI Create([Nullable(2)] EnableAI instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAI
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x0012AA4B File Offset: 0x00128C4B
		public static EnableAI CreateFromSetValue([Nullable(2)] EnableAI_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableAI
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x0012AA5E File Offset: 0x00128C5E
		public EnableAI_SetValue ToSetValue()
		{
			return new EnableAI_SetValue
			{
				EntityIds = this.EntityIds,
				IsEnable = this.IsEnable
			};
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x06007C1D RID: 31773 RVA: 0x0012AA7D File Offset: 0x00128C7D
		// (set) Token: 0x06007C1E RID: 31774 RVA: 0x0012AAA4 File Offset: 0x00128CA4
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				EnableAI_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x06007C1F RID: 31775 RVA: 0x0012AAB2 File Offset: 0x00128CB2
		// (set) Token: 0x06007C20 RID: 31776 RVA: 0x0012AADD File Offset: 0x00128CDD
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

		// Token: 0x04004C46 RID: 19526
		[Nullable(2)]
		protected new EnableAI FbInstance;

		// Token: 0x04004C47 RID: 19527
		[Nullable(2)]
		protected EnableAI_SetValue PocoInterface;
	}
}
