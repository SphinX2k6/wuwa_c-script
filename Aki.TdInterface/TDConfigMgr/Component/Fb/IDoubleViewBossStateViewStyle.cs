using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE4 RID: 3300
	[NullableContext(2)]
	[Nullable(0)]
	public class IDoubleViewBossStateViewStyle : IBossStateViewStyle
	{
		// Token: 0x06004B4F RID: 19279 RVA: 0x000BCEF5 File Offset: 0x000BB0F5
		[NullableContext(0)]
		public static IDoubleViewBossStateViewStyle Create(IDoubleViewBossStateViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDoubleViewBossStateViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x000BCF14 File Offset: 0x000BB114
		public override EBossStateViewStyle Type
		{
			get
			{
				return (EBossStateViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x000BCF21 File Offset: 0x000BB121
		public virtual EDoubleViewSlot Slot
		{
			get
			{
				return (EDoubleViewSlot)this.Instance.Slot;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x000BCF2E File Offset: 0x000BB12E
		public virtual IMarkMainStateTextTarget MainStateTextTarget
		{
			get
			{
				if (this._MainStateTextTargetInited)
				{
					return this._MainStateTextTargetCache;
				}
				this._MainStateTextTargetInited = true;
				this._MainStateTextTargetCache = IMarkMainStateTextTarget.Create(this.Instance.MainStateTextTarget);
				return this._MainStateTextTargetCache;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06004B53 RID: 19283 RVA: 0x000BCF64 File Offset: 0x000BB164
		public virtual int? BindMonsterEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.BindMonsterEntityId);
			}
		}

		// Token: 0x04002A95 RID: 10901
		private IDoubleViewBossStateViewStyle Instance;

		// Token: 0x04002A96 RID: 10902
		private IMarkMainStateTextTarget _MainStateTextTargetCache;

		// Token: 0x04002A97 RID: 10903
		private bool _MainStateTextTargetInited;
	}
}
