using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000260 RID: 608
	public class ICheckGearHit
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x0002C2BC File Offset: 0x0002A4BC
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

		// Token: 0x06000A8F RID: 2703 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
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

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002C307 File Offset: 0x0002A507
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

		// Token: 0x06000A91 RID: 2705 RVA: 0x0002C31A File Offset: 0x0002A51A
		public ICheckGearHit_SetValue ToSetValue()
		{
			return new ICheckGearHit_SetValue
			{
				HitIndex = this.HitIndex,
				AffectIndex = this.AffectIndex,
				AffectType = this.AffectType
			};
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002C345 File Offset: 0x0002A545
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x0002C370 File Offset: 0x0002A570
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002C37E File Offset: 0x0002A57E
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0002C3A5 File Offset: 0x0002A5A5
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002C3B3 File Offset: 0x0002A5B3
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0002C3DE File Offset: 0x0002A5DE
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

		// Token: 0x04000ABF RID: 2751
		[Nullable(2)]
		protected ICheckGearHit FbInstance;

		// Token: 0x04000AC0 RID: 2752
		[Nullable(2)]
		protected ICheckGearHit_SetValue PocoInterface;
	}
}
