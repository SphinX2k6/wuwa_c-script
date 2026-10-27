using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215C RID: 8540
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetEntity : ActionParams
	{
		// Token: 0x0600BBEA RID: 48106 RVA: 0x001B1968 File Offset: 0x001AFB68
		private ResetEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBEB RID: 48107 RVA: 0x001B19A0 File Offset: 0x001AFBA0
		public static ResetEntity Create([Nullable(2)] ResetEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBEC RID: 48108 RVA: 0x001B19B3 File Offset: 0x001AFBB3
		public static ResetEntity CreateFromSetValue([Nullable(2)] ResetEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x001B19C6 File Offset: 0x001AFBC6
		public ResetEntity_SetValue ToSetValue()
		{
			return new ResetEntity_SetValue
			{
				ResetEntityConfig = this.ResetEntityConfig
			};
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600BBEE RID: 48110 RVA: 0x001B19D9 File Offset: 0x001AFBD9
		// (set) Token: 0x0600BBEF RID: 48111 RVA: 0x001B1A00 File Offset: 0x001AFC00
		public virtual IResetEntityConfig ResetEntityConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetEntityConfig;
				}
				ResetEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetEntityConfig;
			}
			set
			{
				this.GetOrCreatePoco().ResetEntityConfig = value;
			}
		}

		// Token: 0x0400704C RID: 28748
		[Nullable(2)]
		protected new ResetEntity FbInstance;

		// Token: 0x0400704D RID: 28749
		[Nullable(2)]
		protected ResetEntity_SetValue PocoInterface;
	}
}
