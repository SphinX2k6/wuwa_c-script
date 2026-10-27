using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002CD RID: 717
	[NullableContext(1)]
	[Nullable(0)]
	public class IDoubleViewBossStateViewStyle : IBossStateViewStyle
	{
		// Token: 0x06000D81 RID: 3457 RVA: 0x00032400 File Offset: 0x00030600
		private IDoubleViewBossStateViewStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDoubleViewBossStateViewStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDoubleViewBossStateViewStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDoubleViewBossStateViewStyle_SetValue());
			}
			return result;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00032438 File Offset: 0x00030638
		public static IDoubleViewBossStateViewStyle Create([Nullable(2)] IDoubleViewBossStateViewStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDoubleViewBossStateViewStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0003244B File Offset: 0x0003064B
		public static IDoubleViewBossStateViewStyle CreateFromSetValue([Nullable(2)] IDoubleViewBossStateViewStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDoubleViewBossStateViewStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0003245E File Offset: 0x0003065E
		public new IDoubleViewBossStateViewStyle_SetValue ToSetValue()
		{
			return new IDoubleViewBossStateViewStyle_SetValue
			{
				Type = this.Type,
				Slot = this.Slot,
				MainStateTextTarget = this.MainStateTextTarget,
				BindMonsterEntityId = this.BindMonsterEntityId
			};
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00032495 File Offset: 0x00030695
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x000324C0 File Offset: 0x000306C0
		public override EBossStateViewStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBossStateViewStyle.DoubleView;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000324CE File Offset: 0x000306CE
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x000324F9 File Offset: 0x000306F9
		public virtual EDoubleViewSlot Slot
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Slot;
				}
				if (this.PocoInterface == null)
				{
					return EDoubleViewSlot.Left;
				}
				return this.PocoInterface.Slot;
			}
			set
			{
				this.GetOrCreatePoco().Slot = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00032508 File Offset: 0x00030708
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00032569 File Offset: 0x00030769
		[Nullable(2)]
		public virtual IMarkMainStateTextTarget MainStateTextTarget
		{
			[NullableContext(2)]
			get
			{
				if (this._MainStateTextTargetInited)
				{
					return this._MainStateTextTargetCache;
				}
				this._MainStateTextTargetInited = true;
				if (this.FbInstance != null)
				{
					this._MainStateTextTargetCache = IMarkMainStateTextTarget.Create(this.FbInstance.MainStateTextTarget);
				}
				else
				{
					IDoubleViewBossStateViewStyle_SetValue pocoInterface = this.PocoInterface;
					this._MainStateTextTargetCache = ((pocoInterface != null) ? pocoInterface.MainStateTextTarget : null);
				}
				return this._MainStateTextTargetCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MainStateTextTarget = value;
				this._MainStateTextTargetInited = false;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00032580 File Offset: 0x00030780
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x000325BA File Offset: 0x000307BA
		public virtual int? BindMonsterEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindMonsterEntityId;
				}
				IDoubleViewBossStateViewStyle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BindMonsterEntityId;
			}
			set
			{
				this.GetOrCreatePoco().BindMonsterEntityId = value;
			}
		}

		// Token: 0x04000C37 RID: 3127
		[Nullable(2)]
		protected new IDoubleViewBossStateViewStyle FbInstance;

		// Token: 0x04000C38 RID: 3128
		[Nullable(2)]
		protected new IDoubleViewBossStateViewStyle_SetValue PocoInterface;

		// Token: 0x04000C39 RID: 3129
		private IMarkMainStateTextTarget _MainStateTextTargetCache;

		// Token: 0x04000C3A RID: 3130
		private bool _MainStateTextTargetInited;
	}
}
