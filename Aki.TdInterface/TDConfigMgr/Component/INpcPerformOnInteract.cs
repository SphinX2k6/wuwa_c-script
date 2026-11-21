using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005CD RID: 1485
	public class INpcPerformOnInteract
	{
		// Token: 0x06001E4A RID: 7754 RVA: 0x00055E80 File Offset: 0x00054080
		private INpcPerformOnInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcPerformOnInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcPerformOnInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcPerformOnInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00055EB8 File Offset: 0x000540B8
		public static INpcPerformOnInteract Create([Nullable(2)] INpcPerformOnInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformOnInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00055ECB File Offset: 0x000540CB
		public static INpcPerformOnInteract CreateFromSetValue([Nullable(2)] INpcPerformOnInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcPerformOnInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00055EDE File Offset: 0x000540DE
		public INpcPerformOnInteract_SetValue ToSetValue()
		{
			return new INpcPerformOnInteract_SetValue
			{
				Montage = this.Montage,
				NotInterruptMontageWhenFinishedInteract = this.NotInterruptMontageWhenFinishedInteract
			};
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00055EFD File Offset: 0x000540FD
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00055F28 File Offset: 0x00054128
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Montage;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00055F38 File Offset: 0x00054138
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00055F72 File Offset: 0x00054172
		public virtual bool? NotInterruptMontageWhenFinishedInteract
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NotInterruptMontageWhenFinishedInteract;
				}
				INpcPerformOnInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NotInterruptMontageWhenFinishedInteract;
			}
			set
			{
				this.GetOrCreatePoco().NotInterruptMontageWhenFinishedInteract = value;
			}
		}

		// Token: 0x040015A1 RID: 5537
		[Nullable(2)]
		protected INpcPerformOnInteract FbInstance;

		// Token: 0x040015A2 RID: 5538
		[Nullable(2)]
		protected INpcPerformOnInteract_SetValue PocoInterface;
	}
}
