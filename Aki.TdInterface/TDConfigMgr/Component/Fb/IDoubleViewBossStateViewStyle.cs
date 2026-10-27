using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C14 RID: 3092
	[NullableContext(2)]
	[Nullable(0)]
	public class IDoubleViewBossStateViewStyle : IBossStateViewStyle
	{
		// Token: 0x060046EC RID: 18156 RVA: 0x000B2D29 File Offset: 0x000B0F29
		[NullableContext(1)]
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

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x000B2D48 File Offset: 0x000B0F48
		public override EBossStateViewStyle Type
		{
			get
			{
				return (EBossStateViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x000B2D55 File Offset: 0x000B0F55
		public virtual EDoubleViewSlot Slot
		{
			get
			{
				return (EDoubleViewSlot)this.Instance.Slot;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x000B2D62 File Offset: 0x000B0F62
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

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x000B2D98 File Offset: 0x000B0F98
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

		// Token: 0x04002849 RID: 10313
		private IDoubleViewBossStateViewStyle Instance;

		// Token: 0x0400284A RID: 10314
		private IMarkMainStateTextTarget _MainStateTextTargetCache;

		// Token: 0x0400284B RID: 10315
		private bool _MainStateTextTargetInited;
	}
}
