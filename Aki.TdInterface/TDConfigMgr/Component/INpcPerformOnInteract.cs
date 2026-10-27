using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000566 RID: 1382
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformOnInteract
	{
		// Token: 0x06001C4E RID: 7246 RVA: 0x000510C4 File Offset: 0x0004F2C4
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

		// Token: 0x06001C4F RID: 7247 RVA: 0x000510FC File Offset: 0x0004F2FC
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

		// Token: 0x06001C50 RID: 7248 RVA: 0x0005110F File Offset: 0x0004F30F
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

		// Token: 0x06001C51 RID: 7249 RVA: 0x00051122 File Offset: 0x0004F322
		public INpcPerformOnInteract_SetValue ToSetValue()
		{
			return new INpcPerformOnInteract_SetValue
			{
				Montage = this.Montage,
				NotInterruptMontageWhenFinishedInteract = this.NotInterruptMontageWhenFinishedInteract
			};
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00051141 File Offset: 0x0004F341
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x0005116C File Offset: 0x0004F36C
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

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0005117C File Offset: 0x0004F37C
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x000511B6 File Offset: 0x0004F3B6
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

		// Token: 0x04001437 RID: 5175
		[Nullable(2)]
		protected INpcPerformOnInteract FbInstance;

		// Token: 0x04001438 RID: 5176
		[Nullable(2)]
		protected INpcPerformOnInteract_SetValue PocoInterface;
	}
}
