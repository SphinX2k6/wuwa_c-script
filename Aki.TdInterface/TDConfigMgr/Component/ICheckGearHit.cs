using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000239 RID: 569
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckGearHit
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x0002AAFC File Offset: 0x00028CFC
		private ICheckGearHit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckGearHit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckGearHit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckGearHit_SetValue());
			}
			return result;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0002AB34 File Offset: 0x00028D34
		public static ICheckGearHit Create([Nullable(2)] ICheckGearHit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckGearHit
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0002AB47 File Offset: 0x00028D47
		public static ICheckGearHit CreateFromSetValue([Nullable(2)] ICheckGearHit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckGearHit
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002AB5A File Offset: 0x00028D5A
		public ICheckGearHit_SetValue ToSetValue()
		{
			return new ICheckGearHit_SetValue
			{
				HitIndex = this.HitIndex,
				AffectIndex = this.AffectIndex,
				AffectType = this.AffectType
			};
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002AB85 File Offset: 0x00028D85
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		public virtual int HitIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HitIndex;
			}
			set
			{
				this.GetOrCreatePoco().HitIndex = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002ABBE File Offset: 0x00028DBE
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x0002ABE5 File Offset: 0x00028DE5
		public virtual List<int> AffectIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AffectIndex;
				}
				ICheckGearHit_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AffectIndex;
			}
			set
			{
				this.GetOrCreatePoco().AffectIndex = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002ABF3 File Offset: 0x00028DF3
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x0002AC1E File Offset: 0x00028E1E
		public virtual EGearHitAffectType AffectType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AffectType;
				}
				if (this.PocoInterface == null)
				{
					return EGearHitAffectType.ChangeNextState;
				}
				return this.PocoInterface.AffectType;
			}
			set
			{
				this.GetOrCreatePoco().AffectType = value;
			}
		}

		// Token: 0x04000A35 RID: 2613
		[Nullable(2)]
		protected ICheckGearHit FbInstance;

		// Token: 0x04000A36 RID: 2614
		[Nullable(2)]
		protected ICheckGearHit_SetValue PocoInterface;
	}
}
